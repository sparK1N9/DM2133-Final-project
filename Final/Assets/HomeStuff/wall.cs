using UnityEngine;
using System.Collections;

public class wall : MonoBehaviour {
    public bool boo = false;
    public static wall main;

    void Start()
    {
        main = this;
    }
	
	// Update is called once per frame
	void Update () {
	    if (boo) Destroy(gameObject);
    }
}
