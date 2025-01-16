// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

// Vive namespace s
using VIVE.OpenXR.CompositionLayer;
using VIVE.OpenXR.Passthrough;
// using VIVE.OpenXR.Samples;

namespace com.HTC.Common
{

    public class Passthrough : MonoBehaviour
    {
        //vive passthru settings
        private VIVE.OpenXR.Passthrough.XrPassthroughHTC activePassthroughID;
        private LayerType currentActiveLayerType = LayerType.Underlay;

        void Start()
        {
            PassthroughAPI.SetPassthroughLayerType(activePassthroughID, LayerType.Underlay);
            currentActiveLayerType = LayerType.Underlay;
            PassthroughAPI.CreatePlanarPassthrough(out activePassthroughID, currentActiveLayerType, OnDestroyPassthroughFeatureSession);
        }

        // Update is called once per frame
        void Update()
        {
            if(Time.realtimeSinceStartup > 10)
            {
                PassthroughAPI.DestroyPassthrough(activePassthroughID);
                activePassthroughID = 0;
            }
        }

        void OnDestroyPassthroughFeatureSession(VIVE.OpenXR.Passthrough.XrPassthroughHTC passthroughID)
        {
            PassthroughAPI.DestroyPassthrough(passthroughID);
            activePassthroughID = 0;
        }
    }
}