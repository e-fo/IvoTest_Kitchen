using UnityEngine;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `IvoKitchen.SOIngredient`. Inherits from `AtomEventInstancer&lt;IvoKitchen.SOIngredient, SOIngredientEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/SOIngredient Event Instancer")]
    public class SOIngredientEventInstancer : AtomEventInstancer<IvoKitchen.SOIngredient, SOIngredientEvent> { }
}
