using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed;
    private Vector3 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHor = Input.GetAxis("Horizontal");
        float moveVer = Input.GetAxis("Vertical");

        direction = new Vector3(moveHor, 0, moveVer);
        direction = Vector3.ClampMagnitude(direction, 1);
        direction = transform.TransformDirection(direction);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
    }
}