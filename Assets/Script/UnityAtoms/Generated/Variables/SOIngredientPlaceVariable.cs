using UnityEngine;
using System;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `IvoKitchen.SOIngredientPlace`. Inherits from `AtomVariable&lt;IvoKitchen.SOIngredientPlace, SOIngredientPlacePair, SOIngredientPlaceEvent, SOIngredientPlacePairEvent, SOIngredientPlaceSOIngredientPlaceFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/SOIngredientPlace", fileName = "SOIngredientPlaceVariable")]
    public sealed class SOIngredientPlaceVariable : AtomVariable<IvoKitchen.SOIngredientPlace, SOIngredientPlacePair, SOIngredientPlaceEvent, SOIngredientPlacePairEvent, SOIngredientPlaceSOIngredientPlaceFunction>
    {
        protected override bool ValueEquals(IvoKitchen.SOIngredientPlace other)
        {
            throw new NotImplementedException();
        }
    }
}
