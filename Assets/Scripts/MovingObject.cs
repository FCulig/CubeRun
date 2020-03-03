using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public float maxDelta = 3f;
    public float speed = 2.5f;

    private Vector3 startPos;
    private float delta;

    void Start()
    {
        startPos = transform.position;
        delta = Random.Range(1, maxDelta);
    }

    void Update()
    {
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
