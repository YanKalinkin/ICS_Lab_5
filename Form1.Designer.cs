namespace ICS_Lab_5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.hash_btn = new System.Windows.Forms.Button();
            this.p_box = new System.Windows.Forms.TextBox();
            this.q_box = new System.Windows.Forms.TextBox();
            this.e_box = new System.Windows.Forms.TextBox();
            this.d_box = new System.Windows.Forms.TextBox();
            this.hash_box = new System.Windows.Forms.TextBox();
            this.s_A_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.n_box = new System.Windows.Forms.TextBox();
            this.keys = new System.Windows.Forms.Button();
            this.msg_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.e_box_1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.d_box_1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.n_box_1 = new System.Windows.Forms.TextBox();
            this.crypt = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Msg_box_1 = new System.Windows.Forms.TextBox();
            this.check_eds_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.m_sht_box = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.s_check_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hash_btn
            // 
            this.hash_btn.Location = new System.Drawing.Point(12, 309);
            this.hash_btn.Name = "hash_btn";
            this.hash_btn.Size = new System.Drawing.Size(269, 29);
            this.hash_btn.TabIndex = 0;
            this.hash_btn.Text = "Get hash";
            this.hash_btn.UseVisualStyleBackColor = true;
            this.hash_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // p_box
            // 
            this.p_box.Location = new System.Drawing.Point(13, 32);
            this.p_box.Name = "p_box";
            this.p_box.Size = new System.Drawing.Size(100, 22);
            this.p_box.TabIndex = 1;
            // 
            // q_box
            // 
            this.q_box.Location = new System.Drawing.Point(13, 74);
            this.q_box.Name = "q_box";
            this.q_box.Size = new System.Drawing.Size(100, 22);
            this.q_box.TabIndex = 2;
            // 
            // e_box
            // 
            this.e_box.Location = new System.Drawing.Point(181, 31);
            this.e_box.Name = "e_box";
            this.e_box.Size = new System.Drawing.Size(100, 22);
            this.e_box.TabIndex = 3;
            // 
            // d_box
            // 
            this.d_box.Location = new System.Drawing.Point(181, 74);
            this.d_box.Name = "d_box";
            this.d_box.ReadOnly = true;
            this.d_box.Size = new System.Drawing.Size(100, 22);
            this.d_box.TabIndex = 4;
            // 
            // hash_box
            // 
            this.hash_box.Location = new System.Drawing.Point(16, 456);
            this.hash_box.Name = "hash_box";
            this.hash_box.ReadOnly = true;
            this.hash_box.Size = new System.Drawing.Size(491, 22);
            this.hash_box.TabIndex = 5;
            // 
            // s_A_box
            // 
            this.s_A_box.Location = new System.Drawing.Point(433, 122);
            this.s_A_box.Name = "s_A_box";
            this.s_A_box.Size = new System.Drawing.Size(491, 22);
            this.s_A_box.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "m = h(M)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "s = m^d mod n";
            // 
            // n_box
            // 
            this.n_box.Location = new System.Drawing.Point(128, 177);
            this.n_box.Name = "n_box";
            this.n_box.ReadOnly = true;
            this.n_box.Size = new System.Drawing.Size(100, 22);
            this.n_box.TabIndex = 9;
            // 
            // keys
            // 
            this.keys.Location = new System.Drawing.Point(13, 114);
            this.keys.Name = "keys";
            this.keys.Size = new System.Drawing.Size(268, 30);
            this.keys.TabIndex = 10;
            this.keys.Text = "Get keys";
            this.keys.UseVisualStyleBackColor = true;
            this.keys.Click += new System.EventHandler(this.keys_Click);
            // 
            // msg_box
            // 
            this.msg_box.Location = new System.Drawing.Point(13, 281);
            this.msg_box.Name = "msg_box";
            this.msg_box.Size = new System.Drawing.Size(268, 22);
            this.msg_box.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "n = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "e = ";
            // 
            // e_box_1
            // 
            this.e_box_1.Location = new System.Drawing.Point(13, 177);
            this.e_box_1.Name = "e_box_1";
            this.e_box_1.ReadOnly = true;
            this.e_box_1.Size = new System.Drawing.Size(100, 22);
            this.e_box_1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "d = ";
            // 
            // d_box_1
            // 
            this.d_box_1.Location = new System.Drawing.Point(13, 231);
            this.d_box_1.Name = "d_box_1";
            this.d_box_1.ReadOnly = true;
            this.d_box_1.Size = new System.Drawing.Size(100, 22);
            this.d_box_1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "n = ";
            // 
            // n_box_1
            // 
            this.n_box_1.Location = new System.Drawing.Point(128, 231);
            this.n_box_1.Name = "n_box_1";
            this.n_box_1.ReadOnly = true;
            this.n_box_1.Size = new System.Drawing.Size(100, 22);
            this.n_box_1.TabIndex = 16;
            // 
            // crypt
            // 
            this.crypt.Location = new System.Drawing.Point(12, 344);
            this.crypt.Name = "crypt";
            this.crypt.Size = new System.Drawing.Size(269, 29);
            this.crypt.TabIndex = 20;
            this.crypt.Text = "Encrypt m(M) >>";
            this.crypt.UseVisualStyleBackColor = true;
            this.crypt.Click += new System.EventHandler(this.crypt_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "M";
            // 
            // Msg_box_1
            // 
            this.Msg_box_1.Location = new System.Drawing.Point(433, 74);
            this.Msg_box_1.Name = "Msg_box_1";
            this.Msg_box_1.ReadOnly = true;
            this.Msg_box_1.Size = new System.Drawing.Size(491, 22);
            this.Msg_box_1.TabIndex = 21;
            // 
            // check_eds_btn
            // 
            this.check_eds_btn.Location = new System.Drawing.Point(433, 201);
            this.check_eds_btn.Name = "check_eds_btn";
            this.check_eds_btn.Size = new System.Drawing.Size(156, 37);
            this.check_eds_btn.TabIndex = 23;
            this.check_eds_btn.Text = "Check EDS";
            this.check_eds_btn.UseVisualStyleBackColor = true;
            this.check_eds_btn.Click += new System.EventHandler(this.check_eds_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "m\' = h(M)";
            // 
            // m_sht_box
            // 
            this.m_sht_box.Location = new System.Drawing.Point(433, 271);
            this.m_sht_box.Name = "m_sht_box";
            this.m_sht_box.ReadOnly = true;
            this.m_sht_box.Size = new System.Drawing.Size(491, 22);
            this.m_sht_box.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(430, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "m = s^e mod n";
            // 
            // s_check_box
            // 
            this.s_check_box.Location = new System.Drawing.Point(433, 330);
            this.s_check_box.Name = "s_check_box";
            this.s_check_box.ReadOnly = true;
            this.s_check_box.Size = new System.Drawing.Size(491, 22);
            this.s_check_box.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 555);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.s_check_box);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.m_sht_box);
            this.Controls.Add(this.check_eds_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Msg_box_1);
            this.Controls.Add(this.crypt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.d_box_1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.n_box_1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.e_box_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.msg_box);
            this.Controls.Add(this.keys);
            this.Controls.Add(this.n_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.s_A_box);
            this.Controls.Add(this.hash_box);
            this.Controls.Add(this.d_box);
            this.Controls.Add(this.e_box);
            this.Controls.Add(this.q_box);
            this.Controls.Add(this.p_box);
            this.Controls.Add(this.hash_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hash_btn;
        private System.Windows.Forms.TextBox p_box;
        private System.Windows.Forms.TextBox q_box;
        private System.Windows.Forms.TextBox e_box;
        private System.Windows.Forms.TextBox d_box;
        private System.Windows.Forms.TextBox hash_box;
        private System.Windows.Forms.TextBox s_A_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox n_box;
        private System.Windows.Forms.Button keys;
        private System.Windows.Forms.TextBox msg_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox e_box_1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox d_box_1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox n_box_1;
        private System.Windows.Forms.Button crypt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Msg_box_1;
        private System.Windows.Forms.Button check_eds_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox m_sht_box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox s_check_box;
    }
}

