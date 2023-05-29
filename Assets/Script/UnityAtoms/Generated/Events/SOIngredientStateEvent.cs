using UnityEngine;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `IvoKitchen.SOIngredientState`. Inherits from `AtomEvent&lt;IvoKitchen.SOIngredientState&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/SOIngredientState", fileName = "SOIngredientStateEvent")]
    public sealed class SOIngredientStateEvent : AtomEvent<IvoKitchen.SOIngredientState>
    {
    }
}
