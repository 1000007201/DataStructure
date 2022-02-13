// See https://aka.ms/new-console-template for more information
using DataStructureQueue;

Stack stack = new Stack();

bool flag = true;
while (flag)
{
    Console.WriteLine("Enter Value:\n1.Add Element in Stack\n2.Display Stack Elements\n3.Preform Peek Operation\n4.Perform Pop operation\n" +
        "5.Perform IsEmpty Operation\n6.Exit");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            Console.WriteLine("Enter how many Elements you want to add:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Enter Element {i + 1}:");
                int element = Convert.ToInt32(Console.ReadLine());
                stack.Push(element);
            }
            break;
        case 2:
            stack.Display();
            break;
        case 3:
            stack.Peek();
            break;
        case 4:
            stack.Pop();
            break;
        case 5:
            stack.IsEmpty();
            break;
        case 6:
            flag = false;
            break;
    }
}

