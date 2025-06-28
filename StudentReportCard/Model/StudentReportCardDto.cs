namespace StudentReportCard.Model
{
    public class StudentReportCardDto
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string ClassName { get; set; }
        public string SectionName { get; set; }
        public string AcademicYear { get; set; }

        public List<ExamReportDto> Exams { get; set; }
    }
}
