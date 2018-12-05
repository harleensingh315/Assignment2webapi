using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEBAPI_200349465.Models;

namespace WEBAPI_200349465.Controllers
{
    [Produces("application/json")]
    [Route("api/TeamPlayers")]
    public class TeamPlayersController : Controller
    {
        private readonly students_dbContext _context;

        public TeamPlayersController(students_dbContext context)
        {
            _context = context;
        }

        // GET: api/TeamPlayers
        [HttpGet]
        public IEnumerable<TeamPlayers> GetTeamPlayers()
        {
            return _context.TeamPlayers;
        }

        // GET: api/TeamPlayers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeamPlayers([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var teamPlayers = await _context.TeamPlayers.SingleOrDefaultAsync(m => m.Id == id);

            if (teamPlayers == null)
            {
                return NotFound();
            }

            return Ok(teamPlayers);
        }

        // PUT: api/TeamPlayers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeamPlayers([FromRoute] int id, [FromBody] TeamPlayers teamPlayers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != teamPlayers.Id)
            {
                return BadRequest();
            }

            _context.Entry(teamPlayers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamPlayersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TeamPlayers
        [HttpPost]
        public async Task<IActionResult> PostTeamPlayers([FromBody] TeamPlayers teamPlayers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TeamPlayers.Add(teamPlayers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeamPlayers", new { id = teamPlayers.Id }, teamPlayers);
        }

        // DELETE: api/TeamPlayers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeamPlayers([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var teamPlayers = await _context.TeamPlayers.SingleOrDefaultAsync(m => m.Id == id);
            if (teamPlayers == null)
            {
                return NotFound();
            }

            _context.TeamPlayers.Remove(teamPlayers);
            await _context.SaveChangesAsync();

            return Ok(teamPlayers);
        }

        private bool TeamPlayersExists(int id)
        {
            return _context.TeamPlayers.Any(e => e.Id == id);
        }
    }
}