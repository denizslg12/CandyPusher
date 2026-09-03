using UnityEngine;
using System;
using UnityEngine.UI;
public class StageOut : MonoBehaviour
{
    private int Score;
    public Text scoreText;
    public Text comboText;
    public TMPro.TextMeshProUGUI scoreTextTMP;
    private int Combo = 0;

    private CandyColor? previousColor = null;

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

        Candy candy = other.GetComponent<Candy>();

        if (candy != null)
        {
            CandyColor currentColor = candy.Color;
            CandyType isSpecial = candy.Type;

            if (previousColor == null)
            {
                previousColor = currentColor;
                Score += 1;
            }
            else
            {
                if (currentColor == previousColor.Value)
                {
                    Debug.Log("Same Color! Combo Continue! Combo"+Combo);
                    Combo++;
                    Score += 1+Combo;
                }
                else
                {
                    Debug.Log("Different Color! Combo Reset!");
                    Combo = 0;
                    Score += 1;

                }
                if (isSpecial == CandyType.multiplier)
                {
                    Candy[] allCandies = FindObjectsByType<Candy>(FindObjectsSortMode.None);

                    foreach (Candy targetcandy in allCandies)
                        if (targetcandy.Color != currentColor )
                            Destroy(targetcandy.gameObject);
                }

                previousColor = currentColor;
            }




            comboText.text = ($"combo is {Combo}");

            scoreText.text = ($"score is {Score}");
            //Debug.Log($"{other.name}Ç™Ç∑ÇËî≤ÇØÇ‹ÇµÇΩÅB");
            Destroy(other.gameObject);
        }

                        
    }
   

}
