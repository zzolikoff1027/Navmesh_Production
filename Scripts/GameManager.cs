using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void sceneOne()
    {
        SceneManager.LoadScene("Scene_01");
    }
    public void sceneTwo() 
    {
        SceneManager.LoadScene("Scene_02");
    }
    public void sceneThree() 
    {
        SceneManager.LoadScene("Scene_03");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("Start Scene");
    }

    public void reloadScene()
    {
        SceneManager.LoadScene("Scene_03");
    }
}
