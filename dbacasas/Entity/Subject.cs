namespace dbacasas.Entity
{
    public class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public int SubjectCredits { get; set; }
        public List<Exam> Exams { get; set; }
    }
}
