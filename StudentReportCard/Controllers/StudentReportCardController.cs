using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentReportCard.Data;
using StudentReportCard.Model;

namespace StudentReportCard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentReportCardController : ControllerBase
    {
        private readonly AppDbContext _dbcontext;
        public StudentReportCardController(AppDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        [HttpPost("StudentReportCard")]
        public async Task<ActionResult<List<StudentReportCardDto>>> GetReportCards([FromBody] List<int> studIds)
        {
            if (studIds.Count == 0)
            {
                return BadRequest("No data found in list");
            }
            else
            {
                var students = await _dbcontext.students
                    .Where(s => studIds.Contains(s.Student_Id))
                    .Include(s => s.Class)
                    .Include(s => s.Section)
                    .Include(s => s.AcademicYear)
                    .Include(s => s.students)
                        .ThenInclude(sm => sm.ExamSubject)
                            .ThenInclude(es => es.Exam)
                    .Include(s => s.students)
                        .ThenInclude(sm => sm.ExamSubject)
                            .ThenInclude(es => es.Subject)
                    .ToListAsync();

                var studentreportcard = students.Select(s => new StudentReportCardDto
                {
                    StudentId = s.Student_Id,
                    StudentName = s.Student_Name,
                    ClassName = s.Class.Class_Name,
                    SectionName = s.Section.Section_Name,
                    AcademicYear = s.AcademicYear.Year,
                    Exams = s.students
                        .GroupBy(sm => sm.ExamSubject.Exam)
                        .Select(g => new ExamReportDto
                        {
                            ExamId = g.Key.Exam_Id,
                            ExamName = g.Key.Exam_Name,
                            Subjects = g.Select(sm => new SubjectMarkDto
                            {
                                SubjectId = sm.ExamSubject.SubjectId,
                                SubjectName = sm.ExamSubject.Subject.Subject_Name,
                                MarksObtained = sm.MarksObtained,
                                MaxMarks = sm.ExamSubject.MaxMarks
                            }).ToList(),
                            TotalMarksObtained = g.Sum(sm => sm.MarksObtained),
                            TotalMaxMarks = g.Sum(sm => sm.ExamSubject.MaxMarks),
                            Percentage = Math.Round(
                                (double)g.Sum(sm => sm.MarksObtained) / g.Sum(sm => sm.ExamSubject.MaxMarks) * 100, 2)
                        }).ToList()
                }).ToList();

                return Ok(studentreportcard);
            }
        }
    }
}
