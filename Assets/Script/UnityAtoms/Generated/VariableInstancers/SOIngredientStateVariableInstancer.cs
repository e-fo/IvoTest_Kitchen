using UnityEngine;
using UnityAtoms.BaseAtoms;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `IvoKitchen.SOIngredientState`. Inherits from `AtomVariableInstancer&lt;SOIngredientStateVariable, SOIngredientStatePair, IvoKitchen.SOIngredientState, SOIngredientStateEvent, SOIngredientStatePairEvent, SOIngredientStateSOIngredientStateFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/SOIngredientState Variable Instancer")]
    public class SOIngredientStateVariableInstancer : AtomVariableInstancer<
        SOIngredientStateVariable,
        SOIngredientStatePair,
        IvoKitchen.SOIngredientState,
        SOIngredientStateEvent,
        SOIngredientStatePairEvent,
        SOIngredientStateSOIngredientStateFunction>
    { }
}
