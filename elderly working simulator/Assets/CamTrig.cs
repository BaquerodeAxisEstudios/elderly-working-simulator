using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class CamTrig : MonoBehaviour
{
    public int indice;
    public BoxCollider[] collidersDesactive;

    public BoxCollider[] collidersActivar;
    private void OnMouseDown()
    {
        MyGameManager.main.CambiarPosCamera(indice);
        for (int i = 0; i < collidersDesactive.Length; i++)
        {
            collidersDesactive[i].enabled = false;
        }
        for (int i = 0; i < collidersActivar.Length; i++)
        {
            collidersActivar[i].enabled = true;
        }   
    }
}
