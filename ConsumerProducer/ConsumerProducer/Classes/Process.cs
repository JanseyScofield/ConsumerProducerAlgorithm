namespace ConsumerProducer.Classes
{
    public class Process
    {
        public int Id { get; set; }

        protected Process(int id) {
            Id = id;
        }

        public virtual void Execute(Mutex mutex, BufferProcess buffer) {
            Console.WriteLine($"Process {Id} is running in the buffer {buffer.Id}.");
        }
    }
}
