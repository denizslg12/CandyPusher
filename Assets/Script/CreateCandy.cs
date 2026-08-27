using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CreateCandy : MonoBehaviour
{
    [SerializeField] private GameObject[] normalCandyPrefabs;
    [SerializeField] private GameObject[] specialCandyPrefabs;
    public float cooldown = 5f;
    private float canpush = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("OutputTime", 1f, 1f);
    }
    void OutputTime() 
    {
        int randomIndex = Random.Range(0, normalCandyPrefabs.Length);

        GameObject InstantiatedCandy =
            Instantiate(normalCandyPrefabs[randomIndex]);

        InstantiatedCandy.transform.position = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
     
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            int randomIndex = Random.Range(0, normalCandyPrefabs.Length);
            GameObject InstantiatedCandy =
             Instantiate(normalCandyPrefabs[randomIndex]);
            InstantiatedCandy.transform.position = this.transform.position;
        }
       
        {
            if (Keyboard.current.bKey.wasPressedThisFrame && Time.time>=canpush)
            {
                canpush = Time.time + cooldown;
                int randomIndex = Random.Range(0, specialCandyPrefabs.Length);
                GameObject InstantiatedCandy =
                 Instantiate(specialCandyPrefabs[randomIndex]);
                InstantiatedCandy.transform.position = this.transform.position;
                
            }
        }
    }
}
