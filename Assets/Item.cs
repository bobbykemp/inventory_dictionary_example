using System.Collections;
using System;
using UnityEngine;

public class Item : IComparable<Item> {

    public string name;
    public string type;
    public int quantity;

    public Item(string _name, string _type, int _quantity) {
        name = _name;
        type = _type;
        quantity = _quantity;
    }

    public int CompareTo(Item other) {
        /*this method will tell how to sort the objects
        
        return < 0 - this instance comes before "other" in the sort
        return 0 - this instance occurs in the same position in the sort as other
        return > 0 - this instance occurs after "other" in the sort

        See https://docs.microsoft.com/en-us/dotnet/api/system.icomparable.compareto?view=netframework-4.7.2
        for more details

        */

        //if the thing we're comparing to is null, then put this item after other in the sort
        if (other == null) {
            return 1;
        }

        //sort by name string
        return String.Compare(name, other.name);
    }
}
