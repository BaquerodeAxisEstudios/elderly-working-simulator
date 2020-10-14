using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantallaPc : MonoBehaviour
{
    public bool encendido;
    public GameObject canvasPantallaPc;

    public void ControlEnergiaPantalla( bool en)
    {
        canvasPantallaPc.SetActive(en);

        encendido = en;
    }

}
