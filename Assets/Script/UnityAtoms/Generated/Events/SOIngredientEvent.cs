using UnityEngine;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `IvoKitchen.SOIngredient`. Inherits from `AtomEvent&lt;IvoKitchen.SOIngredient&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/SOIngredient", fileName = "SOIngredientEvent")]
    public sealed class SOIngredientEvent : AtomEvent<IvoKitchen.SOIngredient>
    {
    }
}
