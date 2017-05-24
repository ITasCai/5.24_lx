using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._24_lx
{
    class PlayTools
    {

        public bool IsPlayer(string fileName) {

            PlayerHelper playerHelper;

            //找到“.”的索引的位置
            int index = fileName.IndexOf(".");
            //截取。后面的格式
            string fileExtesion = fileName.Substring(index+1);
                //判断内容是否为空
            if (!string.IsNullOrEmpty(fileExtesion))
            {
                switch (fileExtesion.ToUpper())
                {
                    case "AVI":
                        //调用AVI类的播放方法

                        playerHelper = new Avi(fileName);
                        break;
                    case "MPEG":
                        playerHelper = new Mpeg(fileName);
                        break;
                    case "RMVB":
                        playerHelper = new Rmvb(fileName);
                        break;
                    default:
                        return false;
                }
                playerHelper.Play();
                return true;
            }
         
                return false;   
        }
    }
}
