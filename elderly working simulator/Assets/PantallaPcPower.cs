using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantallaPcPower : MonoBehaviour
{
    public PantallaPc pantallaPc;
    
    private void OnMouseDown()
    {
        if (pantallaPc.encendido)
        {
            pantallaPc.ControlEnergiaPantalla(false);
        }
        else
        {
            pantallaPc.ControlEnergiaPantalla(true);
        }
    }
}
