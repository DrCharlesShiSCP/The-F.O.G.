using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject horrorlight;
    public GameObject[] horrorlight1;
    public flick[] horrorlight1flick;
    // Start is called before the first frame update
    void Start()
    {
        if (horrorlight1 == null)
        {
            horrorlight1 = GameObject.FindGameObjectsWithTag("ceilingfl");
           
        }
        for (int i = 0; i < horrorlight1.Length; i++)
        {
             horrorlight1flick = horrorlight1[i].GetComponent<flick[]>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Invoke("BLACK", 15f);
            Debug.Log("wdnmd");
            horrorlight.GetComponent<Lightd>().turns();
            horrorlight.GetComponent<flick>().enabled = !horrorlight.GetComponent<flick>().enabled;     
            Invoke("killlight",10f);

           for (int x = 0; x < horrorlight1.Length; x++)
            {
                horrorlight1[x].GetComponent<Lightd>().turns();
                horrorlight1flick[x].enabled = !horrorlight1flick[x].enabled;
            }
           
        }
    }
    void killlight()
    {
        Destroy(horrorlight);
        horrorlight1 = GameObject.FindGameObjectsWithTag("ceilingfl");
        for (int i=0; i<horrorlight1.Length; i++)
        {
            Destroy(horrorlight1[i]);
        }
}
    void BLACK()
    {
        SceneManager.LoadScene("BLACK");
    }
}
