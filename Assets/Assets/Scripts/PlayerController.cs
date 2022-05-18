using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;

    private Vector3 aceleration;
    void Start()
    {
        
    }
    void Update()
    {
        aceleration = new Vector3(Input.acceleration.x, Input.acceleration.y, Input.acceleration.z);
        text1.text =  "X: " + aceleration.x.ToString();
        text2.text =  "Y: " + aceleration.y.ToString();
        text3.text =  "Z: " + aceleration.z.ToString();
    }
}
