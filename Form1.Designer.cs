namespace Calculadora_Csharp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonNum1 = new System.Windows.Forms.Button();
            this.buttonNum2 = new System.Windows.Forms.Button();
            this.buttonNum3 = new System.Windows.Forms.Button();
            this.buttonNum6 = new System.Windows.Forms.Button();
            this.buttonNum5 = new System.Windows.Forms.Button();
            this.buttonNum4 = new System.Windows.Forms.Button();
            this.buttonNum9 = new System.Windows.Forms.Button();
            this.buttonNum8 = new System.Windows.Forms.Button();
            this.buttonNum7 = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonNum0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMulti = new System.Windows.Forms.Button();
            this.buttonRest = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 40);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonNum1
            // 
            this.buttonNum1.Location = new System.Drawing.Point(9, 120);
            this.buttonNum1.Name = "buttonNum1";
            this.buttonNum1.Size = new System.Drawing.Size(97, 43);
            this.buttonNum1.TabIndex = 1;
            this.buttonNum1.Text = "1";
            this.buttonNum1.UseVisualStyleBackColor = true;
            this.buttonNum1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNum2
            // 
            this.buttonNum2.Location = new System.Drawing.Point(112, 120);
            this.buttonNum2.Name = "buttonNum2";
            this.buttonNum2.Size = new System.Drawing.Size(92, 43);
            this.buttonNum2.TabIndex = 2;
            this.buttonNum2.Text = "2";
            this.buttonNum2.UseVisualStyleBackColor = true;
            this.buttonNum2.Click += new System.EventHandler(this.buttonNum2_Click);
            // 
            // buttonNum3
            // 
            this.buttonNum3.Location = new System.Drawing.Point(210, 120);
            this.buttonNum3.Name = "buttonNum3";
            this.buttonNum3.Size = new System.Drawing.Size(103, 43);
            this.buttonNum3.TabIndex = 3;
            this.buttonNum3.Text = "3";
            this.buttonNum3.UseVisualStyleBackColor = true;
            this.buttonNum3.Click += new System.EventHandler(this.buttonNum3_Click);
            // 
            // buttonNum6
            // 
            this.buttonNum6.Location = new System.Drawing.Point(210, 169);
            this.buttonNum6.Name = "buttonNum6";
            this.buttonNum6.Size = new System.Drawing.Size(103, 43);
            this.buttonNum6.TabIndex = 6;
            this.buttonNum6.Text = "6";
            this.buttonNum6.UseVisualStyleBackColor = true;
            this.buttonNum6.Click += new System.EventHandler(this.buttonNum6_Click);
            // 
            // buttonNum5
            // 
            this.buttonNum5.Location = new System.Drawing.Point(112, 169);
            this.buttonNum5.Name = "buttonNum5";
            this.buttonNum5.Size = new System.Drawing.Size(92, 43);
            this.buttonNum5.TabIndex = 5;
            this.buttonNum5.Text = "5";
            this.buttonNum5.UseVisualStyleBackColor = true;
            this.buttonNum5.Click += new System.EventHandler(this.buttonNum5_Click);
            // 
            // buttonNum4
            // 
            this.buttonNum4.Location = new System.Drawing.Point(9, 169);
            this.buttonNum4.Name = "buttonNum4";
            this.buttonNum4.Size = new System.Drawing.Size(97, 43);
            this.buttonNum4.TabIndex = 4;
            this.buttonNum4.Text = "4";
            this.buttonNum4.UseVisualStyleBackColor = true;
            this.buttonNum4.Click += new System.EventHandler(this.buttonNum4_Click);
            // 
            // buttonNum9
            // 
            this.buttonNum9.Location = new System.Drawing.Point(210, 218);
            this.buttonNum9.Name = "buttonNum9";
            this.buttonNum9.Size = new System.Drawing.Size(103, 43);
            this.buttonNum9.TabIndex = 9;
            this.buttonNum9.Text = "9";
            this.buttonNum9.UseVisualStyleBackColor = true;
            this.buttonNum9.Click += new System.EventHandler(this.buttonNum9_Click);
            // 
            // buttonNum8
            // 
            this.buttonNum8.Location = new System.Drawing.Point(112, 218);
            this.buttonNum8.Name = "buttonNum8";
            this.buttonNum8.Size = new System.Drawing.Size(92, 43);
            this.buttonNum8.TabIndex = 8;
            this.buttonNum8.Text = "8";
            this.buttonNum8.UseVisualStyleBackColor = true;
            this.buttonNum8.Click += new System.EventHandler(this.buttonNum8_Click);
            // 
            // buttonNum7
            // 
            this.buttonNum7.Location = new System.Drawing.Point(9, 218);
            this.buttonNum7.Name = "buttonNum7";
            this.buttonNum7.Size = new System.Drawing.Size(97, 43);
            this.buttonNum7.TabIndex = 7;
            this.buttonNum7.Text = "7";
            this.buttonNum7.UseVisualStyleBackColor = true;
            this.buttonNum7.Click += new System.EventHandler(this.buttonNum7_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(210, 267);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(103, 43);
            this.buttonEqual.TabIndex = 12;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonNum0
            // 
            this.buttonNum0.Location = new System.Drawing.Point(112, 267);
            this.buttonNum0.Name = "buttonNum0";
            this.buttonNum0.Size = new System.Drawing.Size(92, 43);
            this.buttonNum0.TabIndex = 11;
            this.buttonNum0.Text = "0";
            this.buttonNum0.UseVisualStyleBackColor = true;
            this.buttonNum0.Click += new System.EventHandler(this.buttonNum0_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Location = new System.Drawing.Point(9, 267);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(97, 43);
            this.buttonDot.TabIndex = 10;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(319, 267);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(103, 43);
            this.buttonDiv.TabIndex = 16;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonMulti
            // 
            this.buttonMulti.Location = new System.Drawing.Point(319, 218);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(101, 43);
            this.buttonMulti.TabIndex = 15;
            this.buttonMulti.Text = "X";
            this.buttonMulti.UseVisualStyleBackColor = true;
            this.buttonMulti.Click += new System.EventHandler(this.buttonMulti_Click);
            // 
            // buttonRest
            // 
            this.buttonRest.Location = new System.Drawing.Point(319, 169);
            this.buttonRest.Name = "buttonRest";
            this.buttonRest.Size = new System.Drawing.Size(103, 43);
            this.buttonRest.TabIndex = 14;
            this.buttonRest.Text = "-";
            this.buttonRest.UseVisualStyleBackColor = true;
            this.buttonRest.Click += new System.EventHandler(this.buttonRest_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(319, 120);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(103, 43);
            this.buttonSum.TabIndex = 13;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(210, 76);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(103, 37);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(319, 76);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(103, 37);
            this.buttonDel.TabIndex = 18;
            this.buttonDel.Text = "Del";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 331);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMulti);
            this.Controls.Add(this.buttonRest);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonNum0);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.buttonNum9);
            this.Controls.Add(this.buttonNum8);
            this.Controls.Add(this.buttonNum7);
            this.Controls.Add(this.buttonNum6);
            this.Controls.Add(this.buttonNum5);
            this.Controls.Add(this.buttonNum4);
            this.Controls.Add(this.buttonNum3);
            this.Controls.Add(this.buttonNum2);
            this.Controls.Add(this.buttonNum1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonNum1;
        private System.Windows.Forms.Button buttonNum2;
        private System.Windows.Forms.Button buttonNum3;
        private System.Windows.Forms.Button buttonNum6;
        private System.Windows.Forms.Button buttonNum5;
        private System.Windows.Forms.Button buttonNum4;
        private System.Windows.Forms.Button buttonNum9;
        private System.Windows.Forms.Button buttonNum8;
        private System.Windows.Forms.Button buttonNum7;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonNum0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.Button buttonRest;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDel;
    }
}

