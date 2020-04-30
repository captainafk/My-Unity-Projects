using UnityEngine;

public class Player2_Controller : MonoBehaviour
{
    public float jumpVelocity;
    public float gravity;
    private Rigidbody rb;
    public SphereCollider col;
    public LayerMask groundLayers;

    // Use this for initialization
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (GameMng.isGameRunning)
        {
            if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
            {
                rb.AddForce(Vector3.forward * jumpVelocity, ForceMode.Impulse);
            }
            else
            {
                rb.AddForce(Vector3.back * gravity);
            }
        }
    }

    private bool IsGrounded()
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.center.y, col.bounds.min.z), col.radius * .9f, groundLayers);
    }
}