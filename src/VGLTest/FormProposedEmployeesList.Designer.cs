using DevExpress.XtraEditors.Repository;

namespace VGLTest
{
    partial class FormProposedEmployeesList
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
            groupControl = new DevExpress.XtraEditors.GroupControl();
            btnDelete = new DevExpress.XtraEditors.SimpleButton();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            btnReset = new DevExpress.XtraEditors.SimpleButton();
            gridControl = new DevExpress.XtraGrid.GridControl();
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumnEmpCode = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnDept = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnOS = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnNS = new DevExpress.XtraGrid.Columns.GridColumn();
            numericEdit = new RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)groupControl).BeginInit();
            groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericEdit).BeginInit();
            SuspendLayout();
            // 
            // groupControl
            // 
            groupControl.Controls.Add(btnDelete);
            groupControl.Controls.Add(btnSave);
            groupControl.Controls.Add(btnReset);
            groupControl.Controls.Add(gridControl);
            groupControl.Location = new Point(9, 1);
            groupControl.Name = "groupControl";
            groupControl.Size = new Size(779, 437);
            groupControl.TabIndex = 0;
            groupControl.Text = "Danh sách đề xuất";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(533, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(614, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Lưu";
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(695, 409);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.Click += btnReset_Click;
            // 
            // gridControl
            // 
            gridControl.Location = new Point(5, 26);
            gridControl.MainView = gridView;
            gridControl.Name = "gridControl";
            gridControl.Size = new Size(769, 377);
            gridControl.TabIndex = 0;
            gridControl.UseEmbeddedNavigator = true;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumnEmpCode, gridColumnFullName, gridColumnDept, gridColumnOS, gridColumnNS });
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.RowStyle += gridView_RowStyle;
            gridView.CellValueChanging += gridView_CellValueChanging;
            // 
            // gridColumnEmpCode
            // 
            gridColumnEmpCode.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            gridColumnEmpCode.AppearanceHeader.Options.UseBackColor = true;
            gridColumnEmpCode.AppearanceHeader.Options.UseTextOptions = true;
            gridColumnEmpCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnEmpCode.Caption = "Mã nhân viên";
            gridColumnEmpCode.FieldName = "EmployeeId";
            gridColumnEmpCode.Name = "gridColumnEmpCode";
            gridColumnEmpCode.Visible = true;
            gridColumnEmpCode.VisibleIndex = 0;
            // 
            // gridColumnFullName
            // 
            gridColumnFullName.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            gridColumnFullName.AppearanceHeader.Options.UseBackColor = true;
            gridColumnFullName.AppearanceHeader.Options.UseTextOptions = true;
            gridColumnFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnFullName.Caption = "Họ tên";
            gridColumnFullName.FieldName = "FullName";
            gridColumnFullName.Name = "gridColumnFullName";
            gridColumnFullName.OptionsColumn.AllowEdit = false;
            gridColumnFullName.Visible = true;
            gridColumnFullName.VisibleIndex = 1;
            // 
            // gridColumnDept
            // 
            gridColumnDept.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            gridColumnDept.AppearanceHeader.Options.UseBackColor = true;
            gridColumnDept.AppearanceHeader.Options.UseTextOptions = true;
            gridColumnDept.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnDept.Caption = "Phòng ban";
            gridColumnDept.FieldName = "Department";
            gridColumnDept.Name = "gridColumnDept";
            gridColumnDept.OptionsColumn.AllowEdit = false;
            gridColumnDept.Visible = true;
            gridColumnDept.VisibleIndex = 2;
            // 
            // gridColumnOS
            // 
            gridColumnOS.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            gridColumnOS.AppearanceHeader.Options.UseBackColor = true;
            gridColumnOS.AppearanceHeader.Options.UseTextOptions = true;
            gridColumnOS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnOS.Caption = "Mức lương cũ";
            gridColumnOS.FieldName = "OldSalary";
            gridColumnOS.Name = "gridColumnOS";
            gridColumnOS.OptionsColumn.AllowEdit = false;
            gridColumnOS.Visible = true;
            gridColumnOS.VisibleIndex = 3;
            // 
            // gridColumnNS
            // 
            gridColumnNS.AppearanceCell.BackColor = Color.Thistle;
            gridColumnNS.AppearanceCell.Options.UseBackColor = true;
            gridColumnNS.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            gridColumnNS.AppearanceHeader.Options.UseBackColor = true;
            gridColumnNS.AppearanceHeader.Options.UseTextOptions = true;
            gridColumnNS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnNS.Caption = "Mức đề xuất tăng";
            gridColumnNS.ColumnEdit = numericEdit;
            gridColumnNS.FieldName = "NewSalary";
            gridColumnNS.Name = "gridColumnNS";
            gridColumnNS.Visible = true;
            gridColumnNS.VisibleIndex = 4;
            // 
            // numericEdit
            // 
            numericEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            numericEdit.Name = "numericEdit";
            // 
            // FormProposedEmployeesList
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupControl);
            Name = "FormProposedEmployeesList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách nhân viên được đề xuất tăng lương";
            ((System.ComponentModel.ISupportInitialize)groupControl).EndInit();
            groupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericEdit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEmpCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFullName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDept;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnOS;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNS;
        private RepositoryItemTextEdit numericEdit;
    }
}