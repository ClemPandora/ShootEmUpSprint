using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject shoot;

    public float timerShoot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && timerShoot < 0)
        {
            Instantiate(shoot, transform.position, Quaternion.identity);
            timerShoot = 1;
        }

        if (timerShoot >= 0)
        {
            timerShoot -= Time.deltaTime;
        }
    }
    
    
}
