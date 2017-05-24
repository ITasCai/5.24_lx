using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._24_lx
{
    class Avi : PlayerHelper
    {
        public Avi(string fiieName) : base(fiieName)
        {
        }

        /// <summary>
        /// 重写播放得的视屏
        /// </summary>
        public override void Play()
        {
            Console.WriteLine("播放Mpeg格式的视频:"+fiieName);
        }
    }
}
