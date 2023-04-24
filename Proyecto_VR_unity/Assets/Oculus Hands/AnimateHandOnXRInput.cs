
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnXRInput : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;
    public Animator handAnimator;

    void Update()
    {
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger",triggerValue);
        
        float gripValue = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip",gripValue);
    }
}
