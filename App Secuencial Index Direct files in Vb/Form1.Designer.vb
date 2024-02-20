<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        MenuStrip1 = New MenuStrip()
        SecuencialToolStripMenuItem = New ToolStripMenuItem()
        IndexadosToolStripMenuItem = New ToolStripMenuItem()
        DirectosToolStripMenuItem = New ToolStripMenuItem()
        ListDataSecuencial = New ListBox()
        IDSecuencialText = New TextBox()
        NombreSecuencialText = New TextBox()
        NotaSecuencialText = New TextBox()
        CreateFileRegistredSecuencial = New Button()
        OpenFileRegistredSecuencial = New Button()
        AddRegistredSecuencial = New Button()
        PanelIndexados = New Panel()
        PanelDirectos = New Panel()
        AddRegistredDirected = New Button()
        OpenFileRegistredDirected = New Button()
        CreateFileRegistredDirected = New Button()
        NotaDirectedText = New TextBox()
        NombreDirectedText = New TextBox()
        IDDirectedText = New TextBox()
        ListDataDirected = New ListBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        AddRegistredIndexSecuencial = New Button()
        OpenFileRegistredIndexSecuencial = New Button()
        CreateFileRegistredIndexSecuencial = New Button()
        ListDataSecuencialIndexed = New ListBox()
        ListIndexSecuencialIndexed = New ListBox()
        DatoSecuencialIndexadosText = New TextBox()
        KeySecuencialIndexadosText = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        MenuStrip1.SuspendLayout()
        PanelIndexados.SuspendLayout()
        PanelDirectos.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(16, 78)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 30)
        Label1.TabIndex = 0
        Label1.Text = "ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(16, 197)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 30)
        Label2.TabIndex = 1
        Label2.Text = "Nota:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(16, 136)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 30)
        Label3.TabIndex = 2
        Label3.Text = "Nombre:"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ControlDark
        MenuStrip1.Items.AddRange(New ToolStripItem() {SecuencialToolStripMenuItem, IndexadosToolStripMenuItem, DirectosToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(8, 3, 0, 3)
        MenuStrip1.Size = New Size(471, 31)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SecuencialToolStripMenuItem
        ' 
        SecuencialToolStripMenuItem.Font = New Font("Segoe UI", 12F)
        SecuencialToolStripMenuItem.ForeColor = SystemColors.Control
        SecuencialToolStripMenuItem.Name = "SecuencialToolStripMenuItem"
        SecuencialToolStripMenuItem.Size = New Size(95, 25)
        SecuencialToolStripMenuItem.Text = "Secuencial"
        ' 
        ' IndexadosToolStripMenuItem
        ' 
        IndexadosToolStripMenuItem.Font = New Font("Segoe UI", 12F)
        IndexadosToolStripMenuItem.ForeColor = SystemColors.Control
        IndexadosToolStripMenuItem.Name = "IndexadosToolStripMenuItem"
        IndexadosToolStripMenuItem.Size = New Size(92, 25)
        IndexadosToolStripMenuItem.Text = "Indexados"
        ' 
        ' DirectosToolStripMenuItem
        ' 
        DirectosToolStripMenuItem.Font = New Font("Segoe UI", 12F)
        DirectosToolStripMenuItem.ForeColor = SystemColors.Control
        DirectosToolStripMenuItem.Name = "DirectosToolStripMenuItem"
        DirectosToolStripMenuItem.Size = New Size(79, 25)
        DirectosToolStripMenuItem.Text = "Directos"
        ' 
        ' ListDataSecuencial
        ' 
        ListDataSecuencial.FormattingEnabled = True
        ListDataSecuencial.ItemHeight = 21
        ListDataSecuencial.Location = New Point(16, 255)
        ListDataSecuencial.Name = "ListDataSecuencial"
        ListDataSecuencial.Size = New Size(443, 256)
        ListDataSecuencial.TabIndex = 4
        ' 
        ' IDSecuencialText
        ' 
        IDSecuencialText.Location = New Point(61, 82)
        IDSecuencialText.Name = "IDSecuencialText"
        IDSecuencialText.Size = New Size(196, 29)
        IDSecuencialText.TabIndex = 5
        ' 
        ' NombreSecuencialText
        ' 
        NombreSecuencialText.Location = New Point(117, 140)
        NombreSecuencialText.Name = "NombreSecuencialText"
        NombreSecuencialText.Size = New Size(140, 29)
        NombreSecuencialText.TabIndex = 6
        ' 
        ' NotaSecuencialText
        ' 
        NotaSecuencialText.Location = New Point(87, 201)
        NotaSecuencialText.Name = "NotaSecuencialText"
        NotaSecuencialText.Size = New Size(170, 29)
        NotaSecuencialText.TabIndex = 7
        ' 
        ' CreateFileRegistredSecuencial
        ' 
        CreateFileRegistredSecuencial.ForeColor = SystemColors.ActiveCaptionText
        CreateFileRegistredSecuencial.Location = New Point(316, 82)
        CreateFileRegistredSecuencial.Name = "CreateFileRegistredSecuencial"
        CreateFileRegistredSecuencial.Size = New Size(120, 32)
        CreateFileRegistredSecuencial.TabIndex = 8
        CreateFileRegistredSecuencial.Text = "Crear archivo"
        CreateFileRegistredSecuencial.UseVisualStyleBackColor = True
        ' 
        ' OpenFileRegistredSecuencial
        ' 
        OpenFileRegistredSecuencial.ForeColor = SystemColors.ActiveCaptionText
        OpenFileRegistredSecuencial.Location = New Point(316, 140)
        OpenFileRegistredSecuencial.Name = "OpenFileRegistredSecuencial"
        OpenFileRegistredSecuencial.Size = New Size(120, 32)
        OpenFileRegistredSecuencial.TabIndex = 9
        OpenFileRegistredSecuencial.Text = "Abrir archivo"
        OpenFileRegistredSecuencial.UseVisualStyleBackColor = True
        ' 
        ' AddRegistredSecuencial
        ' 
        AddRegistredSecuencial.ForeColor = SystemColors.ActiveCaptionText
        AddRegistredSecuencial.Location = New Point(316, 198)
        AddRegistredSecuencial.Name = "AddRegistredSecuencial"
        AddRegistredSecuencial.Size = New Size(120, 32)
        AddRegistredSecuencial.TabIndex = 10
        AddRegistredSecuencial.Text = "Añadir registro"
        AddRegistredSecuencial.UseVisualStyleBackColor = True
        ' 
        ' PanelIndexados
        ' 
        PanelIndexados.Controls.Add(PanelDirectos)
        PanelIndexados.Controls.Add(AddRegistredIndexSecuencial)
        PanelIndexados.Controls.Add(OpenFileRegistredIndexSecuencial)
        PanelIndexados.Controls.Add(CreateFileRegistredIndexSecuencial)
        PanelIndexados.Controls.Add(ListDataSecuencialIndexed)
        PanelIndexados.Controls.Add(ListIndexSecuencialIndexed)
        PanelIndexados.Controls.Add(DatoSecuencialIndexadosText)
        PanelIndexados.Controls.Add(KeySecuencialIndexadosText)
        PanelIndexados.Controls.Add(Label5)
        PanelIndexados.Controls.Add(Label4)
        PanelIndexados.Dock = DockStyle.Fill
        PanelIndexados.Location = New Point(0, 31)
        PanelIndexados.Name = "PanelIndexados"
        PanelIndexados.Size = New Size(471, 493)
        PanelIndexados.TabIndex = 11
        PanelIndexados.Visible = False
        ' 
        ' PanelDirectos
        ' 
        PanelDirectos.Controls.Add(AddRegistredDirected)
        PanelDirectos.Controls.Add(OpenFileRegistredDirected)
        PanelDirectos.Controls.Add(CreateFileRegistredDirected)
        PanelDirectos.Controls.Add(NotaDirectedText)
        PanelDirectos.Controls.Add(NombreDirectedText)
        PanelDirectos.Controls.Add(IDDirectedText)
        PanelDirectos.Controls.Add(ListDataDirected)
        PanelDirectos.Controls.Add(Label6)
        PanelDirectos.Controls.Add(Label7)
        PanelDirectos.Controls.Add(Label8)
        PanelDirectos.Dock = DockStyle.Fill
        PanelDirectos.Location = New Point(0, 0)
        PanelDirectos.Name = "PanelDirectos"
        PanelDirectos.Size = New Size(471, 493)
        PanelDirectos.TabIndex = 9
        PanelDirectos.Visible = False
        ' 
        ' AddRegistredDirected
        ' 
        AddRegistredDirected.ForeColor = SystemColors.ActiveCaptionText
        AddRegistredDirected.Location = New Point(277, 166)
        AddRegistredDirected.Name = "AddRegistredDirected"
        AddRegistredDirected.Size = New Size(173, 32)
        AddRegistredDirected.TabIndex = 20
        AddRegistredDirected.Text = "Añadir registro"
        AddRegistredDirected.UseVisualStyleBackColor = True
        ' 
        ' OpenFileRegistredDirected
        ' 
        OpenFileRegistredDirected.ForeColor = SystemColors.ActiveCaptionText
        OpenFileRegistredDirected.Location = New Point(277, 108)
        OpenFileRegistredDirected.Name = "OpenFileRegistredDirected"
        OpenFileRegistredDirected.Size = New Size(173, 32)
        OpenFileRegistredDirected.TabIndex = 19
        OpenFileRegistredDirected.Text = "Abrir archivo directo"
        OpenFileRegistredDirected.UseVisualStyleBackColor = True
        ' 
        ' CreateFileRegistredDirected
        ' 
        CreateFileRegistredDirected.ForeColor = SystemColors.ActiveCaptionText
        CreateFileRegistredDirected.Location = New Point(277, 50)
        CreateFileRegistredDirected.Name = "CreateFileRegistredDirected"
        CreateFileRegistredDirected.Size = New Size(173, 32)
        CreateFileRegistredDirected.TabIndex = 18
        CreateFileRegistredDirected.Text = "Crear archivo directo"
        CreateFileRegistredDirected.UseVisualStyleBackColor = True
        ' 
        ' NotaDirectedText
        ' 
        NotaDirectedText.Location = New Point(87, 170)
        NotaDirectedText.Name = "NotaDirectedText"
        NotaDirectedText.Size = New Size(170, 29)
        NotaDirectedText.TabIndex = 17
        ' 
        ' NombreDirectedText
        ' 
        NombreDirectedText.Location = New Point(117, 109)
        NombreDirectedText.Name = "NombreDirectedText"
        NombreDirectedText.Size = New Size(140, 29)
        NombreDirectedText.TabIndex = 16
        ' 
        ' IDDirectedText
        ' 
        IDDirectedText.Location = New Point(61, 51)
        IDDirectedText.Name = "IDDirectedText"
        IDDirectedText.Size = New Size(196, 29)
        IDDirectedText.TabIndex = 15
        ' 
        ' ListDataDirected
        ' 
        ListDataDirected.FormattingEnabled = True
        ListDataDirected.ItemHeight = 21
        ListDataDirected.Location = New Point(16, 224)
        ListDataDirected.Name = "ListDataDirected"
        ListDataDirected.Size = New Size(443, 256)
        ListDataDirected.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(16, 105)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(94, 30)
        Label6.TabIndex = 13
        Label6.Text = "Nombre:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(16, 166)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 30)
        Label7.TabIndex = 12
        Label7.Text = "Nota:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(16, 47)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(39, 30)
        Label8.TabIndex = 11
        Label8.Text = "ID:"
        ' 
        ' AddRegistredIndexSecuencial
        ' 
        AddRegistredIndexSecuencial.ForeColor = SystemColors.ActiveCaptionText
        AddRegistredIndexSecuencial.Location = New Point(263, 131)
        AddRegistredIndexSecuencial.Name = "AddRegistredIndexSecuencial"
        AddRegistredIndexSecuencial.Size = New Size(196, 30)
        AddRegistredIndexSecuencial.TabIndex = 8
        AddRegistredIndexSecuencial.Text = "Añadir registro indexado"
        AddRegistredIndexSecuencial.UseVisualStyleBackColor = True
        ' 
        ' OpenFileRegistredIndexSecuencial
        ' 
        OpenFileRegistredIndexSecuencial.ForeColor = SystemColors.ActiveCaptionText
        OpenFileRegistredIndexSecuencial.Location = New Point(263, 91)
        OpenFileRegistredIndexSecuencial.Name = "OpenFileRegistredIndexSecuencial"
        OpenFileRegistredIndexSecuencial.Size = New Size(196, 30)
        OpenFileRegistredIndexSecuencial.TabIndex = 7
        OpenFileRegistredIndexSecuencial.Text = "Abrir archivo indexado"
        OpenFileRegistredIndexSecuencial.UseVisualStyleBackColor = True
        ' 
        ' CreateFileRegistredIndexSecuencial
        ' 
        CreateFileRegistredIndexSecuencial.ForeColor = SystemColors.ActiveCaptionText
        CreateFileRegistredIndexSecuencial.Location = New Point(263, 53)
        CreateFileRegistredIndexSecuencial.Name = "CreateFileRegistredIndexSecuencial"
        CreateFileRegistredIndexSecuencial.Size = New Size(196, 30)
        CreateFileRegistredIndexSecuencial.TabIndex = 6
        CreateFileRegistredIndexSecuencial.Text = "Crear archivo indexado"
        CreateFileRegistredIndexSecuencial.UseVisualStyleBackColor = True
        ' 
        ' ListDataSecuencialIndexed
        ' 
        ListDataSecuencialIndexed.FormattingEnabled = True
        ListDataSecuencialIndexed.ItemHeight = 21
        ListDataSecuencialIndexed.Location = New Point(251, 195)
        ListDataSecuencialIndexed.Name = "ListDataSecuencialIndexed"
        ListDataSecuencialIndexed.Size = New Size(208, 277)
        ListDataSecuencialIndexed.TabIndex = 5
        ' 
        ' ListIndexSecuencialIndexed
        ' 
        ListIndexSecuencialIndexed.FormattingEnabled = True
        ListIndexSecuencialIndexed.ItemHeight = 21
        ListIndexSecuencialIndexed.Location = New Point(16, 195)
        ListIndexSecuencialIndexed.Name = "ListIndexSecuencialIndexed"
        ListIndexSecuencialIndexed.Size = New Size(208, 277)
        ListIndexSecuencialIndexed.TabIndex = 4
        ' 
        ' DatoSecuencialIndexadosText
        ' 
        DatoSecuencialIndexadosText.Location = New Point(85, 91)
        DatoSecuencialIndexadosText.Name = "DatoSecuencialIndexadosText"
        DatoSecuencialIndexadosText.Size = New Size(150, 29)
        DatoSecuencialIndexadosText.TabIndex = 3
        ' 
        ' KeySecuencialIndexadosText
        ' 
        KeySecuencialIndexadosText.Location = New Point(73, 54)
        KeySecuencialIndexadosText.Name = "KeySecuencialIndexadosText"
        KeySecuencialIndexadosText.Size = New Size(162, 29)
        KeySecuencialIndexadosText.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(16, 87)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 30)
        Label5.TabIndex = 1
        Label5.Text = "Dato:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(16, 50)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 30)
        Label4.TabIndex = 0
        Label4.Text = "Key:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        ClientSize = New Size(471, 524)
        Controls.Add(PanelIndexados)
        Controls.Add(AddRegistredSecuencial)
        Controls.Add(OpenFileRegistredSecuencial)
        Controls.Add(CreateFileRegistredSecuencial)
        Controls.Add(NotaSecuencialText)
        Controls.Add(NombreSecuencialText)
        Controls.Add(IDSecuencialText)
        Controls.Add(ListDataSecuencial)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 12F)
        ForeColor = SystemColors.Control
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        PanelIndexados.ResumeLayout(False)
        PanelIndexados.PerformLayout()
        PanelDirectos.ResumeLayout(False)
        PanelDirectos.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SecuencialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DirectosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListDataSecuencial As ListBox
    Friend WithEvents IDSecuencialText As TextBox
    Friend WithEvents NombreSecuencialText As TextBox
    Friend WithEvents NotaSecuencialText As TextBox
    Friend WithEvents CreateFileRegistredSecuencial As Button
    Friend WithEvents OpenFileRegistredSecuencial As Button
    Friend WithEvents AddRegistredSecuencial As Button
    Friend WithEvents PanelIndexados As Panel
    Friend WithEvents AddRegistredIndexSecuencial As Button
    Friend WithEvents OpenFileRegistredIndexSecuencial As Button
    Friend WithEvents CreateFileRegistredIndexSecuencial As Button
    Friend WithEvents ListDataSecuencialIndexed As ListBox
    Friend WithEvents ListIndexSecuencialIndexed As ListBox
    Friend WithEvents DatoSecuencialIndexadosText As TextBox
    Friend WithEvents KeySecuencialIndexadosText As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelDirectos As Panel
    Friend WithEvents AddRegistredDirected As Button
    Friend WithEvents OpenFileRegistredDirected As Button
    Friend WithEvents CreateFileRegistredDirected As Button
    Friend WithEvents NotaDirectedText As TextBox
    Friend WithEvents NombreDirectedText As TextBox
    Friend WithEvents IDDirectedText As TextBox
    Friend WithEvents ListDataDirected As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label

End Class
