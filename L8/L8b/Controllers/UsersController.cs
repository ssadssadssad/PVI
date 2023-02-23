using L8b.Models;
using Microsoft.AspNetCore.Mvc;

namespace L8b.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private Users _users;
    private readonly ILogger<UsersController> _logger;

    public UsersController(ILogger<UsersController> logger, Users users)
    {
        _logger = logger;
        _users = users;
    }

    /// <summary>
    /// Get all users
    /// </summary>
    /// <remarks>Create 20.12.2022</remarks>
    [HttpGet, ProducesResponseType(typeof(Users), 200)]
    public Users Get()
    {
        return _users.GetAll();
    }

    /// <summary>
    /// Get user by id
    /// </summary>
    /// <remarks>Create 20.12.2022</remarks>
    /// <param name="id" example="101">User id</param>
    /// <response code="200">User found</response>
    /// <response code="404">User not found</response>
    [HttpGet("{id:int}"), ProducesResponseType(typeof(User), 200)]
    public User GetById(int id)
    {
        var foundUser = _users.GetById(id);
        if (foundUser is null)
            Response.StatusCode = 404;
        return foundUser ?? new User();
    }

    /// <summary>
    /// Add user
    /// </summary>
    /// <remarks>Create 20.12.2022</remarks>
    /// <response code="200">User added</response>
    /// <response code="400">User not added</response>
    [HttpPost, ProducesResponseType(typeof(User), 200)]
    public User Post(User user)
    {
        var addedUser = _users.Add(user);
        if (addedUser == null)
            Response.StatusCode = 400;
        return user;
    }

    /// <summary>
    /// Update user
    /// </summary>
    /// <remarks>Create 20.12.2022</remarks>
    /// <response code="200">User updated</response>
    /// <response code="400">User not updated</response>
    [HttpPut]
    public User Put(User user)
    {
        var updatedUser = _users.Update(user);
        if (updatedUser is null)
            Response.StatusCode = 400;
        return user;
    }

    /// <summary>
    /// Delete user
    /// </summary>
    /// <remarks>Create 20.12.2022</remarks>
    /// <param name="id" example="101">User id</param>
    /// <response code="200">User deleted</response>
    /// <response code="404">User not deleted</response>
    [HttpDelete("{id:int}")]
    public User Delete(int id)
    {
        var deletedUser = _users.Delete(id);
        if (deletedUser is null)
            Response.StatusCode = 404;
        return deletedUser ?? new User();
    }
}