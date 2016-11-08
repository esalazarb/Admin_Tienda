Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            Return View()
        End Function

        Function Calendario() As ActionResult
            Return View()
        End Function

        Function Graficos() As ActionResult
            Return View()
        End Function
    End Class
End Namespace