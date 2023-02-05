using Wintellect.PowerCollections;

Wintellect.PowerCollections.Stack<int> stack = new Wintellect.PowerCollections.Stack<int>();

stack.Push(1);
stack.Push(2);
stack.Push(3);  
stack.Push(4);
stack.Push(5);

Console.Write($"Элементы в стеке(размер:{stack.Capacity}):");
var count = stack.Count();
for (int i = 0; i < count; i++)
{
    Console.Write($" {stack.Pop()}");
}

