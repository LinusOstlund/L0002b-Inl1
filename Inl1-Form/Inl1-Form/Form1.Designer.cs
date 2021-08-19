
namespace Inl1_Form
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
            this.costInput = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.paymentInput = new System.Windows.Forms.TextBox();
            this.outputTextbox = new System.Windows.Forms.RichTextBox();
            this.costLbl = new System.Windows.Forms.Label();
            this.paymentLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // costInput
            // 
            this.costInput.Location = new System.Drawing.Point(142, 39);
            this.costInput.Name = "costInput";
            this.costInput.Size = new System.Drawing.Size(194, 20);
            this.costInput.TabIndex = 1;
         
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(142, 91);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(194, 23);
            this.calculateBtn.TabIndex = 2;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // paymentInput
            // 
            this.paymentInput.Location = new System.Drawing.Point(142, 65);
            this.paymentInput.Name = "paymentInput";
            this.paymentInput.Size = new System.Drawing.Size(194, 20);
            this.paymentInput.TabIndex = 3;
            
            // 
            // outputTextbox
            // 
            this.outputTextbox.Location = new System.Drawing.Point(142, 120);
            this.outputTextbox.Name = "outputTextbox";
            this.outputTextbox.ReadOnly = true;
            this.outputTextbox.Size = new System.Drawing.Size(194, 103);
            this.outputTextbox.TabIndex = 4;
            this.outputTextbox.Text = "";
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Location = new System.Drawing.Point(15, 42);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(121, 13);
            this.costLbl.TabIndex = 5;
            this.costLbl.Text = "Price of shopping spree:";
            // 
            // paymentLbl
            // 
            this.paymentLbl.AutoSize = true;
            this.paymentLbl.Location = new System.Drawing.Point(61, 68);
            this.paymentLbl.Name = "paymentLbl";
            this.paymentLbl.Size = new System.Drawing.Size(75, 13);
            this.paymentLbl.TabIndex = 6;
            this.paymentLbl.Text = "Your payment:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 240);
            this.Controls.Add(this.paymentLbl);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.outputTextbox);
            this.Controls.Add(this.paymentInput);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.costInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox costInput;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox paymentInput;
        private System.Windows.Forms.RichTextBox outputTextbox;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Label paymentLbl;
    }
}

