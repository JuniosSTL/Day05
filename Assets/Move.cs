using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Transform myTransform;
    AudioSource source;

	void Start ()
	{
        //시작 하자 마자 GameObject에서 Transform 컴포넌트를 찾아서
        //myTransform에 할당
        myTransform = GetComponent<Transform>();
        source = GetComponent<AudioSource>();
    }
	
	void Update ()
	{
        //myTransform.Translate(0, 1 * Time.deltaTime, 0);
        transform.Translate(0, 1 * Time.deltaTime, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            source.Play();
        }
    }
}
