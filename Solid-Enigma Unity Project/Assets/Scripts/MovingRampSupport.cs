﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRampSupport : MonoBehaviour
{
    public float moveSpeed = 1f;

    private float verticalInput;
    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    //Use fixed update for pjysics code, because we need to be careful
    //about how often we call hardware intensive, physics stuff.
    private void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");
        rigidbody.velocity = new Vector2(0, verticalInput * moveSpeed);
    }
}