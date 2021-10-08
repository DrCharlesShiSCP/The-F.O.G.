using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenetooffice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("tooffice", 5f);
    }
    void tooffice()
    {
        SceneManager.LoadScene("OFFICE");
    }
}
