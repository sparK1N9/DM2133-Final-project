using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class sub : MonoBehaviour
{
    public string text;
    public AudioSource sfxSource;
    public AudioSource winSound;
    List<string> story = new List<string>();
    public int counter = 0;
    public static sub main;
    public bool phase2 = false;
    public bool phase3 = false;
    public RawImage illu;

    void Start()
    {
        main = this;
        illu.enabled = false;
        story.Add("???");
        story.Add("Where am I?");
        story.Add("......");//hello~
        story.Add("Looks like there are hidden speakers in the room and that is where the sound comes from.");
        story.Add("\"Who are you? And what is this place?\"");
        story.Add("");//obv i locked u here. and if can only get out if you solve all my puzzles!
        story.Add("\"But WHY?\"");
        story.Add("");//why not?
        story.Add("......");
        story.Add("\"Fine. I solve your puzzles and I can get out right?\"");
        story.Add("");//yes
        story.Add("\"OK. Oh, and one more thing, why can't I see my legs and body and hands? What did you do?\"");
        story.Add("");//How do I know? Ask the ones who made this game?
        story.Add("......");
        story.Add("\"Whatever, I am just going to solve your puzzles.\"");
        story.Add("");
        story.Add("Looks like this is the first puzzle.");// phase 2
        story.Add("I need to put these pieces back to form a picture.\nI can only slide these pieces to an adjacent empty slot and I cannot pick anything up.");
        story.Add("I only got one chance at this and if I mess up I will permanently be locked here.\nSo I should have the answer in my head before I even touch it.");
        story.Add("How do I know all that just by looking, you ask?");
        story.Add("Hey, listen. I am just reading what's on the script OK?\n So deal with it.");
        story.Add("");
        story.Add("???");
        story.Add("");// looks like the puzzle is solved
        story.Add("What happened?\nI didn't touch it yet, it just solved itself?");
        story.Add("");// correct, which means that YOU did not solve the puzzle and therefore you will be locked here forever.
        story.Add("Can I say something?");
        story.Add("");// wat
        story.Add("W T F ?\n╭∩╮（￣▽￣）╭∩╮");
        story.Add("");// XD
        story.Add("");
        sfxSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (counter != 30)
        {
            if ((Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)) && counter < 15) counter++;
            else if ((Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)) && phase2 && counter < 21) counter++;
            else if ((Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)) && phase3 && counter < 30) counter++;
        }
        else
        {
            sfxSource.Stop();
            if(!winSound.isPlaying) winSound.Play();
            illu.enabled = true;
            if (Input.GetKeyDown(KeyCode.D)) SceneManager.LoadScene(0);
        }
        text = story[counter];
        GetComponent<Text>().text = text;
    }
}
