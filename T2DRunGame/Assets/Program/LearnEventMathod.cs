using UnityEngine;

public class LearnEventMathod : MonoBehaviour
{
    // 事件：在特定時間會自動執行
    // 開始：在播放遊戲後會執行一次，初始化，血量滿
    // 輸出 print("訊息") - 將訊息輸出到儀表板 - 測試用
    private void Start()
    {
        print("Hello World");

        // 呼叫方法
        // 語法：方法名稱();
        Test();
        // 乎較有參數的方法時要輸入對應的引數
        Test2(999);
        Test2(123456);
        // 有預設值的參數可以不填寫
        Drive(123, "右邊");
        Drive(999);
        // 多個預設值參數可以用 參數名稱: 指定
        Drive(777, sound: "bbb");
    }

    // 更新：一秒執行約 60 次，持續執行，例如：移動、監聽玩家輸入
    private void Update()
    {
        print("Hi !! I am updating");
    }

    // 方法：
    // ***** 語法
    // 修飾詞 傳回類型 方法名稱 () { 程式內容 }
    // 無傳回 void
    // 方法名稱 : Unity 習慣會用大寫開頭
    // 事件與方法差異 : 事件名稱為藍色，方法為白色
    // 事件與方法差異 : 事件會自動執行，方法不會
    public void Test()
    {
        print("Test!!!");
    }

    // 參數語法：(參數類型 參數名稱 參數類型 參數名稱，...................)
    // 參數與欄位相同但不需要修飾詞
    public void Test2(int number)
    {
        print("Test No.2");
        print(number);
    }

    // 參數預設值
    // 語法：類型 名稱 = 值
    // 有預設值的參數必須寫在最右邊
    public void Drive(int speed, string direction = "前方", string sound = "sss")
    {
        print("時數:" + speed);
        print("開車方向:" + direction);
        print("開車音效:" + sound);
    }
}
