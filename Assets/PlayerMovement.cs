using System;
using UnityEngine;

[SelectionBase]
[DisallowMultipleComponent]
[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(Rigidbody2D))]
public sealed class PlayerMovement : MonoBehaviour
{
    private const float InputDeadzone = 0.1f;
    [SerializeField] private float m_MovementSpeed;
    [SerializeField] private float m_GroundedAccelerationTime;
    [SerializeField] private float m_AirAccelerationTime;

    [Space]
    [SerializeField] private float m_JumpPower;
    [SerializeField] private int m_MaxAirJumps;
    [SerializeField] private Transform m_GroundCheckPoint;
    [SerializeField] private float m_GroundCheckRadius;
    [SerializeField] private LayerMask m_GroundCheckMask;

    [Space]
    [SerializeField] private float m_DownGravity;
    [SerializeField] private float m_UpGravity;

    private PlayerInput m_Input;
    private Rigidbody2D m_Rigidbody;

    private int m_CurrentAirJumps;

    public bool IsSliding => m_Input.Controls.General.Crouch.ReadValue<float>() > InputDeadzone;

    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();

        if (TryGetComponent(out m_Input))
        {
            m_Input.Controls.General.Jump.performed += (ctx) => Jump();
        }
    }

    private void Update()
    {
        ApplyMovement();

        UpdateGravity();
        UpdateFieldsAndProperties();
    }

    private void ApplyMovement()
    {
        if (!IsSliding)
        {
            Vector2 currentVelocity = m_Rigidbody.velocity;
            Vector2 targetVelocity = m_Input.Controls.General.Movement.ReadValue<Vector2>() * m_MovementSpeed;

            float accelerationTime = GetGrounded() ? m_GroundedAccelerationTime : m_AirAccelerationTime;
            Vector2 force = Vector2.ClampMagnitude(targetVelocity - currentVelocity, m_MovementSpeed) / accelerationTime;
            m_Rigidbody.velocity += force * Time.deltaTime;
        }
    }

    private void UpdateGravity()
    {
        bool isJumpPressed = m_Input.Controls.General.Jump.ReadValue<float>() > InputDeadzone;
        m_Rigidbody.gravityScale = (m_Rigidbody.velocity.y > 0 && isJumpPressed) ? m_UpGravity : m_DownGravity;
    }

    private void UpdateFieldsAndProperties()
    {
        if (GetGrounded())
        {
            m_CurrentAirJumps = m_MaxAirJumps;
        }
    }

    private bool GetGrounded()
    {
        if (m_GroundCheckPoint)
        {
            Collider2D[] queryList = new Collider2D[2];
            Physics2D.OverlapCircleNonAlloc(m_GroundCheckPoint.position, m_GroundCheckRadius, queryList, m_GroundCheckMask);
            foreach (Collider2D query in queryList)
            {
                if (query)
                {
                    if (query.gameObject != gameObject)
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }

    private void Jump ()
    {
        if (GetGrounded())
        {
            ApplyJumpForce();
        }
        else if (m_CurrentAirJumps > 0)
        {
            ApplyJumpForce();
            m_CurrentAirJumps--;
        }
    }

    private void ApplyJumpForce()
    {
        m_Rigidbody.velocity = new Vector2(m_Rigidbody.velocity.x, m_JumpPower);
    }

    private void OnDrawGizmosSelected()
    {
        if (m_GroundCheckPoint)
        {
            Gizmos.color = GetGrounded() ? Color.green : Color.red;
            Gizmos.DrawSphere(m_GroundCheckPoint.position, m_GroundCheckRadius);
            Gizmos.color = Color.white;
        }
    }
}
