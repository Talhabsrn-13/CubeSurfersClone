using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCube : MonoBehaviour
{
    private bool _isCollect;
    private int _index;
    [SerializeField] PickerCube _picker;
    public int Index 
    {
        get
        {
            return _index;
        }
        set
        {
            _index = value;
        }
    }
    public bool IsCollect => _isCollect;
    void Start()
    {
        _isCollect = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Collect()
    {
        _isCollect = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacles")
        {
            GetComponent<BoxCollider>().enabled = false;
            other.GetComponent<BoxCollider>().enabled = false;

            _picker.DecreaseHeight();
            transform.parent = null;

        }
    }
}
