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

            //当前文件夹文件
            var files = Directory.GetFiles(path).ToList();

            //子文件夹的所有文件
            var childDirs = Directory.GetDirectories(path);
            foreach (var item in childDirs)
            {
                files.AddRange(Directory.GetFiles(item));
            }

            long deletedFileCount = 0;
            //删除其中包括“).”文件
            foreach (var item in files)
            {
                var arr = item.Split('.');


                if (arr[arr.Length - 2].EndsWith(")"))
                {
                    File.Delete(item);
                    deletedFileCount++;
                }
            }

            //提示
            MessageBox.Show($"已删除重复文件：{deletedFileCount}个");



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
