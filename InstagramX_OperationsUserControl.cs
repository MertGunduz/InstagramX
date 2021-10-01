using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InstagramX
{
    public partial class InstagramX_OperationsUserControl : UserControl
    {
        SqlConnection MSSQLConnection = new SqlConnection(Database.DatabaseString);

        public InstagramX_OperationsUserControl()
        {
            InitializeComponent();
        }

        private void InstagramX_OperationsUserControl_Load(object sender, EventArgs e)
        {
            // Connection Open
            MSSQLConnection.Open();

            // T-SQL Command (Lists All The Data)
            var selectCommand = new SqlCommand("Select Operation_ID As 'ID', Operation_Type As 'Type', Operation_Quantity As 'Quantity', Operation_Date As 'Date', Operation_Account As 'Account' From InstagramX_OperationsTable", MSSQLConnection);

            // SQL Data Adapter Linked To SelectCommand
            var sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = selectCommand;

            // Datatable Filled
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            InstagramX_DataGridView.DataSource = dataTable;

            // Connection Set To Closed
            MSSQLConnection.Close();
        }
    }
}
