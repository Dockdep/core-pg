using System;
using Microsoft.AspNetCore.Mvc;
using Core.Models.Database;
using Core.Respositories;
using Core.Mappers;
namespace Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserRepository _userRepository;
        public HomeController(DatabaseContext databaseContext)
        {
            _userRepository = new UserRepository(databaseContext);
        }
        [HttpGet("/")]
        public ActionResult Index()
        {
            var email = "test@user.com";
            var user = _userRepository.GetByEmail(email);
            var userViewModel = UserViewModelMapper.MapFrom(user);
            return View(userViewModel);
        }
    }
}