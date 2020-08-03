using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCtrl : MonoBehaviour
{
    // 方法要被按鈕呼叫需要設為公開 public

    /// <summary>
    /// 切換場景
    /// </summary>
    public void ChangeScene()
    {
        // 切換場景
        // 場景管理.載入場景("場景名稱或編號")
        // SceneManager.LoadScene("Start");
        SceneManager.LoadScene(1);
    }

    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void Quit()
    {
        // 關閉遊戲並離開
        // 應用程式.離開
        Application.Quit();
    }

    // 延遲呼叫方法 Invoke("方法名稱", 延遲秒數)
    /// <summary>
    /// 延遲切換場景
    /// </summary>
    public void DelayChangeScene()
    {
        Invoke("ChangeScene", 1.5f);
    }

    /// <summary>
    /// 延遲離開遊戲
    /// </summary>
    public void DelayQuit()
    {
        Invoke("Quit", 1.5f);
    }
}
