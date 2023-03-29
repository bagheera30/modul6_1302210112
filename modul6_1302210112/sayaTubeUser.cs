using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210112
{
    internal class sayaTubeUser
    {
        private int id;
        private List<sayaTubeVideo> uploadVideo;
        public string username;
        public sayaTubeUser(string username)
        {
            this.id = new Random().Next(10000, 99999);
            this.username = username;
            this.uploadVideo = new List<sayaTubeVideo>();

        }
        public int GetTotalVideoCount()
        {
            int total = 0;
            for(int i=0;i<this.uploadVideo.Count;i++)
            {
                total += uploadVideo[i].getplaycount();
            }
            return total;
           
        }
        public void addvideo(sayaTubeVideo video)
        {
            uploadVideo.Add(video);
        }
        public void playallvideo()
        {
            Console.WriteLine("user: " + username);
            for(int i=0;i<uploadVideo.Count;i++)
            {
                Console.WriteLine("video" + (i + 1) + uploadVideo[i].getTitle());
            }
        }

    }
}
