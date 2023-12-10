using ATFAL360.DTOs;
using ATFAL360.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ATFAL360.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtfalMemberController : ControllerBase
    {
        private readonly IAtfalMemberServices _atfalMemberService;

        public AtfalMemberController(IAtfalMemberServices atfalMemberService)
        {
            _atfalMemberService = atfalMemberService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var atfalMember = _atfalMemberService.GetAllAtfalMember();
            return Ok(atfalMember);
        }

        [HttpPost]
        public IActionResult Create(CreateAtfalMemberRequestModel model)
        {
            _atfalMemberService.CreateAtfalMember(model);
            return Ok("Index");
        }

        [HttpGet("{id}", Name = "GetById")]
        public IActionResult GetById(int id)
        {
            var atfalMember = _atfalMemberService.GetAtfalMember(id);
            if (atfalMember == null)
            {
                return NotFound();
            }
            return Ok(atfalMember);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateAtfalMemberRequestModel model)
        {
            _atfalMemberService.UpdateAtfalMember(id, model);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var atfal = _atfalMemberService.GetAtfalMember(id);
            if (atfal == null)
            {
                return NotFound();
            }
            return Ok(atfal);
        }

        [HttpDelete("confirm/{id}")] // Unique route for DeleteConfirmed
        public IActionResult DeleteConfirmed(int id)
        {
            _atfalMemberService.DeleteAtfalMember(id);
            return NoContent();
        }
    }
}
