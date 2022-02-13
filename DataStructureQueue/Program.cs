// See https://aka.ms/new-console-template for more information
using DataStructureQueue;

Queue queue = new Queue();
bool flag = true;
while (flag)
{
    Console.WriteLine("Enter Value:\n1.Add Element in Queue\n2.Display Queue Elements\n3.Perform Dequeue operation\n" +
        "4.Size of Queue\n5.Exit");
    int option = Convert.ToInt32(Console.ReadLine());
    switch(option)
    {
        case 1:
            Console.WriteLine("Enter how many Elements you want to add:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Enter Element {i+1}:");
                int element = Convert.ToInt32(Console.ReadLine());
                queue.Enqueue(element);
            }            
            break;
        case 2:
            queue.Display();
            break;
        case 3:
            queue.Dequeue();
            break;
        case 4:
            queue.Size();
            break;
        case 5:
            flag = false;
            break;
    }
}
