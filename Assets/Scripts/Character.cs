using UnityEngine;

public class Character : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _axis;
    [SerializeField] private float speed = 5f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _axis = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(_axis * speed, _rb.velocity.y);
    }
}