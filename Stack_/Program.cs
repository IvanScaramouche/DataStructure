using System;

namespace Stack_ {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("=> Создаем стек.");
            var stack = new NodeStack<string>();

            Console.WriteLine("=> Заполняем стек.");
            stack.Push("Tom");
            stack.Push("Alice");
            stack.Push("Bob");
            stack.Push("Kate");

            foreach (var node in stack) {
                Console.WriteLine(node);
            }

            Console.WriteLine();

            var header = stack.Peek();
            Console.WriteLine($"=> Верхушка стека: {header}.");
            Console.WriteLine();

            Console.WriteLine("=> Убираем верхушку стека.");
            header = stack.Pop();
            foreach (var node in stack) {
                Console.WriteLine(node);
            }

        }
    }
}
