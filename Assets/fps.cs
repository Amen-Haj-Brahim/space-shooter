using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class fps : MonoBehaviour
{
    void Start()
    {
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 144;
    }
}
