Imports Microsoft.Office.Tools.Ribbon

Public Class ProtoPrintPane

    Private Sub CheckBox1_Click(sender As Object, e As RibbonControlEventArgs) Handles ShowLineNumber.Click
        ShowNumberLine()
    End Sub

    Private Sub ShowNumberLine()
        Dim activeDocument = Globals.ThisAddIn.Application.ActiveDocument
        If ShowLineNumber.Checked Then
            activeDocument.PageSetup.LineNumbering.Active = True
        Else
            activeDocument.PageSetup.LineNumbering.Active = False
        End If
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As RibbonControlEventArgs) Handles PageSelector.TextChanged
        If PageSelector.Text.Equals("Frente") Then
            Dim functionality = New ProtoPrintFunctionality()
            functionality.SetFrontPageFormat()
        Else
            Dim functionality = New ProtoPrintFunctionality()
            functionality.SetBackPageFormat()
        End If
    End Sub

End Class
