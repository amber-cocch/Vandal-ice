using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldOfView : MonoBehaviour
{
    //taken from untiy API https://docs.unity3d.com/ScriptReference/Vector3.Angle.html
    public Transform target;
    void Update()
    {
        Vector3 targetDir = target.position - transform.position;
        Vector3 down = transform.up * -1.0f;
        float angle = Vector3.Angle(targetDir, down);
        if (angle < 5.0F)
        {
            target.position = new Vector3(-0.603f, 0.0f, 0.0f);
        }
    }
}
