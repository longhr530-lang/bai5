namespace nguyenhailongb5
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Events
            this.Load += Form1_Load;
            this.timerClock.Tick += TimerClock_Tick;
            this.dataGridViewItems.CellValidating += DataGridViewItems_CellValidating;
            this.dataGridViewItems.CellEndEdit += DataGridViewItems_CellEndEdit;
            this.dataGridViewItems.CellValueChanged += DataGridViewItems_CellValueChanged;
            this.dataGridViewItems.RowsRemoved += DataGridViewItems_RowsRemoved;
            this.dataGridViewItems.UserDeletingRow += DataGridViewItems_UserDeletingRow;
            this.dataGridViewItems.KeyDown += DataGridViewItems_KeyDown;
            this.KeyDown += Form1_KeyDown;
            this.dataGridViewItems.DefaultValuesNeeded += DataGridViewItems_DefaultValuesNeeded;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            // start clock
            timerClock.Start();

            // set default shipping
            if (cmbShippingType.Items.Count > 0)
                cmbShippingType.SelectedIndex = 0;

            // format numeric columns
            colQuantity.DefaultCellStyle.Format = "N0";
            colWeight.DefaultCellStyle.Format = "N2";
            colUnitPrice.DefaultCellStyle.Format = "N2";
            colTotal.DefaultCellStyle.Format = "N2";

            RecalculateAllTotals();
        }

        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            lblTime.Text = "Thời gian: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void DataGridViewItems_DefaultValuesNeeded(object? sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["colQuantity"].Value = 1;
            e.Row.Cells["colWeight"].Value = 0.0m;
            e.Row.Cells["colUnitPrice"].Value = 0.0m;
        }

        private void DataGridViewItems_KeyDown(object? sender, KeyEventArgs e)
        {
            // handled at row level
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                // add new row
                int idx = dataGridViewItems.Rows.Add();
                // focus new row
                if (idx >= 0)
                {
                    dataGridViewItems.CurrentCell = dataGridViewItems.Rows[idx].Cells[0];
                    dataGridViewItems.BeginEdit(true);
                }
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                // only delete when grid has focus
                if (dataGridViewItems.ContainsFocus)
                {
                    DeleteSelectedRows();
                    e.Handled = true;
                }
            }
        }

        private void DataGridViewItems_RowsRemoved(object? sender, DataGridViewRowsRemovedEventArgs e)
        {
            RecalculateAllTotals();
        }

        private void DataGridViewItems_UserDeletingRow(object? sender, DataGridViewRowCancelEventArgs e)
        {
            // recalc after delete
            this.BeginInvoke(new Action(RecalculateAllTotals));
        }

        private void DataGridViewItems_CellValidating(object? sender, DataGridViewCellValidatingEventArgs e)
        {
            var colName = dataGridViewItems.Columns[e.ColumnIndex].Name;
            if (colName == "colQuantity" || colName == "colWeight")
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue?.ToString()))
                {
                    var editingCtlEmpty = dataGridViewItems.EditingControl;
                    if (editingCtlEmpty != null)
                        errorProvider.SetError(editingCtlEmpty, "Giá trị không được để trống.");
                    else
                        dataGridViewItems.Rows[e.RowIndex].ErrorText = "Giá trị không được để trống.";
                    e.Cancel = true;
                    return;
                }

                if (decimal.TryParse(e.FormattedValue.ToString(), NumberStyles.Any, CultureInfo.CurrentCulture, out decimal val))
                {
                    if (val <= 0)
                    {
                        // show error near current cell
                        var editingCtl = dataGridViewItems.EditingControl;
                        if (editingCtl != null)
                        {
                            errorProvider.SetIconAlignment(editingCtl, ErrorIconAlignment.MiddleRight);
                            errorProvider.SetError(editingCtl, "Giá trị phải lớn hơn 0.");
                        }
                        else
                        {
                            dataGridViewItems.Rows[e.RowIndex].ErrorText = "Giá trị phải lớn hơn 0.";
                        }
                        e.Cancel = true;
                        return;
                    }
                }
                else
                {
                    var editingCtlInvalid = dataGridViewItems.EditingControl;
                    if (editingCtlInvalid != null)
                        errorProvider.SetError(editingCtlInvalid, "Giá trị không hợp lệ.");
                    else
                        dataGridViewItems.Rows[e.RowIndex].ErrorText = "Giá trị không hợp lệ.";
                    e.Cancel = true;
                    return;
                }
            }
            // clear any editing control error
            var ed = dataGridViewItems.EditingControl;
            if (ed != null) errorProvider.SetError(ed, string.Empty);
            dataGridViewItems.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        private void DataGridViewItems_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            // clear error for that cell / editing control
            var ed = dataGridViewItems.EditingControl;
            if (ed != null) errorProvider.SetError(ed, string.Empty);
            if (e.RowIndex >= 0) dataGridViewItems.Rows[e.RowIndex].ErrorText = string.Empty;
            CalculateRowTotal(e.RowIndex);
            RecalculateAllTotals();
        }

        private void DataGridViewItems_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CalculateRowTotal(e.RowIndex);
                RecalculateAllTotals();
            }
        }

        private void CalculateRowTotal(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dataGridViewItems.Rows.Count) return;
            var row = dataGridViewItems.Rows[rowIndex];
            if (row.IsNewRow) return;

            decimal quantity = SafeDecimal(row.Cells["colQuantity"].Value);
            decimal weight = SafeDecimal(row.Cells["colWeight"].Value);
            decimal unitPrice = SafeDecimal(row.Cells["colUnitPrice"].Value);

            // Thành tiền = Số lượng * Đơn giá
            decimal total = quantity * unitPrice;
            row.Cells["colTotal"].Value = total;
        }

        private decimal SafeDecimal(object? value)
        {
            if (value == null || value == DBNull.Value) return 0m;
            if (value is decimal d) return d;
            if (value is int i) return i;
            if (decimal.TryParse(value.ToString(), NumberStyles.Any, CultureInfo.CurrentCulture, out decimal res)) return res;
            return 0m;
        }

        private void RecalculateAllTotals()
        {
            decimal totalQty = 0m;
            decimal totalWeight = 0m;
            decimal totalAmount = 0m;

            foreach (DataGridViewRow row in dataGridViewItems.Rows)
            {
                if (row.IsNewRow) continue;
                decimal qty = SafeDecimal(row.Cells["colQuantity"].Value);
                decimal weight = SafeDecimal(row.Cells["colWeight"].Value);
                decimal amount = SafeDecimal(row.Cells["colTotal"].Value);

                totalQty += qty;
                totalWeight += qty * weight;
                totalAmount += amount;
            }

            lblTotalQuantity.Text = $"Tổng số lượng: {totalQty:N0}";
            lblTotalWeight.Text = $"Tổng trọng lượng: {totalWeight:N2} kg";
            lblTotalPrice.Text = $"Tổng tiền: {totalAmount:N2}";
        }

        private void DeleteSelectedRows()
        {
            if (dataGridViewItems.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewItems.SelectedRows)
                {
                    if (!row.IsNewRow)
                        dataGridViewItems.Rows.Remove(row);
                }
                RecalculateAllTotals();
            }
            else if (dataGridViewItems.CurrentCell != null)
            {
                var row = dataGridViewItems.Rows[dataGridViewItems.CurrentCell.RowIndex];
                if (!row.IsNewRow)
                    dataGridViewItems.Rows.RemoveAt(row.Index);
                RecalculateAllTotals();
            }
        }
    }
}
