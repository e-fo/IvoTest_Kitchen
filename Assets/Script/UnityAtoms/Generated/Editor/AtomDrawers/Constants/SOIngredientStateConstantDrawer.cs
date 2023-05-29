#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `IvoKitchen.SOIngredientState`. Inherits from `AtomDrawer&lt;SOIngredientStateConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOIngredientStateConstant))]
    public class SOIngredientStateConstantDrawer : VariableDrawer<SOIngredientStateConstant> { }
}
#endif
