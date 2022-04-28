using System;

namespace SweepingBlade.IO.Win32;

public class Path : IPath
{
    private readonly IFileSystem _fileSystem;

    public Path(IFileSystem fileSystem)
    {
        _fileSystem = fileSystem ?? throw new ArgumentNullException(nameof(fileSystem));
    }

    public char AltDirectorySeparatorChar => System.IO.Path.AltDirectorySeparatorChar;

    public char DirectorySeparatorChar => System.IO.Path.DirectorySeparatorChar;

    public char PathSeparator => System.IO.Path.PathSeparator;

    public char VolumeSeparatorChar => System.IO.Path.VolumeSeparatorChar;

    public string ChangeExtension(string path, string extension)
    {
        return System.IO.Path.ChangeExtension(path, extension);
    }

    public string Combine(params string[] paths)
    {
        return System.IO.Path.Combine(paths);
    }

    public string Combine(string path1, string path2)
    {
        return System.IO.Path.Combine(path1, path2);
    }

    public string Combine(string path1, string path2, string path3)
    {
        return System.IO.Path.Combine(path1, path2, path3);
    }

    public string Combine(string path1, string path2, string path3, string path4)
    {
        return System.IO.Path.Combine(path1, path2, path3, path4);
    }

    public string GetDirectoryName(string path)
    {
        return System.IO.Path.GetDirectoryName(path);
    }

    public string GetExtension(string path)
    {
        return System.IO.Path.GetExtension(path);
    }

    public string GetFileName(string path)
    {
        return System.IO.Path.GetFileName(path);
    }

    public string GetFileNameWithoutExtension(string path)
    {
        return System.IO.Path.GetFileNameWithoutExtension(path);
    }

    public string GetFullPath(string path)
    {
        return System.IO.Path.GetFullPath(path);
    }

# if FEATURE_ADVANCED_PATH_OPERATIONS
    public string GetFullPath(string path, string basePath)
    {
        return System.IO.Path.GetFullPath(path, basePath);
    }
#endif

    public char[] GetInvalidFileNameChars()
    {
        return System.IO.Path.GetInvalidFileNameChars();
    }

    public char[] GetInvalidPathChars()
    {
        return System.IO.Path.GetInvalidPathChars();
    }

    public string GetPathRoot(string path)
    {
        return System.IO.Path.GetPathRoot(path);
    }

    public string GetRandomFileName()
    {
        return System.IO.Path.GetRandomFileName();
    }

    public string GetTempFileName()
    {
        return System.IO.Path.GetTempFileName();
    }

    public string GetTempPath()
    {
        return System.IO.Path.GetTempPath();
    }

    public bool HasExtension(string path)
    {
        return System.IO.Path.HasExtension(path);
    }

    public bool IsPathRooted(string path)
    {
        return System.IO.Path.IsPathRooted(path);
    }

#if FEATURE_ADVANCED_PATH_OPERATIONS
    public bool IsPathFullyQualified(string path)
    {
        return System.IO.Path.IsPathFullyQualified(path);
    }

    public string GetRelativePath(string relativeTo, string path)
    {
        return System.IO.Path.GetRelativePath(relativeTo, path);
    }
#endif

#if FEATURE_PATH_JOIN_WITH_SPAN
    public string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2)
    {
        return System.IO.Path.Join(path1, path2);
    }

    public string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3)
    {
        return System.IO.Path.Join(path1, path2, path3);
    }

    public bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, Span<char> destination, out int charsWritten)
    {
        return System.IO.Path.TryJoin(path1, path2, destination, out charsWritten);
    }

    public bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3, Span<char> destination, out int charsWritten)
    {
        return System.IO.Path.TryJoin(path1, path2, path3, destination, out charsWritten);
    }
#endif
}