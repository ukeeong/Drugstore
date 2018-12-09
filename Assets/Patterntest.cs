using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Patterntest : MonoBehaviour {

    public GameObject Pattern;
    public List<GameObject> Patterns;
      List<Sprite> list = new List<Sprite>();

    public Sprite[] PatternSprite;

    public int Pnumbers;

    public static Patterntest Instance;



    public void Start()
    {
        Instance = this;
        GetSlots();
        List<Sprite> list = new List<Sprite>();

    }


    public void GetSlots()
    {
        int slotcount = 25;
        int c = 1;

        for (int i =0; i<slotcount; i++)
        {
            GameObject p = Instantiate(Pattern, this.transform);
            getImage(p);
           
            p.GetComponent<SlotClick>().Pnumber = c;
            getTag(p);
            c++;
            Patterns.Add(p);
        }
    }


    public void getImage(GameObject p)
    {
 
        foreach (Sprite sp in PatternSprite)
        {
            list.Add(sp);
        }

        int i = Random.Range(0, 59);

        p.GetComponent<Image>().sprite = list[i];
        list.Remove(list[i]);

        
    }


    public void getTag(GameObject p)
    {
        p.gameObject.tag = "Pnumber";
    }

}
