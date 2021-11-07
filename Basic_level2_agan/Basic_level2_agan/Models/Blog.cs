using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Basic_level2_agan.Models
{
    public class Blog
    {
        public int id { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string tin { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string loai { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string trangThai { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string viTri { get; set; }
        [Required(ErrorMessage="Enter the issue date")]
        [DataType(DataType.Date)]
        public DateTime ngayPublic { get; set; }
    }
    public class BlogDBContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
    }
    public class place
    {
        public int id { get; set; }
        public string name { get; set; }
        public place() { }
        public place(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}