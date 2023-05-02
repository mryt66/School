namespace FormularzPracownicy.View
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

 
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_form = new System.Windows.Forms.GroupBox();
            this.radiobutton_3 = new System.Windows.Forms.RadioButton();
            this.radiobutton_2 = new System.Windows.Forms.RadioButton();
            this.radiobutton_1 = new System.Windows.Forms.RadioButton();
            this.label_contract = new System.Windows.Forms.Label();
            this.combobox_position = new System.Windows.Forms.ComboBox();
            this.label_position = new System.Windows.Forms.Label();
            this.numeric_salary = new System.Windows.Forms.NumericUpDown();
            this.label_money = new System.Windows.Forms.Label();
            this.datepicker_birthdate = new System.Windows.Forms.DateTimePicker();
            this.label_birthday = new System.Windows.Forms.Label();
            this.textbox_surname = new System.Windows.Forms.TextBox();
            this.label_surname = new System.Windows.Forms.Label();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.listbox_out = new System.Windows.Forms.ListBox();
            this.button_serialize = new System.Windows.Forms.Button();
            this.button_deserialize = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorProvider_name = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_surname = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_salary)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_surname)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_form
            // 
            this.groupBox_form.Controls.Add(this.radiobutton_3);
            this.groupBox_form.Controls.Add(this.radiobutton_2);
            this.groupBox_form.Controls.Add(this.radiobutton_1);
            this.groupBox_form.Controls.Add(this.label_contract);
            this.groupBox_form.Controls.Add(this.combobox_position);
            this.groupBox_form.Controls.Add(this.label_position);
            this.groupBox_form.Controls.Add(this.numeric_salary);
            this.groupBox_form.Controls.Add(this.label_money);
            this.groupBox_form.Controls.Add(this.datepicker_birthdate);
            this.groupBox_form.Controls.Add(this.label_birthday);
            this.groupBox_form.Controls.Add(this.textbox_surname);
            this.groupBox_form.Controls.Add(this.label_surname);
            this.groupBox_form.Controls.Add(this.textbox_name);
            this.groupBox_form.Controls.Add(this.label_name);
            this.groupBox_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_form.Location = new System.Drawing.Point(13, 12);
            this.groupBox_form.Name = "groupBox_form";
            this.groupBox_form.Size = new System.Drawing.Size(303, 273);
            this.groupBox_form.TabIndex = 0;
            this.groupBox_form.TabStop = false;
            this.groupBox_form.Enter += new System.EventHandler(this.groupBox_form_Enter);
            // 
            // radiobutton_3
            // 
            this.radiobutton_3.AutoSize = true;
            this.radiobutton_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radiobutton_3.Location = new System.Drawing.Point(116, 219);
            this.radiobutton_3.Name = "radiobutton_3";
            this.radiobutton_3.Size = new System.Drawing.Size(140, 24);
            this.radiobutton_3.TabIndex = 14;
            this.radiobutton_3.Text = "umowa zlecenie";
            this.radiobutton_3.UseVisualStyleBackColor = true;
            this.radiobutton_3.Click += new System.EventHandler(this.send_contract);
            // 
            // radiobutton_2
            // 
            this.radiobutton_2.AutoSize = true;
            this.radiobutton_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radiobutton_2.Location = new System.Drawing.Point(116, 193);
            this.radiobutton_2.Name = "radiobutton_2";
            this.radiobutton_2.Size = new System.Drawing.Size(58, 24);
            this.radiobutton_2.TabIndex = 13;
            this.radiobutton_2.Text = "B2B";
            this.radiobutton_2.UseVisualStyleBackColor = true;
            this.radiobutton_2.Click += new System.EventHandler(this.send_contract);
            // 
            // radiobutton_1
            // 
            this.radiobutton_1.AutoSize = true;
            this.radiobutton_1.Checked = true;
            this.radiobutton_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radiobutton_1.Location = new System.Drawing.Point(116, 167);
            this.radiobutton_1.Name = "radiobutton_1";
            this.radiobutton_1.Size = new System.Drawing.Size(135, 24);
            this.radiobutton_1.TabIndex = 12;
            this.radiobutton_1.TabStop = true;
            this.radiobutton_1.Text = "umowa o pracę";
            this.radiobutton_1.UseVisualStyleBackColor = true;
            this.radiobutton_1.CheckedChanged += new System.EventHandler(this.radiobutton_1_CheckedChanged);
            this.radiobutton_1.Click += new System.EventHandler(this.send_contract);
            // 
            // label_contract
            // 
            this.label_contract.AutoSize = true;
            this.label_contract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_contract.Location = new System.Drawing.Point(3, 167);
            this.label_contract.Name = "label_contract";
            this.label_contract.Size = new System.Drawing.Size(116, 20);
            this.label_contract.TabIndex = 11;
            this.label_contract.Text = "Rodzaj umowy:";
            // 
            // combobox_position
            // 
            this.combobox_position.FormattingEnabled = true;
            this.combobox_position.Items.AddRange(new object[] {
            "Lekarz",
            "Fizyk",
            "Akrobata",
            "Malarz",
            "Tester"});
            this.combobox_position.Location = new System.Drawing.Point(125, 136);
            this.combobox_position.Name = "combobox_position";
            this.combobox_position.Size = new System.Drawing.Size(128, 28);
            this.combobox_position.TabIndex = 10;
            this.combobox_position.SelectedIndexChanged += new System.EventHandler(this.combobox_position_SelectedIndexChanged);
            this.combobox_position.TextChanged += new System.EventHandler(this.send_position);
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_position.Location = new System.Drawing.Point(3, 136);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(95, 20);
            this.label_position.TabIndex = 9;
            this.label_position.Text = "Stanowisko:";
            // 
            // numeric_salary
            // 
            this.numeric_salary.Location = new System.Drawing.Point(125, 108);
            this.numeric_salary.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.numeric_salary.Name = "numeric_salary";
            this.numeric_salary.Size = new System.Drawing.Size(128, 26);
            this.numeric_salary.TabIndex = 8;
            this.numeric_salary.Value = new decimal(new int[] {
            3500,
            0,
            0,
            0});
            this.numeric_salary.ValueChanged += new System.EventHandler(this.send_salary);
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_money.Location = new System.Drawing.Point(3, 108);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(61, 20);
            this.label_money.TabIndex = 7;
            this.label_money.Text = "Pensja:";
            // 
            // datepicker_birthdate
            // 
            this.datepicker_birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_birthdate.Location = new System.Drawing.Point(125, 77);
            this.datepicker_birthdate.Name = "datepicker_birthdate";
            this.datepicker_birthdate.Size = new System.Drawing.Size(128, 26);
            this.datepicker_birthdate.TabIndex = 6;
            this.datepicker_birthdate.ValueChanged += new System.EventHandler(this.send_date);
            // 
            // label_birthday
            // 
            this.label_birthday.AutoSize = true;
            this.label_birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_birthday.Location = new System.Drawing.Point(3, 80);
            this.label_birthday.Name = "label_birthday";
            this.label_birthday.Size = new System.Drawing.Size(125, 20);
            this.label_birthday.TabIndex = 5;
            this.label_birthday.Text = "Data Urodzenia:";
            // 
            // textbox_surname
            // 
            this.textbox_surname.Location = new System.Drawing.Point(125, 52);
            this.textbox_surname.Name = "textbox_surname";
            this.textbox_surname.Size = new System.Drawing.Size(128, 26);
            this.textbox_surname.TabIndex = 3;
            this.textbox_surname.TextChanged += new System.EventHandler(this.send_surname);
            this.textbox_surname.Validating += new System.ComponentModel.CancelEventHandler(this.text_surname_Validating);
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_surname.Location = new System.Drawing.Point(3, 55);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(80, 20);
            this.label_surname.TabIndex = 2;
            this.label_surname.Text = "Nazwisko:";
            // 
            // textbox_name
            // 
            this.textbox_name.Location = new System.Drawing.Point(125, 27);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(128, 26);
            this.textbox_name.TabIndex = 1;
            this.textbox_name.TextChanged += new System.EventHandler(this.send_name);
            this.textbox_name.Validating += new System.ComponentModel.CancelEventHandler(this.text_name_Validating);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_name.Location = new System.Drawing.Point(3, 33);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(43, 20);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Imię:";
            // 
            // button_dodaj
            // 
            this.button_dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_dodaj.Location = new System.Drawing.Point(79, 9);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(142, 35);
            this.button_dodaj.TabIndex = 15;
            this.button_dodaj.Text = "Dodaj";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.add_person);
            // 
            // listbox_out
            // 
            this.listbox_out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listbox_out.FormattingEnabled = true;
            this.listbox_out.HorizontalExtent = 1000;
            this.listbox_out.HorizontalScrollbar = true;
            this.listbox_out.ItemHeight = 20;
            this.listbox_out.Location = new System.Drawing.Point(313, 15);
            this.listbox_out.Name = "listbox_out";
            this.listbox_out.ScrollAlwaysVisible = true;
            this.listbox_out.Size = new System.Drawing.Size(873, 384);
            this.listbox_out.TabIndex = 1;
            this.listbox_out.SelectedIndexChanged += new System.EventHandler(this.on_employee_select);
            // 
            // button_serialize
            // 
            this.button_serialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_serialize.Location = new System.Drawing.Point(79, 50);
            this.button_serialize.Name = "button_serialize";
            this.button_serialize.Size = new System.Drawing.Size(141, 36);
            this.button_serialize.TabIndex = 2;
            this.button_serialize.Text = "Zapisz";
            this.button_serialize.UseVisualStyleBackColor = true;
            this.button_serialize.Click += new System.EventHandler(this.serialize_list);
            // 
            // button_deserialize
            // 
            this.button_deserialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_deserialize.Location = new System.Drawing.Point(78, 89);
            this.button_deserialize.Name = "button_deserialize";
            this.button_deserialize.Size = new System.Drawing.Size(142, 36);
            this.button_deserialize.TabIndex = 3;
            this.button_deserialize.Text = "Wczytaj";
            this.button_deserialize.UseVisualStyleBackColor = true;
            this.button_deserialize.Click += new System.EventHandler(this.deserialize_list);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_dodaj);
            this.groupBox1.Controls.Add(this.button_serialize);
            this.groupBox1.Controls.Add(this.button_deserialize);
            this.groupBox1.Location = new System.Drawing.Point(13, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 131);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // errorProvider_name
            // 
            this.errorProvider_name.ContainerControl = this;
            // 
            // errorProvider_surname
            // 
            this.errorProvider_surname.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 434);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listbox_out);
            this.Controls.Add(this.groupBox_form);
            this.Name = "Form1";
            this.Text = "Formularz Pracownicy";
            this.groupBox_form.ResumeLayout(false);
            this.groupBox_form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_salary)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_surname)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_form;
        private System.Windows.Forms.ListBox listbox_out;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.RadioButton radiobutton_3;
        private System.Windows.Forms.RadioButton radiobutton_2;
        private System.Windows.Forms.RadioButton radiobutton_1;
        private System.Windows.Forms.Label label_contract;
        private System.Windows.Forms.ComboBox combobox_position;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.NumericUpDown numeric_salary;
        private System.Windows.Forms.Label label_money;
        private System.Windows.Forms.DateTimePicker datepicker_birthdate;
        private System.Windows.Forms.Label label_birthday;
        private System.Windows.Forms.TextBox textbox_surname;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_serialize;
        private System.Windows.Forms.Button button_deserialize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider_name;
        private System.Windows.Forms.ErrorProvider errorProvider_surname;

    }
}

