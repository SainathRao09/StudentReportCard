using System.ComponentModel.DataAnnotations;

namespace StudentReportCard.Model.Entities
{
    public class ExamSubject
    {
        [Key]
        public int ExamSubject_Id { get; set; }
        public int ExamId { get; set; }
        public int SubjectId { get; set; }
        public int MaxMarks { get; set; }
        public Exam Exam { get; set; }
        public Subject Subject { get; set; }
    }
}
