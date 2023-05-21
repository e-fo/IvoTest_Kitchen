#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SOIngredientPlacePair`. Inherits from `AtomDrawer&lt;SOIngredientPlacePairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOIngredientPlacePairEvent))]
    public class SOIngredientPlacePairEventDrawer : AtomDrawer<SOIngredientPlacePairEvent> { }
}
#endif
