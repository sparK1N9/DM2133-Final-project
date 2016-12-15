using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class sub3 : MonoBehaviour
{
    public string text;
    int counter;
    public static sub3 main;
    public bool boo = false;

    private void Start()
    {
        main = this;
    }

    void Update()
    {
        text = "Press \"Enter\" to continue";
        if ((Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)) && counter < 15) counter++;
        else if ((Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)) && counter < 21 && boo) counter++;
        if (counter == 21 && Input.GetKeyDown(KeyCode.X)) {
            counter++;
            doge.main.boo = true;
            sub.main.phase3 = true;
            sub2.main.phase3 = true;
        }
        if (counter == 21) text = "Press \"X\" ONLY if you are certain that you have the solution ready";
        else if (counter >= 15 && !boo) text = "";
        GetComponent<Text>().text = text;
    }
}
