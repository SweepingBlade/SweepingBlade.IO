#if FEATURE_ASYNC_FILE
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SweepingBlade.IO.Win32
{
    public partial class File
    {
        public Task AppendAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken)
        {
            return System.IO.File.AppendAllLinesAsync(path, contents, cancellationToken);
        }

        public Task AppendAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken)
        {
            return System.IO.File.AppendAllLinesAsync(path, contents, encoding, cancellationToken);
        }

        public Task AppendAllTextAsync(string path, string contents, CancellationToken cancellationToken)
        {
            return System.IO.File.AppendAllTextAsync(path, contents, cancellationToken);
        }

        public Task AppendAllTextAsync(string path, string contents, Encoding encoding, CancellationToken cancellationToken)
        {
            return System.IO.File.AppendAllTextAsync(path, contents, encoding, cancellationToken);
        }

        public Task<byte[]> ReadAllBytesAsync(string path, CancellationToken cancellationToken)
        {
            return System.IO.File.ReadAllBytesAsync(path, cancellationToken);
        }

        public Task<string[]> ReadAllLinesAsync(string path, CancellationToken cancellationToken)
        {
            return System.IO.File.ReadAllLinesAsync(path, cancellationToken);
        }

        public Task<string[]> ReadAllLinesAsync(string path, Encoding encoding, CancellationToken cancellationToken)
        {
            return System.IO.File.ReadAllLinesAsync(path, encoding, cancellationToken);
        }

        public Task<string> ReadAllTextAsync(string path, CancellationToken cancellationToken)
        {
            return System.IO.File.ReadAllTextAsync(path, cancellationToken);
        }

        public Task<string> ReadAllTextAsync(string path, Encoding encoding, CancellationToken cancellationToken)
        {
            return System.IO.File.ReadAllTextAsync(path, encoding, cancellationToken);
        }

        public Task WriteAllBytesAsync(string path, byte[] bytes, CancellationToken cancellationToken)
        {
            return System.IO.File.WriteAllBytesAsync(path, bytes, cancellationToken);
        }

        public Task WriteAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken)
        {
            return System.IO.File.WriteAllLinesAsync(path, contents, cancellationToken);
        }

        public Task WriteAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken)
        {
            return System.IO.File.WriteAllLinesAsync(path, contents, encoding, cancellationToken);
        }

        public Task WriteAllLinesAsync(string path, string[] contents, CancellationToken cancellationToken)
        {
            return System.IO.File.WriteAllLinesAsync(path, contents, cancellationToken);
        }

        public Task WriteAllLinesAsync(string path, string[] contents, Encoding encoding, CancellationToken cancellationToken)
        {
            return System.IO.File.WriteAllLinesAsync(path, contents, encoding, cancellationToken);
        }

        public Task WriteAllTextAsync(string path, string contents, CancellationToken cancellationToken)
        {
            return System.IO.File.WriteAllTextAsync(path, contents, cancellationToken);
        }

        public Task WriteAllTextAsync(string path, string contents, Encoding encoding, CancellationToken cancellationToken)
        {
            return System.IO.File.WriteAllTextAsync(path, contents, encoding, cancellationToken);
        }
    }
}
#endif