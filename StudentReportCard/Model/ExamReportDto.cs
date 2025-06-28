namespace StudentReportCard.Model
{
    public class ExamReportDto
    {
        public int ExamId { get; set; }
        public string ExamName { get; set; }

        public List<SubjectMarkDto> Subjects { get; set; }

        public int TotalMarksObtained { get; set; }
        public int TotalMaxMarks { get; set; }
        public double Percentage { get; set; }
    }
}
