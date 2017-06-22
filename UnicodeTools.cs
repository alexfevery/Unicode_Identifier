 
 class UnicodeTools
 {
        public enum Script { Latin, Cyrillic, Arabic, Hangul, Kana, CJKCharacters, Hebrew, Zhuyin, Unknown };
        public static Script GetScriptType(char c1)
        {
            if (char.IsHighSurrogate(c1) || char.IsLowSurrogate(c1)) { return Script.CJKCharacters; }
            if (c1 >= 65 && c1 <= 90) { return Script.Latin; }
            if (c1 >= 97 && c1 <= 122) { return Script.Latin; }
            if (c1 >= 192 && c1 < 255) { return Script.Latin; }
            if (c1 >= 256 && c1 < 383) { return Script.Latin; }
            if (c1 >= 384 && c1 < 591) { return Script.Latin; }
            if (c1 >= 592 && c1 < 687) { return Script.Latin; }
            if (c1 >= 688 && c1 < 697) { return Script.Latin; }
            if (c1 >= 736 && c1 < 740) { return Script.Latin; }
            if (c1 >= 1024 && c1 < 1279) { return Script.Cyrillic; }
            if (c1 >= 1280 && c1 < 1327) { return Script.Cyrillic; }
            if (c1 >= 1424 && c1 < 1535) { return Script.Hebrew; }
            if (c1 >= 1536 && c1 < 1791) { return Script.Arabic; }
            if (c1 >= 1872 && c1 < 1919) { return Script.Arabic; }
            if (c1 >= 2208 && c1 < 2303) { return Script.Arabic; }
            if (c1 >= 4352 && c1 <= 4607) { return Script.Hangul; }
            if (c1 >= 7424 && c1 < 7551) { return Script.Latin; }
            if (c1 == 7467) { return Script.Cyrillic; }
            if (c1 == 7544) { return Script.Cyrillic; }
            if (c1 >= 7552 && c1 < 7615) { return Script.Latin; }
            if (c1 >= 7680 && c1 < 7935) { return Script.Latin; }
            if (c1 >= 8448 && c1 < 8527) { return Script.Latin; }
            if (c1 >= 8528 && c1 < 8591) { return Script.Latin; }
            if (c1 >= 11360 && c1 < 11391) { return Script.Latin; }
            if (c1 >= 11744 && c1 < 11775) { return Script.Cyrillic; }
            if(c1 == 12295) { return Script.CJKCharacters; }
            if (c1 >= 12352 && c1 <= 12543) { return Script.Kana; }
            if (c1 >= 12549 && c1 <= 12589) { return Script.Zhuyin; }
            if (c1 >= 12592 && c1 <= 12687) { return Script.Hangul; }
            if (c1 >= 13312 && c1 <= 19903) { return Script.CJKCharacters; }
            if (c1 >= 19968 && c1 <= 40959) { return Script.CJKCharacters; }
            if (c1 >= 42560 && c1 < 42655) { return Script.Cyrillic; }
            if (c1 >= 42784 && c1 < 43007) { return Script.Latin; }
            if (c1 >= 43360 && c1 <= 43391) { return Script.Hangul; }
            if (c1 >= 43824 && c1 < 43887) { return Script.Latin; }
            if (c1 >= 44032 && c1 <= 55215) { return Script.Hangul; }
            if (c1 >= 55216 && c1 <= 55295) { return Script.Hangul; }
            if (c1 >= 63744 && c1 <= 64255) { return Script.CJKCharacters; }
            if (c1 >= 64256 && c1 < 64335) { return Script.Latin; }
            if (c1 >= 64285 && c1 < 64335) { return Script.Hebrew; }
            if (c1 >= 64336 && c1 < 65023) { return Script.Arabic; }
            if (c1 >= 65070 && c1 < 65071) { return Script.Cyrillic; }
            if (c1 >= 65136 && c1 < 65279) { return Script.Arabic; }
            if (c1 >= 65313 && c1 < 65339) { return Script.Latin; }
            if (c1 >= 65345 && c1 < 65371) { return Script.Latin; }
            if (c1 >= 69216 && c1 < 69247) { return Script.Arabic; }
            if (c1 >= 126464 && c1 < 126719) { return Script.Arabic; }
            if (c1 >= 131072 && c1 <= 173791) { return Script.CJKCharacters; }
            if (c1 >= 173824 && c1 <= 177983) { return Script.CJKCharacters; }
            if (c1 >= 177984 && c1 <= 178207) { return Script.CJKCharacters; }
            if (c1 >= 178208 && c1 <= 183983) { return Script.CJKCharacters; }
            if (c1 >= 194560 && c1 <= 195103) { return Script.CJKCharacters; }
            return Script.Unknown;
        }
        }
