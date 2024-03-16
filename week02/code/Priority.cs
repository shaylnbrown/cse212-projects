public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Projects to work on at work
        // Expected Result: RCA Requirements, Meetings, Instruction Modification, Scheduling, Housekeeping, Drink Soda
        Console.WriteLine("Test 1"); 
        priorityQueue.Enqueue("RCA Requirements",9); 
        priorityQueue.Enqueue("Instruction Modification",7);  
        priorityQueue.Enqueue("Scheduling",5);                
        priorityQueue.Enqueue("Housekeeping",3);
        priorityQueue.Enqueue("Meetings",8);
        priorityQueue.Enqueue("Drink Soda",1);
        while (priorityQueue.GetLength() > 0)
        {
            Console.WriteLine(priorityQueue.Dequeue());
        }       
        
        // Defect(s) Found: 
        //The data in the PriorityQueue class was a list and not a queue. Once that was converted, extensive changes needed to be made.
        //For the Dequeue method, a loop had to run to find out which item had the high priority. then another loop runs and copies all but that item to a new queue, which replaces the original.
        //The loop was already going in order, so the first of two matching high priorities would be selected if multiple were found.
        Console.WriteLine("---------");

        // Test 2
        // Scenario: What I would grab in a fire
        // Expected Result: Family, Family History, Family Heirlooms, Laptop, Sourdough Starter, Kitchenaid Mixer

        priorityQueue = new PriorityQueue();
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("Family History",9); 
        priorityQueue.Enqueue("Sourdough Starter",7);  
        priorityQueue.Enqueue("Kitchenaid Mixer",5);                
        priorityQueue.Enqueue("Family Heirlooms",9);
        priorityQueue.Enqueue("Laptop",8);
        priorityQueue.Enqueue("Family",10);
        while (priorityQueue.GetLength() > 0)
        {
            Console.WriteLine(priorityQueue.Dequeue());
        }
        // Defect(s) Found: 
        //None

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}