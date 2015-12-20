namespace WindowsFormsApplication02
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.linkLabelQuerry1 = new System.Windows.Forms.LinkLabel();
            this.linkLabelQuerry2 = new System.Windows.Forms.LinkLabel();
            this.linkLabelQuerry3 = new System.Windows.Forms.LinkLabel();
            this.linkLabelQuerry4 = new System.Windows.Forms.LinkLabel();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelogin = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.tBoxLogin = new System.Windows.Forms.TextBox();
            this.tBoxPass = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.linkLabelShowMagazine = new System.Windows.Forms.LinkLabel();
            this.linkLabelReg = new System.Windows.Forms.LinkLabel();
            this.buttonReg = new System.Windows.Forms.Button();
            this.textBoxPassForReg = new System.Windows.Forms.TextBox();
            this.textBoxLoginForReg = new System.Windows.Forms.TextBox();
            this.labelPassForReg = new System.Windows.Forms.Label();
            this.labelLoginForReg = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.cBoxRoles = new System.Windows.Forms.ComboBox();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(924, 106);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(200, 32);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(924, 186);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(200, 32);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(924, 146);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(200, 32);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Location = new System.Drawing.Point(27, 146);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(162, 32);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Вход";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // linkLabelQuerry1
            // 
            this.linkLabelQuerry1.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabelQuerry1.AutoSize = true;
            this.linkLabelQuerry1.LinkColor = System.Drawing.Color.DarkOrchid;
            this.linkLabelQuerry1.Location = new System.Drawing.Point(219, 37);
            this.linkLabelQuerry1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelQuerry1.Name = "linkLabelQuerry1";
            this.linkLabelQuerry1.Size = new System.Drawing.Size(87, 23);
            this.linkLabelQuerry1.TabIndex = 6;
            this.linkLabelQuerry1.TabStop = true;
            this.linkLabelQuerry1.Text = "Запрос 1";
            this.linkLabelQuerry1.Visible = false;
            this.linkLabelQuerry1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelQuerry1_LinkClicked);
            // 
            // linkLabelQuerry2
            // 
            this.linkLabelQuerry2.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabelQuerry2.AutoSize = true;
            this.linkLabelQuerry2.LinkColor = System.Drawing.Color.DarkOrchid;
            this.linkLabelQuerry2.Location = new System.Drawing.Point(219, 71);
            this.linkLabelQuerry2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelQuerry2.Name = "linkLabelQuerry2";
            this.linkLabelQuerry2.Size = new System.Drawing.Size(87, 23);
            this.linkLabelQuerry2.TabIndex = 7;
            this.linkLabelQuerry2.TabStop = true;
            this.linkLabelQuerry2.Text = "Запрос 2";
            this.linkLabelQuerry2.Visible = false;
            // 
            // linkLabelQuerry3
            // 
            this.linkLabelQuerry3.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabelQuerry3.AutoSize = true;
            this.linkLabelQuerry3.LinkColor = System.Drawing.Color.DarkOrchid;
            this.linkLabelQuerry3.Location = new System.Drawing.Point(219, 106);
            this.linkLabelQuerry3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelQuerry3.Name = "linkLabelQuerry3";
            this.linkLabelQuerry3.Size = new System.Drawing.Size(87, 23);
            this.linkLabelQuerry3.TabIndex = 8;
            this.linkLabelQuerry3.TabStop = true;
            this.linkLabelQuerry3.Text = "Запрос 3";
            this.linkLabelQuerry3.Visible = false;
            // 
            // linkLabelQuerry4
            // 
            this.linkLabelQuerry4.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabelQuerry4.AutoSize = true;
            this.linkLabelQuerry4.LinkColor = System.Drawing.Color.DarkOrchid;
            this.linkLabelQuerry4.Location = new System.Drawing.Point(219, 140);
            this.linkLabelQuerry4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelQuerry4.Name = "linkLabelQuerry4";
            this.linkLabelQuerry4.Size = new System.Drawing.Size(87, 23);
            this.linkLabelQuerry4.TabIndex = 9;
            this.linkLabelQuerry4.TabStop = true;
            this.linkLabelQuerry4.Text = "Запрос 4";
            this.linkLabelQuerry4.Visible = false;
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(924, 41);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(200, 30);
            this.comboBoxTables.TabIndex = 10;
            this.comboBoxTables.Visible = false;
            this.comboBoxTables.SelectedIndexChanged += new System.EventHandler(this.comboBoxTables_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(920, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Таблица:";
            this.label1.Visible = false;
            // 
            // labelogin
            // 
            this.labelogin.AutoSize = true;
            this.labelogin.Location = new System.Drawing.Point(27, 10);
            this.labelogin.Name = "labelogin";
            this.labelogin.Size = new System.Drawing.Size(63, 23);
            this.labelogin.TabIndex = 12;
            this.labelogin.Text = "Логин";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(27, 78);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(75, 23);
            this.labelPass.TabIndex = 13;
            this.labelPass.Text = "Пароль";
            // 
            // tBoxLogin
            // 
            this.tBoxLogin.Location = new System.Drawing.Point(27, 41);
            this.tBoxLogin.Name = "tBoxLogin";
            this.tBoxLogin.Size = new System.Drawing.Size(162, 29);
            this.tBoxLogin.TabIndex = 14;
            // 
            // tBoxPass
            // 
            this.tBoxPass.Location = new System.Drawing.Point(27, 109);
            this.tBoxPass.Name = "tBoxPass";
            this.tBoxPass.PasswordChar = '*';
            this.tBoxPass.Size = new System.Drawing.Size(162, 29);
            this.tBoxPass.TabIndex = 15;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 226);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1112, 490);
            this.dataGridView2.TabIndex = 16;
            this.dataGridView2.Visible = false;
            // 
            // linkLabelShowMagazine
            // 
            this.linkLabelShowMagazine.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabelShowMagazine.AutoSize = true;
            this.linkLabelShowMagazine.LinkColor = System.Drawing.Color.DarkOrchid;
            this.linkLabelShowMagazine.Location = new System.Drawing.Point(219, 71);
            this.linkLabelShowMagazine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelShowMagazine.Name = "linkLabelShowMagazine";
            this.linkLabelShowMagazine.Size = new System.Drawing.Size(266, 23);
            this.linkLabelShowMagazine.TabIndex = 18;
            this.linkLabelShowMagazine.TabStop = true;
            this.linkLabelShowMagazine.Text = "Показать журнал посещений";
            this.linkLabelShowMagazine.Visible = false;
            // 
            // linkLabelReg
            // 
            this.linkLabelReg.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabelReg.AutoSize = true;
            this.linkLabelReg.LinkColor = System.Drawing.Color.DarkOrchid;
            this.linkLabelReg.Location = new System.Drawing.Point(219, 37);
            this.linkLabelReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelReg.Name = "linkLabelReg";
            this.linkLabelReg.Size = new System.Drawing.Size(362, 23);
            this.linkLabelReg.TabIndex = 19;
            this.linkLabelReg.TabStop = true;
            this.linkLabelReg.Text = "Зарегистрировать нового пользователя";
            this.linkLabelReg.Visible = false;
            this.linkLabelReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelReg_LinkClicked);
            // 
            // buttonReg
            // 
            this.buttonReg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonReg.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReg.Location = new System.Drawing.Point(663, 186);
            this.buttonReg.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(192, 32);
            this.buttonReg.TabIndex = 20;
            this.buttonReg.Text = "Зарегистрировать";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Visible = false;
            this.buttonReg.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPassForReg
            // 
            this.textBoxPassForReg.Location = new System.Drawing.Point(663, 89);
            this.textBoxPassForReg.Name = "textBoxPassForReg";
            this.textBoxPassForReg.Size = new System.Drawing.Size(192, 29);
            this.textBoxPassForReg.TabIndex = 24;
            this.textBoxPassForReg.Visible = false;
            // 
            // textBoxLoginForReg
            // 
            this.textBoxLoginForReg.Location = new System.Drawing.Point(663, 29);
            this.textBoxLoginForReg.Name = "textBoxLoginForReg";
            this.textBoxLoginForReg.Size = new System.Drawing.Size(192, 29);
            this.textBoxLoginForReg.TabIndex = 23;
            this.textBoxLoginForReg.Visible = false;
            // 
            // labelPassForReg
            // 
            this.labelPassForReg.AutoSize = true;
            this.labelPassForReg.Location = new System.Drawing.Point(659, 62);
            this.labelPassForReg.Name = "labelPassForReg";
            this.labelPassForReg.Size = new System.Drawing.Size(75, 23);
            this.labelPassForReg.TabIndex = 22;
            this.labelPassForReg.Text = "Пароль";
            this.labelPassForReg.Visible = false;
            // 
            // labelLoginForReg
            // 
            this.labelLoginForReg.AutoSize = true;
            this.labelLoginForReg.Location = new System.Drawing.Point(659, 2);
            this.labelLoginForReg.Name = "labelLoginForReg";
            this.labelLoginForReg.Size = new System.Drawing.Size(63, 23);
            this.labelLoginForReg.TabIndex = 21;
            this.labelLoginForReg.Text = "Логин";
            this.labelLoginForReg.Visible = false;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(659, 122);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(58, 23);
            this.labelRole.TabIndex = 26;
            this.labelRole.Text = "Роль:";
            this.labelRole.Visible = false;
            // 
            // cBoxRoles
            // 
            this.cBoxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxRoles.FormattingEnabled = true;
            this.cBoxRoles.Location = new System.Drawing.Point(663, 149);
            this.cBoxRoles.Name = "cBoxRoles";
            this.cBoxRoles.Size = new System.Drawing.Size(200, 30);
            this.cBoxRoles.TabIndex = 25;
            this.cBoxRoles.Visible = false;
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(27, 147);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(162, 32);
            this.buttonExit.TabIndex = 27;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Visible = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1146, 729);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.cBoxRoles);
            this.Controls.Add(this.textBoxPassForReg);
            this.Controls.Add(this.textBoxLoginForReg);
            this.Controls.Add(this.labelPassForReg);
            this.Controls.Add(this.labelLoginForReg);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.tBoxPass);
            this.Controls.Add(this.tBoxLogin);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.linkLabelQuerry4);
            this.Controls.Add(this.linkLabelQuerry3);
            this.Controls.Add(this.linkLabelQuerry2);
            this.Controls.Add(this.linkLabelQuerry1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.linkLabelShowMagazine);
            this.Controls.Add(this.linkLabelReg);
            this.Controls.Add(this.buttonExit);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Курсовая \"\"";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.LinkLabel linkLabelQuerry1;
        private System.Windows.Forms.LinkLabel linkLabelQuerry2;
        private System.Windows.Forms.LinkLabel linkLabelQuerry3;
        private System.Windows.Forms.LinkLabel linkLabelQuerry4;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox tBoxLogin;
        private System.Windows.Forms.TextBox tBoxPass;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel linkLabelShowMagazine;
        private System.Windows.Forms.LinkLabel linkLabelReg;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox textBoxPassForReg;
        private System.Windows.Forms.TextBox textBoxLoginForReg;
        private System.Windows.Forms.Label labelPassForReg;
        private System.Windows.Forms.Label labelLoginForReg;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.ComboBox cBoxRoles;
        private System.Windows.Forms.Button buttonExit;
    }
}

