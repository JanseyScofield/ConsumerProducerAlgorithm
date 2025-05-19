namespace ConsumerProducer.Classes.ProcessImplemantion
{
    public class Producer : Process
    {
        public int ValueAdd { get; set; } = 0;
        public Producer(int id) : base(id)
        {
        }

        public override void Execute(Mutex mutex, BufferProcess buffer)
        {
            mutex.WaitOne();
            base.Execute(mutex, buffer);

            if (buffer.Size - 1 == buffer.CurrentIndex) {
                Console.WriteLine("The buffer is full!");
            }
            else
            {
                buffer.Items[buffer.CurrentIndex] = ValueAdd;
                ValueAdd++;
                buffer.CurrentIndex++;
                Console.WriteLine($"Was produced new item with value {ValueAdd} for buffer.");
            }

            mutex.ReleaseMutex();
        }
    }
}
