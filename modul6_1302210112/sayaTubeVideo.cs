using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
            Contract.Requires(title != null, "judul tidak boleh null");
            Contract.Requires(title.Length <= 200, "judul tidak boleh lebih dari 200 carakter");
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
            Contract.Requires(playcount>0&&playcount<=25000000,"jumlah play tidak boleh negatif dan lebih dari 25,0000,000");
               this.playcount += playcount;
            try
            {
                checked
                {
                    this.playcount += playcount;
                }
            }catch(OverflowException e)
            {
                Console.WriteLine($"ERROR:{e.Message}");
            }
        }
        public void printvideoDetail()
        {
            Console.WriteLine($"id video:{this.id}\n   dengan judul {this.title}\n dengan jumlah viewers{this.playcount}\n");
        }
    }
}
