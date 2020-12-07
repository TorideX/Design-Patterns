using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Adapter
{
    public class OGGAdapter : IMediaContent
    {
        private OGG _ogg;

        public OGGAdapter(OGG original)
        {
            _ogg = original;
        }

        public void Play()
        {
            _ogg.PlayFromFile(false);
        }

        public void SetFile(string filename)
        {

        }

        public void Stop()
        {
            _ogg.StopMusic();
        }
    }

    public class OGGAdapterStrong : OGG, IMediaContent
    {
        public void Play()
        {
            PlayFromFile(false);
        }

        public void Stop()
        {
            StopMusic();
        }
    }
}
