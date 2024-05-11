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

namespace My_project_MR_FIT_GYM
{
    public partial class Form3 : Form
    {
        public static string filedata = AppDomain.CurrentDomain.BaseDirectory + @"\Gymfile.txt";
        public static string combo1 = "";
        public static string combo2 = "";
        public static List<string> listDrop = new List<string>();
        public static List<string> listDrop2 = new List<string>();

        public Form3()
        {
            InitializeComponent();
        }
        


        private void Add_button_Click(object sender, EventArgs e)
        {
            combo1 = N_textBox.Text;
            combo2 = Amount_textBox.Text;
            string Member_Name = N_textBox.Text;
            if (!listDrop.Contains(Member_Name))
            {
                listDrop.Add(Member_Name);
            }

            string Member_Phone = PH_textBox.Text;
            string Member_Age = Age_textBox.Text;
            string Member_Gender = G_comboBox.Text;
            string Member_Amount = Amount_textBox.Text;
            if (!listDrop2.Contains(Member_Amount))
            {
                listDrop2.Add(Member_Amount);
            }

            ListViewItem item = new ListViewItem(Member_Name);
            listView1.Items.Add(item);
            item.SubItems.Add(Member_Phone);
            item.SubItems.Add(Member_Age);
            item.SubItems.Add(Member_Gender);
            item.SubItems.Add(Member_Amount);


            if (N_textBox.Text != null && PH_textBox.Text != null && Age_textBox.Text != null && G_comboBox.Text != null && Amount_textBox.Text != null)
            {

                StreamWriter sw = new StreamWriter(filedata, append: true);
                string newdata = N_textBox.Text + "," + PH_textBox.Text + "," + Age_textBox.Text + "," + G_comboBox.Text;
                sw.WriteLine(newdata);
                sw.Close();

            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }



            N_textBox.Clear();
            PH_textBox.Clear();
            Age_textBox.Clear();
            G_comboBox.Text = string.Empty;
            Amount_textBox.Clear();

        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);

                N_textBox.Clear();
                PH_textBox.Clear();
                Age_textBox.Clear();
                G_comboBox.Text = string.Empty;
                Amount_textBox.Clear();

            }

        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].Text = N_textBox.Text;
                listView1.SelectedItems[0].SubItems[1].Text = PH_textBox.Text;
                listView1.SelectedItems[0].SubItems[2].Text = Age_textBox.Text;
                listView1.SelectedItems[0].SubItems[3].Text = G_comboBox.Text;
                listView1.SelectedItems[0].SubItems[4].Text = Amount_textBox.Text;
                listView1.SelectedItems.Clear();
                N_textBox.Clear();
                PH_textBox.Clear();
                Age_textBox.Clear();
                G_comboBox.Text = string.Empty;
                Amount_textBox.Clear();


            }

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Hide();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                N_textBox.Text = listView1.SelectedItems[0].Text;
                PH_textBox.Text = listView1.SelectedItems[0].SubItems[1].Text;
                Age_textBox.Text = listView1.SelectedItems[0].SubItems[2].Text;
                G_comboBox.Text = listView1.SelectedItems[0].SubItems[3].Text;
                Amount_textBox.Text = listView1.SelectedItems[0].SubItems[4].Text;

            }

        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            string searchText = Search_textBox.Text.ToLower();
            bool found = false;

            if (listView1.Items.Count > 0)
            {
                foreach(ListViewItem item in listView1.Items)
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
            if(File.Exists(filedata))
            {
                using(StreamReader sr = new StreamReader(filedata))
                {
                    string line;
                    while((line = sr.ReadLine()) != null)
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
