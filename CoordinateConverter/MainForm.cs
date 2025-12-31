using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CoordinateConverter
{
    public partial class MainForm : Form
    {
        // Define matrices
        int num = 36;
        Matrix X = new Matrix(7, 1);
        Matrix B = new Matrix(36, 7);
        Matrix V = new Matrix(36, 1);
        Matrix L = new Matrix(36, 1);
        Matrix Place = new Matrix(36, 1);
        Matrix CGCS2000 = new Matrix(36, 1);
        Matrix XYZCon = new Matrix(18, 1);
        Matrix XYZKnown = new Matrix(18, 1);
        Matrix B1 = new Matrix(18, 7);
        Matrix NBB_1 = new Matrix(7, 7);

        double[,] x = new double[7, 1];
        double[,] b = new double[36, 7];
        double[,] v = new double[36, 1];
        double[,] l = new double[36, 1];
        double[,] place = new double[36, 1];
        double[,] cgcs = new double[36, 1];
        double[,] xyzcon = new double[18, 1];
        double[,] xyzknown = new double[18, 1];
        double[,] b1 = new double[18, 7];
        double sigma;
        double[] nbb_1 = new double[7];

        public MainForm()
        {
            InitializeComponent();
            UpdateStatus("就绪");

            // Enable keyboard shortcuts
            this.KeyPreview = true;
            this.KeyDown += MainForm_KeyDown;

            // Apply zebra striping to grids
            ApplyZebraStriping(this.dataGridView1);
            ApplyZebraStriping(this.dataGridView2);
            ApplyZebraStriping(this.dataGridView3);
            ApplyZebraStriping(this.dataGridView4);
        }

        // Apply zebra striping to DataGridView
        private void ApplyZebraStriping(DataGridView dgv)
        {
            dgv.RowPostPaint += (sender, e) =>
            {
                DataGridView grid = sender as DataGridView;
                if (e.RowIndex >= 0 && e.RowIndex < grid.Rows.Count)
                {
                    if (e.RowIndex % 2 == 0)
                    {
                        grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    }
                    else
                    {
                        grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
                    }
                }
            };
        }

        // Keyboard shortcuts handler
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Ctrl+I: Import Local Coordinates
            if (e.Control && e.KeyCode == Keys.I)
            {
                导入区域坐标ToolStripMenuItem_Click(sender, e);
                e.Handled = true;
            }
            // Ctrl+G: Import CGCS2000 Coordinates
            else if (e.Control && e.KeyCode == Keys.G)
            {
                导入CGCS2000坐标ToolStripMenuItem_Click(sender, e);
                e.Handled = true;
            }
            // Ctrl+C: Calculate 7 Parameters
            else if (e.Control && e.KeyCode == Keys.C)
            {
                计算转换7参数ToolStripMenuItem_Click(sender, e);
                e.Handled = true;
            }
            // Ctrl+T: Calculate Coordinates
            else if (e.Control && e.KeyCode == Keys.T)
            {
                计算转换坐标ToolStripMenuItem_Click(sender, e);
                e.Handled = true;
            }
            // Ctrl+E: Export Coordinates
            else if (e.Control && e.KeyCode == Keys.E)
            {
                导出转换后坐标ToolStripMenuItem_Click(sender, e);
                e.Handled = true;
            }
            // Escape: Clear status
            else if (e.KeyCode == Keys.Escape)
            {
                UpdateStatus("就绪");
                e.Handled = true;
            }
        }

        // Update status bar
        private void UpdateStatus(string message)
        {
            statusLabel.Text = message;
            statusStrip1.Invalidate();
        }

        // Toolbar button event handlers
        private void btnImportLocal_Click(object sender, EventArgs e)
        {
            导入区域坐标ToolStripMenuItem_Click(sender, e);
        }

        private void btnImportCGCS_Click(object sender, EventArgs e)
        {
            导入CGCS2000坐标ToolStripMenuItem_Click(sender, e);
        }

        private void btnCalcParams_Click(object sender, EventArgs e)
        {
            计算转换7参数ToolStripMenuItem_Click(sender, e);
        }

        private void btnCalcCoords_Click(object sender, EventArgs e)
        {
            计算转换坐标ToolStripMenuItem_Click(sender, e);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            导出转换后坐标ToolStripMenuItem_Click(sender, e);
        }

        // Import local coordinate data
        private void 导入区域坐标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStatus("正在导入区域坐标...");
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Set title
            openFileDialog.Title = "请选择文件";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // Filter file format
            openFileDialog.Filter = "(*.txt)|*.txt";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                UpdateStatus("就绪");
                return;
            }
            dataGridView1.Rows.Clear();
            var errInfo = "";
            var isSuccess = InputData(dataGridView1, openFileDialog.FileName, ref errInfo);
            if (!isSuccess)
            {
                MessageBox.Show(errInfo, "温馨提示");
                UpdateStatus("导入失败");
            }
            else
            {
                UpdateStatus($"区域坐标导入成功 - 共 {dataGridView1.Rows.Count} 行数据");
            }
        }

        // Import CGCS2000 coordinates
        private void 导入CGCS2000坐标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStatus("正在导入CGCS2000坐标...");
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Set title
            openFileDialog.Title = "请选择文件";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // Filter file format
            openFileDialog.Filter = "(*.txt)|*.txt";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                UpdateStatus("就绪");
                return;
            }
            dataGridView2.Rows.Clear();
            var errInfo = "";
            var isSuccess = InputData(dataGridView2, openFileDialog.FileName, ref errInfo);
            if (!isSuccess)
            {
                MessageBox.Show(errInfo, "温馨提示");
                UpdateStatus("导入失败");
            }
            else
            {
                UpdateStatus($"CGCS2000坐标导入成功 - 共 {dataGridView2.Rows.Count} 行数据");
            }
        }

        /// <summary>
        /// Import coordinates from file to DataGridView
        /// </summary>
        /// <param name="gridview">The DataGridView to populate</param>
        /// <param name="fileName">The path of the file to read</param>
        /// <param name="errInfo">Reference to string for error information</param>
        /// <returns>True if successful, false otherwise</returns>
        private bool InputData(DataGridView gridview, string fileName, ref string errInfo)
        {
            var isSuccess = true;
            var lines = File.ReadAllLines(fileName);
            var i = 0;
            // Iterate through data lines and display in the table
            foreach (var line in lines)
            {
                i++;
                var infos = line.Split(',');
                // Validate data format: must have 4 columns
                if (infos.Length != 4)
                {
                    errInfo += "文件第 " + i + "行数据格式有误！已过滤";
                    isSuccess = false;
                }
                else
                {
                    // Add data to the grid
                    gridview.Rows.Add(infos);
                }
            }
            return isSuccess;
        }

        // Export converted coordinates
        private void 导出转换后坐标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView4.Rows.Count == 0)
            {
                MessageBox.Show("没有可导出的数据。请先计算转换坐标。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            UpdateStatus("正在导出转换后坐标...");
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            // Set file save type
            saveFileDialog.Filter = "(*.txt)|*.txt|(*.dat)|*.dat";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.AddExtension = true;
            // Set dialog title
            saveFileDialog.Title = "保存文件";
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                UpdateStatus("就绪");
                return;
            }
            var isSuccess = DataGridToTxt(dataGridView4, saveFileDialog.FileName, ',');
            if (!isSuccess)
            {
                MessageBox.Show("保存出错,请检查表格中数据是否为空或有误", "温馨提示");
                UpdateStatus("导出失败");
            }
            else
            {
                MessageBox.Show("保存成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateStatus($"转换坐标已导出至 {System.IO.Path.GetFileName(saveFileDialog.FileName)}");
            }
        }

        /// <summary>
        /// Export data from DataGridView to text file
        /// </summary>
        /// <param name="gridview">The source DataGridView</param>
        /// <param name="strFileName">The output file name</param>
        /// <param name="strSplit">The delimiter character</param>
        /// <returns>True if successful, false otherwise</returns>
        private static bool DataGridToTxt(DataGridView gridview, string strFileName, char strSplit)
        {
            if (gridview == null || gridview.Rows.Count == 0)
                return false;

            FileStream fs = new FileStream(strFileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            StringBuilder sb = new StringBuilder();

            try
            {
                for (int i = 0; i < gridview.Rows.Count; i++)
                {
                    sb = new StringBuilder();
                    for (int j = 0; j < gridview.Columns.Count; j++)
                    {
                        sb.Append(gridview.Rows[i].Cells[j].Value.ToString() + strSplit);
                    }
                    sb.Remove(sb.Length - 1, 1); // Remove the last delimiter
                    sw.WriteLine(sb.ToString());
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
            return true;
        }

        // Calculate 7 parameters
        private void 计算转换7参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 12 || dataGridView2.Rows.Count < 12)
            {
                MessageBox.Show("数据不足。每个表格至少需要12行数据才能计算7参数。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateStatus("计算失败 - 数据不足");
                return;
            }

            UpdateStatus("正在计算转换7参数...");
            // Import data to matrices Place, CGCS2000
            GetDataFromDGV1(dataGridView1, place, 12);
            GetDataFromDGV1(dataGridView2, cgcs, 12);

            // Construct matrix B
            for (int i = 0; i < 12; i++)
            {
                b[3 * i, 0] = 1; b[3 * i + 1, 1] = 1; b[3 * i + 2, 2] = 1;

                b[3 * i, 4] = -place[3 * i + 2, 0]; b[3 * i, 5] = place[3 * i + 1, 0]; b[3 * i, 6] = place[3 * i, 0]; // Row 0 related to Z, Y, X ?
                b[3 * i + 1, 3] = place[3 * i + 2, 0]; b[3 * i + 1, 5] = -place[3 * i, 0]; b[3 * i + 1, 6] = place[3 * i + 1, 0]; // Row 1
                b[3 * i + 2, 3] = -place[3 * i + 1, 0]; b[3 * i + 2, 4] = place[3 * i, 0]; b[3 * i + 2, 6] = place[3 * i + 2, 0]; // Row 2
            }

            X.Data = x; B.Data = b; V.Data = v; L.Data = l;
            Place.Data = place; CGCS2000.Data = cgcs;

            // Calculate matrix L: L = CGCS2000 - Place
            L = MatrixOperations.Subtract(CGCS2000, Place);

            // Calculate NBB inverse: (B^T * B)^-1
            NBB_1 = MatrixOperations.Invert(MatrixOperations.Multiply(MatrixOperations.Transpose(B), B));

            // Calculate 7 parameters matrix X: X = (B^T * B)^-1 * B^T * L
            X = MatrixOperations.Multiply(NBB_1, MatrixOperations.Multiply(MatrixOperations.Transpose(B), L));

            // Calculate residuals V: V = B*X - L
            V = MatrixOperations.Subtract(MatrixOperations.Multiply(B, X), L);

            // Calculate posterior unit weight error (sigma)
            // sigma = Sqrt( (V^T * V) / (num - 7) )
            sigma = Math.Sqrt(Convert.ToDouble((MatrixOperations.Multiply(MatrixOperations.Transpose(V), V)).Data[0, 0]) / (num - 7));
            textBox1.Text = (Convert.ToString(sigma));

            dataGridView3.Rows.Clear();
            // Display X matrix (7 parameters) in DataGridView
            double[] x1 = new double[7];
            for (int i = 0; i < 7; i++)
            {
                x1[i] = X.Data[i, 0];
            }
            dataGridView3.Rows.Add(x1[0], x1[1], x1[2], x1[3], x1[4], x1[5], x1[6]);

            // Calculate error
            double n = 0;
            for (int i = 0; i < 7; i++)
            {
                n = Math.Sqrt(NBB_1.Data[i, i]) * sigma;
                nbb_1[i] = n;
            }

            dataGridView3.Rows.Add(nbb_1[0], nbb_1[1], nbb_1[2], nbb_1[3], nbb_1[4], nbb_1[5], nbb_1[6]);

            UpdateStatus($"计算完成 - 验后单位权中误差: {sigma:F6} m");
        }

        // Calculate converted coordinates
        private void 计算转换坐标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 18 || dataGridView2.Rows.Count < 12)
            {
                MessageBox.Show("数据不足。区域坐标需要至少18行，CGCS2000坐标需要至少12行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateStatus("计算失败 - 数据不足");
                return;
            }

            if (dataGridView3.Rows.Count == 0)
            {
                MessageBox.Show("请先计算转换7参数。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateStatus("请先计算转换7参数");
                return;
            }

            UpdateStatus("正在计算转换坐标...");
            dataGridView4.Rows.Clear();

            // Import data to known point matrix
            GetDataFromDGV2(dataGridView1, xyzknown);
            // Import data to matrices Place, CGCS2000
            GetDataFromDGV1(dataGridView1, place, 12);
            GetDataFromDGV1(dataGridView2, cgcs, 12);

            // Construct matrix B (Using the first 12 points for calculation)
            for (int i = 0; i < 12; i++)
            {
                b[3 * i, 0] = 1; b[3 * i + 1, 1] = 1; b[3 * i + 2, 2] = 1;
                b[3 * i, 4] = -place[3 * i + 2, 0]; b[3 * i, 5] = place[3 * i + 1, 0]; b[3 * i, 6] = place[3 * i, 0];
                b[3 * i + 1, 3] = place[3 * i + 2, 0]; b[3 * i + 1, 5] = -place[3 * i, 0]; b[3 * i + 1, 6] = place[3 * i + 1, 0];
                b[3 * i + 2, 3] = -place[3 * i + 1, 0]; b[3 * i + 2, 4] = place[3 * i, 0]; b[3 * i + 2, 6] = place[3 * i + 2, 0];
            }

            // Calculate matrix L
            L = MatrixOperations.Subtract(CGCS2000, Place);

            // Calculate NBB inverse
            NBB_1 = MatrixOperations.Invert(MatrixOperations.Multiply(MatrixOperations.Transpose(B), B));

            // Calculate 7 parameters matrix X
            X = MatrixOperations.Multiply(NBB_1, MatrixOperations.Multiply(MatrixOperations.Transpose(B), L));

            // Import data to B1 matrix (for new points to be converted)
            // It takes the last 6 points (from xyzknown which are read from index 12 to 18)
            for (int i = 0; i < 6; i++)
            {
                b1[3 * i, 0] = 1; b1[3 * i + 1, 1] = 1; b1[3 * i + 2, 2] = 1;
                b1[3 * i, 4] = -xyzknown[3 * i + 2, 0]; b1[3 * i, 5] = xyzknown[3 * i + 1, 0]; b1[3 * i, 6] = xyzknown[3 * i, 0];
                b1[3 * i + 1, 3] = xyzknown[3 * i + 2, 0]; b1[3 * i + 1, 5] = -xyzknown[3 * i, 0]; b1[3 * i + 1, 6] = xyzknown[3 * i + 1, 0];
                b1[3 * i + 2, 3] = -xyzknown[3 * i + 1, 0]; b1[3 * i + 2, 4] = xyzknown[3 * i, 0]; b1[3 * i + 2, 6] = xyzknown[3 * i + 2, 0];
            }
            B1.Data = b1;
            XYZCon.Data = xyzcon;
            XYZKnown.Data = xyzknown;

            // Calculate converted coordinates: XYZCon = XYZKnown + B1 * X
            XYZCon = MatrixOperations.Add(XYZKnown, MatrixOperations.Multiply(B1, X));

            // Import calculated XYZCon matrix to DataGridView
            for (int i = 0; i < 6; i++)
            {
                dataGridView4.Rows.Add(
                    i + 13,
                    Convert.ToDouble(XYZCon.Data[3 * i, 0]).ToString("0.000"),
                    Convert.ToDouble(XYZCon.Data[3 * i + 1, 0]).ToString("0.000"),
                    Convert.ToDouble(XYZCon.Data[3 * i + 2, 0]).ToString("0.000")
                );
            }

            UpdateStatus($"计算完成 - 已转换 {dataGridView4.Rows.Count} 个坐标点");
        }

        /// <summary>
        /// Get data from DataGridView (Method 1: reads first b rows)
        /// </summary>
        private bool GetDataFromDGV1(DataGridView dgv, double[,] array, int rowsToRead)
        {
            int index = 0;
            for (int i = 0; i < rowsToRead; i++)
            {
                for (int j = 1; j < dgv.ColumnCount; j++)
                {
                    array[index, 0] = Convert.ToDouble(dgv[j, i].Value);
                    index++;
                }
            }
            return true;
        }

        /// <summary>
        /// Get data from DataGridView (Method 2: reads rows 12-18, next 6 rows)
        /// </summary>
        private bool GetDataFromDGV2(DataGridView dgv, double[,] array)
        {
            int index = 0;
            for (int i = 12; i < 18; i++)
            {
                for (int j = 1; j < dgv.ColumnCount; j++)
                {
                    array[index, 0] = Convert.ToDouble(dgv[j, i].Value);
                    index++;
                }
            }
            return true;
        }

        // Exit confirmation
        private void FormClosing01(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("确实退出?", "温馨提示", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
