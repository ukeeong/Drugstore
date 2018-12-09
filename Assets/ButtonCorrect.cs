using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCorrect : MonoBehaviour {


    public static ButtonCorrect Instance;
    

    void Start () {

        Instance = this;

	}
	

    public void Check(int pnumb)
    {
       // answerP = AS.GetComponent<AnswerScreen>().Pnumber;
    }

	
	void Update () {
		
	}
}
