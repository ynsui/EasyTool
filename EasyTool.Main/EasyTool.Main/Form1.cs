namespace EasyTool.Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var path = textBox1.Text;

            //��ǰ�ļ����ļ�
            var files = Directory.GetFiles(path).ToList();

            //���ļ��е������ļ�
            var childDirs = Directory.GetDirectories(path);
            foreach (var item in childDirs)
            {
                files.AddRange(Directory.GetFiles(item));
            }

            long deletedFileCount = 0;
            //ɾ�����а�����).���ļ�
            foreach (var item in files)
            {
                var arr = item.Split('.');


                if (arr[arr.Length - 2].EndsWith(")"))
                {
                    File.Delete(item);
                    deletedFileCount++;
                }
            }

            //��ʾ
            MessageBox.Show($"��ɾ���ظ��ļ���{deletedFileCount}��");



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
