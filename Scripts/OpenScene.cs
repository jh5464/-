using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenScene : MonoBehaviour
{
    public GameObject ���а�;
    public GameObject ����;
    public GameObject �˳�;
    // Start is called before the first frame update
    public void LoadGameScene()
    {
        // ������Ϸ����
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {    
        Application.Quit();

    }
    public void Paihangbang()
    {

        ���а�.SetActive(true);
        ����.SetActive(false);
        �˳�.SetActive(true);
    }
    public void QuitPAI()
    {
        ���а�.SetActive(false);
        ����.SetActive(true);
        �˳�.SetActive(false);

    }
}
