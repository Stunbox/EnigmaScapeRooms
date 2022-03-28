using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMov : MonoBehaviour
{
    [Header("Objects")]
    [SerializeField] private GameObject _camera;
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;

    [Header("Lerp options")]
    [SerializeField] private float lerpDuration = 5f;

    float timeElapsed;
    void Update()
    {
        if (timeElapsed <= lerpDuration)
        {
            LerpWithVector();
            timeElapsed += Time.deltaTime;
        }
    }

    private void OnEnable()
    {

    }
    private void LerpWithVector()
    {
        Vector3 lerpValue = Vector3.Lerp(_startPoint.position, _endPoint.position, EaseOut(timeElapsed / lerpDuration));
        _camera.transform.position = lerpValue;
    }
    void OnDisable()
    {
        timeElapsed = 0f;
        _camera.transform.position = _startPoint.position;
    }
    static float Flip(float x)
    {
        return 1 - x;
    }
    private float EaseIn(float t)
    {
        return t * t * t;
    }
    public static float EaseOut(float t)
    {
        return Flip((Flip(t)) * (Flip(t)));
    }
}
