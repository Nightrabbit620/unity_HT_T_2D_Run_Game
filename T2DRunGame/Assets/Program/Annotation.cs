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
    // 欄位類型 欄位名稱 結束符號 (;)

    // 整數 int：沒有小數點的數值，例：1、100、-100
    // 浮點數 float：有小數點的數值，例：1.234、-1.234
    // 字串 string：文字，例：註解、Annotation
    // 布林植 bool：是、否，例：true、false 

    string brand;
    int cc;
    float weight;
    bool window;
    float speed;

    // 類別、成員命名規則
    // 不允許
    // 1. 特殊符號，例：#*@$ 空格
    // 2. 數字開頭，例：9cc
    // 3. 保留字，例：class、int、bool

    // 允許
    // 1. 底線，例：player_a
    // 2. 數字中間後面，例：player1、player3zzz
    // 3. 中文，例如：角色速度(不建議)
}
