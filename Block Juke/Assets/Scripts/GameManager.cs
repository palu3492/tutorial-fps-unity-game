using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameOver = false;
    public float restartDelay = 2.0f;
    public GameObject completeLevelUI;
    public GameObject player;
    public GameObject fakePlayer;

    private void Start()
    {
        Invoke("StartGame", 1f);
    }

    void StartGame()
    {
        fakePlayer.SetActive(false);
        player.SetActive(true);
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    
    public void EndGame()
    {
        if (!gameOver)
        {
            gameOver = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void Crash()
    {
        SceneManager.LoadScene("Scenes/Crash");
    }
    
}
