namespace SweepingBlade.IO;

public interface IDriveInfoFactory
{
    IDriveInfo FromDriveName(string driveName);
    IDriveInfo[] GetDrives();
}