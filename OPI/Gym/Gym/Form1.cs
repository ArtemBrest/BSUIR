using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Gym
{
    public partial class Form1 : Form
    {
        DataSet ds;
        string connectionString = @"Server=localhost;Port=5432;User Id=postgres;Password=z7AEwer79;Database=GYM;";
        string npg = "SELECT * FROM coach, students";
        public bool students = true;
        public string sql_st = "SELECT * FROM students";
        public string sql_ch = "SELECT * FROM coach";
        public string sql_full = "SELECT * FROM coach JOIN students ON coach.coach_id = students.fk_students_coach";
        public Form1()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = true;
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(npg, connection);

                ds = new DataSet();
                adapter.Fill(ds);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connectString = new NpgsqlConnection(connectionString);
            NpgsqlCommand TableConnection = new NpgsqlCommand();
            connectString.Open();
            TableConnection.Connection = connectString;
            TableConnection.CommandType = CommandType.Text;
            TableConnection.CommandText = sql_ch;
            NpgsqlDataReader db = TableConnection.ExecuteReader();
            if (db.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(db);
                dataGridView1.DataSource = dt;
            }
            TableConnection.Dispose();
            connectString.Close();
            students = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connectString = new NpgsqlConnection(connectionString);
            NpgsqlCommand TableConnection = new NpgsqlCommand();
            connectString.Open();
            TableConnection.Connection = connectString;
            TableConnection.CommandType = CommandType.Text;
            TableConnection.CommandText = sql_st;
            NpgsqlDataReader db = TableConnection.ExecuteReader();
            if (db.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(db);
                dataGridView1.DataSource = dt;
            }
            TableConnection.Dispose();
            connectString.Close();
            students = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connectString = new NpgsqlConnection(connectionString);
            NpgsqlCommand TableConnection = new NpgsqlCommand();
            connectString.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql_full, connectString);
            DataTable dt = new DataTable("coach, students");
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            TableConnection.Dispose();
            connectString.Close();
        }
        private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            NpgsqlConnection connectString = new NpgsqlConnection(connectionString);
            NpgsqlCommand TableConnection = new NpgsqlCommand();
            connectString.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql_full, connectString);
            DataTable dt = new DataTable("coach");
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dt.DefaultView.RowFilter = String.Format("name_coach like '%" + textSearch.Text + "%'");
            TableConnection.Dispose();
            connectString.Close();
        }
        private void textSeach2_KeyPress(object sender, KeyPressEventArgs e)
        {
            NpgsqlConnection connectString = new NpgsqlConnection(connectionString);
            NpgsqlCommand TableConnection = new NpgsqlCommand();
            connectString.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from students JOIN coach ON students.fk_students_coach = coach.coach_id", connectString);
            DataTable dt = new DataTable("students");
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dt.DefaultView.RowFilter = String.Format("name_students like '%" + textSeach2.Text + "%'");

            TableConnection.Dispose();
            connectString.Close();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connectString = new NpgsqlConnection(connectionString);  
            if(students == true)
            {
                connectString.Open();
                NpgsqlDataAdapter adapter_st = new NpgsqlDataAdapter(sql_st, connectString);
                NpgsqlCommandBuilder cmdBuilder_st = new NpgsqlCommandBuilder(adapter_st);
                adapter_st.UpdateCommand = cmdBuilder_st.GetUpdateCommand();
                adapter_st.Update((DataTable)dataGridView1.DataSource);
                connectString.Close();
            }
            else
            {
                connectString.Open();
                NpgsqlDataAdapter adapter_ch = new NpgsqlDataAdapter(sql_ch, connectString);
                NpgsqlCommandBuilder cmdBuilder_ch = new NpgsqlCommandBuilder(adapter_ch);
                adapter_ch.UpdateCommand = cmdBuilder_ch.GetUpdateCommand();
                adapter_ch.Update((DataTable)dataGridView1.DataSource);
                connectString.Close();
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow();
            ds.Tables[0].Rows.Add(row);
        }
        private void textSearch_Click(object sender, EventArgs e)
        {
            textSeach2.Text = "";
        }
        private void textSeach2_Click(object sender, EventArgs e)
        {
            textSearch.Text = "";
        }
    }
}
