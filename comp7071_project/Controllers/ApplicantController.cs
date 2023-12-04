using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using comp7071_project.Models;
using comp7071_project.Data;

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

        /// <summary> 
        /// This method returns a list of all applicants
        /// </summary>
        /// <returns>JsonResult</returns>
        /// <example>
        /// GET: api/Applicant/All
        /// </example>
        /// <response code="200">Returns a list of all applicants</response>
        /// <response code="404">If the list of applicants is empty</response>
        [HttpGet("All")]
        public async Task<IActionResult> All()
        {
            var applicants = await _context.Applicants.ToListAsync();
            return Json(new { success = true, message = "Applicants retrieved successfully", data = applicants });
        } 


        /// <summary>
        /// This method returns a specific applicant
        /// </summary>
        /// <param name="id">The id of the applicant</param>
        /// <returns>JsonResult</returns>
        /// <example>
        /// GET: api/Applicant/5
        /// </example>
        /// <response code="200">Returns the applicant with the specified id</response>
        /// <response code="404">If the applicant is null</response>
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

        /// <summary>
        /// This method returns a json result of the applicant creation
        /// </summary>
        /// <param name="applicant">The person who applies for a rental unit</param>
        /// <returns>JsonResult</returns>
        /// <example>
        /// POST: api/Applicant/Create
        /// </example>
        /// <response code="200">Returns the applicant created</response>
        /// <response code="400">If the applicant is null</response>
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

                application.AssetId = asset.Id;
                application.Asset = asset;

                _context.Add(application);
                _context.Add(asset);

                await _context.SaveChangesAsync();
                return Json(new { success = true, message = "Applicant created successfully", data = applicant });
            } else {
                return Json(new { success = false, message = "Applicant creation failed" });
            }
        }


        /// <summary>
        /// This method returns a json result of the applicant update
        /// </summary>
        /// <param name="id">The id of the applicant</param>
        /// <param name="applicant">The applicant to be updated</param>
        /// <returns>JsonResult</returns>
        /// <example>
        /// PUT: api/Applicant/Update/5
        /// </example>
        /// <response code="200">Returns the applicant updated</response>
        /// <response code="400">If the applicant is null</response>
        [HttpPut("{id}")]
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

        /// <summary>
        /// This method returns a json result of the applicant deletion
        /// </summary>
        /// <param name="id">The id of the applicant</param>
        /// <returns>JsonResult</returns>
        /// <example>
        /// DELETE: api/Applicant/Delete/5
        /// </example>
        /// <response code="200">Returns the applicant deleted</response>
        /// <response code="400">If the applicant is null</response>
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
