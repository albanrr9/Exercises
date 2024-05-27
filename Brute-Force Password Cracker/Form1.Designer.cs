namespace Brute_Force_Password_Cracker
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtTargetPassword = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(39, 46);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "Type Password:";
			// 
			// txtTargetPassword
			// 
			this.txtTargetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
			this.txtTargetPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTargetPassword.ForeColor = System.Drawing.Color.White;
			this.txtTargetPassword.Location = new System.Drawing.Point(35, 71);
			this.txtTargetPassword.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
			this.txtTargetPassword.Name = "txtTargetPassword";
			this.txtTargetPassword.Size = new System.Drawing.Size(293, 28);
			this.txtTargetPassword.TabIndex = 1;
			this.txtTargetPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTargetPassword_KeyDown);
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
			this.btnStart.FlatAppearance.BorderSize = 0;
			this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(78)))), ((int)(((byte)(0)))));
			this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStart.ForeColor = System.Drawing.Color.White;
			this.btnStart.Location = new System.Drawing.Point(128, 113);
			this.btnStart.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(112, 47);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(84, 178);
			this.label2.MinimumSize = new System.Drawing.Size(200, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(200, 100);
			this.label2.TabIndex = 3;
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 27F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(377, 420);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.txtTargetPassword);
			this.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTargetPassword;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label label2;
	}
}

