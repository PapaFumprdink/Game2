using System;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
[DisallowMultipleComponent]
[RequireComponent(typeof(PlayerInput))]
public sealed class PlayerWeaponManager : MonoBehaviour
{
    [SerializeField] private Transform m_WeaponContainer;
    [SerializeField] private Transform m_LookContainer;
    [SerializeField] private float m_ThrowForce;
    [SerializeField] private float m_PickupRange;

    public PlayerInput Input { get; private set; }
    public Weapon CurrentWeapon { get; set; }
    public Transform WeaponContainer => m_WeaponContainer;

    private void Awake()
    {
        Input = GetComponent<PlayerInput>();
    }

    private void Start()
    {
        Input.Controls.General.Throw.performed += (ctx) => PickupThrowWeapon();
    }

    private void PickupThrowWeapon()
    {
        if (CurrentWeapon)
        {
            CurrentWeapon.Throw(Input.LookVector.normalized * m_ThrowForce);
        }
        else
        {
            Collider2D[] queriesInRange = Physics2D.OverlapCircleAll(transform.position, m_PickupRange);
            foreach (Collider2D query in queriesInRange)
            {
                if (query)
                {
                    if (query.gameObject.TryGetComponent(out Weapon weapon))
                    {
                        weapon.Pickup(this);
                        return;
                    }
                }
            }
        }
    }

    private void Update()
    {
        Vector2 lookDirection = Input.LookVector.normalized;
        float rotation = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        m_LookContainer.rotation = Quaternion.Euler(0f, 0f, rotation);
    }
}
