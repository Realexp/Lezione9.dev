using dbacasas.Entity;
using Microsoft.Identity.Client;

namespace dbacasas.DTO
{
    public class Mapper
    {
        public StudentDTO MapEntityToDTO(Student student)
        {
            return new StudentDTO()
            {
                StudentID = student.StudentID,
                StudentName = student.StudentName,
                StudentSurname = student.StudentSurname,
                ExamGrade = student.Exams?.Sum(s => s.ExamGrade) ?? 0,
                Subjects = student.Exams?.ConvertAll(MapExamToSubjectDTO)
            };
        }
        public Student MapDTOtoEntity(StudentDTO student) {
            return new Student() {
                StudentID = student.StudentID, 
                StudentName = student.StudentName, 
            };
        }
        public SubjectDTO MapEntityToDTO(Subject subject)
        {
            return new SubjectDTO()
            {
                SubjectID = subject.SubjectID,
                SubjectName = subject.SubjectName,
                SubjectCredits = subject.SubjectCredits,
                ExamGrade = subject.Exams?.Sum(s => s.ExamGrade) ?? 0,
                Students = subject.Exams?.ConvertAll(MapExamToStudentDTO)
            };
        }
        public Subject MapDTOtoEntity(SubjectDTO subject) {
            return new Subject()
            {
                SubjectID = subject.SubjectID,
                SubjectName = subject.SubjectName,
                SubjectCredits = subject.SubjectCredits,

            };
        }

        public StudentDTO MapExamToStudentDTO(Exam entity)
        {
            return new StudentDTO()
            {
                StudentID = entity.StudentID,
                StudentName = entity.Student?.StudentName ?? "Not Provvided",
                StudentSurname = entity.Student?.StudentSurname ?? "Not Provvided",
                ExamGrade = entity.ExamGrade
            };
        }
        public SubjectDTO MapExamToSubjectDTO(Exam entity)
        {
            return new SubjectDTO()
            {
                SubjectID = entity.SubjectID,
                SubjectName = entity.Subject?.SubjectName ?? "Not Providded",
                SubjectCredits = entity.Subject?.SubjectCredits ?? 0,
                ExamGrade = entity.ExamGrade
            };
        }

    }
}
