#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `IvoKitchen.SOIngredient`. Inherits from `AtomDrawer&lt;SOIngredientEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOIngredientEvent))]
    public class SOIngredientEventDrawer : AtomDrawer<SOIngredientEvent> { }
}
#endif
