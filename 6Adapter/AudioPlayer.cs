using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Adapter
{
    public interface IMediaContent
    {
        void Play();
        void Stop();
    }
    class AudioPlayer
    {
        private List<IMediaContent> playList;
        public AudioPlayer()
        {
            playList = new List<IMediaContent>();
        }

        public void AddToPlayList(IMediaContent music)
        {
            playList.Add(music);
        }

        public void Play()
        {
            foreach (var item in playList)
            {
                item.Play();
            }
        }
    }
}
