using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpCooldown = 1f;
    public float jumpSpeed = 5f;
    private float lastJumpTime;
    private Rigidbody2D body;


    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        body.freezeRotation = true;
     }

    private void Update()
    {
        body.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.linearVelocity.y);
        
        if(Input.GetKey(KeyCode.Space) && Time.time >= lastJumpTime + jumpCooldown)
        {
            body.linearVelocity = new Vector2(body.linearVelocity.x, jumpSpeed);
            lastJumpTime = Time.time;
        }
    
    }
}
