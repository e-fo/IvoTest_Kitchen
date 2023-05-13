#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `IvoKitchen.SOIngredient`. Inherits from `AtomDrawer&lt;SOIngredientVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOIngredientVariable))]
    public class SOIngredientVariableDrawer : VariableDrawer<SOIngredientVariable> { }
}
#endif
