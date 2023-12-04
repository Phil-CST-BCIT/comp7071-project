using System;
using System.Threading.Tasks;
using comp7071_project.Controllers;
using comp7071_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace comp7071_project.Tests
{
    [TestClass]
    public class ApplicantControllerTests
    {
        [TestMethod]
        public async Task CreateApplicant_ReturnsSuccess()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<Comp7071ProjectContext>()
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=comp7071_db;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            using (var context = new Comp7071ProjectContext(options))
            {
                var controller = new ApplicantController(context);

                // Act
                var result = await controller.Create(new Applicant
                {
                    Id = 1,
                    Name = "John Doe",
                    Employer = "ABC Corp",
                    Income = 50000
                });

                // Assert
                var jsonResult = result as JsonResult;
                Assert.IsNotNull(jsonResult);

                dynamic data = jsonResult.Value;
                Assert.IsTrue(data.success);
                Assert.AreEqual("Applicant created successfully", data.message);

                var createdApplicant = data.data as Applicant;
                Assert.IsNotNull(createdApplicant);
                Assert.AreEqual("John Doe", createdApplicant.Name);

                // Check if the applicant exists in the database
                var savedApplicant = await context.Applicants.FirstOrDefaultAsync(a => a.Name == "John Doe");
                Assert.IsNotNull(savedApplicant);
                Assert.AreEqual(1, savedApplicant.Id);
            }
        }

        [TestMethod]
        public async Task GetAllApplicants_ReturnsSuccess()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<Comp7071ProjectContext>()
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=comp7071_db;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            using (var context = new Comp7071ProjectContext(options))
            {
                context.Applicants.Add(new Applicant { Id = 1, Name = "Jane Doe", Employer = "DEF Corp", Income = 80000 });
                context.SaveChanges();
            }

            using (var context = new Comp7071ProjectContext(options))
            {
                var controller = new ApplicantController(context);

                // Act
                var result = await controller.All();

                // Assert
                var jsonResult = result as JsonResult;
                Assert.IsNotNull(jsonResult);

                dynamic data = jsonResult.Value;
                Assert.IsTrue(data.success);
                Assert.AreEqual("Applicants retrieved successfully", data.message);

                var applicants = data.data as List<Applicant>;
                Assert.IsNotNull(applicants);
                Assert.AreEqual(1, applicants.Count);
            }
        }
    }
}
