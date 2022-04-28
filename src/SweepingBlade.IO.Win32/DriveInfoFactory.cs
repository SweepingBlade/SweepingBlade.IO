using System;
using System.Linq;

namespace SweepingBlade.IO.Win32;

public class DriveInfoFactory : IDriveInfoFactory
{
    private readonly IFileSystem _fileSystem;

    public DriveInfoFactory(IFileSystem fileSystem)
    {
        _fileSystem = fileSystem ?? throw new ArgumentNullException(nameof(fileSystem));
    }

    public IDriveInfo FromDriveName(string driveName)
    {
        var driveInfo = new System.IO.DriveInfo(driveName);
        return new DriveInfo(_fileSystem, driveInfo);
    }

    public IDriveInfo[] GetDrives()
    {
        return System.IO.DriveInfo.GetDrives().Select(driveInfo => new DriveInfo(_fileSystem, driveInfo)).ToArray<IDriveInfo>();
    }
}