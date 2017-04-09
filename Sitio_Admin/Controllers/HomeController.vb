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

        Function Registro_Usuarios() As ActionResult
            Return View()
        End Function

        Function Registro_Categorias() As ActionResult
            Return View()
        End Function

        Function Registro_SubCategorias() As ActionResult
            Return View()
        End Function

        Function Registro_Tipos() As ActionResult
            Return View()
        End Function

        Function Registro_Contacto() As ActionResult
            Return View()
        End Function
    End Class
End Namespace