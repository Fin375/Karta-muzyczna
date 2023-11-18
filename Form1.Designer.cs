namespace UPLAB1
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
            this.FileNameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartButton1 = new System.Windows.Forms.Button();
            this.StopButton1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartButton2 = new System.Windows.Forms.Button();
            this.StopButton2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StartButton3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileNameButton
            // 
            this.FileNameButton.Location = new System.Drawing.Point(26, 34);
            this.FileNameButton.Name = "FileNameButton";
            this.FileNameButton.Size = new System.Drawing.Size(308, 66);
            this.FileNameButton.TabIndex = 0;
            this.FileNameButton.Text = "Wybierz plik";
            this.FileNameButton.UseVisualStyleBackColor = true;
            this.FileNameButton.Click += new System.EventHandler(this.FileNameButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(379, 73);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(0, 17);
            this.FileNameLabel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "SoundPlayer()";
            // 
            // StartButton1
            // 
            this.StartButton1.Location = new System.Drawing.Point(215, 18);
            this.StartButton1.Name = "StartButton1";
            this.StartButton1.Size = new System.Drawing.Size(75, 23);
            this.StartButton1.TabIndex = 4;
            this.StartButton1.Text = "Start";
            this.StartButton1.UseVisualStyleBackColor = true;
            this.StartButton1.Click += new System.EventHandler(this.StartButton1_Click);
            // 
            // StopButton1
            // 
            this.StopButton1.Location = new System.Drawing.Point(317, 18);
            this.StopButton1.Name = "StopButton1";
            this.StopButton1.Size = new System.Drawing.Size(75, 23);
            this.StopButton1.TabIndex = 5;
            this.StopButton1.Text = "Stop";
            this.StopButton1.UseVisualStyleBackColor = true;
            this.StopButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StopButton1);
            this.groupBox1.Controls.Add(this.StartButton1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 57);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // StartButton2
            // 
            this.StartButton2.Location = new System.Drawing.Point(210, 15);
            this.StartButton2.Name = "StartButton2";
            this.StartButton2.Size = new System.Drawing.Size(73, 23);
            this.StartButton2.TabIndex = 7;
            this.StartButton2.Text = "Start";
            this.StartButton2.UseVisualStyleBackColor = true;
            this.StartButton2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // StopButton2
            // 
            this.StopButton2.Location = new System.Drawing.Point(312, 15);
            this.StopButton2.Name = "StopButton2";
            this.StopButton2.Size = new System.Drawing.Size(75, 23);
            this.StopButton2.TabIndex = 8;
            this.StopButton2.Text = "Stop";
            this.StopButton2.UseVisualStyleBackColor = true;
            this.StopButton2.Click += new System.EventHandler(this.StopButton2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Windows Media Player";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.StopButton2);
            this.groupBox2.Controls.Add(this.StartButton2);
            this.groupBox2.Location = new System.Drawing.Point(31, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 50);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // StartButton3
            // 
            this.StartButton3.Location = new System.Drawing.Point(241, 278);
            this.StartButton3.Name = "StartButton3";
            this.StartButton3.Size = new System.Drawing.Size(75, 23);
            this.StartButton3.TabIndex = 11;
            this.StartButton3.Text = "Start";
            this.StartButton3.UseVisualStyleBackColor = true;
            this.StartButton3.Click += new System.EventHandler(this.StartButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 514);
            this.Controls.Add(this.StartButton3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileNameButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FileNameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartButton1;
        private System.Windows.Forms.Button StopButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StartButton2;
        private System.Windows.Forms.Button StopButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button StartButton3;
    }
}

