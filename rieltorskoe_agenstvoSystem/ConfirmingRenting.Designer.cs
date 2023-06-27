namespace rieltorskoe_agenstvoSystem
{
    partial class ConfirmingRenting
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
            System.Windows.Forms.Label rented_property_first_dateLabel;
            System.Windows.Forms.Label rented_property_last_dateLabel;
            System.Windows.Forms.Label property_stateLabel;
            this.rented_propertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rieltorskoe_agenstvoDataSet = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSet();
            this.rented_propertiesTableAdapter = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.rented_propertiesTableAdapter();
            this.tableAdapterManager = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.TableAdapterManager();
            this.customersTableAdapter = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.customersTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rented_property_first_dateDateTimePicker = new System.Windows.Forms.MaskedTextBox();
            this.rented_property_last_dateDateTimePicker = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnConfirmRenting = new System.Windows.Forms.Button();
            this.lblPropertyOwner = new System.Windows.Forms.Label();
            this.propertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertiesTableAdapter = new rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.propertiesTableAdapter();
            this.property_stateTextBox = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPropertyOwnerID = new System.Windows.Forms.Label();
            this.lblRentedProperty = new System.Windows.Forms.Label();
            this.btnCurDate = new System.Windows.Forms.Button();
            rented_property_first_dateLabel = new System.Windows.Forms.Label();
            rented_property_last_dateLabel = new System.Windows.Forms.Label();
            property_stateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rented_propertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorskoe_agenstvoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rented_property_first_dateLabel
            // 
            rented_property_first_dateLabel.AutoSize = true;
            rented_property_first_dateLabel.Location = new System.Drawing.Point(13, 156);
            rented_property_first_dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rented_property_first_dateLabel.Name = "rented_property_first_dateLabel";
            rented_property_first_dateLabel.Size = new System.Drawing.Size(184, 29);
            rented_property_first_dateLabel.TabIndex = 8;
            rented_property_first_dateLabel.Text = "Дата начала аренды";
            // 
            // rented_property_last_dateLabel
            // 
            rented_property_last_dateLabel.AutoSize = true;
            rented_property_last_dateLabel.Location = new System.Drawing.Point(13, 206);
            rented_property_last_dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rented_property_last_dateLabel.Name = "rented_property_last_dateLabel";
            rented_property_last_dateLabel.Size = new System.Drawing.Size(173, 29);
            rented_property_last_dateLabel.TabIndex = 10;
            rented_property_last_dateLabel.Text = "Дата конца аренды";
            // 
            // property_stateLabel
            // 
            property_stateLabel.AutoSize = true;
            property_stateLabel.Location = new System.Drawing.Point(757, 233);
            property_stateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            property_stateLabel.Name = "property_stateLabel";
            property_stateLabel.Size = new System.Drawing.Size(131, 29);
            property_stateLabel.TabIndex = 19;
            property_stateLabel.Text = "property state:";
            // 
            // rented_propertiesBindingSource
            // 
            this.rented_propertiesBindingSource.DataMember = "rented_properties";
            this.rented_propertiesBindingSource.DataSource = this.rieltorskoe_agenstvoDataSet;
            // 
            // rieltorskoe_agenstvoDataSet
            // 
            this.rieltorskoe_agenstvoDataSet.DataSetName = "rieltorskoe_agenstvoDataSet";
            this.rieltorskoe_agenstvoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rented_propertiesTableAdapter
            // 
            this.rented_propertiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.ownersTableAdapter = null;
            this.tableAdapterManager.propertiesTableAdapter = null;
            this.tableAdapterManager.property_typesTableAdapter = null;
            this.tableAdapterManager.rented_propertiesTableAdapter = this.rented_propertiesTableAdapter;
            this.tableAdapterManager.statesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rented_propertiesBindingSource, "rented_property_customer", true));
            this.comboBox1.DataSource = this.customersBindingSource;
            this.comboBox1.DisplayMember = "customer_name";
            this.comboBox1.DropDownHeight = 175;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(179, 102);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(315, 37);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "customer_ID";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.rieltorskoe_agenstvoDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Владелец недвижимости";
            // 
            // rented_property_first_dateDateTimePicker
            // 
            this.rented_property_first_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rented_propertiesBindingSource, "rented_property_first_date", true));
            this.rented_property_first_dateDateTimePicker.Location = new System.Drawing.Point(205, 153);
            this.rented_property_first_dateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.rented_property_first_dateDateTimePicker.Mask = "00/00/0000";
            this.rented_property_first_dateDateTimePicker.Name = "rented_property_first_dateDateTimePicker";
            this.rented_property_first_dateDateTimePicker.Size = new System.Drawing.Size(154, 36);
            this.rented_property_first_dateDateTimePicker.TabIndex = 12;
            this.rented_property_first_dateDateTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // rented_property_last_dateDateTimePicker
            // 
            this.rented_property_last_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rented_propertiesBindingSource, "rented_property_last_date", true));
            this.rented_property_last_dateDateTimePicker.Location = new System.Drawing.Point(194, 203);
            this.rented_property_last_dateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.rented_property_last_dateDateTimePicker.Mask = "00/00/0000";
            this.rented_property_last_dateDateTimePicker.Name = "rented_property_last_dateDateTimePicker";
            this.rented_property_last_dateDateTimePicker.Size = new System.Drawing.Size(300, 36);
            this.rented_property_last_dateDateTimePicker.TabIndex = 13;
            this.rented_property_last_dateDateTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Цена аренды/мес.";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rented_propertiesBindingSource, "rented_property_price", true));
            this.lblPrice.Location = new System.Drawing.Point(174, 55);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 29);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "price";
            // 
            // btnConfirmRenting
            // 
            this.btnConfirmRenting.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConfirmRenting.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmRenting.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmRenting.Location = new System.Drawing.Point(18, 253);
            this.btnConfirmRenting.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnConfirmRenting.Name = "btnConfirmRenting";
            this.btnConfirmRenting.Size = new System.Drawing.Size(476, 94);
            this.btnConfirmRenting.TabIndex = 16;
            this.btnConfirmRenting.Text = "Подтвердить";
            this.btnConfirmRenting.UseVisualStyleBackColor = false;
            this.btnConfirmRenting.Click += new System.EventHandler(this.btnConfirmRenting_Click);
            // 
            // lblPropertyOwner
            // 
            this.lblPropertyOwner.AutoSize = true;
            this.lblPropertyOwner.Location = new System.Drawing.Point(232, 9);
            this.lblPropertyOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPropertyOwner.Name = "lblPropertyOwner";
            this.lblPropertyOwner.Size = new System.Drawing.Size(140, 29);
            this.lblPropertyOwner.TabIndex = 19;
            this.lblPropertyOwner.Text = "property_owner";
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
            this.property_stateTextBox.Location = new System.Drawing.Point(896, 230);
            this.property_stateTextBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.property_stateTextBox.Name = "property_stateTextBox";
            this.property_stateTextBox.Size = new System.Drawing.Size(148, 36);
            this.property_stateTextBox.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(18, 351);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(476, 51);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPropertyOwnerID
            // 
            this.lblPropertyOwnerID.AutoSize = true;
            this.lblPropertyOwnerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rented_propertiesBindingSource, "rented_property_owner", true));
            this.lblPropertyOwnerID.Location = new System.Drawing.Point(881, 194);
            this.lblPropertyOwnerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPropertyOwnerID.Name = "lblPropertyOwnerID";
            this.lblPropertyOwnerID.Size = new System.Drawing.Size(163, 29);
            this.lblPropertyOwnerID.TabIndex = 18;
            this.lblPropertyOwnerID.Text = "property_owner_ID";
            // 
            // lblRentedProperty
            // 
            this.lblRentedProperty.AutoSize = true;
            this.lblRentedProperty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rented_propertiesBindingSource, "rented_property", true));
            this.lblRentedProperty.Location = new System.Drawing.Point(902, 165);
            this.lblRentedProperty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentedProperty.Name = "lblRentedProperty";
            this.lblRentedProperty.Size = new System.Drawing.Size(142, 29);
            this.lblRentedProperty.TabIndex = 0;
            this.lblRentedProperty.Text = "rented_property";
            // 
            // btnCurDate
            // 
            this.btnCurDate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCurDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCurDate.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCurDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCurDate.Location = new System.Drawing.Point(367, 153);
            this.btnCurDate.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnCurDate.Name = "btnCurDate";
            this.btnCurDate.Size = new System.Drawing.Size(127, 36);
            this.btnCurDate.TabIndex = 22;
            this.btnCurDate.Text = "Текущая дата";
            this.btnCurDate.UseVisualStyleBackColor = false;
            this.btnCurDate.Click += new System.EventHandler(this.btnCurDate_Click);
            // 
            // ConfirmingRenting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(512, 413);
            this.ControlBox = false;
            this.Controls.Add(this.btnCurDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(property_stateLabel);
            this.Controls.Add(this.property_stateTextBox);
            this.Controls.Add(this.lblPropertyOwner);
            this.Controls.Add(this.lblPropertyOwnerID);
            this.Controls.Add(this.btnConfirmRenting);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rented_property_last_dateDateTimePicker);
            this.Controls.Add(this.rented_property_first_dateDateTimePicker);
            this.Controls.Add(rented_property_last_dateLabel);
            this.Controls.Add(rented_property_first_dateLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblRentedProperty);
            this.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "ConfirmingRenting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление договора на аренду";
            this.Load += new System.EventHandler(this.ConfirmingRenting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rented_propertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorskoe_agenstvoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private rieltorskoe_agenstvoDataSet rieltorskoe_agenstvoDataSet;
        private System.Windows.Forms.BindingSource rented_propertiesBindingSource;
        private rieltorskoe_agenstvoDataSetTableAdapters.rented_propertiesTableAdapter rented_propertiesTableAdapter;
        private rieltorskoe_agenstvoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private rieltorskoe_agenstvoDataSetTableAdapters.customersTableAdapter customersTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox rented_property_first_dateDateTimePicker;
        private System.Windows.Forms.MaskedTextBox rented_property_last_dateDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnConfirmRenting;
        private System.Windows.Forms.Label lblPropertyOwner;
        private System.Windows.Forms.BindingSource propertiesBindingSource;
        private rieltorskoe_agenstvoDataSetTableAdapters.propertiesTableAdapter propertiesTableAdapter;
        private System.Windows.Forms.TextBox property_stateTextBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPropertyOwnerID;
        private System.Windows.Forms.Label lblRentedProperty;
        private System.Windows.Forms.Button btnCurDate;
    }
}