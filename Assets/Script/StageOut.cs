using UnityEngine;
using System;
using UnityEngine.UI;
public class StageOut : MonoBehaviour
{
    private int Score;
    public Text scoreText;
    public TMPro.TextMeshProUGUI scoreTextTMP;
    public AudioManager audioManager;
    private void OnTriggerEnter(Collider other)
    {
        audioManager.PlaySE();

        Score +=1  ;
        Debug.Log($"score is {Score}");

        scoreTextTMP.text = $"{Score}";

        scoreText.text = ($"score is {Score}");
        //Debug.Log($"{other.name}Ç™Ç∑ÇËî≤ÇØÇ‹ÇµÇΩÅB");
        Destroy(other.gameObject);
        
    }

}
