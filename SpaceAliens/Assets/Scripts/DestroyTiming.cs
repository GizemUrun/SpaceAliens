using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTiming : MonoBehaviour
{
    [SerializeField] float destroyTime = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObject", destroyTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
}
