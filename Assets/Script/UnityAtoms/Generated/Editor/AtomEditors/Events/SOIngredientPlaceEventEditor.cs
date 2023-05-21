#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using IvoKitchen;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `IvoKitchen.SOIngredientPlace`. Inherits from `AtomEventEditor&lt;IvoKitchen.SOIngredientPlace, SOIngredientPlaceEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SOIngredientPlaceEvent))]
    public sealed class SOIngredientPlaceEventEditor : AtomEventEditor<IvoKitchen.SOIngredientPlace, SOIngredientPlaceEvent> { }
}
#endif
