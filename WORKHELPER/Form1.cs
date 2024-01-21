using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.Media;

namespace WORKHELPER
{
    public partial class Form1 : Form
    {
        public void addata()
        {
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from dbo.datanote", conn);
            adapter.Fill(data);
            dataGridView1.DataSource = data;
        }
        public Form1()
        {
            InitializeComponent();
            /*try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

                if (key.GetValue("WorkHelper").ToString() == "\"" + Application.ExecutablePath + "\"")
                {
                    // Eğer regeditte varsa, checkbox ı işaretle
                    checkBox1.Checked = true;
                }
            }
            catch
            {

            }*/
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=workhelper;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'workhelperDataSet1.datanote' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.datanoteTableAdapter.Fill(this.workhelperDataSet1.datanote);
            timer1.Start();
            addata();
        }
        int say = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //datenow.Text = DateTime.Now.ToLocalTime().ToString();
            datenow.Text = DateTime.Now.ToShortDateString();
            datenowtime.Text = DateTime.Now.ToShortTimeString();
            say++;
            if (say == 50)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[2].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[3].Value.ToString()=="1")
                        {
                            if (datenow.Text == dataGridView1.Rows[i].Cells[1].Value.ToString() && datenowtime.Text == dataGridView1.Rows[i].Cells[2].Value.ToString())
                            {

                                SoundPlayer simpleSound = new SoundPlayer(Environment.CurrentDirectory + @"\alarms.wav");
                                simpleSound.Play();
                                MessageBox.Show(dataGridView1.Rows[i].Cells[4].Value.ToString());
                            }
                        }
                    }
                    say = 0;
                }
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            string contcheck = "0";
            if(alarmy.Checked)
            {
                contcheck = "1";
            }
            else
            {
                contcheck = "0";
            }
            conn.Open();
            SqlCommand comm = new SqlCommand("insert into dbo.datanote(date_note,time_note,alarmyn,note) values('"+dateTimePicker1.Text.ToString()+"','"+timebox.Text.ToString()+"','"+contcheck+"','"+notebox.Text.ToString()+"')",conn);
            comm.ExecuteNonQuery();
            conn.Close();
            addata();
            timer1.Start();

        }
        void dataclear(int number)
        {
            string sql = "DELETE FROM dbo.datanote WHERE id=@id";
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@id", number);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        private void clearbutton_Click(object sender, EventArgs e)
        { 
           foreach (DataGridViewRow drow in dataGridView1.SelectedRows) 
           {
              int number = Convert.ToInt32(drow.Cells[0].Value);
              dataclear(number);

           }
            addata();
            timer1.Start();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hideToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue("WorkHelper", "\"" + Application.ExecutablePath + "\"");
                MessageBox.Show("Uygulama Otomatik Olarak Başlatılacaktır.");
            }
            else
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue("WorkHelper");
                MessageBox.Show("Uygulamayı Manual Olarak Başlatmanız Gerekmektedir.");
            }
        }
    }
}
