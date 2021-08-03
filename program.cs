using System;
using System.Collections;
 
class studies
{
public static void Main()
  {

  SortedList List = new SortedList();
  //Adding the keys and values pairs to the created sorted list
  List.Add("10th", "school");
  List.Add("12th", "inter");
  List.Add("16th", "bachelors");
  List.Add("18th", "masters");
  List.Add("21st", "phd");

  //Displaying the elements of the sorted list by using keys
  for (int r = 0; r <List.Count; r++)
    {
    Console.WriteLine("{0} and {1}",
    List.GetKey(r),
    List.GetByIndex(r));
    }
  }
}
