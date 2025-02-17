using dbacasas.Entity;
using System.ComponentModel.DataAnnotations;

namespace dbacasas.DTO
{
    public class StudentDTO
    {
        public int StudentID { get; set; }
        [Required(ErrorMessage = "Insert the right StudentName")]
        public required string StudentName { get; set; }
        [Required(ErrorMessage = "Insert the right StudentSurname")]
        public required string StudentSurname { get; set; }
        public int ExamGrade { get; set; } = 0;

        public List<SubjectDTO>? Subjects { get; set; }
    }
}
