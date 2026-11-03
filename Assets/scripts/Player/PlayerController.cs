using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    protected float movementSpeed = 6;

    [SerializeField]
    private Transform viewCamera;

    protected Vector3 movementVector;

    protected void Update() => movementVector =
        Quaternion.Euler(0f, viewCamera.eulerAngles.y, 0f) *
        new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
}