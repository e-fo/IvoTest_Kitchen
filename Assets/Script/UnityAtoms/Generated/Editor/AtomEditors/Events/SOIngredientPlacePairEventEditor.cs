#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SOIngredientPlacePair`. Inherits from `AtomEventEditor&lt;SOIngredientPlacePair, SOIngredientPlacePairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SOIngredientPlacePairEvent))]
    public sealed class SOIngredientPlacePairEventEditor : AtomEventEditor<SOIngredientPlacePair, SOIngredientPlacePairEvent> { }
}
#endif
