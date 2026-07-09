using UnityEngine;

public class candymanagermovementnew : MonoBehaviour
{
    private float moveSpeed = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(moveSpeed, 0, 0) + this.transform.position;
        if (this.transform.position.x > 5f)
        {
            moveSpeed = -0.1f;
        }
        if (this.transform.position.x < -5f)
        {
            moveSpeed = 0.1f;
        }
    }
}
