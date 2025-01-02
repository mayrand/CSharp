namespace WhatsNew12;

ref struct CollectionExpressions
{
    // Rather than initializing an array as follows:
    char[] vowels1 = new[] {'a','e','i','o','u'};
    // you can now use square brackets (a collection expression):
    char[] vowels = ['a','e','i','o','u'];
    // Collection expressions have two major advantages. First, the same syntax also works
    //     with other collection types, such as lists and sets (and even the low-level span types):
    List<char> list = ['a','e','i','o','u'];
    HashSet<char> set = ['a','e','i','o','u'];
    ReadOnlySpan<char> span = ['a','e','i','o','u'];

    public CollectionExpressions()
    {
    }

    // Second, they are target-typed, which means that you can omit the type in other
    //     scenarios where the compiler can infer it, such as when calling methods:
    void Foo (char[] letters) { Foo(['a','e','i','o','u']); }
}