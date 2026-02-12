namespace WinFormsApp9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.GroupBox groupResults;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblMul;
        private System.Windows.Forms.Label lblSumResult;
        private System.Windows.Forms.Label lblSubResult;
        private System.Windows.Forms.Label lblMulResult;
        private System.Windows.Forms.Button btnClear;

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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.groupResults = new System.Windows.Forms.GroupBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblMul = new System.Windows.Forms.Label();
            this.lblSumResult = new System.Windows.Forms.Label();
            this.lblSubResult = new System.Windows.Forms.Label();
            this.lblMulResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 260);
            this.Text = "Calculadora - Suma, Resta y Multiplicación";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(14, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(310, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Calculadora: muestra 3 resultados simultáneos";
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(20, 60);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(66, 15);
            this.lblNumber1.TabIndex = 1;
            this.lblNumber1.Text = "Número 1:";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(100, 57);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(120, 23);
            this.txtNumber1.TabIndex = 2;
            this.txtNumber1.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(20, 95);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(66, 15);
            this.lblNumber2.TabIndex = 3;
            this.lblNumber2.Text = "Número 2:";
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(100, 92);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(120, 23);
            this.txtNumber2.TabIndex = 4;
            this.txtNumber2.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(240, 57);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 58);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupResults
            // 
            this.groupResults.Controls.Add(this.lblSum);
            this.groupResults.Controls.Add(this.lblSumResult);
            this.groupResults.Controls.Add(this.lblSub);
            this.groupResults.Controls.Add(this.lblSubResult);
            this.groupResults.Controls.Add(this.lblMul);
            this.groupResults.Controls.Add(this.lblMulResult);
            this.groupResults.Location = new System.Drawing.Point(20, 135);
            this.groupResults.Name = "groupResults";
            this.groupResults.Size = new System.Drawing.Size(360, 100);
            this.groupResults.TabIndex = 6;
            this.groupResults.TabStop = false;
            this.groupResults.Text = "Resultados";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(16, 24);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(36, 15);
            this.lblSum.TabIndex = 0;
            this.lblSum.Text = "Suma:";
            // 
            // lblSumResult
            // 
            this.lblSumResult.AutoSize = true;
            this.lblSumResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSumResult.Location = new System.Drawing.Point(120, 24);
            this.lblSumResult.Name = "lblSumResult";
            this.lblSumResult.Size = new System.Drawing.Size(12, 15);
            this.lblSumResult.TabIndex = 1;
            this.lblSumResult.Text = "-";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(16, 48);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(42, 15);
            this.lblSub.TabIndex = 2;
            this.lblSub.Text = "Resta:";
            // 
            // lblSubResult
            // 
            this.lblSubResult.AutoSize = true;
            this.lblSubResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubResult.Location = new System.Drawing.Point(120, 48);
            this.lblSubResult.Name = "lblSubResult";
            this.lblSubResult.Size = new System.Drawing.Size(12, 15);
            this.lblSubResult.TabIndex = 3;
            this.lblSubResult.Text = "-";
            // 
            // lblMul
            // 
            this.lblMul.AutoSize = true;
            this.lblMul.Location = new System.Drawing.Point(16, 72);
            this.lblMul.Name = "lblMul";
            this.lblMul.Size = new System.Drawing.Size(77, 15);
            this.lblMul.TabIndex = 4;
            this.lblMul.Text = "Multiplicación:";
            // 
            // lblMulResult
            // 
            this.lblMulResult.AutoSize = true;
            this.lblMulResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMulResult.Location = new System.Drawing.Point(120, 72);
            this.lblMulResult.Name = "lblMulResult";
            this.lblMulResult.Size = new System.Drawing.Size(12, 15);
            this.lblMulResult.TabIndex = 5;
            this.lblMulResult.Text = "-";
            // 
            // Form1 (finalize)
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupResults);
            this.groupResults.ResumeLayout(false);
            this.groupResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
