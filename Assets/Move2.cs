using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    public float moveSpeed = 4;
	
	void Update ()
	{
        //float h = Input.GetAxis("Horizontal"); // 좌우
        //float v = Input.GetAxis("Vertical"); //상하 
        float h = Input.GetAxisRaw("Horizontal"); // 좌우
        float v = Input.GetAxisRaw("Vertical"); //상하 

        transform.Translate(h * moveSpeed * Time.deltaTime,
            v * moveSpeed * Time.deltaTime,
            0);

        if ( Input.GetButtonDown("Fire1") )
        {
            Debug.Log("Fire1");
        }
	}
}
