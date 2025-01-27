/*
 * Characters.cs --
 *
 * Copyright (c) 2007-2012 by Joe Mistachkin.  All rights reserved.
 *
 * See the file "license.terms" for information on usage and redistribution of
 * this file, and for a DISCLAIMER OF ALL WARRANTIES.
 *
 * RCS: @(#) $Id: $
 */

using Eagle._Attributes;
using Eagle._Containers.Private;
using Eagle._Containers.Public;

namespace Eagle._Components.Public
{
    [ObjectId("16571e1f-4c2f-4ce2-95f4-49ebbcae3d79")]
    public static class Characters
    {
        public const char Null = '\0';
        public const char Bell = '\a';
        public const char Backspace = '\b';
        public const char HorizontalTab = '\t';
        public const char LineFeed = '\n';
        public const char VerticalTab = '\v';
        public const char FormFeed = '\f';
        public const char CarriageReturn = '\r';
        public const char NewLine = LineFeed;
        public const char EndOfFile = '\x1A';
        public const char EndOfTransmission = '\x04';

        ///////////////////////////////////////////////////////////////////////////////////////////////

        public const char NextLine = '\u0085';
        public const char LineSeparator = '\u2028';
        public const char ParagraphSeparator = '\u2029';

        ///////////////////////////////////////////////////////////////////////////////////////////////

        public const char Space = ' ';
        public const char Underscore = '_';
        public const char Colon = ':';
        public const char Comma = ',';
        public const char SemiColon = ';';
        public const char Backslash = '\\';
        public const char AtSign = '@';
        public const char NumberSign = '#';
        public const char DollarSign = '$';
        public const char OpenParenthesis = '(';
        public const char CloseParenthesis = ')';
        public const char CircumflexAccent = '^';
        public const char VerticalLine = '|';
        public const char OpenBrace = '{';
        public const char CloseBrace = '}';
        public const char QuotationMark = '"';
        public const char Apostrophe = '\'';
        public const char OpenBracket = '[';
        public const char CloseBracket = ']';
        public const char PercentSign = '%';
        public const char QuestionMark = '?';
        public const char LessThanSign = '<';
        public const char EqualSign = '=';
        public const char GreaterThanSign = '>';
        public const char ExclamationMark = '!';
        public const char Ampersand = '&';
        public const char GraveAccent = '`';
        public const char Tilde = '~';
        public const char Asterisk = '*';
        public const char PlusSign = '+';
        public const char MinusSign = '-';
        public const char Slash = '/';
        public const char Period = '.';
        public const char Delete = '';

        ///////////////////////////////////////////////////////////////////////////////////////////////

        public const char Copyright = '©'; // U+00A9
        public const char SectionSign = '§'; // U+00A7
        public const char PilcrowSign = '¶'; // U+00B6
        public const char BellSymbol = '␇'; // U+2407
        public const char Angzarr = '⍼'; // U+237C

        ///////////////////////////////////////////////////////////////////////////////////////////////

        public const char MaximumNonSurrogate = '퟿'; // U+D7FF
        public const char MinimumPrivateUse = ''; // U+E000
        public const char BackspaceSymbol = '␈'; // U+2408
        public const char ObjectReplacement = '￼'; // U+FFFC
        public const char Replacement = '�'; // U+FFFD
        public const char NonCharacter1 = '￾'; // U+FFFE
        public const char NonCharacter2 = '￿'; // U+FFFF

        ///////////////////////////////////////////////////////////////////////////////////////////////

        public const char VisualNull = ' '; // U+00A0
        public const char VisualHorizontalTab = '»'; // U+00BB
        public const char VisualVerticalTab = '«'; // U+00AB
        public const char VisualFormFeed = '°'; // U+00B0
        public const char VisualSpace = '·'; // U+00B7

        ///////////////////////////////////////////////////////////////////////////////////////////////

        public const char LeftwardsArrow = '←'; // U+2190
        public const char UpwardsArrow = '↑'; // U+2191
        public const char RightwardsArrow = '→'; // U+2192
        public const char DownwardsArrow = '↓'; // U+2193
        public const char FullBlock = '█'; // U+2588

        ///////////////////////////////////////////////////////////////////////////////////////////////

        internal static readonly char[] WhiteSpace_Unicode = {
            BellSymbol, BackspaceSymbol, LeftwardsArrow, UpwardsArrow,
            RightwardsArrow, DownwardsArrow, FullBlock
        };

        internal static readonly char[] WhiteSpace_Extended = {
            SectionSign, PilcrowSign, VisualNull, VisualVerticalTab,
            VisualFormFeed, VisualSpace, VisualHorizontalTab
        };

        ///////////////////////////////////////////////////////////////////////////////////////////////

        public const string CopyrightAnsi = "(c)";

        ///////////////////////////////////////////////////////////////////////////////////////////////

        public const char Caret = CircumflexAccent; // non-standard name
        public const char Pipe = VerticalLine;      // non-standard name
        public const char Comment = NumberSign;     // non-standard name
        public const char AltComment = SemiColon;   // non-standard name

        ///////////////////////////////////////////////////////////////////////////////////////////////

        public const char Zero = '0';
        public const char One = '1';
        public const char Two = '2';
        public const char Three = '3';
        public const char Four = '4';
        public const char Five = '5';
        public const char Six = '6';
        public const char Seven = '7';
        public const char Eight = '8';
        public const char Nine = '9';

        ///////////////////////////////////////////////////////////////////////////////////////////////

        public const char A = 'A';
        public const char B = 'B';
        public const char C = 'C';
        public const char D = 'D';
        public const char E = 'E';
        public const char F = 'F';
        public const char G = 'G';
        public const char H = 'H';
        public const char I = 'I';
        public const char J = 'J';
        public const char K = 'K';
        public const char L = 'L';
        public const char M = 'M';
        public const char N = 'N';
        public const char O = 'O';
        public const char P = 'P';
        public const char Q = 'Q';
        public const char R = 'R';
        public const char S = 'S';
        public const char T = 'T';
        public const char U = 'U';
        public const char V = 'V';
        public const char W = 'W';
        public const char X = 'X';
        public const char Y = 'Y';
        public const char Z = 'Z';

        ///////////////////////////////////////////////////////////////////////////////////////////////

        public const char a = 'a';
        public const char b = 'b';
        public const char c = 'c';
        public const char d = 'd';
        public const char e = 'e';
        public const char f = 'f';
        public const char g = 'g';
        public const char h = 'h';
        public const char i = 'i';
        public const char j = 'j';
        public const char k = 'k';
        public const char l = 'l';
        public const char m = 'm';
        public const char n = 'n';
        public const char o = 'o';
        public const char p = 'p';
        public const char q = 'q';
        public const char r = 'r';
        public const char s = 's';
        public const char t = 't';
        public const char u = 'u';
        public const char v = 'v';
        public const char w = 'w';
        public const char x = 'x';
        public const char y = 'y';
        public const char z = 'z';

        ///////////////////////////////////////////////////////////////////////////////////////////////

        //
        // HACK: Used by Parser to help limit the number of calls to StringBuilder.Append.
        //
        internal static readonly char[] OpenBrace_CloseBrace = { OpenBrace, CloseBrace };
        internal static readonly char[] Backslash_OpenBrace = { Backslash, OpenBrace };
        internal static readonly char[] Backslash_NumberSign = { Backslash, NumberSign };
        internal static readonly char[] Backslash_t = { Backslash, t };
        internal static readonly char[] Backslash_n = { Backslash, n };
        internal static readonly char[] Backslash_v = { Backslash, v };
        internal static readonly char[] Backslash_f = { Backslash, f };
        internal static readonly char[] Backslash_r = { Backslash, r };

        ///////////////////////////////////////////////////////////////////////////////////////////////

        public const int HexChars = sizeof(char) * 2;
        public const int TwoHexChars = HexChars * 2;

        ///////////////////////////////////////////////////////////////////////////////////////////////

        public static readonly string Indent = "  ";

        internal static readonly string CarriageReturnString =
            CarriageReturn.ToString();

        internal static readonly string LineFeedString =
            LineFeed.ToString();

        public static readonly string DosNewLine =
            CarriageReturnString + LineFeedString;

        public static readonly string AcornOsNewLine =
            LineFeedString + CarriageReturnString;

        public static readonly string UnixNewLine =
            LineFeedString;

        ///////////////////////////////////////////////////////////////////////////////////////////////

        internal static readonly char[] DigitChars = {
            Zero, One, Two, Three, Four,
            Five, Six, Seven, Eight, Nine
        };

        ///////////////////////////////////////////////////////////////////////////////////////////////

        internal static readonly char[] UpperAlphabetChars = {
            A, B, C, D, E, F, G, H, I, J, K, L, M,
            N, O, P, Q, R, S, T, U, V, W, X, Y, Z
        };

        ///////////////////////////////////////////////////////////////////////////////////////////////

        internal static readonly char[] LowerAlphabetChars = {
            a, b, c, d, e, f, g, h, i, j, k, l, m,
            n, o, p, q, r, s, t, u, v, w, x, y, z
        };

        ///////////////////////////////////////////////////////////////////////////////////////////////

        #region Dead Code
#if DEAD_CODE
        private static readonly char[] CoreReservedChars = {
            Null, HorizontalTab, LineFeed, VerticalTab, FormFeed,
            CarriageReturn, Space, QuotationMark, NumberSign,
            DollarSign, OpenParenthesis, CloseParenthesis, SemiColon,
            OpenBracket, Backslash, CloseBracket, OpenBrace, CloseBrace
        };

        ///////////////////////////////////////////////////////////////////////////////////////////////

        //
        // NOTE: These characters have special meaning in patterns for the
        //       [glob] command.
        //
        private static readonly char[] GlobReservedChars = {
            QuestionMark, Asterisk, OpenBracket, Backslash, CloseBracket,
            OpenBrace, CloseBrace
        };
#endif
        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////////

#if TEST
        //
        // NOTE: Where "reserved" means quoted by the ConvertElement function.
        //
        private static readonly char[] ListReservedChars = {
            HorizontalTab, LineFeed, VerticalTab, FormFeed, CarriageReturn,
            Space, QuotationMark, NumberSign, DollarSign, SemiColon,
            OpenBracket, Backslash, CloseBracket, OpenBrace, CloseBrace
        };
#endif

        ///////////////////////////////////////////////////////////////////////////////////////////////

        //
        // NOTE: These characters have special meaning in patterns for the
        //       [string match] command.
        //
        internal static readonly char[] StringMatchReservedChars = {
            QuestionMark, Asterisk, OpenBracket, Backslash, CloseBracket
        };

        ///////////////////////////////////////////////////////////////////////////////////////////////

        #region Dead Code
#if DEAD_CODE
        //
        // NOTE: These characters have special meaning in patterns for the
        //       [regexp] command.
        //
        private static readonly char[] RegExpReservedChars = {
            ExclamationMark, DollarSign, OpenParenthesis, CloseParenthesis,
            Asterisk, PlusSign, Period, Colon, LessThanSign, EqualSign,
            GreaterThanSign, QuestionMark, OpenBracket, Backslash,
            CloseBracket, CircumflexAccent, OpenBrace, VerticalLine,
            CloseBrace, Tilde
        };

        ///////////////////////////////////////////////////////////////////////////////////////////////

        //
        // NOTE: These characters have special meaning in patterns for the
        //       [regsub] command.
        //
        private static readonly char[] RegSubReservedChars = {
            Ampersand, Backslash
        };

        ///////////////////////////////////////////////////////////////////////////////////////////////

        //
        // NOTE: These characters have special meaning in command lines.
        //
        private static readonly char[] CommandLineReservedChars = {
            HorizontalTab, LineFeed, VerticalTab, FormFeed, CarriageReturn,
            Space, QuotationMark, Backslash
        };

        ///////////////////////////////////////////////////////////////////////////////////////////////

        private static readonly char[] SignChars = {
            PlusSign, MinusSign
        };

        ///////////////////////////////////////////////////////////////////////////////////////////////

        private static readonly char[] IntegerChars = {
            Zero, One, Two, Three, Four,
            Five, Six, Seven, Eight, Nine
        };
#endif
        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////////

        internal static readonly char[] WhiteSpaceChars = {
            HorizontalTab, LineFeed, VerticalTab, FormFeed, CarriageReturn,
            Space
        };

        ///////////////////////////////////////////////////////////////////////////////////////////////

        public static readonly char[] LineTerminatorChars = {
            LineFeed, CarriageReturn
        };

        ///////////////////////////////////////////////////////////////////////////////////////////////

#if TEST
        internal static readonly CharList ListReservedCharList = new CharList(ListReservedChars);
#endif

        ///////////////////////////////////////////////////////////////////////////////////////////////

        internal static readonly CharList WhiteSpaceCharList = new CharList(WhiteSpaceChars);

        internal static readonly CharDictionary LineTerminatorCharDictionary =
            new CharDictionary(LineTerminatorChars);

        ///////////////////////////////////////////////////////////////////////////////////////////////

        #region Dead Code
#if DEAD_CODE
        private static readonly CharDictionary WhiteSpaceCharDictionary = new CharDictionary(WhiteSpaceChars);

        private static readonly CharList GlobReservedCharList = new CharList(GlobReservedChars);

        private static readonly CharList StringMatchReservedCharList = new CharList(StringMatchReservedChars);

        private static readonly CharList LineTerminatorCharList = new CharList(LineTerminatorChars);

        private static readonly CharDictionary SignCharDictionary = new CharDictionary(SignChars);

        private static readonly CharDictionary IntegerCharDictionary = new CharDictionary(IntegerChars);
#endif
        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////////

        public static readonly char DirectorySeparator = Backslash;
        public static readonly char AltDirectorySeparator = Slash;

        ///////////////////////////////////////////////////////////////////////////////////////////////

        public static readonly char[] DirectorySeparatorChars = {
            DirectorySeparator, AltDirectorySeparator
        };

        ///////////////////////////////////////////////////////////////////////////////////////////////

        #region Dead Code
#if DEAD_CODE
        private static readonly CharList DirectorySeparatorCharList = new CharList(
            DirectorySeparatorChars);
#endif
        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////////

        //
        // NOTE: Unicode characters for slashes and asterisk box (0):
        //
        //       "/" = U+002F, "*" = U+002A, "\" = U+005C
        //       " " = U+0020
        //
        //       Unicode characters for slashes and plus/minus box (1):
        //
        //       "/" = U+002F, "+" = U+002B, "-" = U+002D
        //       "|" = U+007C, "\" = U+005C, " " = U+0020
        //
        //       Unicode characters for spaces box (2):
        //
        //       " " = U+0020
        //
        //       Unicode characters for reverse color box (3):
        //
        //       "█" = U+2588, " " = U+0020
        //
        //       Unicode characters for full reverse color box (4):
        //
        //       "█" = U+2588
        //
        //       Unicode characters for single/double line box (5):
        //
        //       "╓" = U+2553, "╥" = U+2565, "╖" = U+2556
        //       "─" = U+2500, "║" = U+2551, "╟" = U+255F
        //       "╫" = U+256B, "╢" = U+2562, "╙" = U+2559
        //       "╨" = U+2568, "╜" = U+255C, " " = U+0020
        //
        //       Unicode characters for double/single line box (6):
        //
        //       "╒" = U+2552, "╤" = U+2564, "╕" = U+2555
        //       "═" = U+2550, "│" = U+2502, "╞" = U+255E
        //       "╪" = U+256A, "╡" = U+2561, "╘" = U+2558
        //       "╧" = U+2567, "╛" = U+255B, " " = U+0020
        //
        //       Unicode characters for single line box (7):
        //
        //       "┌" = U+250C, "┬" = U+252C, "┐" = U+2510
        //       "─" = U+2500, "│" = U+2502, "├" = U+251C
        //       "┼" = U+253C, "┤" = U+2524, "└" = U+2514
        //       "┴" = U+2534, "┘" = U+2518, " " = U+0020
        //
        //       Unicode characters for double line box (8):
        //
        //       "╔" = U+2554, "╦" = U+2566, "╗" = U+2557
        //       "═" = U+2550, "║" = U+2551, "╠" = U+2560
        //       "╬" = U+256C, "╣" = U+2563, "╚" = U+255A
        //       "╩" = U+2569, "╝" = U+255D, " " = U+0020
        //
        internal static readonly StringList BoxCharacterSets = new StringList(new string[] {
            "/*\\*****\\*/ ", /* 0: slashes and asterisk */
            "/+\\-|+++\\+/ ", /* 1: slashes and plus/minus */
            "            ",   /* 2: spaces */
            "███████████ ",   /* 3: reverse color box */
            "████████████",   /* 4: full reverse color box */
            "╓╥╖─║╟╫╢╙╨╜ ",   /* 5: single horizontal lines and double vertical lines */
            "╒╤╕═│╞╪╡╘╧╛ ",   /* 6: double horizontal lines and single vertical lines */
            "┌┬┐─│├┼┤└┴┘ ",   /* 7: single horizontal lines and single vertical lines */
            "╔╦╗═║╠╬╣╚╩╝ "    /* 8: double horizontal lines and double vertical lines */
        });
    }
}
