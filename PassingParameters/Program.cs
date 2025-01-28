var p = new Person() {Name = "Angela"};
int[] t = [1];
Console.WriteLine(t[0] + p.Name);
ChangeValue(t, p);
Console.WriteLine(t[0] + p.Name);
ChangeValueByRef(ref t, ref p);
Console.WriteLine(t[0] + p.Name);
/*
1Angela
0ByValue
2ByRef 
 */
void ChangeValue(int[] arr, Person p)
{
    arr[0] = 0;
    arr = [3];
    p.Name = "ByValue";
    p = new Person() {Name = "ByRef"};
}

void ChangeValueByRef(ref int[] arr, ref Person p)
{
    arr[0] = 0;
    arr = [2];
    p.Name = "ByValue";
    p = new Person() {Name = "ByRef"};
}

public class Person
{
    public required string Name;
}