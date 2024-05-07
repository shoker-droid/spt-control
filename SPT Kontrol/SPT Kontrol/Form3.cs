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
using System.Xml.Resolvers;
using System.Xml.Serialization;

namespace SPT_Kontrol
{
    public partial class Form3 : Form
    {
        private bool isCollapsed;
        private bool isCollapsedSecond;
        private bool isCollapsedThird;
        private bool isCollapsedFourth;
        private bool isCollapsedFifth;
        private bool isCollapsedSixth;
        private bool isCollapsedSeventh;
        private string _filePath;

        private TagList _xmlModel = new TagList();
        private string filePath;

        public Form3()
        {
            InitializeComponent();
        }

        private TagList _xmlModel1;

        public Form3(TagList xmlModel)
        {
            InitializeComponent();
            _xmlModel1 = xmlModel;
            LoadXdb(_xmlModel1);
        }

        // Добавьте конструктор, который принимает путь к файлу
        /*public Form3(string filePath) : this()
        {
            _filePath = filePath;

            // Загрузка данных при открытии формы
            LoadXdb();
        }*/

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConvertTreeViewIntoDataGridView();
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

            //Перебираем все строки из datagridView
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                //Получаем значения каждого столбца
                var channel = dataGridView1[0, i].Value.ToString();
                Debug.WriteLine("Channel = " + channel);
                var parametr = dataGridView1[1, i].Value.ToString();
                Debug.WriteLine("parametr = " + parametr);
                var value = dataGridView1[2, i].Value.ToString();
                Debug.WriteLine("value = " + value);
                //Если это узел без детей (типа Tag) то находим его
                var result = _xmlModel
                    .Channel.Where(x => x.Name == channel).FirstOrDefault()
                    ?.Tag.Where(x => (x as Tag)?.Ordinal == parametr).FirstOrDefault();

                if (result != null)
                {
                    //Если такой узел есть, то его значение делаем равным value
                    (result as Tag).Value = value;

                }
                //Если такого узла нет, то значит это узел с детьми типа TagGroup
                else
                {
                    //Находим такой узел
                    var tagGroup = _xmlModel
                        .Channel.Where(x => x.Name == channel).FirstOrDefault()
                        ?.Tag.Where(x => x.GetType() == typeof(TagGroup) && parametr.StartsWith((x as TagGroup).Ordinal)).FirstOrDefault() as TagGroup;
                    //Находим у него нужный нам объект типа Tag
                    var tag = tagGroup?.Tag.Where(x => x.Id.Remove(x.Id.IndexOf("Параметры")) == parametr).FirstOrDefault();
                    //Если нашли, то устанавливаем значение
                    if (tag != null)
                        tag.Value = value;
                }
            }
            //Создаем XmlSerializer и убираем все неймспейсы, делая их пустыми
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
                    //StreamWriter sw = new StreamWriter(fileStream);
                    //sw.Close();

                }

            }


        }
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


            // Обновляем _xmlModel перед отображением данных

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void BackMainToolStripMenuItem_Click(object sender, EventArgs e)
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
    }


}
