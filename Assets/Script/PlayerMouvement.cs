using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouvement : MonoBehaviour
{
    private float horizontal;
    public float speed;
    public Vector2 movement;
    private float vertical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        movement.x = horizontal * speed;
        movement.y = vertical * speed;
        
        transform.Translate( movement * Time.deltaTime); 
    }
}
