namespace Scheduler
{
    partial class ScheduleView
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
            this.ScheduleGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ScheduleGridView
            // 
            this.ScheduleGridView.AllowUserToAddRows = false;
            this.ScheduleGridView.AllowUserToDeleteRows = false;
            this.ScheduleGridView.AllowUserToResizeColumns = false;
            this.ScheduleGridView.AllowUserToResizeRows = false;
            this.ScheduleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleGridView.Location = new System.Drawing.Point(13, 13);
            this.ScheduleGridView.Name = "ScheduleGridView";
            this.ScheduleGridView.Size = new System.Drawing.Size(522, 287);
            this.ScheduleGridView.TabIndex = 0;
            // 
            // ScheduleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 366);
            this.Controls.Add(this.ScheduleGridView);
            this.Name = "ScheduleView";
            this.Text = "ScheduleView";
            this.Load += new System.EventHandler(this.ScheduleView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ScheduleGridView;
    }
}