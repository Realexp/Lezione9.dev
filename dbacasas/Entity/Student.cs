namespace dbacasas.Entity
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public List<Exam> Exams { get; set; }
    }
}
