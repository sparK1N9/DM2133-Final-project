using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class subb : MonoBehaviour {
    string text;
    List<string> story = new List<string>();
    public int counter = 0;
    public bool boo = false;
    public static subb main;
    // Use this for initialization
    void Start () {
        main = this;
        story.Add("");
        story.Add("What is this? Did I just go through this wall?\nPress \"B\" to continue");
        story.Add("It must've been a bug since it is not realistic to walk through walls like that\nPress \"B\" to continue");
        story.Add("\nPress \"B\" to continue");
        story.Add("");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.B) && counter < 4 && boo) counter++;
        text = story[counter];
        GetComponent<Text>().text = text;
    }
}
