using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using ICS_Lab_4_dll;

namespace ICS_Lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hash_box.Text = MyEDS.GetHash(msg_box.Text);
        }

        private void keys_Click(object sender, EventArgs e)
        {
            d_box.Text = MyRSA.d_find(Convert.ToInt32(e_box.Text), MyRSA.euler_f(Convert.ToInt32(p_box.Text), Convert.ToInt32(q_box.Text))).ToString();
            n_box.Text = MyRSA.n_module(Convert.ToInt32(p_box.Text), Convert.ToInt32(q_box.Text)).ToString();
            e_box_1.Text = e_box.Text;
            d_box_1.Text = d_box.Text;
            n_box_1.Text = n_box.Text;
        }

        private void crypt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hash_box.Text.Length; i++)
            {
                //MessageBox.Show(MyRSA.RSA_encrypt((int)hash_box.Text[i], Convert.ToInt32(d_box.Text), Convert.ToInt32(n_box.Text)).ToString());
                s_A_box.Text += MyRSA.RSA_encrypt((int)hash_box.Text[i], Convert.ToInt32(d_box.Text), Convert.ToInt32(n_box.Text));
                s_A_box.Text += ' ';
                Msg_box_1.Text = msg_box.Text;
                check_eds_btn.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            check_eds_btn.Enabled = false;
        }

        private void check_eds_btn_Click(object sender, EventArgs e)
        {
            m_sht_box.Text = MyEDS.GetHash(Msg_box_1.Text);
            s_check_box.Text =  MyEDS.get_s(s_A_box.Text, Convert.ToInt32(e_box.Text), Convert.ToInt32(n_box.Text));
            if(m_sht_box.Text == s_check_box.Text)
            {
                MessageBox.Show("The digital signature is confirmed!");
            }
            else
            {
                MessageBox.Show("The message is corrupted!");
            }
        }
    }

    public static class MyEDS
    {
        public static string GetHash(string input)
        {
            var check_md5 = MD5.Create();
            var hash_m = check_md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash_m);
        }

        public static string crypt_hash(char input, int d, int n)
        {
            return MyRSA.RSA_encrypt((int)input, d, n).ToString();
        }

        public static string get_s(string input, int e, int n)
        {
            string put_here = "";
            string decrypted = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    put_here += input[i];
                }
                else
                {
                    decrypted += MyRSA.RSA_decrypt(Convert.ToInt32(put_here), e, n).ToString();
                    put_here = "";
                }
            }
            return decrypted;
        }
    }
}
