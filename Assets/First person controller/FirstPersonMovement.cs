using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    public float speed = 5;
    Vector2 velocity;
    public Joystick joystick; 
    private float verticalMove = 0f;
    private float horizontalMove = 0f;
    void FixedUpdate()
    {
        Debug.Log(joystick.Horizontal);
        if (joystick.Horizontal > 0.80)
            horizontalMove = -1;
        else if ( joystick.Horizontal < -0.80)
            horizontalMove = 1;
        else if (joystick.Vertical > 0.80)
            verticalMove = -1;
        else if (joystick.Vertical < -0.80)
            verticalMove = 1;

        velocity.y = verticalMove * speed * Time.deltaTime;
        velocity.x = horizontalMove * speed * Time.deltaTime;
        transform.Translate(velocity.x, 0, velocity.y);
        verticalMove = 0;
        horizontalMove = 0;
    }
}
