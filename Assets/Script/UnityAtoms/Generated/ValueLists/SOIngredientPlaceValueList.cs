using UnityEngine;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `IvoKitchen.SOIngredientPlace`. Inherits from `AtomValueList&lt;IvoKitchen.SOIngredientPlace, SOIngredientPlaceEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/SOIngredientPlace", fileName = "SOIngredientPlaceValueList")]
    public sealed class SOIngredientPlaceValueList : AtomValueList<IvoKitchen.SOIngredientPlace, SOIngredientPlaceEvent, IntEvent> { }
}
