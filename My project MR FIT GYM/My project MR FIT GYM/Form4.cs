using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace My_project_MR_FIT_GYM
{
    public partial class Form4 : Form
    {
        public static string filedata = AppDomain.CurrentDomain.BaseDirectory + @"\Gymfile.txt";
        public Form4()
        {
            InitializeComponent();
            PN_comboBox.Text = Form3.combo1;
            PA_comboBox.Text = Form3.combo2;
            foreach (string item in Form3.listDrop)
            {
                PN_comboBox.Items.Add(item);
            }
            foreach (string item in Form3.listDrop2)
            {
                PA_comboBox.Items.Add(item);
            }

        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            string M_Name = PN_comboBox.Text;
            string Date = dateTimePicker1.Text;
            string M_AM = PA_comboBox.Text;

            if (string.IsNullOrWhiteSpace(M_Name) || string.IsNullOrWhiteSpace(Date) || string.IsNullOrWhiteSpace(M_AM))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            foreach (ListViewItem existingItem in listView1.Items)
            {
                if (existingItem.SubItems[0].Text == M_Name && existingItem.SubItems[1].Text == Date && existingItem.SubItems[2].Text == M_AM)
                {
                    MessageBox.Show("Already paid for this month");
                    PN_comboBox.Text = string.Empty;
                    dateTimePicker1.Text = string.Empty;
                    PA_comboBox.Text = string.Empty;
                    return;
                }
            }
            if (PN_comboBox.Text != null && dateTimePicker1.Text != null && PA_comboBox.Text != null )
            {

                StreamWriter sw = new StreamWriter(filedata, append: true);
                string newdata = PN_comboBox.Text + "," + dateTimePicker1.Text + "," + PA_comboBox.Text + ",";
                sw.WriteLine(newdata);
                sw.Close();

            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }

            ListViewItem item = new ListViewItem(M_Name);
            listView1.Items.Add(item);
            item.SubItems.Add(Date);
            item.SubItems.Add(M_AM);

            PN_comboBox.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            PA_comboBox.Text = string.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);

                PN_comboBox.Text = string.Empty;
                dateTimePicker1.Text = string.Empty;
                PA_comboBox.Text = string.Empty;
            }

        }

      

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                PN_comboBox.Text = listView1.SelectedItems[0].Text;
                dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[1].Text;
                PA_comboBox.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }


        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].Text = PN_comboBox.Text;
                listView1.SelectedItems[0].SubItems[1].Text = dateTimePicker1.Text;
                listView1.SelectedItems[0].SubItems[2].Text = PA_comboBox.Text;

                listView1.SelectedItems.Clear();
                PN_comboBox.Text = string.Empty;
                dateTimePicker1.Text = string.Empty;
                PA_comboBox.Text = string.Empty;

            }


        }

        private void Back1_button_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            Hide();

        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            string searchText = Search_textBox.Text.ToLower();
            bool found = false;

            if (listView1.Items.Count > 0)
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Text.ToLower().Contains(searchText))
                    {
                        listView1.Items.Remove(item);
                        listView1.Items.Insert(0, item);
                        listView1.Items[0].EnsureVisible();
                        found = true;
                        break;

                    }
                }
                if (!found)
                {
                    MessageBox.Show("No matching record found");
                }

            }
            else
            {
                MessageBox.Show("The list is empty");
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            if (File.Exists(filedata))
            {
                using (StreamReader sr = new StreamReader(filedata))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        ListViewItem item = new ListViewItem(data[0]);
                        item.SubItems.Add(data[1]);
                        item.SubItems.Add(data[2]);
                        item.SubItems.Add(data[3]);
                        item.SubItems.Add(data[4]);
                        listView1.Items.Add(item);

                    }
                }
            }
        }
    }
}
