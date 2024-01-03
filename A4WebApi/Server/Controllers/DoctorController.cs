using A4WebApi.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace A4WebApi.Server.Controllers
{
    [Route("api/v2/[controller]")]
    [ApiController]

    public class DoctorController : Controller
    {

        private readonly AppDbContext _appDbContext;

       // public IActionResult Index()
       // {
       //     return View();
       // }

        public DoctorController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet("/pass")]
        public async Task<IList<Doctor>> GetDoctors()
        {
            try
            {
                var _data = await _appDbContext.Doctors.ToListAsync();
                return _data;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        //GET api/<StudentController>/5
        [HttpGet("{id}")]
        public async Task<Doctor> GetDoctor(int id)
        {
            try
            {

                var _data = await _appDbContext.Doctors.FindAsync(id);
                return _data;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        [HttpPost("/savedoctor")]
        public async Task<IActionResult> SaveDoctor([FromBody] Doctor doctor)
        {
            try
            {
                if (_appDbContext.Doctors == null)
                {
                    return Problem("Entity set 'AppDbContext.Employee'  is null.");
                }

                if(doctor != null)
                {
                    _appDbContext.Add(doctor);
                    await _appDbContext.SaveChangesAsync();

                    return Ok(doctor.DoctorId);
                }

                
            }
            catch
            {
                return BadRequest();
            }
            return NoContent();
        }

        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{

        //}

    }
}
