using Corretora_de_Investimento.Utilities;
using System;
using System.Collections.Specialized;
using System.Data;
using System.Windows.Forms;

namespace Corretora_de_Investimento
{
    public partial class Corretora_Investimentos : Form
    {

        public MoveToScreen moveToScreen;
        private DatabaseConnection connection = new DatabaseConnection();
        public Corretora_Investimentos()
        {
            IsMdiContainer = true;
            InitializeComponent();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (selectionBox.SelectedIndex != -1)
            {
                connection.InsertRow(selectionBox.Text.ToLower());
                dataGrid.DataSource = connection.GetTable(selectionBox.Text.ToLower());
            }
        }
        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (selectionBox.SelectedIndex != -1)
            {
                connection.ModifyRow(selectionBox.Text.ToLower());
                dataGrid.DataSource = connection.GetTable(selectionBox.Text.ToLower());
            }
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count>0) {
                connection.DeleteRow(selectionBox.Text.ToLower(), int.Parse(dataGrid.SelectedRows[0].Cells[0].Value.ToString()));
                dataGrid.DataSource = connection.GetTable(selectionBox.Text.ToLower());
            }
        }
        private void Corretora_Investimentos_Load(object sender, EventArgs e)
        {
            connection = new DatabaseConnection();
        }
        private void selectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectionBox.SelectedIndex == -1) return;
            comboBoxPropriety.DataSource = connection.GetColumns(selectionBox.Text.ToLower());
            comboBoxPropriety.AutoCompleteCustomSource.AddRange(connection.GetColumns(selectionBox.Text.ToLower()).ToArray());
            dataGrid.DataSource = connection.GetTable(selectionBox.Text.ToLower());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (selectionBox.SelectedIndex != -1 && comboBoxPropriety.SelectedIndex != -1)
            {
                (dataGrid.DataSource as DataTable).DefaultView.RowFilter = String.Format(Translate.TranslateText(comboBoxPropriety.Text) + " like'{0}%'", SearchBox.Text);
            }
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            config.Show(this);
        }
    }
}
