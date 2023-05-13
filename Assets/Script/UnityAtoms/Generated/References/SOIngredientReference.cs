using System;
using UnityAtoms.BaseAtoms;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `IvoKitchen.SOIngredient`. Inherits from `AtomReference&lt;IvoKitchen.SOIngredient, SOIngredientPair, SOIngredientConstant, SOIngredientVariable, SOIngredientEvent, SOIngredientPairEvent, SOIngredientSOIngredientFunction, SOIngredientVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SOIngredientReference : AtomReference<
        IvoKitchen.SOIngredient,
        SOIngredientPair,
        SOIngredientConstant,
        SOIngredientVariable,
        SOIngredientEvent,
        SOIngredientPairEvent,
        SOIngredientSOIngredientFunction,
        SOIngredientVariableInstancer>, IEquatable<SOIngredientReference>
    {
        public SOIngredientReference() : base() { }
        public SOIngredientReference(IvoKitchen.SOIngredient value) : base(value) { }
        public bool Equals(SOIngredientReference other) { return base.Equals(other); }
        protected override bool ValueEquals(IvoKitchen.SOIngredient other)
        {
            throw new NotImplementedException();
        }
    }
}
