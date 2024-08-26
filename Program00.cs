namespace MusicPlayerApp
{
    public interface IMusicPlayer
    {
        void Play();
    }

    public class Mp3Player : IMusicPlayer
    {
        public void Play()
        {
            Console.WriteLine("Reproduciendo archivo MP3...");
        }
    }

    public class WavPlayer : IMusicPlayer
    {
        public void Play()
        {
            Console.WriteLine("Reproduciendo archivo WAV...");
        }
    }

    public class FlacPlayer : IMusicPlayer
    {
        public void Play()
        {
            Console.WriteLine("Reproduciendo archivo FLAC...");
        }
    }
    public class Mp4Player : IMusicPlayer
    {
        public void Play()
        {
            Console.WriteLine("Reproduciendo archivo MP4...");
        }
    }

    public abstract class MusicPlayerFactory
    {
        public abstract IMusicPlayer CreateMusicPlayer();
    }

    public class Mp3PlayerFactory : MusicPlayerFactory
    {
        public override IMusicPlayer CreateMusicPlayer()
        {
            return new Mp3Player();
        }
    }

    public class WavPlayerFactory : MusicPlayerFactory
    {
        public override IMusicPlayer CreateMusicPlayer()
        {
            return new WavPlayer();
        }
    }

    public class FlacPlayerFactory : MusicPlayerFactory
    {
        public override IMusicPlayer CreateMusicPlayer()
        {
            return new FlacPlayer();
        }
    }
    public class Mp4PlayerFactory : MusicPlayerFactory
    {
        public override IMusicPlayer CreateMusicPlayer()
        {
            return new Mp4Player();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MusicPlayerFactory mp3Factory = new Mp3PlayerFactory();
            IMusicPlayer mp3Player = mp3Factory.CreateMusicPlayer();
            mp3Player.Play();

            MusicPlayerFactory wavFactory = new WavPlayerFactory();
            IMusicPlayer wavPlayer = wavFactory.CreateMusicPlayer();
            wavPlayer.Play();

            MusicPlayerFactory flacFactory = new FlacPlayerFactory();
            IMusicPlayer flacPlayer = flacFactory.CreateMusicPlayer();
            flacPlayer.Play();

            MusicPlayerFactory mp4Factory = new Mp4PlayerFactory();
            IMusicPlayer mp4Player = mp4Factory.CreateMusicPlayer();
            mp4Player.Play();
        }
    }
}