namespace rieltorskoe_agenstvoSystem
{
    partial class CustomerRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customer_nameLabel;
            System.Windows.Forms.Label customer_phone_numberLabel;
            this.rieltorskoe_agenstvoDataSet = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.customersTableAdapter();
            this.tableAdapterManager = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.TableAdapterManager();
            this.customer_nameTextBox = new System.Windows.Forms.TextBox();
            this.customer_phone_numberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            customer_nameLabel = new System.Windows.Forms.Label();
            customer_phone_numberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorskoe_agenstvoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_nameLabel
            // 
            customer_nameLabel.AutoSize = true;
            customer_nameLabel.Location = new System.Drawing.Point(13, 9);
            customer_nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customer_nameLabel.Name = "customer_nameLabel";
            customer_nameLabel.Size = new System.Drawing.Size(118, 29);
            customer_nameLabel.TabIndex = 1;
            customer_nameLabel.Text = "ФИО клиента";
            // 
            // customer_phone_numberLabel
            // 
            customer_phone_numberLabel.AutoSize = true;
            customer_phone_numberLabel.Location = new System.Drawing.Point(13, 59);
            customer_phone_numberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customer_phone_numberLabel.Name = "customer_phone_numberLabel";
            customer_phone_numberLabel.Size = new System.Drawing.Size(143, 29);
            customer_phone_numberLabel.TabIndex = 3;
            customer_phone_numberLabel.Text = "Номер телефона";
            // 
            // rieltorskoe_agenstvoDataSet
            // 
            this.rieltorskoe_agenstvoDataSet.DataSetName = "rieltorskoe_agenstvoDataSet";
            this.rieltorskoe_agenstvoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.rieltorskoe_agenstvoDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.ownersTableAdapter = null;
            this.tableAdapterManager.propertiesTableAdapter = null;
            this.tableAdapterManager.property_typesTableAdapter = null;
            this.tableAdapterManager.rented_propertiesTableAdapter = null;
            this.tableAdapterManager.statesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customer_nameTextBox
            // 
            this.customer_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "customer_name", true));
            this.customer_nameTextBox.Location = new System.Drawing.Point(139, 6);
            this.customer_nameTextBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.customer_nameTextBox.Name = "customer_nameTextBox";
            this.customer_nameTextBox.Size = new System.Drawing.Size(294, 36);
            this.customer_nameTextBox.TabIndex = 2;
            // 
            // customer_phone_numberTextBox
            // 
            this.customer_phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "customer_phone_number", true));
            this.customer_phone_numberTextBox.Location = new System.Drawing.Point(164, 56);
            this.customer_phone_numberTextBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.customer_phone_numberTextBox.Mask = "+7 (999) 000-00-00";
            this.customer_phone_numberTextBox.Name = "customer_phone_numberTextBox";
            this.customer_phone_numberTextBox.Size = new System.Drawing.Size(269, 36);
            this.customer_phone_numberTextBox.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.Location = new System.Drawing.Point(18, 106);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(415, 105);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Зарегистрировать";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.BackColor = System.Drawing.Color.Red;
            this.btnBackToMainMenu.Location = new System.Drawing.Point(18, 225);
            this.btnBackToMainMenu.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(415, 60);
            this.btnBackToMainMenu.TabIndex = 6;
            this.btnBackToMainMenu.Text = "Вернуться в главное меню";
            this.btnBackToMainMenu.UseVisualStyleBackColor = false;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // CustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(454, 294);
            this.ControlBox = false;
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.customer_phone_numberTextBox);
            this.Controls.Add(customer_phone_numberLabel);
            this.Controls.Add(customer_nameLabel);
            this.Controls.Add(this.customer_nameTextBox);
            this.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "CustomerRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация клиента";
            this.Load += new System.EventHandler(this.CustomerRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rieltorskoe_agenstvoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private rieltorskoe_agenstvoDataSet rieltorskoe_agenstvoDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private rieltorskoe_agenstvoDataSetTableAdapters.customersTableAdapter customersTableAdapter;
        private rieltorskoe_agenstvoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox customer_nameTextBox;
        private System.Windows.Forms.MaskedTextBox customer_phone_numberTextBox;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBackToMainMenu;
    }
}