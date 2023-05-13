using UnityEditor;
using UnityAtoms.Editor;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `IvoKitchen.SOIngredient`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(SOIngredientVariable))]
    public sealed class SOIngredientVariableEditor : AtomVariableEditor<IvoKitchen.SOIngredient, SOIngredientPair> { }
}
