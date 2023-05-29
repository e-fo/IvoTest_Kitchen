using UnityEngine;
using System;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `IvoKitchen.SOIngredientState`. Inherits from `AtomVariable&lt;IvoKitchen.SOIngredientState, SOIngredientStatePair, SOIngredientStateEvent, SOIngredientStatePairEvent, SOIngredientStateSOIngredientStateFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/SOIngredientState", fileName = "SOIngredientStateVariable")]
    public sealed class SOIngredientStateVariable : AtomVariable<IvoKitchen.SOIngredientState, SOIngredientStatePair, SOIngredientStateEvent, SOIngredientStatePairEvent, SOIngredientStateSOIngredientStateFunction>
    {
        protected override bool ValueEquals(IvoKitchen.SOIngredientState other)
        {
            throw new NotImplementedException();
        }
    }
}
