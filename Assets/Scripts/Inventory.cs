using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

	public static int[] inventoryArray = {0, 0, 0};
	public Text inventoryText;
	
	void Update ()
	{
		inventoryText.text = "Keys " + "[" + inventoryArray [0] + "]" + "\n" + "Phone " + "[" + inventoryArray [1] + "]" + "\n" + "Wallet " + "[" + inventoryArray [2] + "]";
		
//		inventoryArray [0]++;      //Comment these 2 lines out when used in 
//		inventoryArray [1] += 2;   //conjunction with the pick-up script. :)
	}
}
