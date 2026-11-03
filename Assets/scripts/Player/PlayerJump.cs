using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 5f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) &&
            Physics.Raycast(transform.position, Vector3.down, 1.1f))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}