using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Nikol\\OneDrive\\Рабочий стол\\Практика\\День28\\Day23\\RepView\\bin\\Debug\\DB28.mdf\";Integrated Security=True;Connect Timeout=30";
            string sqlQuery = "SELECT * FROM Consultation";

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                {

                    adapter.Fill(dt);
                }
            }
            reportViewer1.LocalReport.ReportEmbeddedResource = "RepView.Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Nikol\\OneDrive\\Рабочий стол\\Практика\\День28\\Day23\\RepView\\bin\\Debug\\DB28.mdf\";Integrated Security=True;Connect Timeout=30";
            string sqlQuery = "SELECT * FROM Student";

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                {

                    adapter.Fill(dt);
                }
            }
            reportViewer1.LocalReport.ReportEmbeddedResource = "RepView.Report2.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));

            this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Nikol\\OneDrive\\Рабочий стол\\Практика\\День28\\Day23\\RepView\\bin\\Debug\\DB28.mdf\";Integrated Security=True;Connect Timeout=30";
            string sqlQuery = "SELECT * FROM Teacher";

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                {

                    adapter.Fill(dt);
                }
            }
            reportViewer1.LocalReport.ReportEmbeddedResource = "RepView.Report3.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));

            this.reportViewer1.RefreshReport();
        }
    }
}
