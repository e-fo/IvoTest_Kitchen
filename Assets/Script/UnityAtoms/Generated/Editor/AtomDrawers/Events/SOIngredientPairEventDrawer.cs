#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SOIngredientPair`. Inherits from `AtomDrawer&lt;SOIngredientPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOIngredientPairEvent))]
    public class SOIngredientPairEventDrawer : AtomDrawer<SOIngredientPairEvent> { }
}
#endif
