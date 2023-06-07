using GoodHotel.Service.Common.Utils;
using GoodHotel.Service.Dtos.Accounts;
using GoodHotel.Service.Interfaces.Products;
using GoodHotel.Service.Services.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SendGrid.Helpers.Errors.Model;

namespace GoodHotel.Wep.Controllers
{
    [Route("contacs")]
    //[Authorize]
    public class ContactsController : Controller
    {
        private readonly IRoomService _roomService;
        private readonly int _pageSize = 30;
        public ContactsController(IRoomService roomService)
        {
            this._roomService = roomService;
        }
        public async Task<IActionResult> Contact(int page =1)
        {
            var rooms = await _roomService.GetAllAsync(new PaginationParams(page, _pageSize));
            return View("Contact", rooms);
        }

        [HttpGet("get")]
        public async Task<ViewResult> GetAsync(long roomId)
        {
            var room = await _roomService.GetAsync(roomId);
            int resalt = room.place;
            if(resalt == 0)
            {
                return View("Get", room);
            }
            else
            {
                throw new NotFoundException("Bu joy band!");
                return View();
            }
        }
        //[HttpGet("update")]
        //[HttpPost("update")]
        //public async Task<IActionResult> UpdateAsync(AccountRegisterDto accountRegisterDto)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        bool result = await _roomService.(accountRegisterDto);
        //        if (result)
        //        {
        //            return RedirectToAction("login", "contacs", new { area = "" });
        //        }
        //        else
        //        {
        //            return UpdateAsync();
        //        }
        //    }
        //    else return UpdateAsync();
        //}
    }
}
