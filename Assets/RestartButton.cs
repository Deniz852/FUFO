using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public int scene = 0;
    public void Restart()
    {
        SceneManager.LoadScene(scene);
    }
}
