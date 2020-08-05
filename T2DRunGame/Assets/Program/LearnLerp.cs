using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnLerp : MonoBehaviour
{
    // 差值 : 取得兩點的中間值
    // A:0
    // B:0
    // 取得 A 與 B 中間 50 % 值
    // 差值(A，B，0.5f) = 5

    public float A = 0;
    public float B = 100;

    void Start()
    {
        float result = Mathf.Lerp(A, B, 0.5f);
        print(result);
    }

    public float C = 0;
    public float D = 100;

    public Vector2 v2A = new Vector2(0, 0);
    public Vector2 v2B = new Vector2(100, 100);

    // Update is called once per frame
    void Update()
    {
        
    }
}
