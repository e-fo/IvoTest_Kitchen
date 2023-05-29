#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SOIngredientStatePair`. Inherits from `AtomDrawer&lt;SOIngredientStatePairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOIngredientStatePairEvent))]
    public class SOIngredientStatePairEventDrawer : AtomDrawer<SOIngredientStatePairEvent> { }
}
#endif
