using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleLamp : MonoBehaviour
{
    public Light lampLight; // Reference to the Light component

    // Action for toggling light
    private InputAction toggleLightAction;

    private void OnEnable()
    {
        // Create a new Input Action
        toggleLightAction = new InputAction("ToggleLight", binding: "<Keyboard>/e");
        toggleLightAction.Enable();
        
        // Bind the action to a method
        toggleLightAction.performed += ToggleLight;
    }

    private void OnDisable()
    {
        toggleLightAction.Disable();
    }

    private void ToggleLight(InputAction.CallbackContext context)
    {
        if (lampLight != null)
        {
            lampLight.enabled = !lampLight.enabled;
        }
    }
}
