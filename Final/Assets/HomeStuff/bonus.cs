using UnityEngine;
using System.Collections;

public class bonus : MonoBehaviour {
    int i = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (i == 0)
        {
            subb.main.boo = subb2.main.boo = true;
            subb.main.counter = subb2.main.counter = 1;
            i++;
        }
    }
}
