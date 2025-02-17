using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace dbacasas.Entity
{
    [PrimaryKey("StudentID", "SubjectID")]
    public class Exam
    {
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public int ExamGrade { get; set; }

        [ForeignKey("StudentID")]
        public Student? Student { get; set; }

        [ForeignKey("SubjectID")]
        public Subject? Subject { get; set; }
    }
}
