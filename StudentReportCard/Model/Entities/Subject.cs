using System.ComponentModel.DataAnnotations;

namespace StudentReportCard.Model.Entities
{
    public class Subject
    {
        [Key]
        public int Subject_Id { get; set; }
        public string Subject_Name { get; set; }
        public List<ExamSubject> ExamSubjects { get; set; }
    }
}
