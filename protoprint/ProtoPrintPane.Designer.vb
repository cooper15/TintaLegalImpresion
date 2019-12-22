Partial Class ProtoPrintPane
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()>
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()>
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        'This call is required by the Component Designer.
        InitializeComponent()

    End Sub

    'Component overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim RibbonDropDownItemImpl1 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl2 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Me.Settings = Me.Factory.CreateRibbonTab
        Me.ProtoPrintP = Me.Factory.CreateRibbonGroup
        Me.PageSelector = Me.Factory.CreateRibbonComboBox
        Me.Separator1 = Me.Factory.CreateRibbonSeparator
        Me.ShowLineNumber = Me.Factory.CreateRibbonCheckBox
        Me.Separator2 = Me.Factory.CreateRibbonSeparator
        Me.Settings.SuspendLayout()
        Me.ProtoPrintP.SuspendLayout()
        Me.SuspendLayout()
        '
        'Settings
        '
        Me.Settings.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
        Me.Settings.Groups.Add(Me.ProtoPrintP)
        Me.Settings.Label = "Tinta Legal"
        Me.Settings.Name = "Settings"
        '
        'ProtoPrintP
        '
        Me.ProtoPrintP.Items.Add(Me.PageSelector)
        Me.ProtoPrintP.Items.Add(Me.Separator1)
        Me.ProtoPrintP.Items.Add(Me.ShowLineNumber)
        Me.ProtoPrintP.Items.Add(Me.Separator2)
        Me.ProtoPrintP.Label = "Impresion de protocolo"
        Me.ProtoPrintP.Name = "ProtoPrintP"
        '
        'PageSelector
        '
        RibbonDropDownItemImpl1.Label = "Frente"
        RibbonDropDownItemImpl2.Label = "Reverso"
        Me.PageSelector.Items.Add(RibbonDropDownItemImpl1)
        Me.PageSelector.Items.Add(RibbonDropDownItemImpl2)
        Me.PageSelector.Label = "Posición de la página"
        Me.PageSelector.Name = "PageSelector"
        Me.PageSelector.Text = Nothing
        '
        'Separator1
        '
        Me.Separator1.Name = "Separator1"
        '
        'ShowLineNumber
        '
        Me.ShowLineNumber.Label = "Mostrar número de linea"
        Me.ShowLineNumber.Name = "ShowLineNumber"
        '
        'Separator2
        '
        Me.Separator2.Name = "Separator2"
        '
        'ProtoPrintPane
        '
        Me.Name = "ProtoPrintPane"
        Me.RibbonType = "Microsoft.Word.Document"
        Me.Tabs.Add(Me.Settings)
        Me.Settings.ResumeLayout(False)
        Me.Settings.PerformLayout()
        Me.ProtoPrintP.ResumeLayout(False)
        Me.ProtoPrintP.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Settings As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents ProtoPrintP As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents PageSelector As Microsoft.Office.Tools.Ribbon.RibbonComboBox
    Friend WithEvents Separator1 As Microsoft.Office.Tools.Ribbon.RibbonSeparator
    Friend WithEvents ShowLineNumber As Microsoft.Office.Tools.Ribbon.RibbonCheckBox
    Friend WithEvents Separator2 As Microsoft.Office.Tools.Ribbon.RibbonSeparator
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property ProtoPrintPane() As ProtoPrintPane
        Get
            Return Me.GetRibbon(Of ProtoPrintPane)()
        End Get
    End Property
End Class
