using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    [SerializeField] [Range(1.0f, 10.0f)] float m_jumpResistance = 3.0f;
    [SerializeField] [Range(1.0f, 10.0f)] float m_fallMultiplier = 3.0f;

    Rigidbody m_rigidbody;

    private void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (m_rigidbody.velocity.y > 0.0f)
        {
            m_rigidbody.velocity += (Vector3.up * Physics.gravity.y) * (m_jumpResistance - 1.0f) * Time.deltaTime;
        }
        else if (m_rigidbody.velocity.y < 0.0f)
        {
            m_rigidbody.velocity += (Vector3.up * Physics.gravity.y) * (m_fallMultiplier - 1.0f) * Time.deltaTime;
        }
    }
}
