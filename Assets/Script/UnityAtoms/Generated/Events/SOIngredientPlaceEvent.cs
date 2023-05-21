using UnityEngine;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `IvoKitchen.SOIngredientPlace`. Inherits from `AtomEvent&lt;IvoKitchen.SOIngredientPlace&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/SOIngredientPlace", fileName = "SOIngredientPlaceEvent")]
    public sealed class SOIngredientPlaceEvent : AtomEvent<IvoKitchen.SOIngredientPlace>
    {
    }
}
