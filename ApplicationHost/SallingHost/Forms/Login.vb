Imports DevExpress.XtraExport
Imports DevExpress.XtraEditors.Controls

Namespace Salling.SallingHost
    Public Class Login

        Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' *** Load application Brand Image
            ' Application Brand Path
            Dim ApplicationIntro As String = Application.StartupPath & "\Assets\login.jpg"
            ' Check if it Exist
            If IO.File.Exists(ApplicationIntro) Then
                ' Convert it to image data
                Dim ApplicationIntroImage As Image = Image.FromFile(ApplicationIntro)
                ' Dim ApplicationIntroData() As Byte = ByteImageConverter.ToByteArray(ApplicationIntroImage, ApplicationIntroImage.RawFormat)
                ' Assign image to control
                ' ImgBrand.EditValue = ApplicationIntroData
            End If
        End Sub

        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            ' Close The Application
            'Application.Exit()
            Me.DialogResult = Windows.Forms.DialogResult.No
        End Sub

        Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
            ' Check if username and password have value
            If TxtUsername.Text = "" And TxtPassword.Text = "" Then
                ' there is no value then show message to user
                MsgBox("Enter Username and Password!")
            Else
                ' Check user login data from database
                If Salling.Security.Users.AuthonicateUser(TxtUsername.Text, TxtPassword.Text) Is Nothing Then
                    ' if user not found then inform it
                    MsgBox("Username Or Password is incorrect!")
                Else
                    ' if this is vaild user then hide login form
                    'Me.Hide()
                    ' Declear Mainform With loaded plugins
                    'Dim MainForm As New MainForm(PluginsLoader.GetLoadedPlugins)
                    ' Show Main Form
                    'MainForm.Show()
                    Me.DialogResult = Windows.Forms.DialogResult.Yes
                End If
            End If
        End Sub

        Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
            ' Perform BtnLogin click When press enter at end of typing password
            If e.KeyCode = Keys.Enter Then
                BtnLogin.PerformClick()
            End If
        End Sub
    End Class
End Namespace