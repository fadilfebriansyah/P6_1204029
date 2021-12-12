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

namespace P6_2_1204029
{
    public partial class Form1 : Form
    {
        public DataSet CreateProdiDataSet()
        {
            DataSet myDataSet = new DataSet();
            try
            {
                
                SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-N3JOE60\FADILDB;Initial Catalog=P6_1204029;Integrated Security=True");
                myConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = myConnection;
                command.CommandText = "select * from msprodi";
                command.CommandType = CommandType.Text;

                SqlDataAdapter mydataadapter = new SqlDataAdapter();
                mydataadapter.SelectCommand = command;
                mydataadapter.TableMappings.Add("Table", "Prodi");

                mydataadapter.Fill(myDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return myDataSet;
        
        }
        

        private void RefreshDataset()
        {
            dsProdi = CreateProdiDataSet();
            dgProdi.DataSource = dsProdi.Tables["Prodi"];
        }
        public Form1()
        {
            InitializeComponent();
        }

        private DataSet dsProdi;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataset();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-N3JOE60\FADILDB;Initial Catalog=P6_1204029;Integrated Security=True");

           
            myConnection.Open();

            SqlDataAdapter myAdapter = new SqlDataAdapter("select * from msprodi", myConnection);
            SqlCommandBuilder myCmdBuilder = new SqlCommandBuilder(myAdapter);

            myAdapter.InsertCommand = myCmdBuilder.GetInsertCommand();
            myAdapter.DeleteCommand = myCmdBuilder.GetDeleteCommand();
            myAdapter.UpdateCommand = myCmdBuilder.GetUpdateCommand();


            SqlTransaction myTransaction;
            myTransaction = myConnection.BeginTransaction();
            myAdapter.InsertCommand.Transaction = myTransaction;
            myAdapter.DeleteCommand.Transaction = myTransaction;
            myAdapter.UpdateCommand.Transaction = myTransaction;

            try
            {
                int rowsupdate = myAdapter.Update(dsProdi, "Prodi");
                myTransaction.Commit();
                MessageBox.Show(rowsupdate.ToString() + " baris diperbarui", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshDataset();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update: " + ex.Message);
                myTransaction.Rollback();
            }
        }
    }
}
