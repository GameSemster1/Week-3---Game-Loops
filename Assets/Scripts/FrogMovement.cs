using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMovement : MonoBehaviour
{
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] float speed = 5f;
    [SerializeField] float leftLimitPlayer;
    [SerializeField] float rightLimitPlayer;
    [SerializeField] float topLimitPlayer;
    [SerializeField] float bottomLimitPlayer;
    private float jump = 2f;

    /// <summary>
    /// The key that moves the gameobject forward (or up).
    /// </summary>
    [Tooltip("The key that moves the gameobject forward (or up).")]
    private KeyCode up = KeyCode.UpArrow;

    /// <summary>
    /// The key that moves the gameobject backwards (or down).
    /// </summary>
    [Tooltip("The key that moves the gameobject backwards (or down).")]
    private KeyCode down = KeyCode.DownArrow;

    private int level = 0;
    // Update is called once per frame
    void Update()
    {
        Vector3 moveRL = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f); // +1 if right arrow is pushed, -1 if left arrow is pushed, 0 otherwise
        transform.position += moveRL * Time.deltaTime * speed;
        float x = transform.position.x;
        float y = transform.position.y;
        if (Input.GetKeyDown(up))
        {
            
            if (level == 0)
            {
                transform.position = new Vector3(x, y+jump, 0f);
                level++;
            }
            else if (level == 1)
            {
                transform.position = new Vector3(x, y+jump, 0f);
                level++;
            }
            else if (level == 2)
            {
                transform.position = new Vector3(x, y+jump, 0f);
                level++;
            }
            else if (level == 3)
            {
                transform.position = new Vector3(x, y+jump, 0f);
                level++;
            }
            else if (level == 4)
            {
                transform.position = new Vector3(x, y+jump, 0f);
                level++;
            }
            else if (level == 5)
            {
                transform.position = new Vector3(x, y+jump, 0f);
            }
        }
        else if (Input.GetKeyDown(down))
        {
            if (level == 5)
            {
                transform.position = new Vector3(x, y-jump, 0f);
                level--;
            }
            else if (level == 4)
            {
                transform.position = new Vector3(x, y-jump, 0f);
                level--;
            }
            else if (level == 3)
            {
                transform.position = new Vector3(x, y-jump, 0f);
                level--;
            }
            else if (level == 2)
            {
                transform.position = new Vector3(x, y-jump, 0f);
                level--;
            }
            else if (level == 1)
            {
                transform.position = new Vector3(x, y-jump, 0f);
                level--;
            }
            else if (level == 0)
            {
                transform.position = new Vector3(x, y-jump, 0f);
            }
            
            
        }
        
        transform.position = new Vector3
        (
            Mathf.Clamp(transform.position.x, leftLimitPlayer, rightLimitPlayer),
            Mathf.Clamp(transform.position.y, bottomLimitPlayer, topLimitPlayer),
            transform.position.z
        );

    }

    
}
