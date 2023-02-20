using Linked_List;

SoftUniLinkedList linkedList = new SoftUniLinkedList();

linkedList.AddFirst(1);
linkedList.AddFirst(2);
linkedList.AddFirst(3);
linkedList.AddFirst(4);
linkedList.AddFirst(5);
Node node = linkedList.Head;

while(node != null)
{
    Console.WriteLine(node.Value);
    node = node.Next;
}

//linkedList.ForEach(x => 
//{
//    Console.WriteLine($"Node {x}");
//});

