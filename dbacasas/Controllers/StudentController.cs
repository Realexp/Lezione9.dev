using dbacasas.DTO;
using dbacasas.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dbacasas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly Mapper _mapper;
        public readonly UniversityDbContext _ctx;

        public StudentController(Mapper mapper, UniversityDbContext ctx)
        {
            _mapper = mapper;
            _ctx = ctx;
        }

        [HttpGet]
        public IActionResult getAll()
        {
            return Ok(_ctx.Students.ToList().ConvertAll(_mapper.MapEntityToDTO));
        }

        [HttpGet("{ID}")]
        public IActionResult getOne(int ID)
        {
            var s = _ctx.Students.Find(ID);
            if (s == null)
                return NotFound("Try a different ID");
            return Ok(s);
        }

        [HttpGet("{ID}/Exams")]
        public IActionResult getExam(int ID)
        {
            var s = _ctx.Students.Include(s => s.Exams).ThenInclude(s => s.Subject).SingleOrDefault(s => s.StudentID == ID);
            if (s == null)
                return NotFound("Try a different ID");
            StudentDTO dto = _mapper.MapEntityToDTO(s);
            return Ok(dto);
        }

        [HttpPost]
        public IActionResult postStudent([FromBody] StudentDTO entityDTO)
        {
            var entity = _mapper.MapDTOtoEntity(entityDTO);
            _ctx.Students.Add(entity);
            _ctx.SaveChanges();
            return Created("", entity);
        }
    }
}
