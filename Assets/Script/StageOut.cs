using UnityEngine;
using System;
public class StageOut : MonoBehaviour
{
    private int score = 0;
    private void OnTriggerEnter(Collider other)
    {  
        score = ++score ;
        Debug.Log($"scoreis {score}");
        Debug.Log($"{other.name}Ç™Ç∑ÇËî≤ÇØÇ‹ÇµÇΩÅB");
        Destroy(other.gameObject);
        
    }

}
