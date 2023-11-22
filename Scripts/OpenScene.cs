using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenScene : MonoBehaviour
{
    public GameObject 排行榜;
    public GameObject 排名;
    public GameObject 退出;
    // Start is called before the first frame update
    public void LoadGameScene()
    {
        // 加载游戏场景
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {    
        Application.Quit();

    }
    public void Paihangbang()
    {

        排行榜.SetActive(true);
        排名.SetActive(false);
        退出.SetActive(true);
    }
    public void QuitPAI()
    {
        排行榜.SetActive(false);
        排名.SetActive(true);
        退出.SetActive(false);

    }
}
