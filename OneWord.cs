using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQ2020
{
    public class OneWord
    {
        private Boolean sender;//true表示本用户发出的,false表示本用户接收的
        private DateTime time;
        private string text;//聊天文本内容

        public bool Sender { get => sender; set => sender = value; }
        public DateTime Time { get => time; set => time = value; }
        public string Text { get => text; set => text = value; }
    }
}
