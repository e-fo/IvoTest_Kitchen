using UnityEngine;
using UnityAtoms.BaseAtoms;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `IvoKitchen.SOIngredientPlace`. Inherits from `AtomVariableInstancer&lt;SOIngredientPlaceVariable, SOIngredientPlacePair, IvoKitchen.SOIngredientPlace, SOIngredientPlaceEvent, SOIngredientPlacePairEvent, SOIngredientPlaceSOIngredientPlaceFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/SOIngredientPlace Variable Instancer")]
    public class SOIngredientPlaceVariableInstancer : AtomVariableInstancer<
        SOIngredientPlaceVariable,
        SOIngredientPlacePair,
        IvoKitchen.SOIngredientPlace,
        SOIngredientPlaceEvent,
        SOIngredientPlacePairEvent,
        SOIngredientPlaceSOIngredientPlaceFunction>
    { }
}
