using UnityEngine;

[SelectionBase]
[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody2D))]
public abstract class Weapon : MonoBehaviour
{
    [Space]
    [SerializeField] private SpriteRenderer m_SpriteRenderer;

    [Space]
    [SerializeField] private Transform m_LeftIKTarget;
    [SerializeField] private Transform m_LeftIKHint;
    [SerializeField] private Transform m_RightIKTarget;
    [SerializeField] private Transform m_RightIKHint;

    private Rigidbody2D m_Rigidbody;

    public PlayerWeaponManager BindedManager { get; private set; }
    public Transform LeftIKTarget => m_LeftIKTarget;
    public Transform LeftIKHint => m_LeftIKHint;
    public Transform RightIKTarget => m_RightIKTarget;
    public Transform RightIKHint => m_RightIKHint;

    protected virtual void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    protected virtual void Start()
    {
        PlayerWeaponManager manager = GetComponentInParent<PlayerWeaponManager>();
        if (manager)
        {
            Pickup(manager);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 45f);
        }
    }

    protected virtual void Update()
    {
        m_SpriteRenderer.flipY = transform.right.x < 0;
    }

    public void Pickup (PlayerWeaponManager manager)
    {
        manager.CurrentWeapon = this;

        transform.parent = manager.WeaponContainer;
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;

        m_Rigidbody.simulated = false;

        BindedManager = manager;

        BindInputs();
    }

    public void Throw (Vector2 throwForce)
    {
        BindedManager.CurrentWeapon = null;

        transform.parent = null;
        transform.rotation = Quaternion.Euler(0f, 0f, 45f);

        m_Rigidbody.simulated = true;
        m_Rigidbody.velocity = throwForce / m_Rigidbody.mass;

        UnbindInputs();

        BindedManager = null;
    }

    public abstract void BindInputs();
    public abstract void UnbindInputs();
}
