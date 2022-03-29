using System;
using System.Collections.Generic;
using System.IO;

//using System.Linq;
using System.Text;
using System.Windows.Forms;

//using System.Threading.Tasks;

namespace ArrangeLog
{
    public class JudgeTime
    {
        public void JudgeLog()
        {
            DateTime dateToJudge = DateTime.Now.Date;
            DateTime fileModifiedDate;
            string pathNow = Directory.GetCurrentDirectory();
            string targetPath = string.Empty;
            string[] fileNames = Directory.GetFiles(pathNow, "*.txt");

            foreach (string fileName in fileNames)
            {
                fileModifiedDate = File.GetLastWriteTime(fileName).Date;
                targetPath = Path.Combine(pathNow, fileModifiedDate.ToString("yyyyMM"));
                if (dateToJudge > fileModifiedDate)
                {
                    if (!Directory.Exists(targetPath))
                        Directory.CreateDirectory(targetPath);

                    File.Copy(fileName, Path.Combine(targetPath, Path.GetFileName(fileName)), true);
                    File.Delete(fileName);
                }
            }

            //MessageBox.Show(path);
        }
    }
}