using System;
using System.Windows.Forms;

namespace CustomRecurrenceFormWinFormSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Handle the EditAppointmentFormShowing event to invoke a custom form instead of the default appointment editing form.
            this.schedulerControl1.EditAppointmentFormShowing += schedulerControl1_EditAppointmentFormShowing;
            this.Shown += Form1_Shown;
        }
        
        void schedulerControl1_EditAppointmentFormShowing(object sender, DevExpress.XtraScheduler.AppointmentFormEventArgs e)
        {
            MyAppointmentRecurrenceForm myForm = new MyAppointmentRecurrenceForm(schedulerControl1, e.Appointment);
            myForm.ShowDialog();
            e.Handled = true;
        }

        void Form1_Shown(object sender, EventArgs e)
        {
            this.schedulerControl1.CreateAppointment(false, true);
        }
    }
}
