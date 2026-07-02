using UnityEngine;

public class CandyManagerMovement : MonoBehaviour
{
    public float speed = 1f;
    public float movePower = 5f;
    private Vector3 startPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = this.transform.position;
        Debug.Log("ÉQÅ[ÉÄÇ™äJénÇµÇΩÇÊ");

    }
    public Rigidbody rb;
    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Sin(Time.time * speed) * movePower;
        rb.linearVelocity = new Vector3(x, 0, 0);
    }
}
