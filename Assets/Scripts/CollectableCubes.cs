using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCubes : MonoBehaviour
{
    bool isCollected;
    int index;
    public Collector collector;
    void Start()
    {
        
    }

    void Update()
    {
        if(isCollected == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            collector.ReduceHeight();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    public bool GetIsCollected()
    {
        return isCollected;
    }
    public void Collected()
    {
        isCollected = true;
    }

    public void SetIndex(int index)
    {
        this.index = index;
    }
}
