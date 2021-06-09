using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody2D))]
public sealed class Projectile : MonoBehaviour
{
    private const float SkinWidth = 0.1f;

    [SerializeField] private float m_MuzzleSpeed;
    [SerializeField] private float m_MaxDistance;
    [SerializeField] private LayerMask m_CollisionMask;

    private Rigidbody2D m_Rigidbody;
    private float m_DistanceTraveled;

    public GameObject Shooter { get; set; }

    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        m_Rigidbody.velocity = transform.right * m_MuzzleSpeed;
    }

    private void FixedUpdate()
    {
        float speed = m_Rigidbody.velocity.magnitude;
        RaycastHit2D hit = Physics2D.Raycast(m_Rigidbody.position, m_Rigidbody.velocity, speed * Time.deltaTime + SkinWidth, m_CollisionMask);
        if (hit)
        {
            Destroy(gameObject);
        }

        m_DistanceTraveled += speed * Time.deltaTime;
        if (m_DistanceTraveled > m_MaxDistance) Destroy(gameObject);
    }
}
