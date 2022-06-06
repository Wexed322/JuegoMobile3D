using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Vector2 rangoSpawn;
    private ObjectPool pool;
    [SerializeField] int cantidadEnemigos;



    [SerializeField] float coolDown;
    [SerializeField] float contador;
    void Start()
    {
        pool = GetComponent<ObjectPool>();
        RandomCooldown();
        pool.fullStartPool(cantidadEnemigos);
    }

    void Update()
    {
        contador += Time.deltaTime;
        if (contador > coolDown) 
        {
            pool.getObject();
            contador = 0;
        }
    }
    public void RandomCooldown() 
    {
        coolDown = Random.Range(rangoSpawn.x, rangoSpawn.y);
    }
}
