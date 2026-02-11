using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiClass.Data;
using WebApiClass.Models;

namespace WebApiClass.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{

    // private readonly UserAction _userAction;

    private readonly DataContext _dataContext;
    
    public UserController(DataContext dataContext)
    {
        _dataContext = dataContext;
     //   _userAction = new UserAction();
    }
    [HttpGet]
    public List<User> Get()
    {
        return _dataContext.Users.ToList();

       //return _userAction.GetUsers(); 
    }

    [HttpPost]
    public void Post( User input)
    {
        _dataContext.Users.Add(input);
        _dataContext.SaveChanges();
       // _userAction.AddUser(input);

    }

    [HttpGet("{id}")]
    public User Get(int id)
    {
        return _dataContext.Users.Find(id);
      //  return _userAction.GetUser(id);
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        var user = _dataContext.Users.Find(id);

        if (user != null)
        {
            _dataContext.Users.Remove(user);
            _dataContext.SaveChanges();
        }
        //_userAction.RemoveUser(id);

    }

    [HttpPut("{id}")]
    public void Put(int id, User input ) 
    {

        var user = _dataContext.Users.Find(id);
       
        if (user != null)
        {
            user.Name = input.Name;
            user.Email = input.Email;

            _dataContext.Users.Update(user);
            _dataContext.SaveChanges();
        }

        //  _userAction.UpdateUser(id, input);

    }
}