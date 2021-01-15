using UnityEngine;

public class FirstPersonLook : MonoBehaviour
{
    [SerializeField]
    Transform character;
    public FixedTouchField TouchField;
    protected float CameraAngle;
    protected float CameraAngleSpeed = 0.2f;
    void Reset()
    {
        character = GetComponentInParent<FirstPersonMovement>().transform;
    }
    void Update()
    {
        CameraAngle += TouchField.TouchDist.x * CameraAngleSpeed;
        character.rotation = Quaternion.AngleAxis(CameraAngle, Vector3.up) * transform.rotation;
        CameraAngle = 0;
    }
}
