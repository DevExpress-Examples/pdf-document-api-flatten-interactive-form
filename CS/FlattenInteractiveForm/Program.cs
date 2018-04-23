using DevExpress.Pdf;
using System;

namespace FlattenInteractiveForm {
    class Program {
        static void Main(string[] args) {

            using (PdfDocumentProcessor processor = new PdfDocumentProcessor()) {

                // Load a document with an interactive form.
                processor.LoadDocument("..\\..\\Document.pdf");

                // Flatten a form field by its name
                if (processor.FlattenFormField("Nationality"))

                    // Save a document with the flattened form field. 
                    processor.SaveDocument("..\\..\\Result1.pdf");

                // Show a message if the form field was not found in a document.
                else
                    Console.WriteLine("A document does not contain a form field with the specified name to be flattened.");

                // Flatten a whole interactive form.
                if (processor.FlattenForm())

                    // Save a document with the flattened form. 
                    processor.SaveDocument("..\\..\\Result2.pdf");

                // Show a message if the interactive was not found in a document.
                else
                    Console.WriteLine("A document does not contain an interactive form to be flattened.");
            }
        }
    }
}
