using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    
    void OnTriggerEnter(Collider other)
    {
        if (sub.main.counter == 15)
        {
            sub.main.phase2 = true;
            sub3.main.boo = true;
        }
    }
}
