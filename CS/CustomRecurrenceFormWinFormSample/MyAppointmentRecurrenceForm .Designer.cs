namespace CustomRecurrenceFormWinFormSample
{
    partial class MyAppointmentRecurrenceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dailyRecurrenceControl1 = new DevExpress.XtraScheduler.UI.DailyRecurrenceControl();
            this.monthlyRecurrenceControl1 = new DevExpress.XtraScheduler.UI.MonthlyRecurrenceControl();
            this.weeklyRecurrenceControl1 = new DevExpress.XtraScheduler.UI.WeeklyRecurrenceControl();
            this.yearlyRecurrenceControl1 = new DevExpress.XtraScheduler.UI.YearlyRecurrenceControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dailyRecurrenceControl1
            // 
            this.dailyRecurrenceControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.dailyRecurrenceControl1.Appearance.Options.UseBackColor = true;
            this.dailyRecurrenceControl1.Location = new System.Drawing.Point(306, 24);
            this.dailyRecurrenceControl1.Name = "dailyRecurrenceControl1";
            this.dailyRecurrenceControl1.Size = new System.Drawing.Size(388, 96);
            this.dailyRecurrenceControl1.TabIndex = 0;
            this.dailyRecurrenceControl1.Visible = false;
            // 
            // monthlyRecurrenceControl1
            // 
            this.monthlyRecurrenceControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.monthlyRecurrenceControl1.Appearance.Options.UseBackColor = true;
            this.monthlyRecurrenceControl1.Location = new System.Drawing.Point(306, 24);
            this.monthlyRecurrenceControl1.Name = "monthlyRecurrenceControl1";
            this.monthlyRecurrenceControl1.Size = new System.Drawing.Size(388, 96);
            this.monthlyRecurrenceControl1.TabIndex = 1;
            this.monthlyRecurrenceControl1.Visible = false;
            // 
            // weeklyRecurrenceControl1
            // 
            this.weeklyRecurrenceControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.weeklyRecurrenceControl1.Appearance.Options.UseBackColor = true;
            this.weeklyRecurrenceControl1.Location = new System.Drawing.Point(306, 24);
            this.weeklyRecurrenceControl1.Name = "weeklyRecurrenceControl1";
            this.weeklyRecurrenceControl1.Size = new System.Drawing.Size(388, 96);
            this.weeklyRecurrenceControl1.TabIndex = 2;
            this.weeklyRecurrenceControl1.Visible = false;
            // 
            // yearlyRecurrenceControl1
            // 
            this.yearlyRecurrenceControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.yearlyRecurrenceControl1.Appearance.Options.UseBackColor = true;
            this.yearlyRecurrenceControl1.Location = new System.Drawing.Point(306, 24);
            this.yearlyRecurrenceControl1.Name = "yearlyRecurrenceControl1";
            this.yearlyRecurrenceControl1.Size = new System.Drawing.Size(388, 96);
            this.yearlyRecurrenceControl1.TabIndex = 3;
            this.yearlyRecurrenceControl1.Visible = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.radioGroup1);
            this.groupControl1.Controls.Add(this.btnCancel);
            this.groupControl1.Controls.Add(this.btnOK);
            this.groupControl1.Controls.Add(this.yearlyRecurrenceControl1);
            this.groupControl1.Controls.Add(this.weeklyRecurrenceControl1);
            this.groupControl1.Controls.Add(this.monthlyRecurrenceControl1);
            this.groupControl1.Controls.Add(this.dailyRecurrenceControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(690, 325);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Recurrence Pattern";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(383, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(265, 261);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(21, 37);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Columns = 1;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Daily", "Daily"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Weekly", "Weekly"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Monthly", "Monthly"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Yearly", "Yearly")});
            this.radioGroup1.Size = new System.Drawing.Size(163, 176);
            this.radioGroup1.TabIndex = 14;
            // 
            // MyAppointmentRecurrenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 325);
            this.Controls.Add(this.groupControl1);
            this.Name = "MyAppointmentRecurrenceForm";
            this.Text = "MyAppointmentRecurrenceForm";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.UI.DailyRecurrenceControl dailyRecurrenceControl1;
        private DevExpress.XtraScheduler.UI.MonthlyRecurrenceControl monthlyRecurrenceControl1;
        private DevExpress.XtraScheduler.UI.WeeklyRecurrenceControl weeklyRecurrenceControl1;
        private DevExpress.XtraScheduler.UI.YearlyRecurrenceControl yearlyRecurrenceControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;

    }
}