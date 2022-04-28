namespace SweepingBlade.IO;

public interface IFileSystemWatcherFactory
{
    IFileSystemWatcher CreateNew();
    IFileSystemWatcher CreateNew(string path);
    IFileSystemWatcher CreateNew(string path, string filter);
}