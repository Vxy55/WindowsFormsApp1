using System;

namespace WindowsFormsApp1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aTextBox = new System.Windows.Forms.Label();
            this.bTextBox = new System.Windows.Forms.Label();
            this.cTextBox = new System.Windows.Forms.Label();
            this.Rooot = new System.Windows.Forms.Label();
            this.Root = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.x2TestBox = new System.Windows.Forms.Label();
            this.solution1Label = new System.Windows.Forms.Label();
            this.solution5Label = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(229, 255);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(165, 78);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Given the general formula for solving second degree equations:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ax^2+BX+C=0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Please,insert values in the parameters for obtaining the roots.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // aTextBox
            // 
            this.aTextBox.AutoSize = true;
            this.aTextBox.Location = new System.Drawing.Point(79, 254);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(84, 16);
            this.aTextBox.TabIndex = 4;
            this.aTextBox.Text = "Coefficient A:";
            this.aTextBox.Click += new System.EventHandler(this.label4_Click);
            // 
            // bTextBox
            // 
            this.bTextBox.AutoSize = true;
            this.bTextBox.Location = new System.Drawing.Point(79, 285);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(84, 16);
            this.bTextBox.TabIndex = 5;
            this.bTextBox.Text = "Coefficient B:";
            // 
            // cTextBox
            // 
            this.cTextBox.AutoSize = true;
            this.cTextBox.Location = new System.Drawing.Point(79, 317);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(84, 16);
            this.cTextBox.TabIndex = 6;
            this.cTextBox.Text = "Coefficient C:";
            this.cTextBox.Click += new System.EventHandler(this.label6_Click);
            // 
            // Rooot
            // 
            this.Rooot.AutoSize = true;
            this.Rooot.Location = new System.Drawing.Point(462, 254);
            this.Rooot.Name = "Rooot";
            this.Rooot.Size = new System.Drawing.Size(49, 16);
            this.Rooot.TabIndex = 7;
            this.Rooot.Text = "Root 1:";
            // 
            // Root
            // 
            this.Root.AutoSize = true;
            this.Root.Location = new System.Drawing.Point(462, 314);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(49, 16);
            this.Root.TabIndex = 8;
            this.Root.Text = "Root 2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(483, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Two Complex roots";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 255);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(169, 314);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(47, 22);
            this.textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 283);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(47, 22);
            this.textBox2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 13;
            // 
            // x2TestBox
            // 
            this.x2TestBox.AutoSize = true;
            this.x2TestBox.Location = new System.Drawing.Point(552, 314);
            this.x2TestBox.Name = "x2TestBox";
            this.x2TestBox.Size = new System.Drawing.Size(0, 16);
            this.x2TestBox.TabIndex = 14;
            // 
            // solution1Label
            // 
            this.solution1Label.AutoSize = true;
            this.solution1Label.Location = new System.Drawing.Point(547, 257);
            this.solution1Label.Name = "solution1Label";
            this.solution1Label.Size = new System.Drawing.Size(0, 16);
            this.solution1Label.TabIndex = 19;
            // 
            // solution5Label
            // 
            this.solution5Label.AutoSize = true;
            this.solution5Label.Location = new System.Drawing.Point(550, 313);
            this.solution5Label.Name = "solution5Label";
            this.solution5Label.Size = new System.Drawing.Size(0, 16);
            this.solution5Label.TabIndex = 20;
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(547, 254);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(17, 16);
            this.lblX1.TabIndex = 21;
            this.lblX1.Text = "\"\"";
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(537, 317);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(17, 16);
            this.lblX2.TabIndex = 22;
            this.lblX2.Text = "\"\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.solution5Label);
            this.Controls.Add(this.solution1Label);
            this.Controls.Add(this.x2TestBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Root);
            this.Controls.Add(this.Rooot);
            this.Controls.Add(this.cTextBox);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Windows form ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
    

        private void eventHandler(object sender, EventArgs e) => throw new NotImplementedException();

        private void Calculate_Click(object sender, EventArgs e, NotImplementedException notImplementedException) => throw notImplementedException;

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label aTextBox;
        private System.Windows.Forms.Label bTextBox;
        private System.Windows.Forms.Label cTextBox;
        private System.Windows.Forms.Label Rooot;
        private System.Windows.Forms.Label Root;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label x2TestBox;
        private System.Windows.Forms.Label solution1Label;
        private System.Windows.Forms.Label solution5Label;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label lblX2;
    }
}

