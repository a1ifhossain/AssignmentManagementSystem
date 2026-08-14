using AssignmentManagementSystem.Data;
using AssignmentManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace AssignmentManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class SubmissionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SubmissionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Submissions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Submission>>> GetSubmissions()
        {
            return await _context.Submissions
                .Include(s => s.Student)
                .Include(s => s.Assignment)
                .ToListAsync();
        }

        // GET: api/Submissions/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Submission>> GetSubmission(int id)
        {
            var submission = await _context.Submissions
                .Include(s => s.Student)
                .Include(s => s.Assignment)
                .FirstOrDefaultAsync(s => s.Id == id);

            if (submission == null)
                return NotFound();

            return submission;
        }

        // POST: api/Submissions
        // Only Student can submit
        [HttpPost]
        [Authorize(Roles = "Student")]
        public async Task<ActionResult<Submission>> CreateSubmission(
            Submission submission)
        {
            // Get logged-in student's ID from JWT
            var studentId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (studentId == null)
                return Unauthorized();

            // Set StudentId automatically
            submission.StudentId = int.Parse(studentId);

            // Set submission information automatically
            submission.SubmittedAt = DateTime.UtcNow;
            submission.Status = "Submitted";

            _context.Submissions.Add(submission);

            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetSubmission),
                new { id = submission.Id },
                submission
            );
        }

        // PUT: api/Submissions/1
        // Only Teacher can update/grade
        [HttpPut("{id}")]
        [Authorize(Roles = "Teacher")]
        public async Task<IActionResult> UpdateSubmission(
            int id,
            Submission submission)
        {
            if (id != submission.Id)
                return BadRequest();

            var existingSubmission =
                await _context.Submissions.FindAsync(id);

            if (existingSubmission == null)
                return NotFound();

            existingSubmission.Answer = submission.Answer;
            existingSubmission.Status = submission.Status;
            existingSubmission.Marks = submission.Marks;
            existingSubmission.Feedback = submission.Feedback;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Submissions/1
        // Only Teacher can delete
        [HttpDelete("{id}")]
        [Authorize(Roles = "Teacher")]
        public async Task<IActionResult> DeleteSubmission(int id)
        {
            var submission =
                await _context.Submissions.FindAsync(id);

            if (submission == null)
                return NotFound();

            _context.Submissions.Remove(submission);

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}