using System;

namespace Linked_List {
    class Program {
        static void Main() {
            Console.WriteLine("=> Создаем связаный список.");
            var linkedList = new LinkedList<string>();
            Console.WriteLine("=> Заполняем связанный список:");
            linkedList.Add("Том");
            linkedList.Add("Alice");
            linkedList.Add("Bob");
            linkedList.Add("Sam");

            foreach (var node in linkedList) {
                Console.WriteLine(node);
            }

            Console.WriteLine("=> Удаляем элемент Alice из списка.");
            linkedList.Remove("Alice");

            foreach (var node in linkedList) {
                Console.WriteLine(node);
            }

            Console.WriteLine("=> Присутствует ли элемент Sam в списке?");
            bool isPresent = linkedList.Contains("Sam");
            Console.WriteLine(isPresent ? "Sam присутствует" : "Sam отсутствует");

            Console.WriteLine("=> Добавляем елемент Bill в начало списка:");
            linkedList.AppendFirst("Bill");

            foreach (var node in linkedList) {
                Console.WriteLine(node);
            }
        }
    }
}
