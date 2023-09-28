namespace Cash_Register_Shoe
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.shirtlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShortsInput = new System.Windows.Forms.TextBox();
            this.TotalInput = new System.Windows.Forms.TextBox();
            this.taxlabel = new System.Windows.Forms.Label();
            this.TaxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Silver;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(-4, -1);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(746, 97);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "shirt";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(40, 206);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(138, 36);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // shirtlabel
            // 
            this.shirtlabel.AutoSize = true;
            this.shirtlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shirtlabel.Location = new System.Drawing.Point(42, 147);
            this.shirtlabel.Name = "shirtlabel";
            this.shirtlabel.Size = new System.Drawing.Size(233, 16);
            this.shirtlabel.TabIndex = 2;
            this.shirtlabel.Text = "how Many shirt will You  Doing Today :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your  Total :";
            // 
            // ShortsInput
            // 
            this.ShortsInput.Location = new System.Drawing.Point(293, 147);
            this.ShortsInput.Name = "ShortsInput";
            this.ShortsInput.Size = new System.Drawing.Size(100, 20);
            this.ShortsInput.TabIndex = 4;
            // 
            // TotalInput
            // 
            this.TotalInput.Location = new System.Drawing.Point(190, 405);
            this.TotalInput.Name = "TotalInput";
            this.TotalInput.Size = new System.Drawing.Size(100, 20);
            this.TotalInput.TabIndex = 5;
            // 
            // taxlabel
            // 
            this.taxlabel.Location = new System.Drawing.Point(37, 319);
            this.taxlabel.Name = "taxlabel";
            this.taxlabel.Size = new System.Drawing.Size(100, 23);
            this.taxlabel.TabIndex = 6;
            this.taxlabel.Text = "Your Tax Amount :";
            // 
            // TaxInput
            // 
            this.TaxInput.Location = new System.Drawing.Point(190, 322);
            this.TaxInput.Name = "TaxInput";
            this.TaxInput.Size = new System.Drawing.Size(100, 20);
            this.TaxInput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(744, 559);
            this.Controls.Add(this.TaxInput);
            this.Controls.Add(this.taxlabel);
            this.Controls.Add(this.TotalInput);
            this.Controls.Add(this.ShortsInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shirtlabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label shirtlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ShortsInput;
        private System.Windows.Forms.TextBox TotalInput;
        private System.Windows.Forms.Label taxlabel;
        private System.Windows.Forms.TextBox TaxInput;
    }
}

