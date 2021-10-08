using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightd : MonoBehaviour
{
    Light it;
    // Start is called before the first frame update
    void Start()
    {
        it = GetComponent<Light>();
    }

    // Update is called once per frame
    public void turns()
    {
        Invoke("turnred", 0f);
        //Invoke("darks", 7f);
        Debug.Log("test");
    }
    public void turnred()
    {
        it.color = (new Color(255,0,0) / 5.0f)* Time.deltaTime;
    }
    /*public void darks()
    {
        it.color -= Color.white;
    }*/
}
