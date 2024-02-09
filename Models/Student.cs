using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppPracticeProject1._13.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
         public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public string? Subject { get; set; }
        public double Mark { get; set; }
    }
}
