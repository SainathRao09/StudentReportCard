using System.ComponentModel.DataAnnotations;

namespace StudentReportCard.Model.Entities
{
    public class Exam
    {
        [Key]
        public int Exam_Id { get; set; }
        public string Exam_Name { get; set; }
        public List<ExamSubject> Exam_Subjects { get; set;}
    }
}
