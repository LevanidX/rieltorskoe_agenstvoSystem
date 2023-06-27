namespace rieltorskoe_agenstvoSystem
{
    partial class PropertyAdding
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
            System.Windows.Forms.Label property_typeLabel;
            System.Windows.Forms.Label property_addressLabel;
            System.Windows.Forms.Label property_rooms_quantityLabel;
            System.Windows.Forms.Label property_ownerLabel;
            System.Windows.Forms.Label property_rent_priceLabel;
            this.rieltorskoe_agenstvoDataSet = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSet();
            this.propertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertiesTableAdapter = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.propertiesTableAdapter();
            this.tableAdapterManager = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.TableAdapterManager();
            this.ownersTableAdapter = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.ownersTableAdapter();
            this.property_typesTableAdapter = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.property_typesTableAdapter();
            this.statesTableAdapter = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.statesTableAdapter();
            this.property_addressTextBox = new System.Windows.Forms.TextBox();
            this.property_rooms_quantityTextBox = new System.Windows.Forms.TextBox();
            this.property_rent_priceTextBox = new System.Windows.Forms.TextBox();
            this.property_typeTextBox = new System.Windows.Forms.ComboBox();
            this.propertytypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.property_ownerTextBox = new System.Windows.Forms.ComboBox();
            this.ownersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.property_stateTextBox = new System.Windows.Forms.ComboBox();
            property_typeLabel = new System.Windows.Forms.Label();
            property_addressLabel = new System.Windows.Forms.Label();
            property_rooms_quantityLabel = new System.Windows.Forms.Label();
            property_ownerLabel = new System.Windows.Forms.Label();
            property_rent_priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorskoe_agenstvoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertytypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // property_typeLabel
            // 
            property_typeLabel.AutoSize = true;
            property_typeLabel.Location = new System.Drawing.Point(13, 9);
            property_typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            property_typeLabel.Name = "property_typeLabel";
            property_typeLabel.Size = new System.Drawing.Size(162, 29);
            property_typeLabel.TabIndex = 1;
            property_typeLabel.Text = "Тип недвижимости";
            // 
            // property_addressLabel
            // 
            property_addressLabel.AutoSize = true;
            property_addressLabel.Location = new System.Drawing.Point(13, 60);
            property_addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            property_addressLabel.Name = "property_addressLabel";
            property_addressLabel.Size = new System.Drawing.Size(63, 29);
            property_addressLabel.TabIndex = 2;
            property_addressLabel.Text = "Адрес";
            // 
            // property_rooms_quantityLabel
            // 
            property_rooms_quantityLabel.AutoSize = true;
            property_rooms_quantityLabel.Location = new System.Drawing.Point(13, 110);
            property_rooms_quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            property_rooms_quantityLabel.Name = "property_rooms_quantityLabel";
            property_rooms_quantityLabel.Size = new System.Drawing.Size(164, 29);
            property_rooms_quantityLabel.TabIndex = 4;
            property_rooms_quantityLabel.Text = "Количество комнат";
            // 
            // property_ownerLabel
            // 
            property_ownerLabel.AutoSize = true;
            property_ownerLabel.Location = new System.Drawing.Point(13, 160);
            property_ownerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            property_ownerLabel.Name = "property_ownerLabel";
            property_ownerLabel.Size = new System.Drawing.Size(89, 29);
            property_ownerLabel.TabIndex = 6;
            property_ownerLabel.Text = "Владелец";
            // 
            // property_rent_priceLabel
            // 
            property_rent_priceLabel.AutoSize = true;
            property_rent_priceLabel.Location = new System.Drawing.Point(13, 211);
            property_rent_priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            property_rent_priceLabel.Name = "property_rent_priceLabel";
            property_rent_priceLabel.Size = new System.Drawing.Size(160, 29);
            property_rent_priceLabel.TabIndex = 8;
            property_rent_priceLabel.Text = "Цена аренды/мес.";
            // 
            // rieltorskoe_agenstvoDataSet
            // 
            this.rieltorskoe_agenstvoDataSet.DataSetName = "rieltorskoe_agenstvoDataSet";
            this.rieltorskoe_agenstvoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propertiesBindingSource
            // 
            this.propertiesBindingSource.DataMember = "properties";
            this.propertiesBindingSource.DataSource = this.rieltorskoe_agenstvoDataSet;
            // 
            // propertiesTableAdapter
            // 
            this.propertiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.ownersTableAdapter = this.ownersTableAdapter;
            this.tableAdapterManager.propertiesTableAdapter = this.propertiesTableAdapter;
            this.tableAdapterManager.property_typesTableAdapter = this.property_typesTableAdapter;
            this.tableAdapterManager.rented_propertiesTableAdapter = null;
            this.tableAdapterManager.statesTableAdapter = this.statesTableAdapter;
            this.tableAdapterManager.UpdateOrder = rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ownersTableAdapter
            // 
            this.ownersTableAdapter.ClearBeforeFill = true;
            // 
            // property_typesTableAdapter
            // 
            this.property_typesTableAdapter.ClearBeforeFill = true;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // property_addressTextBox
            // 
            this.property_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertiesBindingSource, "property_address", true));
            this.property_addressTextBox.Location = new System.Drawing.Point(84, 57);
            this.property_addressTextBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.property_addressTextBox.Name = "property_addressTextBox";
            this.property_addressTextBox.Size = new System.Drawing.Size(405, 36);
            this.property_addressTextBox.TabIndex = 3;
            // 
            // property_rooms_quantityTextBox
            // 
            this.property_rooms_quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertiesBindingSource, "property_rooms_quantity", true));
            this.property_rooms_quantityTextBox.Location = new System.Drawing.Point(185, 107);
            this.property_rooms_quantityTextBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.property_rooms_quantityTextBox.Name = "property_rooms_quantityTextBox";
            this.property_rooms_quantityTextBox.Size = new System.Drawing.Size(54, 36);
            this.property_rooms_quantityTextBox.TabIndex = 5;
            // 
            // property_rent_priceTextBox
            // 
            this.property_rent_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertiesBindingSource, "property_rent_price", true));
            this.property_rent_priceTextBox.Location = new System.Drawing.Point(181, 208);
            this.property_rent_priceTextBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.property_rent_priceTextBox.Name = "property_rent_priceTextBox";
            this.property_rent_priceTextBox.Size = new System.Drawing.Size(129, 36);
            this.property_rent_priceTextBox.TabIndex = 9;
            // 
            // property_typeTextBox
            // 
            this.property_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.propertiesBindingSource, "property_type", true));
            this.property_typeTextBox.DataSource = this.propertytypesBindingSource;
            this.property_typeTextBox.DisplayMember = "property_type_name";
            this.property_typeTextBox.FormattingEnabled = true;
            this.property_typeTextBox.Location = new System.Drawing.Point(183, 6);
            this.property_typeTextBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.property_typeTextBox.Name = "property_typeTextBox";
            this.property_typeTextBox.Size = new System.Drawing.Size(306, 37);
            this.property_typeTextBox.TabIndex = 12;
            this.property_typeTextBox.ValueMember = "property_type_ID";
            // 
            // propertytypesBindingSource
            // 
            this.propertytypesBindingSource.DataMember = "property_types";
            this.propertytypesBindingSource.DataSource = this.rieltorskoe_agenstvoDataSet;
            // 
            // property_ownerTextBox
            // 
            this.property_ownerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.propertiesBindingSource, "property_owner", true));
            this.property_ownerTextBox.DataSource = this.ownersBindingSource;
            this.property_ownerTextBox.DisplayMember = "owner_name";
            this.property_ownerTextBox.DropDownHeight = 175;
            this.property_ownerTextBox.FormattingEnabled = true;
            this.property_ownerTextBox.IntegralHeight = false;
            this.property_ownerTextBox.Location = new System.Drawing.Point(110, 157);
            this.property_ownerTextBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.property_ownerTextBox.Name = "property_ownerTextBox";
            this.property_ownerTextBox.Size = new System.Drawing.Size(379, 37);
            this.property_ownerTextBox.TabIndex = 13;
            this.property_ownerTextBox.ValueMember = "owner_ID";
            // 
            // ownersBindingSource
            // 
            this.ownersBindingSource.DataMember = "owners";
            this.ownersBindingSource.DataSource = this.rieltorskoe_agenstvoDataSet;
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "states";
            this.statesBindingSource.DataSource = this.rieltorskoe_agenstvoDataSet;
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.BackColor = System.Drawing.Color.Red;
            this.btnBackToMainMenu.Location = new System.Drawing.Point(18, 377);
            this.btnBackToMainMenu.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(471, 60);
            this.btnBackToMainMenu.TabIndex = 16;
            this.btnBackToMainMenu.Text = "Вернуться в главное меню";
            this.btnBackToMainMenu.UseVisualStyleBackColor = false;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.Location = new System.Drawing.Point(18, 258);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(471, 105);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Добавить";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // property_stateTextBox
            // 
            this.property_stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.propertiesBindingSource, "property_state", true));
            this.property_stateTextBox.DataSource = this.statesBindingSource;
            this.property_stateTextBox.DisplayMember = "state_name";
            this.property_stateTextBox.FormattingEnabled = true;
            this.property_stateTextBox.Location = new System.Drawing.Point(584, 253);
            this.property_stateTextBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.property_stateTextBox.Name = "property_stateTextBox";
            this.property_stateTextBox.Size = new System.Drawing.Size(192, 37);
            this.property_stateTextBox.TabIndex = 14;
            this.property_stateTextBox.ValueMember = "state_ID";
            // 
            // PropertyAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(506, 451);
            this.ControlBox = false;
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.property_stateTextBox);
            this.Controls.Add(this.property_ownerTextBox);
            this.Controls.Add(this.property_typeTextBox);
            this.Controls.Add(property_rent_priceLabel);
            this.Controls.Add(this.property_rent_priceTextBox);
            this.Controls.Add(property_ownerLabel);
            this.Controls.Add(property_rooms_quantityLabel);
            this.Controls.Add(this.property_rooms_quantityTextBox);
            this.Controls.Add(property_addressLabel);
            this.Controls.Add(this.property_addressTextBox);
            this.Controls.Add(property_typeLabel);
            this.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "PropertyAdding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление недвижимости";
            this.Load += new System.EventHandler(this.PropertyAdding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rieltorskoe_agenstvoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertytypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private rieltorskoe_agenstvoDataSet rieltorskoe_agenstvoDataSet;
        private System.Windows.Forms.BindingSource propertiesBindingSource;
        private rieltorskoe_agenstvoDataSetTableAdapters.propertiesTableAdapter propertiesTableAdapter;
        private rieltorskoe_agenstvoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private rieltorskoe_agenstvoDataSetTableAdapters.property_typesTableAdapter property_typesTableAdapter;
        private System.Windows.Forms.TextBox property_addressTextBox;
        private System.Windows.Forms.TextBox property_rooms_quantityTextBox;
        private System.Windows.Forms.TextBox property_rent_priceTextBox;
        private System.Windows.Forms.ComboBox property_typeTextBox;
        private System.Windows.Forms.BindingSource propertytypesBindingSource;
        private rieltorskoe_agenstvoDataSetTableAdapters.ownersTableAdapter ownersTableAdapter;
        private System.Windows.Forms.ComboBox property_ownerTextBox;
        private System.Windows.Forms.BindingSource ownersBindingSource;
        private rieltorskoe_agenstvoDataSetTableAdapters.statesTableAdapter statesTableAdapter;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox property_stateTextBox;
    }
}