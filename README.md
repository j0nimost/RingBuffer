# RingBuffer
A sample implementation of a RingBuffer with a PubSub


### What is a RingBuffer?
Also known as a Cyclic Buffer, Is a data structure well known for its constant space complexity (Once initialized in a specific size it remains the same no matter how large the data set is)
and also implements the FIFO (First In First Out) queue method. 

#### Note
You can increase the Ring Buffer size when needed however its an expensive operation that involves recreating the entire buffer.

### Where is it used?
Its commonly applied is scenarios where there's high data throughput, example: Forex & Stock trading systems, Logging and Data streaming services.

### Notes
There are two approaches to using a Ring Buffer,
 - Preserve Writes: A ring buffer can be implemented in such a way that once the buffer is full it stops writing to it and waits for space to be available.
                    This is Ideal for scenarios where all the data is required.
 - Overwrite Writes: Is a common implementation of ring buffer where once the buffer is full the writer can overwrite the memory allocation containing unread data.
                     In this case, the data is quickly discarded, its ideal for scenarios where old data is not really prioritized.

### Author
John Nyingi