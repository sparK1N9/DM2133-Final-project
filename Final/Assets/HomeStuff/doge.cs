using UnityEngine;
using System.Collections;

public class doge : MonoBehaviour {
    Animator anim;
    public bool boo = false;
    public static doge main;

    private void Start()
    {
        main = this;
    }

    void Update ()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("go", boo);
        if (sub.main.counter == 15)
        {
            wall.main.boo = true;
        }
    }
}
