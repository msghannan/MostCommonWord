using HiQTest.ViewModel;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace HiQTest.Controllers.API
{
    // Tillåter CORS för olika frontend 
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/[controller]/[action]")]

    public class FileController : ApiController
    {
        FileViewModel fileViewModel = new FileViewModel();

        // Post metoden som laddar upp filen
        [HttpPost]
        [Route("API/File/UploadFile/")]
        public async Task<string> UploadFile()
        {
            var ctx = HttpContext.Current;
            var root = ctx.Server.MapPath("~/App_Data");
            var provider = new MultipartFileStreamProvider(root);

            string result = "";


            await Request.Content.ReadAsMultipartAsync(provider);

            foreach (var file in provider.FileData)
            {
                var name = file.Headers.ContentDisposition.FileName;
                name = name.Trim('"');

                var localFileName = file.LocalFileName;
                var filePath = Path.Combine(root, name);

                File.Move(localFileName, filePath);

                // Skickar fil-adressen till ReadtextFromFile metoden
                fileViewModel.ReadTextFromFile(filePath.ToString());

            }

            // Hämtar texten från metoden WriteToJsonFile för att presentera det till användaren
            foreach(var text in fileViewModel.WriteToJsonFile())
            {
                result = text.Text;
            }

            return result;
        }

    }
}
