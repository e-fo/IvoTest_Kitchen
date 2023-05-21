#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `IvoKitchen.SOIngredientPlace`. Inherits from `AtomDrawer&lt;SOIngredientPlaceEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOIngredientPlaceEvent))]
    public class SOIngredientPlaceEventDrawer : AtomDrawer<SOIngredientPlaceEvent> { }
}
#endif
