
Option Explicit On

Imports System.Drawing.Printing
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Public Class printer

    Private Sub printer_paper()
        'Getting Printer names 
        Dim prtlist As New PrintDocument()
        Dim strPrinter As [String]
        For Each strPrinter In PrinterSettings.InstalledPrinters
            cmbPrinterlist.Items.Add(strPrinter)
        Next strPrinter

        'Getting papersizes 
        papersize.DisplayMember = "PaperName"
        prtlist.PrinterSettings.PrinterName = CStr(cmbPrinterlist.SelectedItem)

        Dim pSize As PaperSize

        For i = 0 To prtlist.PrinterSettings.PaperSizes.Count - 1
            pSize = prtlist.PrinterSettings.PaperSizes.Item(i)

            ' For Each pSize In prtlist.PrinterSettings.PaperSizes
            papersize.Items.Add(pSize)
        Next i

    End Sub
    Private Sub update_studentfile_prnSETTINGs()

        studentfile.printerName.Text = cmbPrinterlist.Text
        studentfile.paperSize.Text = papersize.Text



    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call update_studentfile_prnSETTINGs()

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call update_insert_printSETUP()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call update_insert_printSETUP()
            sqlconn.Close()
        End If

        Me.Dispose()
    End Sub
    Private Sub printer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call printer_paper()
    End Sub
    Private Sub update_printSETUP()
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE printSETUP SET prnNAME = '" & cmbPrinterlist.Text & "', paperNAME = '" & papersize.Text & "' where (frmNAME = '" & frm.Text & "' AND hostname = '" & pcname.Text & "')"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub insert_printSETUP()
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "INSERT into printSETUP([hostname],[frmNAME],[prnName],[paperNAME]) values ('" & pcname.Text & "','" & frm.Text & "','" & cmbPrinterlist.Text & "','" & papersize.Text & "')"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub update_insert_printSETUP()
        sqlcmd.CommandText = "select * FROM printSETUP Where (frmNAME = '" & frm.Text & "' AND hostname = '" & pcname.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname2 As SqlDataReader
        daMyname2 = sqlcmd.ExecuteReader()
        If daMyname2.HasRows Then
            daMyname2.Read()
            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call update_printSETUP()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call update_printSETUP()
                sqlconn.Close()
            End If
        Else
            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call insert_printSETUP()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call insert_printSETUP()
                sqlconn.Close()
            End If
        End If

    End Sub
End Class