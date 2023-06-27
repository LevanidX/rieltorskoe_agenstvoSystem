namespace rieltorskoe_agenstvoSystem
{
    partial class RentedProperties
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
            System.Windows.Forms.Label property_stateLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rieltorskoe_agenstvoDataSet = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSet();
            this.rented_propertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rented_propertiesTableAdapter = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.rented_propertiesTableAdapter();
            this.tableAdapterManager = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.TableAdapterManager();
            this.rented_properties_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rented_properties_viewTableAdapter = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.rented_properties_viewTableAdapter();
            this.rented_properties_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEndRenting = new System.Windows.Forms.Button();
            this.propertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertiesTableAdapter = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.propertiesTableAdapter();
            this.property_stateTextBox = new System.Windows.Forms.TextBox();
            this.btnExitToMainMenu = new System.Windows.Forms.Button();
            property_stateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorskoe_agenstvoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rented_propertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rented_properties_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rented_properties_viewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // property_stateLabel
            // 
            property_stateLabel.AutoSize = true;
            property_stateLabel.Location = new System.Drawing.Point(825, 70);
            property_stateLabel.Name = "property_stateLabel";
            property_stateLabel.Size = new System.Drawing.Size(74, 13);
            property_stateLabel.TabIndex = 2;
            property_stateLabel.Text = "property state:";
            // 
            // rieltorskoe_agenstvoDataSet
            // 
            this.rieltorskoe_agenstvoDataSet.DataSetName = "rieltorskoe_agenstvoDataSet";
            this.rieltorskoe_agenstvoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rented_propertiesBindingSource
            // 
            this.rented_propertiesBindingSource.DataMember = "rented_properties";
            this.rented_propertiesBindingSource.DataSource = this.rieltorskoe_agenstvoDataSet;
            // 
            // rented_propertiesTableAdapter
            // 
            this.rented_propertiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.ownersTableAdapter = null;
            this.tableAdapterManager.propertiesTableAdapter = null;
            this.tableAdapterManager.property_typesTableAdapter = null;
            this.tableAdapterManager.rented_propertiesTableAdapter = this.rented_propertiesTableAdapter;
            this.tableAdapterManager.statesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rented_properties_viewBindingSource
            // 
            this.rented_properties_viewBindingSource.DataMember = "rented_properties_view";
            this.rented_properties_viewBindingSource.DataSource = this.rieltorskoe_agenstvoDataSet;
            // 
            // rented_properties_viewTableAdapter
            // 
            this.rented_properties_viewTableAdapter.ClearBeforeFill = true;
            // 
            // rented_properties_viewDataGridView
            // 
            this.rented_properties_viewDataGridView.AllowUserToAddRows = false;
            this.rented_properties_viewDataGridView.AllowUserToDeleteRows = false;
            this.rented_properties_viewDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rented_properties_viewDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.rented_properties_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rented_properties_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.rented_properties_viewDataGridView.DataSource = this.rented_properties_viewBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rented_properties_viewDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.rented_properties_viewDataGridView.Location = new System.Drawing.Point(12, 12);
            this.rented_properties_viewDataGridView.Name = "rented_properties_viewDataGridView";
            this.rented_properties_viewDataGridView.ReadOnly = true;
            this.rented_properties_viewDataGridView.Size = new System.Drawing.Size(776, 279);
            this.rented_properties_viewDataGridView.TabIndex = 0;
            this.rented_properties_viewDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rented_properties_viewDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "rented_property_contract_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер договора";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "rented_property";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер арендованной недвижимости";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "customer_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "ФИО клиента";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "owner_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "ФИО владельца";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "rented_property_price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена аренды/мес.";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "rented_property_first_date";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата начала аренды";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "rented_property_last_date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата конца аренды";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // btnEndRenting
            // 
            this.btnEndRenting.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEndRenting.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEndRenting.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEndRenting.Location = new System.Drawing.Point(12, 297);
            this.btnEndRenting.Name = "btnEndRenting";
            this.btnEndRenting.Size = new System.Drawing.Size(776, 56);
            this.btnEndRenting.TabIndex = 1;
            this.btnEndRenting.Text = "Расторгнуть договор аренды";
            this.btnEndRenting.UseVisualStyleBackColor = false;
            this.btnEndRenting.Click += new System.EventHandler(this.btnEndRenting_Click);
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
            // property_stateTextBox
            // 
            this.property_stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertiesBindingSource, "property_state", true));
            this.property_stateTextBox.Location = new System.Drawing.Point(905, 67);
            this.property_stateTextBox.Name = "property_stateTextBox";
            this.property_stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.property_stateTextBox.TabIndex = 3;
            // 
            // btnExitToMainMenu
            // 
            this.btnExitToMainMenu.BackColor = System.Drawing.Color.Red;
            this.btnExitToMainMenu.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitToMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExitToMainMenu.Location = new System.Drawing.Point(12, 359);
            this.btnExitToMainMenu.Name = "btnExitToMainMenu";
            this.btnExitToMainMenu.Size = new System.Drawing.Size(776, 38);
            this.btnExitToMainMenu.TabIndex = 4;
            this.btnExitToMainMenu.Text = "Вернуться в главное меню";
            this.btnExitToMainMenu.UseVisualStyleBackColor = false;
            this.btnExitToMainMenu.Click += new System.EventHandler(this.btnExitToMainMenu_Click);
            // 
            // RentedProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(801, 405);
            this.ControlBox = false;
            this.Controls.Add(this.btnExitToMainMenu);
            this.Controls.Add(property_stateLabel);
            this.Controls.Add(this.property_stateTextBox);
            this.Controls.Add(this.btnEndRenting);
            this.Controls.Add(this.rented_properties_viewDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RentedProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Арендованная недвижимость";
            this.Load += new System.EventHandler(this.RentedProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rieltorskoe_agenstvoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rented_propertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rented_properties_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rented_properties_viewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private rieltorskoe_agenstvoDataSet rieltorskoe_agenstvoDataSet;
        private System.Windows.Forms.BindingSource rented_propertiesBindingSource;
        private rieltorskoe_agenstvoDataSetTableAdapters.rented_propertiesTableAdapter rented_propertiesTableAdapter;
        private rieltorskoe_agenstvoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource rented_properties_viewBindingSource;
        private rieltorskoe_agenstvoDataSetTableAdapters.rented_properties_viewTableAdapter rented_properties_viewTableAdapter;
        private System.Windows.Forms.DataGridView rented_properties_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnEndRenting;
        private System.Windows.Forms.BindingSource propertiesBindingSource;
        private rieltorskoe_agenstvoDataSetTableAdapters.propertiesTableAdapter propertiesTableAdapter;
        private System.Windows.Forms.TextBox property_stateTextBox;
        private System.Windows.Forms.Button btnExitToMainMenu;
    }
}