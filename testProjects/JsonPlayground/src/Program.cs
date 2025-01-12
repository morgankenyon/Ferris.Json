using Ferris.Json;
using JsonConvert = Newtonsoft.Json.JsonConvert;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Markup;

namespace JsonPlayground;

class Program
{
    static void Main(string[] args)
    {
        var dict = new DictObj
        {
            Values = new Dictionary<string, object>
            {
                { "one", 1 },
                { "two", 2 },
                { "three", 3 }
            }
        };

        var list = new ListObj
        {
            Values = new List<string>
            {
                "one",
                "two",
                "three"
            }
        };

        var hashSet = new HashSetObj
        {
            Values = new HashSet<string>
            {
                "one",
                "two",
                "three"
            }
        };

        var queue = new QueueObj
        {
            Values = new Queue<string>()
        };
        queue.Values.Enqueue("one");
        queue.Values.Enqueue("two");
        queue.Values.Enqueue("three");

        var stack = new StackObj
        {
            Values = new Stack<string>()
        };
        stack.Values.Push("one");
        stack.Values.Push("two");
        stack.Values.Push("three");

        var linkedList = new LinkedListObj
        {
            Values = new LinkedList<string>()
        };
        linkedList.Values.AddLast("one");
        linkedList.Values.AddLast("two");
        linkedList.Values.AddLast("three");

        var sortedDict = new SortedDictObj
        {
            Values = new SortedDictionary<string, object>
            {
                { "one", 1 },
                { "two", 2 },
                { "three", 3 }
            }
        };

        var sortedList = new SortedListObj
        {
            Values = new SortedList<string, object>
            {
                { "one", 1 },
                { "two", 2 },
                { "three", 3 }
            }
        };

        var sortedSet = new SortedSetObj
        {
            Values = new SortedSet<string>
            {
                "one",
                "two",
                "three"
            }
        };

        //dictionary
        var nDictJson = JsonConvert.SerializeObject(dict);
        var mDictJson = JsonSerializer.Serialize(dict);
        var fDictJson = JsonTransformer.Serialize(dict);
        var nDict = JsonConvert.DeserializeObject<DictObj>(nDictJson);
        var mDict = JsonSerializer.Deserialize<DictObj>(nDictJson);
        var fDict = JsonTransformer.Deserialize<DictObj>(nDictJson);

        //list
        var nListJson = JsonConvert.SerializeObject(list);
        var mListJson = JsonSerializer.Serialize(list);
        var fListJson = JsonTransformer.Serialize(list);
        var nList = JsonConvert.DeserializeObject<ListObj>(nListJson);
        var mList = JsonSerializer.Deserialize<ListObj>(mListJson);
        var fList = JsonTransformer.Deserialize<ListObj>(fListJson);

        //hashset
        var nHashSetJson = JsonConvert.SerializeObject(hashSet);
        var mHashSetJson = JsonSerializer.Serialize(hashSet);
        var fHashSetJson = JsonTransformer.Serialize(hashSet);
        var nHashSet = JsonConvert.DeserializeObject<HashSetObj>(nHashSetJson);
        var mHashSet = JsonSerializer.Deserialize<HashSetObj>(mHashSetJson);
        var fHashSet = JsonTransformer.Deserialize<HashSetObj>(fHashSetJson);

        //queue
        var nQueueJson = JsonConvert.SerializeObject(queue);
        var mQueueJson = JsonSerializer.Serialize(queue);
        var fQueueJson = JsonTransformer.Serialize(queue);
        var nQueue = JsonConvert.DeserializeObject<QueueObj>(nQueueJson);
        var mQueue = JsonSerializer.Deserialize<QueueObj>(mQueueJson);
        var fQueue = JsonTransformer.Deserialize<QueueObj>(fQueueJson);

        //stack
        var nStackJson = JsonConvert.SerializeObject(stack);
        var mStackJson = JsonSerializer.Serialize(stack);
        var fStackJson = JsonTransformer.Serialize(stack);
        var nStack = JsonConvert.DeserializeObject<StackObj>(nStackJson);
        var mStack = JsonSerializer.Deserialize<StackObj>(mStackJson);
        var fStack = JsonTransformer.Deserialize<StackObj>(fStackJson);

        //linkedlist
        var nLinkedListJson = JsonConvert.SerializeObject(linkedList);
        var mLinkedListJson = JsonSerializer.Serialize(linkedList);
        var fLinkedListJson = JsonTransformer.Serialize(linkedList);
        var nLinkedList = JsonConvert.DeserializeObject<LinkedListObj>(nLinkedListJson);
        var mLinkedList = JsonSerializer.Deserialize<LinkedListObj>(mLinkedListJson);
        var fLinkedList = JsonTransformer.Deserialize<LinkedListObj>(fLinkedListJson);

        //sortedDict
        var nSortedDictJson = JsonConvert.SerializeObject(sortedDict);
        var mSortedDictJson = JsonSerializer.Serialize(sortedDict);
        var fSortedDictJson = JsonTransformer.Serialize(sortedDict);
        var nSortedDict = JsonConvert.DeserializeObject<SortedDictObj>(nSortedDictJson);
        var mSortedDict = JsonSerializer.Deserialize<SortedDictObj>(mSortedDictJson);
        var fSortedDict = JsonTransformer.Deserialize<SortedDictObj>(fSortedDictJson);

        //sortedList
        var nSortedListJson = JsonConvert.SerializeObject(sortedList);
        var mSortedListJson = JsonSerializer.Serialize(sortedList);
        var fSortedListJson = JsonTransformer.Serialize(sortedList);
        var nSortedList = JsonConvert.DeserializeObject<SortedListObj>(nSortedListJson);
        var mSortedList = JsonSerializer.Deserialize<SortedListObj>(mSortedListJson);
        var fSortedList = JsonTransformer.Deserialize<SortedListObj>(fSortedListJson);

        //sortedSet
        var nSortedSetJson = JsonConvert.SerializeObject(sortedSet);
        var mSortedSetJson = JsonSerializer.Serialize(sortedSet);
        var fSortedSetJson = JsonTransformer.Serialize(sortedSet);
        var nSortedSet = JsonConvert.DeserializeObject<SortedSetObj>(nSortedSetJson);
        var mSortedSet = JsonSerializer.Deserialize<SortedSetObj>(mSortedSetJson);
        var fSortedSet = JsonTransformer.Deserialize<SortedSetObj>(fSortedSetJson);
        Console.WriteLine("Hello, World!");
        Console.ReadLine();
    }

    public class DictObj { public Dictionary<string, object> Values { get; set; } }
    public class ListObj { public List<string> Values { get; set; } }
    public class HashSetObj { public HashSet<string> Values { get; set; } }
    public class QueueObj { public Queue<string> Values { get; set; } }
    public class StackObj { public Stack<string> Values { get; set; } }
    public class LinkedListObj { public LinkedList<string> Values { get; set; } }
    public class SortedDictObj { public SortedDictionary<string, object> Values { get; set; } }
    public class SortedListObj { public SortedList<string, object> Values { get; set; } }
    public class SortedSetObj { public SortedSet<string> Values { get; set; } }
}
