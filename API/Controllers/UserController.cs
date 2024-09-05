using System;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API;

[ApiController]
[Route("api/[controller]")]
public class UsersController(DataContext context) : ControllerBase
{
    [HttpGet] 
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await context.Users.ToListAsync();

        // O OK retornará um objeto de statusCode200 com a lista de usuários dentro
        return Ok(users);
    }

    [HttpGet("{id:int}")] 
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        var user = await context.Users.FindAsync(id);

        if (user == null) return NotFound();

        // O OK retornará um objeto de statusCode200 com a lista de usuários dentro
        return Ok(user);
    }
}