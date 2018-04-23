Imports DevExpress.Pdf
Imports System

Namespace FlattenInteractiveForm
    Friend Class Program
        Shared Sub Main(ByVal args() As String)

            Using processor As New PdfDocumentProcessor()

                ' Load a document with an interactive form.
                processor.LoadDocument("..\..\Document.pdf")

                ' Flatten a form field by its name
                If processor.FlattenFormField("Nationality") Then

                    ' Save a document with the flattened form field. 
                    processor.SaveDocument("..\..\Result1.pdf")

                ' Show a message if the form field was not found in a document.
                Else
                    Console.WriteLine("A document does not contain a form field with the specified name to be flattened.")
                End If

                ' Flatten a whole interactive form.
                If processor.FlattenForm() Then

                    ' Save a document with the flattened form. 
                    processor.SaveDocument("..\..\Result2.pdf")

                ' Show a message if the interactive was not found in a document.
                Else
                    Console.WriteLine("A document does not contain an interactive form to be flattened.")
                End If
            End Using
        End Sub
    End Class
End Namespace
