using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using task6.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.VisualBasic;
using task6.DTOs;

namespace task6.Controllers
{
    [Route("api/enrollments")]
    [ApiController]
    [Authorize(Roles = "Employee")]

    public class EnrollmentsController : ControllerBase
    {
        private IStudentsDbService _service;

        public EnrollmentsController(IStudentsDbService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult EnrollStudent(EnrollStudentRequest request)
        {
            var response = _service.EnrollStudent(request);

            if (response.IndexNumber == null)
            {
                return BadRequest(response.Message);
            }

            return CreatedAtAction(nameof(EnrollStudent), response);
        }

        [HttpPost("promotions")]
        public IActionResult PromoteStudents(PromoteStudentsRequest request)
        {
            var response = _service.PromoteStudents(request);

            if (response.IdEnrollment == 0)
            {
                return NotFound(response.Message);
            }

            return CreatedAtAction(nameof(PromoteStudents), response);
        }
    }