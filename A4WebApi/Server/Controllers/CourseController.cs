using A4WebApi.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace A4WebApi.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public CourseController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet("/pass")]
        public async Task<IList<Course>> GetCourses()
        {
            try
            {
                var _data = await _appDbContext.Courses.ToListAsync();
                return _data;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        //GET api/<StudentController>/5
        [HttpGet("{id}")]
        public async Task<Course> GetCourse(string id)
        {
            try
            {

                var _data = await _appDbContext.Courses.FindAsync(id);
                return _data;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

    }
}
