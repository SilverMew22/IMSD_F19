using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class lerp_sphere : MonoBehaviour
{
    public Vector3 A;
    public Vector3 B;
    float timer;
    bool fwdOrBack;
    public float normalizedTime;
    [Range(0.00f, 1.00f)] public float slider;
    void Start()
    {
        timer = 0;
    }
    void Update()
    {
        if (timer >= 1)
            fwdOrBack = false;
        if (timer <= 0)
            fwdOrBack = true;
        if (fwdOrBack)
            timer += Time.deltaTime / normalizedTime;
        else
            timer -= Time.deltaTime / normalizedTime;
        transform.position = Vector3.Lerp(A, B, timer);
    }
    //Vector3 LerpBetweenPositions(Vector3 posA, Vector3 posB, float t)
    //{
    //    //outputValue = (B - A) * t + A
    //    Vector3 answer = new Vector3();
    //    //answer.x = (posB.x - posA.x) * t + posA.x;
    //    //answer.y = (posB.y - posA.y) * t + posA.y;
    //    //answer.z = (posB.z - posA.z) * t + posA.z;
    //    answer = (posB - posA) * t + posA;
    //    return answer;
    //}
}