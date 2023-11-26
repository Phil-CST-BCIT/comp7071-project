using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using comp7071_project.Models;

namespace comp7071_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantController : Controller
    {
        private readonly Comp7071ProjectContext _context;

        public ApplicantController(Comp7071ProjectContext context)
        {
            _context = context;
        }

        // GET: Applicant/All
        [HttpGet("All")]
        public async Task<IActionResult> All()
        {
            var applicants = await _context.Applicants.ToListAsync();
            return Json(new { success = true, message = "Applicants retrieved successfully", data = applicants });
        } 

        // GET: Applicant/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicant = await _context.Applicants
                .FirstOrDefaultAsync(m => m.Id == id);
            if (applicant == null)
            {
                return NotFound();
            }

            return Json(new { success = true, message = "Applicant retrieved successfully", data = applicant });
        }


        // POST: Applicant/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Employer,Income")] Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(applicant);
                await _context.SaveChangesAsync();

                // create a new application for this applicant
                var application = new Application();
                application.ApplicantId = applicant.Id;
                application.Applicant = applicant;

                // create a new asset for this application
                var asset = new Asset();
                asset.Status = "Pending";
                asset.Type = "Apartment";
                asset.Location = "Toronto";
                asset.Application = application;
                asset.ApplicationId = application.Id;

                application.AssetId = asset.Id;
                application.Asset = asset;

                _context.Add(application);
                _context.Add(asset);

                await _context.SaveChangesAsync();
                // return json action result
                return Json(new { success = true, message = "Applicant created successfully" });
            } else {
                return Json(new { success = false, message = "Applicant creation failed" });
            }
        }

        // PUT: Applicant/Update/{id}
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, [Bind("Id,Name,Employer,Income")] Applicant applicant)
        {
            if (id != applicant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(applicant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicantExists(applicant.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                // return json action result
                return Json(new { success = true, message = "Applicant updated successfully" });
            }
            else
            {
                return Json(new { success = false, message = "Applicant update failed" });
            }
        }

        // DELETE: Applicant/Delete/5
        [HttpDelete("{id}"), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var applicant = await _context.Applicants.FindAsync(id);
            if (applicant != null)
            {
                _context.Applicants.Remove(applicant);
            }

            await _context.SaveChangesAsync();
            
            return Json(new { success = true, message = "Applicant deleted successfully" });
        }

        private bool ApplicantExists(int id)
        {
            return _context.Applicants.Any(e => e.Id == id);
        }
    }
}
