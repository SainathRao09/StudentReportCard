using System.ComponentModel.DataAnnotations;

namespace StudentReportCard.Model.Entities
{
    public class Section
    {
        [Key]
        public int Section_Id { get; set; }
        public string Section_Name { get; set; }
    }
}
