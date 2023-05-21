using UnityEngine;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `IvoKitchen.SOIngredientPlace`. Inherits from `AtomEventReferenceListener&lt;IvoKitchen.SOIngredientPlace, SOIngredientPlaceEvent, SOIngredientPlaceEventReference, SOIngredientPlaceUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SOIngredientPlace Event Reference Listener")]
    public sealed class SOIngredientPlaceEventReferenceListener : AtomEventReferenceListener<
        IvoKitchen.SOIngredientPlace,
        SOIngredientPlaceEvent,
        SOIngredientPlaceEventReference,
        SOIngredientPlaceUnityEvent>
    { }
}
