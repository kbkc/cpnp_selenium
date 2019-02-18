namespace cpnp_selenium
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_task = new System.Windows.Forms.DataGridView();
            this.tb_task_fname = new System.Windows.Forms.TextBox();
            this.btOpenXlsx = new System.Windows.Forms.Button();
            this.btDouble = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCpnpList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.open_product = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicate_product = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCpnp1sList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToCpnpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteWorkingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTestProdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.cpnpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_cpnp_num = new System.Windows.Forms.TextBox();
            this.tb_from = new System.Windows.Forms.TextBox();
            this.tb_to = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_task)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCpnpList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCpnp1sList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpnpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.ForeColor = System.Drawing.Color.DarkRed;
            this.txtConsole.Location = new System.Drawing.Point(0, 0);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsole.Size = new System.Drawing.Size(1262, 114);
            this.txtConsole.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1262, 509);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tb_to);
            this.tabPage2.Controls.Add(this.tb_from);
            this.tabPage2.Controls.Add(this.tb_cpnp_num);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dgv_task);
            this.tabPage2.Controls.Add(this.tb_task_fname);
            this.tabPage2.Controls.Add(this.btOpenXlsx);
            this.tabPage2.Controls.Add(this.btDouble);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dgvCpnpList);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1254, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "db Proc";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "5. add products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.add_product_click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(613, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "task list";
            // 
            // dgv_task
            // 
            this.dgv_task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_task.Location = new System.Drawing.Point(608, 39);
            this.dgv_task.Name = "dgv_task";
            this.dgv_task.RowTemplate.Height = 24;
            this.dgv_task.Size = new System.Drawing.Size(638, 277);
            this.dgv_task.TabIndex = 7;
            // 
            // tb_task_fname
            // 
            this.tb_task_fname.Location = new System.Drawing.Point(241, 327);
            this.tb_task_fname.Name = "tb_task_fname";
            this.tb_task_fname.Size = new System.Drawing.Size(177, 22);
            this.tb_task_fname.TabIndex = 6;
            this.tb_task_fname.Text = "task.xlsx";
            // 
            // btOpenXlsx
            // 
            this.btOpenXlsx.Location = new System.Drawing.Point(424, 322);
            this.btOpenXlsx.Name = "btOpenXlsx";
            this.btOpenXlsx.Size = new System.Drawing.Size(143, 32);
            this.btOpenXlsx.TabIndex = 5;
            this.btOpenXlsx.Text = "4. Open task file";
            this.btOpenXlsx.UseVisualStyleBackColor = true;
            this.btOpenXlsx.Click += new System.EventHandler(this.xls_to_gridview_Click);
            // 
            // btDouble
            // 
            this.btDouble.Enabled = false;
            this.btDouble.Location = new System.Drawing.Point(17, 322);
            this.btDouble.Name = "btDouble";
            this.btDouble.Size = new System.Drawing.Size(177, 32);
            this.btDouble.TabIndex = 4;
            this.btDouble.Text = "3. Dublicate product";
            this.btDouble.UseVisualStyleBackColor = true;
            this.btDouble.Click += new System.EventHandler(this.product_dublicate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "2. cpnp dblclick to open product";
            // 
            // dgvCpnpList
            // 
            this.dgvCpnpList.AllowUserToAddRows = false;
            this.dgvCpnpList.AllowUserToDeleteRows = false;
            this.dgvCpnpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCpnpList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCpnpList.Location = new System.Drawing.Point(27, 39);
            this.dgvCpnpList.Name = "dgvCpnpList";
            this.dgvCpnpList.RowTemplate.Height = 24;
            this.dgvCpnpList.Size = new System.Drawing.Size(550, 277);
            this.dgvCpnpList.TabIndex = 0;
            this.dgvCpnpList.Visible = false;
            this.dgvCpnpList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GetCpnpData);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_product,
            this.duplicate_product});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 52);
            // 
            // open_product
            // 
            this.open_product.Name = "open_product";
            this.open_product.Size = new System.Drawing.Size(140, 24);
            this.open_product.Text = "open";
            // 
            // duplicate_product
            // 
            this.duplicate_product.Name = "duplicate_product";
            this.duplicate_product.Size = new System.Drawing.Size(140, 24);
            this.duplicate_product.Text = "dublicate";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.dgvCpnp1sList);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1254, 480);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tmp";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(114, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "1s";
            // 
            // dgvCpnp1sList
            // 
            this.dgvCpnp1sList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCpnp1sList.Location = new System.Drawing.Point(100, 62);
            this.dgvCpnp1sList.Name = "dgvCpnp1sList";
            this.dgvCpnp1sList.RowTemplate.Height = 24;
            this.dgvCpnp1sList.Size = new System.Drawing.Size(322, 235);
            this.dgvCpnp1sList.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtConsole);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 537);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 114);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 509);
            this.panel2.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 526);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1262, 11);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToCpnpToolStripMenuItem,
            this.siteWorkingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToCpnpToolStripMenuItem
            // 
            this.loginToCpnpToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.loginToCpnpToolStripMenuItem.Name = "loginToCpnpToolStripMenuItem";
            this.loginToCpnpToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.loginToCpnpToolStripMenuItem.Text = "1. login to cpnp";
            this.loginToCpnpToolStripMenuItem.Click += new System.EventHandler(this.login_to_cpnp_click);
            // 
            // siteWorkingToolStripMenuItem
            // 
            this.siteWorkingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTestProdToolStripMenuItem});
            this.siteWorkingToolStripMenuItem.Name = "siteWorkingToolStripMenuItem";
            this.siteWorkingToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.siteWorkingToolStripMenuItem.Text = "site working";
            // 
            // openTestProdToolStripMenuItem
            // 
            this.openTestProdToolStripMenuItem.Name = "openTestProdToolStripMenuItem";
            this.openTestProdToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.openTestProdToolStripMenuItem.Text = "open test prod";
            this.openTestProdToolStripMenuItem.Click += new System.EventHandler(this.product_open);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(113, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(373, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Press \"1. login to cpnp\" and wait...";
            // 
            // cpnpBindingSource
            // 
            this.cpnpBindingSource.DataSource = typeof(cpnp_selenium.Cpnp);
            // 
            // tb_cpnp_num
            // 
            this.tb_cpnp_num.Location = new System.Drawing.Point(241, 410);
            this.tb_cpnp_num.Name = "tb_cpnp_num";
            this.tb_cpnp_num.Size = new System.Drawing.Size(135, 22);
            this.tb_cpnp_num.TabIndex = 11;
            this.tb_cpnp_num.Text = "2288818";
            // 
            // tb_from
            // 
            this.tb_from.Location = new System.Drawing.Point(469, 410);
            this.tb_from.Name = "tb_from";
            this.tb_from.Size = new System.Drawing.Size(75, 22);
            this.tb_from.TabIndex = 12;
            this.tb_from.Text = "0";
            // 
            // tb_to
            // 
            this.tb_to.Location = new System.Drawing.Point(608, 408);
            this.tb_to.Name = "tb_to";
            this.tb_to.Size = new System.Drawing.Size(76, 22);
            this.tb_to.TabIndex = 13;
            this.tb_to.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "cpnp or";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "from";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(575, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "to";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 651);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "cpnp proc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.on_close);
            this.Load += new System.EventHandler(this.Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_task)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCpnpList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCpnp1sList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpnpBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siteWorkingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTestProdToolStripMenuItem;
        private System.Windows.Forms.BindingSource cpnpBindingSource;
        private System.Windows.Forms.DataGridView dgvCpnpList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem loginToCpnpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem open_product;
        private System.Windows.Forms.ToolStripMenuItem duplicate_product;
        private System.Windows.Forms.Button btDouble;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_task;
        private System.Windows.Forms.TextBox tb_task_fname;
        private System.Windows.Forms.Button btOpenXlsx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCpnp1sList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_to;
        private System.Windows.Forms.TextBox tb_from;
        private System.Windows.Forms.TextBox tb_cpnp_num;
    }
}