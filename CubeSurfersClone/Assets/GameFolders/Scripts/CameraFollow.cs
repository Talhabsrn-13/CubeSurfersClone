using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject _targetObject;
    [SerializeField] Vector3 _offset;

    // Update is called once per frame
    private void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, _targetObject.transform.position + _offset, Time.deltaTime);

    }
}
