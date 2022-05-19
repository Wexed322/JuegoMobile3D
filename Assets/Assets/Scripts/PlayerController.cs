using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    //private Gyroscope gyroscope;
    //private bool gyroscopeEnabled;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;

    private Vector3 aceleration;
    public float velocidad;
    public float velocidad2;
    /*void Start()
    {
        //gyroscopeEnabled = EnableGyro();

    }*/
    void Update()
    {
        aceleration = new Vector3(Input.acceleration.x, Input.acceleration.y, Input.acceleration.z);
        text1.text =  "X: " + aceleration.x.ToString();
        text2.text =  "Y: " + aceleration.y.ToString();
        text3.text =  "Z: " + aceleration.z.ToString();

        if (Mathf.Abs(aceleration.x) > 0.05f && Mathf.Abs(aceleration.z) > 0.05f)
        {
            Vector3 movimiento = (this.transform.forward * velocidad * aceleration.x + this.transform.right * velocidad2 * aceleration.z) * Time.deltaTime;
            this.transform.position += movimiento;
        }
    }

    /*private bool EnableGyro() 
    {
        if (SystemInfo.supportsGyroscope) 
        {
            gyroscope = Input.gyro;
            gyroscope.enabled = true;
            return true;
        }
        return false;
    }*/

}
