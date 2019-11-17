using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateBackground : MonoBehaviour
{
    public Color color1 = Color.red;
    public Color color2 = Color.blue;
    public float duration = 3.0F;
    public Camera mainCamera;


    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponent<Camera>();
        mainCamera.clearFlags = CameraClearFlags.SolidColor;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Mathf.PingPong(Time.time, duration) / duration;
        mainCamera.backgroundColor = Color.Lerp(color1, color2, t);
    }
}
