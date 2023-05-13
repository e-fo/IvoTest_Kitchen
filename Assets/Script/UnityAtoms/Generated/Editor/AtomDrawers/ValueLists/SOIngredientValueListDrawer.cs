#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `IvoKitchen.SOIngredient`. Inherits from `AtomDrawer&lt;SOIngredientValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOIngredientValueList))]
    public class SOIngredientValueListDrawer : AtomDrawer<SOIngredientValueList> { }
}
#endif
