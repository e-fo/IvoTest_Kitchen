#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `IvoKitchen.SOIngredientState`. Inherits from `AtomDrawer&lt;SOIngredientStateValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOIngredientStateValueList))]
    public class SOIngredientStateValueListDrawer : AtomDrawer<SOIngredientStateValueList> { }
}
#endif
