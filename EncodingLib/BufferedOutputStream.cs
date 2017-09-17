using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace EncodingLib
{
    /// <summary>
    /// An output stream which buffers data.
    /// Read, ReadByte and their async versions are supported.
    /// This does not close the underlying stream.
    /// </summary>
    public sealed class BufferedOutputStream : Stream
    {
        private const int DefaultBufferSize = 4096;
        private const int MinBufferSize = 16;

        private readonly Stream _stream;
        private readonly byte[] _buffer;
        private int _bufStartIndex;
        private int _bufEndIndex;

        private bool BufferEmpty => _bufStartIndex == _bufEndIndex;

        public BufferedOutputStream(Stream stream)
            : this(stream, DefaultBufferSize)
        {
        }

        public BufferedOutputStream(Stream stream, int bufferSize)
        {
            if (!stream.CanRead)
                throw new ArgumentException("stream is not readable", nameof(stream));
            if (bufferSize < MinBufferSize)
                bufferSize = MinBufferSize;
            _buffer = new byte[bufferSize];
            _stream = stream;
        }

        private void ResetBuffer() => (_bufStartIndex, _bufEndIndex) = (0, 0);

        private void ReadIntoBuffer()
        {
            ResetBuffer();
            _bufEndIndex += _stream.Read(_buffer, 0, _buffer.Length);
        }

        private async Task ReadIntoBufferAsync(CancellationToken token)
        {
            ResetBuffer();
            _bufEndIndex += await _stream.ReadAsync(_buffer, 0, _buffer.Length, token);
        }
        
        public override int Read(byte[] buffer, int offset, int count)
        {
            if (offset + count > buffer.Length)
                throw new ArgumentException("offset + count > buffer.Length");
            if (offset >= buffer.Length)
                throw new ArgumentException("offset out of bounds");

            int n;
            if (BufferEmpty)
            {
                if (count >= _buffer.Length)
                    return _stream.Read(buffer, 0, buffer.Length);
                else
                    ReadIntoBuffer();
            }

            if (_bufEndIndex == 0) return 0; // eof
            
            n = System.Math.Min(_bufEndIndex - _bufStartIndex, count);
            Array.Copy(_buffer, _bufStartIndex, buffer, offset, n);
            _bufStartIndex += n;
            return n;
        }

        public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken token)
        {
            if (offset + count > buffer.Length)
                throw new ArgumentException("offset + count > buffer.Length");
            if (offset >= buffer.Length)
                throw new ArgumentException("offset out of bounds");

            int n;
            if (BufferEmpty)
            {
                if (count >= _buffer.Length)
                    return await _stream.ReadAsync(buffer, 0, buffer.Length, token);
                else
                    await ReadIntoBufferAsync(token);
            }

            if (_bufEndIndex == 0) return 0; // eof
            
            n = System.Math.Min(_bufEndIndex - _bufStartIndex, count);
            Array.Copy(_buffer, _bufStartIndex, buffer, offset, n);
            _bufStartIndex += n;
            return n;
        }

        public override int ReadByte()
        {
            if (BufferEmpty)
            {
                ReadIntoBuffer();
                if (_bufEndIndex == 0) // eof
                    return -1;
            }
            return _buffer[_bufStartIndex++];
        }

        public ValueTask<int> ReadByteAsync()
        {
            return ReadByteAsync(CancellationToken.None);
        }
        
        public async ValueTask<int> ReadByteAsync(CancellationToken token)
        {
            if (BufferEmpty)
            {
                await ReadIntoBufferAsync(token);
                if (_bufEndIndex == 0) // eof
                    return -1;
            }
            return _buffer[_bufStartIndex++];
        }

        public override void Flush() => throw new NotSupportedException();
        public override long Seek(long offset, SeekOrigin origin) => throw new NotSupportedException();
        public override void SetLength(long value) => throw new NotSupportedException();
        public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException();
        public override bool CanRead => true;
        public override bool CanSeek => false;
        public override bool CanWrite => false;
        public override long Length => throw new NotSupportedException();

        public override long Position
        {
            get => throw new NotSupportedException();
            set => throw new NotSupportedException();
        }
    }
}
