using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Teste: MonoBehaviour
{
    VirtualButtonBehaviour[] awa;

    private void Start()
    {
        awa = GetComponentsInChildren<VirtualButtonBehaviour>();
        for(int i = 0; i < awa.Length; i++)
        {
            awa[i].RegisterOnButtonPressed(OnButtonPressed);
            awa[i].RegisterOnButtonReleased(OnButtonReleased);
        }
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed");
        GameManager.Replay();
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonReleased: " + vb.VirtualButtonName);

    }
}
