
namespace MusicPlayerApp
{
    internal class OpenFileDialog
    {
        public bool Multiselect { get; internal set; }
        public string[] SafeFileNames { get; internal set; }
        public string[] FileNames { get; internal set; }

        internal object ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}