using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._24_lx
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例化播放工具类
            PlayTools pt = new PlayTools();
            bool result = pt.IsPlayer("aaaa.mp4");
            if (result==true)
            {
                Console.WriteLine("正在播放中。。。。。。。。。。");
            }
            else
            {
                Console.WriteLine("此视频格式暂不支持！");
            }
            Console.ReadKey();
        }
    }
}
