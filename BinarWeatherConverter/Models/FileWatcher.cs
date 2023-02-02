using BinarWeatherConverter.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.Models
{
    public class FileWatcher
    {
        public event EventHandler FileWatcherEvent;
        private MainViewModel VM;
        private FileInfo fileWatched;
        private FileSystemWatcher watcher;

        public FileWatcher(MainViewModel vm)
        {
            VM = vm;
        }

        public void Watch(string path)
        {
            FileInfo fi = new FileInfo(path);

            if (fileWatched == fi)
                return;

            if (watcher != null)
            {
                //watcher -= new FileSystemEventHandler(OnChanger);
                watcher.Dispose();
            }

            fileWatched = fi;

            if (fi.Exists)
            {
                watcher = new FileSystemWatcher()
                {
                    Path = fi.DirectoryName,
                    Filter = fi.Name,
                    NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.CreationTime | NotifyFilters.Size
                };
                watcher.Changed += new FileSystemEventHandler(OnChanged);
                watcher.EnableRaisingEvents= true;
            }
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            FileWatcherEvent?.Invoke(this, e);
        }
    }
}
