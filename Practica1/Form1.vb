Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Entrada As String = CuadroTexto.Text
        Dim Lexema As AnalizadorLexico = New AnalizadorLexico()
        Dim ListaLexemas As List(Of Token) = Lexema.Scanner(Entrada)
        Lexema.MostrarLista(ListaLexemas)
        If (Lexema.CambiarImagen = 1) Then
            Imagen.Image = My.Resources.Comida
        ElseIf (Lexema.CambiarImagen = 2) Then
            Imagen.Image = My.Resources.Duro
        ElseIf (Lexema.CambiarImagen = 3) Then
            Imagen.Image = My.Resources.Suave
        ElseIf (Lexema.CambiarImagen = 4) Then
            Imagen.Image = My.Resources.Amor
        ElseIf (Lexema.CambiarImagen = 5) Then
            Imagen.Image = My.Resources.Sumar
        ElseIf (Lexema.CambiarImagen = 6) Then
            Imagen.Image = My.Resources.Restar
        ElseIf (Lexema.CambiarImagen = 7) Then
            Imagen.Image = My.Resources.Multiplicar
        ElseIf (Lexema.CambiarImagen = 8) Then
            Imagen.Image = My.Resources.Dividir
        ElseIf (Lexema.CambiarImagen = 9) Then
            Imagen.Image = My.Resources.Cargar
        ElseIf (Lexema.CambiarImagen = 10) Then
            Imagen.Image = My.Resources.Matar
        ElseIf (Lexema.CambiarImagen = 11) Then
            Imagen.Image = My.Resources.Dormir
        ElseIf (Lexema.CambiarImagen = 12) Then
            Imagen.Image = My.Resources.Cargar
        ElseIf (Lexema.CambiarImagen = 13) Then
            Imagen.Image = My.Resources.Concatenar
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Imagen.Image = My.Resources.Comida
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Imagen.Image = My.Resources.Normal

    End Sub

End Class
