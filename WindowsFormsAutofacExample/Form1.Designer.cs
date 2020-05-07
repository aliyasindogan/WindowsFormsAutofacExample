namespace WindowsFormsAutofacExample
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
            this.btnWriteDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWriteDate
            // 
            this.btnWriteDate.Location = new System.Drawing.Point(133, 108);
            this.btnWriteDate.Name = "btnWriteDate";
            this.btnWriteDate.Size = new System.Drawing.Size(117, 43);
            this.btnWriteDate.TabIndex = 0;
            this.btnWriteDate.Text = "Write Date";
            this.btnWriteDate.UseVisualStyleBackColor = true;
            this.btnWriteDate.Click += new System.EventHandler(this.btnWriteDate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 282);
            this.Controls.Add(this.btnWriteDate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Form Autofac Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWriteDate;
    }
}

