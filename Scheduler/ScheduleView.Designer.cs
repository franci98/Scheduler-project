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
            this.components = new System.ComponentModel.Container();
            this.ScheduleGridView = new System.Windows.Forms.DataGridView();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.MondayButton = new System.Windows.Forms.Button();
            this.TuesdayButton = new System.Windows.Forms.Button();
            this.WednesdayButton = new System.Windows.Forms.Button();
            this.ThursdayButton = new System.Windows.Forms.Button();
            this.FridayButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mojiUrnikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPredmeteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmeteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.učiteljiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.izpisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScheduleGridView
            // 
            this.ScheduleGridView.AllowUserToAddRows = false;
            this.ScheduleGridView.AllowUserToDeleteRows = false;
            this.ScheduleGridView.AllowUserToResizeColumns = false;
            this.ScheduleGridView.AllowUserToResizeRows = false;
            this.ScheduleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleGridView.Location = new System.Drawing.Point(12, 100);
            this.ScheduleGridView.Name = "ScheduleGridView";
            this.ScheduleGridView.Size = new System.Drawing.Size(541, 229);
            this.ScheduleGridView.TabIndex = 0;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(182, 25);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(136, 37);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Moj Urnik";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(487, 347);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Nazaj";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // MondayButton
            // 
            this.MondayButton.Location = new System.Drawing.Point(76, 71);
            this.MondayButton.Name = "MondayButton";
            this.MondayButton.Size = new System.Drawing.Size(75, 23);
            this.MondayButton.TabIndex = 3;
            this.MondayButton.Text = "Ponedeljek";
            this.MondayButton.UseVisualStyleBackColor = true;
            this.MondayButton.Click += new System.EventHandler(this.MondayButton_Click);
            // 
            // TuesdayButton
            // 
            this.TuesdayButton.Location = new System.Drawing.Point(157, 71);
            this.TuesdayButton.Name = "TuesdayButton";
            this.TuesdayButton.Size = new System.Drawing.Size(75, 23);
            this.TuesdayButton.TabIndex = 4;
            this.TuesdayButton.Text = "Torek";
            this.TuesdayButton.UseVisualStyleBackColor = true;
            this.TuesdayButton.Click += new System.EventHandler(this.TuesdayButton_Click);
            // 
            // WednesdayButton
            // 
            this.WednesdayButton.Location = new System.Drawing.Point(238, 71);
            this.WednesdayButton.Name = "WednesdayButton";
            this.WednesdayButton.Size = new System.Drawing.Size(75, 23);
            this.WednesdayButton.TabIndex = 5;
            this.WednesdayButton.Text = "Sreda";
            this.WednesdayButton.UseVisualStyleBackColor = true;
            this.WednesdayButton.Click += new System.EventHandler(this.WednesdayButton_Click);
            // 
            // ThursdayButton
            // 
            this.ThursdayButton.Location = new System.Drawing.Point(319, 71);
            this.ThursdayButton.Name = "ThursdayButton";
            this.ThursdayButton.Size = new System.Drawing.Size(75, 23);
            this.ThursdayButton.TabIndex = 6;
            this.ThursdayButton.Text = "Četrtek";
            this.ThursdayButton.UseVisualStyleBackColor = true;
            this.ThursdayButton.Click += new System.EventHandler(this.ThursdayButton_Click);
            // 
            // FridayButton
            // 
            this.FridayButton.Location = new System.Drawing.Point(400, 71);
            this.FridayButton.Name = "FridayButton";
            this.FridayButton.Size = new System.Drawing.Size(75, 23);
            this.FridayButton.TabIndex = 7;
            this.FridayButton.Text = "Petek";
            this.FridayButton.UseVisualStyleBackColor = true;
            this.FridayButton.Click += new System.EventHandler(this.FridayButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mojiUrnikiToolStripMenuItem,
            this.dodajPredmeteToolStripMenuItem,
            this.izpisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(576, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mojiUrnikiToolStripMenuItem
            // 
            this.mojiUrnikiToolStripMenuItem.Name = "mojiUrnikiToolStripMenuItem";
            this.mojiUrnikiToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.mojiUrnikiToolStripMenuItem.Text = "Moji urniki";
            this.mojiUrnikiToolStripMenuItem.Click += new System.EventHandler(this.mojiUrnikiToolStripMenuItem_Click);
            // 
            // dodajPredmeteToolStripMenuItem
            // 
            this.dodajPredmeteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.predmeteToolStripMenuItem,
            this.učiteljiToolStripMenuItem});
            this.dodajPredmeteToolStripMenuItem.Name = "dodajPredmeteToolStripMenuItem";
            this.dodajPredmeteToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.dodajPredmeteToolStripMenuItem.Text = "Dodaj";
            // 
            // predmeteToolStripMenuItem
            // 
            this.predmeteToolStripMenuItem.Name = "predmeteToolStripMenuItem";
            this.predmeteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.predmeteToolStripMenuItem.Text = "Predmete";
            this.predmeteToolStripMenuItem.Click += new System.EventHandler(this.predmeteToolStripMenuItem_Click);
            // 
            // učiteljiToolStripMenuItem
            // 
            this.učiteljiToolStripMenuItem.Name = "učiteljiToolStripMenuItem";
            this.učiteljiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.učiteljiToolStripMenuItem.Text = "Učitelji";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // izpisToolStripMenuItem
            // 
            this.izpisToolStripMenuItem.Name = "izpisToolStripMenuItem";
            this.izpisToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.izpisToolStripMenuItem.Text = "Izpis";
            // 
            // ScheduleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 382);
            this.Controls.Add(this.FridayButton);
            this.Controls.Add(this.ThursdayButton);
            this.Controls.Add(this.WednesdayButton);
            this.Controls.Add(this.TuesdayButton);
            this.Controls.Add(this.MondayButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.ScheduleGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ScheduleView";
            this.Text = "ScheduleView";
            this.Load += new System.EventHandler(this.ScheduleView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ScheduleGridView;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button MondayButton;
        private System.Windows.Forms.Button TuesdayButton;
        private System.Windows.Forms.Button WednesdayButton;
        private System.Windows.Forms.Button ThursdayButton;
        private System.Windows.Forms.Button FridayButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mojiUrnikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajPredmeteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmeteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem učiteljiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izpisToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}