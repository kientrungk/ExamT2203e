namespace Exam.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string? SubjectName { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? ExamDate { get; set;}
        public int Duration { get; set; }
        public string? ClassName { get; set; }
        public string? FacultyName { get; set;}

        public Faculty? Faculty { get; set; }
        public Subject? Subject { get; set; }
        public ClassRoom? ClassRoom { get; set;}
    }
}
