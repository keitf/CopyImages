using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//从任何路径获取图片
//将图片进行复制
//保证图片不会丢失
//软件关闭后自动删除复制的图片及文件
namespace CopyImages
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        //创建一个存放图片的文件夹 命名为    Path
        public string Path = @"D:\DCIM";

        private void Form1_Load(object sender, EventArgs e)
        {
            //加载两个图片控件的默认图片 路径为 程序根目录
            this.picOpenImage.Image = Image.FromFile(@"images\SystemDLAM.jpg");
            this.picUpImage.Image = Image.FromFile(@"images\Systemdefault.jpg");
            //创建文件夹 判断是否存在 当没有相同文件夹名时创建
            //个人感觉 只要名字够意思一般不会有相同的名字
            if (Directory.Exists(Path))
            {
                //MessageBox.Show("文件已存在");
            }
            else
            {
                Directory.CreateDirectory(Path);
                //Directory.CreateDirectory(@"D:\DCIM");
            }
        }
        //设置全局遍 用来存放 上传图片的路径
        public string ImagesUrl = "";

        //选择图片按钮
        //功能：打开一个窗体选择图片，默认JPG格式
        private void lnklabUpdata_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.picUpImage.Image = Image.FromFile(fileDialog.FileName);
                
                //以获取图片路径
                ImagesUrl = fileDialog.FileName;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //生成路径对象
            ImagesInfo images = new ImagesInfo();

            //为对象路径赋值
            images.ImagesURL = this.ImagesUrl;
            
            //在右侧显示上传的图片
            this.picOpenImage.Image = Image.FromFile(newpath);
        }

        public static string path;
        public static string newpath;
        public static int i = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ImagesUrl);
            this.picUpImage.Image = Image.FromFile(@"images\Systemdefault.jpg");
            path = ImagesUrl;
            newpath = @"D:\DCIM\" + i + ".jpg";
            FileCopy(path, newpath);
            i++;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DelectDir(Path);
            DirectoryInfo info = new DirectoryInfo(Path);
            //foreach (DirectoryInfo dir in info.GetDirectories())
            //{
            //    dir.Delete(true);
            //    dir.Delete();
            //}
            //this.picOpenImage.Image = Image.FromFile(@"images\SystemDLAM.jpg");
            info.Delete(true);
            //this.DeleteFile(Path);
            
            this.Close();
        }
        private static void FileCopy(string oldFile, string newFilePath)
        {
            File.Copy(oldFile, newFilePath);
        }
        //删除文件
        //public bool DeleteFile(string path1)
        //{
        //    try
        //    {
        //        if (File.Exists(path1))
        //        {
        //            File.Delete(path1);
        //        }
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        public static void DelectDir(string srcPath)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(srcPath);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
                foreach (FileSystemInfo i in fileinfo)
                {
                    if (i is DirectoryInfo)            //判断是否文件夹
                    {
                        DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                        subdir.Delete(true);          //删除子目录和文件
                    }
                    else
                    {
                        //如果 使用了 streamreader 在删除前 必须先关闭流 ，否则无法删除 sr.close();
                        File.Delete(i.FullName);      //删除指定文件
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
