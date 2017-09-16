using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject missile;

    void Update()
    {
        Instantiate(missile, transform.position, transform.rotation);
    }
}
