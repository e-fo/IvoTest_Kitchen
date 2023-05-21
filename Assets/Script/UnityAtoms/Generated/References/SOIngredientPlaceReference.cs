using System;
using UnityAtoms.BaseAtoms;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `IvoKitchen.SOIngredientPlace`. Inherits from `AtomReference&lt;IvoKitchen.SOIngredientPlace, SOIngredientPlacePair, SOIngredientPlaceConstant, SOIngredientPlaceVariable, SOIngredientPlaceEvent, SOIngredientPlacePairEvent, SOIngredientPlaceSOIngredientPlaceFunction, SOIngredientPlaceVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SOIngredientPlaceReference : AtomReference<
        IvoKitchen.SOIngredientPlace,
        SOIngredientPlacePair,
        SOIngredientPlaceConstant,
        SOIngredientPlaceVariable,
        SOIngredientPlaceEvent,
        SOIngredientPlacePairEvent,
        SOIngredientPlaceSOIngredientPlaceFunction,
        SOIngredientPlaceVariableInstancer>, IEquatable<SOIngredientPlaceReference>
    {
        public SOIngredientPlaceReference() : base() { }
        public SOIngredientPlaceReference(IvoKitchen.SOIngredientPlace value) : base(value) { }
        public bool Equals(SOIngredientPlaceReference other) { return base.Equals(other); }
        protected override bool ValueEquals(IvoKitchen.SOIngredientPlace other)
        {
            throw new NotImplementedException();
        }
    }
}
