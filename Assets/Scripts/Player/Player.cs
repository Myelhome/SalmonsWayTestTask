using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] SettingsManager config;
    [SerializeField] GameInput input;

    private Camera mainCamera;
    private Rigidbody rb;

    private Vector3 lastMousePosition;
    private Vector3 moveDir;
    private Plane groundPlane = new Plane(Vector3.down, 0); 

    public Vector3 MoveDir { get => moveDir; set => moveDir = value; }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

        //cashing to maintain backwards compatibility
        mainCamera = Camera.main;
    }

    private void FixedUpdate()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        rb.AddForce(MoveDir * config.BuildSettings.PlayerSpeed * 50f, ForceMode.Force);
    }

    private void Update()
    {
        UpdateDrag();
        UpdateSpeed();
        HandleRotation();
    }

    private void UpdateDrag()
    {
        if (Physics.Raycast(transform.position + new Vector3(0, 0.1f, 0), Vector3.down, 0.2f, config.BuildSettings.GroundLayer))
        {
            rb.drag = config.BuildSettings.PlayerGroundDrag;
        }
        else
        {
            rb.drag = 0;
        }
    }

    private void UpdateSpeed()
    {
        var flatVelocty = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if (flatVelocty.magnitude > config.BuildSettings.PlayerSpeed)
        {
            Vector3 limitedVelocity = flatVelocty.normalized * config.BuildSettings.PlayerSpeed;
            rb.velocity = new Vector3(limitedVelocity.x, rb.velocity.y, limitedVelocity.z);
        }
    }

    private void HandleRotation()
    {
        var mousePosition = Input.mousePosition;
        if (IsOnScreen(mousePosition)) lastMousePosition = mousePosition;

        var ray = mainCamera.ScreenPointToRay(lastMousePosition);

        if(groundPlane.Raycast(ray, out float distance))
        {
            var lookDirection = ray.GetPoint(distance) - transform.position;
            lookDirection.y = 0;

            //using slerp for smoth rotation
            transform.forward = Vector3.Slerp(transform.forward, lookDirection, Time.deltaTime * config.BuildSettings.PlayerRotationSpeed);
        }
    }

    private bool IsOnScreen(Vector3 mousePosition)
    {
        return mousePosition.x <= Screen.width && mousePosition.x >= 0 && mousePosition.y <= Screen.height && mousePosition.y >= 0;
    }

    public bool IsWalking()
    {
        return MoveDir != Vector3.zero;
    }
}
