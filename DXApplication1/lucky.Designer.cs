namespace RandomNumberGenerator
{
    partial class lucky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lucky));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_OK_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("华文中宋", 15F);
            this.textBox1.Location = new System.Drawing.Point(192, 63);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 34);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 15F);
            this.label1.Location = new System.Drawing.Point(40, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "输入值";
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Font = new System.Drawing.Font("华文中宋", 15F);
            this.Button_Cancel.Location = new System.Drawing.Point(215, 132);
            this.Button_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(78, 37);
            this.Button_Cancel.TabIndex = 9;
            this.Button_Cancel.Text = "取消";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_OK_3
            // 
            this.Button_OK_3.Font = new System.Drawing.Font("华文中宋", 15F);
            this.Button_OK_3.Location = new System.Drawing.Point(55, 132);
            this.Button_OK_3.Margin = new System.Windows.Forms.Padding(2);
            this.Button_OK_3.Name = "Button_OK_3";
            this.Button_OK_3.Size = new System.Drawing.Size(80, 37);
            this.Button_OK_3.TabIndex = 8;
            this.Button_OK_3.Text = "确定";
            this.Button_OK_3.UseVisualStyleBackColor = true;
            this.Button_OK_3.Click += new System.EventHandler(this.Button_OK_3_Click);
            // 
            // lucky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 222);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK_3);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lucky.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "lucky";
            this.Text = "随机抽取";
            this.Load += new System.EventHandler(this.black_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_OK_3;
    }
}