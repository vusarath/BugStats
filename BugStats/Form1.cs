using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Nara
{
    public partial class BugStats : Form
    {
        string filePath = @"C:\Users\sarath\Desktop\Bugs.xls";
        RichTextBox box = new RichTextBox();
        TextBox tb1 = new TextBox();
        TextBox tb2 = new TextBox();
        TextBox tb3 = new TextBox();
        TextBox tb4 = new TextBox();
        TextBox tb5 = new TextBox();
        TextBox tb6 = new TextBox();
        TextBox tb7 = new TextBox();
        TextBox tb8 = new TextBox();
        TextBox tb9 = new TextBox();
        TextBox tb10 = new TextBox();
        TextBox tb11 = new TextBox();
        public BugStats()
        {
            InitializeComponent();
        }

        private void InitCOnnectionString()
        {
            connectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;ReadOnly=False;$HDR=Yes;IMEX=2';";
            var server = "localhost";
            var database = "db1";
            var uid = "root";
            var password = "password123";
            dbConnectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(dbConnectionString);
            
            ReadShets();
        }

        private void ReadShets()
        {
            //string connstring = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=NO;IMEX=1';";

            using (OleDbConnection Connection = new OleDbConnection(connectionString))
            {
                Connection.Open();
                DataTable sheetsName = Connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,new object[] { null, null, null, "TABLE" });
                wsList = sheetsName.Rows.OfType<DataRow>().Where(ex =>ex["TABLE_NAME"].ToString().EndsWith("$")).Select(ex =>ex["TABLE_NAME"].ToString()).ToList();
                if (wsList.Count > 0)
                {
                    listOfSheets.Items.Clear();
                    listOfSheets.Items.AddRange(wsList.ToArray());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FetchData(GetSNO());
        }

        private double GetSNO()
        {
            return double.Parse(tbSno.Text.ToString());
        }

        private void WritetoXLS()
        {
           
           // string connectionString = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" + filePath + ";Extended Properties=Excel 8.0;";
            using (OleDbConnection Connection = new OleDbConnection(connectionString))
            {
                Connection.Open();
                using (OleDbCommand command = new OleDbCommand())
                {

                    command.Connection = Connection;
                    DataTable tables = command.Connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    if (!tables.Select().ToList().Exists(ex => ex["TABLE_NAME"].ToString() == "EmpTable"))
                    {
                        command.CommandText = "CREATE TABLE [EmpTable](EmpFirstName Char(100), EmpLastName char(100), EmpDept char(250))";
                        command.ExecuteNonQuery();
                    }
                }

                //Add values to the table (EMPTable) in the Worksheet 

                using (OleDbCommand command = new OleDbCommand())
                {

                    command.Connection = Connection;
                    command.CommandText = "INSERT INTO [EmpTable](EmpFirstName ,EmpLastName ,EmpDept ) VALUES('Karthik','Anbu','karthik.Anbu@xyz.com')";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO [EmpTable](EmpFirstName ,EmpLastName ,EmpDept ) VALUES('Arun','Kumar','Arun.Kumar@xyz.com')";
                    command.ExecuteNonQuery();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTable = listOfSheets.SelectedItem.ToString();
            tbSno.Text = "";
            colNames.Clear();
            GenerateUI();
            ReSetUI();
        }
        private void GenerateUI()
        {
            RefactorUI();
           // string connstring = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1';";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                //Get All Sheets Name
                DataTable sheetsName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                string sql = string.Format("SELECT * FROM [{0}] ", selectedTable);
                OleDbDataAdapter ada = new OleDbDataAdapter(sql, connectionString);
                DataSet set = new DataSet();
                ada.Fill(set);
                foreach (DataColumn item in set.Tables[0].Columns)
                {
                    AddRow(item.ColumnName, "");
                    colNames.Add(item.ColumnName);
                }
                
            }
        }

        private void RefactorUI()
        {
            this.tableLayoutPanel1.Controls.Clear();
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.Sheet, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listOfSheets, 1, 0);
            //this.tableLayoutPanel1.Controls.Add(this.btnFetch, 0, 14);
        }
        List<String> colNames = new List<string>();
        private void AddRow(String col1, String col2)
        {
            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lbl.Text = col1;
            this.tableLayoutPanel1.Controls.Add(lbl, 0, colNames.Count + 2);
            if ((colNames.Count == 0)&&(col1.ToLower().Contains("no")))
            {
                tbSno.Visible = true;
                this.tableLayoutPanel1.Controls.Add(tbSno, 1, colNames.Count + 2);
            }
            if (col1.ToLower().Contains("status"))
            {
                tbStatus.Visible = true;
                this.tableLayoutPanel1.Controls.Add(tbStatus, 1, colNames.Count + 2);
            }
            else if (col1.ToLower().Contains("description"))
            {
                box.Text = "";
                box.Dock = DockStyle.Fill;
                this.tableLayoutPanel1.Controls.Add(box, 1, colNames.Count + 2);
            }
            else if (colNames.Count > 0)
            {
                this.tableLayoutPanel1.Controls.Add(listOftextBox[colNames.Count - 1], 1, colNames.Count + 2);
            }
            
        }

        private void FetchData(double SNO)
        {
            //string connstring = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1';";
            lblStatus.Text = "";
            tbStatus.Text = "";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                //Get All Sheets Name
                DataTable sheetsName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                string sql = string.Format("SELECT * FROM [{0}] ", selectedTable);
                OleDbDataAdapter ada = new OleDbDataAdapter(sql, connectionString);
                DataSet set = new DataSet();
                ada.Fill(set);
                DataTable tables= set.Tables[0];
                LastRow = tables.Rows.Count;
                var table = set.Tables[0].AsEnumerable().Where(r => r.Field<double>(colNames[0]) == SNO).First();
                FillCOl(table.ItemArray);
                //var table = set.Tables[0].AsEnumerable().Where(r => r.Field<String>("Mode") == "E").Select(ex => ex.Field<String>("Status")).First();
                
            }
        }

        private void FillCOl(object[] p)
        {
            //RefactorUI();
            for (int i = 0; i < colNames.Count; i++)
			{
                if (colNames[i].ToLower().Contains("no"))
                {
                    tbSno.Visible = true;
                    tbSno.Text = p[i].ToString();
                }
                else if (colNames[i].ToLower().Contains("status"))
                {
                    tbStatus.Visible = true;
                    tbStatus.Text = p[i].ToString();
                }
                else if (colNames[i].ToLower().Contains("description"))
                {
                 
                    box.Text = p[i].ToString();
                    box.ReadOnly = true;
                    box.Dock = DockStyle.Fill;
                }
                else if (colNames[i].ToLower().Contains("remarks"))
                {
                    var tb = listOftextBox[i - 1];
                    tb.Multiline = true;
                    tb.WordWrap = false;
                    tb.Dock = DockStyle.Fill;
                    tb.Text = p[i].ToString();
                }
                else
                {
                    var tb = listOftextBox[i - 1];
                    tb.Text = p[i].ToString();
                }
            }
        }

        public string selectedTable { get; set; }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenCount_Click(object sender, EventArgs e)
        {
            int nCount = 0;
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                foreach (var item in wsList)
                {
                    OleDbCommand select = new OleDbCommand();
                    select.Connection = conn;
                    select.CommandText = String.Format("Select * From [{0}] Where Status IS NULL or Status = 'ReOpen'AND(Sno IS NOT NULL)", item);
                    OleDbDataReader reader = select.ExecuteReader();
                    while (reader.Read())
                    {
                        nCount++;
                        
                    }
                   
                }
                conn.Close();
                lblStatus.Text = nCount.ToString();
            }
            
        }
        private void Update_Click(object sender, EventArgs e)
        {
            using (OleDbConnection Connection = new OleDbConnection(connectionString))
            {
                Connection.Open();
                using (OleDbCommand command = new OleDbCommand())
                {
                    command.Connection = Connection;
                    command.CommandText = String.Format("UPDATE [{0}] SET [Status] ='{1}' WHERE [{2}]={3}", selectedTable, tbStatus.Text.ToString(),colNames[0],tbSno.Text.ToString());
                    command.ExecuteScalar();
                    lblStatus.Text = "Sheet Updated";
                    ReSetUI();
                }
            }
        }

        private void ReSetUI()
        {
            tbSno.Text = "";
            tbStatus.Text = "";
            box.Text = "";
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tb4.Text = "";
            tb5.Text = "";
            tb6.Text = "";
            tb7.Text = "";
            tb8.Text = "";
            tb9.Text = "";
            tb10.Text = "";
            tb11.Text = "";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            connectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;ReadOnly=False;$HDR=Yes;IMEX=2';";
        }

        public string connectionString { get; set; }
        List<TextBox> listOftextBox = new List<TextBox>();
        private void Form1_Load(object sender, EventArgs e)
        {
            var showVal = false;
            ToggleBtns(showVal);
            tb1 = new TextBox();
            listOftextBox.Add(tb1);
            tb2 = new TextBox();
            listOftextBox.Add(tb2);
            tb3 = new TextBox();
            listOftextBox.Add(tb3);
            tb4 = new TextBox();
            listOftextBox.Add(tb4);
            tb5 = new TextBox();
            listOftextBox.Add(tb5);
            tb6 = new TextBox();
            listOftextBox.Add(tb6);
            tb7 = new TextBox();
            listOftextBox.Add(tb7);
            tb8 = new TextBox();
            listOftextBox.Add(tb8);
            tb9 = new TextBox();
            listOftextBox.Add(tb9);
            tb10 = new TextBox();
            listOftextBox.Add(tb10);
            tb11 = new TextBox();
            listOftextBox.Add(tb11);
        }

        private void ToggleBtns(bool showVal)
        {
            btnOpenCount.Enabled = showVal;
            btnFetch.Enabled = showVal;
            btnUpdate.Enabled = showVal;
            btnFetchNext.Enabled = showVal;
            btnFetchPrevious.Enabled = showVal;
        }

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.DefaultExt = "xls";
            fd.Filter = "ExcelFiles|*.xls";
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = fd.FileName;
                InitCOnnectionString();
                ToggleBtns(true);
                //InsertIntoMariaDB();
            }
        }

        private void Inset_Click(object sender, EventArgs e)
        {
            using (OleDbConnection Connection = new OleDbConnection(connectionString))
            {
                Connection.Open();
                DataTable sheetsName = Connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                string sql = string.Format("SELECT * FROM [{0}] ", selectedTable);
                OleDbDataAdapter ada = new OleDbDataAdapter(sql, connectionString);
                DataSet set = new DataSet();
                ada.Fill(set);
                DataTable tables = set.Tables[0];
                
                using (OleDbCommand command = new OleDbCommand())
                {

                    var valuesString =  GetCurrentValues();
                    var colString = GetColumnsString();
                    command.Connection = Connection;
                   // command.CommandText = String.Format("INSERT INTO [{0}](["+colNames[1] +"],[Status]) VALUES('ES','Fixed')", selectedTable);//, colString, valuesString);
                   command.CommandText = String.Format("INSERT INTO [{0}]({1} ) VALUES({2})", selectedTable, colString, valuesString); 
                    // add named parameters
                    
                    command.ExecuteNonQuery();
                    lblStatus.Text = "Insert Sucsess";
                    ReSetUI();
                }
            }
        }

        private string GetColumnsString()
        {
            var colString = "";
            foreach (var item in colNames)
            {
                if (colString.Length > 0)
                {
                    colString += String.Format(",[{0}]", item);
                }
                else
                {
                    colString = String.Format("[{0}]", item);
                }
            }
            return colString;
        }

        private String GetCurrentValues()
        {

            var retVal = "";

            for (int i = 0; i < colNames.Count; i++)
            {
                if (colNames[i].ToLower().Contains("no"))
                {
                    retVal = (LastRow++).ToString();        
                }
                else if (colNames[i].ToLower().Contains("status"))
                {
                    retVal += ",'" + tbStatus.Text.ToString()+"'";//SNO     
                }
                else if (colNames[i].ToLower().Contains("description"))
                {
                    //retVal += ",'" + box.Text.ToString()+"'";
                    retVal += ",'" + "Prasad gaadi bug idi" + "'";//SNO     
                }
                else
                {
                    retVal += ",'" + listOftextBox[i-1].Text.ToString()+"'";
                }
            }
            return retVal;
        }

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        void InsertIntoMariaDB()
        {
            connectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;ReadOnly=False;$HDR=Yes;IMEX=2';";
            var server = "localhost";
            var database = "test";
            var uid = "root";
            var password = "password123";
            dbConnectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                //Get All Sheets Name
                DataTable sheetsName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                foreach (var item in wsList)
                {
                    if (item.ToLower().Contains("transform"))
                    {
                        string sql = string.Format("SELECT * FROM [{0}] ", item);
                        OleDbDataAdapter ada = new OleDbDataAdapter(sql, connectionString);
                        DataSet set = new DataSet();
                        ada.Fill(set);
                        DataTable tables = set.Tables[0];
                        LastRow = tables.Rows.Count;
                        var table = set.Tables[0].AsEnumerable();
                        List<String> list = new List<string>();
                        using (MySqlConnection connection = new MySqlConnection(dbConnectionString))
                        {
                            connection.Open();
                            for (int i = 0; i < LastRow; i++)
                            {
                                try
                                {
                                    var row = tables.Rows[i];
                                    var query = GetQueryString(row, tables.Columns, item);
                                    list.Add(query);
                                    MySqlCommand cmd = new MySqlCommand(query, connection);
                                    //Execute command
                                    cmd.ExecuteNonQuery();

                                }
                                catch (Exception ex)
                                {
                                    
                                }
                            }
                        }
                        File.WriteAllLines(@"D:\back.sql", list);
                    }

                }
            }
        }

        private String GetQueryString(DataRow row, DataColumnCollection dataColumnCollection,String item)
        {
            var retval = "";
            var colString = "";
            for (int i = 0; i < dataColumnCollection.Count; i++)
            {
                if (dataColumnCollection[i].ColumnName.ToLower().Contains("no"))
                {
                    retval = row.ItemArray[i].ToString();
                    colString = String.Format("{0}", dataColumnCollection[i].ColumnName);
                }
                else 
                {
                    colString += String.Format(",{0}", dataColumnCollection[i].ColumnName);
                    retval += String.Format(",'{0}'", row.ItemArray[i].ToString());
                }
            }
            var dbQuery = String.Format("INSERT INTO {0}({1}) VALUES ({2})", item.Replace("$",""), colString, retval);
            return dbQuery;
            
        }


        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        public List<string> wsList { get; set; }

        public int LastRow { get; set; }

        public string dbConnectionString { get; set; }

        private void btnFetchNext_Click(object sender, EventArgs e)
        {
            FetchData(GetSNO()+1);
        }

        private void btnFetchPrevious_Click(object sender, EventArgs e)
        {
            FetchData(GetSNO()-1);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
