#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SOIngredientStatePair`. Inherits from `AtomEventEditor&lt;SOIngredientStatePair, SOIngredientStatePairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SOIngredientStatePairEvent))]
    public sealed class SOIngredientStatePairEventEditor : AtomEventEditor<SOIngredientStatePair, SOIngredientStatePairEvent> { }
}
#endif
