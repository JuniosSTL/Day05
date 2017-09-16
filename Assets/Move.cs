using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 1;
    public Color newColor;

	void Update ()
	{
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }
}
