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

    public SwitchControl switchControlReference;
    public ButtonControl buttonControlReference;

    void Update()
    {
        if (switchControlReference.controls.Equals(Control.acelerometer))
        {
            Debug.Log("usando acelerometro");
            acelerometerControl();
        }
        if (switchControlReference.controls.Equals(Control.arrows)) 
        {
            Debug.Log("usando arrows");
            ArrowsControl();
        }
    }
    public void acelerometerControl()
    {
        aceleration = new Vector3(Input.acceleration.x, Input.acceleration.y, Input.acceleration.z);
        text1.text = "X: " + aceleration.x.ToString();
        text2.text = "Y: " + aceleration.y.ToString();
        text3.text = "Z: " + aceleration.z.ToString();

        if (Mathf.Abs(aceleration.x) > 0.05f && Mathf.Abs(aceleration.z) > 0.05f)
        {
            Vector3 movimiento = this.transform.right * velocidad2 * aceleration.z * Time.deltaTime;
            this.transform.position += movimiento;
        }
    }

    public void ArrowsControl()
    {
        if (buttonControlReference != null) 
        {
            int directionLnR = buttonControlReference.direction;

            Vector3 movimiento = this.transform.forward * velocidad * directionLnR * Time.deltaTime;
            this.transform.position += movimiento;
        }
    }
}
