using TMPro;
using UnityEngine;

public class FPSCounter : MonoBehaviour
{
    [SerializeField]
    private TMP_Text counter;

    private float time;

    void Start()
    {
        counter = GetComponent<TMP_Text>();
    }

    void Update()
    {
        if (time >= 0.5f)
        {
            int fps = (int)(1f / Time.unscaledDeltaTime);
            counter.text = fps.ToString();
            time = 0;
        }

        time += Time.unscaledDeltaTime;
    }
}