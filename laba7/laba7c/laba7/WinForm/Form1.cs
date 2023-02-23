using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        WcfService.ServiceClient client;
        public Form1()
        {
            InitializeComponent();

            client = new WcfService.ServiceClient();
        }

        private void list()
        {
            listPhones.Text = "";
            WcfService.Person[] list = client.GetDict();
            foreach (var person in list)
            {
                listPhones.Text += $"{person.Name} - {person.Phone}\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int test;
            if (addName.Text.Replace(" ", "") == "" || 
                addPhone.Text.Replace(" ", "") == "" ||
                !int.TryParse(addPhone.Text, out test))
            {
                MessageBox.Show("Неверные данные");
            }
            else
            {
                client.AddDict(new WcfService.Person
                {
                    Name = addName.Text,
                    Phone = addPhone.Text
                });
                MessageBox.Show("Добавлено");
                list();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int test;
            if (updateName.Text.Replace(" ", "") == "" || 
                updatePhone.Text.Replace(" ", "") == "" ||
                !int.TryParse(updatePhone.Text, out test))
            {
                MessageBox.Show("Неверные данные");
            }
            else
            {
                client.UpdDict(new WcfService.Person
                {
                    Name = updateName.Text,
                    Phone = updatePhone.Text
                });
                MessageBox.Show("Обновлено");
                list();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int test;
            if (deletePhone.Text.Replace(" ", "") == "" ||
                !int.TryParse(deletePhone.Text, out test))
            {
                MessageBox.Show("Неверные данные");
            }
            else
            {
                client.DelDict(new WcfService.Person
                {
                    Phone = deletePhone.Text
                });
                MessageBox.Show("Удалено");
                list();
            }
        }
    }
}
