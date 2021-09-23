using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public float rollspeed = 5;
    public float dodgespeed = 5;
    void Start()
    {
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        var horizontalSpeed = Input.GetAxis("Horizontal") * dodgespeed * Time.deltaTime;
        this.transform.Translate(horizontalSpeed, 0, dodgespeed * Time.deltaTime);
    }
}
