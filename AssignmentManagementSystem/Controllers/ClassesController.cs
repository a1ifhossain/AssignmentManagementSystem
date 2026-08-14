using AssignmentManagementSystem.Data;
using AssignmentManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AssignmentManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ClassesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ClassesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Classes
        // Any logged-in user can view classes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Class>>> GetClasses()
        {
            return await _context.Classes.ToListAsync();
        }

        // GET: api/Classes/1
        // Any logged-in user can view a class
        [HttpGet("{id}")]
        public async Task<ActionResult<Class>> GetClass(int id)
        {
            var classItem = await _context.Classes.FindAsync(id);

            if (classItem == null)
                return NotFound();

            return classItem;
        }

        // POST: api/Classes
        // Only Teacher can create a class
        [HttpPost]
        [Authorize(Roles = "Teacher")]
        public async Task<ActionResult<Class>> CreateClass(Class classItem)
        {
            _context.Classes.Add(classItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetClass),
                new { id = classItem.Id },
                classItem
            );
        }
    }
}