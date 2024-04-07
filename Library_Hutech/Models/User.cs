namespace Library_Hutech.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int ID { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        public DateTime? TimeUpdate { get; set; }

        public DateTime? TimeCreate { get; set; }

        [StringLength(50)]
        public string Password { get; set; }
    }
}
