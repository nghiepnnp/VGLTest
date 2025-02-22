using Data;
using Data.Models;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using System.ComponentModel;
using System.Data;

namespace VGLTest
{
    public partial class FormProposedEmployeesList : XtraForm
    {
        #region Local variable

        private List<ProposedEmployee> oldProposedEmployeeList = [];
        private HashSet<string> deletedRows = [];
        private HashSet<string> currentRows = [];

        #endregion

        /// <summary>
        /// Connstructor
        /// </summary>
        public FormProposedEmployeesList()
        {
            InitializeComponent();

            // Format salary
            gridView.Columns["OldSalary"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView.Columns["NewSalary"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView.Columns["OldSalary"].DisplayFormat.FormatString = "#,0 VNĐ";
            gridView.Columns["NewSalary"].DisplayFormat.FormatString = "#,0 VNĐ";

            RepositoryItemTextEdit numericEdit = new RepositoryItemTextEdit();
            numericEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            gridView.Columns["NewSalary"].ColumnEdit = numericEdit;

            #region GridLookUpEdit
            // Init GridLookUpEdit
            RepositoryItemGridLookUpEdit repositoryItem = new RepositoryItemGridLookUpEdit();
            repositoryItem.DataSource = Repository.EmployeeList;
            repositoryItem.ValueMember = "Id";  // Key
            repositoryItem.DisplayMember = "Id"; // Value

            // Custom popup select emp
            repositoryItem.PopupView = new GridView();
            GridView popupGridView = (GridView)repositoryItem.PopupView;
            popupGridView.OptionsView.ShowAutoFilterRow = true;

            popupGridView.Columns.AddField("Id").Visible = true;
            popupGridView.Columns.AddField("FullName").Visible = true;
            popupGridView.Columns.AddField("Department").Visible = true;
            popupGridView.Columns.AddField("Salary").Visible = true;
            popupGridView.Columns["Id"].Caption = "Mã nhân viên";
            popupGridView.Columns["FullName"].Caption = "Họ Tên";
            popupGridView.Columns["Department"].Caption = "Phòng ban";
            popupGridView.Columns["Salary"].Caption = "Lương";
            popupGridView.Columns["Salary"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            popupGridView.Columns["Salary"].DisplayFormat.FormatString = "#,0 VNĐ";
            popupGridView.OptionsView.ColumnAutoWidth = false;
            gridControl.RepositoryItems.Add(repositoryItem);
            gridView.Columns["EmployeeId"].ColumnEdit = repositoryItem;
            #endregion

            // Reset action rows
            deletedRows.Clear();
            currentRows = new HashSet<string>(Repository.ProposedEmployeeList
                .Select(x => x.EmployeeId));

            // Save data to reset 
            oldProposedEmployeeList = Repository.ProposedEmployeeList
                .Select(emp => emp.Clone()).ToList();

            // Data to gridview
            gridControl.DataSource = new BindingList<ProposedEmployee>(Repository.ProposedEmployeeList);
        }

        /// <summary>
        /// Event Reset Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            Repository.ProposedEmployeeList = oldProposedEmployeeList
                .Select(emp => emp.Clone()).ToList();
            gridControl.DataSource = new BindingList<ProposedEmployee>(Repository.ProposedEmployeeList);
            deletedRows.Clear();
            currentRows = new HashSet<string>(Repository.ProposedEmployeeList
                .Select(x => x.EmployeeId));
            gridView.RefreshData();
        }

        /// <summary>
        /// Event Delete Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowHandle = gridView.FocusedRowHandle;

            if (rowHandle >= 0)
            {
                string employeeId = (string)gridView.GetRowCellValue(rowHandle, "EmployeeId");

                if (!deletedRows.Contains(employeeId))
                {
                    deletedRows.Add(employeeId);
                }

                gridView.RefreshData();
            }
        }

        /// <summary>
        /// Event Save Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Delete row selected
            Repository.ProposedEmployeeList.Remove(x => deletedRows.Contains(x.EmployeeId));

            foreach(var rl in Repository.RequestList)
            {
                var data = Repository.ProposedEmployeeList.Where(x => x.Department == rl.Department).ToList();
                rl.Quantity = data.Count;
                rl.ProposedTotalSalaryIncrease = data.Sum(e => e.NewSalary - e.OldSalary);
            }

            this.Close();
        }

        /// <summary>
        /// gridView RowStyle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                string employeeId = (string)gridView.GetRowCellValue(e.RowHandle, "EmployeeId");
                if (deletedRows.Contains(employeeId))
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Strikeout);
                    e.Appearance.ForeColor = Color.WhiteSmoke;
                    e.Appearance.BackColor = Color.IndianRed;
                    e.HighPriority = true;
                }
            }
        }

        /// <summary>
        /// GridView CellValueChanging
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            if (gridView.IsNewItemRow(e.RowHandle))
            {
                gridView.AddNewRow();
                gridView.PostEditor();
                gridView.UpdateCurrentRow();
            }

            // Check if change "EmployeeId" 
            if (e.Column.FieldName == "EmployeeId")
            {

                Employee selectedEmployee = Repository.EmployeeList.FirstOrDefault(x => x.Id == e.Value);

                if (selectedEmployee != null)
                {
                    if (currentRows.Contains(e.Value) && e.OldValue != e.Value)
                    {
                        XtraMessageBox.Show("Nhân viên đã nằm trong danh sách, vui lòng chọn nhân viên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // if GridView is blank
                    if (!string.IsNullOrEmpty(e.OldValue?.ToString()))
                    {
                        currentRows.Remove(e.OldValue.ToString()!);
                    }

                    currentRows.Add(e.Value.ToString()!);

                    int rowHandle = gridView.FocusedRowHandle;

                    // Update data
                    gridView.SetRowCellValue(rowHandle, "EmployeeId", selectedEmployee.Id);
                    gridView.SetRowCellValue(rowHandle, "FullName", selectedEmployee.FullName);
                    gridView.SetRowCellValue(rowHandle, "Department", selectedEmployee.Department);
                    gridView.SetRowCellValue(rowHandle, "OldSalary", selectedEmployee.Salary);

                    if (e.OldValue != e.Value)
                    {
                        gridView.SetRowCellValue(rowHandle, "NewSalary", 0);
                    }

                    // Focus new edit salary
                    gridView.FocusedColumn = gridView.Columns["NewSalary"];
                    gridView.ShowEditor();
                }
            }
        }
    }
}
