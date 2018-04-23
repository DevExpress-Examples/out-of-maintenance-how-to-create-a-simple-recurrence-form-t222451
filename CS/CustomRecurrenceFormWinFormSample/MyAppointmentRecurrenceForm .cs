using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.UI;
using System;
using System.Windows.Forms;

namespace CustomRecurrenceFormWinFormSample
{
    public partial class MyAppointmentRecurrenceForm : Form
    {
        private RecurrenceControlBase currentRecurrenceControl;
        private IRecurrenceInfo rinfo;
        private AppointmentFormController controller;
        private Appointment patternCopy;
        private FirstDayOfWeek firstDayOfWeek;
        protected int suspendUpdateCount;
        protected bool IsUpdateSuspended { get { return suspendUpdateCount > 0; } }

        public MyAppointmentRecurrenceForm(SchedulerControl scheduler_control,
            Appointment apt)
        {

            InitializeComponent();
            // Create a controller instance.
            controller = new AppointmentFormController(scheduler_control, apt);
            // Get an appointment pattern copy.
            patternCopy = controller.PrepareToRecurrenceEdit();
            // Get access to the recurrence information.
            this.rinfo = patternCopy.RecurrenceInfo;
            // Get the first day of the week.
            firstDayOfWeek = scheduler_control.OptionsView.FirstDayOfWeek;

            radioGroup1.EditValueChanged += radioGroup1_EditValueChanged;
            btnOK.Click += btnOK_Click;
            btnCancel.Click += btnCancel_Click;

            InitializeControls(firstDayOfWeek);
        }
        #region #initialization
        protected virtual void InitializeControls(FirstDayOfWeek firstDayOfWeek)
        {
            InitRecurrenceControls(firstDayOfWeek);
            // Prevent settings from being reset.
            SuspendUpdate();
            SetRecurrenceType(rinfo.Type);
            ResumeUpdate();
        }

        protected virtual void InitRecurrenceControls(FirstDayOfWeek firstDayOfWeek)
        {
            weeklyRecurrenceControl1.FirstDayOfWeek = firstDayOfWeek;
            dailyRecurrenceControl1.RecurrenceInfo = rinfo;
            weeklyRecurrenceControl1.RecurrenceInfo = rinfo;
            monthlyRecurrenceControl1.RecurrenceInfo = rinfo;
            yearlyRecurrenceControl1.RecurrenceInfo = rinfo;
        }

        protected virtual void SuspendUpdate()
        {
            suspendUpdateCount++;
        }
        protected virtual void ResumeUpdate()
        {
            if (suspendUpdateCount > 0)
                suspendUpdateCount--;
        }
        #endregion #initialization
        #region #reset
        protected virtual void ResetRecurrenceInfo()
        {
            RecurrenceType type = GetRecurrenceType();
            Reset(type);
        }

        protected virtual RecurrenceType GetRecurrenceType()
        {
            switch (radioGroup1.EditValue.ToString()) {
            case "Daily": 
                return RecurrenceType.Daily;
            case "Weekly":
                return RecurrenceType.Weekly;
            case "Monthly":
                return RecurrenceType.Monthly;
            default:
                return RecurrenceType.Yearly;
        }
        }

        protected virtual void SetRecurrenceType(RecurrenceType type)
        {
            switch (type)
            {
                case RecurrenceType.Daily:
                    radioGroup1.EditValue = "Daily";
                    break;
                case RecurrenceType.Weekly:
                    radioGroup1.EditValue = "Weekly";
                    break;
                case RecurrenceType.Monthly:
                    radioGroup1.EditValue = "Monthly";;
                    break;
                case RecurrenceType.Yearly:
                    radioGroup1.EditValue = "Yearly";
                    break;
            }
        }

        internal void Reset(RecurrenceType type)
        {
            switch (type)
            {
                case RecurrenceType.Daily:
                    rinfo.Type = RecurrenceType.Daily;
                    rinfo.WeekDays = WeekDays.EveryDay;
                    break;
                case RecurrenceType.Weekly:
                    rinfo.Type = RecurrenceType.Weekly;
                    rinfo.WeekDays = DevExpress.XtraScheduler.Native.DateTimeHelper.ToWeekDays(rinfo.Start.DayOfWeek);
                    break;
                case RecurrenceType.Monthly:
                    rinfo.Type = RecurrenceType.Monthly;
                    rinfo.WeekOfMonth = WeekOfMonth.None;
                    rinfo.DayNumber = rinfo.Start.Day;
                    break;
                case RecurrenceType.Yearly:
                    rinfo.Type = RecurrenceType.Yearly;
                    rinfo.WeekOfMonth = WeekOfMonth.None;
                    rinfo.DayNumber = rinfo.Start.Day;
                    rinfo.Month = rinfo.Start.Month;
                    rinfo.WeekDays = DevExpress.XtraScheduler.Native.DateTimeHelper.ToWeekDays(rinfo.Start.DayOfWeek);
                    break;
            }
            rinfo.Periodicity = 1;
        }

        protected virtual void ChangeCurrentRecurrenceControl()
        {
            if (currentRecurrenceControl != null)
                currentRecurrenceControl.Visible = false;

            switch (GetRecurrenceType())
            {
                case RecurrenceType.Daily:
                    currentRecurrenceControl = dailyRecurrenceControl1;
                    break;
                case RecurrenceType.Weekly:
                    currentRecurrenceControl = weeklyRecurrenceControl1;
                    break;
                case RecurrenceType.Monthly:
                    currentRecurrenceControl = monthlyRecurrenceControl1;
                    break;
                case RecurrenceType.Yearly:
                    currentRecurrenceControl = yearlyRecurrenceControl1;
                    break;
            }
            currentRecurrenceControl.Visible = true;
        }
        #endregion #reset
        #region #events
        // Events section.
        void radioGroup1_EditValueChanged(object sender, EventArgs e)
        {
            OnRecurrenceTypeEditValueChanged();
        }

        protected virtual void OnRecurrenceTypeEditValueChanged()
        {
            if (!IsUpdateSuspended)
                ResetRecurrenceInfo();
            ChangeCurrentRecurrenceControl();
            currentRecurrenceControl.UpdateControls();
        }

        void btnOK_Click(object sender, System.EventArgs e)
        {
            ValidationArgs args = new ValidationArgs();
            currentRecurrenceControl.ValidateValues(args);
            if (args.Valid)
            {
                args = new ValidationArgs();
                currentRecurrenceControl.CheckForWarnings(args);
                if (!args.Valid)
                {
                    DialogResult answer = MessageBox.Show(this, args.ErrorMessage,
                        Application.ProductName, MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);
                    if (answer == DialogResult.OK)
                        this.DialogResult = DialogResult.OK;
                    else
                    {
                        if (args.Control != null)
                            ((Control)args.Control).Focus();
                    }
                }
                else
                    // Apply changes to the appointment recurrence pattern.
                    controller.ApplyRecurrence(patternCopy);
                // Apply changes to the original appointment.
                controller.ApplyChanges();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(this, args.ErrorMessage, Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (args.Control != null)
                    ((Control)args.Control).Focus();
            }
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion #events
    }
}
