using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

[SelectionBase]
[DisallowMultipleComponent]
[RequireComponent(typeof(PlayerWeaponManager))]
public sealed class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator m_Animator;
    [SerializeField] private Rig m_TwoHandedRig;

    [Space]
    [SerializeField] private Transform m_LeftIKTarget;
    [SerializeField] private Transform m_LeftIKHint;
    [SerializeField] private Transform m_RightIKTarget;
    [SerializeField] private Transform m_RightIKHint;

    private PlayerWeaponManager m_WeaponManager;

    private void Awake()
    {
        m_WeaponManager = GetComponent<PlayerWeaponManager>();
    }

    private void Update()
    {
        if (m_WeaponManager.CurrentWeapon)
        {
            m_TwoHandedRig.weight = 1f;

            m_LeftIKTarget = m_WeaponManager.CurrentWeapon.LeftIKTarget;
            m_LeftIKHint = m_WeaponManager.CurrentWeapon.LeftIKHint;
            m_RightIKTarget = m_WeaponManager.CurrentWeapon.RightIKTarget;
            m_RightIKHint = m_WeaponManager.CurrentWeapon.RightIKHint;
        }
        else
        {
            m_TwoHandedRig.weight = 0f;
        }
    }
}
