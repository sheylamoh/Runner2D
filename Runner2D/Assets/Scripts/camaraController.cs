using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraController : MonoBehaviour
{
    public Transform seguidorPlayer;

    // Start is called before the first frame update
    void Start()
    {
        // método alternativo para tomar una referencia del objeto
        if (seguidorPlayer == null)
            seguidorPlayer = GameObject.FindGameObjectWithTag("player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(seguidorPlayer.position.x, 0, transform.position.z);
    }
}
