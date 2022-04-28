using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;

namespace SweepingBlade.IO.Win32;

public class FileSystemWatcher : IFileSystemWatcher
{
    public event FileSystemEventHandler Changed;
    public event FileSystemEventHandler Created;
    public event FileSystemEventHandler Deleted;
    public event ErrorEventHandler Error;
    public event RenamedEventHandler Renamed;

    private readonly System.IO.FileSystemWatcher _watcher;

    public FileSystemWatcher()
        : this(new System.IO.FileSystemWatcher())
    {
    }

    public FileSystemWatcher(string path)
        : this(new System.IO.FileSystemWatcher(path))
    {
    }

    public FileSystemWatcher(string path, string filter)
        : this(new System.IO.FileSystemWatcher(path, filter))
    {
    }

    public FileSystemWatcher(System.IO.FileSystemWatcher watcher)
    {
        _watcher = watcher ?? throw new ArgumentNullException(nameof(watcher));
        _watcher.Created += OnCreated;
        _watcher.Changed += OnChanged;
        _watcher.Deleted += OnDeleted;
        _watcher.Error += OnError;
        _watcher.Renamed += OnRenamed;
    }

    public bool EnableRaisingEvents
    {
        get => _watcher.EnableRaisingEvents;
        set => _watcher.EnableRaisingEvents = value;
    }

    public string Filter
    {
        get => _watcher.Filter;
        set => _watcher.Filter = value;
    }

#if FEATURE_FILE_SYSTEM_WATCHER_FILTERS
    public Collection<string> Filters => _watcher.Filters;
#endif

    public bool IncludeSubdirectories
    {
        get => _watcher.IncludeSubdirectories;
        set => _watcher.IncludeSubdirectories = value;
    }

    public int InternalBufferSize
    {
        get => _watcher.InternalBufferSize;
        set => _watcher.InternalBufferSize = value;
    }

    public NotifyFilters NotifyFilter
    {
        get => _watcher.NotifyFilter;
        set => _watcher.NotifyFilter = value;
    }

    public string Path
    {
        get => _watcher.Path;
        set => _watcher.Path = value;
    }

    public ISite Site
    {
        get => _watcher.Site;
        set => _watcher.Site = value;
    }

    public ISynchronizeInvoke SynchronizingObject
    {
        get => _watcher.SynchronizingObject;
        set => _watcher.SynchronizingObject = value;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public void BeginInit()
    {
        _watcher.BeginInit();
    }

    public void EndInit()
    {
        _watcher.EndInit();
    }

    public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType)
    {
        return _watcher.WaitForChanged(changeType);
    }

    public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout)
    {
        return _watcher.WaitForChanged(changeType, timeout);
    }

    private void Dispose(bool disposing)
    {
        if (disposing)
        {
            _watcher.Created -= OnCreated;
            _watcher.Changed -= OnChanged;
            _watcher.Deleted -= OnDeleted;
            _watcher.Error -= OnError;
            _watcher.Renamed -= OnRenamed;
            _watcher.Dispose();
        }
    }

    private void OnChanged(object sender, FileSystemEventArgs args)
    {
        Changed?.Invoke(sender, args);
    }

    private void OnCreated(object sender, FileSystemEventArgs args)
    {
        Created?.Invoke(sender, args);
    }

    private void OnDeleted(object sender, FileSystemEventArgs args)
    {
        Deleted?.Invoke(sender, args);
    }

    private void OnError(object sender, ErrorEventArgs args)
    {
        Error?.Invoke(sender, args);
    }

    private void OnRenamed(object sender, RenamedEventArgs args)
    {
        Renamed?.Invoke(sender, args);
    }
}