using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    //public Dice otherScript;
    public int sides = 6;
    //出目
    public int result = 0;
    //現在地
    public int places = 0;

    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    //サイコロ
    public　void OnClick()
    {
        //int dice = otherScript.DoSomething();
        result = Random.Range(1, sides + 1);
        Debug.Log(result);
        places += result;
        Debug.Log(places);
        //return result;
    }
    
}
