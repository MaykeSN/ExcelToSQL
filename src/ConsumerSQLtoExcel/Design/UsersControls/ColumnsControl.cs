using ConsumerSQLtoExcel.Entities;
namespace ConsumerSQLtoExcel.Design.UsersControls
{
    public partial class ColumnsControl : UserControl
    {
        private string ColumnSql { get; set; }
        private string ColumnExcel { get; set; }
        public ColumnsControl(string columnExcel)
        {
            InitializeComponent();
            ColumnExcel = columnExcel;
            LblColumn.Text = ColumnExcel;
        }
        public bool ValidateControl()
        {
            return !string.IsNullOrEmpty(ColumnSql);
        }
        internal Columns GetColumns()
        {
            Columns col = new()
            {
                ExcelColumn = ColumnExcel,
                SqlColumn = ColumnSql
            };

            return col;
        }
        private void TxtSqlColumnTextChanged(object sender, EventArgs e)
        {
            ColumnSql = TxtSqlColumn.Text.Trim();
        }
    }
}
