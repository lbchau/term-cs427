using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameObject;
    public bool active;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setItem(bool active)
    {
        gameObject.SetActive(active);
    }
}
