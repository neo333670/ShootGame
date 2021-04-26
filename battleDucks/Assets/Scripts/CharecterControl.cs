using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharecterControl : MonoBehaviour
{
    public bool isStart;
    
    public float walkSpeed;
    public float shootForce = 10f;

    [SerializeField]
    GameObject m_Bullet;

    GameObject m_camera;
    Vector3 moveDirection;

    private void Start()
    {
        isStart = false;
        
        walkSpeed = 1;

        m_camera = GameObject.Find("Main Camera");
    }

    void Update()
    {
        if (isStart) {
            Move();
            MoveHead();
            Shoot();
        }
    }

    void Move() {
        moveDirection = Vector3.zero;
        if (Input.GetKey(KeyCode.W)) {
            moveDirection += this.transform.forward * Time.fixedDeltaTime *walkSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection -= this.transform.forward * Time.fixedDeltaTime * walkSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection -= this.transform.right * Time.fixedDeltaTime * walkSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += this.transform.right * Time.fixedDeltaTime * walkSpeed;
        }
        Vector3 moveWithoutZ = new Vector3(moveDirection.x, 0, moveDirection.z);
        transform.position += moveWithoutZ;
    }

    void MoveHead() {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY= Input.GetAxis("Mouse Y");

        this.transform.Rotate(Vector3.up * mouseX);
        this.transform.Rotate(Vector3.left * mouseY);
    }

    void Shoot() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(m_Bullet, transform.position, this.transform.rotation);
            //var m_Bullet_rig = m_Bullet.GetComponent<Rigidbody>();
            //m_Bullet_rig.velocity = this.transform.forward *Time.fixedDeltaTime * 5f;
        }
    }
}
