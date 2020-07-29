using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    // 非靜態成員需要
    // 1. 實體物件或元件 (Unity 階層面板)
    // 2. 欄位
    // 先看場景上有的物件與元件
    public GameObject sphere;

    public Transform tra;

    public Transform cube;

    public void Start()
    {
        // ［取得］屬性 Peoperties
        // ***** 語法：
        // 欄位名稱.屬性
        print(sphere.layer);

        print("球的座標：" + tra.position);

        // ［設定］屬性　peoperties
        // ***** 語法：
        // 欄位名稱.屬性 = 值
        tra.localScale = new Vector3(7, 7, 7);
    }

    public void Update()
    {
        // ［使用］方法 Methofs
        // ***** 語法：
        // 欄位名稱.方法(對應的引數)
        cube.Rotate(0f, 0f, 0.5f);

    }
}
