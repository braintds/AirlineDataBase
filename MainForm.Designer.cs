namespace AirlineDataBase
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.AircraftFleetPanel = new System.Windows.Forms.Panel();
            this.AircraftFleetButton = new System.Windows.Forms.Button();
            this.AircraftFleetDataGridView = new System.Windows.Forms.DataGridView();
            this.StaffPanel = new System.Windows.Forms.Panel();
            this.StaffDeletePanel = new System.Windows.Forms.Panel();
            this.StaffDeleteButton = new System.Windows.Forms.Button();
            this.StaffDeleteFatherNameLabel = new System.Windows.Forms.Label();
            this.StaffDeleteNameLabel = new System.Windows.Forms.Label();
            this.StaffDeleteSurnameLabel = new System.Windows.Forms.Label();
            this.StaffDeleteFatherNameTextBox = new System.Windows.Forms.TextBox();
            this.StaffDeleteNameTextBox = new System.Windows.Forms.TextBox();
            this.StaffDeleteSurnameTextBox = new System.Windows.Forms.TextBox();
            this.StaffViewDeleteButton = new System.Windows.Forms.Button();
            this.StaffAddPanel = new System.Windows.Forms.Panel();
            this.AddPositionComboBox = new System.Windows.Forms.ComboBox();
            this.AddStaffInDBButton = new System.Windows.Forms.Button();
            this.AddPositionLabel = new System.Windows.Forms.Label();
            this.AddFatherNameLabel = new System.Windows.Forms.Label();
            this.AddNameLabel = new System.Windows.Forms.Label();
            this.AddSurnameLabel = new System.Windows.Forms.Label();
            this.AddFatherNameTextBox = new System.Windows.Forms.TextBox();
            this.AddNameTextBox = new System.Windows.Forms.TextBox();
            this.AddSurnameTextBox = new System.Windows.Forms.TextBox();
            this.StaffAddButton = new System.Windows.Forms.Button();
            this.StaffViewButton = new System.Windows.Forms.Button();
            this.StaffDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.PassengerPanel = new System.Windows.Forms.Panel();
            this.ViewPassengerButton = new System.Windows.Forms.Button();
            this.PassengerDataGridView = new System.Windows.Forms.DataGridView();
            this.AircraftFleetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AircraftFleetDataGridView)).BeginInit();
            this.StaffPanel.SuspendLayout();
            this.StaffDeletePanel.SuspendLayout();
            this.StaffAddPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.PassengerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassengerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(944, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // AircraftFleetPanel
            // 
            this.AircraftFleetPanel.Controls.Add(this.AircraftFleetButton);
            this.AircraftFleetPanel.Controls.Add(this.AircraftFleetDataGridView);
            this.AircraftFleetPanel.Location = new System.Drawing.Point(6, 30);
            this.AircraftFleetPanel.Name = "AircraftFleetPanel";
            this.AircraftFleetPanel.Size = new System.Drawing.Size(932, 379);
            this.AircraftFleetPanel.TabIndex = 1;
            this.AircraftFleetPanel.Visible = false;
            // 
            // AircraftFleetButton
            // 
            this.AircraftFleetButton.Location = new System.Drawing.Point(12, 4);
            this.AircraftFleetButton.Name = "AircraftFleetButton";
            this.AircraftFleetButton.Size = new System.Drawing.Size(150, 23);
            this.AircraftFleetButton.TabIndex = 1;
            this.AircraftFleetButton.Text = "Отобразить базу данных";
            this.AircraftFleetButton.UseVisualStyleBackColor = true;
            this.AircraftFleetButton.Click += new System.EventHandler(this.AircraftFleetButton_Click);
            // 
            // AircraftFleetDataGridView
            // 
            this.AircraftFleetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AircraftFleetDataGridView.Location = new System.Drawing.Point(3, 33);
            this.AircraftFleetDataGridView.Name = "AircraftFleetDataGridView";
            this.AircraftFleetDataGridView.ReadOnly = true;
            this.AircraftFleetDataGridView.Size = new System.Drawing.Size(926, 274);
            this.AircraftFleetDataGridView.TabIndex = 0;
            // 
            // StaffPanel
            // 
            this.StaffPanel.Controls.Add(this.StaffDeletePanel);
            this.StaffPanel.Controls.Add(this.StaffViewDeleteButton);
            this.StaffPanel.Controls.Add(this.StaffAddPanel);
            this.StaffPanel.Controls.Add(this.StaffAddButton);
            this.StaffPanel.Controls.Add(this.StaffViewButton);
            this.StaffPanel.Controls.Add(this.StaffDataGridView);
            this.StaffPanel.Location = new System.Drawing.Point(6, 30);
            this.StaffPanel.Name = "StaffPanel";
            this.StaffPanel.Size = new System.Drawing.Size(926, 459);
            this.StaffPanel.TabIndex = 2;
            this.StaffPanel.Visible = false;
            // 
            // StaffDeletePanel
            // 
            this.StaffDeletePanel.Controls.Add(this.StaffDeleteButton);
            this.StaffDeletePanel.Controls.Add(this.StaffDeleteFatherNameLabel);
            this.StaffDeletePanel.Controls.Add(this.StaffDeleteNameLabel);
            this.StaffDeletePanel.Controls.Add(this.StaffDeleteSurnameLabel);
            this.StaffDeletePanel.Controls.Add(this.StaffDeleteFatherNameTextBox);
            this.StaffDeletePanel.Controls.Add(this.StaffDeleteNameTextBox);
            this.StaffDeletePanel.Controls.Add(this.StaffDeleteSurnameTextBox);
            this.StaffDeletePanel.Location = new System.Drawing.Point(35, 379);
            this.StaffDeletePanel.Name = "StaffDeletePanel";
            this.StaffDeletePanel.Size = new System.Drawing.Size(770, 77);
            this.StaffDeletePanel.TabIndex = 6;
            this.StaffDeletePanel.Visible = false;
            // 
            // StaffDeleteButton
            // 
            this.StaffDeleteButton.Location = new System.Drawing.Point(269, 44);
            this.StaffDeleteButton.Name = "StaffDeleteButton";
            this.StaffDeleteButton.Size = new System.Drawing.Size(124, 23);
            this.StaffDeleteButton.TabIndex = 3;
            this.StaffDeleteButton.Text = "Удалить сотрудника";
            this.StaffDeleteButton.UseVisualStyleBackColor = true;
            this.StaffDeleteButton.Click += new System.EventHandler(this.StaffDeleteButton_Click);
            // 
            // StaffDeleteFatherNameLabel
            // 
            this.StaffDeleteFatherNameLabel.AutoSize = true;
            this.StaffDeleteFatherNameLabel.Location = new System.Drawing.Point(337, 14);
            this.StaffDeleteFatherNameLabel.Name = "StaffDeleteFatherNameLabel";
            this.StaffDeleteFatherNameLabel.Size = new System.Drawing.Size(54, 13);
            this.StaffDeleteFatherNameLabel.TabIndex = 33;
            this.StaffDeleteFatherNameLabel.Text = "Отчество";
            // 
            // StaffDeleteNameLabel
            // 
            this.StaffDeleteNameLabel.AutoSize = true;
            this.StaffDeleteNameLabel.Location = new System.Drawing.Point(192, 14);
            this.StaffDeleteNameLabel.Name = "StaffDeleteNameLabel";
            this.StaffDeleteNameLabel.Size = new System.Drawing.Size(29, 13);
            this.StaffDeleteNameLabel.TabIndex = 32;
            this.StaffDeleteNameLabel.Text = "Имя";
            // 
            // StaffDeleteSurnameLabel
            // 
            this.StaffDeleteSurnameLabel.AutoSize = true;
            this.StaffDeleteSurnameLabel.Location = new System.Drawing.Point(26, 14);
            this.StaffDeleteSurnameLabel.Name = "StaffDeleteSurnameLabel";
            this.StaffDeleteSurnameLabel.Size = new System.Drawing.Size(56, 13);
            this.StaffDeleteSurnameLabel.TabIndex = 31;
            this.StaffDeleteSurnameLabel.Text = "Фамилия";
            // 
            // StaffDeleteFatherNameTextBox
            // 
            this.StaffDeleteFatherNameTextBox.Location = new System.Drawing.Point(397, 11);
            this.StaffDeleteFatherNameTextBox.Name = "StaffDeleteFatherNameTextBox";
            this.StaffDeleteFatherNameTextBox.Size = new System.Drawing.Size(105, 20);
            this.StaffDeleteFatherNameTextBox.TabIndex = 30;
            // 
            // StaffDeleteNameTextBox
            // 
            this.StaffDeleteNameTextBox.Location = new System.Drawing.Point(225, 11);
            this.StaffDeleteNameTextBox.Name = "StaffDeleteNameTextBox";
            this.StaffDeleteNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.StaffDeleteNameTextBox.TabIndex = 29;
            // 
            // StaffDeleteSurnameTextBox
            // 
            this.StaffDeleteSurnameTextBox.Location = new System.Drawing.Point(86, 11);
            this.StaffDeleteSurnameTextBox.Name = "StaffDeleteSurnameTextBox";
            this.StaffDeleteSurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.StaffDeleteSurnameTextBox.TabIndex = 28;
            // 
            // StaffViewDeleteButton
            // 
            this.StaffViewDeleteButton.Location = new System.Drawing.Point(322, 3);
            this.StaffViewDeleteButton.Name = "StaffViewDeleteButton";
            this.StaffViewDeleteButton.Size = new System.Drawing.Size(126, 23);
            this.StaffViewDeleteButton.TabIndex = 5;
            this.StaffViewDeleteButton.Text = "Удалить сотрудника";
            this.StaffViewDeleteButton.UseVisualStyleBackColor = true;
            this.StaffViewDeleteButton.Click += new System.EventHandler(this.StaffViewDeleteButton_Click);
            // 
            // StaffAddPanel
            // 
            this.StaffAddPanel.Controls.Add(this.AddPositionComboBox);
            this.StaffAddPanel.Controls.Add(this.AddStaffInDBButton);
            this.StaffAddPanel.Controls.Add(this.AddPositionLabel);
            this.StaffAddPanel.Controls.Add(this.AddFatherNameLabel);
            this.StaffAddPanel.Controls.Add(this.AddNameLabel);
            this.StaffAddPanel.Controls.Add(this.AddSurnameLabel);
            this.StaffAddPanel.Controls.Add(this.AddFatherNameTextBox);
            this.StaffAddPanel.Controls.Add(this.AddNameTextBox);
            this.StaffAddPanel.Controls.Add(this.AddSurnameTextBox);
            this.StaffAddPanel.Location = new System.Drawing.Point(9, 313);
            this.StaffAddPanel.Name = "StaffAddPanel";
            this.StaffAddPanel.Size = new System.Drawing.Size(768, 63);
            this.StaffAddPanel.TabIndex = 4;
            this.StaffAddPanel.Visible = false;
            // 
            // AddPositionComboBox
            // 
            this.AddPositionComboBox.FormattingEnabled = true;
            this.AddPositionComboBox.Location = new System.Drawing.Point(591, 7);
            this.AddPositionComboBox.Name = "AddPositionComboBox";
            this.AddPositionComboBox.Size = new System.Drawing.Size(162, 21);
            this.AddPositionComboBox.TabIndex = 30;
            // 
            // AddStaffInDBButton
            // 
            this.AddStaffInDBButton.Location = new System.Drawing.Point(283, 34);
            this.AddStaffInDBButton.Name = "AddStaffInDBButton";
            this.AddStaffInDBButton.Size = new System.Drawing.Size(174, 26);
            this.AddStaffInDBButton.TabIndex = 23;
            this.AddStaffInDBButton.Text = "Добавить сотрудника";
            this.AddStaffInDBButton.UseVisualStyleBackColor = true;
            this.AddStaffInDBButton.Click += new System.EventHandler(this.AddStaffInDBButton_Click);
            // 
            // AddPositionLabel
            // 
            this.AddPositionLabel.AutoSize = true;
            this.AddPositionLabel.Location = new System.Drawing.Point(520, 11);
            this.AddPositionLabel.Name = "AddPositionLabel";
            this.AddPositionLabel.Size = new System.Drawing.Size(65, 13);
            this.AddPositionLabel.TabIndex = 28;
            this.AddPositionLabel.Text = "Должность";
            // 
            // AddFatherNameLabel
            // 
            this.AddFatherNameLabel.AutoSize = true;
            this.AddFatherNameLabel.Location = new System.Drawing.Point(334, 11);
            this.AddFatherNameLabel.Name = "AddFatherNameLabel";
            this.AddFatherNameLabel.Size = new System.Drawing.Size(54, 13);
            this.AddFatherNameLabel.TabIndex = 27;
            this.AddFatherNameLabel.Text = "Отчество";
            // 
            // AddNameLabel
            // 
            this.AddNameLabel.AutoSize = true;
            this.AddNameLabel.Location = new System.Drawing.Point(189, 11);
            this.AddNameLabel.Name = "AddNameLabel";
            this.AddNameLabel.Size = new System.Drawing.Size(29, 13);
            this.AddNameLabel.TabIndex = 26;
            this.AddNameLabel.Text = "Имя";
            // 
            // AddSurnameLabel
            // 
            this.AddSurnameLabel.AutoSize = true;
            this.AddSurnameLabel.Location = new System.Drawing.Point(23, 11);
            this.AddSurnameLabel.Name = "AddSurnameLabel";
            this.AddSurnameLabel.Size = new System.Drawing.Size(56, 13);
            this.AddSurnameLabel.TabIndex = 25;
            this.AddSurnameLabel.Text = "Фамилия";
            // 
            // AddFatherNameTextBox
            // 
            this.AddFatherNameTextBox.Location = new System.Drawing.Point(394, 8);
            this.AddFatherNameTextBox.Name = "AddFatherNameTextBox";
            this.AddFatherNameTextBox.Size = new System.Drawing.Size(105, 20);
            this.AddFatherNameTextBox.TabIndex = 21;
            // 
            // AddNameTextBox
            // 
            this.AddNameTextBox.Location = new System.Drawing.Point(222, 8);
            this.AddNameTextBox.Name = "AddNameTextBox";
            this.AddNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddNameTextBox.TabIndex = 20;
            // 
            // AddSurnameTextBox
            // 
            this.AddSurnameTextBox.Location = new System.Drawing.Point(83, 8);
            this.AddSurnameTextBox.Name = "AddSurnameTextBox";
            this.AddSurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddSurnameTextBox.TabIndex = 19;
            // 
            // StaffAddButton
            // 
            this.StaffAddButton.Location = new System.Drawing.Point(182, 3);
            this.StaffAddButton.Name = "StaffAddButton";
            this.StaffAddButton.Size = new System.Drawing.Size(132, 23);
            this.StaffAddButton.TabIndex = 3;
            this.StaffAddButton.Text = "Добавить сотрудника";
            this.StaffAddButton.UseVisualStyleBackColor = true;
            this.StaffAddButton.Click += new System.EventHandler(this.StaffAddButton_Click);
            // 
            // StaffViewButton
            // 
            this.StaffViewButton.Location = new System.Drawing.Point(9, 3);
            this.StaffViewButton.Name = "StaffViewButton";
            this.StaffViewButton.Size = new System.Drawing.Size(167, 23);
            this.StaffViewButton.TabIndex = 2;
            this.StaffViewButton.Text = "Показать всех сотрудников";
            this.StaffViewButton.UseVisualStyleBackColor = true;
            this.StaffViewButton.Click += new System.EventHandler(this.StaffViewButton_Click);
            // 
            // StaffDataGridView
            // 
            this.StaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffDataGridView.Location = new System.Drawing.Point(3, 29);
            this.StaffDataGridView.Name = "StaffDataGridView";
            this.StaffDataGridView.ReadOnly = true;
            this.StaffDataGridView.Size = new System.Drawing.Size(920, 274);
            this.StaffDataGridView.TabIndex = 1;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // PassengerPanel
            // 
            this.PassengerPanel.Controls.Add(this.ViewPassengerButton);
            this.PassengerPanel.Controls.Add(this.PassengerDataGridView);
            this.PassengerPanel.Location = new System.Drawing.Point(3, 27);
            this.PassengerPanel.Name = "PassengerPanel";
            this.PassengerPanel.Size = new System.Drawing.Size(935, 447);
            this.PassengerPanel.TabIndex = 3;
            this.PassengerPanel.Visible = false;
            // 
            // ViewPassengerButton
            // 
            this.ViewPassengerButton.Location = new System.Drawing.Point(6, 3);
            this.ViewPassengerButton.Name = "ViewPassengerButton";
            this.ViewPassengerButton.Size = new System.Drawing.Size(159, 23);
            this.ViewPassengerButton.TabIndex = 1;
            this.ViewPassengerButton.Text = "Вывести всех клиентов";
            this.ViewPassengerButton.UseVisualStyleBackColor = true;
            this.ViewPassengerButton.Click += new System.EventHandler(this.ViewPassengerButton_Click);
            // 
            // PassengerDataGridView
            // 
            this.PassengerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PassengerDataGridView.Location = new System.Drawing.Point(3, 29);
            this.PassengerDataGridView.Name = "PassengerDataGridView";
            this.PassengerDataGridView.ReadOnly = true;
            this.PassengerDataGridView.Size = new System.Drawing.Size(929, 211);
            this.PassengerDataGridView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.PassengerPanel);
            this.Controls.Add(this.AircraftFleetPanel);
            this.Controls.Add(this.StaffPanel);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "База данных";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AircraftFleetPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AircraftFleetDataGridView)).EndInit();
            this.StaffPanel.ResumeLayout(false);
            this.StaffDeletePanel.ResumeLayout(false);
            this.StaffDeletePanel.PerformLayout();
            this.StaffAddPanel.ResumeLayout(false);
            this.StaffAddPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.PassengerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PassengerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Panel AircraftFleetPanel;
        private System.Windows.Forms.DataGridView AircraftFleetDataGridView;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button AircraftFleetButton;
        private System.Windows.Forms.Panel StaffPanel;
        private System.Windows.Forms.Button StaffAddButton;
        private System.Windows.Forms.Button StaffViewButton;
        private System.Windows.Forms.DataGridView StaffDataGridView;
        private System.Windows.Forms.Panel StaffAddPanel;
        private System.Windows.Forms.Button AddStaffInDBButton;
        private System.Windows.Forms.Label AddPositionLabel;
        private System.Windows.Forms.Label AddFatherNameLabel;
        private System.Windows.Forms.Label AddNameLabel;
        private System.Windows.Forms.Label AddSurnameLabel;
        private System.Windows.Forms.TextBox AddFatherNameTextBox;
        private System.Windows.Forms.TextBox AddNameTextBox;
        private System.Windows.Forms.TextBox AddSurnameTextBox;
        private System.Windows.Forms.ComboBox AddPositionComboBox;
        private System.Windows.Forms.Button StaffViewDeleteButton;
        private System.Windows.Forms.Panel StaffDeletePanel;
        private System.Windows.Forms.Label StaffDeleteFatherNameLabel;
        private System.Windows.Forms.Label StaffDeleteNameLabel;
        private System.Windows.Forms.Label StaffDeleteSurnameLabel;
        private System.Windows.Forms.TextBox StaffDeleteFatherNameTextBox;
        private System.Windows.Forms.TextBox StaffDeleteNameTextBox;
        private System.Windows.Forms.TextBox StaffDeleteSurnameTextBox;
        private System.Windows.Forms.Button StaffDeleteButton;
        private System.Windows.Forms.Panel PassengerPanel;
        private System.Windows.Forms.Button ViewPassengerButton;
        private System.Windows.Forms.DataGridView PassengerDataGridView;
    }
}