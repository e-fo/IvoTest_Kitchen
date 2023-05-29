using UnityEngine;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `SOIngredientStatePair`. Inherits from `AtomEvent&lt;SOIngredientStatePair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/SOIngredientStatePair", fileName = "SOIngredientStatePairEvent")]
    public sealed class SOIngredientStatePairEvent : AtomEvent<SOIngredientStatePair>
    {
    }
}
