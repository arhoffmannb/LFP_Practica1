Public Class Token
    Enum TipoToken
        DarComida
        CorregirDuro
        CorregirSuave
        DarAmor
        Sumar
        Restar
        Multiplicar
        Dividir
        Concat
        Dormir
        CargarArchivo
        Ejecutar
        Matar
    End Enum

    Private Token As TipoToken
    Private ValorActual As String

    Public Sub New(ByVal tipo As TipoToken, ByVal valor As String)
        Me.Token = tipo
        Me.ValorActual = valor
    End Sub

    Public Function getTipo() As TipoToken
        Return Token
    End Function

    Public Function getValor() As String
        Return ValorActual
    End Function

    Public Function StringTipo() As String
        Select Case Token
            Case TipoToken.DarComida
                Return "DarComida"
            Case TipoToken.CorregirDuro
                Return "CorregirDuro"
            Case TipoToken.CorregirSuave
                Return "CorregirSuave"
            Case TipoToken.DarAmor
                Return "DarAmor"
            Case TipoToken.Sumar
                Return "Suma"
            Case TipoToken.Restar
                Return "Resta"
            Case TipoToken.Multiplicar
                Return "Multiplicación"
            Case TipoToken.Dividir
                Return "División"
            Case TipoToken.CargarArchivo
                Return "Cargar Archivo"
            Case TipoToken.Concat
                Return "Concatenación"
            Case TipoToken.Dormir
                Return "Dormir"
            Case TipoToken.Matar
                Return "Matar"
            Case TipoToken.Ejecutar
                Return "Ejecutar"
            Case Else
                Return "??"
        End Select
    End Function




End Class
