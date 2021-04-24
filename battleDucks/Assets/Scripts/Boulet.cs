using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulet : MonoBehaviour
{

    public float bulletspeed = 10f;

        // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += this.transform.forward * Time.deltaTime * bulletspeed;
    }
}
