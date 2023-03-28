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

namespace CRUDForm
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-NR2M9QM\\SQLEXPRESS;Initial Catalog=CRUDForm;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ut values(@prod_type,@prod_name,@prod_id,@price,@prod_desc)",con);
            cmd.Parameters.AddWithValue("@prod_type", prod_type.Text);
            cmd.Parameters.AddWithValue("@prod_name", prod_name.Text);
            cmd.Parameters.AddWithValue("@prod_id", int.Parse(prod_id.Text));
            cmd.Parameters.AddWithValue("@price", double.Parse(price.Text));
            cmd.Parameters.AddWithValue("@prod_desc", prod_desc.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Inserted to the database...");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-NR2M9QM\\SQLEXPRESS;Initial Catalog=CRUDForm;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update ut set prod_type=@prod_type, prod_name=@prod_name,price=@price,prod_desc=@prod_desc where prod_id=@prod_id", con);
            cmd.Parameters.AddWithValue("@prod_type", prod_type.Text);
            cmd.Parameters.AddWithValue("@prod_name", prod_name.Text);
            cmd.Parameters.AddWithValue("@prod_id", int.Parse(prod_id.Text));
            cmd.Parameters.AddWithValue("@price", double.Parse(price.Text));
            cmd.Parameters.AddWithValue("@prod_desc", prod_desc.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated to the database...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-NR2M9QM\\SQLEXPRESS;Initial Catalog=CRUDForm;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete ut where prod_id=@prod_id",con);
            cmd.Parameters.AddWithValue("@prod_id", int.Parse(prod_id.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted to the database...");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-NR2M9QM\\SQLEXPRESS;Initial Catalog=CRUDForm;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ut", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            displayTable.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void prod_type_TextChanged(object sender, EventArgs e)
        {

        }

        private void prod_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void prod_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void prod_desc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

