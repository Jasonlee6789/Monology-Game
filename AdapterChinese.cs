using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MolopolyGame
{// 2.2 add a new  design pattern_Adapter

    class Target
    {
        public virtual void WriteLine(string s)
        {
            Console.WriteLine(s);
        }
    }


    class Adapter : Target
    {
        private AdapteeChinese adapteeChinese = new AdapteeChinese();
        public override void WriteLine(string s)
        {
            adapteeChinese.WriteLineToChinese(s);
        }
    }

    class AdapteeChinese
    {
        // 2.5 Demonstrate use of collection 
        private static Dictionary<string, string> TRANSLATIONS = new Dictionary<string, string>
        { {"Would you like to setup initial money ( if no, you will just use 2000$) ? (Y/N)",
                "请问你想要设置玩家的初始金额吗（如果不想，初始玩家将获得2000￥）？（是/否）" } };

        public void WriteLineToChinese(string origin)
        {
           
                Console.WriteLine(TRANSLATIONS[origin]);
           
        }
    }
}
