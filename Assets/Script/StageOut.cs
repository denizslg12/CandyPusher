using UnityEngine;
using System;
using UnityEngine.UI;
public class StageOut : MonoBehaviour
{
    private int Score;
    public Text scoreText;
    public TMPro.TextMeshProUGUI scoreTextTMP;
    private void OnTriggerEnter(Collider other)
    {  
        Score +=1  ;
        Debug.Log($"score is {Score}");

        scoreTextTMP.text = $"{Score}";

        scoreText.text = ($"score is {Score}");
        //Debug.Log($"{other.name}Ç™Ç∑ÇËî≤ÇØÇ‹ÇµÇΩÅB");
        Destroy(other.gameObject);
        
    }

}
