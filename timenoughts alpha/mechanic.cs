using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mechanic : MonoBehaviour
{
    public onclickox click;
    public GameObject winscreno;
    public GameObject winscrenx;
    public static string clickwon;

    // Start is called before the first frame update
    void Start()
    {
        winscreno.SetActive(false);
        winscrenx.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();

        }

        
        if (clickwon == "x")
        {
            winscrenx.SetActive(true);
        }

        if (clickwon == "o")
        {
            winscreno.SetActive(true);
        }


    }     
}
