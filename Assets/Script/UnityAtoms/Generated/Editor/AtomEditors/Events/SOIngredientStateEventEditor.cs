#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `IvoKitchen.SOIngredientState`. Inherits from `AtomEventEditor&lt;IvoKitchen.SOIngredientState, SOIngredientStateEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SOIngredientStateEvent))]
    public sealed class SOIngredientStateEventEditor : AtomEventEditor<IvoKitchen.SOIngredientState, SOIngredientStateEvent> { }
}
#endif
