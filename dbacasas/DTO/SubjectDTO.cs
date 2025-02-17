using dbacasas.Entity;
using System.ComponentModel.DataAnnotations;

namespace dbacasas.DTO
{
    public class SubjectDTO
    {
        public int SubjectID { get; set; }
        [Required(ErrorMessage = "Insert a correct subject Name")]
        public required string SubjectName { get; set; }
        [Required(ErrorMessage = "Insert a correct subject Credits")]
        public required int SubjectCredits { get; set; }
        public required int ExamGrade { get; set; }
        public List<StudentDTO>? Students { get; set; }
    }
}
