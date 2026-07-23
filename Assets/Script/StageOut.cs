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

        if (Score >= 50)
        {
            if (AudioManager.instance.bgmAudioSource.clip != AudioManager.instance.bgmAudioClips[1])
            {
                AudioManager.instance.bgmAudioSource.clip = AudioManager.instance.bgmAudioClips[1];
                AudioManager.instance.bgmAudioSource.Play();
            }
        }

        AudioManager.instance.PlaySE();


        Score += 1  ;
        scoreTextTMP.text = $"{Score}";

        scoreText.text = ($"score is {Score}");
        //Debug.Log($"{other.name}Ç™Ç∑ÇËî≤ÇØÇ‹ÇµÇΩÅB");
        Destroy(other.gameObject);

                        
    }
   

}
