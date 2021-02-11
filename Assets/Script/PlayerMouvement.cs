using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouvement : MonoBehaviour
{
    private float horizontal;
    public float speedInitial;
    private float speed;
    public float speedMax;
    public Vector2 movement;
    private float vertical;
    // Start is called before the first frame update
    void Start()
    {
        speed = speedInitial;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        movement.x = horizontal;
        movement.y = vertical;
        movement = movement.normalized * speed;

        transform.Translate( movement * Time.deltaTime);

        if (Input.GetButton("Jump"))
        {
            speed = Mathf.Lerp(speedInitial, speedMax, 100);
        }

        if (Input.GetButtonUp("Jump"))
        {
            speed = Mathf.Lerp(speedMax, speedInitial, 3);
        }
    }
}
