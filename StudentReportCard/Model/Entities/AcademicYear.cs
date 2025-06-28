using System.ComponentModel.DataAnnotations;

namespace StudentReportCard.Model.Entities
{
    public class AcademicYear
    {
        [Key]
        public int AcademicYear_Id { get; set; }
        public string Year { get; set; }
    }
}
