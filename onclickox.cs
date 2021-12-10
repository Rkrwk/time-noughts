using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onclickox : MonoBehaviour

    
{
    public GameObject X;
    public GameObject O;
    public GameObject empty;
    public bool turns;
    public static bool turn;
    public bool canbeplaced;
    // Start is called before the first frame update

    private void Start()
    {
        canbeplaced = true;
        turn = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUp()

    {
        if ((turn) && (canbeplaced))
        {
            Instantiate(X, empty.transform);
            turn = false;
            canbeplaced = false;
        }
        else if (canbeplaced)
        {
            Instantiate(O, empty.transform);
            turn = true;
            canbeplaced = false;
        }
        else
        {
            return;
        }
       
    }
}
