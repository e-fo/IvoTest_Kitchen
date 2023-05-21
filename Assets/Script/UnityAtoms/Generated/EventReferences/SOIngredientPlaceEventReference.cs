using System;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `IvoKitchen.SOIngredientPlace`. Inherits from `AtomEventReference&lt;IvoKitchen.SOIngredientPlace, SOIngredientPlaceVariable, SOIngredientPlaceEvent, SOIngredientPlaceVariableInstancer, SOIngredientPlaceEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SOIngredientPlaceEventReference : AtomEventReference<
        IvoKitchen.SOIngredientPlace,
        SOIngredientPlaceVariable,
        SOIngredientPlaceEvent,
        SOIngredientPlaceVariableInstancer,
        SOIngredientPlaceEventInstancer>, IGetEvent 
    { }
}
