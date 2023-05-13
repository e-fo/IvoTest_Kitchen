#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `IvoKitchen.SOIngredient`. Inherits from `AtomDrawer&lt;SOIngredientConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOIngredientConstant))]
    public class SOIngredientConstantDrawer : VariableDrawer<SOIngredientConstant> { }
}
#endif
