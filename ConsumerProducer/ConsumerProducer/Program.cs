using ConsumerProducer.Classes;
using ConsumerProducer.Classes.ProcessImplemantion;

namespace ConsumerProducer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mutex mutex = new Mutex();
            BufferProcess buffer = new BufferProcess(1, 10);
            Producer producer = new Producer(1);
            Consumer consumer = new Consumer(2);

            Thread t1 = 
                new Thread(
                    () => {
                        for (int i = 0; i < 20; i++) {
                            consumer.Execute(mutex, buffer);
                        }
                    });

            Thread t2 =
                new Thread(
                    () => {
                        for (int i = 0; i < 20; i++)
                        {
                            producer.Execute(mutex, buffer);
                        }
                    });

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
        }
    }
}
