using Data;
using Data.Models;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using System.ComponentModel;

namespace VGLTest
{
    public partial class FormDepartmentsSalaryIncreaseReq : XtraForm
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FormDepartmentsSalaryIncreaseReq()
        {
            InitializeComponent();

            // Format salary
            gridView.Columns["ProposedTotalSalaryIncrease"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView.Columns["ProposedTotalSalaryIncrease"].DisplayFormat.FormatString = "#,0 VNĐ";

            // Create button action
            RepositoryItemButtonEdit buttonEdit = new();
            buttonEdit.TextEditStyle = TextEditStyles.HideTextEditor;
            buttonEdit.Buttons[0].Kind = ButtonPredefines.Glyph;
            buttonEdit.Buttons[0].Caption = "Xử lý";

            //buttonEdit.Buttons[0].Appearance.BackColor = Color.Blue;
            buttonEdit.Buttons[0].Appearance.ForeColor = Color.Red;
            buttonEdit.Buttons[0].Appearance.Options.UseBackColor = true;
            buttonEdit.Buttons[0].Appearance.Options.UseForeColor = true;

            buttonEdit.Padding = new Padding(5, 2, 5, 2);
            buttonEdit.ButtonClick += ButtonEdit_ButtonClick;

            // to GridView
            gridControlDept.RepositoryItems.Add(buttonEdit);
            gridView.Columns["Action"].ColumnEdit = buttonEdit;
            gridControlDept.DataSource = new BindingList<RequestList>(Repository.RequestList);
        }

        /// <summary>
        /// Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FormProposedEmployeesList form = new();
            form.FormClosed += (s, e) => UpdateData();
            form.ShowDialog();
        }

        /// <summary>
        /// Update Data
        /// </summary>
        private void UpdateData()
        {
            gridControlDept.DataSource = new BindingList<RequestList>(Repository.RequestList);
            gridView.RefreshData();
        }
    }
}
