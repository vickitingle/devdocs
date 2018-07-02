using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    /// </summary>
    public Vector2 speed = new Vector2(0.1f, 0.1f);

    // 2 - Store the movement
    private Vector2 movement;

    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        Physics2D.gravity = Vector2.zero;
        speed.x = 5;
        speed.y = 5;
    }

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        // 4 - Movement per direction
        movement = new Vector2(
          speed.x * inputX,
          speed.y * inputY
        );
    }

        // Update is called once per frame
    void FixedUpdate()
    {
        if (rbody == null)
        {
            rbody = GetComponent<Rigidbody2D>();
        }

        rbody.velocity = movement;
    }
}