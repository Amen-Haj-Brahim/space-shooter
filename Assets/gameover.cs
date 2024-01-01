using UnityEngine;
using UnityEngine.SceneManagement;
public class gameover : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void exit()
    {
        Application.Quit();
    }
}
