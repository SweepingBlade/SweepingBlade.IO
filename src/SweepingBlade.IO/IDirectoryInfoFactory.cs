namespace SweepingBlade.IO;

public interface IDirectoryInfoFactory
{
    IDirectoryInfo FromDirectoryName(string directoryName);
}