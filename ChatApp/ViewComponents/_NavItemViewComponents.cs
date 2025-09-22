using ChatApp.Entities;
using ChatApp.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace ChatApp.ViewComponents
{
    public class _NavItemViewComponents(UserManager<AppUser> userManager, ChatDbContext _context) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            var messages = _context.Messages.Include(x => x.Sender).Where(x => x.ReceiverId == user.Id && x.IsRead == false).ToList();
            ViewBag.messages = _context.Messages.Include(x => x.Sender).Where(x => x.ReceiverId == user.Id && x.IsRead == false).Count();
            return View(messages);
        }

    }
}
