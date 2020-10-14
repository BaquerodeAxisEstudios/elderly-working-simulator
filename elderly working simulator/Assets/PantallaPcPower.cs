using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantallaPcPower : MonoBehaviour
{
    public PantallaPc pantallaPc;

    public int indice;
    public BoxCollider miCollider;

    public BoxCollider[] otrosColliders;
    private void OnMouseDown()
    {
        if (pantallaPc.encenido)
        {
            MyGameManager.main.CambiarPosCamera(indice);
            miCollider.enabled = false;
            for (int i = 0; i < otrosColliders.Length; i++)
            {
                otrosColliders[i].enabled = true;
            }
        }

        //casjnjca
    }
}
