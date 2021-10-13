
namespace FormUi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbx_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbx_Surname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbx_Patronymic = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtbx_Address = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbx_ZipCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbx_City = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbbx_Country = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbx_PhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.rdbtn_Male = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbtn_Female = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbtn_Other = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dtpckr_Birthdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SaveButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.LoadButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.FillColor = System.Drawing.Color.Transparent;
            this.btn_exit.HoverState.Parent = this.btn_exit;
            this.btn_exit.IconColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(338, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ShadowDecoration.Parent = this.btn_exit;
            this.btn_exit.Size = new System.Drawing.Size(30, 30);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.MouseEnter += new System.EventHandler(this.btn_exit_MouseEnter);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(10, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(10, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.label3.Location = new System.Drawing.Point(10, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Patronymic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.label4.Location = new System.Drawing.Point(12, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.label6.Location = new System.Drawing.Point(10, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Zip Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.label7.Location = new System.Drawing.Point(10, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.label8.Location = new System.Drawing.Point(110, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "City";
            // 
            // txtbx_Name
            // 
            this.txtbx_Name.Animated = true;
            this.txtbx_Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.txtbx_Name.BorderRadius = 2;
            this.txtbx_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_Name.DefaultText = "";
            this.txtbx_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_Name.DisabledState.Parent = this.txtbx_Name;
            this.txtbx_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_Name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.txtbx_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_Name.FocusedState.Parent = this.txtbx_Name;
            this.txtbx_Name.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtbx_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_Name.HoverState.Parent = this.txtbx_Name;
            this.txtbx_Name.Location = new System.Drawing.Point(10, 80);
            this.txtbx_Name.MaxLength = 32;
            this.txtbx_Name.Name = "txtbx_Name";
            this.txtbx_Name.PasswordChar = '\0';
            this.txtbx_Name.PlaceholderText = "";
            this.txtbx_Name.SelectedText = "";
            this.txtbx_Name.ShadowDecoration.Parent = this.txtbx_Name;
            this.txtbx_Name.Size = new System.Drawing.Size(360, 30);
            this.txtbx_Name.TabIndex = 9;
            // 
            // txtbx_Surname
            // 
            this.txtbx_Surname.Animated = true;
            this.txtbx_Surname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.txtbx_Surname.BorderRadius = 2;
            this.txtbx_Surname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_Surname.DefaultText = "";
            this.txtbx_Surname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_Surname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_Surname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_Surname.DisabledState.Parent = this.txtbx_Surname;
            this.txtbx_Surname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_Surname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.txtbx_Surname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_Surname.FocusedState.Parent = this.txtbx_Surname;
            this.txtbx_Surname.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtbx_Surname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_Surname.HoverState.Parent = this.txtbx_Surname;
            this.txtbx_Surname.Location = new System.Drawing.Point(10, 150);
            this.txtbx_Surname.MaxLength = 32;
            this.txtbx_Surname.Name = "txtbx_Surname";
            this.txtbx_Surname.PasswordChar = '\0';
            this.txtbx_Surname.PlaceholderText = "";
            this.txtbx_Surname.SelectedText = "";
            this.txtbx_Surname.ShadowDecoration.Parent = this.txtbx_Surname;
            this.txtbx_Surname.Size = new System.Drawing.Size(360, 30);
            this.txtbx_Surname.TabIndex = 11;
            // 
            // txtbx_Patronymic
            // 
            this.txtbx_Patronymic.Animated = true;
            this.txtbx_Patronymic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.txtbx_Patronymic.BorderRadius = 2;
            this.txtbx_Patronymic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_Patronymic.DefaultText = "";
            this.txtbx_Patronymic.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_Patronymic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_Patronymic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_Patronymic.DisabledState.Parent = this.txtbx_Patronymic;
            this.txtbx_Patronymic.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_Patronymic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.txtbx_Patronymic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_Patronymic.FocusedState.Parent = this.txtbx_Patronymic;
            this.txtbx_Patronymic.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtbx_Patronymic.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_Patronymic.HoverState.Parent = this.txtbx_Patronymic;
            this.txtbx_Patronymic.Location = new System.Drawing.Point(10, 220);
            this.txtbx_Patronymic.MaxLength = 32;
            this.txtbx_Patronymic.Name = "txtbx_Patronymic";
            this.txtbx_Patronymic.PasswordChar = '\0';
            this.txtbx_Patronymic.PlaceholderText = "";
            this.txtbx_Patronymic.SelectedText = "";
            this.txtbx_Patronymic.ShadowDecoration.Parent = this.txtbx_Patronymic;
            this.txtbx_Patronymic.Size = new System.Drawing.Size(360, 30);
            this.txtbx_Patronymic.TabIndex = 12;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.guna2Separator1.Location = new System.Drawing.Point(10, 270);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(360, 10);
            this.guna2Separator1.TabIndex = 13;
            // 
            // txtbx_Address
            // 
            this.txtbx_Address.Animated = true;
            this.txtbx_Address.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.txtbx_Address.BorderRadius = 2;
            this.txtbx_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_Address.DefaultText = "";
            this.txtbx_Address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_Address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_Address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_Address.DisabledState.Parent = this.txtbx_Address;
            this.txtbx_Address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_Address.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.txtbx_Address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_Address.FocusedState.Parent = this.txtbx_Address;
            this.txtbx_Address.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtbx_Address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_Address.HoverState.Parent = this.txtbx_Address;
            this.txtbx_Address.Location = new System.Drawing.Point(10, 310);
            this.txtbx_Address.MaxLength = 64;
            this.txtbx_Address.Name = "txtbx_Address";
            this.txtbx_Address.PasswordChar = '\0';
            this.txtbx_Address.PlaceholderText = "";
            this.txtbx_Address.SelectedText = "";
            this.txtbx_Address.ShadowDecoration.Parent = this.txtbx_Address;
            this.txtbx_Address.Size = new System.Drawing.Size(360, 30);
            this.txtbx_Address.TabIndex = 14;
            // 
            // txtbx_ZipCode
            // 
            this.txtbx_ZipCode.Animated = true;
            this.txtbx_ZipCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.txtbx_ZipCode.BorderRadius = 2;
            this.txtbx_ZipCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_ZipCode.DefaultText = "";
            this.txtbx_ZipCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_ZipCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_ZipCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_ZipCode.DisabledState.Parent = this.txtbx_ZipCode;
            this.txtbx_ZipCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_ZipCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.txtbx_ZipCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_ZipCode.FocusedState.Parent = this.txtbx_ZipCode;
            this.txtbx_ZipCode.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtbx_ZipCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_ZipCode.HoverState.Parent = this.txtbx_ZipCode;
            this.txtbx_ZipCode.Location = new System.Drawing.Point(10, 380);
            this.txtbx_ZipCode.MaxLength = 6;
            this.txtbx_ZipCode.Name = "txtbx_ZipCode";
            this.txtbx_ZipCode.PasswordChar = '\0';
            this.txtbx_ZipCode.PlaceholderText = "";
            this.txtbx_ZipCode.SelectedText = "";
            this.txtbx_ZipCode.ShadowDecoration.Parent = this.txtbx_ZipCode;
            this.txtbx_ZipCode.Size = new System.Drawing.Size(90, 30);
            this.txtbx_ZipCode.TabIndex = 15;
            // 
            // txtbx_City
            // 
            this.txtbx_City.Animated = true;
            this.txtbx_City.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.txtbx_City.BorderRadius = 2;
            this.txtbx_City.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_City.DefaultText = "";
            this.txtbx_City.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_City.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_City.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_City.DisabledState.Parent = this.txtbx_City;
            this.txtbx_City.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_City.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.txtbx_City.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_City.FocusedState.Parent = this.txtbx_City;
            this.txtbx_City.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtbx_City.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_City.HoverState.Parent = this.txtbx_City;
            this.txtbx_City.Location = new System.Drawing.Point(110, 380);
            this.txtbx_City.MaxLength = 32;
            this.txtbx_City.Name = "txtbx_City";
            this.txtbx_City.PasswordChar = '\0';
            this.txtbx_City.PlaceholderText = "";
            this.txtbx_City.SelectedText = "";
            this.txtbx_City.ShadowDecoration.Parent = this.txtbx_City;
            this.txtbx_City.Size = new System.Drawing.Size(260, 30);
            this.txtbx_City.TabIndex = 16;
            // 
            // cmbbx_Country
            // 
            this.cmbbx_Country.BackColor = System.Drawing.Color.Transparent;
            this.cmbbx_Country.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.cmbbx_Country.BorderRadius = 2;
            this.cmbbx_Country.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbbx_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_Country.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.cmbbx_Country.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbbx_Country.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbbx_Country.FocusedState.Parent = this.cmbbx_Country;
            this.cmbbx_Country.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbbx_Country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbbx_Country.HoverState.Parent = this.cmbbx_Country;
            this.cmbbx_Country.ItemHeight = 30;
            this.cmbbx_Country.ItemsAppearance.Parent = this.cmbbx_Country;
            this.cmbbx_Country.Location = new System.Drawing.Point(10, 450);
            this.cmbbx_Country.Name = "cmbbx_Country";
            this.cmbbx_Country.ShadowDecoration.Parent = this.cmbbx_Country;
            this.cmbbx_Country.Size = new System.Drawing.Size(180, 36);
            this.cmbbx_Country.TabIndex = 17;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.guna2Separator2.Location = new System.Drawing.Point(10, 506);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(360, 10);
            this.guna2Separator2.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.label5.Location = new System.Drawing.Point(10, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Phone Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.label9.Location = new System.Drawing.Point(10, 656);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Birth Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.label10.Location = new System.Drawing.Point(10, 596);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Gender/Sex";
            // 
            // txtbx_PhoneNumber
            // 
            this.txtbx_PhoneNumber.Animated = true;
            this.txtbx_PhoneNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.txtbx_PhoneNumber.BorderRadius = 2;
            this.txtbx_PhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_PhoneNumber.DefaultText = "";
            this.txtbx_PhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_PhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_PhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_PhoneNumber.DisabledState.Parent = this.txtbx_PhoneNumber;
            this.txtbx_PhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_PhoneNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.txtbx_PhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_PhoneNumber.FocusedState.Parent = this.txtbx_PhoneNumber;
            this.txtbx_PhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtbx_PhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_PhoneNumber.HoverState.Parent = this.txtbx_PhoneNumber;
            this.txtbx_PhoneNumber.Location = new System.Drawing.Point(10, 546);
            this.txtbx_PhoneNumber.MaxLength = 32;
            this.txtbx_PhoneNumber.Name = "txtbx_PhoneNumber";
            this.txtbx_PhoneNumber.PasswordChar = '\0';
            this.txtbx_PhoneNumber.PlaceholderText = "";
            this.txtbx_PhoneNumber.SelectedText = "";
            this.txtbx_PhoneNumber.ShadowDecoration.Parent = this.txtbx_PhoneNumber;
            this.txtbx_PhoneNumber.Size = new System.Drawing.Size(360, 30);
            this.txtbx_PhoneNumber.TabIndex = 22;
            // 
            // rdbtn_Male
            // 
            this.rdbtn_Male.AutoSize = true;
            this.rdbtn_Male.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.rdbtn_Male.CheckedState.BorderThickness = 0;
            this.rdbtn_Male.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.rdbtn_Male.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.rdbtn_Male.CheckedState.InnerOffset = -4;
            this.rdbtn_Male.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.rdbtn_Male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.rdbtn_Male.Location = new System.Drawing.Point(10, 616);
            this.rdbtn_Male.Name = "rdbtn_Male";
            this.rdbtn_Male.Size = new System.Drawing.Size(52, 20);
            this.rdbtn_Male.TabIndex = 23;
            this.rdbtn_Male.Text = "Male";
            this.rdbtn_Male.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbtn_Male.UncheckedState.BorderThickness = 2;
            this.rdbtn_Male.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbtn_Male.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdbtn_Female
            // 
            this.rdbtn_Female.AutoSize = true;
            this.rdbtn_Female.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.rdbtn_Female.CheckedState.BorderThickness = 0;
            this.rdbtn_Female.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.rdbtn_Female.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.rdbtn_Female.CheckedState.InnerOffset = -4;
            this.rdbtn_Female.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.rdbtn_Female.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.rdbtn_Female.Location = new System.Drawing.Point(80, 616);
            this.rdbtn_Female.Name = "rdbtn_Female";
            this.rdbtn_Female.Size = new System.Drawing.Size(64, 20);
            this.rdbtn_Female.TabIndex = 24;
            this.rdbtn_Female.Text = "Female";
            this.rdbtn_Female.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbtn_Female.UncheckedState.BorderThickness = 2;
            this.rdbtn_Female.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbtn_Female.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdbtn_Other
            // 
            this.rdbtn_Other.AutoSize = true;
            this.rdbtn_Other.Checked = true;
            this.rdbtn_Other.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.rdbtn_Other.CheckedState.BorderThickness = 0;
            this.rdbtn_Other.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.rdbtn_Other.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.rdbtn_Other.CheckedState.InnerOffset = -4;
            this.rdbtn_Other.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.rdbtn_Other.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.rdbtn_Other.Location = new System.Drawing.Point(172, 616);
            this.rdbtn_Other.Name = "rdbtn_Other";
            this.rdbtn_Other.Size = new System.Drawing.Size(58, 20);
            this.rdbtn_Other.TabIndex = 25;
            this.rdbtn_Other.TabStop = true;
            this.rdbtn_Other.Text = "Other";
            this.rdbtn_Other.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbtn_Other.UncheckedState.BorderThickness = 2;
            this.rdbtn_Other.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbtn_Other.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // dtpckr_Birthdate
            // 
            this.dtpckr_Birthdate.Animated = true;
            this.dtpckr_Birthdate.BackColor = System.Drawing.Color.Transparent;
            this.dtpckr_Birthdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.dtpckr_Birthdate.CheckedState.Parent = this.dtpckr_Birthdate;
            this.dtpckr_Birthdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.dtpckr_Birthdate.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpckr_Birthdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.dtpckr_Birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpckr_Birthdate.HoverState.Parent = this.dtpckr_Birthdate;
            this.dtpckr_Birthdate.Location = new System.Drawing.Point(10, 676);
            this.dtpckr_Birthdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpckr_Birthdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpckr_Birthdate.Name = "dtpckr_Birthdate";
            this.dtpckr_Birthdate.ShadowDecoration.Parent = this.dtpckr_Birthdate;
            this.dtpckr_Birthdate.Size = new System.Drawing.Size(200, 36);
            this.dtpckr_Birthdate.TabIndex = 26;
            this.dtpckr_Birthdate.Value = new System.DateTime(2021, 10, 12, 19, 52, 32, 812);
            // 
            // SaveButton
            // 
            this.SaveButton.Animated = true;
            this.SaveButton.CheckedState.Parent = this.SaveButton;
            this.SaveButton.CustomImages.Parent = this.SaveButton;
            this.SaveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveButton.DisabledState.Parent = this.SaveButton;
            this.SaveButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
            this.SaveButton.FillColor2 = System.Drawing.Color.Lime;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.HoverState.Parent = this.SaveButton;
            this.SaveButton.Location = new System.Drawing.Point(10, 732);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.ShadowDecoration.Parent = this.SaveButton;
            this.SaveButton.Size = new System.Drawing.Size(150, 36);
            this.SaveButton.TabIndex = 29;
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Animated = true;
            this.LoadButton.CheckedState.Parent = this.LoadButton;
            this.LoadButton.CustomImages.Parent = this.LoadButton;
            this.LoadButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoadButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoadButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoadButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoadButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoadButton.DisabledState.Parent = this.LoadButton;
            this.LoadButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
            this.LoadButton.FillColor2 = System.Drawing.Color.Lime;
            this.LoadButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.LoadButton.ForeColor = System.Drawing.Color.White;
            this.LoadButton.HoverState.Parent = this.LoadButton;
            this.LoadButton.Location = new System.Drawing.Point(220, 732);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.ShadowDecoration.Parent = this.LoadButton;
            this.LoadButton.Size = new System.Drawing.Size(150, 36);
            this.LoadButton.TabIndex = 30;
            this.LoadButton.Text = "Load";
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(380, 788);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.dtpckr_Birthdate);
            this.Controls.Add(this.rdbtn_Other);
            this.Controls.Add(this.rdbtn_Female);
            this.Controls.Add(this.rdbtn_Male);
            this.Controls.Add(this.txtbx_PhoneNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.cmbbx_Country);
            this.Controls.Add(this.txtbx_City);
            this.Controls.Add(this.txtbx_ZipCode);
            this.Controls.Add(this.txtbx_Address);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.txtbx_Patronymic);
            this.Controls.Add(this.txtbx_Surname);
            this.Controls.Add(this.txtbx_Name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox btn_exit;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_Patronymic;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_Surname;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_City;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_ZipCode;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_Address;
        private Guna.UI2.WinForms.Guna2ComboBox cmbbx_Country;
        private Guna.UI2.WinForms.Guna2RadioButton rdbtn_Male;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_PhoneNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2RadioButton rdbtn_Other;
        private Guna.UI2.WinForms.Guna2RadioButton rdbtn_Female;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpckr_Birthdate;
        private Guna.UI2.WinForms.Guna2GradientButton SaveButton;
        private Guna.UI2.WinForms.Guna2GradientButton LoadButton;
    }
}

