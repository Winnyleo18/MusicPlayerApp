namespace MusicPlayerApp
{
    internal class Program
    {
        public static MusicPlayerApp MusicPlayerApp { get; private set; }
        public static object MusicPlayer { get; private set; }

        static void Main(string[] args)
        {
            MusicPlayerApp = new MusicPlayerApp();
            
        }
    }
}
