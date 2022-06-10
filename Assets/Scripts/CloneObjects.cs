using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneObjects : MonoBehaviour
{
    public GameObject confeti;

    public void CloneObject()
    {
        GameObject clon;
        for (int i = 0; i < 15; i++)
        {
            clon = Instantiate(confeti);
            clon.transform.Rotate(0, 45 * i, 0);
            clon.transform.Translate(i * .3f, i, 0);

            //Destroy(clon,.5f);
        }

    }
}
