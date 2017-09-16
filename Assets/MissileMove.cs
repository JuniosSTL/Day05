using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMove : MonoBehaviour
{
    public float moveSpeed = 40.0f;

    void Start()
    {
        Destroy(gameObject, 3.0f);
    }

    void Update ()
	{
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
	}
}
