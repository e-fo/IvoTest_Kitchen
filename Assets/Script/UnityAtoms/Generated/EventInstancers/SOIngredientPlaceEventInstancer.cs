using UnityEngine;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `IvoKitchen.SOIngredientPlace`. Inherits from `AtomEventInstancer&lt;IvoKitchen.SOIngredientPlace, SOIngredientPlaceEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/SOIngredientPlace Event Instancer")]
    public class SOIngredientPlaceEventInstancer : AtomEventInstancer<IvoKitchen.SOIngredientPlace, SOIngredientPlaceEvent> { }
}
