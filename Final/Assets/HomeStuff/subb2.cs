using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class subb2 : MonoBehaviour
{
    string text;
    List<string> story = new List<string>();
    public int counter = 0;
    public bool boo = false;
    public static subb2 main;
    // Use this for initialization
    void Start()
    {
        main = this;
        story.Add("");
        story.Add("");
        story.Add("");
        story.Add("\"There must be somthing wrong with people who seek reality in fiction.\"");
        story.Add("");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B) && counter < 4 && boo) counter++;
        text = story[counter];
        GetComponent<Text>().text = text;
    }
}
