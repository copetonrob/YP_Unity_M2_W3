using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Webinar3Task1 : MonoBehaviour
{
    public Light Light;
    public MeshRenderer MeshRenderer;

    Color _color;
    float _timer = 0;

    void Update()
    {
        _timer = _timer + Time.deltaTime;
        if (_timer > 3)
        {
            _timer = 0;
        }

        if (_timer < 1)
        {
            _color = new Color(1, 0, 0);
        }
        else if (_timer < 2)
        {
            _color = new Color(0, 1, 0);
        }
        else
        {
            _color = new Color(0, 0, 1);
        }

        Light.color = _color;
        MeshRenderer.material.SetColor("_EmissionColor", _color);
    }
}
