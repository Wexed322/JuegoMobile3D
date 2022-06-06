using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScene : MonoBehaviour
{
    public GameObject container;
    public List<GameObject> casas;
    public float velocidad;

    public float limiteMapa;
    public float offsetConOtros;
    void Start()
    {
        limiteMapa = 50;
        offsetConOtros = 20;
    }

    void Update()
    {
        container.transform.position += container.transform.right * velocidad * Time.deltaTime;
        if (casas[0].transform.localPosition.x > limiteMapa) 
        {
            GameObject tmp = casas[0];
            tmp.SetActive(false);
            tmp.transform.localPosition = casas[casas.Count-1].transform.localPosition - new Vector3(offsetConOtros, 0, 0);
            casas.Remove(tmp);
            casas.Add(tmp);
            tmp.SetActive(true);
        }
    }
}
