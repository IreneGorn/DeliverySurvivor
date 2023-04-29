using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // movement speed
    private bool isFacingRight = true; // flag for character direction

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Move the character in the direction of arrow keys or WASD keys
        Vector3 direction = new Vector3(horizontal, vertical, 0f);
        transform.position += direction * speed * Time.deltaTime;
        
        if ((horizontal > 0 && !isFacingRight) || (horizontal < 0 && isFacingRight))
        {
            isFacingRight = !isFacingRight;
            transform.Rotate(0f, 180f, 0f);
        }
    }
}
