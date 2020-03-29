using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{

    public Transform player;
    public Text highScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = PlayerPrefs.GetFloat("HighScore", 0f).ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        float score = player.position.z;
        if(score >  PlayerPrefs.GetFloat("HighScore")){
            PlayerPrefs.SetFloat("HighScore", score);
            highScoreText.text = score.ToString("0");
        }
    }
}