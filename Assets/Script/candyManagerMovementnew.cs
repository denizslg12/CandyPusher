using UnityEngine;

public class candyManagerMovementTranslate : MonoBehaviour
{
    private float moveSpeed = 1f;
    
    // Update is called once per frame
    void Update()
    {
        this.transform.position = this.transform.position + new Vector3(moveSpeed, 0, 0) * Time.deltaTime;

        if (this.transform.position.x > 3) 
        {
            moveSpeed = -1 * moveSpeed;
        }
        if (this.transform.position.x < -3)
        {
            moveSpeed = -1 * moveSpeed;
        }

    }
    
}
