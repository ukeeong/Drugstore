using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PatternSlot : MonoBehaviour {


    public Sprite[] PatternButtonSpriteList; //이지모드 문제를 위해 문양 다 넣을 공간 만들기
    public Sprite[] PatternA; //하드모드 문양의 A면 넣을 공간 만들기
    public Sprite[] PatternB; //하드모드 문양의 B면 넣을 공간 만들기

    

	void Start () {

        List<Sprite> list = new List<Sprite>();

        foreach(Sprite sp in PatternButtonSpriteList)
        {
            list.Add(sp);

        }
        // 새로운 이미지 리스트를 만들어서 PatternButtonSpriteList의 모든 이미지들을
        // list라는 새 리스트에 넣는다.
        

        Image[] childrenImgs = transform.GetComponentsInChildren<Image>();


        foreach (Image img in childrenImgs)
        {
            int i = Random.Range(0, list.Count);
            img.sprite = list[i];
            list.Remove(list[i]);
        }

        // 이 스크립트가 붙은 녀석에게서 Image컴포넌트를 찾아 가져와 childrenImgs에 넣는다.
        // 0부터 list에 들어있는 만큼에서 랜덤한 숫자 i를 구한다.
        // 이 스크립트의 모든 자식들을 리스트의 이미지중에서 i번째 이미지로 교체한다
        // 그 후 i번째 그림을 리스트에서 삭제한다

	}
	
	
}
