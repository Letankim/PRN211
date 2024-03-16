using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using WebApplication1.Helper;
using WebApplication1.Models;

namespace WebApplication1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminTbTinTucsController : Controller
    {
        private readonly Se1708Context _context;

        public AdminTbTinTucsController(Se1708Context context)
        {
            _context = context;
        }

        // GET: Admin/AdminTbTinTucs
        public IActionResult Index(int? page)
        {
          
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;
            var lsTinTucs = _context.TbTinTucs
                .AsNoTracking()
                .OrderByDescending(x => x.PostId);
            PagedList<TbTinTuc> models = new PagedList<TbTinTuc>(lsTinTucs, pageNumber, pageSize);
            ViewBag.CreateDate =DateTime.Now;
            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }

        // GET: Admin/AdminTbTinTucs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbTinTuc = await _context.TbTinTucs
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (tbTinTuc == null)
            {
                return NotFound();
            }

            return View(tbTinTuc);
        }

        // GET: Admin/AdminTbTinTucs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminTbTinTucs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PostId,Title,Scontents,Contents,Thumb,Published,Alias,CreatedDate,Author,AccountId,Tags,CatId,IsHot,IsNewfeed,MetaKey,MetaDesc,Views")] TbTinTuc tbTinTuc, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (ModelState.IsValid)
            {
                if (fThumb != null)
                {
                    string extension = Path.GetExtension(fThumb.FileName);
                    string imageName = Ultilities.SEOUrl(tbTinTuc.Title) + extension;
                    tbTinTuc.Thumb = await Ultilities.UploadFile(fThumb, @"tbTinTucs", imageName.ToLower());
                }
                if (string.IsNullOrEmpty(tbTinTuc.Thumb)) tbTinTuc.Thumb = "default.jpg";

                tbTinTuc.CreatedDate = DateTime.Now;
                _context.Add(tbTinTuc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tbTinTuc);
        }

        // GET: Admin/AdminTbTinTucs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbTinTuc = await _context.TbTinTucs.FindAsync(id);
            if (tbTinTuc == null)
            {
                return NotFound();
            }
            return View(tbTinTuc);
        }

        // POST: Admin/AdminTbTinTucs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PostId,Title,Scontents,Contents,Thumb,Published,Alias,CreatedDate,Author,AccountId,Tags,CatId,IsHot,IsNewfeed,MetaKey,MetaDesc,Views")] TbTinTuc tbTinTuc, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (id != tbTinTuc.PostId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    tbTinTuc.Title = Ultilities.ToTitleCase(tbTinTuc.Title);

                    if (fThumb != null)
                    {
                        string extension = Path.GetExtension(fThumb.FileName);
                        string imageName = Ultilities.SEOUrl(tbTinTuc.Title) + extension;
                        tbTinTuc.Thumb = await Ultilities.UploadFile(fThumb, @"tbTinTucs", imageName.ToLower());
                    }
                    if (string.IsNullOrEmpty(tbTinTuc.Thumb))
                        tbTinTuc.Thumb = "default.jpg";
                    tbTinTuc.CreatedDate = DateTime.Now;

                    _context.Update(tbTinTuc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TbTinTucExists(tbTinTuc.PostId))
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
            return View(tbTinTuc);
        }

        // GET: Admin/AdminTbTinTucs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbTinTuc = await _context.TbTinTucs
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (tbTinTuc == null)
            {
                return NotFound();
            }

            return View(tbTinTuc);
        }

        // POST: Admin/AdminTbTinTucs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbTinTuc = await _context.TbTinTucs.FindAsync(id);
            _context.TbTinTucs.Remove(tbTinTuc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TbTinTucExists(int id)
        {
            return _context.TbTinTucs.Any(e => e.PostId == id);
        }
    }
}
