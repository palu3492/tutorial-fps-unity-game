using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelSelect : MonoBehaviour
{
    private int start = 1;
    public void SelectLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex + start);
    }
}
