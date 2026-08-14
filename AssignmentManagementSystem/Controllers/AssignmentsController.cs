using AssignmentManagementSystem.Data;
using AssignmentManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace AssignmentManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class AssignmentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AssignmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Assignments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Assignment>>> GetAssignments()
        {
            return await _context.Assignments.ToListAsync();
        }

        // GET: api/Assignments/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Assignment>> GetAssignment(int id)
        {
            var assignment = await _context.Assignments.FindAsync(id);

            if (assignment == null)
                return NotFound();

            return assignment;
        }

        // POST: api/Assignments
        [HttpPost]
        [Authorize(Roles = "Teacher")]
        public async Task<ActionResult<Assignment>> CreateAssignment(Assignment assignment)
        {
            _context.Assignments.Add(assignment);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
    nameof(GetAssignment),
    new { id = assignment.Id },
    assignment
);
        }

        // PUT: api/Assignments/1
        [HttpPut("{id}")]
        [Authorize(Roles = "Teacher")]
        public async Task<IActionResult> UpdateAssignment(int id, Assignment assignment)
        {
            if (id != assignment.Id)
                return BadRequest();

            var existingAssignment = await _context.Assignments.FindAsync(id);

            if (existingAssignment == null)
                return NotFound();

            existingAssignment.Title = assignment.Title;
            existingAssignment.Description = assignment.Description;
            existingAssignment.Deadline = assignment.Deadline;
            existingAssignment.MaxMarks = assignment.MaxMarks;
            existingAssignment.Status = assignment.Status;
            existingAssignment.TeacherId = assignment.TeacherId;
            existingAssignment.ClassId = assignment.ClassId;
            existingAssignment.SubjectId = assignment.SubjectId;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Assignments/1
        [HttpDelete("{id}")]
        [Authorize(Roles = "Teacher")]
        public async Task<IActionResult> DeleteAssignment(int id)
        {
            var assignment = await _context.Assignments.FindAsync(id);

            if (assignment == null)
                return NotFound();

            _context.Assignments.Remove(assignment);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}