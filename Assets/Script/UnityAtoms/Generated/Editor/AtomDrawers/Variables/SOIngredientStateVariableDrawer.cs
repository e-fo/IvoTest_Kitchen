#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `IvoKitchen.SOIngredientState`. Inherits from `AtomDrawer&lt;SOIngredientStateVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOIngredientStateVariable))]
    public class SOIngredientStateVariableDrawer : VariableDrawer<SOIngredientStateVariable> { }
}
#endif
