namespace rieltorskoe_agenstvoSystem
{
    partial class RentingProperty
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.property_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.property_owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.property_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rieltorskoe_agenstvoDataSet = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSet();
            this.btnRent = new System.Windows.Forms.Button();
            this.property_viewTableAdapter = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.property_viewTableAdapter();
            this.tableAdapterManager = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.TableAdapterManager();
            this.propertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertiesTableAdapter = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.propertiesTableAdapter();
            this.property_stateTextBox = new System.Windows.Forms.TextBox();
            this.btnExitToMainMenu = new System.Windows.Forms.Button();
            property_stateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.property_viewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.property_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorskoe_agenstvoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // property_stateLabel
            // 
            property_stateLabel.AutoSize = true;
            property_stateLabel.Location = new System.Drawing.Point(1099, 103);
            property_stateLabel.Name = "property_stateLabel";
            property_stateLabel.Size = new System.Drawing.Size(74, 13);
            property_stateLabel.TabIndex = 2;
            property_stateLabel.Text = "property state:";
            // 
            // property_viewDataGridView
            // 
            this.property_viewDataGridView.AllowUserToAddRows = false;
            this.property_viewDataGridView.AllowUserToDeleteRows = false;
            this.property_viewDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.property_viewDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.property_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.property_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.property_owner,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.property_viewDataGridView.DataSource = this.property_viewBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.property_viewDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.property_viewDataGridView.Location = new System.Drawing.Point(12, 12);
            this.property_viewDataGridView.Name = "property_viewDataGridView";
            this.property_viewDataGridView.ReadOnly = true;
            this.property_viewDataGridView.Size = new System.Drawing.Size(1027, 155);
            this.property_viewDataGridView.TabIndex = 1;
            this.property_viewDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.property_viewDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "property_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "Номер недвижимости";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "property_type_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Тип недвижимости";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "property_address";
            this.dataGridViewTextBoxColumn2.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "property_rooms_quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество комнат";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // property_owner
            // 
            this.property_owner.DataPropertyName = "property_owner";
            this.property_owner.HeaderText = "Номер владельца";
            this.property_owner.Name = "property_owner";
            this.property_owner.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn5.DataPropertyName = "property_rent_price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена аренды/мес.";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "state_name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Состояние";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // property_viewBindingSource
            // 
            this.property_viewBindingSource.DataMember = "property_view";
            this.property_viewBindingSource.DataSource = this.rieltorskoe_agenstvoDataSet;
            // 
            // rieltorskoe_agenstvoDataSet
            // 
            this.rieltorskoe_agenstvoDataSet.DataSetName = "rieltorskoe_agenstvoDataSet";
            this.rieltorskoe_agenstvoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRent.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRent.Location = new System.Drawing.Point(12, 173);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(1027, 58);
            this.btnRent.TabIndex = 2;
            this.btnRent.Text = "Начать аренду недвижимости";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // property_viewTableAdapter
            // 
            this.property_viewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.ownersTableAdapter = null;
            this.tableAdapterManager.propertiesTableAdapter = null;
            this.tableAdapterManager.property_typesTableAdapter = null;
            this.tableAdapterManager.rented_propertiesTableAdapter = null;
            this.tableAdapterManager.statesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.property_stateTextBox.Location = new System.Drawing.Point(1179, 100);
            this.property_stateTextBox.Name = "property_stateTextBox";
            this.property_stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.property_stateTextBox.TabIndex = 3;
            // 
            // btnExitToMainMenu
            // 
            this.btnExitToMainMenu.BackColor = System.Drawing.Color.Red;
            this.btnExitToMainMenu.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitToMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExitToMainMenu.Location = new System.Drawing.Point(12, 237);
            this.btnExitToMainMenu.Name = "btnExitToMainMenu";
            this.btnExitToMainMenu.Size = new System.Drawing.Size(1027, 40);
            this.btnExitToMainMenu.TabIndex = 5;
            this.btnExitToMainMenu.Text = "Вернуться в главное меню";
            this.btnExitToMainMenu.UseVisualStyleBackColor = false;
            this.btnExitToMainMenu.Click += new System.EventHandler(this.btnExitToMainMenu_Click);
            // 
            // RentingProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1052, 287);
            this.ControlBox = false;
            this.Controls.Add(this.btnExitToMainMenu);
            this.Controls.Add(property_stateLabel);
            this.Controls.Add(this.property_stateTextBox);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.property_viewDataGridView);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RentingProperty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аренда недвижимости";
            this.Load += new System.EventHandler(this.RentingProperty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.property_viewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.property_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorskoe_agenstvoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private rieltorskoe_agenstvoDataSet rieltorskoe_agenstvoDataSet;
        private System.Windows.Forms.BindingSource property_viewBindingSource;
        private rieltorskoe_agenstvoDataSetTableAdapters.property_viewTableAdapter property_viewTableAdapter;
        private rieltorskoe_agenstvoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView property_viewDataGridView;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn property_owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource propertiesBindingSource;
        private rieltorskoe_agenstvoDataSetTableAdapters.propertiesTableAdapter propertiesTableAdapter;
        private System.Windows.Forms.TextBox property_stateTextBox;
        private System.Windows.Forms.Button btnExitToMainMenu;
    }
}