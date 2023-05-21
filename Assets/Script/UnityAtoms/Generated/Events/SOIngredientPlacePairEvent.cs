using UnityEngine;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `SOIngredientPlacePair`. Inherits from `AtomEvent&lt;SOIngredientPlacePair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/SOIngredientPlacePair", fileName = "SOIngredientPlacePairEvent")]
    public sealed class SOIngredientPlacePairEvent : AtomEvent<SOIngredientPlacePair>
    {
    }
}
