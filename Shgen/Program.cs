using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shgen
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Run(@"..\..\..\wtest", "proceed.sh");
        }

        private void Run(string dir, string sh)
        {
            StringWriter writer = new StringWriter();
            writer.WriteLine("#!/bin/bash");
            foreach (var filePath in Directory.GetFiles(dir, "*.tif"))
            {
                foreach (var option in "/-j/-z/-n/-d".Split('/'))
                {
                    var pdfOut = $"{Path.GetFileName(filePath)}!{option}.pdf";
                    var txtOut = $"{Path.GetFileName(filePath)}!{option}.txt";

                    writer.WriteLine("tiff2pdf {2,3} -o {0} {1}"
                        , pdfOut
                        , "/d/Proj/InvestigatePDF2TIFF/wtest/" + Path.GetFileName(filePath)
                        , option
                        );
                    writer.WriteLine("pdfimages -list {0} > {1}", pdfOut, txtOut);
                }
            }
            File.WriteAllText(sh, writer.ToString().Replace("\r\n", "\n"));
        }
    }
}
