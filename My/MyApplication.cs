﻿// Decompiled with JetBrains decompiler
// Type: Phulli.My.MyApplication
// Assembly: Phulli, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5588EA96-561C-40B7-9B78-06ECD0A07CB4
// Assembly location: C:\Users\Voltaren\Desktop\infocenter247 HK.exe

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Phulli.My
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  [GeneratedCode("MyTemplate", "8.0.0.0")]
  internal class MyApplication : WindowsFormsApplicationBase
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();

    [DebuggerNonUserCode]
    static MyApplication()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (MyApplication.__ENCList)
      {
        if (MyApplication.__ENCList.Count == MyApplication.__ENCList.Capacity)
        {
          int index1 = 0;
          int num1 = 0;
          int num2 = checked (MyApplication.__ENCList.Count - 1);
          int index2 = num1;
          while (index2 <= num2)
          {
            if (MyApplication.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                MyApplication.__ENCList[index1] = MyApplication.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          MyApplication.__ENCList.RemoveRange(index1, checked (MyApplication.__ENCList.Count - index1));
          MyApplication.__ENCList.Capacity = MyApplication.__ENCList.Count;
        }
        MyApplication.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [STAThread]
    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    internal static void Main(string[] Args)
    {
      try
      {
        Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
      }
      finally
      {
      }
      MyProject.Application.Run(Args);
    }

    [DebuggerStepThrough]
    public MyApplication()
      : base(AuthenticationMode.Windows)
    {
      MyApplication.__ENCAddToList((object) this);
      this.IsSingleInstance = true;
      this.EnableVisualStyles = true;
      this.SaveMySettingsOnExit = true;
      this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
    }

    [DebuggerStepThrough]
    protected override void OnCreateMainForm()
    {
      this.MainForm = (Form) MyProject.Forms.Form1;
    }
  }
}
