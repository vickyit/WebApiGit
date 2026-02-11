using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiClass.Models;

namespace WebApiClass.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly UserAction _userAction;
     
    public UserController()
    {
        _userAction = new UserAction();
    }
    [HttpGet]
    public List<User> Get()
    {
       return _userAction.GetUsers(); 
    }

    [HttpPost]
    public void Post( User input)
    {
        _userAction.AddUser(input);

    }

    [HttpGet("{id}")]
    public User Get(int id)
    {
        return _userAction.GetUser(id);
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _userAction.RemoveUser(id);

    }

    [HttpPut("{id}")]
    public void Put(int id, User input ) 
    {
        _userAction.UpdateUser(id, input);

     }
}