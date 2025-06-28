using System.ComponentModel.DataAnnotations;

namespace StudentReportCard.Model.Entities
{
    public class StudentMark
    {
        [Key]
        public int StudentMark_Id { get; set; }
        public int StudentId { get; set; }
        public int ExamSubjectId { get; set; }
        public int MarksObtained { get; set; }

        public Student Student { get; set; }
        public ExamSubject ExamSubject { get; set; }
    }
}
