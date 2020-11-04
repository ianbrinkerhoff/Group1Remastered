using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Typing.DataAccess.Data.Repository.IRepository;

namespace Typing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        //gives ability to save and has access to the IUserRepository and inherits from unitofwork
        //which already has access to the DbContect
        //gives me unit of work, repository, db context and inherits all funcitonality
        private readonly IUnitOfWork _unitOfWork;
        
        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //evrey time i use HTTPGet on the client side itll map the get to what have been a serverside get
        [HttpGet]
        public IActionResult Get()
        {
            //retruns all data in  the form of a jason string 
            return Json(new { data = _unitOfWork.User.GetAll() });
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.User.GetFirstOrDefault(u => u.Id == id);

            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.User.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }
    }
}
