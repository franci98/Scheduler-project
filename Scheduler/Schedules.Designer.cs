namespace Scheduler
{
    partial class Schedules
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
            this.SchedulesDataGridView1 = new System.Windows.Forms.DataGridView();
            this.CreateScheduleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SchedulesDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SchedulesDataGridView1
            // 
            this.SchedulesDataGridView1.AllowUserToAddRows = false;
            this.SchedulesDataGridView1.AllowUserToDeleteRows = false;
            this.SchedulesDataGridView1.AllowUserToResizeColumns = false;
            this.SchedulesDataGridView1.AllowUserToResizeRows = false;
            this.SchedulesDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SchedulesDataGridView1.Location = new System.Drawing.Point(32, 47);
            this.SchedulesDataGridView1.Name = "SchedulesDataGridView1";
            this.SchedulesDataGridView1.Size = new System.Drawing.Size(483, 119);
            this.SchedulesDataGridView1.TabIndex = 0;
            this.SchedulesDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SchedulesDataGridView1_CellContentClick);
            // 
            // CreateScheduleButton
            // 
            this.CreateScheduleButton.Location = new System.Drawing.Point(32, 13);
            this.CreateScheduleButton.Name = "CreateScheduleButton";
            this.CreateScheduleButton.Size = new System.Drawing.Size(75, 23);
            this.CreateScheduleButton.TabIndex = 1;
            this.CreateScheduleButton.Text = "Ustvari urnik";
            this.CreateScheduleButton.UseVisualStyleBackColor = true;
            this.CreateScheduleButton.Click += new System.EventHandler(this.CreateScheduleButton_Click);
            // 
            // Schedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 368);
            this.Controls.Add(this.CreateScheduleButton);
            this.Controls.Add(this.SchedulesDataGridView1);
            this.Name = "Schedules";
            this.Text = "Schedules";
            this.Load += new System.EventHandler(this.Schedules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SchedulesDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SchedulesDataGridView1;
        private System.Windows.Forms.Button CreateScheduleButton;
    }
}