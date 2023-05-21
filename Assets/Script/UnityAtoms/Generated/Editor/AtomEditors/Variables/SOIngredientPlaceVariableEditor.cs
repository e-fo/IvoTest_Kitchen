using UnityEditor;
using UnityAtoms.Editor;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `IvoKitchen.SOIngredientPlace`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(SOIngredientPlaceVariable))]
    public sealed class SOIngredientPlaceVariableEditor : AtomVariableEditor<IvoKitchen.SOIngredientPlace, SOIngredientPlacePair> { }
}
