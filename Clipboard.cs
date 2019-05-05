﻿// Decompiled with JetBrains decompiler
// Type: Phulli.Clipboard
// Assembly: Phulli, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5588EA96-561C-40B7-9B78-06ECD0A07CB4
// Assembly location: C:\Users\Voltaren\Desktop\infocenter247 HK.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Phulli
{
  internal class Clipboard : NativeWindow
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IntPtr ID;

    [DebuggerNonUserCode]
    static Clipboard()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (Clipboard.__ENCList)
      {
        if (Clipboard.__ENCList.Count == Clipboard.__ENCList.Capacity)
        {
          int index1 = 0;
          int num1 = 0;
          int num2 = checked (Clipboard.__ENCList.Count - 1);
          int index2 = num1;
          while (index2 <= num2)
          {
            if (Clipboard.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                Clipboard.__ENCList[index1] = Clipboard.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          Clipboard.__ENCList.RemoveRange(index1, checked (Clipboard.__ENCList.Count - index1));
          Clipboard.__ENCList.Capacity = Clipboard.__ENCList.Count;
        }
        Clipboard.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr SetClipboardViewer(IntPtr handle);

    [DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern bool ChangeClipboardChain(IntPtr handle, IntPtr next);

    [DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern long SendMessage(IntPtr handle, int code, IntPtr flags, IntPtr data);

    public event Clipboard.ChangedEventHandler Changed;

    public Clipboard()
    {
      Clipboard.__ENCAddToList((object) this);
      this.CreateHandle(new CreateParams());
    }

    public void Install()
    {
      this.ID = Clipboard.SetClipboardViewer(this.Handle);
    }

    public void Uninstall()
    {
      Clipboard.ChangeClipboardChain(this.Handle, this.ID);
    }

    protected override void WndProc(ref Message m)
    {
      switch (m.Msg)
      {
        case 776:
          Clipboard.ChangedEventHandler changedEvent = this.ChangedEvent;
          if (changedEvent != null)
            changedEvent(this);
          Clipboard.SendMessage(this.ID, m.Msg, m.WParam, m.LParam);
          break;
        case 781:
          if (m.WParam == this.ID)
          {
            this.ID = m.LParam;
            break;
          }
          Clipboard.SendMessage(this.ID, m.Msg, m.WParam, m.LParam);
          break;
      }
      base.WndProc(ref m);
    }

    ~Clipboard()
    {
      this.Uninstall();
    }

    public delegate void ChangedEventHandler(Clipboard sender);
  }
}
