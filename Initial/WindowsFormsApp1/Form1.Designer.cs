
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.nmSayi1 = new System.Windows.Forms.NumericUpDown();
            this.nmSayi2 = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmSayi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSayi2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.Location = new System.Drawing.Point(68, 25);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(37, 15);
            this.lblSayi1.TabIndex = 0;
            this.lblSayi1.Text = "Sayı 1";
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.Location = new System.Drawing.Point(68, 56);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(37, 15);
            this.lblSayi2.TabIndex = 1;
            this.lblSayi2.Text = "Sayı 2";
            // 
            // nmSayi1
            // 
            this.nmSayi1.Location = new System.Drawing.Point(132, 23);
            this.nmSayi1.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmSayi1.Name = "nmSayi1";
            this.nmSayi1.Size = new System.Drawing.Size(120, 23);
            this.nmSayi1.TabIndex = 2;
            // 
            // nmSayi2
            // 
            this.nmSayi2.Location = new System.Drawing.Point(132, 54);
            this.nmSayi2.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmSayi2.Name = "nmSayi2";
            this.nmSayi2.Size = new System.Drawing.Size(120, 23);
            this.nmSayi2.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(177, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Topla";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 168);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nmSayi2);
            this.Controls.Add(this.nmSayi1);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.lblSayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmSayi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSayi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.NumericUpDown nmSayi1;
        private System.Windows.Forms.NumericUpDown nmSayi2;
        private System.Windows.Forms.Button btnAdd;
    }
}

