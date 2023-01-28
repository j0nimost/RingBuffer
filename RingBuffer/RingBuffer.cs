using System;
using System.Threading;

namespace RingBuffer
{
    public class RingBuffer<T>
    {
        private const int DefaultBufferSize = 1024;
        private volatile int WritePos = -1;
        private volatile int ReadPos = 0;
        public readonly int Capacity;

        private T[] Buffer;

        public RingBuffer(int bufferSize = 0)
        {
            Buffer = bufferSize > 0 ? new T[bufferSize] : new T[DefaultBufferSize];
            Capacity = Buffer.Length;
        }

        public bool Write(T item)
        {
            // check if buffer is full
            if(!IsFull())
            {
                int pos = WritePos + 1;
                Buffer[pos % Capacity] = item;
                WritePos++;
                return true;
            }

            return false;
        }

        public T Read()
        {
            // check if buffer is empty
            if(!IsEmpty())
            {
                T item = Buffer[ReadPos % Capacity];
                Buffer[ReadPos % Capacity] = default; // remove it from the buffer after reading
                ReadPos++;
                return item;
            }

            return default;
        }

        public bool IsEmpty()
        {
            return WritePos < ReadPos;
        }

        public bool IsFull()
        {
            return (WritePos - ReadPos) + 1 == Capacity;
        }
    }
}
