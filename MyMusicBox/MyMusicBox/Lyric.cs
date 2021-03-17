using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyMusicBox
{
    class Lyric
    {
        public int minute;
        public float second;
        public float totSecond;
        public string strLyric;
    }

    class LyricFiles
    {
        public List<Lyric> lstLyric = new List<Lyric>();

        public void LoadLyricFromFile(string fileName)
        {

            Encoding encoder = Encoding.GetEncoding("GB2312");
            FileStream fs = new FileStream(fileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs, encoder);

            string strLyric;

            while ((strLyric = sr.ReadLine()) != null)
            {
                if (strLyric == "")
                {
                    continue;
                }

                Lyric lyric = new Lyric();
                lyric.minute = int.Parse(strLyric.Substring(1, 2));
                lyric.second = float.Parse(strLyric.Substring(4, 5));
                lyric.totSecond = lyric.minute * 60 + lyric.second;
                lyric.strLyric = strLyric.Substring(10);

                lstLyric.Add(lyric);
            }

            sr.Close();
            fs.Close();

        }

    }
}
