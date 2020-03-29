using UnityEngine;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void PlayAgain()
    {
        Debug.Log("Play Again");
        SceneManager.LoadScene(1);
    }
}
