using UnityEngine;

namespace Extensions {
    public static class ColorExtensions {
        // Converts hex code to a color
        // EX: #000000 => RGBA(0, 0, 0, 255);
        // EX: 0x000000 => RGBA(0, 0, 0, 255);
        // EX: #000000, 0 => RGBA(0, 0, 0, 0);
        // EX: #00000000 => RGBA(0, 0, 0, 0);
        // EX: #000000.HexToRGBA(125);
        public static Color32 HexToRGBA32(this string hex, byte alpha = 255) {
            hex = hex.Replace("0x", "");
            hex = hex.Replace("#", "");

            byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            if (hex.Length == 8) {
                alpha = byte.Parse(hex.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
            }

            return new Color32(r, g, b, alpha);
        }

        // Converts a color into hex code
        public static string RGBToHex32(this Color32 c) {
            return '#' + ColorUtility.ToHtmlStringRGBA(c);
        }

        // Easily change a colors alpha
        public static Color32 WithAlpha32(this Color32 color, byte alpha) {
            return new Color32(color.r, color.g, color.b, alpha);
        }


        public static Color HexToRGBA(this string hex, byte alpha = 255) {
            hex = hex.Replace("0x", "");
            hex = hex.Replace("#", "");

            byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            if (hex.Length == 8) {
                alpha = byte.Parse(hex.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
            }

            return new Color(r, g, b, alpha);
        }

        public static string RGBToHex(this Color c) {
            return '#' + ColorUtility.ToHtmlStringRGBA(c);
        }

        public static Color WithAlpha(this Color color, byte alpha) {
            return new Color(color.r, color.g, color.b, alpha);
        }
    }
}
