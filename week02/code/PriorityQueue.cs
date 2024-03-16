public class PriorityQueue {
    //private List<PriorityItem> _queue = new();
    private Queue<PriorityItem> _queue = new();

    /// <summary>
    /// Add a new value to the queue with an associated priority.  The
    /// node is always added to the back of the queue irregardless of 
    /// the priority.
    /// </summary>
    /// <param name="value">The value</param>
    /// <param name="priority">The priority</param>
    public void Enqueue(string value, int priority) {
        var newNode = new PriorityItem(value, priority);
        //_queue.Add(newNode);
        _queue.Enqueue(newNode);
    }

    public String Dequeue() {
        if (_queue.Count == 0) // Verify the queue is not empty
        {
            Console.WriteLine("The queue is empty.");
            return null;
        }

        // Find the index of the item with the highest priority to remove
        var highPriorityIndex = 0;
        int index=0;
        int highestPriority=0;        
        //for (int index = 1; index < _queue.Count - 1; index++) {    
        foreach (PriorityItem item in _queue) {    
            if (item.Priority > highestPriority) 
            {
                highPriorityIndex=index;
                highestPriority=item.Priority;
            }
            index++;
        }

        Queue<PriorityItem> temp = new();
        var highPriorityValue="";
        index=0;
        foreach (PriorityItem item in _queue) {    
            if (index==highPriorityIndex)
            {
                highPriorityValue=item.Value;
            } 
            else
            {
                temp.Enqueue(item);
            }
            index++;
        }
        _queue=temp;
        // Remove and return the item with the highest priority
        var value = highPriorityValue;
        return value;
    }

    public int GetLength()
    {
        return _queue.Count;
    }

    public override string ToString() {
        return $"[{string.Join(", ", _queue)}]";
    }
}

internal class PriorityItem {
    internal string Value { get; set; }
    internal int Priority { get; set; }

    internal PriorityItem(string value, int priority) {
        Value = value;
        Priority = priority;
    }

    public override string ToString() {
        return $"{Value} (Pri:{Priority})";
    }
}