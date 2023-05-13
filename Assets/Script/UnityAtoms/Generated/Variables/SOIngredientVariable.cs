using UnityEngine;
using System;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `IvoKitchen.SOIngredient`. Inherits from `AtomVariable&lt;IvoKitchen.SOIngredient, SOIngredientPair, SOIngredientEvent, SOIngredientPairEvent, SOIngredientSOIngredientFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/SOIngredient", fileName = "SOIngredientVariable")]
    public sealed class SOIngredientVariable : AtomVariable<IvoKitchen.SOIngredient, SOIngredientPair, SOIngredientEvent, SOIngredientPairEvent, SOIngredientSOIngredientFunction>
    {
        protected override bool ValueEquals(IvoKitchen.SOIngredient other)
        {
            throw new NotImplementedException();
        }
    }
}
