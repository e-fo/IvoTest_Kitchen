using UnityEngine;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `IvoKitchen.SOIngredientState`. Inherits from `AtomEventInstancer&lt;IvoKitchen.SOIngredientState, SOIngredientStateEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/SOIngredientState Event Instancer")]
    public class SOIngredientStateEventInstancer : AtomEventInstancer<IvoKitchen.SOIngredientState, SOIngredientStateEvent> { }
}
