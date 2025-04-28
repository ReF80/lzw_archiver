namespace LWZ
{
    partial class Form1
    {        
        private System.ComponentModel.IContainer components = null;                
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Код, автоматически созданный конструктором форм Windows       
        private void InitializeComponent()
        {
            this.btnFile = new System.Windows.Forms.Button();
            this.btnCompress = new System.Windows.Forms.Button();
            this.btnDecompress = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.messegeLabel = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            
            // btnFile            
            this.btnFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFile.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.btnFile.Location = new System.Drawing.Point(54, 117);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(295, 57);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Выбрать файл";
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            
            // btnCompress            
            this.btnCompress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompress.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCompress.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.btnCompress.Location = new System.Drawing.Point(54, 198);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(295, 57);
            this.btnCompress.TabIndex = 1;
            this.btnCompress.Text = "Архивировать";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            
            // btnDecompress            
            this.btnDecompress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecompress.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDecompress.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.btnDecompress.Location = new System.Drawing.Point(54, 277);
            this.btnDecompress.Name = "btnDecompress";
            this.btnDecompress.Size = new System.Drawing.Size(295, 57);
            this.btnDecompress.TabIndex = 2;
            this.btnDecompress.Text = "Разархивировать";
            this.btnDecompress.UseVisualStyleBackColor = true;
            this.btnDecompress.Click += new System.EventHandler(this.btnDecompress_Click);
            
            // btnExit            
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Black", 14F);
            this.btnExit.Location = new System.Drawing.Point(-2, -2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(223, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Сброс";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            
            // messegeLabel            
            this.messegeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.messegeLabel.Location = new System.Drawing.Point(1, 66);
            this.messegeLabel.Name = "messegeLabel";
            this.messegeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.messegeLabel.Size = new System.Drawing.Size(399, 56);
            this.messegeLabel.TabIndex = 5;
            this.messegeLabel.Text = "Выберите файл";
            this.messegeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // Exit            
            this.Exit.BackColor = System.Drawing.Color.DarkRed;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Exit.Location = new System.Drawing.Point(380, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(20, 20);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "X";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            
            // panel1            
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(54, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 60);
            this.panel1.TabIndex = 7;
            
            // panel2            
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(54, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 60);
            this.panel2.TabIndex = 8;
            
            // panel3            
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(54, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 60);
            this.panel3.TabIndex = 9;
            
            // label1             
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "LZW";
            
            // panel4            
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Location = new System.Drawing.Point(89, 363);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 48);
            this.panel4.TabIndex = 8;
            
            // panel5            
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(-4, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(420, 5);
            this.panel5.TabIndex = 11;
            
            // panel6            
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(420, 5);
            this.panel6.TabIndex = 12;
            
            // label2            
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(170, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Архиватор";
            
            // Form1            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(400, 433);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.messegeLabel);
            this.Controls.Add(this.btnDecompress);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.Button btnDecompress;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label messegeLabel;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
    }
}

