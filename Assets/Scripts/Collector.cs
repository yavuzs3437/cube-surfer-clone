using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    GameObject mainCube;
    int height;

    void Start()
    {
        mainCube = GameObject.Find("MainCube");
    }

    // Update is called once per frame
    void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x, height+1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -height, 0);
    }

    public void ReduceHeight()
    {
        height -= 1;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collect" && other.gameObject.GetComponent<CollectableCubes>().GetIsCollected() == false)
        {
            height += 1;
            other.gameObject.GetComponent<CollectableCubes>().Collected();
            other.gameObject.GetComponent<CollectableCubes>().SetIndex(height);
            other.gameObject.transform.parent = mainCube.transform;
        }
    }
}
