using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleWeb.Data;
using SampleWeb.Models;

namespace SampleWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        public TestController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> TestAddData(Product model)
        {
            _dbContext.Products.Add(model);
            await _dbContext.SaveChangesAsync();
            return Ok(model);
        }
    }
}