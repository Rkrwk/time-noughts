using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class onclickox : MonoBehaviour

    
{
    public GameObject X;
    public GameObject O;
    public GameObject empty;
    public static int turns;
    public static bool turn;
    public bool canbeplaced;
    public string tilenumber;
    public static List<string> tilelisto = new List<string>();
    public static List<string> tilelistx = new List<string>();
    public static string checkwin;


    // Start is called before the first frame update

    private void Start()
    {
        canbeplaced = true;
        turns = 1;

    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void OnMouseUp()

    {
        if ((turns%2 != 0) && (canbeplaced))
        {
            Instantiate(X, empty.transform);
            turns = turns + 1 ;
            canbeplaced = false;
            tilelistx.Add(tilenumber);
            endphase();
        }
        else if (canbeplaced)
        {
            Instantiate(O, empty.transform);
            turns = turns + 1;
            canbeplaced = false;
            tilelisto.Add(tilenumber);
            endphase();
        }







    }

    public void endphase()

    {

        if (tilelisto.Contains("a1") && (tilelisto.Contains("a2")) && (tilelisto.Contains("a3"))) { checkwin = "o"; }
        else if (tilelisto.Contains("b1") && (tilelisto.Contains("b2")) && (tilelisto.Contains("b3"))) {checkwin = "o"; }
        else if (tilelisto.Contains("c1") && (tilelisto.Contains("c2")) && (tilelisto.Contains("c3"))) {checkwin = "o"; }
        else if (tilelisto.Contains("a1") && (tilelisto.Contains("b1")) && (tilelisto.Contains("c1"))) {checkwin = "o"; }
        else if (tilelisto.Contains("a2") && (tilelisto.Contains("b2")) && (tilelisto.Contains("c2"))) {checkwin = "o"; }
        else if (tilelisto.Contains("a3") && (tilelisto.Contains("b3")) && (tilelisto.Contains("c3"))) {checkwin = "o"; }
        else if (tilelisto.Contains("a1") && (tilelisto.Contains("b2")) && (tilelisto.Contains("c3"))) {checkwin = "o"; }
        else if (tilelisto.Contains("a3") && (tilelisto.Contains("b2")) && (tilelisto.Contains("c1"))) {checkwin = "o"; }
        else if (tilelistx.Contains("a1") && (tilelistx.Contains("a2")) && (tilelistx.Contains("a3"))) {checkwin = "x"; }
        else if (tilelistx.Contains("b1") && (tilelistx.Contains("b2")) && (tilelistx.Contains("b3"))) {checkwin = "x"; }
        else if (tilelistx.Contains("c1") && (tilelistx.Contains("c2")) && (tilelistx.Contains("c3"))) {checkwin =  "x"; }
        else if (tilelistx.Contains("a1") && (tilelistx.Contains("b1")) && (tilelistx.Contains("c1"))) {checkwin =  "x"; }
        else if (tilelistx.Contains("a2") && (tilelistx.Contains("b2")) && (tilelistx.Contains("c2"))) {checkwin =  "x"; }
        else if (tilelistx.Contains("a3") && (tilelistx.Contains("b3")) && (tilelistx.Contains("c3"))) {checkwin =  "x"; }
        else if (tilelistx.Contains("a1") && (tilelistx.Contains("b2")) && (tilelistx.Contains("c3"))) {checkwin =  "x"; }
        else if (tilelistx.Contains("a3") && (tilelistx.Contains("b2")) && (tilelistx.Contains("c1"))) {checkwin =  "x"; }
        else if (turns > 9) Debug.Log(message: "TIE");
        mechanic.clickwon = checkwin;



        Debug.Log(message: "i will end my turn");
        Debug.Log(message: turns);
    }
}
