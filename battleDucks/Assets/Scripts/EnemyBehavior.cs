using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{

    [SerializeField]
    GameObject m_Bullet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Detect(Vector3 L_cornerPos, Vector3 R_cornerPos, GameObject player)
    {
        Vector3 L_Sight = L_cornerPos - this.transform.position;
        Vector3 R_Sight = R_cornerPos - this.transform.position;
        Vector3 toPlayer = player.transform.position - this.transform.position;

        float L_slope = L_Sight.z / L_Sight.x;
        float R_slope = R_Sight.z / R_Sight.x;
        float toPlayer_slope = toPlayer.z / toPlayer.x;        
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(m_Bullet, transform.position, this.transform.rotation);
        }
    }
}