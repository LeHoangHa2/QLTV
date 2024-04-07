using System;
using System.Linq;
using System.Web.Mvc;
using Library_Hutech.Models;
using Microsoft.AspNet.Identity;
using System.Security.Claims;


namespace Library_Hutech.Controllers
{
    public class ChangePasswordController : Controller
    {
        private Model1 db = new Model1();

        // GET: ChangePassword
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid) // Kiểm tra xem dữ liệu nhập vào có hợp lệ không
            {
                // Kiểm tra xem User.Identity có khác null không
                if (User.Identity != null && User.Identity.IsAuthenticated)
                {
                    // Lấy ID của người dùng hiện tại từ thông tin xác thực người dùng
                    string userId = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.NameIdentifier)?.Value;

                    if (!string.IsNullOrEmpty(userId))
                    {
                        // Lấy thông tin người dùng từ cơ sở dữ liệu
                        int intUserId = Convert.ToInt32(userId);
                        User user = db.User.FirstOrDefault(u => u.ID == intUserId);

                        // Kiểm tra mật khẩu cũ và thực hiện việc thay đổi mật khẩu
                        if (user != null && user.Password == model.currentPassword)
                        {
                            if (model.newPassword == model.confirmPassword)
                            {
                                user.Password = model.newPassword;
                                db.SaveChanges();
                                return RedirectToAction("Login", "Home");
                            }
                            else
                            {
                                ModelState.AddModelError("confirmPassword", "New password and confirm password do not match.");
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("currentPassword", "Current password is incorrect.");
                        }
                    }
                }
            }

            return View("Index");
        }
    }
}
