using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace P6_3_1204029
{
    public partial class Form1 : Form
    {
        //string url = "Data Source=DESKTOP-N3JOE60\FADILDB;Initial Catalog=P6_1204029;Integrated Security=True";


        DataTable dataprodi = new DataTable();
        private void filldataset()
        {
            using (SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-N3JOE60\FADILDB;Initial Catalog=P6_1204029;Integrated Security=True"))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT id_prodi, singkatan FROM msprodi", sqlconnection);
                sqlconnection.Open();
                SqlDataAdapter sqlReader = new SqlDataAdapter(sqlCmd);
                sqlReader.Fill(dataprodi);

                //while (sqlReader.Read())
                //{
                //    comboBox1.Items.Add(sqlReader["singkatan"].ToString());
                //    comboBox1.Items.Add(new List)
                //}
            }
            comboBox1.DataSource = dataprodi;
            comboBox1.DisplayMember = "singkatan";
            comboBox1.ValueMember = "id_prodi";
        }

        public Form1()
        {
            InitializeComponent();
            filldataset();
        }

        private void InsertDB(string cmd)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N3JOE60\FADILDB;Initial Catalog=P6_1204029;Integrated Security=True");
                conn.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = cmd;
                command.ExecuteNonQuery();
                MessageBox.Show("Data has been Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string jk = "";
            if (pr.Checked) { jk = pr.Text; } else if (ll.Checked) { jk = ll.Text; }
            string sDate = kalender.SelectionStart.ToString("yyyy\\/MM\\/dd");
            string alamat = tbalamat.Text;
            string cmdsave = "insert into msmhs values('" + tbnpm.Text + "','" + tbnama.Text + "','" + sDate + "','" + jk + "','" + alamat + "','" + tbno.Text + "','" + comboBox1.SelectedValue + "')";
            InsertDB(cmdsave);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbnama.Text = null;
            tbnpm.Text = null;
            tbno.Text = null;
            tbalamat.Text = null;
            comboBox1.SelectedIndex = 0;
            pr.Checked = false;
            ll.Checked = false;
        }
        private void seterror(Control control)
        {
            epWar.SetError(control, "Harus diisi");
        }

        private void remerror()
        {
            epWar.Clear();
        }

        private void tbnpm_Leave(object sender, EventArgs e)
        {
            if (tbnpm.Text == "")
            {
                seterror(tbnpm);
            }
            else
            {
                remerror();
            }
        }

        private void tbnama_Leave(object sender, EventArgs e)
        {
            if (tbnama.Text == "")
            {
                seterror(tbnama);
            }
            else
            {
                remerror();
            }
        }

        private void tbalamat_Leave(object sender, EventArgs e)
        {
            if (tbalamat.Text == "")
            {
                seterror(tbalamat);
            }
            else
            {
                remerror();
            }
        }

        private void tbno_Leave(object sender, EventArgs e)
        {
            if (tbno.Text == "")
            {
                seterror(tbno);
            }
            else
            {
                remerror();
            }
        }
    }
}
