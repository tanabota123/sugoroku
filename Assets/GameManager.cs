using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    //ゴールの位置
    public int gole = 15;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("1");
    }

    // Update is called once per frame
    void Update()
    {
        //ButtonClickと共有
        ButtonClick ButtonClick;
        GameObject obj = GameObject.Find("Button");
        ButtonClick = obj.GetComponent<ButtonClick>();
        Debug.Log(ButtonClick.places);


        //placesとgoleが同じになったとき終了する。
        if (ButtonClick.places >= gole)
        {
            Debug.Log("ゴール");
        }
    }
}
