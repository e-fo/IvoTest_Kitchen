#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `IvoKitchen.SOIngredientPlace`. Inherits from `AtomDrawer&lt;SOIngredientPlaceConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOIngredientPlaceConstant))]
    public class SOIngredientPlaceConstantDrawer : VariableDrawer<SOIngredientPlaceConstant> { }
}
#endif
