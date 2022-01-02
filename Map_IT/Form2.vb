
Imports System
Imports System.Text
Imports System.IO
Imports System.Threading
Imports System.CodeDom.Compiler
Imports Microsoft.CSharp
Imports System.Collections.Generic

Public Class Form2

    Dim batchpath As String = Nothing
    Dim iconpath As String = Nothing
    Dim bindfilepath As String = Nothing
    Dim bindfilename As String = Nothing
    Dim outputfile As String = Nothing
    Dim src As String = My.Resources.stub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


    Private Sub Compile(ByVal Exename As String, ByVal SourceCode As String, ByVal Icon As String)
        Dim compiler As CodeDomProvider = CodeDomProvider.CreateProvider("VisualBasic")
        Dim param As New CompilerParameters
        Dim results As CompilerResults = Nothing
        param.GenerateExecutable = True
        param.OutputAssembly = Exename
        param.ReferencedAssemblies.Add("System.dll")
        param.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")
        param.CompilerOptions = " /target:winexe"
        param.TreatWarningsAsErrors = False
        If (Icon = Nothing) Then
            'do nothing
        Else

            File.Copy(Icon, "icon.ico")
            param.CompilerOptions += " /win32icon:" & "icon.ico"
        End If

        results = compiler.CompileAssemblyFromSource(param, SourceCode)

        If (results.Errors.Count <> 0) Then
            MsgBox("Some Error Occured, Try Again", MsgBoxStyle.Critical)
            For Each E As CompilerError In results.Errors
                MessageBox.Show(E.ErrorText)
            Next
        End If

        If (Icon = Nothing) Then
            'do nothing
        Else
            File.Delete("icon.ico")
        End If

    End Sub

    Function secure(ByVal data As Byte()) As Byte()
        Using SA As New System.Security.Cryptography.RijndaelManaged
            SA.IV = New Byte() {1, 9, 2, 8, 3, 7, 4, 5, 6, 0, 1, 4, 3, 0, 0, 7}
            SA.Key = New Byte() {7, 0, 0, 3, 4, 1, 0, 6, 5, 4, 7, 3, 8, 2, 9, 1}
            Return SA.CreateEncryptor.TransformFinalBlock(data, 0, data.Length)
        End Using
    End Function

    Sub Replace(ByRef main As String, ByVal old As String, ByVal [new] As String)
        main = main.Replace(old, [new])
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim src As String = Nothing
        Dim Compressor As Boolean = False

        If iconBox1.Checked = False Then
            iconpath = Nothing

        End If

        Using s As New SaveFileDialog()
            s.Title = "Save file"
            s.Filter = "Executable |*.exe"
            If (s.ShowDialog = Windows.Forms.DialogResult.OK) Then
                outputfile = s.FileName

                src = My.Resources.stub








                Try

                    Compile(outputfile, src, iconpath)

                    ' Writing Files into stub 
                    Dim sp As String = "[SPLITTING_POINT]"
                    Dim batchf As Byte() = secure(My.Computer.FileSystem.ReadAllBytes(batchpath))



                    System.IO.File.AppendAllText(outputfile, sp & Convert.ToBase64String(batchf))
                    MessageBox.Show("Exe file has been created" + Environment.NewLine + outputfile, "Success")

                Catch ex As Exception

                    MsgBox("Some error occured", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End Try



            End If
        End Using
    End Sub





    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

        Using O As New OpenFileDialog()
            O.Title = "Select Batch File"
            O.Filter = "Batch File|*.bat"
            If O.ShowDialog = Windows.Forms.DialogResult.OK Then
                batchpath = O.FileName
                Label3.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub iconBox_CheckedChanged(sender As Object, e As EventArgs) Handles iconBox1.CheckedChanged
        If iconBox1.Checked = True Then
            iconFilePath1.Visible = True
        Else
            iconFilePath1.Visible = False
        End If
    End Sub

    Private Sub iconFilePath1_Click(sender As Object, e As EventArgs) Handles iconFilePath1.Click
        If iconBox1.Checked = True Then
            Using O As New OpenFileDialog()
                O.Title = "Select Icon File.."
                O.Filter = "Icon File|*.ico"
                If O.ShowDialog = Windows.Forms.DialogResult.OK Then
                    iconpath = O.FileName
                    iconFilePath1.Text = O.SafeFileName
                End If
            End Using
        Else
            iconpath = Nothing
        End If

    End Sub





    ' Private Function components() As Object
    '  Throw New NotImplementedException
    '  End Function





End Class