namespace Registration_of_issuance_of_certificates
{
    partial class Form6
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
            System.Windows.Forms.Label номер_выпускникаLabel;
            System.Windows.Forms.Label номер_регистрацииLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.accountingCertificatesDataSet1 = new Registration_of_issuance_of_certificates.AccountingCertificatesDataSet1();
            this.the_number_of_the_certificateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.the_number_of_the_certificateTableAdapter = new Registration_of_issuance_of_certificates.AccountingCertificatesDataSet1TableAdapters.The_number_of_the_certificateTableAdapter();
            this.tableAdapterManager = new Registration_of_issuance_of_certificates.AccountingCertificatesDataSet1TableAdapters.TableAdapterManager();
            this.the_number_of_the_certificateBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.the_number_of_the_certificateBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.номер_выпускникаComboBox = new System.Windows.Forms.ComboBox();
            this.theNumberOfTheCertificateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.номер_регистрацииComboBox = new System.Windows.Forms.ComboBox();
            номер_выпускникаLabel = new System.Windows.Forms.Label();
            номер_регистрацииLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accountingCertificatesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_number_of_the_certificateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_number_of_the_certificateBindingNavigator)).BeginInit();
            this.the_number_of_the_certificateBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theNumberOfTheCertificateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // номер_выпускникаLabel
            // 
            номер_выпускникаLabel.AutoSize = true;
            номер_выпускникаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номер_выпускникаLabel.Location = new System.Drawing.Point(46, 93);
            номер_выпускникаLabel.Name = "номер_выпускникаLabel";
            номер_выпускникаLabel.Size = new System.Drawing.Size(200, 24);
            номер_выпускникаLabel.TabIndex = 3;
            номер_выпускникаLabel.Text = "Номер выпускника:";
            номер_выпускникаLabel.Click += new System.EventHandler(this.номер_выпускникаLabel_Click);
            // 
            // номер_регистрацииLabel
            // 
            номер_регистрацииLabel.AutoSize = true;
            номер_регистрацииLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номер_регистрацииLabel.Location = new System.Drawing.Point(46, 119);
            номер_регистрацииLabel.Name = "номер_регистрацииLabel";
            номер_регистрацииLabel.Size = new System.Drawing.Size(213, 24);
            номер_регистрацииLabel.TabIndex = 5;
            номер_регистрацииLabel.Text = "Номер регистрации:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(441, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // accountingCertificatesDataSet1
            // 
            this.accountingCertificatesDataSet1.DataSetName = "AccountingCertificatesDataSet1";
            this.accountingCertificatesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // the_number_of_the_certificateBindingSource
            // 
            this.the_number_of_the_certificateBindingSource.DataMember = "The number of the certificate";
            this.the_number_of_the_certificateBindingSource.DataSource = this.accountingCertificatesDataSet1;
            // 
            // the_number_of_the_certificateTableAdapter
            // 
            this.the_number_of_the_certificateTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.The_number_of_the_certificateTableAdapter = this.the_number_of_the_certificateTableAdapter;
            this.tableAdapterManager.UpdateOrder = Registration_of_issuance_of_certificates.AccountingCertificatesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // the_number_of_the_certificateBindingNavigator
            // 
            this.the_number_of_the_certificateBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.the_number_of_the_certificateBindingNavigator.BindingSource = this.the_number_of_the_certificateBindingSource;
            this.the_number_of_the_certificateBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.the_number_of_the_certificateBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.the_number_of_the_certificateBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.the_number_of_the_certificateBindingNavigatorSaveItem});
            this.the_number_of_the_certificateBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.the_number_of_the_certificateBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.the_number_of_the_certificateBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.the_number_of_the_certificateBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.the_number_of_the_certificateBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.the_number_of_the_certificateBindingNavigator.Name = "the_number_of_the_certificateBindingNavigator";
            this.the_number_of_the_certificateBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.the_number_of_the_certificateBindingNavigator.Size = new System.Drawing.Size(786, 25);
            this.the_number_of_the_certificateBindingNavigator.TabIndex = 8;
            this.the_number_of_the_certificateBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // the_number_of_the_certificateBindingNavigatorSaveItem
            // 
            this.the_number_of_the_certificateBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.the_number_of_the_certificateBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("the_number_of_the_certificateBindingNavigatorSaveItem.Image")));
            this.the_number_of_the_certificateBindingNavigatorSaveItem.Name = "the_number_of_the_certificateBindingNavigatorSaveItem";
            this.the_number_of_the_certificateBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.the_number_of_the_certificateBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.the_number_of_the_certificateBindingNavigatorSaveItem.Click += new System.EventHandler(this.the_number_of_the_certificateBindingNavigatorSaveItem_Click_2);
            // 
            // номер_выпускникаComboBox
            // 
            this.номер_выпускникаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.the_number_of_the_certificateBindingSource, "Номер выпускника", true));
            this.номер_выпускникаComboBox.DataSource = this.theNumberOfTheCertificateBindingSource;
            this.номер_выпускникаComboBox.DisplayMember = "Номер выпускника";
            this.номер_выпускникаComboBox.FormattingEnabled = true;
            this.номер_выпускникаComboBox.Location = new System.Drawing.Point(288, 96);
            this.номер_выпускникаComboBox.Name = "номер_выпускникаComboBox";
            this.номер_выпускникаComboBox.Size = new System.Drawing.Size(121, 21);
            this.номер_выпускникаComboBox.TabIndex = 9;
            this.номер_выпускникаComboBox.ValueMember = "Номер выпускника";
            // 
            // theNumberOfTheCertificateBindingSource
            // 
            this.theNumberOfTheCertificateBindingSource.DataMember = "The number of the certificate";
            this.theNumberOfTheCertificateBindingSource.DataSource = this.accountingCertificatesDataSet1;
            // 
            // номер_регистрацииComboBox
            // 
            this.номер_регистрацииComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.the_number_of_the_certificateBindingSource, "Номер регистрации", true));
            this.номер_регистрацииComboBox.DataSource = this.the_number_of_the_certificateBindingSource;
            this.номер_регистрацииComboBox.DisplayMember = "Номер регистрации";
            this.номер_регистрацииComboBox.FormattingEnabled = true;
            this.номер_регистрацииComboBox.Location = new System.Drawing.Point(288, 124);
            this.номер_регистрацииComboBox.Name = "номер_регистрацииComboBox";
            this.номер_регистрацииComboBox.Size = new System.Drawing.Size(121, 21);
            this.номер_регистрацииComboBox.TabIndex = 10;
            this.номер_регистрацииComboBox.ValueMember = "Номер регистрации";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 436);
            this.Controls.Add(this.номер_регистрацииComboBox);
            this.Controls.Add(this.номер_выпускникаComboBox);
            this.Controls.Add(this.the_number_of_the_certificateBindingNavigator);
            this.Controls.Add(номер_выпускникаLabel);
            this.Controls.Add(номер_регистрацииLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountingCertificatesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_number_of_the_certificateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_number_of_the_certificateBindingNavigator)).EndInit();
            this.the_number_of_the_certificateBindingNavigator.ResumeLayout(false);
            this.the_number_of_the_certificateBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theNumberOfTheCertificateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private AccountingCertificatesDataSet1 accountingCertificatesDataSet1;
        private System.Windows.Forms.BindingSource the_number_of_the_certificateBindingSource;
        private AccountingCertificatesDataSet1TableAdapters.The_number_of_the_certificateTableAdapter the_number_of_the_certificateTableAdapter;
        private AccountingCertificatesDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator the_number_of_the_certificateBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton the_number_of_the_certificateBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox номер_выпускникаComboBox;
        private System.Windows.Forms.ComboBox номер_регистрацииComboBox;
        private System.Windows.Forms.BindingSource theNumberOfTheCertificateBindingSource;
    }
}