
namespace Facade
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.order_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edType = new System.Windows.Forms.TextBox();
            this.edSize = new System.Windows.Forms.TextBox();
            this.edCountry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // order_button
            // 
            this.order_button.Location = new System.Drawing.Point(685, 403);
            this.order_button.Name = "order_button";
            this.order_button.Size = new System.Drawing.Size(103, 35);
            this.order_button.TabIndex = 0;
            this.order_button.Text = "Order";
            this.order_button.UseVisualStyleBackColor = true;
            this.order_button.Click += new System.EventHandler(this.order_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type of clothing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size of clothing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Country to deliver";
            // 
            // edType
            // 
            this.edType.Location = new System.Drawing.Point(126, 8);
            this.edType.Name = "edType";
            this.edType.Size = new System.Drawing.Size(128, 23);
            this.edType.TabIndex = 4;
            this.edType.Text = "shirt";
            // 
            // edSize
            // 
            this.edSize.Location = new System.Drawing.Point(126, 37);
            this.edSize.Name = "edSize";
            this.edSize.Size = new System.Drawing.Size(128, 23);
            this.edSize.TabIndex = 5;
            this.edSize.Text = "M";
            // 
            // edCountry
            // 
            this.edCountry.Location = new System.Drawing.Point(126, 67);
            this.edCountry.Name = "edCountry";
            this.edCountry.Size = new System.Drawing.Size(128, 23);
            this.edCountry.TabIndex = 6;
            this.edCountry.Text = "Russia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stuff price with VAT:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edCountry);
            this.Controls.Add(this.edSize);
            this.Controls.Add(this.edType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.order_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button order_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edSize;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox edCountry;
        public System.Windows.Forms.TextBox edType;
        private System.Windows.Forms.Label label5;
    }
}

