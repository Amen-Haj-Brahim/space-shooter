using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void loadgame() {
        SceneManager.LoadScene("Game");
    }
    public void exitgame()
    {
        Application.Quit();
    }
}
