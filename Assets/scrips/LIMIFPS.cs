using UnityEngine;

public class LIMIFPS : MonoBehaviour
{
    public int limiteDeFps = 72;

    void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = limiteDeFps;
    }
}