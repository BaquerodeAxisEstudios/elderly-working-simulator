using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    public static MyGameManager main;
    Camera cameraP;
    public float camVel = 10f;

    #region primitivas
    private void Awake()
    {
        main = this;
        cameraP = Camera.main;
    }
    private void Update()
    {
        if (cameraP)
        {
            cameraP.transform.position = Vector3.Slerp(cameraP.transform.position, posiciones[posCam].position, camVel * Time.deltaTime);
            cameraP.transform.rotation = Quaternion.Slerp(cameraP.transform.rotation, posiciones[posCam].rotation, camVel * Time.deltaTime);
            
        }
    }
    #endregion

    #region camara fun
    
    int posCam;
    public List<Transform> posiciones;
    
    public void CambiarPosCamera(int posI)
    {
        posCam = posI;
    }

    #endregion

    
}
