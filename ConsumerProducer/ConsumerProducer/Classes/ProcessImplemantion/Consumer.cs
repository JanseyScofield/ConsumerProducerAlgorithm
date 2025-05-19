namespace ConsumerProducer.Classes.ProcessImplemantion
{
    public class Consumer : Process
    {
        public Consumer(int id) : base(id)
        {
        }

        public override void Execute(Mutex mutex, BufferProcess buffer)
        {
            mutex.WaitOne();
            base.Execute(mutex, buffer);

            if (buffer.CurrentIndex == 0)
            {
                Console.WriteLine("The buffer is empty!");
            }
            else
            {
                buffer.CurrentIndex -= 1;
                Console.WriteLine("The buffer has been consumed.");
            }

            mutex.ReleaseMutex();
        }
    }
}
