using System;

namespace SweepingBlade.IO;

public interface IPath
{
        string ChangeExtension(string path, string extension);
        string Combine(params string[] paths);
        string Combine(string path1, string path2);
        string Combine(string path1, string path2, string path3);
        string Combine(string path1, string path2, string path3, string path4);
        string GetDirectoryName(string path);
        string GetExtension(string path);
        string GetFileName(string path);
        string GetFileNameWithoutExtension(string path);
        string GetFullPath(string path);
#if FEATURE_ADVANCED_PATH_OPERATIONS
        string GetFullPath(string path, string basePath);
#endif
        char[] GetInvalidFileNameChars();
        char[] GetInvalidPathChars();
        string GetPathRoot(string path);
        string GetRandomFileName();
        string GetTempFileName();
        string GetTempPath();
        bool HasExtension(string path);
        bool IsPathRooted(string path);
        char AltDirectorySeparatorChar { get; }
        char DirectorySeparatorChar { get; }
        char PathSeparator { get; }
        char VolumeSeparatorChar { get; }

#if FEATURE_ADVANCED_PATH_OPERATIONS
        bool IsPathFullyQualified(string path);
        string GetRelativePath(string relativeTo, string path);
#endif

#if FEATURE_PATH_JOIN_WITH_SPAN
        string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2);
        string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3);
        bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3, Span<char> destination, out int charsWritten);
        bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, Span<char> destination, out int charsWritten);
#endif
}