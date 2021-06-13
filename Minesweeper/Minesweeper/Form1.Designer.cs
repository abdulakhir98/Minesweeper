namespace Minesweeper
{
    partial class Minesweeper
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Start = new System.Windows.Forms.Button();
            this.Level1 = new System.Windows.Forms.RadioButton();
            this.Level3 = new System.Windows.Forms.RadioButton();
            this.Level2 = new System.Windows.Forms.RadioButton();
            this.CellsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Start);
            this.panel1.Controls.Add(this.Level1);
            this.panel1.Controls.Add(this.Level3);
            this.panel1.Controls.Add(this.Level2);
            this.panel1.Location = new System.Drawing.Point(34, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 57);
            this.panel1.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(494, 3);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(229, 51);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Level1
            // 
            this.Level1.AutoSize = true;
            this.Level1.Location = new System.Drawing.Point(19, 16);
            this.Level1.Name = "Level1";
            this.Level1.Size = new System.Drawing.Size(75, 21);
            this.Level1.TabIndex = 3;
            this.Level1.TabStop = true;
            this.Level1.Text = "Level 1";
            this.Level1.UseVisualStyleBackColor = true;
            // 
            // Level3
            // 
            this.Level3.AutoSize = true;
            this.Level3.Location = new System.Drawing.Point(293, 16);
            this.Level3.Name = "Level3";
            this.Level3.Size = new System.Drawing.Size(75, 21);
            this.Level3.TabIndex = 2;
            this.Level3.TabStop = true;
            this.Level3.Text = "Level 3";
            this.Level3.UseVisualStyleBackColor = true;
            // 
            // Level2
            // 
            this.Level2.AutoSize = true;
            this.Level2.Location = new System.Drawing.Point(164, 16);
            this.Level2.Name = "Level2";
            this.Level2.Size = new System.Drawing.Size(75, 21);
            this.Level2.TabIndex = 4;
            this.Level2.TabStop = true;
            this.Level2.Text = "Level 2";
            this.Level2.UseVisualStyleBackColor = true;
            // 
            // CellsPanel
            // 
            this.CellsPanel.Location = new System.Drawing.Point(15, 114);
            this.CellsPanel.Name = "CellsPanel";
            this.CellsPanel.Size = new System.Drawing.Size(661, 331);
            this.CellsPanel.TabIndex = 1;
            // 
            // Minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CellsPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Minesweeper";
            this.Text = "Minesweeper";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Level3;
        private System.Windows.Forms.RadioButton Level2;
        private System.Windows.Forms.RadioButton Level1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.FlowLayoutPanel CellsPanel;
    }
}

