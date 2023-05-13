#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SOIngredientPair`. Inherits from `AtomEventEditor&lt;SOIngredientPair, SOIngredientPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SOIngredientPairEvent))]
    public sealed class SOIngredientPairEventEditor : AtomEventEditor<SOIngredientPair, SOIngredientPairEvent> { }
}
#endif
