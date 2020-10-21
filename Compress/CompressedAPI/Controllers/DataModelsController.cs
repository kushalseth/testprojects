using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CompressedAPI;
using CompressedAPI.Models;
using Compress;

namespace CompressedAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataModelsController : ControllerBase
    {
       // private readonly CompressedAPIContext _context;
       // private readonly Compress.Compress _compress;

        public DataModelsController()
        {
          //  _context = context;
          //  _compress = compress;
        }

        // GET: api/DataModels
        [HttpGet("GetCompressedString/{uncompressed}")]
        public async Task<ActionResult<string>> GetCompressedString(string uncompressed)
        {
            Compress.Compress _compress = new Compress.Compress();
            string result = await _compress.GetCompressedString(uncompressed);

            return result;
        }

    }
}
