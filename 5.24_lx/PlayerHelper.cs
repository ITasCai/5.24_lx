using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._24_lx
{
    /// <summary>
    /// 播放器抽象类
    /// </summary>
   abstract class PlayerHelper
    {
        protected string fiieName;

        public PlayerHelper(string fiieName) {
            this.fiieName = fiieName;
        }

        public abstract void Play();
    }
}
