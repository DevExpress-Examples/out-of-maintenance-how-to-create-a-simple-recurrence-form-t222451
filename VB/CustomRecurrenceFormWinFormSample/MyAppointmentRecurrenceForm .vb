Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.UI
Imports System
Imports System.Windows.Forms

Namespace CustomRecurrenceFormWinFormSample
    Partial Public Class MyAppointmentRecurrenceForm
        Inherits Form

        Private currentRecurrenceControl As RecurrenceControlBase
        Private rinfo As RecurrenceInfo
        Private controller As AppointmentFormController
        Private patternCopy As Appointment
        Private firstDayOfWeek As FirstDayOfWeek
        Protected suspendUpdateCount As Integer
        Protected ReadOnly Property IsUpdateSuspended() As Boolean
            Get
                Return suspendUpdateCount > 0
            End Get
        End Property

        Public Sub New(ByVal scheduler_control As SchedulerControl, ByVal apt As Appointment)

            InitializeComponent()
            ' Create a controller instance.
            controller = New AppointmentFormController(scheduler_control, apt)
            ' Get an appointment pattern copy.
            patternCopy = controller.PrepareToRecurrenceEdit()
            ' Get access to the recurrence information.
            Me.rinfo = patternCopy.RecurrenceInfo
            ' Get the first day of the week.
            firstDayOfWeek = scheduler_control.OptionsView.FirstDayOfWeek

            AddHandler radioGroup1.EditValueChanged, AddressOf radioGroup1_EditValueChanged
            AddHandler btnOK.Click, AddressOf btnOK_Click
            AddHandler btnCancel.Click, AddressOf btnCancel_Click

            InitializeControls(firstDayOfWeek)
        End Sub
        #Region "#initialization"
        Protected Overridable Sub InitializeControls(ByVal firstDayOfWeek As FirstDayOfWeek)
            InitRecurrenceControls(firstDayOfWeek)
            ' Prevent settings from being reset.
            SuspendUpdate()
            SetRecurrenceType(rinfo.Type)
            ResumeUpdate()
        End Sub

        Protected Overridable Sub InitRecurrenceControls(ByVal firstDayOfWeek As FirstDayOfWeek)
            weeklyRecurrenceControl1.FirstDayOfWeek = firstDayOfWeek
            dailyRecurrenceControl1.RecurrenceInfo = rinfo
            weeklyRecurrenceControl1.RecurrenceInfo = rinfo
            monthlyRecurrenceControl1.RecurrenceInfo = rinfo
            yearlyRecurrenceControl1.RecurrenceInfo = rinfo
        End Sub

        Protected Overridable Sub SuspendUpdate()
            suspendUpdateCount += 1
        End Sub
        Protected Overridable Sub ResumeUpdate()
            If suspendUpdateCount > 0 Then
                suspendUpdateCount -= 1
            End If
        End Sub
        #End Region ' #initialization
        #Region "#reset"
        Protected Overridable Sub ResetRecurrenceInfo()
            Dim type As RecurrenceType = GetRecurrenceType()
            Reset(type)
        End Sub

        Protected Overridable Function GetRecurrenceType() As RecurrenceType
            Select Case radioGroup1.EditValue.ToString()
            Case "Daily"
                Return RecurrenceType.Daily
            Case "Weekly"
                Return RecurrenceType.Weekly
            Case "Monthly"
                Return RecurrenceType.Monthly
            Case Else
                Return RecurrenceType.Yearly
            End Select
        End Function

        Protected Overridable Sub SetRecurrenceType(ByVal type As RecurrenceType)
            Select Case type
                Case RecurrenceType.Daily
                    radioGroup1.EditValue = "Daily"
                Case RecurrenceType.Weekly
                    radioGroup1.EditValue = "Weekly"
                Case RecurrenceType.Monthly
                    radioGroup1.EditValue = "Monthly"
                Case RecurrenceType.Yearly
                    radioGroup1.EditValue = "Yearly"
            End Select
        End Sub

        Friend Sub Reset(ByVal type As RecurrenceType)
            Select Case type
                Case RecurrenceType.Daily
                    rinfo.Type = RecurrenceType.Daily
                    rinfo.WeekDays = WeekDays.EveryDay
                Case RecurrenceType.Weekly
                    rinfo.Type = RecurrenceType.Weekly
                    rinfo.WeekDays = DevExpress.XtraScheduler.Native.DateTimeHelper.ToWeekDays(rinfo.Start.DayOfWeek)
                Case RecurrenceType.Monthly
                    rinfo.Type = RecurrenceType.Monthly
                    rinfo.WeekOfMonth = WeekOfMonth.None
                    rinfo.DayNumber = rinfo.Start.Day
                Case RecurrenceType.Yearly
                    rinfo.Type = RecurrenceType.Yearly
                    rinfo.WeekOfMonth = WeekOfMonth.None
                    rinfo.DayNumber = rinfo.Start.Day
                    rinfo.Month = rinfo.Start.Month
                    rinfo.WeekDays = DevExpress.XtraScheduler.Native.DateTimeHelper.ToWeekDays(rinfo.Start.DayOfWeek)
            End Select
            rinfo.Periodicity = 1
        End Sub

        Protected Overridable Sub ChangeCurrentRecurrenceControl()
            If currentRecurrenceControl IsNot Nothing Then
                currentRecurrenceControl.Visible = False
            End If

            Select Case GetRecurrenceType()
                Case RecurrenceType.Daily
                    currentRecurrenceControl = dailyRecurrenceControl1
                Case RecurrenceType.Weekly
                    currentRecurrenceControl = weeklyRecurrenceControl1
                Case RecurrenceType.Monthly
                    currentRecurrenceControl = monthlyRecurrenceControl1
                Case RecurrenceType.Yearly
                    currentRecurrenceControl = yearlyRecurrenceControl1
            End Select
            currentRecurrenceControl.Visible = True
        End Sub
        #End Region ' #reset
        #Region "#events"
        ' Events section.
        Private Sub radioGroup1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            OnRecurrenceTypeEditValueChanged()
        End Sub

        Protected Overridable Sub OnRecurrenceTypeEditValueChanged()
            If Not IsUpdateSuspended Then
                ResetRecurrenceInfo()
            End If
            ChangeCurrentRecurrenceControl()
            currentRecurrenceControl.UpdateControls()
        End Sub

        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim args As New ValidationArgs()
            currentRecurrenceControl.ValidateValues(args)
            If args.Valid Then
                args = New ValidationArgs()
                currentRecurrenceControl.CheckForWarnings(args)
                If Not args.Valid Then
                    Dim answer As DialogResult = MessageBox.Show(Me, args.ErrorMessage, Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If answer = System.Windows.Forms.DialogResult.OK Then
                        Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Else
                        If args.Control IsNot Nothing Then
                            CType(args.Control, Control).Focus()
                        End If
                    End If
                Else
                    ' Apply changes to the appointment recurrence pattern.
                    controller.ApplyRecurrence(patternCopy)
                End If
                ' Apply changes to the original appointment.
                controller.ApplyChanges()
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show(Me, args.ErrorMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                If args.Control IsNot Nothing Then
                    CType(args.Control, Control).Focus()
                End If
            End If
        End Sub

        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub
        #End Region ' #events
    End Class
End Namespace
