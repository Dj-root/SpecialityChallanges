using System;

namespace CSharp.Essential.Unit4
{
    public class Player : IRecordable, IPlayable
    {
        public string RecordName { get; private set; }

        public Player(string recordName)
        {
            RecordName = recordName;
        }

        public void Record()
        {
            Console.WriteLine("Recording track {0}", RecordName);
        }

        public void Play()
        {
            Console.WriteLine("Playing track {0}", RecordName);
        }


        void IRecordable.Pause()
        {
            Console.WriteLine("Paused recording of track {0}", RecordName);
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Stoped recording of track {0}", RecordName);
        }


        void IPlayable.Pause()
        {
            Console.WriteLine("Paused playback of track {0}", RecordName);
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stoped playback of track {0}", RecordName);
        }
    }
}