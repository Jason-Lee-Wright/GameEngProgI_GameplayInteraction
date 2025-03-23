using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObjects : MonoBehaviour
{
    public enum InteractionType
    {
        Nothing,
        Pickup,
        Info,
        Dialogue
    }

    [Header("Type of Interactable")]
    public InteractionType interType; // Creates a drop-down for selecting the interaction type

    public void Interact()
    {
        Debug.Log("Interacting with object " + gameObject.name);
    }

    public void Nothing()
    {
        Debug.Log("Interaction type not defined for " + gameObject.name);
    }

    public void Pickup()
    {
        Debug.Log("Picking up object: " + gameObject.name);
        // Add pickup logic here (e.g., adding to inventory, disabling object, etc.)
    }

    public void Info()
    {
        Debug.Log("Displaying info message on object: " + gameObject.name);
        // Add logic to display UI info or a message
    }

    public void Dialogue()
    {
        Debug.Log("Starting dialogue with: " + gameObject.name);
        // Add dialogue system logic here
    }
}
