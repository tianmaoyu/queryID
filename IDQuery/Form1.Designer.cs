namespace IDQuery
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_phoneNumber = new System.Windows.Forms.TextBox();
            this.tb_Identification = new System.Windows.Forms.TextBox();
            this.tb_adress = new System.Windows.Forms.TextBox();
            this.button_seach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_key = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_cpu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_UpdataCookie = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb_phoneNumber
            // 
            this.tb_phoneNumber.Location = new System.Drawing.Point(64, 51);
            this.tb_phoneNumber.Name = "tb_phoneNumber";
            this.tb_phoneNumber.Size = new System.Drawing.Size(218, 21);
            this.tb_phoneNumber.TabIndex = 0;
            // 
            // tb_Identification
            // 
            this.tb_Identification.Location = new System.Drawing.Point(64, 125);
            this.tb_Identification.Name = "tb_Identification";
            this.tb_Identification.Size = new System.Drawing.Size(218, 21);
            this.tb_Identification.TabIndex = 1;
            // 
            // tb_adress
            // 
            this.tb_adress.Location = new System.Drawing.Point(64, 179);
            this.tb_adress.Multiline = true;
            this.tb_adress.Name = "tb_adress";
            this.tb_adress.Size = new System.Drawing.Size(218, 35);
            this.tb_adress.TabIndex = 2;
            // 
            // button_seach
            // 
            this.button_seach.Location = new System.Drawing.Point(207, 87);
            this.button_seach.Name = "button_seach";
            this.button_seach.Size = new System.Drawing.Size(75, 23);
            this.button_seach.TabIndex = 3;
            this.button_seach.Text = "查询";
            this.button_seach.UseVisualStyleBackColor = true;
            this.button_seach.Click += new System.EventHandler(this.button_seach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "电话号码";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "身份证";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "地址";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(64, 152);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(218, 21);
            this.tb_name.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "姓名";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_key
            // 
            this.tb_key.Location = new System.Drawing.Point(64, 242);
            this.tb_key.Multiline = true;
            this.tb_key.Name = "tb_key";
            this.tb_key.Size = new System.Drawing.Size(218, 35);
            this.tb_key.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "授权码";
            // 
            // tb_cpu
            // 
            this.tb_cpu.Location = new System.Drawing.Point(64, 283);
            this.tb_cpu.Multiline = true;
            this.tb_cpu.Name = "tb_cpu";
            this.tb_cpu.Size = new System.Drawing.Size(218, 25);
            this.tb_cpu.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "机器码";
            // 
            // checkBox_UpdataCookie
            // 
            this.checkBox_UpdataCookie.AutoSize = true;
            this.checkBox_UpdataCookie.Location = new System.Drawing.Point(174, 220);
            this.checkBox_UpdataCookie.Name = "checkBox_UpdataCookie";
            this.checkBox_UpdataCookie.Size = new System.Drawing.Size(108, 16);
            this.checkBox_UpdataCookie.TabIndex = 13;
            this.checkBox_UpdataCookie.Text = "是否更新Cookie";
            this.checkBox_UpdataCookie.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 327);
            this.Controls.Add(this.checkBox_UpdataCookie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_cpu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_key);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_seach);
            this.Controls.Add(this.tb_adress);
            this.Controls.Add(this.tb_Identification);
            this.Controls.Add(this.tb_phoneNumber);
            this.Name = "Form1";
            this.Text = "............";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_phoneNumber;
        private System.Windows.Forms.TextBox tb_Identification;
        private System.Windows.Forms.TextBox tb_adress;
        private System.Windows.Forms.Button button_seach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_key;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_cpu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_UpdataCookie;
    }
}

