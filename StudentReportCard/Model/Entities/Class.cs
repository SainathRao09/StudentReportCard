using System.ComponentModel.DataAnnotations;

namespace StudentReportCard.Model.Entities
{
    public class Class
    {
        [Key]
        public int Class_Id { get; set; }
        public string Class_Name { get; set; }
    }
}
