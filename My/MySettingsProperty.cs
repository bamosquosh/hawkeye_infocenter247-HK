// Decompiled with JetBrains decompiler
// Type: Phulli.My.MySettingsProperty
// Assembly: Phulli, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5588EA96-561C-40B7-9B78-06ECD0A07CB4
// Assembly location: C:\Users\Voltaren\Desktop\infocenter247 HK.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Phulli.My
{
  [HideModuleName]
  [CompilerGenerated]
  [StandardModule]
  [DebuggerNonUserCode]
  internal sealed class MySettingsProperty
  {
    [HelpKeyword("My.Settings")]
    internal static MySettings Settings
    {
      get
      {
        MySettings mySettings = MySettings.Default;
        return mySettings;
      }
    }
  }
}
