using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscsharp
{


    public static class ScannerTool
    {
        static Dictionary<string, SyntaxKind> __textToToken;
        public static Dictionary<string, SyntaxKind> textToToken
        {
            get
            {
                if (__textToToken == null)
                {
                    __textToToken = new Dictionary<string, SyntaxKind>();
                    __textToToken["abstract"] = SyntaxKind.AbstractKeyword;
                    __textToToken["any"] = SyntaxKind.AnyKeyword;
                    __textToToken["as"] = SyntaxKind.AsKeyword;
                    __textToToken["boolean"] = SyntaxKind.BooleanKeyword;
                    __textToToken["break"] = SyntaxKind.BreakKeyword;
                    __textToToken["case"] = SyntaxKind.CaseKeyword;
                    __textToToken["catch"] = SyntaxKind.CatchKeyword;
                    __textToToken["class"] = SyntaxKind.ClassKeyword;
                    __textToToken["continue"] = SyntaxKind.ContinueKeyword;
                    __textToToken["const"] = SyntaxKind.ConstKeyword;
                    __textToToken["constructor"] = SyntaxKind.ConstructorKeyword;
                    __textToToken["debugger"] = SyntaxKind.DebuggerKeyword;
                    __textToToken["declare"] = SyntaxKind.DeclareKeyword;
                    __textToToken["default"] = SyntaxKind.DefaultKeyword;
                    __textToToken["delete"] = SyntaxKind.DeleteKeyword;
                    __textToToken["do"] = SyntaxKind.DoKeyword;
                    __textToToken["else"] = SyntaxKind.ElseKeyword;
                    __textToToken["enum"] = SyntaxKind.EnumKeyword;
                    __textToToken["export"] = SyntaxKind.ExportKeyword;
                    __textToToken["extends"] = SyntaxKind.ExtendsKeyword;
                    __textToToken["false"] = SyntaxKind.FalseKeyword;
                    __textToToken["finally"] = SyntaxKind.FinallyKeyword;
                    __textToToken["for"] = SyntaxKind.ForKeyword;
                    __textToToken["from"] = SyntaxKind.FromKeyword;
                    __textToToken["function"] = SyntaxKind.FunctionKeyword;
                    __textToToken["get"] = SyntaxKind.GetKeyword;
                    __textToToken["if"] = SyntaxKind.IfKeyword;
                    __textToToken["implements"] = SyntaxKind.ImplementsKeyword;
                    __textToToken["import"] = SyntaxKind.ImportKeyword;
                    __textToToken["in"] = SyntaxKind.InKeyword;
                    __textToToken["instanceof"] = SyntaxKind.InstanceOfKeyword;
                    __textToToken["interface"] = SyntaxKind.InterfaceKeyword;
                    __textToToken["is"] = SyntaxKind.IsKeyword;
                    __textToToken["keyof"] = SyntaxKind.KeyOfKeyword;
                    __textToToken["let"] = SyntaxKind.LetKeyword;
                    __textToToken["module"] = SyntaxKind.ModuleKeyword;
                    __textToToken["namespace"] = SyntaxKind.NamespaceKeyword;
                    __textToToken["never"] = SyntaxKind.NeverKeyword;
                    __textToToken["new"] = SyntaxKind.NewKeyword;
                    __textToToken["null"] = SyntaxKind.NullKeyword;
                    __textToToken["number"] = SyntaxKind.NumberKeyword;
                    __textToToken["object"] = SyntaxKind.ObjectKeyword;
                    __textToToken["package"] = SyntaxKind.PackageKeyword;
                    __textToToken["private"] = SyntaxKind.PrivateKeyword;
                    __textToToken["protected"] = SyntaxKind.ProtectedKeyword;
                    __textToToken["public"] = SyntaxKind.PublicKeyword;
                    __textToToken["readonly"] = SyntaxKind.ReadonlyKeyword;
                    __textToToken["require"] = SyntaxKind.RequireKeyword;
                    __textToToken["global"] = SyntaxKind.GlobalKeyword;
                    __textToToken["return"] = SyntaxKind.ReturnKeyword;
                    __textToToken["set"] = SyntaxKind.SetKeyword;
                    __textToToken["static"] = SyntaxKind.StaticKeyword;
                    __textToToken["string"] = SyntaxKind.StringKeyword;
                    __textToToken["super"] = SyntaxKind.SuperKeyword;
                    __textToToken["switch"] = SyntaxKind.SwitchKeyword;
                    __textToToken["symbol"] = SyntaxKind.SymbolKeyword;
                    __textToToken["this"] = SyntaxKind.ThisKeyword;
                    __textToToken["throw"] = SyntaxKind.ThrowKeyword;
                    __textToToken["true"] = SyntaxKind.TrueKeyword;
                    __textToToken["try"] = SyntaxKind.TryKeyword;
                    __textToToken["type"] = SyntaxKind.TypeKeyword;
                    __textToToken["typeof"] = SyntaxKind.TypeOfKeyword;
                    __textToToken["undefined"] = SyntaxKind.UndefinedKeyword;
                    __textToToken["var"] = SyntaxKind.VarKeyword;
                    __textToToken["void"] = SyntaxKind.VoidKeyword;
                    __textToToken["while"] = SyntaxKind.WhileKeyword;
                    __textToToken["with"] = SyntaxKind.WithKeyword;
                    __textToToken["yield"] = SyntaxKind.YieldKeyword;
                    __textToToken["async"] = SyntaxKind.AsyncKeyword;
                    __textToToken["await"] = SyntaxKind.AwaitKeyword;
                    __textToToken["of"] = SyntaxKind.OfKeyword;
                    __textToToken["{"] = SyntaxKind.OpenBraceToken;
                    __textToToken["}"] = SyntaxKind.CloseBraceToken;
                    __textToToken["("] = SyntaxKind.OpenParenToken;
                    __textToToken[")"] = SyntaxKind.CloseParenToken;
                    __textToToken["["] = SyntaxKind.OpenBracketToken;
                    __textToToken["]"] = SyntaxKind.CloseBracketToken;
                    __textToToken["."] = SyntaxKind.DotToken;
                    __textToToken["..."] = SyntaxKind.DotDotDotToken;
                    __textToToken[";"] = SyntaxKind.SemicolonToken;
                    __textToToken[";"] = SyntaxKind.CommaToken;
                    __textToToken["<"] = SyntaxKind.LessThanToken;
                    __textToToken[">"] = SyntaxKind.GreaterThanToken;
                    __textToToken["<="] = SyntaxKind.LessThanEqualsToken;
                    __textToToken[">="] = SyntaxKind.GreaterThanEqualsToken;
                    __textToToken["=="] = SyntaxKind.EqualsEqualsToken;
                    __textToToken["!="] = SyntaxKind.ExclamationEqualsToken;
                    __textToToken["==="] = SyntaxKind.EqualsEqualsEqualsToken;
                    __textToToken["!=="] = SyntaxKind.ExclamationEqualsEqualsToken;
                    __textToToken["=>"] = SyntaxKind.EqualsGreaterThanToken;
                    __textToToken["+"] = SyntaxKind.PlusToken;
                    __textToToken["-"] = SyntaxKind.MinusToken;
                    __textToToken["**"] = SyntaxKind.AsteriskAsteriskToken;
                    __textToToken["*"] = SyntaxKind.AsteriskToken;
                    __textToToken["/"] = SyntaxKind.SlashToken;
                    __textToToken["%"] = SyntaxKind.PercentToken;
                    __textToToken["++"] = SyntaxKind.PlusPlusToken;
                    __textToToken["--"] = SyntaxKind.MinusMinusToken;
                    __textToToken["<<"] = SyntaxKind.LessThanLessThanToken;
                    __textToToken["</"] = SyntaxKind.LessThanSlashToken;
                    __textToToken[">>"] = SyntaxKind.GreaterThanGreaterThanToken;
                    __textToToken[">>>"] = SyntaxKind.GreaterThanGreaterThanGreaterThanToken;
                    __textToToken["&"] = SyntaxKind.AmpersandToken;
                    __textToToken["|"] = SyntaxKind.BarToken;
                    __textToToken["^"] = SyntaxKind.CaretToken;
                    __textToToken["!"] = SyntaxKind.ExclamationToken;
                    __textToToken["~"] = SyntaxKind.TildeToken;
                    __textToToken["&&"] = SyntaxKind.AmpersandAmpersandToken;
                    __textToToken["||"] = SyntaxKind.BarBarToken;
                    __textToToken["?"] = SyntaxKind.QuestionToken;
                    __textToToken["]="] = SyntaxKind.ColonToken;
                    __textToToken["="] = SyntaxKind.EqualsToken;
                    __textToToken["+="] = SyntaxKind.PlusEqualsToken;
                    __textToToken["-="] = SyntaxKind.MinusEqualsToken;
                    __textToToken["*="] = SyntaxKind.AsteriskEqualsToken;
                    __textToToken["**="] = SyntaxKind.AsteriskAsteriskEqualsToken;
                    __textToToken["/="] = SyntaxKind.SlashEqualsToken;
                    __textToToken["%="] = SyntaxKind.PercentEqualsToken;
                    __textToToken["<<="] = SyntaxKind.LessThanLessThanEqualsToken;
                    __textToToken[">>="] = SyntaxKind.GreaterThanGreaterThanEqualsToken;
                    __textToToken[">>>="] = SyntaxKind.GreaterThanGreaterThanGreaterThanEqualsToken;
                    __textToToken["&="] = SyntaxKind.AmpersandEqualsToken;
                    __textToToken["|="] = SyntaxKind.BarEqualsToken;
                    __textToToken["^="] = SyntaxKind.CaretEqualsToken;
                    __textToToken["@"] = SyntaxKind.AtToken;
                }
                return __textToToken;
            }
        }

        static int[] unicodeES3IdentifierStart = new int[] { 170, 170, 181, 181, 186, 186, 192, 214, 216, 246, 248, 543, 546, 563, 592, 685, 688, 696, 699, 705, 720, 721, 736, 740, 750, 750, 890, 890, 902, 902, 904, 906, 908, 908, 910, 929, 931, 974, 976, 983, 986, 1011, 1024, 1153, 1164, 1220, 1223, 1224, 1227, 1228, 1232, 1269, 1272, 1273, 1329, 1366, 1369, 1369, 1377, 1415, 1488, 1514, 1520, 1522, 1569, 1594, 1600, 1610, 1649, 1747, 1749, 1749, 1765, 1766, 1786, 1788, 1808, 1808, 1810, 1836, 1920, 1957, 2309, 2361, 2365, 2365, 2384, 2384, 2392, 2401, 2437, 2444, 2447, 2448, 2451, 2472, 2474, 2480, 2482, 2482, 2486, 2489, 2524, 2525, 2527, 2529, 2544, 2545, 2565, 2570, 2575, 2576, 2579, 2600, 2602, 2608, 2610, 2611, 2613, 2614, 2616, 2617, 2649, 2652, 2654, 2654, 2674, 2676, 2693, 2699, 2701, 2701, 2703, 2705, 2707, 2728, 2730, 2736, 2738, 2739, 2741, 2745, 2749, 2749, 2768, 2768, 2784, 2784, 2821, 2828, 2831, 2832, 2835, 2856, 2858, 2864, 2866, 2867, 2870, 2873, 2877, 2877, 2908, 2909, 2911, 2913, 2949, 2954, 2958, 2960, 2962, 2965, 2969, 2970, 2972, 2972, 2974, 2975, 2979, 2980, 2984, 2986, 2990, 2997, 2999, 3001, 3077, 3084, 3086, 3088, 3090, 3112, 3114, 3123, 3125, 3129, 3168, 3169, 3205, 3212, 3214, 3216, 3218, 3240, 3242, 3251, 3253, 3257, 3294, 3294, 3296, 3297, 3333, 3340, 3342, 3344, 3346, 3368, 3370, 3385, 3424, 3425, 3461, 3478, 3482, 3505, 3507, 3515, 3517, 3517, 3520, 3526, 3585, 3632, 3634, 3635, 3648, 3654, 3713, 3714, 3716, 3716, 3719, 3720, 3722, 3722, 3725, 3725, 3732, 3735, 3737, 3743, 3745, 3747, 3749, 3749, 3751, 3751, 3754, 3755, 3757, 3760, 3762, 3763, 3773, 3773, 3776, 3780, 3782, 3782, 3804, 3805, 3840, 3840, 3904, 3911, 3913, 3946, 3976, 3979, 4096, 4129, 4131, 4135, 4137, 4138, 4176, 4181, 4256, 4293, 4304, 4342, 4352, 4441, 4447, 4514, 4520, 4601, 4608, 4614, 4616, 4678, 4680, 4680, 4682, 4685, 4688, 4694, 4696, 4696, 4698, 4701, 4704, 4742, 4744, 4744, 4746, 4749, 4752, 4782, 4784, 4784, 4786, 4789, 4792, 4798, 4800, 4800, 4802, 4805, 4808, 4814, 4816, 4822, 4824, 4846, 4848, 4878, 4880, 4880, 4882, 4885, 4888, 4894, 4896, 4934, 4936, 4954, 5024, 5108, 5121, 5740, 5743, 5750, 5761, 5786, 5792, 5866, 6016, 6067, 6176, 6263, 6272, 6312, 7680, 7835, 7840, 7929, 7936, 7957, 7960, 7965, 7968, 8005, 8008, 8013, 8016, 8023, 8025, 8025, 8027, 8027, 8029, 8029, 8031, 8061, 8064, 8116, 8118, 8124, 8126, 8126, 8130, 8132, 8134, 8140, 8144, 8147, 8150, 8155, 8160, 8172, 8178, 8180, 8182, 8188, 8319, 8319, 8450, 8450, 8455, 8455, 8458, 8467, 8469, 8469, 8473, 8477, 8484, 8484, 8486, 8486, 8488, 8488, 8490, 8493, 8495, 8497, 8499, 8505, 8544, 8579, 12293, 12295, 12321, 12329, 12337, 12341, 12344, 12346, 12353, 12436, 12445, 12446, 12449, 12538, 12540, 12542, 12549, 12588, 12593, 12686, 12704, 12727, 13312, 19893, 19968, 40869, 40960, 42124, 44032, 55203, 63744, 64045, 64256, 64262, 64275, 64279, 64285, 64285, 64287, 64296, 64298, 64310, 64312, 64316, 64318, 64318, 64320, 64321, 64323, 64324, 64326, 64433, 64467, 64829, 64848, 64911, 64914, 64967, 65008, 65019, 65136, 65138, 65140, 65140, 65142, 65276, 65313, 65338, 65345, 65370, 65382, 65470, 65474, 65479, 65482, 65487, 65490, 65495, 65498, 65500, };
        static int[] unicodeES3IdentifierPart = new int[] { 170, 170, 181, 181, 186, 186, 192, 214, 216, 246, 248, 543, 546, 563, 592, 685, 688, 696, 699, 705, 720, 721, 736, 740, 750, 750, 768, 846, 864, 866, 890, 890, 902, 902, 904, 906, 908, 908, 910, 929, 931, 974, 976, 983, 986, 1011, 1024, 1153, 1155, 1158, 1164, 1220, 1223, 1224, 1227, 1228, 1232, 1269, 1272, 1273, 1329, 1366, 1369, 1369, 1377, 1415, 1425, 1441, 1443, 1465, 1467, 1469, 1471, 1471, 1473, 1474, 1476, 1476, 1488, 1514, 1520, 1522, 1569, 1594, 1600, 1621, 1632, 1641, 1648, 1747, 1749, 1756, 1759, 1768, 1770, 1773, 1776, 1788, 1808, 1836, 1840, 1866, 1920, 1968, 2305, 2307, 2309, 2361, 2364, 2381, 2384, 2388, 2392, 2403, 2406, 2415, 2433, 2435, 2437, 2444, 2447, 2448, 2451, 2472, 2474, 2480, 2482, 2482, 2486, 2489, 2492, 2492, 2494, 2500, 2503, 2504, 2507, 2509, 2519, 2519, 2524, 2525, 2527, 2531, 2534, 2545, 2562, 2562, 2565, 2570, 2575, 2576, 2579, 2600, 2602, 2608, 2610, 2611, 2613, 2614, 2616, 2617, 2620, 2620, 2622, 2626, 2631, 2632, 2635, 2637, 2649, 2652, 2654, 2654, 2662, 2676, 2689, 2691, 2693, 2699, 2701, 2701, 2703, 2705, 2707, 2728, 2730, 2736, 2738, 2739, 2741, 2745, 2748, 2757, 2759, 2761, 2763, 2765, 2768, 2768, 2784, 2784, 2790, 2799, 2817, 2819, 2821, 2828, 2831, 2832, 2835, 2856, 2858, 2864, 2866, 2867, 2870, 2873, 2876, 2883, 2887, 2888, 2891, 2893, 2902, 2903, 2908, 2909, 2911, 2913, 2918, 2927, 2946, 2947, 2949, 2954, 2958, 2960, 2962, 2965, 2969, 2970, 2972, 2972, 2974, 2975, 2979, 2980, 2984, 2986, 2990, 2997, 2999, 3001, 3006, 3010, 3014, 3016, 3018, 3021, 3031, 3031, 3047, 3055, 3073, 3075, 3077, 3084, 3086, 3088, 3090, 3112, 3114, 3123, 3125, 3129, 3134, 3140, 3142, 3144, 3146, 3149, 3157, 3158, 3168, 3169, 3174, 3183, 3202, 3203, 3205, 3212, 3214, 3216, 3218, 3240, 3242, 3251, 3253, 3257, 3262, 3268, 3270, 3272, 3274, 3277, 3285, 3286, 3294, 3294, 3296, 3297, 3302, 3311, 3330, 3331, 3333, 3340, 3342, 3344, 3346, 3368, 3370, 3385, 3390, 3395, 3398, 3400, 3402, 3405, 3415, 3415, 3424, 3425, 3430, 3439, 3458, 3459, 3461, 3478, 3482, 3505, 3507, 3515, 3517, 3517, 3520, 3526, 3530, 3530, 3535, 3540, 3542, 3542, 3544, 3551, 3570, 3571, 3585, 3642, 3648, 3662, 3664, 3673, 3713, 3714, 3716, 3716, 3719, 3720, 3722, 3722, 3725, 3725, 3732, 3735, 3737, 3743, 3745, 3747, 3749, 3749, 3751, 3751, 3754, 3755, 3757, 3769, 3771, 3773, 3776, 3780, 3782, 3782, 3784, 3789, 3792, 3801, 3804, 3805, 3840, 3840, 3864, 3865, 3872, 3881, 3893, 3893, 3895, 3895, 3897, 3897, 3902, 3911, 3913, 3946, 3953, 3972, 3974, 3979, 3984, 3991, 3993, 4028, 4038, 4038, 4096, 4129, 4131, 4135, 4137, 4138, 4140, 4146, 4150, 4153, 4160, 4169, 4176, 4185, 4256, 4293, 4304, 4342, 4352, 4441, 4447, 4514, 4520, 4601, 4608, 4614, 4616, 4678, 4680, 4680, 4682, 4685, 4688, 4694, 4696, 4696, 4698, 4701, 4704, 4742, 4744, 4744, 4746, 4749, 4752, 4782, 4784, 4784, 4786, 4789, 4792, 4798, 4800, 4800, 4802, 4805, 4808, 4814, 4816, 4822, 4824, 4846, 4848, 4878, 4880, 4880, 4882, 4885, 4888, 4894, 4896, 4934, 4936, 4954, 4969, 4977, 5024, 5108, 5121, 5740, 5743, 5750, 5761, 5786, 5792, 5866, 6016, 6099, 6112, 6121, 6160, 6169, 6176, 6263, 6272, 6313, 7680, 7835, 7840, 7929, 7936, 7957, 7960, 7965, 7968, 8005, 8008, 8013, 8016, 8023, 8025, 8025, 8027, 8027, 8029, 8029, 8031, 8061, 8064, 8116, 8118, 8124, 8126, 8126, 8130, 8132, 8134, 8140, 8144, 8147, 8150, 8155, 8160, 8172, 8178, 8180, 8182, 8188, 8255, 8256, 8319, 8319, 8400, 8412, 8417, 8417, 8450, 8450, 8455, 8455, 8458, 8467, 8469, 8469, 8473, 8477, 8484, 8484, 8486, 8486, 8488, 8488, 8490, 8493, 8495, 8497, 8499, 8505, 8544, 8579, 12293, 12295, 12321, 12335, 12337, 12341, 12344, 12346, 12353, 12436, 12441, 12442, 12445, 12446, 12449, 12542, 12549, 12588, 12593, 12686, 12704, 12727, 13312, 19893, 19968, 40869, 40960, 42124, 44032, 55203, 63744, 64045, 64256, 64262, 64275, 64279, 64285, 64296, 64298, 64310, 64312, 64316, 64318, 64318, 64320, 64321, 64323, 64324, 64326, 64433, 64467, 64829, 64848, 64911, 64914, 64967, 65008, 65019, 65056, 65059, 65075, 65076, 65101, 65103, 65136, 65138, 65140, 65140, 65142, 65276, 65296, 65305, 65313, 65338, 65343, 65343, 65345, 65370, 65381, 65470, 65474, 65479, 65482, 65487, 65490, 65495, 65498, 65500 };

        static int[] unicodeES5IdentifierStart = new int[] { 170, 170, 181, 181, 186, 186, 192, 214, 216, 246, 248, 705, 710, 721, 736, 740, 748, 748, 750, 750, 880, 884, 886, 887, 890, 893, 902, 902, 904, 906, 908, 908, 910, 929, 931, 1013, 1015, 1153, 1162, 1319, 1329, 1366, 1369, 1369, 1377, 1415, 1488, 1514, 1520, 1522, 1568, 1610, 1646, 1647, 1649, 1747, 1749, 1749, 1765, 1766, 1774, 1775, 1786, 1788, 1791, 1791, 1808, 1808, 1810, 1839, 1869, 1957, 1969, 1969, 1994, 2026, 2036, 2037, 2042, 2042, 2048, 2069, 2074, 2074, 2084, 2084, 2088, 2088, 2112, 2136, 2208, 2208, 2210, 2220, 2308, 2361, 2365, 2365, 2384, 2384, 2392, 2401, 2417, 2423, 2425, 2431, 2437, 2444, 2447, 2448, 2451, 2472, 2474, 2480, 2482, 2482, 2486, 2489, 2493, 2493, 2510, 2510, 2524, 2525, 2527, 2529, 2544, 2545, 2565, 2570, 2575, 2576, 2579, 2600, 2602, 2608, 2610, 2611, 2613, 2614, 2616, 2617, 2649, 2652, 2654, 2654, 2674, 2676, 2693, 2701, 2703, 2705, 2707, 2728, 2730, 2736, 2738, 2739, 2741, 2745, 2749, 2749, 2768, 2768, 2784, 2785, 2821, 2828, 2831, 2832, 2835, 2856, 2858, 2864, 2866, 2867, 2869, 2873, 2877, 2877, 2908, 2909, 2911, 2913, 2929, 2929, 2947, 2947, 2949, 2954, 2958, 2960, 2962, 2965, 2969, 2970, 2972, 2972, 2974, 2975, 2979, 2980, 2984, 2986, 2990, 3001, 3024, 3024, 3077, 3084, 3086, 3088, 3090, 3112, 3114, 3123, 3125, 3129, 3133, 3133, 3160, 3161, 3168, 3169, 3205, 3212, 3214, 3216, 3218, 3240, 3242, 3251, 3253, 3257, 3261, 3261, 3294, 3294, 3296, 3297, 3313, 3314, 3333, 3340, 3342, 3344, 3346, 3386, 3389, 3389, 3406, 3406, 3424, 3425, 3450, 3455, 3461, 3478, 3482, 3505, 3507, 3515, 3517, 3517, 3520, 3526, 3585, 3632, 3634, 3635, 3648, 3654, 3713, 3714, 3716, 3716, 3719, 3720, 3722, 3722, 3725, 3725, 3732, 3735, 3737, 3743, 3745, 3747, 3749, 3749, 3751, 3751, 3754, 3755, 3757, 3760, 3762, 3763, 3773, 3773, 3776, 3780, 3782, 3782, 3804, 3807, 3840, 3840, 3904, 3911, 3913, 3948, 3976, 3980, 4096, 4138, 4159, 4159, 4176, 4181, 4186, 4189, 4193, 4193, 4197, 4198, 4206, 4208, 4213, 4225, 4238, 4238, 4256, 4293, 4295, 4295, 4301, 4301, 4304, 4346, 4348, 4680, 4682, 4685, 4688, 4694, 4696, 4696, 4698, 4701, 4704, 4744, 4746, 4749, 4752, 4784, 4786, 4789, 4792, 4798, 4800, 4800, 4802, 4805, 4808, 4822, 4824, 4880, 4882, 4885, 4888, 4954, 4992, 5007, 5024, 5108, 5121, 5740, 5743, 5759, 5761, 5786, 5792, 5866, 5870, 5872, 5888, 5900, 5902, 5905, 5920, 5937, 5952, 5969, 5984, 5996, 5998, 6000, 6016, 6067, 6103, 6103, 6108, 6108, 6176, 6263, 6272, 6312, 6314, 6314, 6320, 6389, 6400, 6428, 6480, 6509, 6512, 6516, 6528, 6571, 6593, 6599, 6656, 6678, 6688, 6740, 6823, 6823, 6917, 6963, 6981, 6987, 7043, 7072, 7086, 7087, 7098, 7141, 7168, 7203, 7245, 7247, 7258, 7293, 7401, 7404, 7406, 7409, 7413, 7414, 7424, 7615, 7680, 7957, 7960, 7965, 7968, 8005, 8008, 8013, 8016, 8023, 8025, 8025, 8027, 8027, 8029, 8029, 8031, 8061, 8064, 8116, 8118, 8124, 8126, 8126, 8130, 8132, 8134, 8140, 8144, 8147, 8150, 8155, 8160, 8172, 8178, 8180, 8182, 8188, 8305, 8305, 8319, 8319, 8336, 8348, 8450, 8450, 8455, 8455, 8458, 8467, 8469, 8469, 8473, 8477, 8484, 8484, 8486, 8486, 8488, 8488, 8490, 8493, 8495, 8505, 8508, 8511, 8517, 8521, 8526, 8526, 8544, 8584, 11264, 11310, 11312, 11358, 11360, 11492, 11499, 11502, 11506, 11507, 11520, 11557, 11559, 11559, 11565, 11565, 11568, 11623, 11631, 11631, 11648, 11670, 11680, 11686, 11688, 11694, 11696, 11702, 11704, 11710, 11712, 11718, 11720, 11726, 11728, 11734, 11736, 11742, 11823, 11823, 12293, 12295, 12321, 12329, 12337, 12341, 12344, 12348, 12353, 12438, 12445, 12447, 12449, 12538, 12540, 12543, 12549, 12589, 12593, 12686, 12704, 12730, 12784, 12799, 13312, 19893, 19968, 40908, 40960, 42124, 42192, 42237, 42240, 42508, 42512, 42527, 42538, 42539, 42560, 42606, 42623, 42647, 42656, 42735, 42775, 42783, 42786, 42888, 42891, 42894, 42896, 42899, 42912, 42922, 43000, 43009, 43011, 43013, 43015, 43018, 43020, 43042, 43072, 43123, 43138, 43187, 43250, 43255, 43259, 43259, 43274, 43301, 43312, 43334, 43360, 43388, 43396, 43442, 43471, 43471, 43520, 43560, 43584, 43586, 43588, 43595, 43616, 43638, 43642, 43642, 43648, 43695, 43697, 43697, 43701, 43702, 43705, 43709, 43712, 43712, 43714, 43714, 43739, 43741, 43744, 43754, 43762, 43764, 43777, 43782, 43785, 43790, 43793, 43798, 43808, 43814, 43816, 43822, 43968, 44002, 44032, 55203, 55216, 55238, 55243, 55291, 63744, 64109, 64112, 64217, 64256, 64262, 64275, 64279, 64285, 64285, 64287, 64296, 64298, 64310, 64312, 64316, 64318, 64318, 64320, 64321, 64323, 64324, 64326, 64433, 64467, 64829, 64848, 64911, 64914, 64967, 65008, 65019, 65136, 65140, 65142, 65276, 65313, 65338, 65345, 65370, 65382, 65470, 65474, 65479, 65482, 65487, 65490, 65495, 65498, 65500, };

        static int[] unicodeES5IdentifierPart = new int[] { 170, 170, 181, 181, 186, 186, 192, 214, 216, 246, 248, 705, 710, 721, 736, 740, 748, 748, 750, 750, 768, 884, 886, 887, 890, 893, 902, 902, 904, 906, 908, 908, 910, 929, 931, 1013, 1015, 1153, 1155, 1159, 1162, 1319, 1329, 1366, 1369, 1369, 1377, 1415, 1425, 1469, 1471, 1471, 1473, 1474, 1476, 1477, 1479, 1479, 1488, 1514, 1520, 1522, 1552, 1562, 1568, 1641, 1646, 1747, 1749, 1756, 1759, 1768, 1770, 1788, 1791, 1791, 1808, 1866, 1869, 1969, 1984, 2037, 2042, 2042, 2048, 2093, 2112, 2139, 2208, 2208, 2210, 2220, 2276, 2302, 2304, 2403, 2406, 2415, 2417, 2423, 2425, 2431, 2433, 2435, 2437, 2444, 2447, 2448, 2451, 2472, 2474, 2480, 2482, 2482, 2486, 2489, 2492, 2500, 2503, 2504, 2507, 2510, 2519, 2519, 2524, 2525, 2527, 2531, 2534, 2545, 2561, 2563, 2565, 2570, 2575, 2576, 2579, 2600, 2602, 2608, 2610, 2611, 2613, 2614, 2616, 2617, 2620, 2620, 2622, 2626, 2631, 2632, 2635, 2637, 2641, 2641, 2649, 2652, 2654, 2654, 2662, 2677, 2689, 2691, 2693, 2701, 2703, 2705, 2707, 2728, 2730, 2736, 2738, 2739, 2741, 2745, 2748, 2757, 2759, 2761, 2763, 2765, 2768, 2768, 2784, 2787, 2790, 2799, 2817, 2819, 2821, 2828, 2831, 2832, 2835, 2856, 2858, 2864, 2866, 2867, 2869, 2873, 2876, 2884, 2887, 2888, 2891, 2893, 2902, 2903, 2908, 2909, 2911, 2915, 2918, 2927, 2929, 2929, 2946, 2947, 2949, 2954, 2958, 2960, 2962, 2965, 2969, 2970, 2972, 2972, 2974, 2975, 2979, 2980, 2984, 2986, 2990, 3001, 3006, 3010, 3014, 3016, 3018, 3021, 3024, 3024, 3031, 3031, 3046, 3055, 3073, 3075, 3077, 3084, 3086, 3088, 3090, 3112, 3114, 3123, 3125, 3129, 3133, 3140, 3142, 3144, 3146, 3149, 3157, 3158, 3160, 3161, 3168, 3171, 3174, 3183, 3202, 3203, 3205, 3212, 3214, 3216, 3218, 3240, 3242, 3251, 3253, 3257, 3260, 3268, 3270, 3272, 3274, 3277, 3285, 3286, 3294, 3294, 3296, 3299, 3302, 3311, 3313, 3314, 3330, 3331, 3333, 3340, 3342, 3344, 3346, 3386, 3389, 3396, 3398, 3400, 3402, 3406, 3415, 3415, 3424, 3427, 3430, 3439, 3450, 3455, 3458, 3459, 3461, 3478, 3482, 3505, 3507, 3515, 3517, 3517, 3520, 3526, 3530, 3530, 3535, 3540, 3542, 3542, 3544, 3551, 3570, 3571, 3585, 3642, 3648, 3662, 3664, 3673, 3713, 3714, 3716, 3716, 3719, 3720, 3722, 3722, 3725, 3725, 3732, 3735, 3737, 3743, 3745, 3747, 3749, 3749, 3751, 3751, 3754, 3755, 3757, 3769, 3771, 3773, 3776, 3780, 3782, 3782, 3784, 3789, 3792, 3801, 3804, 3807, 3840, 3840, 3864, 3865, 3872, 3881, 3893, 3893, 3895, 3895, 3897, 3897, 3902, 3911, 3913, 3948, 3953, 3972, 3974, 3991, 3993, 4028, 4038, 4038, 4096, 4169, 4176, 4253, 4256, 4293, 4295, 4295, 4301, 4301, 4304, 4346, 4348, 4680, 4682, 4685, 4688, 4694, 4696, 4696, 4698, 4701, 4704, 4744, 4746, 4749, 4752, 4784, 4786, 4789, 4792, 4798, 4800, 4800, 4802, 4805, 4808, 4822, 4824, 4880, 4882, 4885, 4888, 4954, 4957, 4959, 4992, 5007, 5024, 5108, 5121, 5740, 5743, 5759, 5761, 5786, 5792, 5866, 5870, 5872, 5888, 5900, 5902, 5908, 5920, 5940, 5952, 5971, 5984, 5996, 5998, 6000, 6002, 6003, 6016, 6099, 6103, 6103, 6108, 6109, 6112, 6121, 6155, 6157, 6160, 6169, 6176, 6263, 6272, 6314, 6320, 6389, 6400, 6428, 6432, 6443, 6448, 6459, 6470, 6509, 6512, 6516, 6528, 6571, 6576, 6601, 6608, 6617, 6656, 6683, 6688, 6750, 6752, 6780, 6783, 6793, 6800, 6809, 6823, 6823, 6912, 6987, 6992, 7001, 7019, 7027, 7040, 7155, 7168, 7223, 7232, 7241, 7245, 7293, 7376, 7378, 7380, 7414, 7424, 7654, 7676, 7957, 7960, 7965, 7968, 8005, 8008, 8013, 8016, 8023, 8025, 8025, 8027, 8027, 8029, 8029, 8031, 8061, 8064, 8116, 8118, 8124, 8126, 8126, 8130, 8132, 8134, 8140, 8144, 8147, 8150, 8155, 8160, 8172, 8178, 8180, 8182, 8188, 8204, 8205, 8255, 8256, 8276, 8276, 8305, 8305, 8319, 8319, 8336, 8348, 8400, 8412, 8417, 8417, 8421, 8432, 8450, 8450, 8455, 8455, 8458, 8467, 8469, 8469, 8473, 8477, 8484, 8484, 8486, 8486, 8488, 8488, 8490, 8493, 8495, 8505, 8508, 8511, 8517, 8521, 8526, 8526, 8544, 8584, 11264, 11310, 11312, 11358, 11360, 11492, 11499, 11507, 11520, 11557, 11559, 11559, 11565, 11565, 11568, 11623, 11631, 11631, 11647, 11670, 11680, 11686, 11688, 11694, 11696, 11702, 11704, 11710, 11712, 11718, 11720, 11726, 11728, 11734, 11736, 11742, 11744, 11775, 11823, 11823, 12293, 12295, 12321, 12335, 12337, 12341, 12344, 12348, 12353, 12438, 12441, 12442, 12445, 12447, 12449, 12538, 12540, 12543, 12549, 12589, 12593, 12686, 12704, 12730, 12784, 12799, 13312, 19893, 19968, 40908, 40960, 42124, 42192, 42237, 42240, 42508, 42512, 42539, 42560, 42607, 42612, 42621, 42623, 42647, 42655, 42737, 42775, 42783, 42786, 42888, 42891, 42894, 42896, 42899, 42912, 42922, 43000, 43047, 43072, 43123, 43136, 43204, 43216, 43225, 43232, 43255, 43259, 43259, 43264, 43309, 43312, 43347, 43360, 43388, 43392, 43456, 43471, 43481, 43520, 43574, 43584, 43597, 43600, 43609, 43616, 43638, 43642, 43643, 43648, 43714, 43739, 43741, 43744, 43759, 43762, 43766, 43777, 43782, 43785, 43790, 43793, 43798, 43808, 43814, 43816, 43822, 43968, 44010, 44012, 44013, 44016, 44025, 44032, 55203, 55216, 55238, 55243, 55291, 63744, 64109, 64112, 64217, 64256, 64262, 64275, 64279, 64285, 64296, 64298, 64310, 64312, 64316, 64318, 64318, 64320, 64321, 64323, 64324, 64326, 64433, 64467, 64829, 64848, 64911, 64914, 64967, 65008, 65019, 65024, 65039, 65056, 65062, 65075, 65076, 65101, 65103, 65136, 65140, 65142, 65276, 65296, 65305, 65313, 65338, 65343, 65343, 65345, 65370, 65382, 65470, 65474, 65479, 65482, 65487, 65490, 65495, 65498, 65500, };
        public static bool lookupInUnicodeMap(int code, int[] map)
        {
            // Bail out quickly if it couldn't possibly be in the map.
            if (code < map[0])
            {
                return false;
            }

            // Perform binary search in one of the Unicode range maps
            var lo = 0;
            int hi = map.Length;
            int mid = 0;

            while (lo + 1 < hi)
            {
                mid = lo + (hi - lo) / 2;
                // mid has to be even to catch a range's beginning
                mid -= mid % 2;
                if (map[mid] <= code && code <= map[mid + 1])
                {
                    return true;
                }

                if (code < map[mid])
                {
                    hi = mid;
                }
                else
                {
                    lo = mid + 2;
                }
            }

            return false;
        }

        public static string Substring(string text, int start, int end)
        {
            return text.Substring(start, end - start);
        }
        public static string Substr(string text, int start, int length)
        {
            return text.Substring(start, length);
        }

        public delegate void ErrorCallback(DiagnosticMessage message, int length);
        public static bool tokenIsIdentifierOrKeyword(SyntaxKind token)
        {
            return token >= SyntaxKind.Identifier;
        }
        public static bool isIdentifierStart(int ch, ScriptTarget languageVersion)
        {
            return ch >= (char)CharacterCodes.A && ch <= (char)CharacterCodes.Z || ch >= (char)CharacterCodes.a && ch <= (char)CharacterCodes.z ||
                ch == (char)CharacterCodes._doller_ || ch == (char)CharacterCodes._ ||
                ch > (char)CharacterCodes.maxAsciiCharacter && isUnicodeIdentifierStart(ch, languageVersion);
        }

        /* @internal */
        public static bool isUnicodeIdentifierStart(int code, ScriptTarget languageVersion)
        {
            return languageVersion >= ScriptTarget.ES5 ?
                lookupInUnicodeMap(code, unicodeES5IdentifierStart) :
                lookupInUnicodeMap(code, unicodeES3IdentifierStart);
        }
        public static Scanner createScanner(ScriptTarget languageVersion,
                                      bool skipTrivia,
                                      LanguageVariant languageVariant = LanguageVariant.Standard,
                                      string text = null,
                                      ErrorCallback onError = null,
                                      int start = 0,
                                      int length = 0)
        {
            Scanner scanner = new Scanner();
            scanner.languageVersion = languageVersion;
            scanner.skipTrivia = skipTrivia;
            scanner.languageVariant = languageVariant;
            scanner.onError = onError;
            scanner.setText(text, start, length);
            return scanner;
        }
        public static bool isLineBreak(char ch)
        {
            // ES5 7.3:
            // The ECMAScript line terminator characters are listed in Table 3.
            //     Table 3: Line Terminator Characters
            //     Code Unit Value     Name                    Formal Name
            //     \u000A              Line Feed               <LF>
            //     \u000D              Carriage Return         <CR>
            //     \u2028              Line separator          <LS>
            //     \u2029              Paragraph separator     <PS>
            // Only the characters in Table 3 are treated as line terminators. Other new line or line
            // breaking characters are treated as white space but not as line terminators.

            return ch == (char)CharacterCodes.lineFeed ||
                ch == (char)CharacterCodes.carriageReturn ||
                ch == (char)CharacterCodes.lineSeparator ||
                ch == (char)CharacterCodes.paragraphSeparator;
        }
        public static bool isIdentifierPart(char ch, ScriptTarget languageVersion)
        {
            return ch >= (char)CharacterCodes.A && ch <= (char)CharacterCodes.Z || ch >= (char)CharacterCodes.a && ch <= (char)CharacterCodes.z ||
                ch >= (char)CharacterCodes._0 && ch <= (char)CharacterCodes._9 || ch == (char)CharacterCodes._doller_ || ch == (char)CharacterCodes._ ||
                ch > (char)CharacterCodes.maxAsciiCharacter && isUnicodeIdentifierPart(ch, languageVersion);
        }
        public static bool isUnicodeIdentifierPart(char code, ScriptTarget languageVersion)
        {
            return languageVersion >= ScriptTarget.ES5 ?
                lookupInUnicodeMap(code, unicodeES5IdentifierPart) :
                lookupInUnicodeMap(code, unicodeES3IdentifierPart);
        }
        static readonly int mergeConflictMarkerLength = "<<<<<<<".Length;

        public static bool isConflictMarkerTrivia(string text, int pos)
        {
            System.Diagnostics.Debug.Assert(pos >= 0);

            // Conflict markers must be at the start of a line.
            if (pos == 0 || isLineBreak(text[pos - 1]))
            {
                var ch = text[pos];

                if ((pos + mergeConflictMarkerLength) < text.Length)
                {
                    for (var i = 0; i < mergeConflictMarkerLength; i++)
                    {
                        if (text[pos + i] != ch)
                        {
                            return false;
                        }
                    }

                    return ch == (char)CharacterCodes.equals ||
                        text[pos + mergeConflictMarkerLength] == (char)CharacterCodes.space;
                }
            }

            return false;
        }
        public static bool isWhiteSpaceLike(char ch)
        {
            return isWhiteSpaceSingleLine(ch) || isLineBreak(ch);
        }
        public static bool isWhiteSpaceSingleLine(char ch)
        {
            // Note: nextLine is in the Zs space, and should be considered to be a whitespace.
            // It is explicitly not a line-break as it isn't in the exact set specified by EcmaScript.
            return ch == (char)CharacterCodes.space ||
                ch == (char)CharacterCodes.tab ||
                ch == (char)CharacterCodes.verticalTab ||
                ch == (char)CharacterCodes.formFeed ||
                ch == (char)CharacterCodes.nonBreakingSpace ||
                ch == (char)CharacterCodes.nextLine ||
                ch == (char)CharacterCodes.ogham ||
                ch >= (char)CharacterCodes.enQuad && ch <= (char)CharacterCodes.zeroWidthSpace ||
                ch == (char)CharacterCodes.narrowNoBreakSpace ||
                ch == (char)CharacterCodes.mathematicalSpace ||
                ch == (char)CharacterCodes.ideographicSpace ||
                ch == (char)CharacterCodes.byteOrderMark;
        }
        public static string utf16EncodeAsString(int codePoint)
        {
            System.Diagnostics.Debug.Assert(0x0 <= codePoint && codePoint <= 0x10FFFF);

            if (codePoint <= 65535)
            {
                return codePoint.ToString();
            }

            var codeUnit1 = Math.Floor((double)((codePoint - 65536) / 1024)) + 0xD800;
            var codeUnit2 = ((codePoint - 65536) % 1024) + 0xDC00;

            return codeUnit1.ToString() + codeUnit2.ToString();
        }

        const string shebangTriviaRegex = "^#!.*";
        public static bool isShebangTrivia(string text, int pos)
        {
            // Shebangs check must only be done at the start of the file
            System.Diagnostics.Debug.Assert(pos == 0);
            var b = System.Text.RegularExpressions.Regex.IsMatch(text, shebangTriviaRegex);
            return b;// shebangTriviaRegex.test(text);
        }

        public static int scanShebangTrivia(string text, int pos)
        {
            var m = System.Text.RegularExpressions.Regex.Match(text, shebangTriviaRegex);
            //var shebang = shebangTriviaRegex.exec(text)[0];
            pos = pos + m.Value.Length;
            return pos;
        }
        public static bool isDigit(char ch)
        {
            return ch >= (char)CharacterCodes._0 && ch <= (char)CharacterCodes._9;
        }
        public static bool isOctalDigit(char ch)
        {
            return ch >= (char)CharacterCodes._0 && ch <= (char)CharacterCodes._7;
        }
        public class Scanner
        {
            public LanguageVariant languageVariant;
            public ScriptTarget languageVersion;
            public bool skipTrivia;
            public ErrorCallback onError;
            string text;
            // Current position (end position of text of current token)
            int pos;

            // end of text
            int end;

            // Start position of whitespace before current token
            int startPos;

            // Start position of text of current token
            int tokenPos;

            SyntaxKind token;
            string tokenValue;
            bool precedingLineBreak;
            bool _hasExtendedUnicodeEscape;
            bool tokenIsUnterminated;
            NumericLiteralFlags numericLiteralFlags;

            public int getStartPos()
            {
                return startPos;
            }
            public int getTextPos()
            {
                return pos;
            }
            public SyntaxKind getToken()
            {
                return token;
            }

            public int getTokenPos()
            {
                return tokenPos;
            }
            public string getTokenText()
            {
                return Substring(text, tokenPos, pos);
            }
            public string getTokenValue()
            {
                return tokenValue;
            }
            public bool hasExtendedUnicodeEscape()
            {
                return _hasExtendedUnicodeEscape;
            }
            public bool hasPrecedingLineBreak()
            {
                return precedingLineBreak;
            }
            public bool isIdentifier()
            {
                return token == SyntaxKind.Identifier || token > SyntaxKind.LastReservedWord;
            }
            public bool isReservedWord()
            {
                return token >= SyntaxKind.FirstReservedWord && token <= SyntaxKind.LastReservedWord;
            }
            public bool isUnterminated()
            {
                return tokenIsUnterminated;
            }
            /* @internal */
            public NumericLiteralFlags getNumericLiteralFlags()
            {
                return numericLiteralFlags;
            }
            public SyntaxKind reScanGreaterToken()
            {
                if (token == SyntaxKind.GreaterThanToken)
                {
                    if (text[pos] == (char)CharacterCodes.greaterThan)
                    {
                        if (text[pos + 1] == (char)CharacterCodes.greaterThan)
                        {
                            if (text[pos + 2] == (char)CharacterCodes.equals)
                            {
                                pos += 3;
                                token = SyntaxKind.GreaterThanGreaterThanGreaterThanEqualsToken;
                                return token;
                            }
                            pos += 2;
                            token = SyntaxKind.GreaterThanGreaterThanGreaterThanToken;
                            return token;
                        }
                        if (text[pos + 1] == (char)CharacterCodes.equals)
                        {
                            pos += 2;
                            token = SyntaxKind.GreaterThanGreaterThanEqualsToken;
                            return token;
                        }
                        pos++;
                        token = SyntaxKind.GreaterThanGreaterThanToken;
                        return token;
                    }
                    if (text[pos] == (char)CharacterCodes.equals)
                    {
                        pos++;
                        token = SyntaxKind.GreaterThanEqualsToken;
                        return token;
                    }
                }
                return token;
            }
            public SyntaxKind reScanSlashToken()
            {
                if (token == SyntaxKind.SlashToken || token == SyntaxKind.SlashEqualsToken)
                {
                    var p = tokenPos + 1;
                    var inEscape = false;
                    var inCharacterClass = false;
                    while (true)
                    {
                        // If we reach the end of a file, or hit a newline, then this is an unterminated
                        // regex.  Report error and return what we have so far.
                        if (p >= end)
                        {
                            tokenIsUnterminated = true;
                            error(Diagnostics.Unterminated_regular_expression_literal);
                            break;
                        }

                        var ch = text[p];
                        if (isLineBreak(ch))
                        {
                            tokenIsUnterminated = true;
                            error(Diagnostics.Unterminated_regular_expression_literal);
                            break;
                        }

                        if (inEscape)
                        {
                            // Parsing an escape character;
                            // reset the flag and just advance to the next char.
                            inEscape = false;
                        }
                        else if (ch == (char)CharacterCodes.slash && !inCharacterClass)
                        {
                            // A slash within a character class is permissible,
                            // but in general it signals the end of the regexp literal.
                            p++;
                            break;
                        }
                        else if (ch == (char)CharacterCodes.openBracket)
                        {
                            inCharacterClass = true;
                        }
                        else if (ch == (char)CharacterCodes.backslash)
                        {
                            inEscape = true;
                        }
                        else if (ch == (char)CharacterCodes.closeBracket)
                        {
                            inCharacterClass = false;
                        }
                        p++;
                    }

                    while (p < end && isIdentifierPart(text[p], languageVersion))
                    {
                        p++;
                    }
                    pos = p;
                    tokenValue = Substring(text, tokenPos, pos);
                    token = SyntaxKind.RegularExpressionLiteral;
                }
                return token;
            }
            public SyntaxKind reScanTemplateToken()
            {
                System.Diagnostics.Debug.Assert(token == SyntaxKind.CloseBraceToken, "'reScanTemplateToken' should only be called on a '}'");
                pos = tokenPos;
                return token = scanTemplateAndSetTokenValue();
            }
            public SyntaxKind scanJsxIdentifier()
            {
                if (tokenIsIdentifierOrKeyword(token))
                {
                    var firstCharPosition = pos;
                    while (pos < end)
                    {
                        var ch = text[pos];
                        if (ch == (char)CharacterCodes.minus || ((firstCharPosition == pos) ? isIdentifierStart(ch, languageVersion) : isIdentifierPart(ch, languageVersion)))
                        {
                            pos++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    tokenValue += Substr(text, firstCharPosition, pos - firstCharPosition);
                }
                return token;
            }
            public SyntaxKind scanJsxAttributeValue()
            {
                startPos = pos;

                switch (text[pos])
                {
                    case (char)CharacterCodes.doubleQuote:
                    case (char)CharacterCodes.singleQuote:
                        tokenValue = scanString(/*allowEscapes*/ false);
                        return token = SyntaxKind.StringLiteral;
                    default:
                        // If this scans anything other than `{`, it's a parse error.
                        return scan();
                }
            }
            public SyntaxKind reScanJsxToken()
            {
                pos = tokenPos = startPos;
                return token = scanJsxToken();
            }
            public SyntaxKind scanJsxToken()
            {
                startPos = tokenPos = pos;

                if (pos >= end)
                {
                    return token = SyntaxKind.EndOfFileToken;
                }

                var _char = text[pos];
                if (_char == (char)CharacterCodes.lessThan)
                {
                    if (text[pos + 1] == (char)CharacterCodes.slash)
                    {
                        pos += 2;
                        return token = SyntaxKind.LessThanSlashToken;
                    }
                    pos++;
                    return token = SyntaxKind.LessThanToken;
                }

                if (_char == (char)CharacterCodes.openBrace)
                {
                    pos++;
                    return token = SyntaxKind.OpenBraceToken;
                }

                // First non-whitespace character on this line.
                var firstNonWhitespace = 0;
                // These initial values are special because the first line is:
                // firstNonWhitespace = 0 to indicate that we want leading whitspace,

                while (pos < end)
                {
                    _char = text[pos];
                    if (_char == (char)CharacterCodes.openBrace)
                    {
                        break;
                    }
                    if (_char == (char)CharacterCodes.lessThan)
                    {
                        if (isConflictMarkerTrivia(text, pos))
                        {
                            pos = scanConflictMarkerTrivia(text, pos, error);
                            return token = SyntaxKind.ConflictMarkerTrivia;
                        }
                        break;
                    }

                    // FirstNonWhitespace is 0, then we only see whitespaces so far. If we see a linebreak, we want to ignore that whitespaces.
                    // i.e (- : whitespace)
                    //      <div>----
                    //      </div> becomes <div></div>
                    //
                    //      <div>----</div> becomes <div>----</div>
                    if (isLineBreak(_char) && firstNonWhitespace == 0)
                    {
                        firstNonWhitespace = -1;
                    }
                    else if (!isWhiteSpaceLike(_char))
                    {
                        firstNonWhitespace = pos;
                    }
                    pos++;
                }

                return firstNonWhitespace == -1 ? SyntaxKind.JsxTextAllWhiteSpaces : SyntaxKind.JsxText;
            }
            public SyntaxKind scanJSDocToken()
            {
                if (pos >= end)
                {
                    return token = SyntaxKind.EndOfFileToken;
                }

                startPos = pos;
                tokenPos = pos;

                var ch = text[pos];
                switch (ch)
                {
                    case (char)CharacterCodes.tab:
                    case (char)CharacterCodes.verticalTab:
                    case (char)CharacterCodes.formFeed:
                    case (char)CharacterCodes.space:
                        while (pos < end && isWhiteSpaceSingleLine(text[pos]))
                        {
                            pos++;
                        }
                        return token = SyntaxKind.WhitespaceTrivia;
                    case (char)CharacterCodes.at:
                        pos++;
                        return token = SyntaxKind.AtToken;
                    case (char)CharacterCodes.lineFeed:
                    case (char)CharacterCodes.carriageReturn:
                        pos++;
                        return token = SyntaxKind.NewLineTrivia;
                    case (char)CharacterCodes.asterisk:
                        pos++;
                        return token = SyntaxKind.AsteriskToken;
                    case (char)CharacterCodes.openBrace:
                        pos++;
                        return token = SyntaxKind.OpenBraceToken;
                    case (char)CharacterCodes.closeBrace:
                        pos++;
                        return token = SyntaxKind.CloseBraceToken;
                    case (char)CharacterCodes.openBracket:
                        pos++;
                        return token = SyntaxKind.OpenBracketToken;
                    case (char)CharacterCodes.closeBracket:
                        pos++;
                        return token = SyntaxKind.CloseBracketToken;
                    case (char)CharacterCodes.lessThan:
                        pos++;
                        return token = SyntaxKind.LessThanToken;
                    case (char)CharacterCodes.greaterThan:
                        pos++;
                        return token = SyntaxKind.GreaterThanToken;
                    case (char)CharacterCodes.equals:
                        pos++;
                        return token = SyntaxKind.EqualsToken;
                    case (char)CharacterCodes.comma:
                        pos++;
                        return token = SyntaxKind.CommaToken;
                    case (char)CharacterCodes.dot:
                        pos++;
                        return token = SyntaxKind.DotToken;
                }

                if (isIdentifierStart(ch, ScriptTarget.Latest))
                {
                    pos++;
                    while (isIdentifierPart(text[pos], ScriptTarget.Latest) && pos < end)
                    {
                        pos++;
                    }
                    token = SyntaxKind.Identifier;
                    return token;
                }
                else
                {
                    pos += 1;
                    token = SyntaxKind.Unknown;
                    return token;
                }
            }
            public SyntaxKind scan()
            {
                startPos = pos;
                _hasExtendedUnicodeEscape = false;
                precedingLineBreak = false;
                tokenIsUnterminated = false;
                numericLiteralFlags = 0;
                while (true)
                {
                    tokenPos = pos;
                    if (pos >= end)
                    {
                        return token = SyntaxKind.EndOfFileToken;
                    }
                    var ch = text[pos];

                    // Special handling for shebang
                    if (ch == (char)CharacterCodes.hash && pos == 0 && isShebangTrivia(text, pos))
                    {
                        pos = scanShebangTrivia(text, pos);
                        if (skipTrivia)
                        {
                            continue;
                        }
                        else
                        {
                            return token = SyntaxKind.ShebangTrivia;
                        }
                    }

                    switch (ch)
                    {
                        case (char)CharacterCodes.lineFeed:
                        case (char)CharacterCodes.carriageReturn:
                            precedingLineBreak = true;
                            if (skipTrivia)
                            {
                                pos++;
                                continue;
                            }
                            else
                            {
                                if (ch == (char)CharacterCodes.carriageReturn && pos + 1 < end && text[pos + 1] == (char)CharacterCodes.lineFeed)
                                {
                                    // consume both CR and LF
                                    pos += 2;
                                }
                                else
                                {
                                    pos++;
                                }
                                return token = SyntaxKind.NewLineTrivia;
                            }
                        case (char)CharacterCodes.tab:
                        case (char)CharacterCodes.verticalTab:
                        case (char)CharacterCodes.formFeed:
                        case (char)CharacterCodes.space:
                            if (skipTrivia)
                            {
                                pos++;
                                continue;
                            }
                            else
                            {
                                while (pos < end && isWhiteSpaceSingleLine(text[pos]))
                                {
                                    pos++;
                                }
                                return token = SyntaxKind.WhitespaceTrivia;
                            }
                        case (char)CharacterCodes.exclamation:
                            if (text[pos + 1] == (char)CharacterCodes.equals)
                            {
                                if (text[pos + 2] == (char)CharacterCodes.equals)
                                {
                                    pos += 3;
                                    token = SyntaxKind.ExclamationEqualsEqualsToken;
                                    return token;
                                }
                                pos += 2;
                                token = SyntaxKind.ExclamationEqualsToken;
                                return token;
                            }
                            pos++;
                            return token = SyntaxKind.ExclamationToken;
                        case (char)CharacterCodes.doubleQuote:
                        case (char)CharacterCodes.singleQuote:
                            tokenValue = scanString();
                            return token = SyntaxKind.StringLiteral;
                        case (char)CharacterCodes.backtick:
                            return token = scanTemplateAndSetTokenValue();
                        case (char)CharacterCodes.percent:
                            if (text[pos + 1] == (char)CharacterCodes.equals)
                            {
                                pos += 2;
                                token = SyntaxKind.PercentEqualsToken;
                                return token;
                            }
                            pos++;
                            return token = SyntaxKind.PercentToken;
                        case (char)CharacterCodes.ampersand:
                            if (text[pos + 1] == (char)CharacterCodes.ampersand)
                            {
                                pos += 2;
                                token = SyntaxKind.AmpersandAmpersandToken;
                                return token;
                            }
                            if (text[pos + 1] == (char)CharacterCodes.equals)
                            {
                                pos += 2;
                                token = SyntaxKind.AmpersandEqualsToken;
                                return token;
                            }
                            pos++;
                            return token = SyntaxKind.AmpersandToken;
                        case (char)CharacterCodes.openParen:
                            pos++;
                            return token = SyntaxKind.OpenParenToken;
                        case (char)CharacterCodes.closeParen:
                            pos++;
                            return token = SyntaxKind.CloseParenToken;
                        case (char)CharacterCodes.asterisk:
                            if (text[pos + 1] == (char)CharacterCodes.equals)
                            {
                                pos += 2;
                                token = SyntaxKind.AsteriskEqualsToken;
                                return token;
                            }
                            if (text[pos + 1] == (char)CharacterCodes.asterisk)
                            {
                                if (text[pos + 2] == (char)CharacterCodes.equals)
                                {
                                    pos += 3;
                                    token = SyntaxKind.AsteriskAsteriskEqualsToken;
                                    return token;
                                }
                                pos += 2;
                                token = SyntaxKind.AsteriskAsteriskToken;
                                return token;
                            }
                            pos++;
                            return token = SyntaxKind.AsteriskToken;
                        case (char)CharacterCodes.plus:
                            if (text[pos + 1] == (char)CharacterCodes.plus)
                            {
                                pos += 2;
                                token = SyntaxKind.PlusPlusToken;
                                return token;
                            }
                            if (text[pos + 1] == (char)CharacterCodes.equals)
                            {
                                pos += 2;
                                token = SyntaxKind.PlusEqualsToken;
                                return token;
                            }
                            pos++;
                            return token = SyntaxKind.PlusToken;
                        case (char)CharacterCodes.comma:
                            pos++;
                            return token = SyntaxKind.CommaToken;
                        case (char)CharacterCodes.minus:
                            if (text[pos + 1] == (char)CharacterCodes.minus)
                            {
                                pos += 2;
                                token = SyntaxKind.MinusMinusToken;
                                return token;
                            }
                            if (text[pos + 1] == (char)CharacterCodes.equals)
                            {
                                pos += 2;
                                token = SyntaxKind.MinusEqualsToken;
                                return token;
                            }
                            pos++;
                            return token = SyntaxKind.MinusToken;
                        case (char)CharacterCodes.dot:
                            if (isDigit(text[pos + 1]))
                            {
                                tokenValue = scanNumber();
                                token = SyntaxKind.NumericLiteral;
                                return token;
                            }
                            if (text[pos + 1] == (char)CharacterCodes.dot && text[pos + 2] == (char)CharacterCodes.dot)
                            {
                                pos += 3;
                                token = SyntaxKind.DotDotDotToken;
                                return token;
                            }
                            pos++;
                            return token = SyntaxKind.DotToken;
                        case (char)CharacterCodes.slash:
                            // Single-line comment
                            if (text[pos + 1] == (char)CharacterCodes.slash)
                            {
                                pos += 2;

                                while (pos < end)
                                {
                                    if (isLineBreak(text[pos]))
                                    {
                                        break;
                                    }
                                    pos++;

                                }

                                if (skipTrivia)
                                {
                                    continue;
                                }
                                else
                                {
                                    return token = SyntaxKind.SingleLineCommentTrivia;
                                }
                            }
                            // Multi-line comment
                            if (text[pos + 1] == (char)CharacterCodes.asterisk)
                            {
                                pos += 2;

                                var commentClosed = false;
                                while (pos < end)
                                {
                                    var _ch = text[pos];

                                    if (_ch == (char)CharacterCodes.asterisk && text[pos + 1] == (char)CharacterCodes.slash)
                                    {
                                        pos += 2;
                                        commentClosed = true;
                                        break;
                                    }

                                    if (isLineBreak(_ch))
                                    {
                                        precedingLineBreak = true;
                                    }
                                    pos++;
                                }

                                if (!commentClosed)
                                {
                                    error(Diagnostics.Asterisk_Slash_expected);
                                }

                                if (skipTrivia)
                                {
                                    continue;
                                }
                                else
                                {
                                    tokenIsUnterminated = !commentClosed;
                                    return token = SyntaxKind.MultiLineCommentTrivia;
                                }
                            }

                            if (text[pos + 1] == (char)CharacterCodes.equals)
                            {
                                pos += 2;
                                token = SyntaxKind.SlashEqualsToken;
                                return token;
                            }

                            pos++;
                            return token = SyntaxKind.SlashToken;

                        case (char)CharacterCodes._0:
                            if (pos + 2 < end && (text[pos + 1] == (char)CharacterCodes.X || text[pos + 1] == (char)CharacterCodes.x))
                            {
                                pos += 2;
                                var value = scanMinimumNumberOfHexDigits(1);
                                if (value < 0)
                                {
                                    error(Diagnostics.Hexadecimal_digit_expected);
                                    value = 0;
                                }
                                tokenValue = "" + value;
                                numericLiteralFlags = NumericLiteralFlags.HexSpecifier;
                                return token = SyntaxKind.NumericLiteral;
                            }
                            else if (pos + 2 < end && (text[pos + 1] == (char)CharacterCodes.B || text[pos + 1] == (char)CharacterCodes.b))
                            {
                                pos += 2;
                                var value = scanBinaryOrOctalDigits(/* base */ 2);
                                if (value < 0)
                                {
                                    error(Diagnostics.Binary_digit_expected);
                                    value = 0;
                                }
                                tokenValue = "" + value;
                                numericLiteralFlags = NumericLiteralFlags.BinarySpecifier;
                                return token = SyntaxKind.NumericLiteral;
                            }
                            else if (pos + 2 < end && (text[pos + 1] == (char)CharacterCodes.O || text[pos + 1] == (char)CharacterCodes.o))
                            {
                                pos += 2;
                                var value = scanBinaryOrOctalDigits(/* base */ 8);
                                if (value < 0)
                                {
                                    error(Diagnostics.Octal_digit_expected);
                                    value = 0;
                                }
                                tokenValue = "" + value;
                                numericLiteralFlags = NumericLiteralFlags.OctalSpecifier;
                                return token = SyntaxKind.NumericLiteral;
                            }
                            // Try to parse as an octal
                            if (pos + 1 < end && isOctalDigit(text[pos + 1]))
                            {
                                tokenValue = "" + scanOctalDigits();
                                numericLiteralFlags = NumericLiteralFlags.Octal;
                                return token = SyntaxKind.NumericLiteral;
                            }
                            tokenValue = scanNumber();
                            return token = SyntaxKind.NumericLiteral;
                        // This fall-through is a deviation from the EcmaScript grammar. The grammar says that a leading zero
                        // can only be followed by an octal digit, a dot, or the end of the number literal. However, we are being
                        // permissive and allowing decimal digits of the form 08* and 09* (which many browsers also do).
                        // falls through
                        case (char)CharacterCodes._1:
                        case (char)CharacterCodes._2:
                        case (char)CharacterCodes._3:
                        case (char)CharacterCodes._4:
                        case (char)CharacterCodes._5:
                        case (char)CharacterCodes._6:
                        case (char)CharacterCodes._7:
                        case (char)CharacterCodes._8:
                        case (char)CharacterCodes._9:
                            tokenValue = scanNumber();
                            return token = SyntaxKind.NumericLiteral;
                        case (char)CharacterCodes.colon:
                            pos++;
                            return token = SyntaxKind.ColonToken;
                        case (char)CharacterCodes.semicolon:
                            pos++;
                            return token = SyntaxKind.SemicolonToken;
                        case (char)CharacterCodes.lessThan:
                            if (isConflictMarkerTrivia(text, pos))
                            {
                                pos = scanConflictMarkerTrivia(text, pos, error);
                                if (skipTrivia)
                                {
                                    continue;
                                }
                                else
                                {
                                    return token = SyntaxKind.ConflictMarkerTrivia;
                                }
                            }

                            if (text[pos + 1] == (char)CharacterCodes.lessThan)
                            {
                                if (text[pos + 2] == (char)CharacterCodes.equals)
                                {
                                    pos += 3;
                                    token = SyntaxKind.LessThanLessThanEqualsToken;
                                    return token;
                                }
                                pos += 2;
                                token = SyntaxKind.LessThanLessThanToken;
                                return token;
                            }
                            if (text[pos + 1] == (char)CharacterCodes.equals)
                            {
                                pos += 2;
                                token = SyntaxKind.LessThanEqualsToken;
                                return token;
                            }
                            if (languageVariant == LanguageVariant.JSX &&
                                    text[pos + 1] == (char)CharacterCodes.slash &&
                                    text[pos + 2] != (char)CharacterCodes.asterisk)
                            {
                                pos += 2;
                                token = SyntaxKind.LessThanSlashToken;
                                return token;
                            }
                            pos++;
                            return token = SyntaxKind.LessThanToken;
                        case (char)CharacterCodes.equals:
                            if (isConflictMarkerTrivia(text, pos))
                            {
                                pos = scanConflictMarkerTrivia(text, pos, error);
                                if (skipTrivia)
                                {
                                    continue;
                                }
                                else
                                {
                                    return token = SyntaxKind.ConflictMarkerTrivia;
                                }
                            }

                            if (text[pos + 1] == (char)CharacterCodes.equals)
                            {
                                if (text[pos + 2] == (char)CharacterCodes.equals)
                                {
                                    pos += 3;
                                    token = SyntaxKind.EqualsEqualsEqualsToken;
                                    return token;
                                }
                                pos += 2;
                                token = SyntaxKind.EqualsEqualsToken;
                                return token;
                            }
                            if (text[pos + 1] == (char)CharacterCodes.greaterThan)
                            {
                                pos += 2;
                                token = SyntaxKind.EqualsGreaterThanToken;
                                return token;
                            }
                            pos++;
                            return token = SyntaxKind.EqualsToken;
                        case (char)CharacterCodes.greaterThan:
                            if (isConflictMarkerTrivia(text, pos))
                            {
                                pos = scanConflictMarkerTrivia(text, pos, error);
                                if (skipTrivia)
                                {
                                    continue;
                                }
                                else
                                {
                                    return token = SyntaxKind.ConflictMarkerTrivia;
                                }
                            }

                            pos++;
                            return token = SyntaxKind.GreaterThanToken;
                        case (char)CharacterCodes.question:
                            pos++;
                            return token = SyntaxKind.QuestionToken;
                        case (char)CharacterCodes.openBracket:
                            pos++;
                            return token = SyntaxKind.OpenBracketToken;
                        case (char)CharacterCodes.closeBracket:
                            pos++;
                            return token = SyntaxKind.CloseBracketToken;
                        case (char)CharacterCodes.caret:
                            if (text[pos + 1] == (char)CharacterCodes.equals)
                            {
                                pos += 2;
                                token = SyntaxKind.CaretEqualsToken;
                                return token;
                            }
                            pos++;
                            return token = SyntaxKind.CaretToken;
                        case (char)CharacterCodes.openBrace:
                            pos++;
                            return token = SyntaxKind.OpenBraceToken;
                        case (char)CharacterCodes.bar:
                            if (isConflictMarkerTrivia(text, pos))
                            {
                                pos = scanConflictMarkerTrivia(text, pos, error);
                                if (skipTrivia)
                                {
                                    continue;
                                }
                                else
                                {
                                    return token = SyntaxKind.ConflictMarkerTrivia;
                                }
                            }

                            if (text[pos + 1] == (char)CharacterCodes.bar)
                            {
                                pos += 2;
                                token = SyntaxKind.BarBarToken;
                                return token;
                            }
                            if (text[pos + 1] == (char)CharacterCodes.equals)
                            {
                                pos += 2;
                                token = SyntaxKind.BarEqualsToken;
                                return token;
                            }
                            pos++;
                            return token = SyntaxKind.BarToken;
                        case (char)CharacterCodes.closeBrace:
                            pos++;
                            return token = SyntaxKind.CloseBraceToken;
                        case (char)CharacterCodes.tilde:
                            pos++;
                            return token = SyntaxKind.TildeToken;
                        case (char)CharacterCodes.at:
                            pos++;
                            return token = SyntaxKind.AtToken;
                        case (char)CharacterCodes.backslash:
                            var cookedChar = peekUnicodeEscape();
                            if (cookedChar >= 0 && isIdentifierStart(cookedChar, languageVersion))
                            {
                                pos += 6;
                                tokenValue = ((char)cookedChar).ToString() + scanIdentifierParts();
                                return token = getIdentifierToken();
                            }
                            error(Diagnostics.Invalid_character);
                            pos++;
                            return token = SyntaxKind.Unknown;
                        default:
                            if (isIdentifierStart(ch, languageVersion))
                            {
                                pos++;
                                while (pos < end && isIdentifierPart(ch = text[pos], languageVersion)) pos++;
                                tokenValue = Substring(text, tokenPos, pos);
                                if (ch == (char)CharacterCodes.backslash)
                                {
                                    tokenValue += scanIdentifierParts();
                                }
                                return token = getIdentifierToken();
                            }
                            else if (isWhiteSpaceSingleLine(ch))
                            {
                                pos++;
                                continue;
                            }
                            else if (isLineBreak(ch))
                            {
                                precedingLineBreak = true;
                                pos++;
                                continue;
                            }
                            error(Diagnostics.Invalid_character);
                            pos++;
                            return token = SyntaxKind.Unknown;
                    }
                }
            }
            public string getText()
            {
                return text;
            }
            // Sets the text for the scanner to scan.  An optional subrange starting point and length
            // can be provided to have the scanner only scan a portion of the text.
            public void setText(string newText, int start = 0, int length = 0)
            {
                text = newText != null ? newText : "";
                end = length == 0 ? text.Length : start + length;
                setTextPos(start);
            }
            public void setOnError(ErrorCallback errorCallback)
            {
                this.onError = errorCallback;
            }
            public void setScriptTarget(ScriptTarget scriptTarget)
            {
                languageVersion = scriptTarget;
            }
            public void setLanguageVariant(LanguageVariant variant)
            {
                languageVariant = variant;
            }
            public void setTextPos(int textPos)
            {
                System.Diagnostics.Debug.Assert(textPos >= 0);
                pos = textPos;
                startPos = textPos;
                tokenPos = textPos;
                token = SyntaxKind.Unknown;
                precedingLineBreak = false;

                tokenValue = null;
                _hasExtendedUnicodeEscape = false;
                tokenIsUnterminated = false;
            }
            // Invokes the provided callback then unconditionally restores the scanner to the state it
            // was in immediately prior to invoking the callback.  The result of invoking the callback
            // is returned from this function.
            //    lookAhead<T>(callback: () => T): T;

            public delegate T TCallBack<T>();
            T speculationHelper<T>(TCallBack<T> callback, bool isLookahead)
            {
                var savePos = pos;
                var saveStartPos = startPos;
                var saveTokenPos = tokenPos;
                var saveToken = token;
                var saveTokenValue = tokenValue;
                var savePrecedingLineBreak = precedingLineBreak;
                var result = callback();

                // If our callback returned something 'falsy' or we're just looking ahead,
                // then unconditionally restore us to where we were.
                if (result == null || isLookahead)
                {
                    pos = savePos;
                    startPos = saveStartPos;
                    tokenPos = saveTokenPos;
                    token = saveToken;
                    tokenValue = saveTokenValue;
                    precedingLineBreak = savePrecedingLineBreak;
                }
                return result;
            }


            public T lookAhead<T>(TCallBack<T> callback)
            {
                return speculationHelper(callback, /*isLookahead*/ true);
            }
            //// Invokes the callback with the scanner set to scan the specified range. When the callback
            //// returns, the scanner is restored to the state it was in before scanRange was called.
            public T scanRange<T>(int start, int length, TCallBack<T> callback)
            {
                var saveEnd = end;
                var savePos = pos;
                var saveStartPos = startPos;
                var saveTokenPos = tokenPos;
                var saveToken = token;
                var savePrecedingLineBreak = precedingLineBreak;
                var saveTokenValue = tokenValue;
                var saveHasExtendedUnicodeEscape = _hasExtendedUnicodeEscape;
                var saveTokenIsUnterminated = tokenIsUnterminated;

                setText(text, start, length);
                var result = callback();

                end = saveEnd;
                pos = savePos;
                startPos = saveStartPos;
                tokenPos = saveTokenPos;
                token = saveToken;
                precedingLineBreak = savePrecedingLineBreak;
                tokenValue = saveTokenValue;
                _hasExtendedUnicodeEscape = saveHasExtendedUnicodeEscape;
                tokenIsUnterminated = saveTokenIsUnterminated;

                return result;

            }

            //// Invokes the provided callback.  If the callback returns something falsy, then it restores
            //// the scanner to the state it was in immediately prior to invoking the callback.  If the
            //// callback returns something truthy, then the scanner state is not rolled back.  The result
            //// of invoking the callback is returned from this function.
            public T tryScan<T>(TCallBack<T> callback)
            {
                return speculationHelper(callback, /*isLookahead*/ false);
            }

            void error(DiagnosticMessage message, int length = 0)
            {
                if (onError != null)
                {
                    onError(message, length);
                }
            }
            SyntaxKind scanTemplateAndSetTokenValue()
            {
                var startedWithBacktick = text[pos] == (char)CharacterCodes.backtick;

                pos++;
                var start = pos;
                var contents = "";
                SyntaxKind? resultingToken = null;

                while (true)
                {
                    if (pos >= end)
                    {
                        contents += Substring(text, start, pos);
                        tokenIsUnterminated = true;
                        error(Diagnostics.Unterminated_template_literal);
                        resultingToken = startedWithBacktick ? SyntaxKind.NoSubstitutionTemplateLiteral : SyntaxKind.TemplateTail;
                        break;
                    }

                    var currChar = text[pos];

                    // '`'
                    if (currChar == (char)CharacterCodes.backtick)
                    {
                        contents += Substring(text, start, pos);
                        pos++;
                        resultingToken = startedWithBacktick ? SyntaxKind.NoSubstitutionTemplateLiteral : SyntaxKind.TemplateTail;
                        break;
                    }

                    // '${'
                    if (currChar == (char)CharacterCodes._doller_ && pos + 1 < end && text[pos + 1] == (char)CharacterCodes.openBrace)
                    {
                        contents += Substring(text, start, pos);
                        pos += 2;
                        resultingToken = startedWithBacktick ? SyntaxKind.TemplateHead : SyntaxKind.TemplateMiddle;
                        break;
                    }

                    // Escape character
                    if (currChar == (char)CharacterCodes.backslash)
                    {
                        contents += Substring(text, start, pos);
                        contents += scanEscapeSequence();
                        start = pos;
                        continue;
                    }

                    // Speculated ECMAScript 6 Spec 11.8.6.1:
                    // <CR><LF> and <CR> LineTerminatorSequences are normalized to <LF> for Template Values
                    if (currChar == (char)CharacterCodes.carriageReturn)
                    {
                        contents += Substring(text, start, pos);
                        pos++;

                        if (pos < end && text[pos] == (char)CharacterCodes.lineFeed)
                        {
                            pos++;
                        }

                        contents += "\n";
                        start = pos;
                        continue;
                    }

                    pos++;
                }

                System.Diagnostics.Debug.Assert(resultingToken != null);

                tokenValue = contents;
                return resultingToken.Value;
            }

            string scanEscapeSequence()
            {
                pos++;
                if (pos >= end)
                {
                    error(Diagnostics.Unexpected_end_of_text);
                    return "";
                }
                var ch = text[pos];
                pos++;
                switch (ch)
                {
                    case (char)CharacterCodes._0:
                        return "\0";
                    case (char)CharacterCodes.b:
                        return "\b";
                    case (char)CharacterCodes.t:
                        return "\t";
                    case (char)CharacterCodes.n:
                        return "\n";
                    case (char)CharacterCodes.v:
                        return "\v";
                    case (char)CharacterCodes.f:
                        return "\f";
                    case (char)CharacterCodes.r:
                        return "\r";
                    case (char)CharacterCodes.singleQuote:
                        return "\'";
                    case (char)CharacterCodes.doubleQuote:
                        return "\"";
                    case (char)CharacterCodes.u:
                        // '\u{DDDDDDDD}'
                        if (pos < end && text[pos] == (char)CharacterCodes.openBrace)
                        {
                            _hasExtendedUnicodeEscape = true;
                            pos++;
                            return scanExtendedUnicodeEscape();
                        }

                        // '\uDDDD'
                        return scanHexadecimalEscape(/*numDigits*/ 4);

                    case (char)CharacterCodes.x:
                        // '\xDD'
                        return scanHexadecimalEscape(/*numDigits*/ 2);

                    // when encountering a LineContinuation (i.e. a backslash and a line terminator sequence),
                    // the line terminator is interpreted to be "the empty code unit sequence".
                    case (char)CharacterCodes.carriageReturn:
                        if (pos < end && text[pos] == (char)CharacterCodes.lineFeed)
                        {
                            pos++;
                        }
                        return "";
                    // falls through
                    case (char)CharacterCodes.lineFeed:
                    case (char)CharacterCodes.lineSeparator:
                    case (char)CharacterCodes.paragraphSeparator:
                        return "";
                    default:
                        return ch.ToString();
                }
            }
            string scanExtendedUnicodeEscape()
            {
                var escapedValue = scanMinimumNumberOfHexDigits(1);
                var isInvalidExtendedEscape = false;

                // Validate the value of the digit
                if (escapedValue < 0)
                {
                    error(Diagnostics.Hexadecimal_digit_expected);
                    isInvalidExtendedEscape = true;
                }
                else if (escapedValue > 0x10FFFF)
                {
                    error(Diagnostics.An_extended_Unicode_escape_value_must_be_between_0x0_and_0x10FFFF_inclusive);
                    isInvalidExtendedEscape = true;
                }

                if (pos >= end)
                {
                    error(Diagnostics.Unexpected_end_of_text);
                    isInvalidExtendedEscape = true;
                }
                else if (text[pos] == (char)CharacterCodes.closeBrace)
                {
                    // Only swallow the following character up if it's a '}'.
                    pos++;
                }
                else
                {
                    error(Diagnostics.Unterminated_Unicode_escape_sequence);
                    isInvalidExtendedEscape = true;
                }

                if (isInvalidExtendedEscape)
                {
                    return "";
                }

                return utf16EncodeAsString(escapedValue);
            }
            int scanMinimumNumberOfHexDigits(int count)
            {
                return scanHexDigits(/*minCount*/ count, /*scanAsManyAsPossible*/ true);
            }
            int scanHexDigits(int minCount, bool scanAsManyAsPossible)
            {
                var digits = 0;
                var value = 0;
                while (digits < minCount || scanAsManyAsPossible)
                {
                    var ch = text[pos];
                    if (ch >= (char)CharacterCodes._0 && ch <= (char)CharacterCodes._9)
                    {
                        value = value * 16 + ch - (char)CharacterCodes._0;
                    }
                    else if (ch >= (char)CharacterCodes.A && ch <= (char)CharacterCodes.F)
                    {
                        value = value * 16 + ch - (char)CharacterCodes.A + 10;
                    }
                    else if (ch >= (char)CharacterCodes.a && ch <= (char)CharacterCodes.f)
                    {
                        value = value * 16 + ch - (char)CharacterCodes.a + 10;
                    }
                    else
                    {
                        break;
                    }
                    pos++;
                    digits++;
                }
                if (digits < minCount)
                {
                    value = -1;
                }
                return value;
            }
            string scanHexadecimalEscape(int numDigits)
            {
                var escapedValue = scanExactNumberOfHexDigits(numDigits);

                if (escapedValue >= 0)
                {
                    return escapedValue.ToString();
                }
                else
                {
                    error(Diagnostics.Hexadecimal_digit_expected);
                    return "";
                }
            }
            int scanExactNumberOfHexDigits(int count)
            {
                return scanHexDigits(/*minCount*/ count, /*scanAsManyAsPossible*/ false);
            }
            string scanString(bool allowEscapes = true)
            {
                var quote = text[pos];
                pos++;
                var result = "";
                var start = pos;
                while (true)
                {
                    if (pos >= end)
                    {
                        result += Substring(text, start, pos);
                        tokenIsUnterminated = true;
                        error(Diagnostics.Unterminated_string_literal);
                        break;
                    }
                    var ch = text[pos];
                    if (ch == quote)
                    {
                        result += Substring(text, start, pos);
                        pos++;
                        break;
                    }
                    if (ch == (char)CharacterCodes.backslash && allowEscapes)
                    {
                        result += Substring(text, start, pos);
                        result += scanEscapeSequence();
                        start = pos;
                        continue;
                    }
                    if (isLineBreak(ch))
                    {
                        result += Substring(text, start, pos);
                        tokenIsUnterminated = true;
                        error(Diagnostics.Unterminated_string_literal);
                        break;
                    }
                    pos++;
                }
                return result;
            }
            int scanConflictMarkerTrivia(string text, int pos, ErrorCallback error = null)
            {
                if (error != null)
                {
                    error(Diagnostics.Merge_conflict_marker_encountered, mergeConflictMarkerLength);
                }

                var ch = text[pos];
                var len = text.Length;

                if (ch == (char)CharacterCodes.lessThan || ch == (char)CharacterCodes.greaterThan)
                {
                    while (pos < len && !isLineBreak(text[pos]))
                    {
                        pos++;
                    }
                }
                else
                {
                    System.Diagnostics.Debug.Assert(ch == (char)CharacterCodes.bar || ch == (char)CharacterCodes.equals);
                    // Consume everything from the start of a ||||||| or ======= marker to the start
                    // of the next ======= or >>>>>>> marker.
                    while (pos < len)
                    {
                        var currentChar = text[pos];
                        if ((currentChar == (char)CharacterCodes.equals || currentChar == (char)CharacterCodes.greaterThan) && currentChar != ch && isConflictMarkerTrivia(text, pos))
                        {
                            break;
                        }

                        pos++;
                    }
                }

                return pos;
            }

            string scanNumber()
            {
                var start = pos;
                while (pos < text.Length && isDigit(text[pos])) pos++;
                if (pos < text.Length && text[pos] == (char)CharacterCodes.dot)
                {
                    pos++;
                    while (isDigit(text[pos])) pos++;
                }
                var end = pos;
                if (pos < text.Length && (text[pos] == (char)CharacterCodes.E || text[pos] == (char)CharacterCodes.e))
                {
                    pos++;
                    numericLiteralFlags = NumericLiteralFlags.Scientific;
                    if (text[pos] == (char)CharacterCodes.plus || text[pos] == (char)CharacterCodes.minus) pos++;
                    if (isDigit(text[pos]))
                    {
                        pos++;
                        while (isDigit(text[pos])) pos++;
                        end = pos;
                    }
                    else
                    {
                        error(Diagnostics.Digit_expected);
                    }
                }
                return "" + (Substring(text, start, end));
            }
            int scanBinaryOrOctalDigits(int _base)
            {
                System.Diagnostics.Debug.Assert(_base == 2 || _base == 8, "Expected either base 2 or base 8");

                var value = 0;
                // For counting number of digits; Valid binaryIntegerLiteral must have at least one binary digit following B or b.
                // Similarly valid octalIntegerLiteral must have at least one octal digit following o or O.
                var numberOfDigits = 0;
                while (true)
                {
                    var ch = text[pos];
                    var valueOfCh = ch - (char)CharacterCodes._0;
                    if (!isDigit(ch) || valueOfCh >= _base)
                    {
                        break;
                    }
                    value = value * _base + valueOfCh;
                    pos++;
                    numberOfDigits++;
                }
                // Invalid binaryIntegerLiteral or octalIntegerLiteral
                if (numberOfDigits == 0)
                {
                    return -1;
                }
                return value;
            }
            int scanOctalDigits()
            {
                var start = pos;
                while (isOctalDigit(text[pos]))
                {
                    pos++;
                }
                return int.Parse(Substring(text, start, pos));
            }

            int peekUnicodeEscape()
            {
                if (pos + 5 < end && text[pos + 1] == (char)CharacterCodes.u)
                {
                    var start = pos;
                    pos += 2;
                    var value = scanExactNumberOfHexDigits(4);
                    pos = start;
                    return value;
                }
                return -1;
            }
            string scanIdentifierParts()
            {
                var result = "";
                var start = pos;
                while (pos < end)
                {
                    int ch = text[pos];
                    if (isIdentifierPart((char)ch, languageVersion))
                    {
                        pos++;
                    }
                    else if (ch == (char)CharacterCodes.backslash)
                    {
                        ch = peekUnicodeEscape();
                        if (!(ch >= 0 && isIdentifierPart((char)ch, languageVersion)))
                        {
                            break;
                        }
                        result += Substring(text, start, pos);
                        result += ch.ToString();
                        // Valid Unicode escape is always six characters
                        pos += 6;
                        start = pos;
                    }
                    else
                    {
                        break;
                    }
                }
                result += Substring(text, start, pos);
                return result;
            }
            SyntaxKind getIdentifierToken()
            {
                // Reserved words are between 2 and 11 characters long and start with a lowercase letter
                var len = tokenValue.Length;
                if (len >= 2 && len <= 11)
                {
                    var ch = tokenValue[0];
                    if (ch >= (char)CharacterCodes.a && ch <= (char)CharacterCodes.z)
                    {
                        if (textToToken.ContainsKey(tokenValue))
                        {
                            return textToToken[tokenValue];
                        }
                        //token = textToToken.get(tokenValue);
                        //if (token != null)
                        //{
                        //    return token;
                        //}
                    }
                }
                return token = SyntaxKind.Identifier;
            }
            //funcend
        }

    }

}
