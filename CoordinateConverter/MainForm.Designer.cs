namespace CoordinateConverter
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            // Initialize all components
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.导入区域坐标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入CGCS2000坐标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算转换7参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算转换坐标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出转换坐标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnImportLocal = new System.Windows.Forms.ToolStripButton();
            this.btnImportCGCS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCalcParams = new System.Windows.Forms.ToolStripButton();
            this.btnCalcCoords = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();

            // ========================================
            // Modern Color Palette
            // ========================================
            var primaryColor = System.Drawing.Color.FromArgb(67, 56, 202);        // Indigo 700
            var primaryLight = System.Drawing.Color.FromArgb(99, 102, 241);       // Indigo 500
            var accentColor = System.Drawing.Color.FromArgb(79, 70, 229);         // Indigo 600
            var bgColor = System.Drawing.Color.FromArgb(249, 250, 251);           // Gray 50
            var cardColor = System.Drawing.Color.FromArgb(255, 255, 255);         // White
            var textPrimary = System.Drawing.Color.FromArgb(17, 24, 39);          // Gray 900
            var textSecondary = System.Drawing.Color.FromArgb(107, 114, 128);     // Gray 500
            var textMuted = System.Drawing.Color.FromArgb(156, 163, 175);         // Gray 400
            var borderColor = System.Drawing.Color.FromArgb(229, 231, 235);       // Gray 200
            var headerBg = System.Drawing.Color.FromArgb(243, 244, 246);          // Gray 100
            var selectionBg = System.Drawing.Color.FromArgb(238, 242, 255);       // Indigo 50
            var toolbarBg = System.Drawing.Color.FromArgb(255, 255, 255);         // White

            // ========================================
            // Shared DataGridView Styles
            // ========================================
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerStyle.BackColor = headerBg;
            headerStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = primaryColor;
            headerStyle.SelectionBackColor = primaryLight;
            headerStyle.SelectionForeColor = System.Drawing.Color.White;
            headerStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            headerStyle.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);

            cellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            cellStyle.BackColor = cardColor;
            cellStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            cellStyle.ForeColor = textPrimary;
            cellStyle.SelectionBackColor = selectionBg;
            cellStyle.SelectionForeColor = primaryColor;
            cellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            cellStyle.Padding = new System.Windows.Forms.Padding(4);

            // ========================================
            // menuStrip1 - Hidden
            // ========================================
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.导入区域坐标ToolStripMenuItem,
                this.导入CGCS2000坐标ToolStripMenuItem,
                this.计算转换7参数ToolStripMenuItem,
                this.计算转换坐标ToolStripMenuItem,
                this.导出转换坐标ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1600, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Visible = false;

            // ========================================
            // toolStrip1 - Modern Toolbar
            // ========================================
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = toolbarBg;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.btnImportLocal,
                this.btnImportCGCS,
                this.toolStripSeparator1,
                this.btnCalcParams,
                this.btnCalcCoords,
                this.toolStripSeparator2,
                this.btnExport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.toolStrip1.Size = new System.Drawing.Size(1560, 52);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Renderer = new ModernToolStripRenderer(primaryColor, primaryLight);

            // btnImportLocal
            this.btnImportLocal.AutoSize = false;
            this.btnImportLocal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnImportLocal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.btnImportLocal.ForeColor = textPrimary;
            this.btnImportLocal.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnImportLocal.Name = "btnImportLocal";
            this.btnImportLocal.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.btnImportLocal.Size = new System.Drawing.Size(100, 32);
            this.btnImportLocal.Text = "导入区域坐标";
            this.btnImportLocal.ToolTipText = "导入区域坐标数据 (Ctrl+I)";
            this.btnImportLocal.Click += new System.EventHandler(this.btnImportLocal_Click);

            // btnImportCGCS
            this.btnImportCGCS.AutoSize = false;
            this.btnImportCGCS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnImportCGCS.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.btnImportCGCS.ForeColor = textPrimary;
            this.btnImportCGCS.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnImportCGCS.Name = "btnImportCGCS";
            this.btnImportCGCS.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.btnImportCGCS.Size = new System.Drawing.Size(115, 32);
            this.btnImportCGCS.Text = "导入CGCS2000";
            this.btnImportCGCS.ToolTipText = "导入CGCS2000坐标数据 (Ctrl+G)";
            this.btnImportCGCS.Click += new System.EventHandler(this.btnImportCGCS_Click);

            // toolStripSeparator1
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);

            // btnCalcParams
            this.btnCalcParams.AutoSize = false;
            this.btnCalcParams.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCalcParams.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.btnCalcParams.ForeColor = textPrimary;
            this.btnCalcParams.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnCalcParams.Name = "btnCalcParams";
            this.btnCalcParams.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.btnCalcParams.Size = new System.Drawing.Size(90, 32);
            this.btnCalcParams.Text = "计算7参数";
            this.btnCalcParams.ToolTipText = "计算转换7参数及中误差 (Ctrl+C)";
            this.btnCalcParams.Click += new System.EventHandler(this.btnCalcParams_Click);

            // btnCalcCoords
            this.btnCalcCoords.AutoSize = false;
            this.btnCalcCoords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCalcCoords.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.btnCalcCoords.ForeColor = textPrimary;
            this.btnCalcCoords.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnCalcCoords.Name = "btnCalcCoords";
            this.btnCalcCoords.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.btnCalcCoords.Size = new System.Drawing.Size(80, 32);
            this.btnCalcCoords.Text = "计算坐标";
            this.btnCalcCoords.ToolTipText = "计算转换坐标 (Ctrl+T)";
            this.btnCalcCoords.Click += new System.EventHandler(this.btnCalcCoords_Click);

            // toolStripSeparator2
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 36);

            // btnExport
            this.btnExport.AutoSize = false;
            this.btnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExport.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.btnExport.ForeColor = textPrimary;
            this.btnExport.Name = "btnExport";
            this.btnExport.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.btnExport.Size = new System.Drawing.Size(80, 32);
            this.btnExport.Text = "导出坐标";
            this.btnExport.ToolTipText = "导出转换后坐标 (Ctrl+E)";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);

            // ========================================
            // statusStrip1 - Modern Status Bar
            // ========================================
            this.statusStrip1.BackColor = toolbarBg;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.statusLabel });
            this.statusStrip1.Location = new System.Drawing.Point(0, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1560, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 23;

            // statusLabel
            this.statusLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.statusLabel.ForeColor = textSecondary;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(32, 19);
            this.statusLabel.Text = "就绪";

            // ========================================
            // panel1 - Local Coordinates Card
            // ========================================
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = cardColor;
            this.panel1.Controls.Add(this.label0);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(16, 64);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(500, 400);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler((s, e) => {
                using (var pen = new System.Drawing.Pen(borderColor, 1))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, this.panel1.Width - 1, this.panel1.Height - 1);
                }
            });

            // label0 - Local Coordinates Title
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.label0.ForeColor = primaryColor;
            this.label0.Location = new System.Drawing.Point(20, 16);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(88, 21);
            this.label0.TabIndex = 8;
            this.label0.Text = "区域坐标";

            // dataGridView1 - Local Coordinates Grid
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = cardColor;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.Column1, this.Column2, this.Column3, this.Column4});
            this.dataGridView1.DefaultCellStyle = cellStyle;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = borderColor;
            this.dataGridView1.Location = new System.Drawing.Point(20, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(460, 336);
            this.dataGridView1.TabIndex = 0;

            // Column1 - Point ID
            this.Column1.HeaderText = "点号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;

            // Column2 - X
            this.Column2.HeaderText = "X (m)";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;

            // Column3 - Y
            this.Column3.HeaderText = "Y (m)";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;

            // Column4 - Z
            this.Column4.HeaderText = "Z (m)";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;

            // ========================================
            // panel2 - CGCS2000 Coordinates Card
            // ========================================
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = cardColor;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(532, 64);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(1);
            this.panel2.Size = new System.Drawing.Size(500, 400);
            this.panel2.TabIndex = 25;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler((s, e) => {
                using (var pen = new System.Drawing.Pen(borderColor, 1))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, this.panel2.Width - 1, this.panel2.Height - 1);
                }
            });

            // label4 - CGCS2000 Title
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = primaryColor;
            this.label4.Location = new System.Drawing.Point(20, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "CGCS2000坐标";

            // dataGridView2 - CGCS2000 Grid
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = cardColor;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dataGridView2.ColumnHeadersHeight = 40;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.Column16, this.Column17, this.Column18, this.Column19});
            this.dataGridView2.DefaultCellStyle = cellStyle;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = borderColor;
            this.dataGridView2.Location = new System.Drawing.Point(20, 48);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 32;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(460, 336);
            this.dataGridView2.TabIndex = 11;

            // Column16 - Point ID
            this.Column16.HeaderText = "点号";
            this.Column16.Name = "Column16";
            this.Column16.Width = 80;

            // Column17 - X
            this.Column17.HeaderText = "X (m)";
            this.Column17.Name = "Column17";
            this.Column17.Width = 120;

            // Column18 - Y
            this.Column18.HeaderText = "Y (m)";
            this.Column18.Name = "Column18";
            this.Column18.Width = 120;

            // Column19 - Z
            this.Column19.HeaderText = "Z (m)";
            this.Column19.Name = "Column19";
            this.Column19.Width = 120;

            // ========================================
            // panel3 - Converted Coordinates Card
            // ========================================
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.panel3.BackColor = cardColor;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dataGridView4);
            this.panel3.Location = new System.Drawing.Point(1048, 64);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(1);
            this.panel3.Size = new System.Drawing.Size(496, 400);
            this.panel3.TabIndex = 26;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler((s, e) => {
                using (var pen = new System.Drawing.Pen(borderColor, 1))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, this.panel3.Width - 1, this.panel3.Height - 1);
                }
            });

            // label2 - Converted Title
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = primaryColor;
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "转换后坐标";

            // dataGridView4 - Converted Grid
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.BackgroundColor = cardColor;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView4.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dataGridView4.ColumnHeadersHeight = 40;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.Column12, this.Column13, this.Column14, this.Column15});
            this.dataGridView4.DefaultCellStyle = cellStyle;
            this.dataGridView4.EnableHeadersVisualStyles = false;
            this.dataGridView4.GridColor = borderColor;
            this.dataGridView4.Location = new System.Drawing.Point(20, 48);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowTemplate.Height = 32;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(456, 336);
            this.dataGridView4.TabIndex = 7;

            // Column12 - Point ID
            this.Column12.HeaderText = "点号";
            this.Column12.Name = "Column12";
            this.Column12.Width = 80;

            // Column13 - X
            this.Column13.HeaderText = "X (m)";
            this.Column13.Name = "Column13";
            this.Column13.Width = 120;

            // Column14 - Y
            this.Column14.HeaderText = "Y (m)";
            this.Column14.Name = "Column14";
            this.Column14.Width = 120;

            // Column15 - Z
            this.Column15.HeaderText = "Z (m)";
            this.Column15.Name = "Column15";
            this.Column15.Width = 120;

            // ========================================
            // panel4 - Parameters Card
            // ========================================
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = cardColor;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dataGridView3);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(16, 480);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(1);
            this.panel4.Size = new System.Drawing.Size(1528, 188);
            this.panel4.TabIndex = 27;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler((s, e) => {
                using (var pen = new System.Drawing.Pen(borderColor, 1))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, this.panel4.Width - 1, this.panel4.Height - 1);
                }
            });

            // label1 - Parameters Title
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = primaryColor;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "转换7参数";

            // dataGridView3 - Parameters Grid
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.BackgroundColor = cardColor;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dataGridView3.ColumnHeadersHeight = 40;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.Column5, this.Column6, this.Column7, this.Column8, this.Column9, this.Column10, this.Column11});
            this.dataGridView3.DefaultCellStyle = cellStyle;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.GridColor = borderColor;
            this.dataGridView3.Location = new System.Drawing.Point(20, 48);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 32;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(1488, 80);
            this.dataGridView3.TabIndex = 4;

            // Column5 - Tx
            this.Column5.HeaderText = "Tx";
            this.Column5.Name = "Column5";
            this.Column5.Width = 210;

            // Column6 - Ty
            this.Column6.HeaderText = "Ty";
            this.Column6.Name = "Column6";
            this.Column6.Width = 210;

            // Column7 - Tz
            this.Column7.HeaderText = "Tz";
            this.Column7.Name = "Column7";
            this.Column7.Width = 210;

            // Column8 - wx
            this.Column8.HeaderText = "\u03c9x";
            this.Column8.Name = "Column8";
            this.Column8.Width = 210;

            // Column9 - wy
            this.Column9.HeaderText = "\u03c9y";
            this.Column9.Name = "Column9";
            this.Column9.Width = 210;

            // Column10 - wz
            this.Column10.HeaderText = "\u03c9z";
            this.Column10.Name = "Column10";
            this.Column10.Width = 210;

            // Column11 - m
            this.Column11.HeaderText = "m";
            this.Column11.Name = "Column11";
            this.Column11.Width = 210;

            // label5 - Unit labels
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.5F);
            this.label5.ForeColor = textMuted;
            this.label5.Location = new System.Drawing.Point(20, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(800, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "m                                    m                                    m                                    \"                                    \"                                    \"                                    ppm";

            // label6 - Unit description
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.5F);
            this.label6.ForeColor = textMuted;
            this.label6.Location = new System.Drawing.Point(20, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "参数单位";

            // label3 - Hidden
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label3.ForeColor = textSecondary;
            this.label3.Location = new System.Drawing.Point(20, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 10;
            this.label3.Visible = false;

            // label8 - Error label
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5F);
            this.label8.ForeColor = textPrimary;
            this.label8.Location = new System.Drawing.Point(1220, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "验后单位权中误差";

            // textBox1 - Error value
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = headerBg;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = primaryColor;
            this.textBox1.Location = new System.Drawing.Point(1344, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(120, 25);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "0.000";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.AccessibleName = "验后单位权中误差";

            // label9 - Error unit
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label9.ForeColor = textMuted;
            this.label9.Location = new System.Drawing.Point(1470, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "m";

            // ========================================
            // Menu Items
            // ========================================
            this.导入区域坐标ToolStripMenuItem.Name = "导入区域坐标ToolStripMenuItem";
            this.导入区域坐标ToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.导入区域坐标ToolStripMenuItem.Text = "导入区域坐标(&I)";
            this.导入区域坐标ToolStripMenuItem.Click += new System.EventHandler(this.导入区域坐标ToolStripMenuItem_Click);

            this.导入CGCS2000坐标ToolStripMenuItem.Name = "导入CGCS2000坐标ToolStripMenuItem";
            this.导入CGCS2000坐标ToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.导入CGCS2000坐标ToolStripMenuItem.Text = "导入CGCS2000坐标(&G)";
            this.导入CGCS2000坐标ToolStripMenuItem.Click += new System.EventHandler(this.导入CGCS2000坐标ToolStripMenuItem_Click);

            this.计算转换7参数ToolStripMenuItem.Name = "计算转换7参数ToolStripMenuItem";
            this.计算转换7参数ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.计算转换7参数ToolStripMenuItem.Text = "计算转换7参数及中误差(&C)";
            this.计算转换7参数ToolStripMenuItem.Click += new System.EventHandler(this.计算转换7参数ToolStripMenuItem_Click);

            this.计算转换坐标ToolStripMenuItem.Name = "计算转换坐标ToolStripMenuItem";
            this.计算转换坐标ToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.计算转换坐标ToolStripMenuItem.Text = "计算转换坐标(&T)";
            this.计算转换坐标ToolStripMenuItem.Click += new System.EventHandler(this.计算转换坐标ToolStripMenuItem_Click);

            this.导出转换坐标ToolStripMenuItem.Name = "导出转换坐标ToolStripMenuItem";
            this.导出转换坐标ToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.导出转换坐标ToolStripMenuItem.Text = "导出转换后坐标(&E)";
            this.导出转换坐标ToolStripMenuItem.Click += new System.EventHandler(this.导出转换后坐标ToolStripMenuItem_Click);

            // ========================================
            // MainForm
            // ========================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = bgColor;
            this.ClientSize = new System.Drawing.Size(1560, 702);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1400, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "坐标转换计算系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosing01);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 导入区域坐标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入CGCS2000坐标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算转换7参数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算转换坐标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出转换坐标ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnImportLocal;
        private System.Windows.Forms.ToolStripButton btnImportCGCS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCalcParams;
        private System.Windows.Forms.ToolStripButton btnCalcCoords;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
    }

    /// <summary>
    /// Modern ToolStrip renderer with hover effects
    /// </summary>
    public class ModernToolStripRenderer : System.Windows.Forms.ToolStripProfessionalRenderer
    {
        private System.Drawing.Color _primaryColor;
        private System.Drawing.Color _primaryLight;

        public ModernToolStripRenderer(System.Drawing.Color primaryColor, System.Drawing.Color primaryLight)
            : base(new ModernColorTable())
        {
            _primaryColor = primaryColor;
            _primaryLight = primaryLight;
        }

        protected override void OnRenderButtonBackground(System.Windows.Forms.ToolStripItemRenderEventArgs e)
        {
            var btn = e.Item as System.Windows.Forms.ToolStripButton;
            if (btn != null)
            {
                var bounds = new System.Drawing.Rectangle(System.Drawing.Point.Empty, e.Item.Size);
                var g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                if (btn.Selected || btn.Pressed)
                {
                    using (var brush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(238, 242, 255)))
                    {
                        using (var path = CreateRoundedRectangle(bounds, 6))
                        {
                            g.FillPath(brush, path);
                        }
                    }
                }
            }
        }

        protected override void OnRenderToolStripBorder(System.Windows.Forms.ToolStripRenderEventArgs e)
        {
            // Draw bottom border only
            using (var pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(229, 231, 235), 1))
            {
                e.Graphics.DrawLine(pen, 0, e.AffectedBounds.Height - 1, e.AffectedBounds.Width, e.AffectedBounds.Height - 1);
            }
        }

        private System.Drawing.Drawing2D.GraphicsPath CreateRoundedRectangle(System.Drawing.Rectangle bounds, int radius)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            var diameter = radius * 2;
            var arc = new System.Drawing.Rectangle(bounds.Location, new System.Drawing.Size(diameter, diameter));

            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();

            return path;
        }
    }

    /// <summary>
    /// Modern color table for ToolStrip
    /// </summary>
    public class ModernColorTable : System.Windows.Forms.ProfessionalColorTable
    {
        public override System.Drawing.Color ToolStripGradientBegin => System.Drawing.Color.White;
        public override System.Drawing.Color ToolStripGradientMiddle => System.Drawing.Color.White;
        public override System.Drawing.Color ToolStripGradientEnd => System.Drawing.Color.White;
        public override System.Drawing.Color MenuStripGradientBegin => System.Drawing.Color.White;
        public override System.Drawing.Color MenuStripGradientEnd => System.Drawing.Color.White;
        public override System.Drawing.Color SeparatorDark => System.Drawing.Color.FromArgb(229, 231, 235);
        public override System.Drawing.Color SeparatorLight => System.Drawing.Color.FromArgb(243, 244, 246);
    }
}
