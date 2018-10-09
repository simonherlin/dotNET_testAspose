using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using Aspose.Pdf.Facades;

namespace testApose
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataDir = "pycon";

            // Open document
            Aspose.Pdf.Document pdfDocument = new Aspose.Pdf.Document(dataDir + ".pdf");

            // Get particular page
            Page pdfPage = (Page)pdfDocument.Pages[1];

            // Create text fragment
            TextFragment textFragment = new TextFragment("main text");
            textFragment.Position = new Position(100, 600);

            // Set text properties
            textFragment.TextState.FontSize = 12;
            textFragment.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            textFragment.TextState.BackgroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray);
            textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Red);

            // Create TextBuilder object
            TextBuilder textBuilder = new TextBuilder(pdfPage);

            // Append the text fragment to the PDF page
            textBuilder.AppendText(textFragment);

            dataDir = dataDir + "AddText_out.pdf";

            // Save resulting PDF document.
            pdfDocument.Save(dataDir);

        }
    }
}
