using Corretora_de_Investimento.Utilities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Corretora_de_Investimento
{
    internal class DatabaseConnection
    {
        private MySqlConnection connection;
        public DatabaseConnection() {
            connection = new MySqlConnection("server=localhost;user id=root;password='1234';database=corretorainvestimentos");
        }
        public DataTable GetTable(string name)
        {
            MySqlCommand cmd = new MySqlCommand("selectTable", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = name;
            try
            {
                connection.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                Translate.TranslateDataTable(ref dataTable);
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public void DeleteRow(string name, int id)
        {
            MySqlCommand cmd = new MySqlCommand("apaga", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@chave", MySqlDbType.Int32).Value = id;

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e);
            }
            finally
            {
                connection.Close();
            }
        }
        public List<string> GetColumns(string name)
        {
            MySqlCommand cmd = new MySqlCommand("obtemNomeColunas", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = name;

            try
            {
                connection.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                List<string> columnsName = new List<string>();

                for (int i = 0; i < dataTable.Rows.Count; i++) {
                    DataRow dataRow = dataTable.Rows[i];
                    columnsName.Add(dataRow[0].ToString());
                }
            return columnsName;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public void InsertRow(string name)
        {
            char[] nameC= name.ToCharArray();
            nameC[0] = char.ToUpper(name[0]);
            name = new string(nameC);
            MySqlCommand cmd = new MySqlCommand("insere" + name, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            List<string> columnsName = GetColumns(name);
            columnsName.RemoveAt(0);
            try
            {
                connection.Open();
                InsertDialog insertDialog = new InsertDialog();
                TextBox textBoxModel = new TextBox();
                GroupBox groupBoxModel = new GroupBox();
                foreach (Control c in insertDialog.Controls)
                {
                    if(c is GroupBox)
                    {
                        groupBoxModel = ((GroupBox)c).Clone();
                        textBoxModel = ((TextBox)c.Controls[0]).Clone();
                        c.Text = Translate.TranslateText(columnsName[0]);
                        c.Controls[0].Name = columnsName[0];
                        continue;
                    }
                    if(c is Label && c.Name == "TextTableName")
                    {
                        c.Text = name;
                    }
                }
                for (int i = 1; i < columnsName.Count; i++)
                {

                    TextBox textBox = textBoxModel.Clone();
                    GroupBox groupBox = groupBoxModel.Clone();

                    groupBox.Visible = true;
                    groupBox.Location = new Point(groupBoxModel.Location.X, groupBoxModel.Location.Y + i * 56);

                    groupBox.Name = "attributeBox" + (i+1);
                    groupBox.Text = Translate.TranslateText(columnsName[i]);
                    textBox.Name = columnsName[i];
                    groupBox.Controls.Add(textBox);
                    groupBox.Controls[0].Visible = true;
                    insertDialog.Controls.Add(groupBox);
                }
                insertDialog.ShowDialog();
                if (insertDialog.validated)
                {
                    foreach (Control c in insertDialog.selection)
                    {
                        cmd.Parameters.Add("@" + c.Name, MySqlDbType.VarChar).Value = c.Text;
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e);
            }
            finally
            {
                connection.Close();
            }
        }
        public void ModifyRow(string name)
        {
            char[] nameC = name.ToCharArray();
            nameC[0] = char.ToUpper(name[0]);
            name = new string(nameC);
            MySqlCommand cmd = new MySqlCommand("altera" + name, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            List<string> columnsName = GetColumns(name);
            try
            {
                connection.Open();
                InsertDialog insertDialog = new InsertDialog();
                TextBox textBoxModel = new TextBox();
                GroupBox groupBoxModel = new GroupBox();
                foreach (Control c in insertDialog.Controls)
                {
                    if (c is GroupBox)
                    {
                        groupBoxModel = ((GroupBox)c).Clone();
                        textBoxModel = ((TextBox)c.Controls[0]).Clone();
                        c.Text = Translate.TranslateText(columnsName[0]);
                        c.Controls[0].Name = columnsName[0];
                        continue;
                    }
                    if (c is Label && c.Name == "TextTableName")
                    {
                        c.Text = name;
                    }
                }
                for (int i = 1; i < columnsName.Count; i++)
                {

                    TextBox textBox = textBoxModel.Clone();
                    GroupBox groupBox = groupBoxModel.Clone();

                    groupBox.Visible = true;
                    groupBox.Location = new Point(groupBoxModel.Location.X, groupBoxModel.Location.Y + i * 56);

                    groupBox.Name = "attributeBox" + (i + 1);
                    groupBox.Text = Translate.TranslateText(columnsName[i]);
                    textBox.Name = columnsName[i];
                    groupBox.Controls.Add(textBox);
                    groupBox.Controls[0].Visible = true;
                    insertDialog.Controls.Add(groupBox);
                }
                insertDialog.ShowDialog();
                if (insertDialog.validated)
                {
                    foreach (Control c in insertDialog.selection)
                    {
                        cmd.Parameters.Add("@" + c.Name, MySqlDbType.VarChar).Value = c.Text;
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e);
            }
            finally
            {
                connection.Close();
            }
        }
        public bool ValidateUserName(string username)
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("procuraNomeUsuario", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = username;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) return true;
                else return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e);
                return false;
            }
            finally
            {
                connection.Close();
            }

        }
        public bool ValidateLogin(string username, string password)
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("obtemLogin", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = MakeHash.HashSha256(password);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) return true;
                else return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public void SingOnUser(string username, string password)
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("insereAdministrador", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = MakeHash.HashSha256(password);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
