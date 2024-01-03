using A4WebApi.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace A4WebApi.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class StudentController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public StudentController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet("/pass")]
        public async Task<IList<Student>> GetStudents()
        {
            try
            {
                var _data = await _appDbContext.Students.ToListAsync();
                return _data;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        //GET api/<StudentController>/5
        [HttpGet("{id}")]
        public async Task<Student> GetStudent(int id)
        {
            try
            {

                var _data = await _appDbContext.Students.FindAsync(id);
                return _data;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

    }
}
