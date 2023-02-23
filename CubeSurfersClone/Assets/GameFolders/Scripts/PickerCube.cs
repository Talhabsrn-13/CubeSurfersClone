using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickerCube : MonoBehaviour
{
    GameObject _mainCube;
    int _height = 0;
    private void Start()
    {
        _mainCube = GameObject.FindGameObjectWithTag("MainCube");
    }
    private void Update()
    {

        _mainCube.transform.position = new Vector3(_mainCube.transform.position.x, _height + 1, _mainCube.transform.position.z);
        this.transform.localPosition = new Vector3(0, -_height, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CollectableCube" && !other.GetComponent<CollectableCube>().IsCollect)
        {

            _height++;
            other.gameObject.GetComponent<CollectableCube>().Collect();
            other.gameObject.GetComponent<CollectableCube>().Index = _height;
            other.gameObject.transform.parent = _mainCube.transform;
            other.gameObject.transform.localPosition = new Vector3(0, -_height, 0);
        }
        if (other.gameObject.tag == "Obstacles" && _height == 0)
        {
            Time.timeScale = 0;
        }
    }
    public void DecreaseHeight()
    {
        _height--;
    }

}
