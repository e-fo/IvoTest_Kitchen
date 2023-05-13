using UnityEngine;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `SOIngredientPair`. Inherits from `AtomEvent&lt;SOIngredientPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/SOIngredientPair", fileName = "SOIngredientPairEvent")]
    public sealed class SOIngredientPairEvent : AtomEvent<SOIngredientPair>
    {
    }
}
