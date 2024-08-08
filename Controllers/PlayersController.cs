using Microsoft.AspNetCore.Mvc;
using ARSENAL_API_2.Data;
using ARSENAL_API_2.Core;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class PlayersController : ControllerBase
{
    private readonly ArsenalContext _context;

    public PlayersController(ArsenalContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    [HttpPost]
    public async Task<IActionResult> AddPlayer(Player player)
    {
        _context.Players.Add(player);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetPlayer), new { id = player.Id }, player);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Player>>> GetPlayers()
    {
        try
        {
            var players = await _context.Players.ToListAsync();
            return Ok(players);
        }
        catch (Exception ex)
        {
            // Log the exception
            Console.WriteLine($"Error in GetPlayers: {ex}");
            return StatusCode(500, "An error occurred while processing your request.");
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Player>> GetPlayer(int id)
    {
        var player = await _context.Players.FindAsync(id);
        if (player == null)
        {
            return NotFound();
        }
        return player;
    }

    [HttpGet("position/{position}")]
    public async Task<ActionResult<IEnumerable<Player>>> GetPlayersByPosition(string position)
    {
        var players = await _context.Players
            .Where(p => p.Position.ToLower() == position.ToLower())
            .ToListAsync();

        if (!players.Any())
        {
            return NotFound($"No players found with position: {position}");
        }

        return players;
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePlayer(int id)
    {
        Console.WriteLine($"Attempting to delete player with ID: {id}");

        var player = await _context.Players.FindAsync(id);
        if (player == null)
        {
            Console.WriteLine($"Player with ID {id} not found");
            return NotFound();
        }

        _context.Players.Remove(player);
        await _context.SaveChangesAsync();

        Console.WriteLine($"Player with ID {id} deleted successfully");
        return NoContent();
    }
}