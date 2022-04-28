using System;
using System.IO;

namespace SweepingBlade.IO.Win32;

public class DriveInfo : IDriveInfo
{
    private readonly System.IO.DriveInfo _driveInfo;
    private readonly IFileSystem _fileSystem;

    public DriveInfo(IFileSystem fileSystem, System.IO.DriveInfo driveInfo)
    {
        _fileSystem = fileSystem ?? throw new ArgumentNullException(nameof(fileSystem));
        _driveInfo = driveInfo ?? throw new ArgumentNullException(nameof(driveInfo));
    }

    public long AvailableFreeSpace => _driveInfo.AvailableFreeSpace;

    public string DriveFormat => _driveInfo.DriveFormat;

    public DriveType DriveType => _driveInfo.DriveType;

    public bool IsReady => _driveInfo.IsReady;

    public string Name => _driveInfo.Name;

    public IDirectoryInfo RootDirectory => new DirectoryInfo(_fileSystem, _driveInfo.RootDirectory);

    public long TotalFreeSpace => _driveInfo.TotalFreeSpace;

    public long TotalSize => _driveInfo.TotalSize;

    public string VolumeLabel
    {
        get => _driveInfo.VolumeLabel;
        set => _driveInfo.VolumeLabel = value;
    }
}