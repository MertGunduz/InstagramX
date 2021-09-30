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
using InstagramX.Properties;

namespace InstagramX
{
    public partial class InstagramX_DatabaseMenuUserControl : UserControl
    {
        SqlConnection MSSQLConnection = new SqlConnection(Database.DatabaseString);

        public InstagramX_DatabaseMenuUserControl()
        {
            InitializeComponent();
        }

        private void InstagramX_DatabaseMenuUserControl_Load(object sender, EventArgs e)
        {
            // Connection Set To Open
            MSSQLConnection.Open();

            // T-SQL Command (Lists All The Data)
            var selectCommand = new SqlCommand("Select Account_ID As 'ID', Account_Follower As 'FOLLOWERS', Account_Following As 'FOLLOWING', Account_Posts As 'POSTS', Account_CreationDate As 'CREATED IN', Account_InstagramUsername As 'INSTAGRAM USERNAME', Account_InstagramPassword As 'INSTAGRAM PASSWORD', Account_Email As 'EMAIL', Account_EmailPassword As 'EMAIL PASSWORD', Account_UserGender As 'Gender' From InstagramX_AccountsTable", MSSQLConnection);
            
            // SQL Data Adapter Linked To SelectCommand
            var sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = selectCommand;
            
            // Datatable Filled
            var dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            InstagramX_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            InstagramX_DataGridView.DataSource = dataTable;
            
            // Connection Set To Closed
            MSSQLConnection.Close();
        }

        // CreateAccountsButton (Hover-NonHover)
        private void CreateAccounts_Button_MouseEnter(object sender, EventArgs e)
        {
            CreateAccounts_Button.Image = Resources.InstagramX_HoveredCreateAccountsIcon;
            CreateAccounts_Button.ForeColor = Color.FromArgb(19, 165, 254);
        }

        private void CreateAccounts_Button_MouseLeave(object sender, EventArgs e)
        {
            CreateAccounts_Button.Image = Resources.InstagramX_CreateAccountsIcon;
            CreateAccounts_Button.ForeColor = Color.FromArgb(4, 150, 239);
        }

        private void CreateAccountsAccountQty_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (CreateAccountsAccountQty_TextBox.Text == "  Account Qty:")
            {
                CreateAccountsAccountQty_TextBox.Clear();
            }
        }

        private void CreateAccountsSpeed_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (CreateAccountsSpeed_TextBox.Text == "  Speed (1000-3000):")
            {
                CreateAccountsSpeed_TextBox.Clear();
            }
        }
    }
}