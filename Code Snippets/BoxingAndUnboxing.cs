using System.Collections.Generic;

namespace Code_Snippets
{
    

    internal class BoxingAndUnboxing
    {
        private readonly var sum = 0;
        //int i = 123;
        //// The following line boxes i.
        //object o = i;

        //o = 123;
        //i = (int) o;  // unboxing


       





for (var j = 1; j< 5; j++)
{
    // The following statement causes a compiler error: Operator 
    // '*' cannot be applied to operands of type 'object' and
    // 'object'. 
    //sum += mixedList[j] * mixedList[j]);

    // After the list elements are unboxed, the computation does 
    // not cause a compiler error.
    sum += private (int) mixedList[j] * private (int) mixedList[j];
}


    }
internal class mixedList
{
    mixedList.Add("First Group:");

         private readonly List<object> mixedList = new List<object>();

        
       

// Add some integers to the list. 
for (int j = 1; j< 5; j++)
{
    // Rest the mouse pointer over j to verify that you are adding
    // an int to a list of objects. Each element j is boxed when 
    // you add j to mixedList.
    mixedList.Add(j);
}

// Add another string and more integers.
mixedList.Add("Second Group:");
for (int j = 5; j< 10; j++)
{
    mixedList.Add(j);
}
}
}
