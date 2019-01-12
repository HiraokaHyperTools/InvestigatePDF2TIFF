using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tblgen
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Run(@"..\..\..\Shgen\bin\DEBUG", "result.json");
        }

        private void Run(string dir, string jsonOut)
        {
            List<Result> results = new List<Result>();

            foreach (var filePath in Directory.GetFiles(dir, "*.txt"))
            {
                var name = Path.GetFileNameWithoutExtension(filePath);
                var match = Regex.Match(name, "^(?<a>\\d+)bpp-(?<b>[\\w_]+)\\.tif!(?<c>.*)$");
                if (match.Success)
                {
                    var result = new Result
                    {
                        tiffBpp = int.Parse(match.Groups["a"].Value),
                        tiffCompress = match.Groups["b"].Value,
                        tiff2pdf = match.Groups["c"].Value,
                    };
                    results.Add(result);
                    var lines = File.ReadAllLines(filePath);
                    if (lines.Length >= 3)
                    {
                        //page   num  type   width height color comp bpc  enc interp  object ID x-ppi y-ppi size ratio
                        //--------------------------------------------------------------------------------------------
                        //   1     0 image     554   470  rgb     3   8  image no         7  0    72    72  763K 100 %

                        var cols = lines[2].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        result.pdfImageColor = cols[5];
                        result.pdfImageComp = int.Parse(cols[6]);
                        result.pdfImageBpc = int.Parse(cols[7]);
                        result.pdfImageInterp = cols[9];
                        result.pdfImageSize = cols[14];
                        result.pdfImageRatio = cols[15];
                    }
                }
            }
            File.WriteAllText(jsonOut, JsonConvert.SerializeObject(results, Formatting.Indented));
        }

        class Result
        {
            public int tiffBpp { get; set; }
            public string tiffCompress { get; set; }
            public string tiff2pdf { get; set; }

            public string pdfImageColor { get; set; }
            public int? pdfImageComp { get; set; }
            public int? pdfImageBpc { get; set; }
            public string pdfImageInterp { get; set; }
            public string pdfImageSize { get; set; }
            public string pdfImageRatio { get; set; }
        }
    }
}
