namespace ArcadeStartupAzfar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.polybiusLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.beginningLabel = new System.Windows.Forms.Label();
            this.fightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // polybiusLabel
            // 
            this.polybiusLabel.Font = new System.Drawing.Font("Agency FB", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polybiusLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.polybiusLabel.Location = new System.Drawing.Point(242, 78);
            this.polybiusLabel.Name = "polybiusLabel";
            this.polybiusLabel.Size = new System.Drawing.Size(332, 112);
            this.polybiusLabel.TabIndex = 0;
            this.polybiusLabel.Text = "Polybius";
            this.polybiusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.polybiusLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.startButton.Location = new System.Drawing.Point(322, 280);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(153, 64);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // beginningLabel
            // 
            this.beginningLabel.AutoSize = true;
            this.beginningLabel.BackColor = System.Drawing.Color.Transparent;
            this.beginningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginningLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.beginningLabel.Location = new System.Drawing.Point(272, 295);
            this.beginningLabel.Name = "beginningLabel";
            this.beginningLabel.Size = new System.Drawing.Size(249, 29);
            this.beginningLabel.TabIndex = 2;
            this.beginningLabel.Text = "Game will begin in... 3";
            // 
            // fightLabel
            // 
            this.fightLabel.AutoSize = true;
            this.fightLabel.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fightLabel.Location = new System.Drawing.Point(336, 203);
            this.fightLabel.Name = "fightLabel";
            this.fightLabel.Size = new System.Drawing.Size(128, 44);
            this.fightLabel.TabIndex = 4;
            this.fightLabel.Text = "FIGHT";
            this.fightLabel.Click += new System.EventHandler(this.fightLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fightLabel);
            this.Controls.Add(this.beginningLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.polybiusLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Golden Polybius";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label polybiusLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label beginningLabel;
        private System.Windows.Forms.Label fightLabel;
    }
}

