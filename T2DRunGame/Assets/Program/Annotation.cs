// 單行註解
// 引用 unity 引擎 API (倉庫)
using UnityEngine;

// 類別 class (腳本) 類別名稱
public class Annotation : MonoBehaviour
{
    // 大括號內為
    // 類別 成員
    // 括號 C# 成對出現
    // ()、[]、{}、""、''、<>

    // 類別：定義務建需要的資料與功能
    // 成員：資料與功能
    // 資料：欄位、屬性 - 儲存遊戲內所需要的資料，例如：血量、移動速度、道具名稱...
    // 功能：方法 - 有作用的程式內容，例如：跳躍、死亡、吃金幣...

    // 資料
    // 品牌、CC 數、重量、顏色、速度、是否有天窗

    // 欄位 field：儲存資料
    // 欄位語法
    // 修飾詞 欄位類型 欄位名稱 (指定 值) 結束符號 (;)

    // 整數 int：沒有小數點的數值，例：1、100、-100
    // 浮點數 float：有小數點的數值，例：1.234、-1.234 - 結尾必須要有 f 大小寫皆可
    // 字串 string：文字，例：註解、Annotation - 必須包覆在 "" 內
    // 布林植 bool：是、否，例：true、false 

    // 類別、成員命名規則
    // 不允許
    // 1. 特殊符號，例：#*@$ 空格
    // 2. 數字開頭，例：9cc
    // 3. 保留字，例：class、int、bool

    // 允許
    // 1. 底線，例：player_a
    // 2. 數字中間後面，例：player1、player3zzz
    // 3. 中文，例如：角色速度(不建議)

    // 修飾詞：預設為私人
    // 私人 private：不顯示
    // 公開 public：顯示

    // 資料
    // 品牌、CC 數、重量、是否有天窗、速度、顏色

    // 欄位的屬性
    // 語法：[屬性名稱(值)]
    // 標題 Header("標題")
    // 提示 Tooltip("提示文字")
    // 範圍 Range(最小值，最大值) - 僅限於數值類型
    [Header("品牌")]
    public string brand = "台灣";
    [Header("CC 數"), Tooltip("汽車的 CC 數量")]
    public int cc = 9999;
    [Header("重量"), Range(0, 100)]
    public float weight = 49.5f;
    public bool window = false;

    // 補充：Unity 常用資料類型
    // 顏色、座標(2、3、4)
    // Color、Vector234
    public Color red = Color.red;
    public Color myColor = new Color(0.5f, 0.5f, 0.5f);

    public Vector2 posZero = Vector2.zero;
    public Vector2 posOne = Vector2.one;
    public Vector2 posCustom = new Vector2(9, 20);
    public Vector3 pos3 = new Vector3(3, 2, 1);

    // 儲存物件、元件
    // 物件：階層 (Hierarchy) 面板內的所有東西
    // 元件：屬性 (Inspector) 面板內的粗體字 > Class
    public GameObject cam;
    public Transform traCam;
    public Camera cam2;
}
