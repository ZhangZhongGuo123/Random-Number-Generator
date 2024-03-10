namespace RandomNumberGenerator
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_OK_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("华文中宋", 15F);
            this.textBox1.Location = new System.Drawing.Point(190, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 34);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 15F);
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "输入白名单值";
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Font = new System.Drawing.Font("华文中宋", 15F);
            this.Button_Cancel.Location = new System.Drawing.Point(213, 109);
            this.Button_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(78, 37);
            this.Button_Cancel.TabIndex = 5;
            this.Button_Cancel.Text = "取消";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_OK_3
            // 
            this.Button_OK_3.Font = new System.Drawing.Font("华文中宋", 15F);
            this.Button_OK_3.Location = new System.Drawing.Point(53, 109);
            this.Button_OK_3.Margin = new System.Windows.Forms.Padding(2);
            this.Button_OK_3.Name = "Button_OK_3";
            this.Button_OK_3.Size = new System.Drawing.Size(80, 37);
            this.Button_OK_3.TabIndex = 4;
            this.Button_OK_3.Text = "确定";
            this.Button_OK_3.UseVisualStyleBackColor = true;
            this.Button_OK_3.Click += new System.EventHandler(this.Button_OK_3_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 177);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK_3);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Form6.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.Text = "随机抽取";
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