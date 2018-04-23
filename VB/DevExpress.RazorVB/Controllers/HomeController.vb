Imports System.Web.Script.Serialization

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "Welcome to DevExpress Extensions for ASP.NET MVC!"

        Return View()
    End Function

    Function CallbackPanelPartial() As ActionResult
        ViewData("Data") = GetSerializationObject()
        Return PartialView("CallbackPanelPartial")
    End Function

    Private Function GetSerializationObject() As MyData
        Dim jsonText As String = Request.Params("SerializationData")
        If String.IsNullOrEmpty(jsonText) Then
            Return Nothing
        End If

        Dim data As MyData = Nothing
        Try
            data = New JavaScriptSerializer().Deserialize(Of MyData)(jsonText)
        Catch
            ViewData("ErrorMessage") = "Incorrect data"
        End Try

        Return data
    End Function
End Class
