#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `IvoKitchen.SOIngredientPlace`. Inherits from `AtomDrawer&lt;SOIngredientPlaceValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOIngredientPlaceValueList))]
    public class SOIngredientPlaceValueListDrawer : AtomDrawer<SOIngredientPlaceValueList> { }
}
#endif
