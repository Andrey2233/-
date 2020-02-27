namespace Registration_of_issuance_of_certificates
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.accountingCertificatesDataSet = new Registration_of_issuance_of_certificates.AccountingCertificatesDataSet();
            this.number_of_the_finished_certificateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.number_of_the_finished_certificateTableAdapter = new Registration_of_issuance_of_certificates.AccountingCertificatesDataSetTableAdapters.Number_of_the_finished_certificateTableAdapter();
            this.tableAdapterManager = new Registration_of_issuance_of_certificates.AccountingCertificatesDataSetTableAdapters.TableAdapterManager();
            this.number_of_the_finished_certificateBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.number_of_the_finished_certificateBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.number_of_the_finished_certificateDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountingCertificatesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_the_finished_certificateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_the_finished_certificateBindingNavigator)).BeginInit();
            this.number_of_the_finished_certificateBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_the_finished_certificateDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(690, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(343, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // accountingCertificatesDataSet
            // 
            this.accountingCertificatesDataSet.DataSetName = "AccountingCertificatesDataSet";
            this.accountingCertificatesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // number_of_the_finished_certificateBindingSource
            // 
            this.number_of_the_finished_certificateBindingSource.DataMember = "Number of the finished certificate";
            this.number_of_the_finished_certificateBindingSource.DataSource = this.accountingCertificatesDataSet;
            // 
            // number_of_the_finished_certificateTableAdapter
            // 
            this.number_of_the_finished_certificateTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CertificateTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.Number_of_the_finished_certificateTableAdapter = this.number_of_the_finished_certificateTableAdapter;
            this.tableAdapterManager.The_number_of_the_certificate_of_graduateTableAdapter = null;
            this.tableAdapterManager.The_number_of_the_certificateTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Registration_of_issuance_of_certificates.AccountingCertificatesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // number_of_the_finished_certificateBindingNavigator
            // 
            this.number_of_the_finished_certificateBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.number_of_the_finished_certificateBindingNavigator.BindingSource = this.number_of_the_finished_certificateBindingSource;
            this.number_of_the_finished_certificateBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.number_of_the_finished_certificateBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.number_of_the_finished_certificateBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.number_of_the_finished_certificateBindingNavigatorSaveItem});
            this.number_of_the_finished_certificateBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.number_of_the_finished_certificateBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.number_of_the_finished_certificateBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.number_of_the_finished_certificateBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.number_of_the_finished_certificateBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.number_of_the_finished_certificateBindingNavigator.Name = "number_of_the_finished_certificateBindingNavigator";
            this.number_of_the_finished_certificateBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.number_of_the_finished_certificateBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.number_of_the_finished_certificateBindingNavigator.TabIndex = 13;
            this.number_of_the_finished_certificateBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // number_of_the_finished_certificateBindingNavigatorSaveItem
            // 
            this.number_of_the_finished_certificateBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.number_of_the_finished_certificateBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("number_of_the_finished_certificateBindingNavigatorSaveItem.Image")));
            this.number_of_the_finished_certificateBindingNavigatorSaveItem.Name = "number_of_the_finished_certificateBindingNavigatorSaveItem";
            this.number_of_the_finished_certificateBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.number_of_the_finished_certificateBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.number_of_the_finished_certificateBindingNavigatorSaveItem.Click += new System.EventHandler(this.number_of_the_finished_certificateBindingNavigatorSaveItem_Click);
            // 
            // number_of_the_finished_certificateDataGridView
            // 
            this.number_of_the_finished_certificateDataGridView.AutoGenerateColumns = false;
            this.number_of_the_finished_certificateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.number_of_the_finished_certificateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.number_of_the_finished_certificateDataGridView.DataSource = this.number_of_the_finished_certificateBindingSource;
            this.number_of_the_finished_certificateDataGridView.Location = new System.Drawing.Point(12, 63);
            this.number_of_the_finished_certificateDataGridView.Name = "number_of_the_finished_certificateDataGridView";
            this.number_of_the_finished_certificateDataGridView.Size = new System.Drawing.Size(776, 220);
            this.number_of_the_finished_certificateDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID certificate";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID certificate";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Итоговые оценки";
            this.dataGridViewTextBoxColumn3.HeaderText = "Итоговые оценки";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Общий балл";
            this.dataGridViewTextBoxColumn4.HeaderText = "Общий балл";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Номер сертификата";
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер сертификата";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дата выдачи";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата выдачи";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.number_of_the_finished_certificateDataGridView);
            this.Controls.Add(this.number_of_the_finished_certificateBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.Text = "Номер готового аттестата";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountingCertificatesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_the_finished_certificateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_the_finished_certificateBindingNavigator)).EndInit();
            this.number_of_the_finished_certificateBindingNavigator.ResumeLayout(false);
            this.number_of_the_finished_certificateBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_the_finished_certificateDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private AccountingCertificatesDataSet accountingCertificatesDataSet;
        private System.Windows.Forms.BindingSource number_of_the_finished_certificateBindingSource;
        private AccountingCertificatesDataSetTableAdapters.Number_of_the_finished_certificateTableAdapter number_of_the_finished_certificateTableAdapter;
        private AccountingCertificatesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator number_of_the_finished_certificateBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton number_of_the_finished_certificateBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView number_of_the_finished_certificateDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}