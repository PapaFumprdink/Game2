using UnityEngine;

[SelectionBase]
[DisallowMultipleComponent]
[RequireComponent(typeof(PlayerWeaponManager))]
[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(Rigidbody2D))]
public sealed class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Transform m_SpriteTransform;
    [SerializeField] private float m_MovementSway;

    [Space]
    [SerializeField] private AnimationCurve m_CrouchAnimationCurve;
    [SerializeField] private float m_CrouchAnimationSpeed;

    private Rigidbody2D m_Rigidbody;
    private PlayerMovement m_Movement;
    private PlayerWeaponManager m_WeaponManager;

    private float m_CrouchPercent;

    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        m_Movement = GetComponent<PlayerMovement>();
        m_WeaponManager = GetComponent<PlayerWeaponManager>();
    }

    private void LateUpdate()
    {
        m_SpriteTransform.rotation = Quaternion.Euler(0f, 0f, m_Rigidbody.velocity.x * m_MovementSway);

        m_CrouchPercent = Mathf.Clamp01(m_CrouchPercent + Time.deltaTime / (m_Movement.IsSliding ? m_CrouchAnimationSpeed : -m_CrouchAnimationSpeed));
        m_SpriteTransform.localScale = new Vector3(1f / m_CrouchAnimationCurve.Evaluate(m_CrouchPercent), m_CrouchAnimationCurve.Evaluate(m_CrouchPercent), 1f);
    }
}
