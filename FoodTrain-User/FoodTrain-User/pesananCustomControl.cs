﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodTrain_User
{
    public partial class pesananCustomControl : UserControl
    {
        //access database koneksi string
        string PesananConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\WIN10x64\OneDrive\Desktop\FoodTrain-App\\db_access.accdb";
        //query for interesting data into pesanan
        string pesanDataIntoPesanan = "INSERT INTO Pesanan (Nama, Jumlah) VALUES (?,?)";
        //query for seleting from pesanan
        string selectAllDataFromPesananQuery = "Select * FROM Pesanan";
        //query for updating from pesanan
        string ubahAllDataFromPesananQuery = "UPDATE Pesanan SET Nama = ?, Jumlah = ?, WHERE ID = ?";
        //query for deleting from pesanan
        string hapusDataFromPesananQuery = "DELETE FROM Pesanan  WHERE ID = ?";

        public OleDbConnection PesananOleDbConnection = null;

        public pesananCustomControl()
        {
            //inisialisasi oledbkoneksi dalam konstruksi
            PesananOleDbConnection = new OleDbConnection(PesananConnectionString);
            InitializeComponent();
        }

        private void openCennection()
        {
            //membuka koneksi
            if (PesananOleDbConnection.State == ConnectionState.Closed)
            {
                PesananOleDbConnection.Open();
            }
        }
        private void closeConnection()
        {
            //tutup koneksi
            if (PesananOleDbConnection.State == ConnectionState.Open)
            {
                PesananOleDbConnection.Close();
            }
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            OleDbCommand pesanDataIntoPesananOleDbCommand;
            //check field empty or not
            if (String.IsNullOrEmpty(txtNama.Text) || String.IsNullOrEmpty(txtJumlah.Text))
            {
                MessageBox.Show("One or more fields are empty make sure all fields are filled.");
            }
            else
                try
                {
                    pesanDataIntoPesananOleDbCommand = new OleDbCommand(pesanDataIntoPesanan, PesananOleDbConnection);
                    pesanDataIntoPesananOleDbCommand.Parameters.AddWithValue("Nama", OleDbType.VarChar).Value = txtNama.Text;
                    pesanDataIntoPesananOleDbCommand.Parameters.AddWithValue("Jumlah", OleDbType.Numeric).Value = txtJumlah.Text;
                    //open database connection
                    openCennection();

                    int dataInserted = pesanDataIntoPesananOleDbCommand.ExecuteNonQuery();

                    if (dataInserted > 0)
                    {
                        MessageBox.Show("Menu Berhasil Dipesan.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //finally close connection to the database
                    closeConnection();
                    //refresh datagridview after inserting data to the database
                    populateDataGridViewFromPesanan();
                }
        }

        private void pesananCustomControl_Load(object sender, EventArgs e)
        {
            //change row height
            dataGridView1.RowTemplate.Height = 60;
            //populate dataGridview on form pesanan on from load
            populateDataGridViewFromPesanan();
        }

        //Function datagridview retrieving data from pesanan and displaying it on datagridview
        private void populateDataGridViewFromPesanan()
        {
            //clear datagridview rows before loading data from pesanan
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
            }

            try
            {
                OleDbCommand populateDataGridViewFromPesananOleDbCommand = new OleDbCommand(selectAllDataFromPesananQuery, PesananOleDbConnection);
                //open koneksi
                openCennection();
                OleDbDataReader reader = populateDataGridViewFromPesananOleDbCommand.ExecuteReader();
                //loop trough data pesanan
                while (reader.Read())
                {
                    //add pesanan ke datagridview
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //close koneksi
                closeConnection();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if datagridview  is clicked
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectDataGridViewRow = dataGridView1.Rows[e.RowIndex];

                txtID.Text = selectDataGridViewRow.Cells[0].Value.ToString();
                txtNama.Text = selectDataGridViewRow.Cells[1].Value.ToString();
                txtJumlah.Text = selectDataGridViewRow.Cells[2].Value.ToString();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtID.Text == String.Empty)
            {
                MessageBox.Show("First Click On DatagridView Row Cell Or Make Sure ID Field Is Not Empty.");
            }
            else
            {
                try
                {
                    //Check If One Or More Fields Are Empty
                    if (txtNama.Text == String.Empty || txtJumlah.Text == String.Empty)
                    {
                        MessageBox.Show("One Or More Empty Field Make sure all fields are filled.");
                    }
                    else
                    {
                        OleDbCommand ubahPesananOleDbCommand = new OleDbCommand(ubahAllDataFromPesananQuery, PesananOleDbConnection);
                        ubahPesananOleDbCommand.Parameters.AddWithValue("@Nama", OleDbType.VarChar).Value = txtNama.Text;
                        ubahPesananOleDbCommand.Parameters.AddWithValue("@Jumlah", OleDbType.VarChar).Value = txtJumlah.Text;
                        ubahPesananOleDbCommand.Parameters.AddWithValue("@ID", OleDbType.Integer).Value = Convert.ToInt32(txtID.Text);
                        //Opening Access Database Connection
                        PesananOleDbConnection.Open();
                        int insertDataIntoPesanan = ubahPesananOleDbCommand.ExecuteNonQuery();
                        //If data Has been inserted to the database output the following message
                        if (insertDataIntoPesanan > 0)
                        {
                            MessageBox.Show("Data Updated In Pesanan Susccessfully.");
                            //Clear Input fields After Deleting the Data From MS Access Database
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
                finally
                {
                    //Finally Close MS Access Database Connection
                    if (PesananOleDbConnection != null)
                    {
                        PesananOleDbConnection.Close();
                    }
                }
                //Refreshing Datagridview after Updating a row
                populateDataGridViewFromPesanan();
            }
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            clearInputFields();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                //check if id textbox is empty
                if (String.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("ID field is empty click on datagrid row cell first.");
                }
                else
                {
                    OleDbCommand hapusDataFromPesananQueryOleDbCommand = new OleDbCommand(hapusDataFromPesananQuery, PesananOleDbConnection);
                    hapusDataFromPesananQueryOleDbCommand.Parameters.AddWithValue("ID", OleDbType.Integer).Value = Convert.ToInt16(txtID.Text);
                    //open koneksi
                    openCennection();

                    int deleteDataFromPesanan = hapusDataFromPesananQueryOleDbCommand.ExecuteNonQuery();
                    if (deleteDataFromPesanan > 0)
                    {
                        MessageBox.Show("Delete data from Table Pesanan Successfully.");
                        //clear input fields

                        clearInputFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close koneksi pesanan
                closeConnection();
                //refresh datagridview after deleting data to the database
                populateDataGridViewFromPesanan();
            }
        }

        private void clearInputFields()
        {
            //first check if all input fields are empty
            if (String.IsNullOrEmpty(txtNama.Text) && String.IsNullOrEmpty(txtJumlah.Text))
            {
                MessageBox.Show("All input fields are empty");
            }
            else
            {
                //clearing textboxes
                txtID.Text = string.Empty;
                txtNama.Text = string.Empty;
                txtJumlah.Text = string.Empty;
            }
        }
    }
}
