using UnityEngine;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `IvoKitchen.SOIngredientState`. Inherits from `AtomValueList&lt;IvoKitchen.SOIngredientState, SOIngredientStateEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/SOIngredientState", fileName = "SOIngredientStateValueList")]
    public sealed class SOIngredientStateValueList : AtomValueList<IvoKitchen.SOIngredientState, SOIngredientStateEvent, IntEvent> { }
}
