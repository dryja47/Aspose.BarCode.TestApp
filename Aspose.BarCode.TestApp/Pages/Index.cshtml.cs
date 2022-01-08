using System.Collections.Generic;
using System.IO;
using System.Linq;
using Aspose.BarCode.BarCodeRecognition;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Aspose.BarCode.TestApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly string[] _extensions = new[] { ".jpg", ".jpeg", ".bmp", ".png", ".tiff" };

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public JsonResult OnPost([FromForm] List<IFormFile> picture)
        {
            if (picture == null || picture.Count == 0 ||
                !_extensions.Contains(Path.GetExtension(picture.First().FileName)))
                return new JsonResult(new List<BarCodeResult>());
            using var stream = new MemoryStream();
            picture.First().CopyTo(stream);
            using var barCodeReader = new BarCodeReader(stream);
            barCodeReader.ReadBarCodes();
            return new JsonResult(barCodeReader.FoundBarCodes);
        }
    }
}   