namespace SPT_Kontrol
{
    partial class Form3
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
            TreeNode treeNode23 = new TreeNode("001");
            TreeNode treeNode24 = new TreeNode("003");
            TreeNode treeNode25 = new TreeNode("004");
            TreeNode treeNode26 = new TreeNode("005");
            TreeNode treeNode27 = new TreeNode("006н00");
            TreeNode treeNode28 = new TreeNode("006н01");
            TreeNode treeNode29 = new TreeNode("006н02");
            TreeNode treeNode30 = new TreeNode("006н03");
            TreeNode treeNode31 = new TreeNode("006н04");
            TreeNode treeNode32 = new TreeNode("006н05");
            TreeNode treeNode33 = new TreeNode("006н06");
            TreeNode treeNode34 = new TreeNode("006н07");
            TreeNode treeNode35 = new TreeNode("006n08");
            TreeNode treeNode36 = new TreeNode("006н09");
            TreeNode treeNode37 = new TreeNode("006н10");
            TreeNode treeNode38 = new TreeNode("006", new TreeNode[] { treeNode27, treeNode28, treeNode29, treeNode30, treeNode31, treeNode32, treeNode33, treeNode34, treeNode35, treeNode36, treeNode37 });
            TreeNode treeNode39 = new TreeNode("Параметр 0", new TreeNode[] { treeNode23, treeNode24, treeNode25, treeNode26, treeNode38 });
            TreeNode treeNode40 = new TreeNode("100");
            TreeNode treeNode41 = new TreeNode("101");
            TreeNode treeNode42 = new TreeNode("102");
            TreeNode treeNode43 = new TreeNode("Параметр т1", new TreeNode[] { treeNode40, treeNode41, treeNode42 });
            TreeNode treeNode44 = new TreeNode("СПТ963", new TreeNode[] { treeNode39, treeNode43 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            createBDToolStripMenuItem = new ToolStripMenuItem();
            SPT963ToolStripMenuItem = new ToolStripMenuItem();
            SPT962ToolStripMenuItem = new ToolStripMenuItem();
            OpenProjectToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            SpravkaToolStripMenuItem = new ToolStripMenuItem();
            BackMainToolStripMenuItem = new ToolStripMenuItem();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            treeView1 = new TreeView();
            button1 = new Button();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            panel5 = new Panel();
            label3 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel6 = new Panel();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label6 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            tabPage2 = new TabPage();
            panel3 = new Panel();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel7 = new Panel();
            label7 = new Label();
            menuStrip1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel6.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DeepSkyBlue;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem, BackMainToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1055, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createBDToolStripMenuItem, OpenProjectToolStripMenuItem, ExitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(48, 20);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // createBDToolStripMenuItem
            // 
            createBDToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SPT963ToolStripMenuItem, SPT962ToolStripMenuItem });
            createBDToolStripMenuItem.Name = "createBDToolStripMenuItem";
            createBDToolStripMenuItem.Size = new Size(180, 22);
            createBDToolStripMenuItem.Text = "Создать БД";
            // 
            // SPT963ToolStripMenuItem
            // 
            SPT963ToolStripMenuItem.Name = "SPT963ToolStripMenuItem";
            SPT963ToolStripMenuItem.Size = new Size(118, 22);
            SPT963ToolStripMenuItem.Text = "СПТ 963";
            SPT963ToolStripMenuItem.Click += SPT963ToolStripMenuItem_Click;
            // 
            // SPT962ToolStripMenuItem
            // 
            SPT962ToolStripMenuItem.Name = "SPT962ToolStripMenuItem";
            SPT962ToolStripMenuItem.Size = new Size(118, 22);
            SPT962ToolStripMenuItem.Text = "СПТ 962";
            SPT962ToolStripMenuItem.Click += SPT962ToolStripMenuItem_Click;
            // 
            // OpenProjectToolStripMenuItem
            // 
            OpenProjectToolStripMenuItem.Name = "OpenProjectToolStripMenuItem";
            OpenProjectToolStripMenuItem.Size = new Size(180, 22);
            OpenProjectToolStripMenuItem.Text = "Открыть проект";
            OpenProjectToolStripMenuItem.Click += OpenProjectToolStripMenuItem_Click;
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(180, 22);
            ExitToolStripMenuItem.Text = "Выход";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SpravkaToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(68, 20);
            helpToolStripMenuItem.Text = "Помощь";
            // 
            // SpravkaToolStripMenuItem
            // 
            SpravkaToolStripMenuItem.Name = "SpravkaToolStripMenuItem";
            SpravkaToolStripMenuItem.Size = new Size(120, 22);
            SpravkaToolStripMenuItem.Text = "Справка";
            SpravkaToolStripMenuItem.Click += SpravkaToolStripMenuItem_Click;
            // 
            // BackMainToolStripMenuItem
            // 
            BackMainToolStripMenuItem.Name = "BackMainToolStripMenuItem";
            BackMainToolStripMenuItem.Size = new Size(98, 20);
            BackMainToolStripMenuItem.Text = "Выход в меню";
            BackMainToolStripMenuItem.Click += BackMainToolStripMenuItem_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.BackColor = Color.DeepSkyBlue;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Location = new Point(0, 22);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(243, 538);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 32);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 6);
            label1.Name = "label1";
            label1.Size = new Size(110, 22);
            label1.TabIndex = 2;
            label1.Text = "Параметры";
            // 
            // panel2
            // 
            panel2.Controls.Add(treeView1);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 38);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 490);
            panel2.TabIndex = 0;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(9, 17);
            treeView1.Margin = new Padding(3, 2, 3, 2);
            treeView1.Name = "treeView1";
            treeNode23.Name = "parametr-001";
            treeNode23.Text = "001";
            treeNode24.Name = "parametr-003";
            treeNode24.Text = "003";
            treeNode25.Name = "parametr-004";
            treeNode25.Text = "004";
            treeNode26.Name = "parametr-005";
            treeNode26.Text = "005";
            treeNode27.Name = "parametr-006n00";
            treeNode27.Text = "006н00";
            treeNode28.Name = "parametr-006n01";
            treeNode28.Text = "006н01";
            treeNode29.Name = "parametr-006n02";
            treeNode29.Text = "006н02";
            treeNode30.Name = "parametr-006n03";
            treeNode30.Text = "006н03";
            treeNode31.Name = "parametr-006n04";
            treeNode31.Text = "006н04";
            treeNode32.Name = "parametr-006n05";
            treeNode32.Text = "006н05";
            treeNode33.Name = "parametr-006n06";
            treeNode33.Text = "006н06";
            treeNode34.Name = "parametr-006n07";
            treeNode34.Text = "006н07";
            treeNode35.Name = "parametr-006n08";
            treeNode35.Text = "006n08";
            treeNode36.Name = "parametr-006n09";
            treeNode36.Text = "006н09";
            treeNode37.Name = "parametr-006n10";
            treeNode37.Text = "006н10";
            treeNode38.Name = "parametr-006";
            treeNode38.Text = "006";
            treeNode39.Name = "parametr-0";
            treeNode39.Text = "Параметр 0";
            treeNode40.Name = "parametr-100";
            treeNode40.Text = "100";
            treeNode41.Name = "parametr-101";
            treeNode41.Text = "101";
            treeNode42.Name = "parametr-102";
            treeNode42.Text = "102";
            treeNode43.Name = "parametr-t1";
            treeNode43.Text = "Параметр т1";
            treeNode44.Name = "SPT963";
            treeNode44.Text = "СПТ963";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode44 });
            treeView1.Size = new Size(200, 438);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // button1
            // 
            button1.Location = new Point(10, 458);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(200, 31);
            button1.TabIndex = 8;
            button1.Text = "Вывод БД";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(245, 21);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(392, 275);
            panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 33);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(390, 240);
            dataGridView1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DeepSkyBlue;
            panel5.Controls.Add(label3);
            panel5.Location = new Point(245, 22);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(390, 28);
            panel5.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(107, 4);
            label3.Name = "label3";
            label3.Size = new Size(157, 18);
            label3.TabIndex = 7;
            label3.Text = "Настройки элемента";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panel6);
            flowLayoutPanel2.Controls.Add(tabControl1);
            flowLayoutPanel2.Location = new Point(245, 301);
            flowLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(393, 255);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DeepSkyBlue;
            panel6.Controls.Add(label2);
            panel6.Location = new Point(3, 2);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(389, 26);
            panel6.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(132, 4);
            label2.Name = "label2";
            label2.Size = new Size(112, 18);
            label2.TabIndex = 7;
            label2.Text = "Конфигурация";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 32);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(388, 231);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(380, 203);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Информация";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 53);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 7;
            label6.Text = "Описание:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(5, 81);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(354, 115);
            textBox1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(143, 21);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 1;
            label5.Text = "значения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 21);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 0;
            label4.Text = "Единицы измерения:";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(380, 203);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Лист 2 (В разработке)";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(panel7);
            panel3.Location = new Point(640, 22);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(416, 536);
            panel3.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(56, 338);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(38, 32);
            button2.TabIndex = 2;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 87);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(402, 284);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DeepSkyBlue;
            panel7.Controls.Add(label7);
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(416, 26);
            panel7.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(79, 4);
            label7.Name = "label7";
            label7.Size = new Size(251, 18);
            label7.TabIndex = 1;
            label7.Text = "Графический интерфейс прибора";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 559);
            Controls.Add(panel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Location = new Point(280, 28);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Настройка СПТ963";
            Load += Form3_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem createBDToolStripMenuItem;
        private ToolStripMenuItem OpenProjectToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem SPT963ToolStripMenuItem;
        private ToolStripMenuItem SPT962ToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem SpravkaToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TreeView treeView1;
        private Panel panel4;
        private Panel panel5;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel6;
        private Label label2;
        private Label label3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label5;
        private Label label4;
        private TextBox textBox1;
        private Label label6;
        private Button button1;
        private Panel panel3;
        private Panel panel7;
        private Label label7;
        private PictureBox pictureBox1;
        private Button button2;
        private ToolStripMenuItem BackMainToolStripMenuItem;
    }
}