/*
 * Created by SharpDevelop.
 * User: alexF
 * Date: 18.08.2018
 * Time: 21:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EmailSender
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox recieverTB;
		private System.Windows.Forms.TextBox subjectTB;
		private System.Windows.Forms.RichTextBox bodyRTB;
		private System.Windows.Forms.Button sendBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.recieverTB = new System.Windows.Forms.TextBox();
            this.subjectTB = new System.Windows.Forms.TextBox();
            this.bodyRTB = new System.Windows.Forms.RichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(57, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // recieverTB
            // 
            this.recieverTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recieverTB.Location = new System.Drawing.Point(57, 33);
            this.recieverTB.Name = "recieverTB";
            this.recieverTB.Size = new System.Drawing.Size(716, 20);
            this.recieverTB.TabIndex = 1;
            // 
            // subjectTB
            // 
            this.subjectTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectTB.Location = new System.Drawing.Point(56, 59);
            this.subjectTB.Name = "subjectTB";
            this.subjectTB.Size = new System.Drawing.Size(717, 20);
            this.subjectTB.TabIndex = 1;
            // 
            // bodyRTB
            // 
            this.bodyRTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyRTB.Location = new System.Drawing.Point(12, 101);
            this.bodyRTB.Name = "bodyRTB";
            this.bodyRTB.Size = new System.Drawing.Size(761, 439);
            this.bodyRTB.TabIndex = 2;
            this.bodyRTB.Text = "";
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sendBtn.Location = new System.Drawing.Point(13, 546);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 3;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.SendBtnClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subject:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(1, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Body:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 581);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.bodyRTB);
            this.Controls.Add(this.subjectTB);
            this.Controls.Add(this.recieverTB);
            this.Controls.Add(this.comboBox1);
            this.Name = "MainForm";
            this.Text = "EmailSender";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}
