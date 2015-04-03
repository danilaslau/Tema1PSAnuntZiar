namespace Tema1PS3Layers.GUI
{
    partial class FrmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.btnAddAdv = new System.Windows.Forms.Button();
            this.btnUpdateAd = new System.Windows.Forms.Button();
            this.btnDeleteAd = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.advertisementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advertisementBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.advertisementBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.advertisementDataGridView = new System.Windows.Forms.DataGridView();
            this.dgvColAdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColOccurrenceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColPicture1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvColPicture2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvColPicture3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvColUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.advertisementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertisementBindingNavigator)).BeginInit();
            this.advertisementBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advertisementDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAdv
            // 
            this.btnAddAdv.Location = new System.Drawing.Point(663, 79);
            this.btnAddAdv.Name = "btnAddAdv";
            this.btnAddAdv.Size = new System.Drawing.Size(89, 41);
            this.btnAddAdv.TabIndex = 1;
            this.btnAddAdv.Text = "Add Advertisement";
            this.btnAddAdv.UseVisualStyleBackColor = true;
            this.btnAddAdv.Click += new System.EventHandler(this.btnAddAdv_Click);
            // 
            // btnUpdateAd
            // 
            this.btnUpdateAd.Location = new System.Drawing.Point(663, 145);
            this.btnUpdateAd.Name = "btnUpdateAd";
            this.btnUpdateAd.Size = new System.Drawing.Size(89, 38);
            this.btnUpdateAd.TabIndex = 2;
            this.btnUpdateAd.Text = "Update Advertisement";
            this.btnUpdateAd.UseVisualStyleBackColor = true;
            this.btnUpdateAd.Click += new System.EventHandler(this.btnUpdateAd_Click);
            // 
            // btnDeleteAd
            // 
            this.btnDeleteAd.Location = new System.Drawing.Point(663, 208);
            this.btnDeleteAd.Name = "btnDeleteAd";
            this.btnDeleteAd.Size = new System.Drawing.Size(89, 37);
            this.btnDeleteAd.TabIndex = 3;
            this.btnDeleteAd.Text = "Delete Advertisement";
            this.btnDeleteAd.UseVisualStyleBackColor = true;
            this.btnDeleteAd.Click += new System.EventHandler(this.btnDeleteAd_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(663, 390);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(89, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // advertisementBindingSource
            // 
            this.advertisementBindingSource.DataSource = typeof(Tema1PS3Layers.BL.Entities.Advertisement);
            // 
            // advertisementBindingNavigator
            // 
            this.advertisementBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.advertisementBindingNavigator.BindingSource = this.advertisementBindingSource;
            this.advertisementBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.advertisementBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.advertisementBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.advertisementBindingNavigatorSaveItem});
            this.advertisementBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.advertisementBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.advertisementBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.advertisementBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.advertisementBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.advertisementBindingNavigator.Name = "advertisementBindingNavigator";
            this.advertisementBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.advertisementBindingNavigator.Size = new System.Drawing.Size(774, 25);
            this.advertisementBindingNavigator.TabIndex = 5;
            this.advertisementBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // advertisementBindingNavigatorSaveItem
            // 
            this.advertisementBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.advertisementBindingNavigatorSaveItem.Enabled = false;
            this.advertisementBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("advertisementBindingNavigatorSaveItem.Image")));
            this.advertisementBindingNavigatorSaveItem.Name = "advertisementBindingNavigatorSaveItem";
            this.advertisementBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.advertisementBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // advertisementDataGridView
            // 
            this.advertisementDataGridView.AllowUserToAddRows = false;
            this.advertisementDataGridView.AllowUserToResizeColumns = false;
            this.advertisementDataGridView.AllowUserToResizeRows = false;
            this.advertisementDataGridView.AutoGenerateColumns = false;
            this.advertisementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advertisementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColAdID,
            this.dgvColOccurrenceNo,
            this.dgvColDescription,
            this.dgvColPicture1,
            this.dgvColPicture2,
            this.dgvColPicture3,
            this.dgvColUserId});
            this.advertisementDataGridView.DataSource = this.advertisementBindingSource;
            this.advertisementDataGridView.Location = new System.Drawing.Point(12, 39);
            this.advertisementDataGridView.Name = "advertisementDataGridView";
            this.advertisementDataGridView.ReadOnly = true;
            this.advertisementDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.advertisementDataGridView.Size = new System.Drawing.Size(634, 374);
            this.advertisementDataGridView.TabIndex = 5;
            // 
            // dgvColAdID
            // 
            this.dgvColAdID.DataPropertyName = "AdID";
            this.dgvColAdID.HeaderText = "AdID";
            this.dgvColAdID.Name = "dgvColAdID";
            this.dgvColAdID.ReadOnly = true;
            this.dgvColAdID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvColOccurrenceNo
            // 
            this.dgvColOccurrenceNo.DataPropertyName = "OccurrenceNo";
            this.dgvColOccurrenceNo.HeaderText = "OccurrenceNo";
            this.dgvColOccurrenceNo.Name = "dgvColOccurrenceNo";
            this.dgvColOccurrenceNo.ReadOnly = true;
            this.dgvColOccurrenceNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvColDescription
            // 
            this.dgvColDescription.DataPropertyName = "Description";
            this.dgvColDescription.HeaderText = "Description";
            this.dgvColDescription.Name = "dgvColDescription";
            this.dgvColDescription.ReadOnly = true;
            this.dgvColDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvColPicture1
            // 
            this.dgvColPicture1.DataPropertyName = "Picture1";
            this.dgvColPicture1.HeaderText = "Picture1";
            this.dgvColPicture1.Name = "dgvColPicture1";
            this.dgvColPicture1.ReadOnly = true;
            // 
            // dgvColPicture2
            // 
            this.dgvColPicture2.DataPropertyName = "Picture2";
            this.dgvColPicture2.HeaderText = "Picture2";
            this.dgvColPicture2.Name = "dgvColPicture2";
            this.dgvColPicture2.ReadOnly = true;
            // 
            // dgvColPicture3
            // 
            this.dgvColPicture3.DataPropertyName = "Picture3";
            this.dgvColPicture3.HeaderText = "Picture3";
            this.dgvColPicture3.Name = "dgvColPicture3";
            this.dgvColPicture3.ReadOnly = true;
            // 
            // dgvColUserId
            // 
            this.dgvColUserId.DataPropertyName = "UserId";
            this.dgvColUserId.HeaderText = "UserId";
            this.dgvColUserId.Name = "dgvColUserId";
            this.dgvColUserId.ReadOnly = true;
            this.dgvColUserId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 433);
            this.Controls.Add(this.advertisementDataGridView);
            this.Controls.Add(this.advertisementBindingNavigator);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDeleteAd);
            this.Controls.Add(this.btnUpdateAd);
            this.Controls.Add(this.btnAddAdv);
            this.Name = "FrmUser";
            this.Text = "Regular User";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUser_FormClosed);
            this.Load += new System.EventHandler(this.FrmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advertisementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertisementBindingNavigator)).EndInit();
            this.advertisementBindingNavigator.ResumeLayout(false);
            this.advertisementBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advertisementDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAdv;
        private System.Windows.Forms.Button btnUpdateAd;
        private System.Windows.Forms.Button btnDeleteAd;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.BindingSource advertisementBindingSource;
        private System.Windows.Forms.BindingNavigator advertisementBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton advertisementBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView advertisementDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColAdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColOccurrenceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColDescription;
        private System.Windows.Forms.DataGridViewImageColumn dgvColPicture1;
        private System.Windows.Forms.DataGridViewImageColumn dgvColPicture2;
        private System.Windows.Forms.DataGridViewImageColumn dgvColPicture3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColUserId;
    }
}