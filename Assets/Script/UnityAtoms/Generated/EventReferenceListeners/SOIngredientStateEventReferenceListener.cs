using UnityEngine;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `IvoKitchen.SOIngredientState`. Inherits from `AtomEventReferenceListener&lt;IvoKitchen.SOIngredientState, SOIngredientStateEvent, SOIngredientStateEventReference, SOIngredientStateUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SOIngredientState Event Reference Listener")]
    public sealed class SOIngredientStateEventReferenceListener : AtomEventReferenceListener<
        IvoKitchen.SOIngredientState,
        SOIngredientStateEvent,
        SOIngredientStateEventReference,
        SOIngredientStateUnityEvent>
    { }
}
