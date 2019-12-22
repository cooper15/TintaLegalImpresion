Public Class ProtoPrintFunctionality
    Public Sub SetFrontPageFormat()
        Dim activeDocument As Word.Document = Globals.ThisAddIn.Application.ActiveDocument
        activeDocument.PageSetup.PaperSize = Word.WdPaperSize.wdPaperLegal
        activeDocument.PageSetup.LeftMargin = Globals.ThisAddIn.Application.InchesToPoints(FrontPageMargins.LEFT_MARGIN)
        activeDocument.PageSetup.RightMargin = Globals.ThisAddIn.Application.InchesToPoints(FrontPageMargins.RIGHT_MARGIN)
        activeDocument.PageSetup.TopMargin = Globals.ThisAddIn.Application.InchesToPoints(FrontPageMargins.TOP_MARGIN)
        activeDocument.PageSetup.BottomMargin = Globals.ThisAddIn.Application.InchesToPoints(FrontPageMargins.BOTTOM_MARGIN)
        activeDocument.PageSetup.MirrorMargins = True
        ParagraphConfiguration(activeDocument)
        activeDocument.Paragraphs.Format.LeftIndent = Globals.ThisAddIn.Application.InchesToPoints(FrontPageIndent.LEFT_INDENT)
        activeDocument.Paragraphs.Format.RightIndent = Globals.ThisAddIn.Application.InchesToPoints(FrontPageIndent.RIGHT_INDENT)
    End Sub

    Public Sub SetBackPageFormat()
        Dim activeDocument As Word.Document = Globals.ThisAddIn.Application.ActiveDocument
        activeDocument.PageSetup.PaperSize = Word.WdPaperSize.wdPaperLegal
        activeDocument.PageSetup.LeftMargin = Globals.ThisAddIn.Application.InchesToPoints(BackPageMargins.LEFT_MARGIN)
        activeDocument.PageSetup.RightMargin = Globals.ThisAddIn.Application.InchesToPoints(BackPageMargins.RIGHT_MARGIN)
        activeDocument.PageSetup.TopMargin = Globals.ThisAddIn.Application.InchesToPoints(BackPageMargins.TOP_MARGIN)
        activeDocument.PageSetup.BottomMargin = Globals.ThisAddIn.Application.InchesToPoints(BackPageMargins.BOTTOM_MARGIN)
        activeDocument.PageSetup.MirrorMargins = True
        ParagraphConfiguration(activeDocument)
        activeDocument.Paragraphs.Format.LeftIndent = Globals.ThisAddIn.Application.InchesToPoints(BackPageIndent.LEFT_INDENT)
        activeDocument.Paragraphs.Format.RightIndent = Globals.ThisAddIn.Application.InchesToPoints(BackPageIndent.RIGHT_INDENT)
    End Sub

    Private Sub ParagraphConfiguration(activeDocument As Word.Document)
        activeDocument.Paragraphs.Format.SpaceBefore = 0
        activeDocument.Paragraphs.Format.SpaceAfter = 0
        activeDocument.Paragraphs.Format.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceExactly
        activeDocument.Paragraphs.Format.LineSpacing = 24.3
        activeDocument.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        activeDocument.Paragraphs(1).Range.Font.Name = "Calibri"
        activeDocument.Paragraphs(1).Range.Font.Size = 10
    End Sub
End Class
