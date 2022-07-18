using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.ARFoundation;


[RequireComponent(typeof(ARPlaneManager))]

public class AREXperienceMnager : MonoBehaviour
{
    [SerializeField]
    private UnityEvent OnInitilized;
    [SerializeField]
    private UnityEvent OnRestarted;

    private ARPlaneManager planeManager;
    private bool Initilized { get; set; }

    private void Awake()
    {
        planeManager = GetComponent<ARPlaneManager>();
        planeManager.planesChanged += PlanesChanged;

        #if UNITY_EDITOR
            OnInitilized?.Invoke();
            Initilized = true;
            planeManager.enabled = false;
        #endif
    }

    void PlanesChanged(ARPlanesChangedEventArgs args)
    {
        if (!Initilized)
        {
            Activate();
        }
    }

    void Activate()
    {
        OnInitilized?.Invoke();
        Initilized = true;
        planeManager.enabled = false;
    }

    public void Restart()
    {
        OnRestarted?.Invoke();
        Initilized = false;
        planeManager.enabled = true;
    }

}
