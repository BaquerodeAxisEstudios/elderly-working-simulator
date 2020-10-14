using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class CamTrig : MonoBehaviour
{
    public int indice;
    public BoxCollider miCollider;

    public BoxCollider[] otrosColliders;
    private void OnMouseDown()
    {
        MyGameManager.main.CambiarPosCamera(indice);
        miCollider.enabled = false;
        for (int i = 0; i < otrosColliders.Length; i++)
        {
            otrosColliders[i].enabled = true;
        }   
    }
}
