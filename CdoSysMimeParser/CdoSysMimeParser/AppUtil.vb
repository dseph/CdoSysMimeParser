Option Explicit On
Option Strict On
Imports System.Diagnostics
Imports System.IO
Imports System.Xml
Imports System.Text
Namespace MyApp
    Public Class AppUtil

        Public Function GetFileAsString(ByVal sFile As String) As String
            'Dim myStream As Stream
            Dim sr As StreamReader
            Dim sLoadedCode As String
            sr = New StreamReader(sFile)

            sLoadedCode = sr.ReadToEnd()
            sr.Close()

            Return sLoadedCode
        End Function

        Public Function GetFileAsString(ByVal sFile As String, ByVal TypeOfFileEncoding As System.Text.Encoding) As String

            Dim sr As StreamReader
            Dim sLoadedCode As String


            sr = New StreamReader(sFile, TypeOfFileEncoding)

            sLoadedCode = sr.ReadToEnd()
            sr.Close()

            Return sLoadedCode
        End Function

        Public Sub SaveStringAsFile(ByVal sString As String, ByVal sFile As String)
            Dim sr As StreamWriter
            sr = New StreamWriter(sFile)
            sr.Write(sString)
            sr.Flush()
            sr.Close()
            sr = Nothing

        End Sub

        Public Sub SaveStringAsFile(ByVal sString As String, ByVal sFile As String, ByVal bAppend As Boolean)
            Dim sr As StreamWriter
            sr = New StreamWriter(sFile, bAppend)
            sr.Write(sString)
            sr.Flush()
            sr.Close()
            sr = Nothing

        End Sub

        Public Sub SaveStringAsFile(ByVal sString As String, ByVal sFile As String, ByVal bAppend As Boolean, ByVal TypeOfFileEncoding As System.Text.Encoding)
            Dim sr As StreamWriter
            sr = New StreamWriter(sFile, bAppend, TypeOfFileEncoding)
            sr.Write(sString)
            sr.Flush()
            sr.Close()
            sr = Nothing
        End Sub

        Public Sub SaveStringAsFile(ByVal sString As String, ByVal sFile As String, ByVal TypeOfFileEncoding As System.Text.Encoding)
            Dim sr As StreamWriter
            sr = New StreamWriter(sFile, False, TypeOfFileEncoding)
            sr.Write(sString)
            sr.Flush()
            sr.Close()
            sr = Nothing

        End Sub

    End Class
End Namespace


