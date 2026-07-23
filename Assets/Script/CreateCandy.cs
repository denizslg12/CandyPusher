using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CreateCandy : MonoBehaviour
{
    [SerializeField]
    private GameObject candyPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("OutputTime", 1f, 1f);
    }
    void OutputTime() {
        GameObject InstantiatedCandy = Instantiate(candyPrefab);
    InstantiatedCandy.transform.position = this.transform.position;
        }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            GameObject InstantiatedCandy = Instantiate(candyPrefab);
            InstantiatedCandy.transform.position = this.transform.position;
        }
    }
}
