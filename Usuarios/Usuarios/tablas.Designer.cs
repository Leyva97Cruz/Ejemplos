namespace Usuarios
{
    partial class tablas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tablas));
            System.Windows.Forms.Label idCANTIDADLabel;
            System.Windows.Forms.Label nOMBRELabel;
            System.Windows.Forms.Label tIPO_DE_ELEMENTOLabel;
            System.Windows.Forms.Label pRECIOLabel;
            this.baseDataSet = new Usuarios.baseDataSet();
            this.dATOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATOSTableAdapter = new Usuarios.baseDataSetTableAdapters.DATOSTableAdapter();
            this.tableAdapterManager = new Usuarios.baseDataSetTableAdapters.TableAdapterManager();
            this.dATOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dATOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dATOSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCANTIDADTextBox = new System.Windows.Forms.TextBox();
            this.nOMBRETextBox = new System.Windows.Forms.TextBox();
            this.tIPO_DE_ELEMENTOTextBox = new System.Windows.Forms.TextBox();
            this.pRECIOTextBox = new System.Windows.Forms.TextBox();
            idCANTIDADLabel = new System.Windows.Forms.Label();
            nOMBRELabel = new System.Windows.Forms.Label();
            tIPO_DE_ELEMENTOLabel = new System.Windows.Forms.Label();
            pRECIOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATOSBindingNavigator)).BeginInit();
            this.dATOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dATOSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // baseDataSet
            // 
            this.baseDataSet.DataSetName = "baseDataSet";
            this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dATOSBindingSource
            // 
            this.dATOSBindingSource.DataMember = "DATOS";
            this.dATOSBindingSource.DataSource = this.baseDataSet;
            // 
            // dATOSTableAdapter
            // 
            this.dATOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DATOSTableAdapter = this.dATOSTableAdapter;
            this.tableAdapterManager.UpdateOrder = Usuarios.baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dATOSBindingNavigator
            // 
            this.dATOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dATOSBindingNavigator.BindingSource = this.dATOSBindingSource;
            this.dATOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dATOSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dATOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dATOSBindingNavigatorSaveItem});
            this.dATOSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dATOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dATOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dATOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dATOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dATOSBindingNavigator.Name = "dATOSBindingNavigator";
            this.dATOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dATOSBindingNavigator.Size = new System.Drawing.Size(838, 25);
            this.dATOSBindingNavigator.TabIndex = 0;
            this.dATOSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
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
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // dATOSBindingNavigatorSaveItem
            // 
            this.dATOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dATOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dATOSBindingNavigatorSaveItem.Image")));
            this.dATOSBindingNavigatorSaveItem.Name = "dATOSBindingNavigatorSaveItem";
            this.dATOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.dATOSBindingNavigatorSaveItem.Text = "Guardar datos";
            this.dATOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.dATOSBindingNavigatorSaveItem_Click);
            // 
            // dATOSDataGridView
            // 
            this.dATOSDataGridView.AutoGenerateColumns = false;
            this.dATOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dATOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dATOSDataGridView.DataSource = this.dATOSBindingSource;
            this.dATOSDataGridView.Location = new System.Drawing.Point(0, 28);
            this.dATOSDataGridView.Name = "dATOSDataGridView";
            this.dATOSDataGridView.Size = new System.Drawing.Size(448, 258);
            this.dATOSDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCANTIDAD";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdCANTIDAD";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TIPO DE ELEMENTO";
            this.dataGridViewTextBoxColumn3.HeaderText = "TIPO DE ELEMENTO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PRECIO";
            this.dataGridViewTextBoxColumn4.HeaderText = "PRECIO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // idCANTIDADLabel
            // 
            idCANTIDADLabel.AutoSize = true;
            idCANTIDADLabel.Location = new System.Drawing.Point(586, 62);
            idCANTIDADLabel.Name = "idCANTIDADLabel";
            idCANTIDADLabel.Size = new System.Drawing.Size(68, 13);
            idCANTIDADLabel.TabIndex = 2;
            idCANTIDADLabel.Text = " CANTIDAD:";
            // 
            // idCANTIDADTextBox
            // 
            this.idCANTIDADTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dATOSBindingSource, "IdCANTIDAD", true));
            this.idCANTIDADTextBox.Location = new System.Drawing.Point(687, 59);
            this.idCANTIDADTextBox.Name = "idCANTIDADTextBox";
            this.idCANTIDADTextBox.Size = new System.Drawing.Size(100, 20);
            this.idCANTIDADTextBox.TabIndex = 3;
            // 
            // nOMBRELabel
            // 
            nOMBRELabel.AutoSize = true;
            nOMBRELabel.Location = new System.Drawing.Point(597, 107);
            nOMBRELabel.Name = "nOMBRELabel";
            nOMBRELabel.Size = new System.Drawing.Size(57, 13);
            nOMBRELabel.TabIndex = 4;
            nOMBRELabel.Text = "NOMBRE:";
            // 
            // nOMBRETextBox
            // 
            this.nOMBRETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dATOSBindingSource, "NOMBRE", true));
            this.nOMBRETextBox.Location = new System.Drawing.Point(687, 100);
            this.nOMBRETextBox.Name = "nOMBRETextBox";
            this.nOMBRETextBox.Size = new System.Drawing.Size(100, 20);
            this.nOMBRETextBox.TabIndex = 5;
            // 
            // tIPO_DE_ELEMENTOLabel
            // 
            tIPO_DE_ELEMENTOLabel.AutoSize = true;
            tIPO_DE_ELEMENTOLabel.Location = new System.Drawing.Point(539, 149);
            tIPO_DE_ELEMENTOLabel.Name = "tIPO_DE_ELEMENTOLabel";
            tIPO_DE_ELEMENTOLabel.Size = new System.Drawing.Size(115, 13);
            tIPO_DE_ELEMENTOLabel.TabIndex = 6;
            tIPO_DE_ELEMENTOLabel.Text = "TIPO DE ELEMENTO:";
            // 
            // tIPO_DE_ELEMENTOTextBox
            // 
            this.tIPO_DE_ELEMENTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dATOSBindingSource, "TIPO DE ELEMENTO", true));
            this.tIPO_DE_ELEMENTOTextBox.Location = new System.Drawing.Point(687, 142);
            this.tIPO_DE_ELEMENTOTextBox.Name = "tIPO_DE_ELEMENTOTextBox";
            this.tIPO_DE_ELEMENTOTextBox.Size = new System.Drawing.Size(100, 20);
            this.tIPO_DE_ELEMENTOTextBox.TabIndex = 7;
            // 
            // pRECIOLabel
            // 
            pRECIOLabel.AutoSize = true;
            pRECIOLabel.Location = new System.Drawing.Point(604, 192);
            pRECIOLabel.Name = "pRECIOLabel";
            pRECIOLabel.Size = new System.Drawing.Size(50, 13);
            pRECIOLabel.TabIndex = 8;
            pRECIOLabel.Text = "PRECIO:";
            // 
            // pRECIOTextBox
            // 
            this.pRECIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dATOSBindingSource, "PRECIO", true));
            this.pRECIOTextBox.Location = new System.Drawing.Point(687, 185);
            this.pRECIOTextBox.Name = "pRECIOTextBox";
            this.pRECIOTextBox.Size = new System.Drawing.Size(100, 20);
            this.pRECIOTextBox.TabIndex = 9;
            // 
            // tablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(pRECIOLabel);
            this.Controls.Add(this.pRECIOTextBox);
            this.Controls.Add(tIPO_DE_ELEMENTOLabel);
            this.Controls.Add(this.tIPO_DE_ELEMENTOTextBox);
            this.Controls.Add(nOMBRELabel);
            this.Controls.Add(this.nOMBRETextBox);
            this.Controls.Add(idCANTIDADLabel);
            this.Controls.Add(this.idCANTIDADTextBox);
            this.Controls.Add(this.dATOSDataGridView);
            this.Controls.Add(this.dATOSBindingNavigator);
            this.Name = "tablas";
            this.Text = "tablas";
            this.Load += new System.EventHandler(this.tablas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATOSBindingNavigator)).EndInit();
            this.dATOSBindingNavigator.ResumeLayout(false);
            this.dATOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dATOSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private baseDataSet baseDataSet;
        private System.Windows.Forms.BindingSource dATOSBindingSource;
        private baseDataSetTableAdapters.DATOSTableAdapter dATOSTableAdapter;
        private baseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dATOSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dATOSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dATOSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox idCANTIDADTextBox;
        private System.Windows.Forms.TextBox nOMBRETextBox;
        private System.Windows.Forms.TextBox tIPO_DE_ELEMENTOTextBox;
        private System.Windows.Forms.TextBox pRECIOTextBox;
    }
}