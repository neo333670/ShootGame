using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject m_canvas;
    CharecterControl player;

    [SerializeField] GameObject m_Enemy;

    [SerializeField] GameObject wall;
    GameObject LefttCorner;
    GameObject RightCorner;

    // Start is called before the first frame update
    void Start()
    {
        m_canvas = GameObject.Find("Canvas").gameObject;
        player = GameObject.Find("Character").GetComponent<CharecterControl>();
        LefttCorner = wall.transform.Find("LeftCorner").gameObject;
        RightCorner = wall.transform.Find("RightCorner").gameObject;
        EnemySpawn();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame() {
        m_canvas.SetActive(false);
        player.isStart = true;
    }

    void EnemySpawn() {
        Instantiate(m_Enemy, new Vector3(0, 2, 9), new Quaternion());
    }
}
