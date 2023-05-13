using System;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `IvoKitchen.SOIngredient`. Inherits from `AtomEventReference&lt;IvoKitchen.SOIngredient, SOIngredientVariable, SOIngredientEvent, SOIngredientVariableInstancer, SOIngredientEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SOIngredientEventReference : AtomEventReference<
        IvoKitchen.SOIngredient,
        SOIngredientVariable,
        SOIngredientEvent,
        SOIngredientVariableInstancer,
        SOIngredientEventInstancer>, IGetEvent 
    { }
}
