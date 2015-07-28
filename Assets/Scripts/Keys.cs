﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Keys : MonoBehaviour
{

	public string myString;
	public Text myText;
	public float fadeTime;
	public bool displayInfo;
	
	// Use this for initialization
	void Start ()
	{
		
		myText = GameObject.Find ("Text").GetComponent<Text> ();
		myText.color = Color.clear;
		//Screen.showCursor = false;
		//Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		FadeText ();
		
	}
	
	void OnMouseOver ()
	{
		displayInfo = true;
		
	}

	void OnMouseExit ()
	{
		displayInfo = false;
		
	}
	
	void FadeText ()
	{
		if (displayInfo) {
			
			myText.text = myString;
			myText.color = Color.Lerp (myText.color, Color.black, fadeTime * Time.deltaTime);
		} else {
			
			myText.color = Color.Lerp (myText.color, Color.clear, fadeTime * Time.deltaTime);
		}	
	}
	
	
	void OnTriggerEnter (Collider other)
	{
	
		if (other.gameObject.tag == "Player") {
			Inventory.inventoryArray [0]++;
			Destroy (gameObject);
		}
	}
}
