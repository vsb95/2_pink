using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UserService;
//using UserService;
//using UserService = UserService.UserService;

namespace WindowsFormsApplication02
{
    public partial class MainForm : Form
    {
        private readonly UserService.UserService _service;
        private ArrayList _juornal;
        private bool _isLoginTried = false;


        public MainForm()
        {
            InitializeComponent();
            _juornal = new ArrayList();
            _service = new UserService.UserService();

            
        }

        

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            _isLoginTried = true;
            try
            {
                string role = _service.GetCurrentRole(tBoxLogin.Text, tBoxPass.Text);
                if (role == null) throw new Exception("Пользователь не найден");
                labelPass.Enabled = false;
                tBoxPass.Enabled = false;
                labelogin.Enabled = false;
                tBoxLogin.Enabled = false;
                buttonLogin.Visible = false;
                label1.Visible = true;
                comboBoxTables.Visible = true;
                dataGridView2.Visible = true;
                buttonExit.Visible = true;
                cBoxRoles.DataSource = new List<string> { "Администратор", "Оператор", "Пользователь" };
                foreach (var table in _service.Tables)
                    comboBoxTables.Items.Add(table.Name);
                comboBoxTables.Items.Remove("Журнал");
                comboBoxTables.Items.Remove("Пользователь");
                switch (role)
                {
                    case "Администратор":
                        linkLabelReg.Visible = true;
                        linkLabelShowMagazine.Visible = true;
                        buttonAdd.Visible = true;
                        buttonEdit.Visible = true;
                        buttonDelete.Visible = true;
                        linkLabelQuerry1.Visible = true;
                        linkLabelQuerry2.Visible = true;
                        linkLabelQuerry3.Visible = true;
                        linkLabelQuerry4.Visible = true;
                        break;
                    case "Оператор":
                        buttonAdd.Visible = true;
                        buttonEdit.Visible = true;
                        buttonDelete.Visible = true;
                        linkLabelQuerry1.Visible = true;
                        linkLabelQuerry2.Visible = true;
                        linkLabelQuerry3.Visible = true;
                        linkLabelQuerry4.Visible = true;
                        break;
                    case "Пользователь":
                        break;
                    default: throw new Exception("Не удалось определить права доступа");
                }
                _juornal.Add(tBoxLogin.Text);
                _juornal.Add(DateTime.Now);
            }
            catch (Exception ex)
            {
                _juornal.Add(tBoxLogin.Text);
                _juornal.Add(DateTime.Now);
                _juornal.Add(DateTime.Now);
                _juornal.Add(false);
                _service.InsertQuery(_juornal, "Журнал");
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //// выбрать табу и из нее датагрида вызвать 

            try
            {
                var fields = _service.Tables.FirstOrDefault(t => t.Name == comboBoxTables.SelectedItem.ToString())
                    .Fields.Select(field => field.Name).ToList();
                var frm = new FormEdit_Add_(_service, this, fields, comboBoxTables.SelectedItem.ToString());
                frm.ShowDialog();
                dataGridView2.DataSource = _service.SelectFromTable(comboBoxTables.SelectedItem.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //// выбрать табу и из нее датагрида вызвать 

            try
            {
                if (comboBoxTables.SelectedItem == null) return;
                var editValuesList = new List<string>();
                for (var i = 0; i < dataGridView2.SelectedRows[0].Cells.Count; i++)
                    editValuesList.Add(dataGridView2.SelectedRows[0].Cells[i].Value.ToString());
                var fields = _service.Tables.FirstOrDefault(t => t.Name == comboBoxTables.SelectedItem.ToString())
                    .Fields.Select(field => field.Name).ToList();
                var frm = new FormEdit_Add_(_service, this, fields, comboBoxTables.SelectedItem.ToString(), editValuesList);
                frm.ShowDialog();
                dataGridView2.DataSource = _service.SelectFromTable(comboBoxTables.SelectedItem.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _service.DeleteFromTable(comboBoxTables.SelectedItem.ToString(),
                    Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));
                dataGridView2.DataSource = _service.SelectFromTable(comboBoxTables.SelectedItem.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.DataSource = _service.SelectFromTable(comboBoxTables.SelectedItem.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void linkLabelReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cBoxRoles.Visible = true;
            textBoxLoginForReg.Visible = true;
            textBoxPassForReg.Visible = true;
            labelLoginForReg.Visible = true;
            labelPassForReg.Visible = true;
            labelRole.Visible = true;
            buttonReg.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _service.InsertQuery(
                    new ArrayList { textBoxLoginForReg.Text, textBoxPassForReg.Text, cBoxRoles.SelectedItem.ToString() },
                    "Пользователь");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            cBoxRoles.Visible = false;
            textBoxLoginForReg.Visible = false;
            textBoxPassForReg.Visible = false;
            labelLoginForReg.Visible = false;
            labelPassForReg.Visible = false;
            labelRole.Visible = false;
            buttonReg.Visible = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabelShowMagazine_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                dataGridView2.DataSource = _service.SelectFromTable("Журнал");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void linkLabelQuerry1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var query = "SELECT        dbo.Акт.*, dbo.Объект.*, dbo.[Оценка стоимости].[Физический износ( %)], dbo.[Оценка стоимости].[Остаточная стоимость (руб)], dbo.[Оценка стоимости].[Оценочная стоимость (руб)], dbo.[Категория износа].Категория "
                        + "FROM            dbo.Акт INNER JOIN "
                        +
                        "dbo.[Оценка стоимости] ON dbo.Акт.[Номер акта] = dbo.[Оценка стоимости].[Номер акта] INNER JOIN "
                        +
                        "dbo.Объект ON dbo.[Оценка стоимости].[Инвентарный номер] = dbo.Объект.[Инвернтарный номер] INNER JOIN "
                        +
                        "dbo.[Категория износа] ON dbo.[Оценка стоимости].[Физический износ( %)] = dbo.[Категория износа].[Фактический износ (%)] "
                        + "WHERE(dbo.Акт.[Название организации] = N'ООО Ромашка')";
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView2.DataSource = _service.SelectQuery(query);
        }
        private void linkLabelQuerry2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var query = "SELECT        dbo.Объект.Наименование, dbo.Объект.Местонахождение, dbo.[Категория износа].Категория "
                        + "FROM            dbo.Объект INNER JOIN "
                        +
                        "dbo.[Оценка стоимости] ON dbo.Объект.[Инвернтарный номер] = dbo.[Оценка стоимости].[Инвентарный номер] INNER JOIN "
                        + "dbo.[Категория износа] ON dbo.[Оценка стоимости].[Физический износ( %)] = dbo.[Категория износа].[Фактический износ (%)]";
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView2.DataSource = _service.SelectQuery(query);
        }

        private void linkLabelQuerry3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var query = "select Count(*) as Количество from Акт where Акт.Дата between  '2015-02-01 00:00:00' and '2015-02-28 00:00:00'";
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView2.DataSource = _service.SelectQuery(query);
        }

        private void linkLabelQuerry4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var query = "SELECT        dbo.Объект.Наименование, dbo.[Категория износа].Категория, dbo.[Оценка стоимости].[Физический износ( %)] "
                        + "FROM            dbo.Объект INNER JOIN "
                        +
                        "dbo.[Оценка стоимости] ON dbo.Объект.[Инвернтарный номер] = dbo.[Оценка стоимости].[Инвентарный номер] INNER JOIN "
                        + "dbo.[Категория износа] ON dbo.[Оценка стоимости].[Физический износ( %)] = dbo.[Категория износа].[Фактический износ (%)]"
                        + "ORDER BY dbo.[Категория износа].Категория";
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView2.DataSource = _service.SelectQuery(query);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_isLoginTried) return;
            _juornal.Add(DateTime.Now);
            _juornal.Add(true);
            _service.InsertQuery(_juornal, "Журнал");
        }
    }
}
