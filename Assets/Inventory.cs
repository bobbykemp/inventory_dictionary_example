using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	// Use this for initialization
	void Start () {

        List<Item> items = new List<Item>();

        Item map = new Item("Map", "Permanent", 1);
        Item sword = new Item("Sword", "Collectible", 1);
        Item shield = new Item("Shield", "Collectible", 1);
        Item jawbone = new Item("Jawbone", "Magical", 1);

        items.Add(map);
        items.Add(sword);
        items.Add(shield);
        items.Add(jawbone);

        foreach(Item i in items) {
            print(i.name + " " + i.type + " " + i.quantity);
        }

        items.Sort();

        foreach (Item i in items) {
            print(i.name + " " + i.type + " " + i.quantity);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
