using Collections_Demo;
Collections collections = new Collections();
Console.WriteLine("1 - Run List Demo\n2 - Run Stack Demo\n3 - Queue Demo\n4 - Run Dictionary");
int select = Convert.ToInt32(Console.ReadLine());
switch (select)
{
    case 1:
        {
            collections.ListDemo();
            break;
        }
    case 2:
        {
            collections.StackDemo();
            break;
        }
    case 3:
        {
            collections.QueueDemo();
            break;
        }
    case 4:
        {
            collections.Dictionary();
            break;
        }
}