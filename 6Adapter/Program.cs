using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            OGGAdapter oGGAdapter = new OGGAdapter(new OGG());
            oGGAdapter.SetFile("Somestring");

            //OGGAdapterStrong oGGAdapterStrong = new OGGAdapterStrong(new OGG());

            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.AddToPlayList(new MP3());
            audioPlayer.AddToPlayList(new WAV());
            audioPlayer.AddToPlayList((IMediaContent)oGGAdapter);

            audioPlayer.Play();
        }
    }
}
