namespace VGLTest
{
    partial class FormDepartmentsSalaryIncreaseReq
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupControl = new DevExpress.XtraEditors.GroupControl();
            gridControlDept = new DevExpress.XtraGrid.GridControl();
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnAction = new DevExpress.XtraGrid.Columns.GridColumn();
            checkedComboBoxEdit1 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            asdf = new DevExpress.XtraTreeList.Columns.TreeListBand();
            ((System.ComponentModel.ISupportInitialize)groupControl).BeginInit();
            groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlDept).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkedComboBoxEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // groupControl
            // 
            groupControl.Appearance.BackColor = Color.Blue;
            groupControl.Appearance.Options.UseBackColor = true;
            groupControl.AutoSize = true;
            groupControl.Controls.Add(gridControlDept);
            groupControl.Controls.Add(checkedComboBoxEdit1);
            groupControl.Controls.Add(labelControl1);
            groupControl.Dock = DockStyle.Fill;
            groupControl.Location = new Point(0, 0);
            groupControl.Name = "groupControl";
            groupControl.Padding = new Padding(0, 50, 0, 50);
            groupControl.Size = new Size(800, 450);
            groupControl.TabIndex = 1;
            groupControl.Text = "Danh sách yêu cầu";
            // 
            // gridControlDept
            // 
            gridControlDept.Location = new Point(12, 59);
            gridControlDept.MainView = gridView;
            gridControlDept.Name = "gridControlDept";
            gridControlDept.Size = new Size(776, 379);
            gridControlDept.TabIndex = 3;
            gridControlDept.UseEmbeddedNavigator = true;
            gridControlDept.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumnQuantity, gridColumnTotal, gridColumnAction });
            gridView.GridControl = gridControlDept;
            gridView.Name = "gridView";
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(gridColumn1, DevExpress.Data.ColumnSortOrder.Descending) });
            // 
            // gridColumn1
            // 
            gridColumn1.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn1.Caption = "Phòng ban";
            gridColumn1.FieldName = "Department";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.OptionsColumn.AllowEdit = false;
            gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            // 
            // gridColumnQuantity
            // 
            gridColumnQuantity.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            gridColumnQuantity.AppearanceHeader.Options.UseBackColor = true;
            gridColumnQuantity.AppearanceHeader.Options.UseTextOptions = true;
            gridColumnQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnQuantity.Caption = "Số lượng";
            gridColumnQuantity.FieldName = "Quantity";
            gridColumnQuantity.Name = "gridColumnQuantity";
            gridColumnQuantity.OptionsColumn.AllowEdit = false;
            gridColumnQuantity.Visible = true;
            gridColumnQuantity.VisibleIndex = 1;
            // 
            // gridColumnTotal
            // 
            gridColumnTotal.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            gridColumnTotal.AppearanceHeader.Options.UseBackColor = true;
            gridColumnTotal.AppearanceHeader.Options.UseTextOptions = true;
            gridColumnTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnTotal.Caption = "Tổng đề xuất";
            gridColumnTotal.FieldName = "ProposedTotalSalaryIncrease";
            gridColumnTotal.Name = "gridColumnTotal";
            gridColumnTotal.OptionsColumn.AllowEdit = false;
            gridColumnTotal.Visible = true;
            gridColumnTotal.VisibleIndex = 2;
            // 
            // gridColumnAction
            // 
            gridColumnAction.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            gridColumnAction.AppearanceHeader.Options.UseBackColor = true;
            gridColumnAction.AppearanceHeader.Options.UseTextOptions = true;
            gridColumnAction.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnAction.Caption = "Hành động";
            gridColumnAction.FieldName = "Action";
            gridColumnAction.Name = "gridColumnAction";
            gridColumnAction.OptionsColumn.AllowShowHide = false;
            gridColumnAction.Visible = true;
            gridColumnAction.VisibleIndex = 3;
            // 
            // checkedComboBoxEdit1
            // 
            checkedComboBoxEdit1.Enabled = false;
            checkedComboBoxEdit1.Location = new Point(81, 33);
            checkedComboBoxEdit1.Name = "checkedComboBoxEdit1";
            checkedComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            checkedComboBoxEdit1.Size = new Size(179, 20);
            checkedComboBoxEdit1.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(12, 36);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(51, 13);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Phòng ban";
            // 
            // asdf
            // 
            asdf.Caption = "treeListBand1";
            asdf.Name = "asdf";
            // 
            // FormDepartmentsSalaryIncreaseReq
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupControl);
            Name = "FormDepartmentsSalaryIncreaseReq";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách yêu cầu tăng lương các bộ phận";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)groupControl).EndInit();
            groupControl.ResumeLayout(false);
            groupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlDept).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkedComboBoxEdit1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTreeList.Columns.TreeListBand asdf;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit1;
        private DevExpress.XtraGrid.GridControl gridControlDept;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAction;
    }
}
