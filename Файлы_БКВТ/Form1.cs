using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Файлы_БКВТ
{
    public partial class Form1 : Form
    {
        string папка_Где = @"\\Serverhead\ttn_bkvt";
        string папка_Куда = @"\\Serverhead\ttn_bkvt";


        public Form1()
        {
            InitializeComponent();
        }

             

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Выполнить_Click(object sender, EventArgs e)
        {
            Обработка();
        }

        private void Обработка()
        {
            if (System.IO.Directory.Exists(папка_Где))
            {
                string[] файлы_все = System.IO.Directory.GetFiles(папка_Где);
                int файлов_колво = файлы_все.Count();
                progressBar1.Maximum = файлов_колво;
                progressBar1.Value = 0;
                label_Всего.Text = файлов_колво.ToString();

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in файлы_все)
                {
                    // T_100095087_590959404_20170501_0035846.DBF

                    string файл_имя = System.IO.Path.GetFileName(s);
                    string[]  файл_разделить = файл_имя.Split('_');
                    string папка_дата = файл_разделить[3];
                    string файл_имя_док = файл_разделить[4];
                    string папка_куда_дата = System.IO.Path.Combine(папка_Куда,  папка_дата); 

                    if (!System.IO.Directory.Exists(папка_куда_дата))
                    {
                        System.IO.Directory.CreateDirectory(папка_куда_дата);
                    }

                    string файл_исходный = System.IO.Path.Combine(папка_Где, файл_имя);
                    string файл_целевой = System.IO.Path.Combine(папка_куда_дата, файл_имя_док);

                    progressBar1.Value ++;
                    label_Обработано.Text = progressBar1.Value.ToString();

                    try
                    {
                        //System.IO.File.Copy(файл_исходный, файл_целевой, true);

                        System.IO.File.Delete(файл_целевой);
                        System.IO.File.Move(файл_исходный, файл_целевой);


                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show("Файл " + файл_исходный + " копируется в " + файл_целевой + "\n\n" + ee);
                        // throw;
                    }

                }
            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox_Где.Text = папка_Где;
        
        }

        private void textBox_Где_TextChanged(object sender, EventArgs e)
        {
            папка_Где = this.textBox_Где.Text;
        }

        private void textBox_Куда_TextChanged(object sender, EventArgs e)
        {
            папка_Куда = this.textBox_Куда.Text;
        }
    }
}
