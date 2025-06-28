using Microsoft.EntityFrameworkCore;
using StudentReportCard.Model.Entities;

namespace StudentReportCard.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Class> Class { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<AcademicYear> AcademicYear { get; set; }
        public DbSet<Exam> exams { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<ExamSubject> examSubjects { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<StudentMark> studentMarks { get; set; }
    }
}
