using System.ComponentModel.DataAnnotations;

namespace StudentReportCard.Model.Entities
{
    public class Student
    {
        [Key]
        public int Student_Id { get; set; }
        public string Student_Name { get; set; }
        public int ClassId { get; set; }
        public int SectionId { get; set; }
        public int AcademicYearId { get; set; }
        public Class Class { get; set; }
        public Section Section { get; set; }
        public AcademicYear AcademicYear { get; set; }

        public List<StudentMark> students { get; set; }
    }
}
