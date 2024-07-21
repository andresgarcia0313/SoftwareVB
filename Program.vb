Imports System

Public Class Program' Definimos la clase Program    
    Public Shared Sub Main(args As String())' Método principal que sirve como punto de entrada del programa
        Console.WriteLine("Inicio!")
        Dim bienvenida As New Bienvenida() ' Creamos una instancia de la clase Bienvenida
        bienvenida.MostrarMensaje() ' Llamamos al método para mostrar el mensaje
        Dim imprimir As New Imprimir() ' Creamos una instancia de la clase Imprimir
        imprimir.MostrarMensaje() ' Llamamos al método para mostrar el mensaje
    End Sub
End Class
