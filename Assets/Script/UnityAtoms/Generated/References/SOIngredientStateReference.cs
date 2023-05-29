using System;
using UnityAtoms.BaseAtoms;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `IvoKitchen.SOIngredientState`. Inherits from `AtomReference&lt;IvoKitchen.SOIngredientState, SOIngredientStatePair, SOIngredientStateConstant, SOIngredientStateVariable, SOIngredientStateEvent, SOIngredientStatePairEvent, SOIngredientStateSOIngredientStateFunction, SOIngredientStateVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SOIngredientStateReference : AtomReference<
        IvoKitchen.SOIngredientState,
        SOIngredientStatePair,
        SOIngredientStateConstant,
        SOIngredientStateVariable,
        SOIngredientStateEvent,
        SOIngredientStatePairEvent,
        SOIngredientStateSOIngredientStateFunction,
        SOIngredientStateVariableInstancer>, IEquatable<SOIngredientStateReference>
    {
        public SOIngredientStateReference() : base() { }
        public SOIngredientStateReference(IvoKitchen.SOIngredientState value) : base(value) { }
        public bool Equals(SOIngredientStateReference other) { return base.Equals(other); }
        protected override bool ValueEquals(IvoKitchen.SOIngredientState other)
        {
            throw new NotImplementedException();
        }
    }
}
