using UnityEngine;
using UnityAtoms.BaseAtoms;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `IvoKitchen.SOIngredient`. Inherits from `AtomVariableInstancer&lt;SOIngredientVariable, SOIngredientPair, IvoKitchen.SOIngredient, SOIngredientEvent, SOIngredientPairEvent, SOIngredientSOIngredientFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/SOIngredient Variable Instancer")]
    public class SOIngredientVariableInstancer : AtomVariableInstancer<
        SOIngredientVariable,
        SOIngredientPair,
        IvoKitchen.SOIngredient,
        SOIngredientEvent,
        SOIngredientPairEvent,
        SOIngredientSOIngredientFunction>
    { }
}
