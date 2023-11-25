namespace prog._4
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
            this.btnReadArray = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnWriteResult = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReadArray
            // 
            this.btnReadArray.Location = new System.Drawing.Point(239, 205);
            this.btnReadArray.Name = "btnReadArray";
            this.btnReadArray.Size = new System.Drawing.Size(240, 40);
            this.btnReadArray.TabIndex = 0;
            this.btnReadArray.Text = "Вибрати текстовий файл";
            this.btnReadArray.UseVisualStyleBackColor = true;
            this.btnReadArray.Click += new System.EventHandler(this.btnReadArray_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(210, 267);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(305, 40);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Визначити кількість унікальних чисел";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnWriteResult
            // 
            this.btnWriteResult.Location = new System.Drawing.Point(190, 328);
            this.btnWriteResult.Name = "btnWriteResult";
            this.btnWriteResult.Size = new System.Drawing.Size(343, 34);
            this.btnWriteResult.TabIndex = 2;
            this.btnWriteResult.Text = "Записати результат у текстовий файл";
            this.btnWriteResult.UseVisualStyleBackColor = true;
            this.btnWriteResult.Click += new System.EventHandler(this.btnWriteResult_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(235, 153);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 20);
            this.lblMessage.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnWriteResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnReadArray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadArray;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnWriteResult;
        private System.Windows.Forms.Label lblMessage;
    }
}

