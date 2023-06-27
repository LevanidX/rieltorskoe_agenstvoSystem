namespace rieltorskoe_agenstvoSystem
{
    partial class MainMenu
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
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.btnAddNewOwner = new System.Windows.Forms.Button();
            this.btnRentProperty = new System.Windows.Forms.Button();
            this.btnViewRentedProperty = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddingNewProperty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddNewCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(13, 16);
            this.btnAddNewCustomer.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(153, 83);
            this.btnAddNewCustomer.TabIndex = 0;
            this.btnAddNewCustomer.Text = "Добавление нового клиента";
            this.btnAddNewCustomer.UseVisualStyleBackColor = false;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // btnAddNewOwner
            // 
            this.btnAddNewOwner.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddNewOwner.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewOwner.Location = new System.Drawing.Point(174, 16);
            this.btnAddNewOwner.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnAddNewOwner.Name = "btnAddNewOwner";
            this.btnAddNewOwner.Size = new System.Drawing.Size(171, 83);
            this.btnAddNewOwner.TabIndex = 1;
            this.btnAddNewOwner.Text = "Добавление нового владельца";
            this.btnAddNewOwner.UseVisualStyleBackColor = false;
            this.btnAddNewOwner.Click += new System.EventHandler(this.btnAddNewOwner_Click);
            // 
            // btnRentProperty
            // 
            this.btnRentProperty.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRentProperty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRentProperty.Location = new System.Drawing.Point(13, 210);
            this.btnRentProperty.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnRentProperty.Name = "btnRentProperty";
            this.btnRentProperty.Size = new System.Drawing.Size(333, 83);
            this.btnRentProperty.TabIndex = 2;
            this.btnRentProperty.Text = "Аренда недвижимости";
            this.btnRentProperty.UseVisualStyleBackColor = false;
            this.btnRentProperty.Click += new System.EventHandler(this.btnRentProperty_Click);
            // 
            // btnViewRentedProperty
            // 
            this.btnViewRentedProperty.BackColor = System.Drawing.Color.SeaGreen;
            this.btnViewRentedProperty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewRentedProperty.Location = new System.Drawing.Point(13, 307);
            this.btnViewRentedProperty.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnViewRentedProperty.Name = "btnViewRentedProperty";
            this.btnViewRentedProperty.Size = new System.Drawing.Size(333, 83);
            this.btnViewRentedProperty.TabIndex = 3;
            this.btnViewRentedProperty.Text = "Просмотр арендованной недвижимости";
            this.btnViewRentedProperty.UseVisualStyleBackColor = false;
            this.btnViewRentedProperty.Click += new System.EventHandler(this.btnViewRentedProperty_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(13, 401);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(333, 83);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход из программы";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddingNewProperty
            // 
            this.btnAddingNewProperty.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddingNewProperty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddingNewProperty.Location = new System.Drawing.Point(13, 113);
            this.btnAddingNewProperty.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnAddingNewProperty.Name = "btnAddingNewProperty";
            this.btnAddingNewProperty.Size = new System.Drawing.Size(333, 83);
            this.btnAddingNewProperty.TabIndex = 5;
            this.btnAddingNewProperty.Text = "Добавление новой недвижимости";
            this.btnAddingNewProperty.UseVisualStyleBackColor = false;
            this.btnAddingNewProperty.Click += new System.EventHandler(this.btnAddingNewProperty_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(359, 498);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddingNewProperty);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewRentedProperty);
            this.Controls.Add(this.btnRentProperty);
            this.Controls.Add(this.btnAddNewOwner);
            this.Controls.Add(this.btnAddNewCustomer);
            this.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.Button btnAddNewOwner;
        private System.Windows.Forms.Button btnRentProperty;
        private System.Windows.Forms.Button btnViewRentedProperty;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddingNewProperty;
    }
}

