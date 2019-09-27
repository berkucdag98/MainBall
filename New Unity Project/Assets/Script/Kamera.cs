using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    public Transform m_Player;

    void Start()
    {
        m_Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        transform.position = new Vector3(m_Player.position.x, m_Player.position.y, -10);
    }
}
