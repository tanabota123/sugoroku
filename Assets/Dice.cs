using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public int sides = 6;

    //ButtonClickに呼び出される
    public int DoSomething()
    {
        int result = Random.Range(1, sides + 1);
        return result;
        
    }
}