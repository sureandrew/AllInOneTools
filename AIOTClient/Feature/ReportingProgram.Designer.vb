﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportingProgram
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.txtAttachment = New System.Windows.Forms.TextBox()
        Me.txtMessage = New System.Windows.Forms.RichTextBox()
        Me.Send = New System.Windows.Forms.Button()
        Me.lblsubject = New System.Windows.Forms.Label()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.lblto = New System.Windows.Forms.Label()
        Me.lblfrom = New System.Windows.Forms.Label()
        Me.GroupLogin = New System.Windows.Forms.GroupBox()
        Me.GroupLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Location = New System.Drawing.Point(6, 19)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(55, 13)
        Me.lbluser.TabIndex = 25
        Me.lbluser.Text = "Username"
        '
        'btnclose
        '
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.Location = New System.Drawing.Point(342, 200)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 66
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(261, 28)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.ReadOnly = True
        Me.txtTo.Size = New System.Drawing.Size(140, 20)
        Me.txtTo.TabIndex = 58
        Me.txtTo.Text = "o2psoftlabs@gmail.com"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(67, 16)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(100, 20)
        Me.txtUserName.TabIndex = 22
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(67, 42)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 23
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(261, 54)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.ReadOnly = True
        Me.txtSubject.Size = New System.Drawing.Size(193, 20)
        Me.txtSubject.TabIndex = 59
        Me.txtSubject.Text = "Reporting Program"
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(261, 2)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(140, 20)
        Me.txtFrom.TabIndex = 57
        '
        'txtAttachment
        '
        Me.txtAttachment.Location = New System.Drawing.Point(5, 95)
        Me.txtAttachment.Name = "txtAttachment"
        Me.txtAttachment.Size = New System.Drawing.Size(179, 20)
        Me.txtAttachment.TabIndex = 55
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(261, 80)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(200, 114)
        Me.txtMessage.TabIndex = 60
        Me.txtMessage.Text = "<example:I Running My Program But Have Bug...I Got SS And This Using My Friend Pr" & _
            "ograms Of Client>" & Global.Microsoft.VisualBasic.ChrW(10) & "<For Attach Using Add Button>"
        '
        'Send
        '
        Me.Send.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Send.Location = New System.Drawing.Point(261, 200)
        Me.Send.Name = "Send"
        Me.Send.Size = New System.Drawing.Size(75, 23)
        Me.Send.TabIndex = 56
        Me.Send.Text = "Send"
        Me.Send.UseVisualStyleBackColor = True
        '
        'lblsubject
        '
        Me.lblsubject.AutoSize = True
        Me.lblsubject.Location = New System.Drawing.Point(195, 54)
        Me.lblsubject.Name = "lblsubject"
        Me.lblsubject.Size = New System.Drawing.Size(43, 13)
        Me.lblsubject.TabIndex = 64
        Me.lblsubject.Text = "Subject"
        '
        'lblmsg
        '
        Me.lblmsg.AutoSize = True
        Me.lblmsg.Location = New System.Drawing.Point(195, 83)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(50, 13)
        Me.lblmsg.TabIndex = 65
        Me.lblmsg.Text = "Message"
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Location = New System.Drawing.Point(72, 121)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(50, 26)
        Me.btnAdd.TabIndex = 54
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Location = New System.Drawing.Point(6, 45)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(53, 13)
        Me.lblpass.TabIndex = 25
        Me.lblpass.Text = "Password"
        '
        'lblto
        '
        Me.lblto.AutoSize = True
        Me.lblto.Location = New System.Drawing.Point(195, 31)
        Me.lblto.Name = "lblto"
        Me.lblto.Size = New System.Drawing.Size(20, 13)
        Me.lblto.TabIndex = 63
        Me.lblto.Text = "To"
        '
        'lblfrom
        '
        Me.lblfrom.AutoSize = True
        Me.lblfrom.Location = New System.Drawing.Point(195, 5)
        Me.lblfrom.Name = "lblfrom"
        Me.lblfrom.Size = New System.Drawing.Size(30, 13)
        Me.lblfrom.TabIndex = 62
        Me.lblfrom.Text = "From"
        '
        'GroupLogin
        '
        Me.GroupLogin.Controls.Add(Me.lblpass)
        Me.GroupLogin.Controls.Add(Me.lbluser)
        Me.GroupLogin.Controls.Add(Me.txtUserName)
        Me.GroupLogin.Controls.Add(Me.txtPass)
        Me.GroupLogin.Location = New System.Drawing.Point(5, 6)
        Me.GroupLogin.Name = "GroupLogin"
        Me.GroupLogin.Size = New System.Drawing.Size(179, 83)
        Me.GroupLogin.TabIndex = 61
        Me.GroupLogin.TabStop = False
        Me.GroupLogin.Text = "Login"
        '
        'ReportingProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 227)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.txtAttachment)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.Send)
        Me.Controls.Add(Me.lblsubject)
        Me.Controls.Add(Me.lblmsg)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblto)
        Me.Controls.Add(Me.lblfrom)
        Me.Controls.Add(Me.GroupLogin)
        Me.Name = "ReportingProgram"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Program Reporting"
        Me.GroupLogin.ResumeLayout(False)
        Me.GroupLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtAttachment As System.Windows.Forms.TextBox
    Friend WithEvents txtMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents Send As System.Windows.Forms.Button
    Friend WithEvents lblsubject As System.Windows.Forms.Label
    Friend WithEvents lblmsg As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents lblto As System.Windows.Forms.Label
    Friend WithEvents lblfrom As System.Windows.Forms.Label
    Friend WithEvents GroupLogin As System.Windows.Forms.GroupBox
End Class
