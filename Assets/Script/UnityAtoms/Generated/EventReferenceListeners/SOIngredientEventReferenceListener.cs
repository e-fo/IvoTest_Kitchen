using UnityEngine;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `IvoKitchen.SOIngredient`. Inherits from `AtomEventReferenceListener&lt;IvoKitchen.SOIngredient, SOIngredientEvent, SOIngredientEventReference, SOIngredientUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SOIngredient Event Reference Listener")]
    public sealed class SOIngredientEventReferenceListener : AtomEventReferenceListener<
        IvoKitchen.SOIngredient,
        SOIngredientEvent,
        SOIngredientEventReference,
        SOIngredientUnityEvent>
    { }
}
