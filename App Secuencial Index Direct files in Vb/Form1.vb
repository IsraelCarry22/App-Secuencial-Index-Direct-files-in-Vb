Imports System.IO
Imports System.Text

Public Class Form1
    Public dataSecuencialFilePath As String

    Public indexSecuencialIndexFilePath As String
    Public dataSecuencialIndexFilePath As String

    Public dataDirectedFilePath As String


    Private Sub CreateFileRegistredSecuencial_Click(sender As Object, e As EventArgs) Handles CreateFileRegistredSecuencial.Click
        Using FolderPath As New FolderBrowserDialog
            If FolderPath.ShowDialog <> DialogResult.OK Then
                Return
            End If

            GenerateFile(FolderPath.SelectedPath)
        End Using
    End Sub

    Public Sub GenerateFile(ByVal filePath As String)
        dataSecuencialFilePath = Path.Combine(filePath, "datosSecuencialesVB.dat")

        If File.Exists(dataSecuencialFilePath) Then
            Return
        End If

        Using FileStream As FileStream = File.Create(dataSecuencialFilePath)
        End Using
    End Sub


    Private Sub OpenFileRegistredSecuencial_Click(sender As Object, e As EventArgs) Handles OpenFileRegistredSecuencial.Click
        Dim OpenFile As New OpenFileDialog

        If OpenFile.ShowDialog <> DialogResult.OK Then
            Return
        End If

        dataSecuencialFilePath = OpenFile.FileName

        UpdateList()
    End Sub

    Private Sub UpdateList()
        ListDataSecuencial.Items.Clear()

        If File.Exists(dataSecuencialFilePath) Then
            Dim Regitre As New List(Of String)(File.ReadAllLines(dataSecuencialFilePath))

            ListDataSecuencial.Items.AddRange(Regitre.ToArray())
        End If
    End Sub

    Private Sub AddRegistredSecuencial_Click(sender As Object, e As EventArgs) Handles AddRegistredSecuencial.Click
        If String.IsNullOrEmpty(dataSecuencialFilePath) Then
            Return
        End If

        Dim Id = IDSecuencialText.Text
        Dim Name = NombreSecuencialText.Text
        Dim Note = NotaSecuencialText.Text

        If Not String.IsNullOrEmpty(Id) AndAlso Not String.IsNullOrEmpty(Name) AndAlso Not String.IsNullOrEmpty(Note) Then
            AddInformationSecuencial(Id, Name, Note)

            IDSecuencialText.Clear()
            NombreSecuencialText.Clear()
            NotaSecuencialText.Clear()

            UpdateList()
        End If

        UpdateList()
    End Sub

    Private Sub AddInformationSecuencial(ByVal Id As String, ByVal Name As String, ByVal Note As String)
        Using writer As New StreamWriter(dataSecuencialFilePath, True)
            writer.WriteLine($"{Id},{Name},{Note}")
        End Using
    End Sub

    Private Sub SecuencialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SecuencialToolStripMenuItem.Click
        PanelIndexados.Visible = False
    End Sub

    Private Sub IndexadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndexadosToolStripMenuItem.Click
        PanelIndexados.Visible = True
        PanelDirectos.Visible = False
    End Sub

    Private Sub CreateFileRegistredIndexSecuencial_Click(sender As Object, e As EventArgs) Handles CreateFileRegistredIndexSecuencial.Click
        Using FolderPath As New FolderBrowserDialog()
            If FolderPath.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            GenerateFileIndexed(FolderPath.SelectedPath)
        End Using
    End Sub

    Public Sub GenerateFileIndexed(ByVal filePath As String)
        indexSecuencialIndexFilePath = Path.Combine(filePath, "indexVB.dat")
        dataSecuencialIndexFilePath = Path.Combine(filePath, "datosIndexadaVB.dat")

        If File.Exists(indexSecuencialIndexFilePath) Then
            Return
        End If

        Using FileStream As FileStream = File.Create(indexSecuencialIndexFilePath)
        End Using

        If File.Exists(dataSecuencialIndexFilePath) Then
            Return
        End If

        Using FileStream As FileStream = File.Create(dataSecuencialIndexFilePath)
        End Using
    End Sub

    Private Sub OpenFileRegistredIndexSecuencial_Click(sender As Object, e As EventArgs) Handles OpenFileRegistredIndexSecuencial.Click
        Dim OpenFile As New OpenFileDialog()

        If OpenFile.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        indexSecuencialIndexFilePath = OpenFile.FileName

        If OpenFile.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        dataSecuencialIndexFilePath = OpenFile.FileName

        UpdateListIndexed()
    End Sub

    Private Sub UpdateListIndexed()
        ListIndexSecuencialIndexed.Items.Clear()
        ListDataSecuencialIndexed.Items.Clear()

        If Not File.Exists(indexSecuencialIndexFilePath) Then
            Return
        End If

        Dim indexLines As New List(Of String)(File.ReadAllLines(indexSecuencialIndexFilePath))

        For Each line As String In indexLines
            Dim parts As String() = line.Split(":"c)

            ListIndexSecuencialIndexed.Items.Add($"{parts(0)} : {parts(1)} : {parts(2)}")
        Next

        If Not File.Exists(dataSecuencialIndexFilePath) Then
            Return
        End If

        Dim dataLines As New List(Of String)(File.ReadAllLines(dataSecuencialIndexFilePath))

        For Each line As String In dataLines
            Dim parts As String() = line.Split(":"c)

            ListDataSecuencialIndexed.Items.Add($"{parts(0)} - {parts(1)}")
        Next
    End Sub

    Private Sub AddRegistredIndexSecuencial_Click(sender As Object, e As EventArgs) Handles AddRegistredIndexSecuencial.Click
        Dim clave As String = KeySecuencialIndexadosText.Text
        Dim dato As String = DatoSecuencialIndexadosText.Text

        If Not String.IsNullOrEmpty(clave) AndAlso Not String.IsNullOrEmpty(dato) Then
            AddInformationIndexed(clave, dato)

            KeySecuencialIndexadosText.Clear()
            DatoSecuencialIndexadosText.Clear()

            UpdateListIndexed()
        End If
    End Sub

    Private Sub AddInformationIndexed(ByVal clave As String, ByVal dato As String)
        Using dataWriter As New StreamWriter(dataSecuencialIndexFilePath, True)
            dataWriter.WriteLine($"{clave},{dato}")
        End Using

        Using indexWriter As New StreamWriter(indexSecuencialIndexFilePath, True)
            Dim offset As Long = ObtenerOffset(dataSecuencialIndexFilePath)
            indexWriter.WriteLine($"{clave}:{dato}:{offset}")
        End Using
    End Sub

    Private Function ObtenerOffset(ByVal filePath As String) As Long
        Using fs As New FileStream(filePath, FileMode.Open, FileAccess.Read)
            Return fs.Length
        End Using
    End Function

    Private Sub DirectosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectosToolStripMenuItem.Click
        PanelIndexados.Visible = True
        PanelDirectos.Visible = True
    End Sub

    Private Sub CreateFileRegistredDirected_Click(sender As Object, e As EventArgs) Handles CreateFileRegistredDirected.Click
        Using FolderPath As New FolderBrowserDialog
            If FolderPath.ShowDialog <> DialogResult.OK Then
                Return
            End If

            GenerateFileDirected(FolderPath.SelectedPath)
        End Using
    End Sub

    Public Sub GenerateFileDirected(ByVal filePath As String)
        dataDirectedFilePath = Path.Combine(filePath, "dataDirectedVB.dat")

        If File.Exists(dataDirectedFilePath) Then
            Return
        End If

        Using FileStream As FileStream = File.Create(dataDirectedFilePath)
        End Using
    End Sub

    Private Sub OpenFileRegistredDirected_Click(sender As Object, e As EventArgs) Handles OpenFileRegistredDirected.Click
        Dim OpenFile As New OpenFileDialog

        If OpenFile.ShowDialog <> DialogResult.OK Then
            Return
        End If

        dataDirectedFilePath = OpenFile.FileName

        UpdateListDireted()
    End Sub

    Private Sub UpdateListDireted()
        ListDataDirected.Items.Clear()

        Using fileStream As New FileStream(dataDirectedFilePath, FileMode.Open, FileAccess.Read)
            Dim fileSize As Long = fileStream.Length

            While fileStream.Position < fileSize
                Using reader As New BinaryReader(fileStream, Encoding.UTF8, True)
                    Dim id As String = Encoding.UTF8.GetString(reader.ReadBytes(10)).Trim()
                    Dim nombre As String = Encoding.UTF8.GetString(reader.ReadBytes(50)).Trim()
                    Dim nota As String = Encoding.UTF8.GetString(reader.ReadBytes(40)).Trim()

                    ListDataDirected.Items.Add($"ID: {id}, Nombre: {nombre}, Nota: {nota}")
                End Using
            End While
        End Using
    End Sub

    Private Sub AddRegistredDirected_Click(sender As Object, e As EventArgs) Handles AddRegistredDirected.Click
        Dim id As String = IDDirectedText.Text.PadRight(10)
        Dim nombre As String = NombreDirectedText.Text.PadRight(50)
        Dim nota As String = NotaDirectedText.Text.PadRight(40)

        If String.IsNullOrEmpty(id) AndAlso String.IsNullOrEmpty(nombre) AndAlso String.IsNullOrEmpty(nota) Then
            Return
        End If

        AddInformationDirected(id, nombre, nota)

        IDDirectedText.Clear()
        NombreDirectedText.Clear()
        NotaDirectedText.Clear()

        UpdateListDireted()
    End Sub

    Private Sub AddInformationDirected(ByVal id As String, ByVal nombre As String, ByVal nota As String)
        Using fileStream As New FileStream(dataDirectedFilePath, FileMode.Append, FileAccess.Write)
            Using writer As New BinaryWriter(fileStream)
                writer.Write(Encoding.UTF8.GetBytes(id))
                writer.Write(Encoding.UTF8.GetBytes(nombre))
                writer.Write(Encoding.UTF8.GetBytes(nota))
            End Using
        End Using
    End Sub
End Class
