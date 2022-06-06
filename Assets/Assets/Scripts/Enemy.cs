using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : InPoolObject
{
    public float velocidad;
    void Start()
    {
        velocidad = 15f;
    }


    void Update()
    {
        this.transform.position += Vector3.right * velocidad * Time.deltaTime;
    }

    public void DestroyMySelf() 
    {
        poolReference.pool.Add(this);
        this.transform.position = poolReference.transform.position;
        this.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Spawner")) 
        {
            DestroyMySelf();
        }
    }
}
