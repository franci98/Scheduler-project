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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
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
            this.ScheduleGridView.Location = new System.Drawing.Point(30, 49);
            this.ScheduleGridView.Name = "ScheduleGridView";
            this.ScheduleGridView.Size = new System.Drawing.Size(522, 267);
            this.ScheduleGridView.TabIndex = 0;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(201, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(136, 37);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Moj Urnik";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(506, 331);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Nazaj";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // ScheduleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 366);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.ScheduleGridView);
            this.Name = "ScheduleView";
            this.Text = "ScheduleView";
            this.Load += new System.EventHandler(this.ScheduleView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ScheduleGridView;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button BackButton;
    }
}