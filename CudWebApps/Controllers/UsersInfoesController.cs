using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CudWebApps.Models;
using Microsoft.Data.SqlClient;

namespace CudWebApps.Controllers
{
    public class UsersInfoesController : Controller
    {
        private readonly SwasSnewDb3Context _context;

        public UsersInfoesController(SwasSnewDb3Context context)
        {
            _context = context;
        }

        // GET: UsersInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.UsersInfos.ToListAsync());
        }

        // GET: UsersInfoes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usersInfo = await _context.UsersInfos
                .FirstOrDefaultAsync(m => m.UserGuid == id);
            if (usersInfo == null)
            {
                return NotFound();
            }

            return View(usersInfo);
        }

        // GET: UsersInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UsersInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserGuid,UserName,Password,EmailAddress,IsEmailVerified,FullName,CompanyName,ContactNo,CityId,MembershipType,MembershipUpdated,BuyerTypeCode,SellerDiscCodes,SellerTopDiscPer,ValidUpto,CreateDate,UpdateDate,IsEnabled,EmailVerifyCode,MobileVerifyCode,IsMobileVerified,LoginOtp,Otpdate,SignupVia")] UsersInfo usersInfo)
        {
            if (ModelState.IsValid)
            {
                usersInfo.UserGuid = Guid.NewGuid();
                //_context.Add(usersInfo);
                //await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                var parameters = new[]
                {
                    new SqlParameter("@Name", usersInfo.UserName),
                    new SqlParameter("@Email", usersInfo.EmailAddress)
                };
                await _context.Database.ExecuteSqlRawAsync("EXEC aspnet_InsertInNewTable @Name,@Email", parameters);
                return RedirectToAction(nameof(Index));
            }
            return View(usersInfo);
        }

        // GET: UsersInfoes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usersInfo = await _context.UsersInfos.FindAsync(id);
            if (usersInfo == null)
            {
                return NotFound();
            }
            return View(usersInfo);
        }

        // POST: UsersInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("UserGuid,UserName,Password,EmailAddress,IsEmailVerified,FullName,CompanyName,ContactNo,CityId,MembershipType,MembershipUpdated,BuyerTypeCode,SellerDiscCodes,SellerTopDiscPer,ValidUpto,CreateDate,UpdateDate,IsEnabled,EmailVerifyCode,MobileVerifyCode,IsMobileVerified,LoginOtp,Otpdate,SignupVia")] UsersInfo usersInfo)
        {
            if (id != usersInfo.UserGuid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usersInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsersInfoExists(usersInfo.UserGuid))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(usersInfo);
        }

        // GET: UsersInfoes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usersInfo = await _context.UsersInfos
                .FirstOrDefaultAsync(m => m.UserGuid == id);
            if (usersInfo == null)
            {
                return NotFound();
            }

            return View(usersInfo);
        }

        // POST: UsersInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var usersInfo = await _context.UsersInfos.FindAsync(id);
            if (usersInfo != null)
            {
                _context.UsersInfos.Remove(usersInfo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsersInfoExists(Guid id)
        {
            return _context.UsersInfos.Any(e => e.UserGuid == id);
        }
    }
}
