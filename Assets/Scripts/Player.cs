using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 motion;
    public float speed = 20f;

    private void Start()
    {
        motion = this.transform.position;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            motion.y += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            motion.y -= speed * Time.deltaTime;
        }

        motion.y = Mathf.Clamp(motion.y, -10f, 10f);

        this.transform.position = motion;
    }
}
