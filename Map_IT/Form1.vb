Imports System
Imports System.Text
Imports System.IO
Imports System.Threading
Imports System.CodeDom.Compiler
Imports Microsoft.CSharp
Imports System.Collections.Generic


Public Class Form1
    Dim map1 As String
    Dim map2 As String
    Dim num As Integer = 0
    Dim mapNumber As Integer = 1
    Dim iconpath As String = Nothing




    Dim outputfile As String = Nothing
    Dim src As String = My.Resources.stub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mapList.DefaultCellStyle.Font = New Font(mapList.Font.FontFamily, 7, FontStyle.Regular)
        mapList.ColumnHeadersDefaultCellStyle.Font = New Font(mapList.Font.FontFamily, 7, FontStyle.Regular)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub button_Click(sender As Object, e As EventArgs) Handles button.Click
        Dim persistentVal As String
        Dim savecredsVal As String
        Dim mapNumber As Integer = mapList.Rows.Count + 1
        If persistent.Checked = True Then
            persistentVal = "yes"
        Else
            persistentVal = "no"
        End If

        If serverPath.Text = "" Or shortcutName.Text = "" Or serverUsername.Text = "" Or serverPassword.Text = "" Or driveLetter.SelectedItem = "" Then
            MessageBox.Show("Incomplete")
        Else

            mapList.Rows.Insert(mapList.Rows.Count, New String() {"Map " + mapNumber.ToString, serverPath.Text.ToString(), driveLetter.SelectedItem.ToString, shortcutName.Text.ToString(), serverUsername.Text.ToString, serverPassword.Text.ToString, persistentVal})
            MessageBox.Show("Added to list")
        End If




    End Sub
    Function secure(ByVal data As Byte()) As Byte()
        Using SA As New System.Security.Cryptography.RijndaelManaged
            SA.IV = New Byte() {1, 9, 2, 8, 3, 7, 4, 5, 6, 0, 1, 4, 3, 0, 0, 7}
            SA.Key = New Byte() {7, 0, 0, 3, 4, 1, 0, 6, 5, 4, 7, 3, 8, 2, 9, 1}
            Return SA.CreateEncryptor.TransformFinalBlock(data, 0, data.Length)
        End Using
    End Function

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
            MsgBox("Some Error Occured During Code Compiletion, Try Again!!", MsgBoxStyle.Critical)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FILE_NAME As String = "MAPIT.bat"
        Dim FILE_PATH As String = "C:\MAP_IT\"
        Dim FULL_PATH As String = FILE_PATH + FILE_NAME

        If iconBox.Checked = False Then
            iconpath = Nothing

        End If

        If mapList.Rows.Count = 0 Then
            MessageBox.Show("Map list is empty", "Failed")
        Else
            writeFile()
            createEXE()


        End If





    End Sub

    Public Sub writeFile()
        num = 0
        mapNumber = 1

        Dim FILE_NAME As String = "MAPIT.bat"
        Dim FILE_PATH As String = "C:\MAP_IT\"
        Dim FULL_PATH As String = FILE_PATH + FILE_NAME


        If System.IO.File.Exists(FULL_PATH) = True Then

            '  Dim stringToCleanUp As String = mapList.Rows(num).Cells(1).Value.ToString()
            '   Dim characterToRemove As String = "\"
            '   Dim cleanString As String = Replace(stringToCleanUp, characterToRemove, "")

            Dim objWriter As New System.IO.StreamWriter(FULL_PATH)

            objWriter.Write("@echo off" + Environment.NewLine)
            objWriter.Write("Net USE * /DELETE /YES" + Environment.NewLine)

            For rowNum = 1 To mapList.Rows.Count


                objWriter.Write(":map" + mapNumber.ToString + Environment.NewLine)
                '  objWriter.Write("cmdkey /delete:" + cleanString + Environment.NewLine)
                '  objWriter.Write("cmdkey /add:" + cleanString + " /user:" + mapList.Rows(num).Cells(4).Value.ToString() + " /pass:" + mapList.Rows(num).Cells(5).Value.ToString() + Environment.NewLine + Environment.NewLine)
                objWriter.Write("Net use " + mapList.Rows(num).Cells(2).Value.ToString() + " """ + mapList.Rows(num).Cells(1).Value.ToString() + """ /user:" + mapList.Rows(num).Cells(4).Value.ToString() + " " + mapList.Rows(num).Cells(5).Value.ToString() + " /persistent:" + mapList.Rows(num).Cells(6).Value.ToString() + Environment.NewLine)
                objWriter.Write("set SCRIPT=""%TEMP%\%RANDOM%-%RANDOM%-%RANDOM%-%RANDOM%.vbs""" + Environment.NewLine)
                objWriter.Write("echo Set oWS = WScript.CreateObject(""WScript.Shell"") >> %SCRIPT%" + Environment.NewLine)
                objWriter.Write("echo sLinkFile = ""%USERPROFILE%\Desktop\" + mapList.Rows(num).Cells(3).Value.ToString() + ".lnk"" >> %SCRIPT%" + Environment.NewLine)
                objWriter.Write("echo Set oLink = oWS.CreateShortcut(sLinkFile) >> %SCRIPT%" + Environment.NewLine)
                objWriter.Write("echo oLink.TargetPath = """ + mapList.Rows(num).Cells(2).Value.ToString() + "\"" >> %SCRIPT%" + Environment.NewLine)
                objWriter.Write("echo oLink.Save >> %SCRIPT%" + Environment.NewLine)
                objWriter.Write("cscript /nologo %SCRIPT%" + Environment.NewLine)
                objWriter.Write("del %SCRIPT%" + Environment.NewLine + Environment.NewLine)

                num += 1
                mapNumber += 1

            Next



            'last part

            '    objWriter.Write("If EXIST Then C:\ADMIN_WSUS\" + FILE_NAME + " (" + Environment.NewLine)
            '       objWriter.Write("GoTo : create" + Environment.NewLine)
            '     objWriter.Write(")" + Environment.NewLine)
            '      objWriter.Write("Exit" + Environment.NewLine + Environment.NewLine)
            '       objWriter.Write("create" + Environment.NewLine)
            '      objWriter.Write("set TARGET=C:\ADMIN_WSUS\" + FILE_NAME + Environment.NewLine)
            '      objWriter.Write("set SCRIPT3=""%TEMP%\%RANDOM%-%RANDOM%-%RANDOM%-%RANDOM%.vbs""" + Environment.NewLine)
            '      objWriter.Write("echo Set oWS = WScript.CreateObject(""WScript.Shell"") >> %SCRIPT3%" + Environment.NewLine)
            '     objWriter.Write("echo sLinkFile = ""%USERPROFILE%\Desktop\Remap.lnk"" >> %SCRIPT3%" + Environment.NewLine)
            '     objWriter.Write("echo Set oLink = oWS.CreateShortcut(sLinkFile) >> %SCRIPT3%" + Environment.NewLine)
            '     objWriter.Write("echo oLink.IconLocation = ""C:\Windows\System32\SHELL32.dll, 238"" >> %SCRIPT3%" + Environment.NewLine)
            '     objWriter.Write("echo oLink.TargetPath = ""%TARGET%"" >> %SCRIPT3%" + Environment.NewLine)
            '     objWriter.Write("echo oLink.Save >> %SCRIPT3%" + Environment.NewLine)
            '     objWriter.Write("cscript / nologo %SCRIPT3%" + Environment.NewLine)
            '     objWriter.Write("del %SCRIPT3%" + Environment.NewLine)

            objWriter.Write("Exit" + Environment.NewLine)


            objWriter.Close()




        Else
            System.IO.Directory.CreateDirectory(FILE_PATH)
            System.IO.File.Create(FULL_PATH).Dispose()
            writeFile()


        End If
    End Sub

    Public Sub createEXE()
        Dim src As String = Nothing
        Dim Compressor As Boolean = False
        Dim FILE_NAME As String = "MAPIT.bat"
        Dim FILE_PATH As String = "C:\MAP_IT\"
        Dim FULL_PATH As String = FILE_PATH + FILE_NAME


        '    Using s As New SaveFileDialog()
        '  s.Title = "Save File ...!!"
        '   s.Filter = "Executable |*.exe"
        '  If (s.ShowDialog = Windows.Forms.DialogResult.OK) Then
        '  outputfile = s.FileName
        outputfile = FILE_PATH + "MAPIT.exe"

        src = My.Resources.stub



        Try

            Compile(outputfile, src, iconpath)

            ' Writing Files into stub 
            Dim sp As String = "[SPLITTING_POINT]"
            Dim batchf As Byte() = secure(My.Computer.FileSystem.ReadAllBytes(FULL_PATH))

            System.IO.File.AppendAllText(outputfile, sp & Convert.ToBase64String(batchf))
            My.Computer.FileSystem.DeleteFile(FULL_PATH)
            MessageBox.Show("Exe file has been created" + Environment.NewLine + outputfile, "Success")

        Catch ex As Exception

            MsgBox("Some error occured", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try



        '     End If
        '   End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        If mapList.Rows.Count = 0 Then
            MessageBox.Show("Map list is empty", "Failed")
        Else
            writeFile()
        End If






        '  StatusDataGridView.Rows(rowKey).Cells(3).Value
    End Sub



    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles clearButton.Click
        mapList.Rows.Clear()
    End Sub

    Private Sub hiddenLocation_Click(sender As Object, e As EventArgs)
        Dim hiddenDirectory As String
        ' hiddenDirectory = Microsoft.VisualBasic.InputBox("Hidden location directory", "MAP_IT", hiddenLocation.Text, Me.Location.X + 50, Me.Location.Y)
        If hiddenDirectory <> "" Then
            '     hiddenLocation.Text = hiddenDirectory
        Else
            MessageBox.Show("Empty", "Failed")
        End If

    End Sub


    Private Sub iconFilePath_Click(sender As Object, e As EventArgs) Handles iconFilePath.Click
        If iconBox.Checked = True Then
            Using O As New OpenFileDialog()
                O.Title = "Select Icon File.."
                O.Filter = "Icon File|*.ico"
                If O.ShowDialog = Windows.Forms.DialogResult.OK Then
                    iconpath = O.FileName
                    iconFilePath.Text = O.SafeFileName
                End If
            End Using
        Else
            iconpath = Nothing
        End If

    End Sub

    Private Sub iconBox_CheckedChanged(sender As Object, e As EventArgs) Handles iconBox.CheckedChanged
        If iconBox.Checked = True Then
            iconFilePath.Visible = True
        Else
            iconFilePath.Visible = False
        End If
    End Sub


    Private Sub ToolStripLabel6_Click(sender As Object, e As EventArgs) Handles ToolStripLabel6.Click
        If mapList.Visible = True Then
            mapList.Visible = False
            clearButton.Visible = False
            ToolStripLabel6.Text = "Mappings"
            GroupBox2.Visible = True
            iconBox.Visible = True
            If iconBox.Checked = True Then
                iconFilePath.Visible = True
            End If
        Else

            mapList.Visible = True
            mapList.BringToFront()
            clearButton.Visible = True
            ToolStripLabel6.Text = "Hide list"
            GroupBox2.Visible = False
            iconBox.Visible = False
            iconFilePath.Visible = False
            If iconBox.Checked = False Then
                iconFilePath.Visible = False
            End If

        End If
    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripLabel5.Click
        Form2.Show()
    End Sub

    Private Sub mapList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles mapList.CellContentClick

    End Sub
End Class
