using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{

    [SerializeField]
    GameObject m_Bullet;

    RaycastHit hit;
    Vector3 detectDirection;

    public float sightDistance;
    public int oneTrurnSecond = 5;

    // Start is called before the first frame update
    void Start()
    {
        detectDirection = new Vector3();
        sightDistance = 10f;
        Debug.Log(transform.localEulerAngles);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localEulerAngles = Vector3.Lerp(transform.localEulerAngles, Vector3.up * 90, Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.T)) {
            SeeArownd();
        }
        Detect();
    }

    void Detect()
    {
        detectDirection = this.transform.forward;
        Physics.Raycast(this.transform.position, detectDirection, out hit, sightDistance);
        /**
        if (hit.transform.gameObject.tag == "Player") {
            Debug.Log("HIto");
            Shoot();
        }**/

        Debug.DrawRay(this.transform.position, detectDirection * sightDistance, Color.red);
    }

    void SeeArownd() {
            this.transform.localEulerAngles = Vector3.Lerp(transform.localEulerAngles, Vector3.up * 90, 3);
            this.transform.localEulerAngles = Vector3.Lerp(Vector3.up * 90, -Vector3.up * 180, 6);
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(m_Bullet, transform.position, this.transform.rotation);
        }
    }
}