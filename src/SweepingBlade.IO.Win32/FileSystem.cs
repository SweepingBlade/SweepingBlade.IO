namespace SweepingBlade.IO.Win32;

public class FileSystem : IFileSystem
{
    private IDirectory _directory;
    private IDirectoryInfoFactory _directoryInfoFactory;
    private IDriveInfoFactory _driveInfoFactory;
    private IFile _file;
    private IFileInfoFactory _fileInfoFactory;
    private IFileSystemWatcherFactory _fileSystemWatcherFactory;
    private IPath _path;

    public IDirectory Directory => _directory ??= new Directory(this);
    public IDirectoryInfoFactory DirectoryInfo => _directoryInfoFactory ??= new DirectoryInfoFactory(this);
    public IDriveInfoFactory DriveInfo => _driveInfoFactory ??= new DriveInfoFactory(this);
    public IFile File => _file ??= new File(this);
    public IFileInfoFactory FileInfo => _fileInfoFactory ??= new FileInfoFactory(this);
    public IFileSystemWatcherFactory FileSystemWatcher => _fileSystemWatcherFactory ??= new FileSystemWatcherFactory(this);
    public IPath Path => _path ??= new Path(this);
}