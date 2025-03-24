using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SYSARCH_proj
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.collegeTableAdapter1.Fill(this.univDataSet1.College);
            this.departmentTableAdapter.Fill(this.univDataSet.Department);
            this.collegeTableAdapter.Fill(this.univDataSet.College);
            DbHelper.GetConnection();
        }

        private void RefreshDataGrid()
        {
            try
            {
                if (DbHelper.conn == null || DbHelper.conn.State != ConnectionState.Open)
                {
                    DbHelper.GetConnection();
                }

                string query = "SELECT * FROM Department";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, DbHelper.conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing data: {ex.Message}");
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtCollegeID.Text = row.Cells[0].Value?.ToString() ?? "";
                txtDeptID.Text = row.Cells[1].Value?.ToString() ?? "";
                txtDeptName.Text = row.Cells[2].Value?.ToString() ?? "";
                txtDeptCode.Text = row.Cells[3].Value?.ToString() ?? "";
                if (row.Cells[4].Value != DBNull.Value && row.Cells[4].Value != null)
                {
                    chkIsActive.Checked = Convert.ToInt32(row.Cells[4].Value) == -1;
                }
                else
                {
                    chkIsActive.Checked = false;
                }
                MessageBox.Show($"Clicked Row Data:\nCollegeID: {txtCollegeID.Text}\nDeptID: {txtDeptID.Text}\nDeptName: {txtDeptName.Text}\nDeptCode: {txtDeptCode.Text}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DbHelper.conn == null || DbHelper.conn.State != ConnectionState.Open)
            {
                DbHelper.GetConnection();
            }

            OleDbConnection connection = DbHelper.conn;

            if (connection != null)
            {
                try
                {
                    string collegeID = txtCollegeID.Text.Trim();
                    string deptID = txtDeptID.Text.Trim();
                    string deptName = txtDeptName.Text.Trim();
                    string deptCode = txtDeptCode.Text.Trim();
                    bool isActive = chkIsActive.Checked;

                    if (string.IsNullOrWhiteSpace(deptID) || string.IsNullOrWhiteSpace(deptName) || string.IsNullOrWhiteSpace(deptCode) || string.IsNullOrWhiteSpace(collegeID))
                    {
                        MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string checkDeptQuery = "SELECT COUNT(*) FROM Department WHERE DepartmentID = ?";
                    OleDbCommand checkDeptCommand = new OleDbCommand(checkDeptQuery, connection);
                    checkDeptCommand.Parameters.AddWithValue("?", deptID);
                    int deptCount = (int)checkDeptCommand.ExecuteScalar();

                    if (deptCount == 0)
                    {
                        MessageBox.Show("Department ID not found. Please enter a valid Department ID.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string updateQuery = "UPDATE Department SET DepartmentName = ?, DepartmentCode = ?, CollegeID = ?, IsActive = ? WHERE DepartmentID = ?";
                    OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("?", deptName);
                    updateCommand.Parameters.AddWithValue("?", deptCode);
                    updateCommand.Parameters.AddWithValue("?", collegeID);
                    updateCommand.Parameters.AddWithValue("?", isActive ? -1 : 0);
                    updateCommand.Parameters.AddWithValue("?", deptID);

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Department record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("No records were updated. Please check your inputs.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating department record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (DbHelper.conn != null && DbHelper.conn.State == ConnectionState.Open)
                    {
                        DbHelper.conn.Close();
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (DbHelper.conn == null || DbHelper.conn.State != System.Data.ConnectionState.Open)
            {
                DbHelper.GetConnection();
            }

            OleDbConnection connection = DbHelper.conn;

            if (connection != null)
            {
                try
                {
                    string collegeID = txtCollegeID.Text.Trim();
                    string deptID = txtDeptID.Text.Trim();
                    string deptName = txtDeptName.Text.Trim();
                    string deptCode = txtDeptCode.Text.Trim();
                    bool isActive = chkIsActive.Checked;
                    string checkCollegeQuery = "SELECT COUNT(*) FROM College WHERE CollegeID = ?";
                    OleDbCommand checkCollegeCommand = new OleDbCommand(checkCollegeQuery, connection);
                    checkCollegeCommand.Parameters.AddWithValue("?", collegeID);
                    int collegeCount = (int)checkCollegeCommand.ExecuteScalar();

                    if (collegeCount == 0)
                    {
                        MessageBox.Show("Invalid College ID. Please enter an existing College ID.");
                        return;
                    }

                    string checkDeptQuery = "SELECT COUNT(*) FROM Department WHERE DepartmentID = ?";
                    OleDbCommand checkDeptCommand = new OleDbCommand(checkDeptQuery, connection);
                    checkDeptCommand.Parameters.AddWithValue("?", deptID);
                    int deptCount = (int)checkDeptCommand.ExecuteScalar();

                    if (deptCount > 0)
                    {
                        MessageBox.Show("Department ID already exists.");
                        return;
                    }

                    string query = "INSERT INTO Department (DepartmentID, DepartmentName, DepartmentCode, CollegeID, IsActive) VALUES (?, ?, ?, ?, ?)";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("?", deptID);
                    command.Parameters.AddWithValue("?", deptName);
                    command.Parameters.AddWithValue("?", deptCode);
                    command.Parameters.AddWithValue("?", collegeID);
                    command.Parameters.AddWithValue("?", isActive ? -1 : 0);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Department record added successfully!");
                        txtDeptID.Clear();
                        txtDeptName.Clear();
                        txtDeptCode.Clear();
                        chkIsActive.Checked = false;
                        RefreshDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add department record.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding department record: {ex.Message}");
                }
                finally
                {
                    if (DbHelper.conn != null && DbHelper.conn.State == System.Data.ConnectionState.Open)
                    {
                        DbHelper.conn.Close();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DbHelper.conn == null || DbHelper.conn.State != ConnectionState.Open)
            {
                DbHelper.GetConnection();
            }

            OleDbConnection connection = DbHelper.conn;

            if (connection != null)
            {
                try
                {
                    string deptID = txtDeptID.Text.Trim();
                    if (string.IsNullOrWhiteSpace(deptID))
                    {
                        MessageBox.Show("Please select a department to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this department?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        
                        string deleteQuery = "DELETE FROM Department WHERE DepartmentID = ?";
                        OleDbCommand deleteCommand = new OleDbCommand(deleteQuery, connection);
                        deleteCommand.Parameters.AddWithValue("?", deptID);

                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Department record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtDeptID.Clear();
                            txtDeptName.Clear();
                            txtDeptCode.Clear();
                            chkIsActive.Checked = false;
                            RefreshDataGrid();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the department record. Please try again.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting department record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (DbHelper.conn != null && DbHelper.conn.State == ConnectionState.Open)
                    {
                        DbHelper.conn.Close();
                    }
                }
            }
        }

        private void txtCollegeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (DbHelper.conn == null || DbHelper.conn.State != System.Data.ConnectionState.Open)
                {
                    DbHelper.GetConnection();
                }

                OleDbConnection connection = DbHelper.conn;

                if (connection != null)
                {
                    try
                    {
                        string collegeID = txtCollegeID.Text.Trim();
                        string collegeName = txtColName.Text.Trim();
                        string collegeCode = txtColCode.Text.Trim();
                        bool isActive = checkBox1.Checked;
                        string checkIDQuery = "SELECT COUNT(*) FROM College WHERE CollegeID = ?";
                        OleDbCommand checkIDCommand = new OleDbCommand(checkIDQuery, connection);
                        checkIDCommand.Parameters.AddWithValue("?", collegeID);
                        int idCount = (int)checkIDCommand.ExecuteScalar();

                        if (idCount > 0)
                        {
                            MessageBox.Show("College ID already exists.");
                            return;
                        }
                      
                        string query = "INSERT INTO College (CollegeID, CollegeName, CollegeCode, IsActive) VALUES (?, ?, ?, ?)";
                        OleDbCommand command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("?", collegeID);
                        command.Parameters.AddWithValue("?", collegeName);
                        command.Parameters.AddWithValue("?", collegeCode);
                        command.Parameters.AddWithValue("?", isActive ? -1 : 0);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record added successfully!");
                            txtCollegeID.Clear();
                            txtColName.Clear();
                            txtColCode.Clear();
                            checkBox1.Checked = false;
                            RefreshDataGrid();
                    }
                        else
                        {
                            MessageBox.Show("Failed to add record.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error adding record: {ex.Message}");
                    }
                    finally
                    {
                        if (DbHelper.conn != null && DbHelper.conn.State == System.Data.ConnectionState.Open)
                        {
                            DbHelper.conn.Close();
                        }
                    }
                }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int columnCount = dataGridView1.Columns.Count;

                if (columnCount < 5)
                {
                    MessageBox.Show($"Invalid column count: {columnCount}. Please check the data source.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtCollegeID.Text = row.Cells[0].Value?.ToString();
                txtDeptID.Text = row.Cells[1].Value?.ToString();
                if (columnCount > 2)
                    txtDeptName.Text = row.Cells[2].Value?.ToString();
                if (columnCount > 3)
                    txtDeptCode.Text = row.Cells[3].Value?.ToString();
                if (columnCount > 6)
                {
                    object isActiveValue = row.Cells[6].Value;
                    chkIsActive.Checked = isActiveValue != null && bool.TryParse(isActiveValue.ToString(), out bool isActiveResult) && isActiveResult;
                }
            }
        }
    }
}
