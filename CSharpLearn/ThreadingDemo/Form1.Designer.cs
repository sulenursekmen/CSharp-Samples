namespace ThreadingDemo
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
            this.process1 = new System.Windows.Forms.Button();
            this.process2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // process1
            // 
            this.process1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.process1.Location = new System.Drawing.Point(243, 123);
            this.process1.Name = "process1";
            this.process1.Size = new System.Drawing.Size(75, 68);
            this.process1.TabIndex = 0;
            this.process1.Text = "Operation1";
            this.process1.UseVisualStyleBackColor = true;
            this.process1.Click += new System.EventHandler(this.process1_Click);
            // 
            // process2
            // 
            this.process2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.process2.Location = new System.Drawing.Point(410, 123);
            this.process2.Name = "process2";
            this.process2.Size = new System.Drawing.Size(75, 68);
            this.process2.TabIndex = 1;
            this.process2.Text = "Operation2";
            this.process2.UseVisualStyleBackColor = true;
            this.process2.Click += new System.EventHandler(this.process2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.process2);
            this.Controls.Add(this.process1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button process1;
        private System.Windows.Forms.Button process2;
    }
}

