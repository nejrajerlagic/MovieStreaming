using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Movie_Streaming_Platform.Controllers
{
    [ApiController]

    [Route("[controller]/[action]")]
    public class VideoStramingAPIController : ControllerBase
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public VideoStramingAPIController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        [HttpGet]
        public async Task<IActionResult> GetVideoContent(string fileName)
        {
            string path = Path.Combine(_hostingEnvironment.WebRootPath, "Movies/") + fileName;
            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 65536, FileOptions.Asynchronous | FileOptions.SequentialScan))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, "application/octet-stream", Path.GetFileName(path), true); //enableRangeProcessing = true
        }
    }
}
