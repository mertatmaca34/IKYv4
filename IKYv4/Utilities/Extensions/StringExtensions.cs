using Entities.Concrete;
using System;

namespace IKYv4.Utilities.Extensions
{
    public static class StringExtensions
    {
        public static string DidTheyWork(this string str, DayOfWeek dayOfWeek, CalismaSaatleri calismaSaatleri)
        {
            if (dayOfWeek == DayOfWeek.Monday && calismaSaatleri.PazartesiBaslama == "HAFTA TATİLİ")
            {
                return "T";
            }
            else if (dayOfWeek == DayOfWeek.Tuesday && calismaSaatleri.SaliBaslama == "HAFTA TATİLİ")
            {
                return "T";
            }
            else if (dayOfWeek == DayOfWeek.Wednesday && calismaSaatleri.CarsambaBaslama == "HAFTA TATİLİ")
            {
                return "T";
            }
            else if (dayOfWeek == DayOfWeek.Thursday && calismaSaatleri.PersembeBaslama == "HAFTA TATİLİ")
            {
                return "T";
            }
            else if (dayOfWeek == DayOfWeek.Friday && calismaSaatleri.CumaBaslama == "HAFTA TATİLİ")
            {
                return "T";
            }
            else if (dayOfWeek == DayOfWeek.Saturday && calismaSaatleri.CumartesiBaslama == "HAFTA TATİLİ")
            {
                return "T";
            }
            else if (dayOfWeek == DayOfWeek.Sunday && calismaSaatleri.PazarBaslama == "HAFTA TATİLİ")
            {
                return "T";
            }
            else if (string.IsNullOrEmpty(str) || str == "X")
            {
                return "X";
            }
            return str;
        }
    }
}
