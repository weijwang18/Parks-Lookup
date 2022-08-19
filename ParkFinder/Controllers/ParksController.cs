using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkFinder.Models;

namespace ParkFinder.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ParkFinderContext _db;

    public ParksController(ParkFinderContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get()
    {
      return await _db.Parks.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = park.ParkId }, park);
    }
  }
}