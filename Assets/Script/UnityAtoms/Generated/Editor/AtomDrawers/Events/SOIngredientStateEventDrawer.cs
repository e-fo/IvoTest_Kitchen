#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `IvoKitchen.SOIngredientState`. Inherits from `AtomDrawer&lt;SOIngredientStateEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOIngredientStateEvent))]
    public class SOIngredientStateEventDrawer : AtomDrawer<SOIngredientStateEvent> { }
}
#endif
