using System;
using System.Runtime.InteropServices;

namespace CourseProject
{
    internal class Pointer<T> where T : unmanaged
    {
        private readonly bool _isLogic;

        public Pointer(bool isLogic)
        {
            _isLogic = isLogic;
        }

        public static string ByteArrayToString(byte[] ba)
        {
            var hex = "";
            var g = BitConverter.ToString(ba).Split('-');
            for (var i = 0; i < ba.Length; i++) hex += g[i] + " ";

            return hex;
        }

        public static string ByteArrayToStringDecimal(byte[] ba)
        {
            var hex = "";
            var g = BitConverter.ToString(ba).Split('-');
            for (var i = 1; i <= 4; i++)
            for (var j = i * 4 - 1; j >= i * 4 - 4; j--)
                hex += g[j] + " ";
            return hex;
        }

        public static string BytetoBinary(byte ba)
        {
            return Convert.ToString(ba, 2).PadLeft(8, '0');
        }

        public string[] Сheck(T num)
        {
            try
            {
                unsafe
                {
                    var pt = &num;
                    var numberI = 0;
                    var ret = new string[2];
                    byte[] mas = null;
                    //Задание типа
                    if (typeof(T) == typeof(sbyte) || typeof(T) == typeof(byte)) //byte sbyte
                    {
                        numberI = 1;
                        mas = new byte[numberI];
                    }
                    else if (typeof(T) == typeof(int) || typeof(T) == typeof(uint) || typeof(T) == typeof(float)
                    ) // int uint float
                    {
                        numberI = 4;
                        mas = new byte[numberI];
                    }
                    else if (typeof(T) == typeof(short) || typeof(T) == typeof(ushort)) //short ushort
                    {
                        numberI = 2;
                        mas = new byte[numberI];
                    }
                    else if (typeof(T) == typeof(long) || typeof(T) == typeof(ulong) || typeof(T) == typeof(double)
                    ) //long ulong double
                    {
                        numberI = 8;
                        mas = new byte[numberI];
                    }
                    else if (typeof(T) == typeof(decimal)) //decimal
                    {
                        numberI = 16;
                        mas = new byte[numberI];
                        for (var i = 0; i < numberI; i++) mas[i] = Convert.ToByte(Marshal.ReadByte((IntPtr) pt, i));
                        if (!_isLogic)
                        {
                            ret[0] = ByteArrayToString(mas);
                            var decBin = "";
                            for (var i = 0; i < numberI; i++) decBin += BytetoBinary(mas[i]) + " ";
                            ret[1] = decBin;
                            return ret;
                        }

                        ret[0] = ByteArrayToStringDecimal(mas);
                        for (var i = 1; i <= 4; i++)
                        for (var j = i * 4 - 1; j >= i * 4 - 4; j--)
                            ret[1] += BytetoBinary(mas[j]) + " ";

                        return ret;
                    }

                    for (var i = 0; i < numberI; i++)
                        if (mas != null)
                            mas[i] = Convert.ToByte(Marshal.ReadByte((IntPtr) pt, i));

                    ret[0] = ByteArrayToString(mas);
                    var tBin = "";
                    for (var i = 0; i < numberI; i++)
                        if (mas != null)
                            tBin += BytetoBinary(mas[i]) + " ";
                    ret[1] = tBin;
                    if (!_isLogic) return ret;
                    var hexDone = "";
                    var binaryDone = "";
                    var elements = ret[0].Split(' ');
                    for (var i = elements.Length - 2; i >= 0; i--) hexDone += elements[i] + " ";
                    var elementsBin = tBin.Split(' ');
                    for (var i = elementsBin.Length - 1; i >= 0; i--) binaryDone += elementsBin[i] + " ";
                    ret[0] = hexDone;
                    ret[1] = binaryDone;
                    return ret;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}