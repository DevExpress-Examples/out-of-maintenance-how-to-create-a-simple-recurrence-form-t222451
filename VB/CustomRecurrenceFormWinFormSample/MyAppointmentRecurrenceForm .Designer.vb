Namespace CustomRecurrenceFormWinFormSample
    Partial Public Class MyAppointmentRecurrenceForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.dailyRecurrenceControl1 = New DevExpress.XtraScheduler.UI.DailyRecurrenceControl()
            Me.monthlyRecurrenceControl1 = New DevExpress.XtraScheduler.UI.MonthlyRecurrenceControl()
            Me.weeklyRecurrenceControl1 = New DevExpress.XtraScheduler.UI.WeeklyRecurrenceControl()
            Me.yearlyRecurrenceControl1 = New DevExpress.XtraScheduler.UI.YearlyRecurrenceControl()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
            Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
            Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
            DirectCast(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            DirectCast(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dailyRecurrenceControl1
            ' 
            Me.dailyRecurrenceControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.dailyRecurrenceControl1.Appearance.Options.UseBackColor = True
            Me.dailyRecurrenceControl1.Location = New System.Drawing.Point(306, 24)
            Me.dailyRecurrenceControl1.Name = "dailyRecurrenceControl1"
            Me.dailyRecurrenceControl1.Size = New System.Drawing.Size(388, 96)
            Me.dailyRecurrenceControl1.TabIndex = 0
            Me.dailyRecurrenceControl1.Visible = False
            ' 
            ' monthlyRecurrenceControl1
            ' 
            Me.monthlyRecurrenceControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.monthlyRecurrenceControl1.Appearance.Options.UseBackColor = True
            Me.monthlyRecurrenceControl1.Location = New System.Drawing.Point(306, 24)
            Me.monthlyRecurrenceControl1.Name = "monthlyRecurrenceControl1"
            Me.monthlyRecurrenceControl1.Size = New System.Drawing.Size(388, 96)
            Me.monthlyRecurrenceControl1.TabIndex = 1
            Me.monthlyRecurrenceControl1.Visible = False
            ' 
            ' weeklyRecurrenceControl1
            ' 
            Me.weeklyRecurrenceControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.weeklyRecurrenceControl1.Appearance.Options.UseBackColor = True
            Me.weeklyRecurrenceControl1.Location = New System.Drawing.Point(306, 24)
            Me.weeklyRecurrenceControl1.Name = "weeklyRecurrenceControl1"
            Me.weeklyRecurrenceControl1.Size = New System.Drawing.Size(388, 96)
            Me.weeklyRecurrenceControl1.TabIndex = 2
            Me.weeklyRecurrenceControl1.Visible = False
            ' 
            ' yearlyRecurrenceControl1
            ' 
            Me.yearlyRecurrenceControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.yearlyRecurrenceControl1.Appearance.Options.UseBackColor = True
            Me.yearlyRecurrenceControl1.Location = New System.Drawing.Point(306, 24)
            Me.yearlyRecurrenceControl1.Name = "yearlyRecurrenceControl1"
            Me.yearlyRecurrenceControl1.Size = New System.Drawing.Size(388, 96)
            Me.yearlyRecurrenceControl1.TabIndex = 3
            Me.yearlyRecurrenceControl1.Visible = False
            ' 
            ' groupControl1
            ' 
            Me.groupControl1.Controls.Add(Me.radioGroup1)
            Me.groupControl1.Controls.Add(Me.btnCancel)
            Me.groupControl1.Controls.Add(Me.btnOK)
            Me.groupControl1.Controls.Add(Me.yearlyRecurrenceControl1)
            Me.groupControl1.Controls.Add(Me.weeklyRecurrenceControl1)
            Me.groupControl1.Controls.Add(Me.monthlyRecurrenceControl1)
            Me.groupControl1.Controls.Add(Me.dailyRecurrenceControl1)
            Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.groupControl1.Location = New System.Drawing.Point(0, 0)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(690, 325)
            Me.groupControl1.TabIndex = 0
            Me.groupControl1.Text = "Recurrence Pattern"
            ' 
            ' btnCancel
            ' 
            Me.btnCancel.Location = New System.Drawing.Point(383, 261)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 23)
            Me.btnCancel.TabIndex = 13
            Me.btnCancel.Text = "Cancel"
            ' 
            ' btnOK
            ' 
            Me.btnOK.Location = New System.Drawing.Point(265, 261)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(75, 23)
            Me.btnOK.TabIndex = 12
            Me.btnOK.Text = "OK"
            ' 
            ' radioGroup1
            ' 
            Me.radioGroup1.Location = New System.Drawing.Point(21, 37)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Properties.Columns = 1
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { _
                New DevExpress.XtraEditors.Controls.RadioGroupItem("Daily", "Daily"), _
                New DevExpress.XtraEditors.Controls.RadioGroupItem("Weekly", "Weekly"), _
                New DevExpress.XtraEditors.Controls.RadioGroupItem("Monthly", "Monthly"), _
                New DevExpress.XtraEditors.Controls.RadioGroupItem("Yearly", "Yearly") _
            })
            Me.radioGroup1.Size = New System.Drawing.Size(163, 176)
            Me.radioGroup1.TabIndex = 14
            ' 
            ' MyAppointmentRecurrenceForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(690, 325)
            Me.Controls.Add(Me.groupControl1)
            Me.Name = "MyAppointmentRecurrenceForm"
            Me.Text = "MyAppointmentRecurrenceForm"
            DirectCast(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            DirectCast(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private dailyRecurrenceControl1 As DevExpress.XtraScheduler.UI.DailyRecurrenceControl
        Private monthlyRecurrenceControl1 As DevExpress.XtraScheduler.UI.MonthlyRecurrenceControl
        Private weeklyRecurrenceControl1 As DevExpress.XtraScheduler.UI.WeeklyRecurrenceControl
        Private yearlyRecurrenceControl1 As DevExpress.XtraScheduler.UI.YearlyRecurrenceControl
        Private groupControl1 As DevExpress.XtraEditors.GroupControl
        Private btnCancel As DevExpress.XtraEditors.SimpleButton
        Private btnOK As DevExpress.XtraEditors.SimpleButton
        Private radioGroup1 As DevExpress.XtraEditors.RadioGroup

    End Class
End Namespace