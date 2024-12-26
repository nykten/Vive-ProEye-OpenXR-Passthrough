using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Vive namespace
using VIVE.OpenXR.Passthrough;
using VIVE.OpenXR.Samples;
namespace VIVE.OpenXR.CompositionLayer.Samples.Passthrough
{

public class Passthrough : MonoBehaviour
{
    int ID;

    void Start()
    {
        ID = PassthroughAPI.CreatePlanarPassthrough(LayerType.Underlay);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.realtimeSinceStartup > 10)
        {
            PassthroughAPI.DestroyPassthrough(ID);
        }
    }
}
}