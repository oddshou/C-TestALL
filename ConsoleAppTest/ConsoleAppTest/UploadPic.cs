using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    /// <summary>
    /// 将指定目录下的文件上传，生成一个地址字符串
    /// </summary>
    public class UploadPic
    {
        private int mAppId;
        /// <summary>
        /// 将路径下的所有图片上传到云
        /// </summary>
        /// <param name="path">图片存储路径</param>
        public UploadPic(int appid)
        {
            this.mAppId = appid;

        }

        public string upload4path(string path)
        {
            string resultString = "";
            FileSystemInfo fileSystem = null;
            if (Directory.Exists(path))
            {
                fileSystem = new DirectoryInfo(path);
            }
            else
            {
                return resultString;
            }
            var fileList = ListFiles(fileSystem);
            var fileArray = fileList.Split(',');
            
            foreach (var item in fileArray)
            {
                //resultString += Upload(item) + ",";
                //从后往前加，调整图片顺序
                resultString = Upload(item) + "," + resultString;
            }
            if (resultString.EndsWith(","))
            {
                resultString = resultString.Remove(resultString.Length -1, 1);
            }
            return resultString;
        }

        /// <summary>
        /// 上传单个文件，返回文件路径
        /// </summary>
        /// <returns></returns>
        private string Upload(string filePath)
        {
            var md5 = filePath.getFilesMD5Hash();
            FileInfo fileInfo = new FileInfo(filePath);
            localhost.UploadFile service = new localhost.UploadFile();
            //var result = TmpResInfoBLL.StartTransfer(mAppId, 0, filePath, 1, Convert.ToInt32(fileInfo.Length), md5);
            var result = service.StartTransfer(mAppId, 0, filePath, 1, Convert.ToInt32(fileInfo.Length), md5);

            var resultArray = result.Split('|');
            if (resultArray[0] == "0")
            {
                //返回 0|key
                var token = resultArray[1];
                byte[] fileByte = File.ReadAllBytes(filePath);
                //var transResult = TmpResInfoBLL.Transfer(token, fileByte, 1);
                var transResult = service.Transfer(token, fileByte, 1);
                var transList = transResult.Split(',');
                return transList[1];
            }
            else
            {
                //文件已经存在
                var resultNext = resultArray[1].Split(',');
                var fileName = resultNext[0];//获取地址
                //if(resultArray[2] != "")
                //{
                //    //包含解包信息，
                //}
                return fileName;
            }
        }

        /// <summary>  
        /// 遍历文件  
        /// </summary>  
        /// <param name="info"></param>  
        public string ListFiles(FileSystemInfo info)
        {
            string result = "";
            if (!info.Exists) return result;
            DirectoryInfo dir = info as DirectoryInfo;
            if (dir == null) return result;
            FileSystemInfo[] files = dir.GetFileSystemInfos();
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = files[i] as FileInfo;
                if (file != null && file.Name.Trim().LastIndexOf(".") > -1)
                {
                    //if (file.Name.Substring(file.Name.LastIndexOf(".")).ToUpper() == ".JPG")
                    //{
                    //    //this.lvSourceFolderList.Items.Add(file.FullName);
                    //    //imageList.Add(file.FullName);
                        
                    //}
                    result += file.FullName + ",";
                }
                //else
                //{
                //不必递归
                //    ListFiles(files[i]); //对于子目录，进行递归调用  
                //}
            }
            if (result.EndsWith(","))
            {
                result = result.Remove(result.Length -1, 1);
            }
            return result;
        }

        

    }

    public static class AllExtension
    {
        /// <summary>
        /// 获取指定文件的MD5值
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static string getFilesMD5Hash(this string target)
        {

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            FileStream stream = new FileStream(target, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);

            md5.ComputeHash(stream);

            stream.Close();

            byte[] hash = md5.Hash;

            StringBuilder sb = new StringBuilder();

            foreach (byte b in hash)
            {
                sb.Append(string.Format("{0:X2}", b));
            }

            return sb.ToString();
        }
    }
}
