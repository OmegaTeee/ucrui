//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rosalina Code Generator tool.
//     Version: 4.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public partial class Rounded
{
    public Button CasualUiE_ButtonRounded { get; private set; }

    public VisualElement Root { get; }

    public Rounded(VisualElement root)
    {
        Root = root;
        CasualUiE_ButtonRounded = Root?.Q<Button>("CasualUiE_ButtonRounded");
    }
}