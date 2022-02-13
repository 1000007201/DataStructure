// See https://aka.ms/new-console-template for more information
using DataStructureLinkedList;

bool flag = true;
LinkedList list = new LinkedList();
while (flag)
{
    Console.WriteLine("Enter Value:\n1.Add Element.\n2.Display Your List." +
        "\n3.Add in Reverse order.\n\n4.Get size of list.\n5.Search Elemnt." +
        "\n6.Delete Element.\n7.Remove first node\n8.Remove Last node.\n9.Exit");
    int option = Convert.ToInt32(Console.ReadLine());
    switch(option)
    {
        case 1:
            Console.WriteLine("Enter Number of elements to be added:");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < number; i++)
            {
                Console.WriteLine($"Enter Element {i + 1}:");
                int element = Convert.ToInt32(Console.ReadLine());
                list.Add(element);
            }
            break;
        case 2:
            list.Display();
            break;
        case 3:
            Console.WriteLine("Enter Number of elements to be added:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number1; i++)
            {
                Console.WriteLine($"Enter Element {i + 1}:");
                int revelement = Convert.ToInt32(Console.ReadLine());
                list.AddInReverse(revelement);
            }
            break;
        case 4:
            list.Size();
            break;
        case 5:
            Console.WriteLine("Enter Element You want to search:");
            int element1 = Convert.ToInt32(Console.ReadLine());
            int searchoption = list.Search(element1);
            if (searchoption == -1)
            {
                Console.WriteLine("Element is not Present");
            }
            else
            {
                Console.WriteLine($"Element is present at {searchoption}");
            }
            break;
        case 6:
            Console.WriteLine("Enter Element to be deleted:");
            int element2 = Convert.ToInt32(Console.ReadLine());
            int position = list.Search(element2);
            list.DeleteNodeParticularPosition(position);
            break;
        case 7:
            list.RemoveFirstNode();
            break;
        case 8:
            list.RemoveLastNode();
            break;
        case 9:
            flag = false;
            break;
    }
}
