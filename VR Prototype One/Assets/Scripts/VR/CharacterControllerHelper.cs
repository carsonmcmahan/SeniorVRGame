using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;


public class CharacterControllerHelper : MonoBehaviour
{
    private XROrigin XROrigin;
    private CharacterController CharacterController;

    [SerializeField]
    [Tooltip("The minimum height of the character's capsule that will be set by this behavior.")]
    float m_MinHeight;
    /// <summary>
    /// The minimum height of the character's capsule that this behavior sets.
    /// </summary>
    /// <seealso cref="maxHeight"/>
    /// <seealso cref="CharacterController.height"/>
    public float minHeight
    {
        get => m_MinHeight;
        set => m_MinHeight = value;
    }

    [SerializeField]
    [Tooltip("The maximum height of the character's capsule that will be set by this behavior.")]
    float m_MaxHeight = float.PositiveInfinity;
    /// <summary>
    /// The maximum height of the character's capsule that this behavior sets.
    /// </summary>
    /// <seealso cref="minHeight"/>
    /// <seealso cref="CharacterController.height"/>
    public float maxHeight
    {
        get => m_MaxHeight;
        set => m_MaxHeight = value;
    }

    // Start is called before the first frame update
    void Start()
    {
        XROrigin = GetComponent<XROrigin>();
        CharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCharacterController();
    }

    protected virtual void UpdateCharacterController()
    {
        if (XROrigin == null || CharacterController == null)
            return;

        var height = Mathf.Clamp(XROrigin.CameraInOriginSpaceHeight, m_MinHeight, m_MaxHeight);

        Vector3 center = XROrigin.CameraInOriginSpacePos;
        center.y = height / 2f + CharacterController.skinWidth;

        CharacterController.height = height;
        CharacterController.center = center;
    }
}
