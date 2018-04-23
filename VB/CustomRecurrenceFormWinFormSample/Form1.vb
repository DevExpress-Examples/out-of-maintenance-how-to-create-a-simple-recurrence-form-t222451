Imports System
Imports System.Windows.Forms

Namespace CustomRecurrenceFormWinFormSample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            ' Handle the EditAppointmentFormShowing event to invoke a custom form instead of the default appointment editing form.
            AddHandler Me.schedulerControl1.EditAppointmentFormShowing, AddressOf schedulerControl1_EditAppointmentFormShowing
            AddHandler Me.Shown, AddressOf Form1_Shown
        End Sub

        Private Sub schedulerControl1_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.AppointmentFormEventArgs)
            Dim myForm As New MyAppointmentRecurrenceForm(schedulerControl1, e.Appointment)
            myForm.ShowDialog()
            e.Handled = True
        End Sub

        Private Sub Form1_Shown(ByVal sender As Object, ByVal e As EventArgs)
            Me.schedulerControl1.CreateAppointment(False, True)
        End Sub
    End Class
End Namespace
