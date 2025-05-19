namespace ConsumerProducer.Classes
{
    public class BufferProcess
    {
        public int Id{ get; set; }
        public int[] Items { get; set; }
        public int Size { get; set; }
        public int CurrentIndex { get; set; }

        public BufferProcess(int id, int size)
        {
            Id = id;
            Items = new int[size];
            Size = size;
            CurrentIndex = 0;
        }
    }
}
