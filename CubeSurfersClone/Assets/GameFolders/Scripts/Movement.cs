using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float _horizontalSpeed;
    [SerializeField] float _verticalSpeed;
    [SerializeField] float _horizontalRange;



    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * _horizontalSpeed * Time.deltaTime;
        this.transform.Translate(horizontal, 0, _verticalSpeed * Time.deltaTime);
        this.transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z, -_horizontalRange, _horizontalRange));
    }
}
