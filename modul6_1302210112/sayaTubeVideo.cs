using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210112
{
    internal class sayaTubeVideo
    {
        private int id;
        private string title;
        private int playcount;

        public sayaTubeVideo(string title)
        {
            this.title = title;
            this.id = new Random().Next(10000, 99999);
            this.playcount = 0;
        }
        public int getplaycount()
        {
            return playcount;
        }
        public string getTitle()
        {
            return title;
        }
        public void incresePlaycount(int playcount)
        {
               this.playcount += playcount;
        }
        public void printvideoDetail()
        {
            Console.WriteLine($"id video:{this.id}\n   dengan judul {this.title}\n dengan jumlah viewers{this.playcount}\n");
        }
    }
}
