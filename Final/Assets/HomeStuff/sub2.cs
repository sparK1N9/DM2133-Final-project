using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class sub2 : MonoBehaviour {
    public string text;
    List<string> story = new List<string>();
    int counter = 0;
    public bool phase3 = false;
    public static sub2 main;

    void Start()
    {
        main = this;
        story.Add("");
        story.Add("");
        story.Add("\"Hello~\"");
        story.Add("");
        story.Add("");
        story.Add("\"Obviously I locked you here. And you can get out only if solve all my puzzles!\"");
        story.Add("");
        story.Add("\"Why not?\"");
        story.Add("");
        story.Add("");
        story.Add("\"Yes.\"");
        story.Add("");
        story.Add("\"How do I know? Ask the ones who made this game?\"");
        story.Add("");
        story.Add("");
        story.Add("Looks like the puzzle is solved.");
        story.Add("");
        story.Add("Exactly, it is my master plan to make sure that YOU will not solve the puzzle\n(since it will solve itself before you attempt to do so).\nTherefore you will be locked here forever.");
        story.Add("");
        story.Add("Wat?");
        story.Add("");
        story.Add("XD");
        story.Add("");
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)) && counter < 13) counter++;
        else if ((Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)) && phase3) counter++;
        text = story[counter];
        GetComponent<Text>().text = text;
    }
}
