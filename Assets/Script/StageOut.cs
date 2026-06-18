using UnityEngine;
using System;
using UnityEngine.UI;
public class StageOut : MonoBehaviour
{
    private int score;
    public Text scoreText;
    private void OnTriggerEnter(Collider other)
    {  
        score +=1  ;
        Debug.Log($"score is {score}");

        scoreText.text = ($"score is {score}");
        //Debug.Log($"{other.name}Ç™Ç∑ÇËî≤ÇØÇ‹ÇµÇΩÅB");
        Destroy(other.gameObject);
        
    }

}
