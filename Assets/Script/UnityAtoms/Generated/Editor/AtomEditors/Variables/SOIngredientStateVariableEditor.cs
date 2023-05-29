using UnityEditor;
using UnityAtoms.Editor;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `IvoKitchen.SOIngredientState`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(SOIngredientStateVariable))]
    public sealed class SOIngredientStateVariableEditor : AtomVariableEditor<IvoKitchen.SOIngredientState, SOIngredientStatePair> { }
}
