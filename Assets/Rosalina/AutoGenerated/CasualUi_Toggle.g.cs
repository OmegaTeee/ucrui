//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rosalina Code Generator tool.
//     Version: 4.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.UIElements;

public partial class CasualUi_Toggle
{
    [SerializeField]
    private UIDocument _document;
    public Toggle CasualUiE_Toggle { get; private set; }

    public VisualElement Root => _document?.rootVisualElement;
    public void InitializeDocument()
    {
        CasualUiE_Toggle = Root?.Q<Toggle>("CasualUiE_Toggle");
    }
}