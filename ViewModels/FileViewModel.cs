using HiQTest.Controllers.API;
using HiQTest.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace HiQTest.ViewModel
{
    public class FileViewModel
    {
        public List<FileClass> FileClass { get; set; }
        public string FileContent { get; set; }


        string TextJsonPath = HttpContext.Current.Server.MapPath("~/DAL/Text.json");


        public FileViewModel()
        {
            string jsonText = File.ReadAllText(HttpContext.Current.Server.MapPath("~/DAL/Text.json"));
            FileClass = Newtonsoft.Json.JsonConvert.DeserializeObject<List<FileClass>>(jsonText);
        }

        // Hämtar mest använda ordet
        public string MostUsedWords(string text)
        {
            string [] input = text.Split(' ');

            Dictionary<string, int> hs = new Dictionary<string, int>();

            for (int i =0; i<input.Length; i++)
            {
                if(hs.ContainsKey(input[i]))
                {
                    hs[input[i]] = hs[input[i]] + 1;
                }

                else
                {
                    hs.Add(input[i], 1);
                }
            }


            string key = "";
            int value = 0;

            foreach(KeyValuePair<string, int> me in hs)
            {
                if(me.Value > value)
                {
                    value = me.Value;
                    key = me.Key;
                }
            }

            return key;
        }


        // Läsen texten från filen som laddades upp av användaren
        public string ReadTextFromFile(string filePath)
        {
            List<string> FileText = new List<string>();
            
            string result = "";

            FileText = File.ReadAllLines(filePath).ToList();

            foreach (var text in FileText)
            {
                result = text;
            }

            // Sparar texten i en property för att senare användas av en annan metod
            FileContent = result;

            return result;
        }


        // Sparar texten i JSOn filen
        public List<FileClass> WriteToJsonFile()
        {
            foreach (var a in FileClass)
            {
                a.Text = FileContent;
            }

            string output = JsonConvert.SerializeObject(FileClass, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(TextJsonPath, output);


            // Skickar texten som sparades i FileContent property för att spara mest använda
            // ordet i en variabel
            string mostUsedWord = MostUsedWords(FileContent);

            // Lägger till foo och bar
            string addFooBar = "foo" + mostUsedWord + "bar";

            // Ersätter mest använda ordet med det nya, variabels ovan
            foreach (var a in FileClass)
            {
                a.Text = a.Text.Replace(mostUsedWord, addFooBar);
            }


            // Sparar det nya resultatet i JSOn filen
            string output2 = JsonConvert.SerializeObject(FileClass, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(TextJsonPath, output2);


            // Returnerar listan av typen FileClass för att presentera resultatet till användaren
            return FileClass;
        }
    }
}