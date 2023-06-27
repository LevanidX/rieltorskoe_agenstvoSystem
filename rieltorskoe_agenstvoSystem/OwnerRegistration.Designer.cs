namespace rieltorskoe_agenstvoSystem
{
    partial class OwnerRegistration
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
            System.Windows.Forms.Label customer_phone_numberLabel;
            System.Windows.Forms.Label customer_nameLabel;
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.customer_phone_numberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ownersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rieltorskoe_agenstvoDataSet = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSet();
            this.customer_nameTextBox = new System.Windows.Forms.TextBox();
            this.ownersTableAdapter = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.ownersTableAdapter();
            this.tableAdapterManager = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.TableAdapterManager();
            customer_phone_numberLabel = new System.Windows.Forms.Label();
            customer_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorskoe_agenstvoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_phone_numberLabel
            // 
            customer_phone_numberLabel.AutoSize = true;
            customer_phone_numberLabel.Location = new System.Drawing.Point(13, 59);
            customer_phone_numberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customer_phone_numberLabel.Name = "customer_phone_numberLabel";
            customer_phone_numberLabel.Size = new System.Drawing.Size(143, 29);
            customer_phone_numberLabel.TabIndex = 9;
            customer_phone_numberLabel.Text = "Номер телефона";
            // 
            // customer_nameLabel
            // 
            customer_nameLabel.AutoSize = true;
            customer_nameLabel.Location = new System.Drawing.Point(13, 9);
            customer_nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customer_nameLabel.Name = "customer_nameLabel";
            customer_nameLabel.Size = new System.Drawing.Size(139, 29);
            customer_nameLabel.TabIndex = 7;
            customer_nameLabel.Text = "ФИО владельца";
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.BackColor = System.Drawing.Color.Red;
            this.btnBackToMainMenu.Location = new System.Drawing.Point(18, 225);
            this.btnBackToMainMenu.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(416, 60);
            this.btnBackToMainMenu.TabIndex = 12;
            this.btnBackToMainMenu.Text = "Вернуться в главное меню";
            this.btnBackToMainMenu.UseVisualStyleBackColor = false;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.Location = new System.Drawing.Point(18, 106);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(416, 105);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Зарегистрировать";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // customer_phone_numberTextBox
            // 
            this.customer_phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ownersBindingSource, "owner_phone_number", true));
            this.customer_phone_numberTextBox.Location = new System.Drawing.Point(164, 56);
            this.customer_phone_numberTextBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.customer_phone_numberTextBox.Mask = "+7 (999) 000-00-00";
            this.customer_phone_numberTextBox.Name = "customer_phone_numberTextBox";
            this.customer_phone_numberTextBox.Size = new System.Drawing.Size(270, 36);
            this.customer_phone_numberTextBox.TabIndex = 10;
            // 
            // ownersBindingSource
            // 
            this.ownersBindingSource.DataMember = "owners";
            this.ownersBindingSource.DataSource = this.rieltorskoe_agenstvoDataSet;
            // 
            // rieltorskoe_agenstvoDataSet
            // 
            this.rieltorskoe_agenstvoDataSet.DataSetName = "rieltorskoe_agenstvoDataSet";
            this.rieltorskoe_agenstvoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customer_nameTextBox
            // 
            this.customer_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ownersBindingSource, "owner_name", true));
            this.customer_nameTextBox.Location = new System.Drawing.Point(160, 6);
            this.customer_nameTextBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.customer_nameTextBox.Name = "customer_nameTextBox";
            this.customer_nameTextBox.Size = new System.Drawing.Size(274, 36);
            this.customer_nameTextBox.TabIndex = 8;
            // 
            // ownersTableAdapter
            // 
            this.ownersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.ownersTableAdapter = this.ownersTableAdapter;
            this.tableAdapterManager.propertiesTableAdapter = null;
            this.tableAdapterManager.property_typesTableAdapter = null;
            this.tableAdapterManager.rented_propertiesTableAdapter = null;
            this.tableAdapterManager.statesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // OwnerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(452, 299);
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
            this.Name = "OwnerRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация владельца";
            this.Load += new System.EventHandler(this.OwnerRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorskoe_agenstvoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.MaskedTextBox customer_phone_numberTextBox;
        private System.Windows.Forms.TextBox customer_nameTextBox;
        private rieltorskoe_agenstvoDataSet rieltorskoe_agenstvoDataSet;
        private System.Windows.Forms.BindingSource ownersBindingSource;
        private rieltorskoe_agenstvoDataSetTableAdapters.ownersTableAdapter ownersTableAdapter;
        private rieltorskoe_agenstvoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}