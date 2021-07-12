namespace CircleButton
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
            this.lblCountDown = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.testingModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dwellTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voiceRecognitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eyeTAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnGreen = new WindowsFormsApplication1.RoundButton();
            this.btnBlue = new WindowsFormsApplication1.RoundButton();
            this.btnRed = new WindowsFormsApplication1.RoundButton();
            this.rbDwell = new System.Windows.Forms.RadioButton();
            this.rbVoice = new System.Windows.Forms.RadioButton();
            this.rbEyeTAP = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMouse = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.Font = new System.Drawing.Font("Arial", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.Location = new System.Drawing.Point(506, 177);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(59, 18);
            this.lblCountDown.TabIndex = 6;
            this.lblCountDown.Text = "counter";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Arial", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.Location = new System.Drawing.Point(299, 27);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(67, 16);
            this.lblDistance.TabIndex = 8;
            this.lblDistance.Text = "Distance:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Arial", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(375, 27);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(16, 16);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "X";
            // 
            // testingModeToolStripMenuItem
            // 
            this.testingModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dwellTimeToolStripMenuItem,
            this.voiceRecognitionToolStripMenuItem,
            this.eyeTAPToolStripMenuItem,
            this.rESETToolStripMenuItem});
            this.testingModeToolStripMenuItem.Name = "testingModeToolStripMenuItem";
            this.testingModeToolStripMenuItem.Size = new System.Drawing.Size(104, 23);
            this.testingModeToolStripMenuItem.Text = "Testing Mode";
            // 
            // dwellTimeToolStripMenuItem
            // 
            this.dwellTimeToolStripMenuItem.Name = "dwellTimeToolStripMenuItem";
            this.dwellTimeToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.dwellTimeToolStripMenuItem.Text = "Dwell-Time";
            this.dwellTimeToolStripMenuItem.Click += new System.EventHandler(this.dwellTimeToolStripMenuItem_Click);
            // 
            // voiceRecognitionToolStripMenuItem
            // 
            this.voiceRecognitionToolStripMenuItem.Name = "voiceRecognitionToolStripMenuItem";
            this.voiceRecognitionToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.voiceRecognitionToolStripMenuItem.Text = "Voice Recognition";
            this.voiceRecognitionToolStripMenuItem.Click += new System.EventHandler(this.voiceRecognitionToolStripMenuItem_Click);
            // 
            // eyeTAPToolStripMenuItem
            // 
            this.eyeTAPToolStripMenuItem.Name = "eyeTAPToolStripMenuItem";
            this.eyeTAPToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.eyeTAPToolStripMenuItem.Text = "EyeTAP";
            this.eyeTAPToolStripMenuItem.Click += new System.EventHandler(this.eyeTAPToolStripMenuItem_Click);
            // 
            // rESETToolStripMenuItem
            // 
            this.rESETToolStripMenuItem.Name = "rESETToolStripMenuItem";
            this.rESETToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.rESETToolStripMenuItem.Text = "RESET";
            this.rESETToolStripMenuItem.Click += new System.EventHandler(this.rESETToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testingModeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1169, 27);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(97, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(43, 20);
            this.txtId.TabIndex = 10;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(45, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(51, 15);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "User ID:";
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGreen.Location = new System.Drawing.Point(511, 260);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(60, 60);
            this.btnGreen.TabIndex = 5;
            this.btnGreen.UseVisualStyleBackColor = false;
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBlue.Location = new System.Drawing.Point(482, 230);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(120, 120);
            this.btnBlue.TabIndex = 4;
            this.btnBlue.UseVisualStyleBackColor = false;
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRed.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnRed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRed.Location = new System.Drawing.Point(454, 200);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(180, 180);
            this.btnRed.TabIndex = 3;
            this.btnRed.UseVisualStyleBackColor = false;
            // 
            // rbDwell
            // 
            this.rbDwell.AutoSize = true;
            this.rbDwell.Location = new System.Drawing.Point(282, 32);
            this.rbDwell.Name = "rbDwell";
            this.rbDwell.Size = new System.Drawing.Size(56, 19);
            this.rbDwell.TabIndex = 12;
            this.rbDwell.TabStop = true;
            this.rbDwell.Text = "Dwell";
            this.rbDwell.UseVisualStyleBackColor = true;
            // 
            // rbVoice
            // 
            this.rbVoice.AutoSize = true;
            this.rbVoice.Location = new System.Drawing.Point(373, 31);
            this.rbVoice.Name = "rbVoice";
            this.rbVoice.Size = new System.Drawing.Size(55, 19);
            this.rbVoice.TabIndex = 13;
            this.rbVoice.TabStop = true;
            this.rbVoice.Text = "Voice";
            this.rbVoice.UseVisualStyleBackColor = true;
            // 
            // rbEyeTAP
            // 
            this.rbEyeTAP.AutoSize = true;
            this.rbEyeTAP.Location = new System.Drawing.Point(453, 32);
            this.rbEyeTAP.Name = "rbEyeTAP";
            this.rbEyeTAP.Size = new System.Drawing.Size(67, 19);
            this.rbEyeTAP.TabIndex = 14;
            this.rbEyeTAP.TabStop = true;
            this.rbEyeTAP.Text = "EyeTAP";
            this.rbEyeTAP.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(567, 32);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMouse);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.rbEyeTAP);
            this.groupBox1.Controls.Add(this.rbDwell);
            this.groupBox1.Controls.Add(this.rbVoice);
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 67);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // rbMouse
            // 
            this.rbMouse.AutoSize = true;
            this.rbMouse.Location = new System.Drawing.Point(206, 32);
            this.rbMouse.Name = "rbMouse";
            this.rbMouse.Size = new System.Drawing.Size(63, 19);
            this.rbMouse.TabIndex = 16;
            this.rbMouse.TabStop = true;
            this.rbMouse.Text = "Mouse";
            this.rbMouse.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Target Selection Test";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WindowsFormsApplication1.RoundButton btnRed;
        private WindowsFormsApplication1.RoundButton btnBlue;
        private WindowsFormsApplication1.RoundButton btnGreen;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ToolStripMenuItem testingModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dwellTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voiceRecognitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eyeTAPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESETToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.RadioButton rbDwell;
        private System.Windows.Forms.RadioButton rbVoice;
        private System.Windows.Forms.RadioButton rbEyeTAP;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMouse;
    }
}

