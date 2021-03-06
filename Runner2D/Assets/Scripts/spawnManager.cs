using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] bloques;
    public float tiempoMin = 2f;
    public float tiempoMax = 4f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoroutine(0));
    }

    // Update is called once per frame
    void Update()
    {

    }

    // creación de una corrutina (se ejecuta en tiempo)
    IEnumerator SpawnCoroutine(float time)
    {
        yield return new WaitForSeconds(time);

        // crea un gameobject
        Instantiate(bloques[Random.Range(0, bloques.Length)], transform.position, Quaternion.identity);

        // para que las corrutinas vuelvan a ejecutarse
        StartCoroutine(SpawnCoroutine(Random.Range(tiempoMin, tiempoMax)));

    }

}