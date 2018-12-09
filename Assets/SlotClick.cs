using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotClick : MonoBehaviour {

    public int Pnumber;
    public GameObject Getfromanswer;
    

    public void Onclick()
    {
        ButtonCorrect.Instance.Check(Pnumber);
        Debug.Log(Pnumber);


    }


    
}
