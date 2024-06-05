using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Computer : MonoBehaviour
{
    private Vector3 motion;
    public float speed = 20f;
    public Ball ball;

    private void Start()
    {
        motion = this.transform.position;
    }

    void Update()
    {
        float distance = Vector3.Distance(ball.transform.position, this.transform.position);

        if (distance <= 20)
        {
            Vector2 target = new Vector2(transform.position.x, ball.transform.position.y);
            motion = Vector2.MoveTowards(this.transform.position, target, speed * Time.deltaTime);
        }

        motion.y = Mathf.Clamp(motion.y, -10f, 10f);
        this.transform.position = motion;
    }
}
