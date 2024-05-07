using SPT_Kontrol.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Resolvers;
using System.Xml.Serialization;

namespace SPT_Kontrol
{
    public partial class Form2 : Form
    {
        private bool isCollapsed;
        private bool isCollapsedSecond;
        private bool isCollapsedThird;
        private bool isCollapsedFourth;
        private bool isCollapsedFifth;
        private bool isCollapsedSixth;
        private bool isCollapsedSeventh;


        private TagList _xmlModel = new TagList();
        public Form2()
        {
            InitializeComponent();


            //panelElement.Hide();
            //tabControlElement.Hide();


        }

        private TagList _xmlModel1;

        public Form2(TagList xmlModel)
        {
            InitializeComponent();
            _xmlModel1 = xmlModel;
            LoadXdb(_xmlModel1);
        }

        // Добавьте конструктор, который принимает путь к файлу
        /* public Form2(string filePath) : this()
         {
             _filePath = filePath;
         }*/
        /*
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }



            else
            {
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }

            }
        }*/

        // private void button1_Click(object sender, EventArgs e)
        //{
        // timer1.Start();
        //}

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}
        //private void panelDropDownSecond_Click(object sender, PaintEventArgs e)
        //{

        // }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //   timer2.Start();
        //}
        /*
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsedSecond)
            {
                panelDropDownSecond.Height += 10;
                if (panelDropDownSecond.Size == panelDropDownSecond.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsedSecond = false;
                }
            }
            else
            {
                panelDropDownSecond.Height -= 10;
                if (panelDropDownSecond.Size == panelDropDownSecond.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsedSecond = true;
                }

            }
        }*/
        /*
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsedThird)
            {
                panelDropDownThird.Height += 10;
                if (panelDropDownThird.Size == panelDropDownThird.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsedThird = false;
                }
            }
            else
            {
                panelDropDownThird.Height -= 10;
                if (panelDropDownThird.Size == panelDropDownThird.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsedThird = true;
                }

            }
        }
        */
        //private void button3_Click(object sender, EventArgs e)
        //{
        //timer3.Start();
        //}
        /*
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (isCollapsedFourth)
            {
                panelDropDownFourth.Height += 10;
                if (panelDropDownFourth.Size == panelDropDownFourth.MaximumSize)
                {
                    timer4.Stop();
                    isCollapsedFourth = false;
                }
            }
            else
            {
                panelDropDownFourth.Height -= 10;
                if (panelDropDownFourth.Size == panelDropDownFourth.MinimumSize)
                {
                    timer4.Stop();
                    isCollapsedFourth = true;
                }

            }
        }
        */
        // private void button4_Click(object sender, EventArgs e)
        //{
        // timer4.Start();
        //}
        /*
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (isCollapsedFifth)
            {
                panelDropDownFifth.Height += 10;
                if (panelDropDownFifth.Size == panelDropDownFifth.MaximumSize)
                {
                    timer5.Stop();
                    isCollapsedFifth = false;
                }
            }
            else
            {
                panelDropDownFifth.Height -= 10;
                if (panelDropDownFifth.Size == panelDropDownFifth.MinimumSize)
                {
                    timer5.Stop();
                    isCollapsedFifth = true;
                }

            }
        }
        */
        // private void button5_Click(object sender, EventArgs e)
        //{
        //  timer5.Start();
        // }

        /*
        private void timer6_Tick(object sender, EventArgs e)
        {
            if (isCollapsedSixth)
            {
                panelDropDownSixth.Height += 10;
                if (panelDropDownSixth.Size == panelDropDownSixth.MaximumSize)
                {
                    timer6.Stop();
                    isCollapsedSixth = false;
                }
            }
            else
            {
                panelDropDownSixth.Height -= 10;
                if (panelDropDownSixth.Size == panelDropDownSixth.MinimumSize)
                {
                    timer6.Stop();
                    isCollapsedSixth = true;
                }

            }
        }
        */
        // private void button6_Click(object sender, EventArgs e)
        //{
        // timer6.Start();
        //}

        /*
        private void timer7_Tick(object sender, EventArgs e)
        {
            if (isCollapsedSeventh)
            {
                panelDropDownSeventh.Height += 10;
                if (panelDropDownSeventh.Size == panelDropDownSeventh.MaximumSize)
                {
                    timer7.Stop();
                    isCollapsedSeventh = false;
                }
            }
            else
            {
                panelDropDownSeventh.Height -= 10;
                if (panelDropDownSeventh.Size == panelDropDownSeventh.MinimumSize)
                {
                    timer7.Stop();
                    isCollapsedSeventh = true;
                }

            }
        }
        */
        //private void button7_Click(object sender, EventArgs e)
        //{
        //timer7.Start();
        //}

        //private void label21_Click(object sender, EventArgs e)
        //{
        //panelElement.Show();
        //}

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConvertTreeViewIntoDataGridView();

            // Загрузка данных при открытии формы

        }

        private string _targetDevice;
        private DataTable _dataTable; // Поле для хранения текущей DataTable

        private void ConvertTreeViewIntoDataGridView()
        {
            // Создаем новую DataTable только если dataGridView пустая
            if (_dataTable == null)
            {
                _dataTable = new DataTable();
                _dataTable.Columns.Add("Канал", typeof(string));
                _dataTable.Columns.Add("Параметр", typeof(string));
                _dataTable.Columns.Add("Значение", typeof(string));
            }

            // Получение корневых узлов из TreeView
            var rootNodes = treeView1.Nodes.Cast<TreeNode>().Where(node => node.Parent == null).ToList();
            //Создаем новую модель
            _xmlModel = new TagList();

            // Обход корневых узлов
            foreach (var rootNode in rootNodes)
            {
                Debug.WriteLine("Заполняем корневой узел");
                //Заполняем корневой узел
                _xmlModel.TargetDevice = rootNode.Name;
                _targetDevice = rootNode.Name;
                _xmlModel.Id = 101010;
                _xmlModel.SerialNumber = "???";
                _xmlModel.Channel = new List<Channel>();

                // Получение всех дочерних узлов для текущего корневого узла
                var childNodes = GetChildNodes(rootNode);
                int channelNumber = 0;
                int prefixNumber = 0;
                foreach (var node in childNodes)
                {
                    Debug.WriteLine("Для каждого дочернего объекта создаем объект Channel и заполняем его");
                    //Для каждого дочернего объекта создаем объект Channel и заполняем его
                    var currentChannel = new Channel();
                    currentChannel.No = channelNumber;
                    currentChannel.Name = node.Text;
                    currentChannel.Kind = "Channel";
                    currentChannel.Prefix = node.Name;
                    currentChannel.Description = "???";
                    currentChannel.Tag = new List<BaseTag>();
                    // Добавляем к корневому
                    _xmlModel.Channel.Add(currentChannel);
                    // Получение всех дочерних узлов для node
                    var childrens = GetChildNodes(node);
                    foreach (var childNode in childrens)
                    {
                        Debug.WriteLine("Для каждого дочернего объекта проверяем есть ли у него дети");
                        //Для каждого дочернего объекта проверяем есть ли у него дети
                        if (childNode.Nodes.Count > 0)
                        {
                            Debug.WriteLine("Если дети есть то создаем для него объект TagGroup и заполняем");
                            //Если дети есть то создаем для него объект TagGroup и заполняем
                            var tagGroup = new TagGroup();
                            tagGroup.Ordinal = childNode.Text;
                            tagGroup.Name = "???";
                            tagGroup.Tag = new List<TagGroupTag>();
                            //Добавляем объекту Channel объект TagGroup
                            currentChannel.Tag.Add(tagGroup);
                            // Получение всех дочерних узлов для childNode
                            var childChildNodes = GetChildNodes(childNode);
                            int tagGroupIndex = 0;
                            foreach (var child in childChildNodes)
                            {
                                Debug.WriteLine("Для каждого дочернего объекта создаем объект TagGroupTag и заполняем");
                                //Для каждого дочернего объекта создаем объект TagGroupTag и заполняем
                                var tagGroupTag = new TagGroupTag();
                                tagGroupTag.Index = tagGroupIndex;
                                tagGroupTag.Id = child.Text;
                                tagGroupTag.Name = "???";
                                tagGroupTag.Value = string.Empty;
                                tagGroupTag.Eu = string.Empty;
                                // Добавляем объект TagGroupTag к объекту TagGroup
                                tagGroup.Tag.Add(tagGroupTag);
                                tagGroupIndex++;
                                //Добавляем строчку в dataTable 
                                _dataTable.Rows.Add(node.Text, child.Text);
                            }
                            // Так как дети были то добавлять такую узел в DataTable не нужно, переходим к следующей итерации
                            continue;
                        }
                        //Если нет то создаем объект Tag и заполняем
                        var tag = new Tag();
                        tag.Ordinal = childNode.Text;
                        tag.Name = "???";
                        tag.Id = childNode.Text + node.Text;
                        //После этого добавляем его к объекту Channel
                        currentChannel.Tag.Add(tag);
                        //Добавляем строчку в dataTable 
                        _dataTable.Rows.Add(node.Text, childNode.Text);

                    }
                    channelNumber++;
                }
            }

            // Функция для получения всех дочерних узлов для указанного узла
            List<TreeNode> GetChildNodes(TreeNode node)
            {
                Debug.WriteLine("Получение всех дочерних узлов для node");
                List<TreeNode> childNodes = new List<TreeNode>();

                foreach (TreeNode childNode in node.Nodes)
                {
                    childNodes.Add(childNode);
                }

                return childNodes;
            }


            dataGridView1.DataSource = _dataTable;

        }

        private void CreateXdb()
        {
            // Перебираем все строки из datagridView
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                // Получаем значения каждого столбца
                var channel = dataGridView1[0, i].Value.ToString();
                Debug.WriteLine("Channel = " + channel);
                var parametr = dataGridView1[1, i].Value.ToString();
                Debug.WriteLine("parametr = " + parametr);
                var value = dataGridView1[2, i].Value.ToString();
                Debug.WriteLine("value = " + value);

                // Если это узел без детей (типа Tag) то находим его
                var result = _xmlModel
                    .Channel.Where(x => x.Name == channel).FirstOrDefault()
                    ?.Tag.Where(x => (x as Tag)?.Ordinal == parametr).FirstOrDefault();

                if (result != null)
                {
                    // Если такой узел есть, то его значение делаем равным value
                    (result as Tag).Value = value;
                }
                // Если такого узла нет, то значит это узел с детьми типа TagGroup
                else
                {
                    // Находим канал в _xmlModel
                    var currentChannel = _xmlModel.Channel.FirstOrDefault(x => x.Name == channel);

                    // Находим TagGroup для этого параметра
                    var tagGroup = currentChannel?.Tag.OfType<TagGroup>().FirstOrDefault(tg => parametr.StartsWith(tg.Ordinal, StringComparison.OrdinalIgnoreCase));

                    // Если TagGroup найден, обновляем значение соответствующего TagGroupTag
                    if (tagGroup != null)
                    {
                        var tag = tagGroup.Tag.FirstOrDefault(t => t.Id.StartsWith(parametr, StringComparison.OrdinalIgnoreCase));
                        if (tag != null)
                            tag.Value = value;
                    }
                }
            }

            // Создаем XmlSerializer и убираем все неймспейсы, делая их пустыми
            XmlSerializer serializer = new XmlSerializer(typeof(TagList));
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Xdb Files (*.xdb)|*.xdb";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Создаем FileStream и серилизуем нашу модель xml в файл output.xdb
                using (FileStream fileStream = new FileStream(sfd.FileName, FileMode.Create))
                {
                    serializer.Serialize(fileStream, _xmlModel, namespaces);
                }
            }
        }
















        //private void button8_Click(object sender, EventArgs e)
        //{
        //
        //}

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Получаем название родительского узла (канала)
            string parent = (e.Node.Parent != null && e.Node.Parent.Parent != null) ? e.Node.Parent.Text : (e.Node.Level == 1 ? e.Node.Text : "1");

            // Если выбран узел, у которого есть дочерние узлы
            if (e.Node.Nodes.Count > 0)
            {
                // Если родительский узел - корень и его название "СПТ962", то для дочерних узлов в первом столбце будет использоваться их собственное название
                if (e.Node.Level == 0 && e.Node.Text == "СПТ962")
                {
                    parent = e.Node.Text;
                }

                // Очищаем DataTable перед добавлением новых строк
                _dataTable.Rows.Clear();

                // Добавляем строки для каждого дочернего узла
                foreach (var childNode in e.Node.Nodes.Cast<TreeNode>())
                {
                    // Получаем название текущего узла
                    string nodeText = childNode.Text;

                    // Добавляем строку в DataTable с названием родительского узла (канала) в первом столбце
                    // и названием текущего узла во втором столбце
                    _dataTable.Rows.Add(parent, nodeText, "");
                }
            }
            else
            {
                // Если у выбранного узла нет дочерних узлов, добавляем его в DataTable
                _dataTable.Rows.Clear();
                _dataTable.Rows.Add(parent, e.Node.Text, "");
            }


            

        }

        private void AddChildNodeToDataGridView(string parent, TreeNode node, DataTable dataTable, Dictionary<string, string> previousValues)
        {
            foreach (var childNode in node.Nodes.Cast<TreeNode>())
            {
                if (childNode.Nodes.Count > 0)
                {
                    var tagGroup = new TagGroup();
                    tagGroup.Ordinal = childNode.Text;
                    tagGroup.Name = "???";
                    tagGroup.Tag = new List<TagGroupTag>();

                    var childChildNodes = GetChildNodes(childNode);
                    int tagGroupIndex = 0;
                    foreach (var child in childChildNodes)
                    {
                        var tagGroupTag = new TagGroupTag();
                        tagGroupTag.Index = tagGroupIndex;
                        tagGroupTag.Id = child.Text;
                        tagGroupTag.Name = "???";
                        tagGroupTag.Value = previousValues.ContainsKey(child.Text) ? previousValues[child.Text] : string.Empty; // Используем предыдущее значение, если оно было сохранено
                        tagGroupTag.Eu = string.Empty;

                        tagGroup.Tag.Add(tagGroupTag);
                        tagGroupIndex++;

                        // Добавляем строку в DataTable
                        dataTable.Rows.Add(node.Text, child.Text, tagGroupTag.Value);
                    }
                    continue;
                }

                var tag = new Tag();
                tag.Ordinal = childNode.Text;
                tag.Name = "???";
                tag.Id = childNode.Text;

                // Добавляем строку в DataTable
                dataTable.Rows.Add(node.Text, childNode.Text, previousValues.ContainsKey(childNode.Text) ? previousValues[childNode.Text] : string.Empty); // Используем предыдущее значение, если оно было сохранено
            }
        }

        List<TreeNode> GetChildNodes(TreeNode node)
        {
            List<TreeNode> childNodes = new List<TreeNode>();

            foreach (TreeNode childNode in node.Nodes)
            {
                childNodes.Add(childNode);
            }

            return childNodes;
        }


        // Общий метод для загрузки файла
        public TagList LoadXdbFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Файл не найден: {filePath}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(TagList));
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    return (TagList)serializer.Deserialize(fileStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}\n\nДетали: {ex.ToString()}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        //private void UpdateDataGridView(TreeNode selectedNode)
        //{


        //    // Если у узла нет дочерних элементов, добавляем его в DataGridView
        //    //if (selectedNode.Nodes.Count == 0)
        //    //{
        //    //    dataGridView1.Rows.Add(selectedNode.Text, "");
        //    //}
        //    //else
        //    //{
        //    //    foreach (var item in selectedNode.Nodes)
        //    //    {
        //    //        if (item is TreeNode node)
        //    //        {

        //    //            if (node.Parent != null)
        //    //            {
        //    //                dataGridView1.Rows.Add(node.Parent.Text, node.Text, "");
        //    //            }
        //    //            else
        //    //            {
        //    //                dataGridView1.Rows.Add("", node.Text, "");
        //    //            }

        //    //        }
        //    //    }
        //    //}
        //}

        private void AddChildNodeToDataGridView(string parent, TreeNode node)
        {
            dataGridView1.Rows.Add(parent, node.Text);
            foreach (var childNode in node.Nodes.Cast<TreeNode>())
            {
                AddChildNodeToDataGridView(parent, childNode);
            }
        }

        private void buttonXdbOutput_Click(object sender, EventArgs e)
        {

            CreateXdb();



        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SPT963ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 spt963form = new Form3();
            spt963form.Show();
        }

        private void SPT962ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 spt962form = new Form2();
            spt962form.Show();
        }

        private void ExitMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainform = new Form1();
            mainform.Show();
        }

        private void SpravkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создание и отображение модальной формы Form4
            using (Form4 spravkaForm = new Form4())
            {
                spravkaForm.StartPosition = FormStartPosition.CenterParent;
                spravkaForm.ShowDialog();
            }
        }


        // метод для загрузки данных
        public void LoadXdb(TagList xmlModel)
        {
            try
            {
                // Очищаем существующие данные
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                // Создаем новый объект DataTable
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Канал", typeof(string));
                dataTable.Columns.Add("Параметр", typeof(string));
                dataTable.Columns.Add("Значение", typeof(string));

                // Получаем значение TargetDevice
                string targetDevice = xmlModel.TargetDevice;

                // Вывод содержимого объекта _xmlModel
                foreach (var channel in xmlModel.Channel)
                {
                    MessageBox.Show($"Канал: {channel.Name}");
                    // Выведите здесь другие свойства, которые вам интересны
                }

                // Проверка значения параметра TargetDevice
                if (targetDevice == "TSPT962")
                {
                    // Заполняем DataTable данными из _xmlModel
                    foreach (var channel in xmlModel.Channel)
                    {
                        foreach (var tagOrGroup in channel.Tag)
                        {
                            if (tagOrGroup is Tag tag)
                            {
                                dataTable.Rows.Add(channel.Name, tag.Ordinal, tag.Value);
                            }
                            else if (tagOrGroup is TagGroup tagGroup)
                            {
                                foreach (var tagGroupTag in tagGroup.Tag)
                                {
                                    dataTable.Rows.Add(channel.Name, tagGroupTag.Id, tagGroupTag.Value);
                                }
                            }
                        }
                    }

                    // Устанавливаем источник данных для DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    string errorText = "Вы загружаете базу для СПТ963, попробуйте еще раз.";
                    MessageBox.Show(errorText, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void OpenProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создаем диалоговое окно для выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Xdb Files (*.xdb)|*.xdb";

            // Если пользователь выбрал файл и нажал "OK"
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Получаем путь к выбранному файлу
                string filePath = openFileDialog.FileName;

                // Отладочное сообщение для вывода пути к файлу
                MessageBox.Show($"Выбранный файл: {openFileDialog.FileName}");

                // Обрабатываем выбранный файл
                ProcessFile(filePath);
            }
        }


        private void ProcessFile(string filePath)
        {
            try
            {
                // Определение значения TargetDevice из файла
                string targetDevice;

                // Используем конструкцию using для автоматического закрытия потока файла
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(TagList));
                    TagList xmlModel = (TagList)serializer.Deserialize(fileStream);
                    targetDevice = xmlModel.TargetDevice;

                    // Создание нужной формы и передача объекта xmlModel
                    Form targetForm;
                    if (targetDevice == "TSPT962")
                    {
                        targetForm = new Form2();
                        targetForm.Show();
                        ((Form2)targetForm).LoadXdb(xmlModel);
                        this.Hide();
                    }
                    else if (targetDevice == "TSPT963")
                    {
                        targetForm = new Form3();
                        targetForm.Show();
                        // Добавьте здесь код для передачи xmlModel в Form3, если необходимо
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show($"Ошибка при обработке файла:", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обработке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Dictionary<string, Tuple<string, string>> paramTextMapping = new Dictionary<string, Tuple<string, string>>()
{
    { "001", new Tuple<string, string>("Параметр может вводиться пользователем с целью обеспечения сохранности значений настроечных параметров при перерывах в эксплуатации прибора, например, связанных с его поверкой. Пароль представляет собой строку из 6 цифр. До ввода пароля необходимо предварительно выключить микропереключатель защиты данных и остановить вычисления. После ввода пароля изменение настроечных параметров невозможно до его отмены, невозможно также возобновление вычислений. Отмена пароля производится повторным вводом его значения. При успешной отмене прибор выведет на индикацию: 001=Нет данных.", "1050029299") },
    { "003", new Tuple<string, string>("Параметр указывает тип оборудования, подключенного по интерфейсу RS232C, и скорость обмена по RS232C, а также скорость и тип протокола обмена по первому интерфейсу RS485. Значение параметра представляет собой строку из 10 символов, значение которых пояснено ниже. \r\n▪p₁ – указывает тип протокола, который применяется при обмене по первому интерфейсу RS485 между вычислителем и внешним устройством (ВУ), при этом: p₁=1 – применяется магистральный протокол с маркерным доступом к шине RS485,9-битовым форматом байтов без контроля четности и одним стоповым битом; p₁=2 - магистральный протокол с режимом работы шины RS485 ведущий/ведомый, 8 – битовым форматом байтов без контроля четности и 1-м стоповым битом; p₁=3 – применяется магистральный протокол с маркерным доступом к шине RS485,8-битовым форматом байтов без контроля четности и одним стоповым битом; p₁=5 - протокол Modbus RTU c 8 – битовым форматом байтов без контроля четности и2-мя стоповыми битами; \r\n▪e₁ – описывает оборудование, подключенное к RS232C: е₁=0 – компьютер или другое устройство, обеспечивающее прозрачный канал; е₁=1 - модем для коммутируемых телефонных линий или GSM модем, работающий в режиме CSD; е₁=2 – принтер; е₁=4 – GSM модем, работающий в режиме G2 или G3; \r\n▪s₁ – задает скорость обмена по RS232C, скорость выбирается из ряда 300,600,1200,2400,4800,9600,19200,38400,57600,115200 бод, при этом s₁=0 соответствует скорость 300 бод, … s₁=9 – 115200 бод; \r\n▪l₁ – указывает на способ управления потоком данных на интерфейсе RS232C посредством цепей RTS, CTS: l₁=0 – управление не осуществляется, l₁=1 – однонаправленное управление: возможен запрет на передачу данных со стороны прибора внешнему оборудованию (применяется при работе с принтером), l₁=2 – двунаправленное управление: возможен запрет на передачу и на прием данных (при-меняется при работе с модемом, в т. ч. с GSM-модемом); \r\n▪r₁ – указывает на наличие магистрального принтера, подключенного через адаптер АПС43 кпервому интерфейсу RS485: r₁=1 – есть принтер, r₁=0 – нет принтера; \r\n▪аа₁ – магистральный адрес прибора, аа₁=00…29; \r\n▪hh₁ - старший магистральный адрес, hh₁=00…29; hh₁ ≥ аа₁; \r\n▪v₁ – скорость обмена на магистрали; v₁=1-600 бод, …, v₁=9-115200 бод.", "1050100002") },
    // Добавьте другие значения и тексты для label5 и textBox1 по мере необходимости
};


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Проверяем, что выбрана конкретная ячейка
            if (dataGridView1.CurrentCell != null)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;

                // Получаем значение из ячейки в столбце с именем "Параметр"
                string paramName = dataGridView1.Rows[rowIndex].Cells["Параметр"].Value.ToString();

                // Проверяем, есть ли параметр в словаре, и если есть, устанавливаем соответствующий текст в textBox1 и label5
                if (paramTextMapping.ContainsKey(paramName))
                {
                    var texts = paramTextMapping[paramName];
                    textBox1.Text = texts.Item1;
                    label5.Text = texts.Item2;
                }
                else
                {
                    // Если значение параметра не найдено в словаре, установите другие тексты или оставьте textBox1 и label5 пустыми
                    textBox1.Text = "Текст для другого значения";
                    label5.Text = "Текст для другого значения (Label5)";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (FormSchema schemaForm = new FormSchema())
            {
                schemaForm.ShowDialog(); // Отображение формы модально
            }
        }
    }







    /* private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
     {
         if (comboBox1.SelectedIndex == 0)
         {
             tabControlElement.Show();
         }
     }

     */

}
