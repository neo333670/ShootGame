using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject m_canvas;
    CharecterControl player;

    [SerializeField] GameObject m_Enemy;

    [SerializeField] GameObject wall;

    // Start is called before the first frame update
    void Start()
    {
        m_canvas = GameObject.Find("Canvas").gameObject;
        player = GameObject.Find("PlayerDuck").GetComponent<CharecterControl>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame() {
        m_canvas.SetActive(false);
        player.isStart = true;
        EnemySpawn();
    }

    void EnemySpawn() {
        Instantiate(m_Enemy, new Vector3(0, 2, 9), new Quaternion());
    }
}
