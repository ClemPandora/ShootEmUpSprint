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
    private Vector2 _screenBounds;

    private float _objectWidth;
    private float _objectHeight;
    
    // Start is called before the first frame update
    void Start()
    {
        _screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        speed = speedInitial;
        _objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x;
        _objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y;
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
    
    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, _screenBounds.x * -1 + _objectWidth, _screenBounds.x - _objectWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, _screenBounds.y * -1 + _objectHeight, _screenBounds.y - _objectHeight);
        transform.position = viewPos;
    }
}
