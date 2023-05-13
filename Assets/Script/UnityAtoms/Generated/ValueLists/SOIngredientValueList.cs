using UnityEngine;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `IvoKitchen.SOIngredient`. Inherits from `AtomValueList&lt;IvoKitchen.SOIngredient, SOIngredientEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/SOIngredient", fileName = "SOIngredientValueList")]
    public sealed class SOIngredientValueList : AtomValueList<IvoKitchen.SOIngredient, SOIngredientEvent, IntEvent> { }
}
