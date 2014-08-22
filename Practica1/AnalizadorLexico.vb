Public Class AnalizadorLexico
    Private Salida As List(Of Token)
    Public CambiarImagen As Integer
    Private EstadoActual As Integer
    Private LexemaActual As String
    Public Entrada As String
    Public Accion As Integer

    Public Function Scanner(ByVal Entrada As String) As List(Of Token)
        Salida = New List(Of Token)
        EstadoActual = 0
        LexemaActual = ""
        Dim Caracter As Char

        For i As Integer = 0 To Entrada.Length - 1 Step 1
            Caracter = Entrada.Chars(i)


        Select Case EstadoActual
                Case 0
                    If Char.IsLetter(Caracter) Then
                        LexemaActual += Caracter
                        EstadoActual = 1
                    ElseIf (i = Entrada.Length) Then
                        Console.WriteLine("Proceso terminado")
                    Else
                        Console.WriteLine("Error con caracter " + Caracter + " En posicion " + i.ToString)
                        Exit For
                    End If
                Case 1
                    If Char.IsLetter(Caracter) Then
                        LexemaActual += Caracter
                    ElseIf Char.IsDigit(Caracter) Then
                        Exit For
                    End If

                    If (LexemaActual.Equals("DarComida")) Then
                        AddToken(Token.TipoToken.DarComida)
                        CambiarImagen = 1
                        LexemaActual = ""
                        EstadoActual = 1
                    ElseIf (LexemaActual.Equals("CorregirDuro")) Then
                        AddToken(Token.TipoToken.CorregirDuro)
                        CambiarImagen = 2
                    ElseIf (LexemaActual.Equals("CorregirSuave")) Then
                        AddToken(Token.TipoToken.CorregirSuave)
                        CambiarImagen = 3
                    ElseIf (LexemaActual.Equals("DarAmor")) Then
                        AddToken(Token.TipoToken.DarAmor)
                        CambiarImagen = 4
                    ElseIf (LexemaActual.Equals("Sumar")) Then
                        AddToken(Token.TipoToken.Sumar)
                        CambiarImagen = 5
                    ElseIf (LexemaActual.Equals("Sumarln")) Then
                        AddToken(Token.TipoToken.Sumar)
                        CambiarImagen = 5
                    ElseIf (LexemaActual.Equals("Restar")) Then
                        AddToken(Token.TipoToken.Restar)
                        CambiarImagen = 6
                    ElseIf (LexemaActual.Equals("Restarln")) Then
                        AddToken(Token.TipoToken.Restar)
                        CambiarImagen = 6
                    ElseIf (LexemaActual.Equals("Multiplicar")) Then
                        AddToken(Token.TipoToken.Multiplicar)
                        CambiarImagen = 7
                    ElseIf (LexemaActual.Equals("MultiplicarInv")) Then
                        AddToken(Token.TipoToken.Dividir)
                        CambiarImagen = 8
                    ElseIf (LexemaActual.Equals("Dividir")) Then
                        AddToken(Token.TipoToken.Dividir)
                        CambiarImagen = 8
                    ElseIf (LexemaActual.Equals("DividirInv")) Then
                        AddToken(Token.TipoToken.Multiplicar)
                        CambiarImagen = 7
                    ElseIf (LexemaActual.Equals("CargarArchivo")) Then
                        AddToken(Token.TipoToken.CargarArchivo)
                        CambiarImagen = 9
                    ElseIf (LexemaActual.Equals("Matar")) Then
                        AddToken(Token.TipoToken.Matar)
                        CambiarImagen = 10
                    ElseIf (LexemaActual.Equals("Ejecutar")) Then
                        AddToken(Token.TipoToken.Ejecutar)
                    ElseIf (LexemaActual.Equals("Dormir")) Then
                        AddToken(Token.TipoToken.Dormir)
                        CambiarImagen = 11
                    ElseIf (LexemaActual.Equals("CargarArchivo")) Then
                        AddToken(Token.TipoToken.CargarArchivo)
                        CambiarImagen = 12
                    ElseIf (LexemaActual.Equals("Concat")) Then
                        AddToken(Token.TipoToken.Concat)
                        CambiarImagen = 13
                    End If

            End Select

            
        Next
        Return Salida
    End Function

    Private Sub AddToken(ByVal tipo As Token.TipoToken)
        Salida.Add(New Token(tipo, "Palabra Reservada"))
        LexemaActual = ""
        EstadoActual = 0
    End Sub

    Public Function MostrarLista(ByVal Lista As List(Of Token))
        For Each t As Token In Lista
            Console.WriteLine(t.StringTipo() & "---" & t.getValor())

            If (t.StringTipo.Equals("DarComida")) Then
                Accion = 0
            End If

        Next
        Return Accion
    End Function

End Class

