namespace Matrix_Calculator
{
    partial class FormCalculator
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
            this.btnGen = new System.Windows.Forms.Button();
            this.numRow1 = new System.Windows.Forms.NumericUpDown();
            this.numCol1 = new System.Windows.Forms.NumericUpDown();
            this.numRow2 = new System.Windows.Forms.NumericUpDown();
            this.numCol2 = new System.Windows.Forms.NumericUpDown();
            this.lblMatrixA = new System.Windows.Forms.Label();
            this.lblMatrixB = new System.Windows.Forms.Label();
            this.Times1 = new System.Windows.Forms.Label();
            this.Times2 = new System.Windows.Forms.Label();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDetA = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDetB = new System.Windows.Forms.Button();
            this.btnClearA = new System.Windows.Forms.Button();
            this.btnClearB = new System.Windows.Forms.Button();
            this.lblMatrixC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numRow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCol1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCol2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGen
            // 
            this.btnGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGen.Location = new System.Drawing.Point(40, 276);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(123, 34);
            this.btnGen.TabIndex = 4;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.BtnGen_Click);
            // 
            // numRow1
            // 
            this.numRow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numRow1.Location = new System.Drawing.Point(89, 43);
            this.numRow1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRow1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRow1.Name = "numRow1";
            this.numRow1.Size = new System.Drawing.Size(63, 30);
            this.numRow1.TabIndex = 0;
            this.numRow1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numCol1
            // 
            this.numCol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numCol1.Location = new System.Drawing.Point(191, 43);
            this.numCol1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCol1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCol1.Name = "numCol1";
            this.numCol1.Size = new System.Drawing.Size(63, 30);
            this.numCol1.TabIndex = 1;
            this.numCol1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numRow2
            // 
            this.numRow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numRow2.Location = new System.Drawing.Point(467, 43);
            this.numRow2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRow2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRow2.Name = "numRow2";
            this.numRow2.Size = new System.Drawing.Size(63, 30);
            this.numRow2.TabIndex = 2;
            this.numRow2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numCol2
            // 
            this.numCol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numCol2.Location = new System.Drawing.Point(572, 43);
            this.numCol2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCol2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCol2.Name = "numCol2";
            this.numCol2.Size = new System.Drawing.Size(63, 30);
            this.numCol2.TabIndex = 3;
            this.numCol2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMatrixA
            // 
            this.lblMatrixA.AutoSize = true;
            this.lblMatrixA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMatrixA.Location = new System.Drawing.Point(132, 9);
            this.lblMatrixA.Name = "lblMatrixA";
            this.lblMatrixA.Size = new System.Drawing.Size(84, 25);
            this.lblMatrixA.TabIndex = 5;
            this.lblMatrixA.Text = "Matrix A";
            // 
            // lblMatrixB
            // 
            this.lblMatrixB.AutoSize = true;
            this.lblMatrixB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMatrixB.Location = new System.Drawing.Point(506, 9);
            this.lblMatrixB.Name = "lblMatrixB";
            this.lblMatrixB.Size = new System.Drawing.Size(83, 25);
            this.lblMatrixB.TabIndex = 6;
            this.lblMatrixB.Text = "Matrix B";
            // 
            // Times1
            // 
            this.Times1.AutoSize = true;
            this.Times1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Times1.Location = new System.Drawing.Point(541, 45);
            this.Times1.Name = "Times1";
            this.Times1.Size = new System.Drawing.Size(22, 25);
            this.Times1.TabIndex = 7;
            this.Times1.Text = "x";
            // 
            // Times2
            // 
            this.Times2.AutoSize = true;
            this.Times2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Times2.Location = new System.Drawing.Point(161, 45);
            this.Times2.Name = "Times2";
            this.Times2.Size = new System.Drawing.Size(22, 25);
            this.Times2.TabIndex = 8;
            this.Times2.Text = "x";
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMultiply.Location = new System.Drawing.Point(427, 276);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(123, 34);
            this.btnMultiply.TabIndex = 8;
            this.btnMultiply.Text = "A x B";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // btnDetA
            // 
            this.btnDetA.Location = new System.Drawing.Point(557, 276);
            this.btnDetA.Name = "btnDetA";
            this.btnDetA.Size = new System.Drawing.Size(134, 34);
            this.btnDetA.TabIndex = 6;
            this.btnDetA.Text = "Determinant of A";
            this.btnDetA.UseVisualStyleBackColor = true;
            this.btnDetA.Click += new System.EventHandler(this.BtnDetA_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSub.Location = new System.Drawing.Point(298, 276);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(123, 34);
            this.btnSub.TabIndex = 9;
            this.btnSub.Text = "A - B";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(169, 276);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 34);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "A + B";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDetB
            // 
            this.btnDetB.Location = new System.Drawing.Point(697, 276);
            this.btnDetB.Name = "btnDetB";
            this.btnDetB.Size = new System.Drawing.Size(134, 34);
            this.btnDetB.TabIndex = 10;
            this.btnDetB.Text = "Determinant of B";
            this.btnDetB.UseVisualStyleBackColor = true;
            this.btnDetB.Click += new System.EventHandler(this.BtnDetB_Click);
            // 
            // btnClearA
            // 
            this.btnClearA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClearA.Location = new System.Drawing.Point(837, 276);
            this.btnClearA.Name = "btnClearA";
            this.btnClearA.Size = new System.Drawing.Size(123, 34);
            this.btnClearA.TabIndex = 7;
            this.btnClearA.Text = "Clear A";
            this.btnClearA.UseVisualStyleBackColor = true;
            this.btnClearA.Click += new System.EventHandler(this.BtnClearA_Click);
            // 
            // btnClearB
            // 
            this.btnClearB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClearB.Location = new System.Drawing.Point(966, 276);
            this.btnClearB.Name = "btnClearB";
            this.btnClearB.Size = new System.Drawing.Size(123, 34);
            this.btnClearB.TabIndex = 11;
            this.btnClearB.Text = "Clear B";
            this.btnClearB.UseVisualStyleBackColor = true;
            this.btnClearB.Click += new System.EventHandler(this.BtnClearB_Click);
            // 
            // lblMatrixC
            // 
            this.lblMatrixC.AutoSize = true;
            this.lblMatrixC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMatrixC.Location = new System.Drawing.Point(893, 9);
            this.lblMatrixC.Name = "lblMatrixC";
            this.lblMatrixC.Size = new System.Drawing.Size(85, 25);
            this.lblMatrixC.TabIndex = 12;
            this.lblMatrixC.Text = "Matrix C";
            this.lblMatrixC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 336);
            this.Controls.Add(this.lblMatrixC);
            this.Controls.Add(this.btnClearB);
            this.Controls.Add(this.btnClearA);
            this.Controls.Add(this.btnDetB);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnDetA);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.Times2);
            this.Controls.Add(this.Times1);
            this.Controls.Add(this.lblMatrixB);
            this.Controls.Add(this.lblMatrixA);
            this.Controls.Add(this.numCol2);
            this.Controls.Add(this.numRow2);
            this.Controls.Add(this.numCol1);
            this.Controls.Add(this.numRow1);
            this.Controls.Add(this.btnGen);
            this.Name = "FormCalculator";
            this.Text = "Matrix Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numRow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCol1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCol2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.NumericUpDown numRow1;
        private System.Windows.Forms.NumericUpDown numCol1;
        private System.Windows.Forms.NumericUpDown numRow2;
        private System.Windows.Forms.NumericUpDown numCol2;
        private System.Windows.Forms.Label lblMatrixA;
        private System.Windows.Forms.Label lblMatrixB;
        private System.Windows.Forms.Label Times1;
        private System.Windows.Forms.Label Times2;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDetA;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDetB;
        private System.Windows.Forms.Button btnClearA;
        private System.Windows.Forms.Button btnClearB;
        private System.Windows.Forms.Label lblMatrixC;
    }
}

