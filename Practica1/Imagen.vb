Public Class Imagen
    Dim Accion As String

    Public Sub CambiarImagen(ByVal Analizador As AnalizadorLexico, ByRef Prueba As Form1)
        Analizador.Accion = Accion
        If Accion = 1 Then
            Prueba.Imagen.Image = My.Resources.Comida
        End If
    End Sub


End Class
