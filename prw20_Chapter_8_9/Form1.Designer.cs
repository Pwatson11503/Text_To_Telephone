namespace prw20_Chapter_8_9
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
			this.btnConvert = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.txtUserInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblOutput = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnConvert
			// 
			this.btnConvert.Location = new System.Drawing.Point(43, 115);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(75, 23);
			this.btnConvert.TabIndex = 0;
			this.btnConvert.Text = "Convert";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(85, 143);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// txtUserInput
			// 
			this.txtUserInput.Location = new System.Drawing.Point(67, 38);
			this.txtUserInput.Name = "txtUserInput";
			this.txtUserInput.Size = new System.Drawing.Size(111, 20);
			this.txtUserInput.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(207, 26);
			this.label1.TabIndex = 3;
			this.label1.Text = "Please enter a 10 letter text in the format \r\nXXX-XXX-XXXX you would like convert" +
    "ed.";
			// 
			// lblOutput
			// 
			this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblOutput.Location = new System.Drawing.Point(79, 73);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(85, 19);
			this.lblOutput.TabIndex = 4;
			this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(124, 115);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 5;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(249, 191);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUserInput);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnConvert);
			this.Name = "Form1";
			this.Text = "Alphabet Tele Number";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnConvert;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TextBox txtUserInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.Button btnClear;
	}
}

