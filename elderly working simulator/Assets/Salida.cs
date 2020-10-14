using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Salida : MonoBehaviour
{
    public GameObject confirmacion;
    public Button confirmBtn;
    public Button escBtn;

    public float timeAct = 2f;
    private void OnMouseDown()
    {

        Invoke("ActivarPanel", timeAct);

        confirmBtn.onClick.RemoveAllListeners();
        confirmBtn.onClick.AddListener(Salir);

        escBtn.onClick.RemoveAllListeners();
        escBtn.onClick.AddListener(Esc);
    }

    void ActivarPanel()
    {
        confirmacion.SetActive(true);
    }
    void Salir()
    {
        Application.Quit();
    }
    void Esc()
    {
        confirmacion.SetActive(false);
    }
}
