using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;

namespace SweepingBlade.IO;

public interface IFileSystemWatcher : IDisposable
{
    event FileSystemEventHandler Changed;
    event FileSystemEventHandler Created;
    event FileSystemEventHandler Deleted;
    event ErrorEventHandler Error;
    event RenamedEventHandler Renamed;
    void BeginInit();
    void EndInit();
    WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType);
    WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout);
    bool EnableRaisingEvents { get; set; }
    string Filter { get; set; }
#if FEATURE_FILE_SYSTEM_WATCHER_FILTERS
    Collection<string> Filters { get; }
#endif
    bool IncludeSubdirectories { get; set; }
    int InternalBufferSize { get; set; }
    NotifyFilters NotifyFilter { get; set; }
    string Path { get; set; }
    ISite Site { get; set; }
    ISynchronizeInvoke SynchronizingObject { get; set; }
}