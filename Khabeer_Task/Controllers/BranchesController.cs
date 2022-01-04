using Khabeer_Task_Contract;
using Khabeer_Task_DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Khabeer_Task.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BranchesController : ControllerBase
    {
        private readonly IRepositoryManager _context;
        public BranchesController(IRepositoryManager context)
        {
            _context = context;

        }
        [HttpPost]
        [Route("GetBranchesTable")]
        public async Task<IActionResult> GetBranchesTable()
        {
            try
            {
                var _GetBranchesTable = await _context.UserRepository.GetBranchesTable();
                if (_GetBranchesTable == null) return NotFound();
                return Ok(_GetBranchesTable);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
        [HttpPost]
        [Route("InsertnewBranch")]
        public async Task<IActionResult> InsertNewBranch([FromBody] Users user)
        {
            try
            {
                var _InsertnewBranch = await _context.UserRepository.InsertnewBranch(user);
                if (_InsertnewBranch == null) return NotFound();
                return Ok(_InsertnewBranch);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut]
        [Route("EditBranch")]
        public async Task<IActionResult> EditBranch([FromBody] Users user)
        {
            try
            {

                var _EditBranch = await _context.UserRepository.EditBranch(user);
                if (_EditBranch == null) return NotFound();
                return Ok(_EditBranch);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("DeleteBranch")]
        public async Task<IActionResult> DeleteBranch([FromBody] int UserId)
        {
            try
            {
                var result = await _context.UserRepository.DeleteBranch(UserId);
                if (result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
