using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScreen : MonoBehaviour {


    public int HowmanyQ;//문제의 수
    public int answerlistnum = 0; //
    public int Pvalue; //지금 정답인애


    public List<GameObject> answerList; //정답프리팹담기

    public GameObject[] PButtons; //패턴 들어간 리스트
    public GameObject PButton; //패턴 슬롯 
    public GameObject Qprefabs;//문제가 나올 빈 패턴슬롯
    public static AnswerScreen instance;
    


	void Start () {

        instance = this;
        //newCostumer();
        callgamestart();
    }

  
	void Update () {
		
	}


    public void callgamestart()
    {
        StartCoroutine(WaitforAnimation());
    }

    IEnumerator WaitforAnimation()
    {

        yield return new WaitForSeconds(5);
        newCostumer();
        

    }


    public void newCostumer()
    {
        //랜덤한 숫자를 구해서 그 숫자 만큼 반복문을 돌면서 문제를 만들어낸다
        int RQN = Random.Range(4, 6);

        HowmanyQ = RQN;

        for(int i = 0; i< RQN; i++)
        {
            GameObject q = Instantiate(Qprefabs, this.transform);
            Getimage(q);
            answerList.Add(q);
            Debug.Log(q.GetComponent<SlotClick>().Pnumber);
           // Debug.Log(q.GetComponent<Image>().name);
        }

        sendAnswer();


    }

    public void Getimage(GameObject q)
    {

        PButtons = GameObject.FindGameObjectsWithTag("Pnumber");

        int i = Random.Range(0, PButtons.Length);


        q.GetComponent<Image>().sprite = PButtons[i].GetComponent<Image>().sprite;
        q.GetComponent<SlotClick>().Pnumber = PButtons[i].GetComponent<SlotClick>().Pnumber;
  

    }


    public void sendAnswer()
    {

        if (answerList.Count >= 1)
        {
            int i = answerlistnum;
            Pvalue = answerList[i].GetComponent<SlotClick>().Pnumber;

        }
        else
        {
            //Clean();
            
        }
        
    }


}
