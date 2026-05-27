using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private float _speed;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Rigidbody2D _rb;

    private bool _isGrounded;

    private void OnCollisionEnter2D(Collision2D other)
    {
        _isGrounded = true;

    }



    private void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");

        // left-right movement
        Vector3 direction = new Vector3(horizontal, 0, 0);
        _playerTransform.Translate(direction * _speed * Time.deltaTime);

        //Jumping
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)) && _isGrounded == true)
        {
            _rb.AddForce(Vector3.up * 5f, ForceMode2D.Impulse);
            Debug.Log("Jumping");
            _isGrounded = false;
        }

        // Flip player sprite left and right while moving

        if (horizontal < 0)
        {
            // Moving left, flip the sprite on the X-axis
            spriteRenderer.flipX = true;
        }
        else if (horizontal > 0)
        {
            // Moving right, ensure the sprite is not flipped
            spriteRenderer.flipX = false;
        }

    }
}
