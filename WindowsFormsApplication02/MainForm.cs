using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UserService;

namespace WindowsFormsApplication02
{
    public partial class MainForm : Form
    {
        private readonly List<Table> _tablesList;
        private readonly string _role;
        private readonly UserService.UserService _service;
        private List<string> _fieldsList;
        private BindingSource bindingSource1 = new BindingSource();
        public MainForm()
        {
            InitializeComponent();
        }

        private void linkLabelQuerry1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string role = "Admin";
                labelPass.Enabled = false;
                tBoxPass.Enabled = false;
                labelogin.Enabled = false;
                tBoxLogin.Enabled = false;
                buttonLogin.Visible = false;
                label1.Visible = true;
                comboBoxTables.Visible = true;
                dataGridView2.Visible = true;
                buttonExit.Visible = true;
                //////////////////////////////////////////////////////////////////////////////////
                ///  загрузи список таблиц в comboBoxTables
                
                switch (role)
                {
                    case "Admin":
                        linkLabelReg.Visible = true;
                        linkLabelShowMagazine.Visible = true;
                        break;
                    case "Editor":
                        buttonAdd.Visible = true;
                        buttonEdit.Visible = true;
                        buttonDelete.Visible = true;
                        linkLabelQuerry1.Visible = true;
                        linkLabelQuerry2.Visible = true;
                        linkLabelQuerry3.Visible = true;
                        linkLabelQuerry4.Visible = true;
                        break;
                    case "Reader":
                        break;
                    default: throw new Exception("Чет хз кто ты");
                }
                foreach (var table in _service.Tables)
                    comboBoxTables.Items.Add(table.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //// выбрать табу и из нее датагрида вызвать 
            /*
            var fields = _service.Tables.FirstOrDefault(t => t.Name == listBoxTables.SelectedItem.ToString())
                .Fields.Select(field => field.Name).ToList();
            var frm = new FormEdit_Add_(_service, this, fields, listBoxTables.SelectedItem.ToString());
            frm.ShowDialog();
            Refresh();
    */
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //// выбрать табу и из нее датагрида вызвать 
            /*
            var fields = _service.Tables.FirstOrDefault(t => t.Name == listBoxTables.SelectedItem.ToString())
                .Fields.Select(field => field.Name).ToList();
            var frm = new FormEdit_Add_(_service, this, fields, listBoxTables.SelectedItem.ToString());
            frm.ShowDialog();
            Refresh();
    */
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dataGridView2.DataSource = _service.SelectFromTable(comboBoxTables.SelectedItem.ToString());
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
            /////////////////////////////////////////////////////////////////////
            /// Нужно зарегистрировать в системе
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
    }
}
