namespace TaskFormApp
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
            this.btnReadFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnCounter = new System.Windows.Forms.Button();
            this.textBoxCounter = new System.Windows.Forms.TextBox();

            this.richTextBox2 = new System.Windows.Forms.RichTextBox();


            this.SuspendLayout();
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(1022, 237);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(201, 69);
            this.btnReadFile.TabIndex = 0;
            this.btnReadFile.Text = "Read the file";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(102, 50);
            this.richTextBox1.Name = "richTextBox1";

            this.richTextBox1.Size = new System.Drawing.Size(436, 451);

            this.richTextBox1.Size = new System.Drawing.Size(869, 451);

            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // BtnCounter
            // 
            this.BtnCounter.Location = new System.Drawing.Point(1022, 538);
            this.BtnCounter.Name = "BtnCounter";
            this.BtnCounter.Size = new System.Drawing.Size(201, 71);
            this.BtnCounter.TabIndex = 2;
            this.BtnCounter.Text = "Increase Counter";
            this.BtnCounter.UseVisualStyleBackColor = true;
            this.BtnCounter.Click += new System.EventHandler(this.BtnCounter_Click);
            // 
            // textBoxCounter
            // 
            this.textBoxCounter.Location = new System.Drawing.Point(102, 538);
            this.textBoxCounter.Name = "textBoxCounter";
            this.textBoxCounter.Size = new System.Drawing.Size(869, 20);
            this.textBoxCounter.TabIndex = 3;
            this.textBoxCounter.TextChanged += new System.EventHandler(this.textBoxCounter_TextChanged);
            // 

            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(579, 50);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(392, 451);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 

            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 790);

            this.Controls.Add(this.richTextBox2);

            this.Controls.Add(this.textBoxCounter);
            this.Controls.Add(this.BtnCounter);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnReadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnCounter;
        private System.Windows.Forms.TextBox textBoxCounter;

        private System.Windows.Forms.RichTextBox richTextBox2;

    }
}

