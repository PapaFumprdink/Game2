using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

[SelectionBase]
[DisallowMultipleComponent]
public sealed class ProjectileGun : Weapon
{
    [SerializeField] private Projectile m_ProjectilePrefab;
    [SerializeField] private int m_ProjectilesPerShot;
    [SerializeField] private float m_Firerate;
    [SerializeField] private bool m_Singlefire;
    [SerializeField] private float m_Spray;

    [Space]
    [SerializeField] private int m_Magazine;

    [Space]
    [SerializeField] private Transform m_Muzzle;

    [Space]
    [SerializeField] private UnityEvent m_FireEvent;

    private bool m_IsFiring;
    private float m_NextFireTime;
    private GameObject m_Shooter;

    public override void BindInputs()
    {
        PlayerControls controls = BindedManager.Input.Controls;

        controls.General.Shoot.performed += ShootPerformed;
        controls.General.Shoot.canceled += ShootCanceled;
        
        ResetInputFields();

        m_Shooter = BindedManager.gameObject;
    }

    public override void UnbindInputs()
    {
        PlayerControls controls = BindedManager.Input.Controls;

        controls.General.Shoot.performed -= ShootPerformed;
        controls.General.Shoot.canceled -= ShootCanceled;

        ResetInputFields();

        m_Shooter = null;
    }

    private void ResetInputFields()
    {
        m_IsFiring = false;
    }


    private void ShootPerformed(InputAction.CallbackContext ctx) => m_IsFiring = true;
    private void ShootCanceled(InputAction.CallbackContext ctx) => m_IsFiring = false;

    protected override void Update()
    {
        base.Update();

        Shoot();
    }

    private void Shoot()
    {
        if (Time.time > m_NextFireTime && m_Magazine > 0 && m_IsFiring)
        {
            for (int i = 0; i < m_ProjectilesPerShot; i++)
            {
                Quaternion sprayFactor = Quaternion.Euler(0f, 0f, Random.Range(m_Spray / -2f, m_Spray / 2f));
                
                Projectile instance = Instantiate(m_ProjectilePrefab, m_Muzzle.position, m_Muzzle.rotation * sprayFactor);
                instance.Shooter = m_Shooter;
            }

            m_FireEvent?.Invoke();

            m_Magazine--;
            m_NextFireTime = Time.time + 60f / m_Firerate;
        }

        if (m_Singlefire) m_IsFiring = false;
    }
}
