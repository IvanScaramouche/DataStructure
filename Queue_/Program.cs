using System;

namespace Queue_ {
    class Program {
        static void Main() {
            Console.WriteLine("=> Создаем очередь.");
            Queue<string> queue = new Queue<string>();

            Console.WriteLine("=> Заполняем очередь.");
            queue.Enqueue("Kate");
            queue.Enqueue("Sam");
            queue.Enqueue("Alice");
            queue.Enqueue("Tom");

            foreach (var item in queue) {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("=> Получаем первый элемент из очереди: ");
            string first = queue.Dequeue();
            Console.WriteLine($"Первый элемент: {first}");
            foreach (var item in queue) {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            string firstNew = queue.First;
            Console.WriteLine($"=> Первый элемент: {firstNew}");
            string last = queue.Last;
            Console.WriteLine($"=> Последний элемент: {last}");
        }
    }
}
