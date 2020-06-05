namespace AsyncWebContent
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
            this.response2 = new System.Windows.Forms.TextBox();
            this.response1 = new System.Windows.Forms.TextBox();
            this.url2 = new System.Windows.Forms.TextBox();
            this.url1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // response2
            // 
            this.response2.Location = new System.Drawing.Point(324, 142);
            this.response2.Multiline = true;
            this.response2.Name = "response2";
            this.response2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.response2.Size = new System.Drawing.Size(219, 156);
            this.response2.TabIndex = 13;
            // 
            // response1
            // 
            this.response1.Location = new System.Drawing.Point(31, 142);
            this.response1.Multiline = true;
            this.response1.Name = "response1";
            this.response1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.response1.Size = new System.Drawing.Size(219, 156);
            this.response1.TabIndex = 12;
            // 
            // url2
            // 
            this.url2.Location = new System.Drawing.Point(324, 100);
            this.url2.Name = "url2";
            this.url2.Size = new System.Drawing.Size(219, 22);
            this.url2.TabIndex = 11;
            // 
            // url1
            // 
            this.url1.Location = new System.Drawing.Point(31, 100);
            this.url1.Name = "url1";
            this.url1.Size = new System.Drawing.Size(219, 22);
            this.url1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Url 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Url 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Get Content";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.response2);
            this.Controls.Add(this.response1);
            this.Controls.Add(this.url2);
            this.Controls.Add(this.url1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox response2;
        private System.Windows.Forms.TextBox response1;
        private System.Windows.Forms.TextBox url2;
        private System.Windows.Forms.TextBox url1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

