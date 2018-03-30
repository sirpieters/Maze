using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private CharacterController m_charCont; // With this function you can move the player

    float m_horizontal; // This is an variable
    float m_vertical; // This is an variable

    public float PlayerSpeed = 0.3f; // With this function you see the speed of the player

    void Start()
    {
        m_charCont = GetComponent<CharacterController>(); // Here you set the character controler you have named in rule 8
    }

    void Update()
    {
        m_horizontal = Input.GetAxis("Horizontal");
        m_vertical = Input.GetAxis("Vertical");

        Vector3 m_playerMovement = new Vector3(m_horizontal, 0f, m_vertical) * PlayerSpeed;

        m_charCont.Move(m_playerMovement); // This is moving the player
    }
}