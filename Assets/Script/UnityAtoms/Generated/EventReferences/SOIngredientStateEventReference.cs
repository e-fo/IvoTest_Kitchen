using System;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `IvoKitchen.SOIngredientState`. Inherits from `AtomEventReference&lt;IvoKitchen.SOIngredientState, SOIngredientStateVariable, SOIngredientStateEvent, SOIngredientStateVariableInstancer, SOIngredientStateEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SOIngredientStateEventReference : AtomEventReference<
        IvoKitchen.SOIngredientState,
        SOIngredientStateVariable,
        SOIngredientStateEvent,
        SOIngredientStateVariableInstancer,
        SOIngredientStateEventInstancer>, IGetEvent 
    { }
}
