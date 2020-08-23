/*
  Version as of Sun Aug 23 08:29:50 2020
*/

using System;


namespace FunStackStrings
{
    public interface IFastString
    {
        char this[int id] { get; }
        int Length { get; }
    }
    

    public static class Factory
    {
        public static unsafe FastString0 Construct()
        {
            var res = new FastString0();
            return res;
        }
        public static unsafe FastString1 Construct(char s0)
        {
            var res = new FastString1();
            res.letters[0] = s0;
            return res;
        }
        public static unsafe FastString2 Construct(char s0, char s1)
        {
            var res = new FastString2();
            res.letters[0] = s0;
            res.letters[1] = s1;
            return res;
        }
        public static unsafe FastString3 Construct(char s0, char s1, char s2)
        {
            var res = new FastString3();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            return res;
        }
        public static unsafe FastString4 Construct(char s0, char s1, char s2, char s3)
        {
            var res = new FastString4();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            return res;
        }
        public static unsafe FastString5 Construct(char s0, char s1, char s2, char s3, char s4)
        {
            var res = new FastString5();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            return res;
        }
        public static unsafe FastString6 Construct(char s0, char s1, char s2, char s3, char s4, char s5)
        {
            var res = new FastString6();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            return res;
        }
        public static unsafe FastString7 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6)
        {
            var res = new FastString7();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            return res;
        }
        public static unsafe FastString8 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7)
        {
            var res = new FastString8();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            return res;
        }
        public static unsafe FastString9 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8)
        {
            var res = new FastString9();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            return res;
        }
        public static unsafe FastString10 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9)
        {
            var res = new FastString10();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            return res;
        }
        public static unsafe FastString11 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10)
        {
            var res = new FastString11();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            return res;
        }
        public static unsafe FastString12 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11)
        {
            var res = new FastString12();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            return res;
        }
        public static unsafe FastString13 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11, char s12)
        {
            var res = new FastString13();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            res.letters[12] = s12;
            return res;
        }
        public static unsafe FastString14 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11, char s12, char s13)
        {
            var res = new FastString14();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            res.letters[12] = s12;
            res.letters[13] = s13;
            return res;
        }
        public static unsafe FastString15 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11, char s12, char s13, char s14)
        {
            var res = new FastString15();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            res.letters[12] = s12;
            res.letters[13] = s13;
            res.letters[14] = s14;
            return res;
        }
        public static unsafe FastString16 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11, char s12, char s13, char s14, char s15)
        {
            var res = new FastString16();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            res.letters[12] = s12;
            res.letters[13] = s13;
            res.letters[14] = s14;
            res.letters[15] = s15;
            return res;
        }
        public static unsafe FastString17 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11, char s12, char s13, char s14, char s15, char s16)
        {
            var res = new FastString17();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            res.letters[12] = s12;
            res.letters[13] = s13;
            res.letters[14] = s14;
            res.letters[15] = s15;
            res.letters[16] = s16;
            return res;
        }
        public static unsafe FastString18 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11, char s12, char s13, char s14, char s15, char s16, char s17)
        {
            var res = new FastString18();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            res.letters[12] = s12;
            res.letters[13] = s13;
            res.letters[14] = s14;
            res.letters[15] = s15;
            res.letters[16] = s16;
            res.letters[17] = s17;
            return res;
        }
        public static unsafe FastString19 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11, char s12, char s13, char s14, char s15, char s16, char s17, char s18)
        {
            var res = new FastString19();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            res.letters[12] = s12;
            res.letters[13] = s13;
            res.letters[14] = s14;
            res.letters[15] = s15;
            res.letters[16] = s16;
            res.letters[17] = s17;
            res.letters[18] = s18;
            return res;
        }
        public static unsafe FastString20 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11, char s12, char s13, char s14, char s15, char s16, char s17, char s18, char s19)
        {
            var res = new FastString20();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            res.letters[12] = s12;
            res.letters[13] = s13;
            res.letters[14] = s14;
            res.letters[15] = s15;
            res.letters[16] = s16;
            res.letters[17] = s17;
            res.letters[18] = s18;
            res.letters[19] = s19;
            return res;
        }
        public static unsafe FastString21 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11, char s12, char s13, char s14, char s15, char s16, char s17, char s18, char s19, char s20)
        {
            var res = new FastString21();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            res.letters[12] = s12;
            res.letters[13] = s13;
            res.letters[14] = s14;
            res.letters[15] = s15;
            res.letters[16] = s16;
            res.letters[17] = s17;
            res.letters[18] = s18;
            res.letters[19] = s19;
            res.letters[20] = s20;
            return res;
        }
        public static unsafe FastString22 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11, char s12, char s13, char s14, char s15, char s16, char s17, char s18, char s19, char s20, char s21)
        {
            var res = new FastString22();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            res.letters[12] = s12;
            res.letters[13] = s13;
            res.letters[14] = s14;
            res.letters[15] = s15;
            res.letters[16] = s16;
            res.letters[17] = s17;
            res.letters[18] = s18;
            res.letters[19] = s19;
            res.letters[20] = s20;
            res.letters[21] = s21;
            return res;
        }
        public static unsafe FastString23 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11, char s12, char s13, char s14, char s15, char s16, char s17, char s18, char s19, char s20, char s21, char s22)
        {
            var res = new FastString23();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            res.letters[12] = s12;
            res.letters[13] = s13;
            res.letters[14] = s14;
            res.letters[15] = s15;
            res.letters[16] = s16;
            res.letters[17] = s17;
            res.letters[18] = s18;
            res.letters[19] = s19;
            res.letters[20] = s20;
            res.letters[21] = s21;
            res.letters[22] = s22;
            return res;
        }
        public static unsafe FastString24 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11, char s12, char s13, char s14, char s15, char s16, char s17, char s18, char s19, char s20, char s21, char s22, char s23)
        {
            var res = new FastString24();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            res.letters[12] = s12;
            res.letters[13] = s13;
            res.letters[14] = s14;
            res.letters[15] = s15;
            res.letters[16] = s16;
            res.letters[17] = s17;
            res.letters[18] = s18;
            res.letters[19] = s19;
            res.letters[20] = s20;
            res.letters[21] = s21;
            res.letters[22] = s22;
            res.letters[23] = s23;
            return res;
        }
        public static unsafe FastString25 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11, char s12, char s13, char s14, char s15, char s16, char s17, char s18, char s19, char s20, char s21, char s22, char s23, char s24)
        {
            var res = new FastString25();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            res.letters[12] = s12;
            res.letters[13] = s13;
            res.letters[14] = s14;
            res.letters[15] = s15;
            res.letters[16] = s16;
            res.letters[17] = s17;
            res.letters[18] = s18;
            res.letters[19] = s19;
            res.letters[20] = s20;
            res.letters[21] = s21;
            res.letters[22] = s22;
            res.letters[23] = s23;
            res.letters[24] = s24;
            return res;
        }
        public static unsafe FastString26 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11, char s12, char s13, char s14, char s15, char s16, char s17, char s18, char s19, char s20, char s21, char s22, char s23, char s24, char s25)
        {
            var res = new FastString26();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            res.letters[12] = s12;
            res.letters[13] = s13;
            res.letters[14] = s14;
            res.letters[15] = s15;
            res.letters[16] = s16;
            res.letters[17] = s17;
            res.letters[18] = s18;
            res.letters[19] = s19;
            res.letters[20] = s20;
            res.letters[21] = s21;
            res.letters[22] = s22;
            res.letters[23] = s23;
            res.letters[24] = s24;
            res.letters[25] = s25;
            return res;
        }
        public static unsafe FastString27 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11, char s12, char s13, char s14, char s15, char s16, char s17, char s18, char s19, char s20, char s21, char s22, char s23, char s24, char s25, char s26)
        {
            var res = new FastString27();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            res.letters[12] = s12;
            res.letters[13] = s13;
            res.letters[14] = s14;
            res.letters[15] = s15;
            res.letters[16] = s16;
            res.letters[17] = s17;
            res.letters[18] = s18;
            res.letters[19] = s19;
            res.letters[20] = s20;
            res.letters[21] = s21;
            res.letters[22] = s22;
            res.letters[23] = s23;
            res.letters[24] = s24;
            res.letters[25] = s25;
            res.letters[26] = s26;
            return res;
        }
        public static unsafe FastString28 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11, char s12, char s13, char s14, char s15, char s16, char s17, char s18, char s19, char s20, char s21, char s22, char s23, char s24, char s25, char s26, char s27)
        {
            var res = new FastString28();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            res.letters[12] = s12;
            res.letters[13] = s13;
            res.letters[14] = s14;
            res.letters[15] = s15;
            res.letters[16] = s16;
            res.letters[17] = s17;
            res.letters[18] = s18;
            res.letters[19] = s19;
            res.letters[20] = s20;
            res.letters[21] = s21;
            res.letters[22] = s22;
            res.letters[23] = s23;
            res.letters[24] = s24;
            res.letters[25] = s25;
            res.letters[26] = s26;
            res.letters[27] = s27;
            return res;
        }
        public static unsafe FastString29 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11, char s12, char s13, char s14, char s15, char s16, char s17, char s18, char s19, char s20, char s21, char s22, char s23, char s24, char s25, char s26, char s27, char s28)
        {
            var res = new FastString29();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            res.letters[12] = s12;
            res.letters[13] = s13;
            res.letters[14] = s14;
            res.letters[15] = s15;
            res.letters[16] = s16;
            res.letters[17] = s17;
            res.letters[18] = s18;
            res.letters[19] = s19;
            res.letters[20] = s20;
            res.letters[21] = s21;
            res.letters[22] = s22;
            res.letters[23] = s23;
            res.letters[24] = s24;
            res.letters[25] = s25;
            res.letters[26] = s26;
            res.letters[27] = s27;
            res.letters[28] = s28;
            return res;
        }
        public static unsafe FastString30 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11, char s12, char s13, char s14, char s15, char s16, char s17, char s18, char s19, char s20, char s21, char s22, char s23, char s24, char s25, char s26, char s27, char s28, char s29)
        {
            var res = new FastString30();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            res.letters[12] = s12;
            res.letters[13] = s13;
            res.letters[14] = s14;
            res.letters[15] = s15;
            res.letters[16] = s16;
            res.letters[17] = s17;
            res.letters[18] = s18;
            res.letters[19] = s19;
            res.letters[20] = s20;
            res.letters[21] = s21;
            res.letters[22] = s22;
            res.letters[23] = s23;
            res.letters[24] = s24;
            res.letters[25] = s25;
            res.letters[26] = s26;
            res.letters[27] = s27;
            res.letters[28] = s28;
            res.letters[29] = s29;
            return res;
        }
        public static unsafe FastString31 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11, char s12, char s13, char s14, char s15, char s16, char s17, char s18, char s19, char s20, char s21, char s22, char s23, char s24, char s25, char s26, char s27, char s28, char s29, char s30)
        {
            var res = new FastString31();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            res.letters[12] = s12;
            res.letters[13] = s13;
            res.letters[14] = s14;
            res.letters[15] = s15;
            res.letters[16] = s16;
            res.letters[17] = s17;
            res.letters[18] = s18;
            res.letters[19] = s19;
            res.letters[20] = s20;
            res.letters[21] = s21;
            res.letters[22] = s22;
            res.letters[23] = s23;
            res.letters[24] = s24;
            res.letters[25] = s25;
            res.letters[26] = s26;
            res.letters[27] = s27;
            res.letters[28] = s28;
            res.letters[29] = s29;
            res.letters[30] = s30;
            return res;
        }
        public static unsafe FastString32 Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11, char s12, char s13, char s14, char s15, char s16, char s17, char s18, char s19, char s20, char s21, char s22, char s23, char s24, char s25, char s26, char s27, char s28, char s29, char s30, char s31)
        {
            var res = new FastString32();
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            res.letters[12] = s12;
            res.letters[13] = s13;
            res.letters[14] = s14;
            res.letters[15] = s15;
            res.letters[16] = s16;
            res.letters[17] = s17;
            res.letters[18] = s18;
            res.letters[19] = s19;
            res.letters[20] = s20;
            res.letters[21] = s21;
            res.letters[22] = s22;
            res.letters[23] = s23;
            res.letters[24] = s24;
            res.letters[25] = s25;
            res.letters[26] = s26;
            res.letters[27] = s27;
            res.letters[28] = s28;
            res.letters[29] = s29;
            res.letters[30] = s30;
            res.letters[31] = s31;
            return res;
        }
        public static FastStringInf Construct(char s0, char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9, char s10, char s11, char s12, char s13, char s14, char s15, char s16, char s17, char s18, char s19, char s20, char s21, char s22, char s23, char s24, char s25, char s26, char s27, char s28, char s29, char s30, char s31, char s32, params char[] ss)
        {
            var res = new FastStringInf();
            res.letters = new char[32 + ss.Length + 1];
            res.letters[0] = s0;
            res.letters[1] = s1;
            res.letters[2] = s2;
            res.letters[3] = s3;
            res.letters[4] = s4;
            res.letters[5] = s5;
            res.letters[6] = s6;
            res.letters[7] = s7;
            res.letters[8] = s8;
            res.letters[9] = s9;
            res.letters[10] = s10;
            res.letters[11] = s11;
            res.letters[12] = s12;
            res.letters[13] = s13;
            res.letters[14] = s14;
            res.letters[15] = s15;
            res.letters[16] = s16;
            res.letters[17] = s17;
            res.letters[18] = s18;
            res.letters[19] = s19;
            res.letters[20] = s20;
            res.letters[21] = s21;
            res.letters[22] = s22;
            res.letters[23] = s23;
            res.letters[24] = s24;
            res.letters[25] = s25;
            res.letters[26] = s26;
            res.letters[27] = s27;
            res.letters[28] = s28;
            res.letters[29] = s29;
            res.letters[30] = s30;
            res.letters[31] = s31;
            res.letters[32] = s32;
            for (int i = 0; i < ss.Length; i++)
                res.letters[i + 1 + 32] = ss[i];
            return res;
        }
    }

    public unsafe struct FastString0 : IFastString
    {
        public static FastString0 operator+(FastString0 a, FastString0 b)
            => Factory.Construct();
        public static FastString1 operator+(FastString1 a, FastString0 b)
            => Factory.Construct(a[0]);
        public static FastString2 operator+(FastString2 a, FastString0 b)
            => Factory.Construct(a[0], a[1]);
        public static FastString3 operator+(FastString3 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2]);
        public static FastString4 operator+(FastString4 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3]);
        public static FastString5 operator+(FastString5 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4]);
        public static FastString6 operator+(FastString6 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5]);
        public static FastString7 operator+(FastString7 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6]);
        public static FastString8 operator+(FastString8 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7]);
        public static FastString9 operator+(FastString9 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8]);
        public static FastString10 operator+(FastString10 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9]);
        public static FastString11 operator+(FastString11 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10]);
        public static FastString12 operator+(FastString12 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11]);
        public static FastString13 operator+(FastString13 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12]);
        public static FastString14 operator+(FastString14 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13]);
        public static FastString15 operator+(FastString15 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14]);
        public static FastString16 operator+(FastString16 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15]);
        public static FastString17 operator+(FastString17 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16]);
        public static FastString18 operator+(FastString18 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17]);
        public static FastString19 operator+(FastString19 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18]);
        public static FastString20 operator+(FastString20 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19]);
        public static FastString21 operator+(FastString21 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20]);
        public static FastString22 operator+(FastString22 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21]);
        public static FastString23 operator+(FastString23 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22]);
        public static FastString24 operator+(FastString24 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23]);
        public static FastString25 operator+(FastString25 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24]);
        public static FastString26 operator+(FastString26 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25]);
        public static FastString27 operator+(FastString27 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26]);
        public static FastString28 operator+(FastString28 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27]);
        public static FastString29 operator+(FastString29 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28]);
        public static FastString30 operator+(FastString30 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29]);
        public static FastString31 operator+(FastString31 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30]);
        public static FastString32 operator+(FastString32 a, FastString0 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31]);
        public override string ToString()
            => "";
        public char this[int id] => throw new IndexOutOfRangeException();
        public int Length => 0;
    }

    public unsafe struct FastString1 : IFastString
    {
        internal fixed char letters[1];
        public static FastString1 operator+(FastString0 a, FastString1 b)
            => Factory.Construct(b[0]);
        public static FastString2 operator+(FastString1 a, FastString1 b)
            => Factory.Construct(a[0], b[0]);
        public static FastString3 operator+(FastString2 a, FastString1 b)
            => Factory.Construct(a[0], a[1], b[0]);
        public static FastString4 operator+(FastString3 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], b[0]);
        public static FastString5 operator+(FastString4 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0]);
        public static FastString6 operator+(FastString5 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0]);
        public static FastString7 operator+(FastString6 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0]);
        public static FastString8 operator+(FastString7 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0]);
        public static FastString9 operator+(FastString8 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0]);
        public static FastString10 operator+(FastString9 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0]);
        public static FastString11 operator+(FastString10 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0]);
        public static FastString12 operator+(FastString11 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0]);
        public static FastString13 operator+(FastString12 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0]);
        public static FastString14 operator+(FastString13 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0]);
        public static FastString15 operator+(FastString14 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0]);
        public static FastString16 operator+(FastString15 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0]);
        public static FastString17 operator+(FastString16 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0]);
        public static FastString18 operator+(FastString17 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0]);
        public static FastString19 operator+(FastString18 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0]);
        public static FastString20 operator+(FastString19 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0]);
        public static FastString21 operator+(FastString20 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0]);
        public static FastString22 operator+(FastString21 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0]);
        public static FastString23 operator+(FastString22 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0]);
        public static FastString24 operator+(FastString23 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0]);
        public static FastString25 operator+(FastString24 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0]);
        public static FastString26 operator+(FastString25 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0]);
        public static FastString27 operator+(FastString26 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0]);
        public static FastString28 operator+(FastString27 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0]);
        public static FastString29 operator+(FastString28 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0]);
        public static FastString30 operator+(FastString29 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0]);
        public static FastString31 operator+(FastString30 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0]);
        public static FastString32 operator+(FastString31 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0]);
        public static FastStringInf operator+(FastString32 a, FastString1 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 1; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 1;
    }

    public unsafe struct FastString2 : IFastString
    {
        internal fixed char letters[2];
        public static FastString2 operator+(FastString0 a, FastString2 b)
            => Factory.Construct(b[0], b[1]);
        public static FastString3 operator+(FastString1 a, FastString2 b)
            => Factory.Construct(a[0], b[0], b[1]);
        public static FastString4 operator+(FastString2 a, FastString2 b)
            => Factory.Construct(a[0], a[1], b[0], b[1]);
        public static FastString5 operator+(FastString3 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1]);
        public static FastString6 operator+(FastString4 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1]);
        public static FastString7 operator+(FastString5 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1]);
        public static FastString8 operator+(FastString6 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1]);
        public static FastString9 operator+(FastString7 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1]);
        public static FastString10 operator+(FastString8 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1]);
        public static FastString11 operator+(FastString9 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1]);
        public static FastString12 operator+(FastString10 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1]);
        public static FastString13 operator+(FastString11 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1]);
        public static FastString14 operator+(FastString12 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1]);
        public static FastString15 operator+(FastString13 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1]);
        public static FastString16 operator+(FastString14 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1]);
        public static FastString17 operator+(FastString15 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1]);
        public static FastString18 operator+(FastString16 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1]);
        public static FastString19 operator+(FastString17 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1]);
        public static FastString20 operator+(FastString18 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1]);
        public static FastString21 operator+(FastString19 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1]);
        public static FastString22 operator+(FastString20 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1]);
        public static FastString23 operator+(FastString21 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1]);
        public static FastString24 operator+(FastString22 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1]);
        public static FastString25 operator+(FastString23 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1]);
        public static FastString26 operator+(FastString24 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1]);
        public static FastString27 operator+(FastString25 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1]);
        public static FastString28 operator+(FastString26 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1]);
        public static FastString29 operator+(FastString27 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1]);
        public static FastString30 operator+(FastString28 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1]);
        public static FastString31 operator+(FastString29 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1]);
        public static FastString32 operator+(FastString30 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1]);
        public static FastStringInf operator+(FastString31 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1]);
        public static FastStringInf operator+(FastString32 a, FastString2 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 2; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 2;
    }

    public unsafe struct FastString3 : IFastString
    {
        internal fixed char letters[3];
        public static FastString3 operator+(FastString0 a, FastString3 b)
            => Factory.Construct(b[0], b[1], b[2]);
        public static FastString4 operator+(FastString1 a, FastString3 b)
            => Factory.Construct(a[0], b[0], b[1], b[2]);
        public static FastString5 operator+(FastString2 a, FastString3 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2]);
        public static FastString6 operator+(FastString3 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2]);
        public static FastString7 operator+(FastString4 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2]);
        public static FastString8 operator+(FastString5 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2]);
        public static FastString9 operator+(FastString6 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2]);
        public static FastString10 operator+(FastString7 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2]);
        public static FastString11 operator+(FastString8 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2]);
        public static FastString12 operator+(FastString9 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2]);
        public static FastString13 operator+(FastString10 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2]);
        public static FastString14 operator+(FastString11 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2]);
        public static FastString15 operator+(FastString12 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2]);
        public static FastString16 operator+(FastString13 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2]);
        public static FastString17 operator+(FastString14 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2]);
        public static FastString18 operator+(FastString15 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2]);
        public static FastString19 operator+(FastString16 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2]);
        public static FastString20 operator+(FastString17 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2]);
        public static FastString21 operator+(FastString18 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2]);
        public static FastString22 operator+(FastString19 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2]);
        public static FastString23 operator+(FastString20 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2]);
        public static FastString24 operator+(FastString21 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2]);
        public static FastString25 operator+(FastString22 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2]);
        public static FastString26 operator+(FastString23 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2]);
        public static FastString27 operator+(FastString24 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2]);
        public static FastString28 operator+(FastString25 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2]);
        public static FastString29 operator+(FastString26 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2]);
        public static FastString30 operator+(FastString27 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2]);
        public static FastString31 operator+(FastString28 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2]);
        public static FastString32 operator+(FastString29 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2]);
        public static FastStringInf operator+(FastString30 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2]);
        public static FastStringInf operator+(FastString31 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2]);
        public static FastStringInf operator+(FastString32 a, FastString3 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 3; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 3;
    }

    public unsafe struct FastString4 : IFastString
    {
        internal fixed char letters[4];
        public static FastString4 operator+(FastString0 a, FastString4 b)
            => Factory.Construct(b[0], b[1], b[2], b[3]);
        public static FastString5 operator+(FastString1 a, FastString4 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3]);
        public static FastString6 operator+(FastString2 a, FastString4 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3]);
        public static FastString7 operator+(FastString3 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3]);
        public static FastString8 operator+(FastString4 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3]);
        public static FastString9 operator+(FastString5 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3]);
        public static FastString10 operator+(FastString6 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3]);
        public static FastString11 operator+(FastString7 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3]);
        public static FastString12 operator+(FastString8 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3]);
        public static FastString13 operator+(FastString9 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3]);
        public static FastString14 operator+(FastString10 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3]);
        public static FastString15 operator+(FastString11 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3]);
        public static FastString16 operator+(FastString12 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3]);
        public static FastString17 operator+(FastString13 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3]);
        public static FastString18 operator+(FastString14 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3]);
        public static FastString19 operator+(FastString15 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3]);
        public static FastString20 operator+(FastString16 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3]);
        public static FastString21 operator+(FastString17 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3]);
        public static FastString22 operator+(FastString18 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3]);
        public static FastString23 operator+(FastString19 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3]);
        public static FastString24 operator+(FastString20 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3]);
        public static FastString25 operator+(FastString21 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3]);
        public static FastString26 operator+(FastString22 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3]);
        public static FastString27 operator+(FastString23 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3]);
        public static FastString28 operator+(FastString24 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3]);
        public static FastString29 operator+(FastString25 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3]);
        public static FastString30 operator+(FastString26 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3]);
        public static FastString31 operator+(FastString27 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3]);
        public static FastString32 operator+(FastString28 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3]);
        public static FastStringInf operator+(FastString29 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3]);
        public static FastStringInf operator+(FastString30 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3]);
        public static FastStringInf operator+(FastString31 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3]);
        public static FastStringInf operator+(FastString32 a, FastString4 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 4; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 4;
    }

    public unsafe struct FastString5 : IFastString
    {
        internal fixed char letters[5];
        public static FastString5 operator+(FastString0 a, FastString5 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4]);
        public static FastString6 operator+(FastString1 a, FastString5 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4]);
        public static FastString7 operator+(FastString2 a, FastString5 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4]);
        public static FastString8 operator+(FastString3 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4]);
        public static FastString9 operator+(FastString4 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4]);
        public static FastString10 operator+(FastString5 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4]);
        public static FastString11 operator+(FastString6 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4]);
        public static FastString12 operator+(FastString7 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4]);
        public static FastString13 operator+(FastString8 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4]);
        public static FastString14 operator+(FastString9 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4]);
        public static FastString15 operator+(FastString10 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4]);
        public static FastString16 operator+(FastString11 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4]);
        public static FastString17 operator+(FastString12 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4]);
        public static FastString18 operator+(FastString13 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4]);
        public static FastString19 operator+(FastString14 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4]);
        public static FastString20 operator+(FastString15 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4]);
        public static FastString21 operator+(FastString16 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4]);
        public static FastString22 operator+(FastString17 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4]);
        public static FastString23 operator+(FastString18 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4]);
        public static FastString24 operator+(FastString19 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4]);
        public static FastString25 operator+(FastString20 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4]);
        public static FastString26 operator+(FastString21 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4]);
        public static FastString27 operator+(FastString22 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4]);
        public static FastString28 operator+(FastString23 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4]);
        public static FastString29 operator+(FastString24 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4]);
        public static FastString30 operator+(FastString25 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4]);
        public static FastString31 operator+(FastString26 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4]);
        public static FastString32 operator+(FastString27 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4]);
        public static FastStringInf operator+(FastString28 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4]);
        public static FastStringInf operator+(FastString29 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4]);
        public static FastStringInf operator+(FastString30 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4]);
        public static FastStringInf operator+(FastString31 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4]);
        public static FastStringInf operator+(FastString32 a, FastString5 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 5; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 5;
    }

    public unsafe struct FastString6 : IFastString
    {
        internal fixed char letters[6];
        public static FastString6 operator+(FastString0 a, FastString6 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString7 operator+(FastString1 a, FastString6 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString8 operator+(FastString2 a, FastString6 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString9 operator+(FastString3 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString10 operator+(FastString4 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString11 operator+(FastString5 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString12 operator+(FastString6 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString13 operator+(FastString7 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString14 operator+(FastString8 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString15 operator+(FastString9 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString16 operator+(FastString10 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString17 operator+(FastString11 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString18 operator+(FastString12 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString19 operator+(FastString13 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString20 operator+(FastString14 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString21 operator+(FastString15 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString22 operator+(FastString16 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString23 operator+(FastString17 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString24 operator+(FastString18 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString25 operator+(FastString19 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString26 operator+(FastString20 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString27 operator+(FastString21 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString28 operator+(FastString22 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString29 operator+(FastString23 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString30 operator+(FastString24 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString31 operator+(FastString25 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastString32 operator+(FastString26 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastStringInf operator+(FastString27 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastStringInf operator+(FastString28 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastStringInf operator+(FastString29 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastStringInf operator+(FastString30 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastStringInf operator+(FastString31 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5]);
        public static FastStringInf operator+(FastString32 a, FastString6 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 6; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 6;
    }

    public unsafe struct FastString7 : IFastString
    {
        internal fixed char letters[7];
        public static FastString7 operator+(FastString0 a, FastString7 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString8 operator+(FastString1 a, FastString7 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString9 operator+(FastString2 a, FastString7 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString10 operator+(FastString3 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString11 operator+(FastString4 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString12 operator+(FastString5 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString13 operator+(FastString6 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString14 operator+(FastString7 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString15 operator+(FastString8 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString16 operator+(FastString9 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString17 operator+(FastString10 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString18 operator+(FastString11 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString19 operator+(FastString12 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString20 operator+(FastString13 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString21 operator+(FastString14 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString22 operator+(FastString15 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString23 operator+(FastString16 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString24 operator+(FastString17 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString25 operator+(FastString18 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString26 operator+(FastString19 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString27 operator+(FastString20 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString28 operator+(FastString21 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString29 operator+(FastString22 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString30 operator+(FastString23 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString31 operator+(FastString24 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastString32 operator+(FastString25 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastStringInf operator+(FastString26 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastStringInf operator+(FastString27 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastStringInf operator+(FastString28 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastStringInf operator+(FastString29 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastStringInf operator+(FastString30 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastStringInf operator+(FastString31 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public static FastStringInf operator+(FastString32 a, FastString7 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 7; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 7;
    }

    public unsafe struct FastString8 : IFastString
    {
        internal fixed char letters[8];
        public static FastString8 operator+(FastString0 a, FastString8 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString9 operator+(FastString1 a, FastString8 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString10 operator+(FastString2 a, FastString8 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString11 operator+(FastString3 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString12 operator+(FastString4 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString13 operator+(FastString5 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString14 operator+(FastString6 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString15 operator+(FastString7 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString16 operator+(FastString8 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString17 operator+(FastString9 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString18 operator+(FastString10 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString19 operator+(FastString11 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString20 operator+(FastString12 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString21 operator+(FastString13 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString22 operator+(FastString14 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString23 operator+(FastString15 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString24 operator+(FastString16 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString25 operator+(FastString17 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString26 operator+(FastString18 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString27 operator+(FastString19 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString28 operator+(FastString20 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString29 operator+(FastString21 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString30 operator+(FastString22 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString31 operator+(FastString23 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastString32 operator+(FastString24 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastStringInf operator+(FastString25 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastStringInf operator+(FastString26 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastStringInf operator+(FastString27 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastStringInf operator+(FastString28 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastStringInf operator+(FastString29 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastStringInf operator+(FastString30 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastStringInf operator+(FastString31 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public static FastStringInf operator+(FastString32 a, FastString8 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 8; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 8;
    }

    public unsafe struct FastString9 : IFastString
    {
        internal fixed char letters[9];
        public static FastString9 operator+(FastString0 a, FastString9 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString10 operator+(FastString1 a, FastString9 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString11 operator+(FastString2 a, FastString9 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString12 operator+(FastString3 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString13 operator+(FastString4 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString14 operator+(FastString5 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString15 operator+(FastString6 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString16 operator+(FastString7 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString17 operator+(FastString8 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString18 operator+(FastString9 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString19 operator+(FastString10 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString20 operator+(FastString11 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString21 operator+(FastString12 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString22 operator+(FastString13 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString23 operator+(FastString14 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString24 operator+(FastString15 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString25 operator+(FastString16 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString26 operator+(FastString17 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString27 operator+(FastString18 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString28 operator+(FastString19 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString29 operator+(FastString20 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString30 operator+(FastString21 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString31 operator+(FastString22 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastString32 operator+(FastString23 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastStringInf operator+(FastString24 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastStringInf operator+(FastString25 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastStringInf operator+(FastString26 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastStringInf operator+(FastString27 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastStringInf operator+(FastString28 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastStringInf operator+(FastString29 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastStringInf operator+(FastString30 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastStringInf operator+(FastString31 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public static FastStringInf operator+(FastString32 a, FastString9 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 9; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 9;
    }

    public unsafe struct FastString10 : IFastString
    {
        internal fixed char letters[10];
        public static FastString10 operator+(FastString0 a, FastString10 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString11 operator+(FastString1 a, FastString10 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString12 operator+(FastString2 a, FastString10 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString13 operator+(FastString3 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString14 operator+(FastString4 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString15 operator+(FastString5 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString16 operator+(FastString6 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString17 operator+(FastString7 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString18 operator+(FastString8 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString19 operator+(FastString9 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString20 operator+(FastString10 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString21 operator+(FastString11 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString22 operator+(FastString12 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString23 operator+(FastString13 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString24 operator+(FastString14 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString25 operator+(FastString15 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString26 operator+(FastString16 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString27 operator+(FastString17 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString28 operator+(FastString18 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString29 operator+(FastString19 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString30 operator+(FastString20 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString31 operator+(FastString21 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastString32 operator+(FastString22 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastStringInf operator+(FastString23 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastStringInf operator+(FastString24 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastStringInf operator+(FastString25 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastStringInf operator+(FastString26 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastStringInf operator+(FastString27 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastStringInf operator+(FastString28 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastStringInf operator+(FastString29 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastStringInf operator+(FastString30 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastStringInf operator+(FastString31 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public static FastStringInf operator+(FastString32 a, FastString10 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 10; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 10;
    }

    public unsafe struct FastString11 : IFastString
    {
        internal fixed char letters[11];
        public static FastString11 operator+(FastString0 a, FastString11 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastString12 operator+(FastString1 a, FastString11 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastString13 operator+(FastString2 a, FastString11 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastString14 operator+(FastString3 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastString15 operator+(FastString4 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastString16 operator+(FastString5 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastString17 operator+(FastString6 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastString18 operator+(FastString7 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastString19 operator+(FastString8 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastString20 operator+(FastString9 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastString21 operator+(FastString10 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastString22 operator+(FastString11 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastString23 operator+(FastString12 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastString24 operator+(FastString13 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastString25 operator+(FastString14 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastString26 operator+(FastString15 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastString27 operator+(FastString16 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastString28 operator+(FastString17 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastString29 operator+(FastString18 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastString30 operator+(FastString19 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastString31 operator+(FastString20 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastString32 operator+(FastString21 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastStringInf operator+(FastString22 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastStringInf operator+(FastString23 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastStringInf operator+(FastString24 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastStringInf operator+(FastString25 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastStringInf operator+(FastString26 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastStringInf operator+(FastString27 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastStringInf operator+(FastString28 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastStringInf operator+(FastString29 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastStringInf operator+(FastString30 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastStringInf operator+(FastString31 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public static FastStringInf operator+(FastString32 a, FastString11 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 11; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 11;
    }

    public unsafe struct FastString12 : IFastString
    {
        internal fixed char letters[12];
        public static FastString12 operator+(FastString0 a, FastString12 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastString13 operator+(FastString1 a, FastString12 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastString14 operator+(FastString2 a, FastString12 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastString15 operator+(FastString3 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastString16 operator+(FastString4 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastString17 operator+(FastString5 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastString18 operator+(FastString6 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastString19 operator+(FastString7 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastString20 operator+(FastString8 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastString21 operator+(FastString9 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastString22 operator+(FastString10 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastString23 operator+(FastString11 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastString24 operator+(FastString12 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastString25 operator+(FastString13 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastString26 operator+(FastString14 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastString27 operator+(FastString15 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastString28 operator+(FastString16 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastString29 operator+(FastString17 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastString30 operator+(FastString18 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastString31 operator+(FastString19 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastString32 operator+(FastString20 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastStringInf operator+(FastString21 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastStringInf operator+(FastString22 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastStringInf operator+(FastString23 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastStringInf operator+(FastString24 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastStringInf operator+(FastString25 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastStringInf operator+(FastString26 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastStringInf operator+(FastString27 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastStringInf operator+(FastString28 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastStringInf operator+(FastString29 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastStringInf operator+(FastString30 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastStringInf operator+(FastString31 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public static FastStringInf operator+(FastString32 a, FastString12 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 12; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 12;
    }

    public unsafe struct FastString13 : IFastString
    {
        internal fixed char letters[13];
        public static FastString13 operator+(FastString0 a, FastString13 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastString14 operator+(FastString1 a, FastString13 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastString15 operator+(FastString2 a, FastString13 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastString16 operator+(FastString3 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastString17 operator+(FastString4 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastString18 operator+(FastString5 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastString19 operator+(FastString6 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastString20 operator+(FastString7 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastString21 operator+(FastString8 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastString22 operator+(FastString9 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastString23 operator+(FastString10 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastString24 operator+(FastString11 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastString25 operator+(FastString12 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastString26 operator+(FastString13 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastString27 operator+(FastString14 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastString28 operator+(FastString15 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastString29 operator+(FastString16 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastString30 operator+(FastString17 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastString31 operator+(FastString18 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastString32 operator+(FastString19 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastStringInf operator+(FastString20 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastStringInf operator+(FastString21 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastStringInf operator+(FastString22 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastStringInf operator+(FastString23 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastStringInf operator+(FastString24 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastStringInf operator+(FastString25 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastStringInf operator+(FastString26 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastStringInf operator+(FastString27 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastStringInf operator+(FastString28 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastStringInf operator+(FastString29 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastStringInf operator+(FastString30 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastStringInf operator+(FastString31 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public static FastStringInf operator+(FastString32 a, FastString13 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 13; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 13;
    }

    public unsafe struct FastString14 : IFastString
    {
        internal fixed char letters[14];
        public static FastString14 operator+(FastString0 a, FastString14 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastString15 operator+(FastString1 a, FastString14 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastString16 operator+(FastString2 a, FastString14 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastString17 operator+(FastString3 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastString18 operator+(FastString4 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastString19 operator+(FastString5 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastString20 operator+(FastString6 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastString21 operator+(FastString7 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastString22 operator+(FastString8 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastString23 operator+(FastString9 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastString24 operator+(FastString10 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastString25 operator+(FastString11 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastString26 operator+(FastString12 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastString27 operator+(FastString13 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastString28 operator+(FastString14 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastString29 operator+(FastString15 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastString30 operator+(FastString16 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastString31 operator+(FastString17 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastString32 operator+(FastString18 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastStringInf operator+(FastString19 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastStringInf operator+(FastString20 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastStringInf operator+(FastString21 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastStringInf operator+(FastString22 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastStringInf operator+(FastString23 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastStringInf operator+(FastString24 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastStringInf operator+(FastString25 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastStringInf operator+(FastString26 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastStringInf operator+(FastString27 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastStringInf operator+(FastString28 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastStringInf operator+(FastString29 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastStringInf operator+(FastString30 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastStringInf operator+(FastString31 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public static FastStringInf operator+(FastString32 a, FastString14 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 14; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 14;
    }

    public unsafe struct FastString15 : IFastString
    {
        internal fixed char letters[15];
        public static FastString15 operator+(FastString0 a, FastString15 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastString16 operator+(FastString1 a, FastString15 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastString17 operator+(FastString2 a, FastString15 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastString18 operator+(FastString3 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastString19 operator+(FastString4 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastString20 operator+(FastString5 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastString21 operator+(FastString6 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastString22 operator+(FastString7 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastString23 operator+(FastString8 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastString24 operator+(FastString9 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastString25 operator+(FastString10 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastString26 operator+(FastString11 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastString27 operator+(FastString12 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastString28 operator+(FastString13 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastString29 operator+(FastString14 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastString30 operator+(FastString15 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastString31 operator+(FastString16 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastString32 operator+(FastString17 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastStringInf operator+(FastString18 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastStringInf operator+(FastString19 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastStringInf operator+(FastString20 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastStringInf operator+(FastString21 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastStringInf operator+(FastString22 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastStringInf operator+(FastString23 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastStringInf operator+(FastString24 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastStringInf operator+(FastString25 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastStringInf operator+(FastString26 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastStringInf operator+(FastString27 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastStringInf operator+(FastString28 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastStringInf operator+(FastString29 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastStringInf operator+(FastString30 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastStringInf operator+(FastString31 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public static FastStringInf operator+(FastString32 a, FastString15 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 15; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 15;
    }

    public unsafe struct FastString16 : IFastString
    {
        internal fixed char letters[16];
        public static FastString16 operator+(FastString0 a, FastString16 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastString17 operator+(FastString1 a, FastString16 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastString18 operator+(FastString2 a, FastString16 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastString19 operator+(FastString3 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastString20 operator+(FastString4 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastString21 operator+(FastString5 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastString22 operator+(FastString6 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastString23 operator+(FastString7 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastString24 operator+(FastString8 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastString25 operator+(FastString9 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastString26 operator+(FastString10 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastString27 operator+(FastString11 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastString28 operator+(FastString12 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastString29 operator+(FastString13 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastString30 operator+(FastString14 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastString31 operator+(FastString15 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastString32 operator+(FastString16 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastStringInf operator+(FastString17 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastStringInf operator+(FastString18 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastStringInf operator+(FastString19 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastStringInf operator+(FastString20 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastStringInf operator+(FastString21 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastStringInf operator+(FastString22 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastStringInf operator+(FastString23 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastStringInf operator+(FastString24 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastStringInf operator+(FastString25 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastStringInf operator+(FastString26 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastStringInf operator+(FastString27 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastStringInf operator+(FastString28 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastStringInf operator+(FastString29 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastStringInf operator+(FastString30 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastStringInf operator+(FastString31 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public static FastStringInf operator+(FastString32 a, FastString16 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 16; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 16;
    }

    public unsafe struct FastString17 : IFastString
    {
        internal fixed char letters[17];
        public static FastString17 operator+(FastString0 a, FastString17 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastString18 operator+(FastString1 a, FastString17 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastString19 operator+(FastString2 a, FastString17 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastString20 operator+(FastString3 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastString21 operator+(FastString4 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastString22 operator+(FastString5 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastString23 operator+(FastString6 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastString24 operator+(FastString7 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastString25 operator+(FastString8 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastString26 operator+(FastString9 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastString27 operator+(FastString10 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastString28 operator+(FastString11 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastString29 operator+(FastString12 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastString30 operator+(FastString13 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastString31 operator+(FastString14 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastString32 operator+(FastString15 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastStringInf operator+(FastString16 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastStringInf operator+(FastString17 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastStringInf operator+(FastString18 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastStringInf operator+(FastString19 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastStringInf operator+(FastString20 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastStringInf operator+(FastString21 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastStringInf operator+(FastString22 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastStringInf operator+(FastString23 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastStringInf operator+(FastString24 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastStringInf operator+(FastString25 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastStringInf operator+(FastString26 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastStringInf operator+(FastString27 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastStringInf operator+(FastString28 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastStringInf operator+(FastString29 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastStringInf operator+(FastString30 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastStringInf operator+(FastString31 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public static FastStringInf operator+(FastString32 a, FastString17 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 17; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 17;
    }

    public unsafe struct FastString18 : IFastString
    {
        internal fixed char letters[18];
        public static FastString18 operator+(FastString0 a, FastString18 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastString19 operator+(FastString1 a, FastString18 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastString20 operator+(FastString2 a, FastString18 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastString21 operator+(FastString3 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastString22 operator+(FastString4 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastString23 operator+(FastString5 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastString24 operator+(FastString6 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastString25 operator+(FastString7 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastString26 operator+(FastString8 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastString27 operator+(FastString9 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastString28 operator+(FastString10 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastString29 operator+(FastString11 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastString30 operator+(FastString12 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastString31 operator+(FastString13 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastString32 operator+(FastString14 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastStringInf operator+(FastString15 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastStringInf operator+(FastString16 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastStringInf operator+(FastString17 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastStringInf operator+(FastString18 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastStringInf operator+(FastString19 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastStringInf operator+(FastString20 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastStringInf operator+(FastString21 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastStringInf operator+(FastString22 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastStringInf operator+(FastString23 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastStringInf operator+(FastString24 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastStringInf operator+(FastString25 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastStringInf operator+(FastString26 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastStringInf operator+(FastString27 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastStringInf operator+(FastString28 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastStringInf operator+(FastString29 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastStringInf operator+(FastString30 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastStringInf operator+(FastString31 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public static FastStringInf operator+(FastString32 a, FastString18 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 18; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 18;
    }

    public unsafe struct FastString19 : IFastString
    {
        internal fixed char letters[19];
        public static FastString19 operator+(FastString0 a, FastString19 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastString20 operator+(FastString1 a, FastString19 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastString21 operator+(FastString2 a, FastString19 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastString22 operator+(FastString3 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastString23 operator+(FastString4 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastString24 operator+(FastString5 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastString25 operator+(FastString6 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastString26 operator+(FastString7 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastString27 operator+(FastString8 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastString28 operator+(FastString9 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastString29 operator+(FastString10 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastString30 operator+(FastString11 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastString31 operator+(FastString12 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastString32 operator+(FastString13 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastStringInf operator+(FastString14 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastStringInf operator+(FastString15 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastStringInf operator+(FastString16 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastStringInf operator+(FastString17 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastStringInf operator+(FastString18 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastStringInf operator+(FastString19 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastStringInf operator+(FastString20 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastStringInf operator+(FastString21 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastStringInf operator+(FastString22 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastStringInf operator+(FastString23 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastStringInf operator+(FastString24 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastStringInf operator+(FastString25 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastStringInf operator+(FastString26 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastStringInf operator+(FastString27 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastStringInf operator+(FastString28 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastStringInf operator+(FastString29 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastStringInf operator+(FastString30 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastStringInf operator+(FastString31 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public static FastStringInf operator+(FastString32 a, FastString19 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 19; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 19;
    }

    public unsafe struct FastString20 : IFastString
    {
        internal fixed char letters[20];
        public static FastString20 operator+(FastString0 a, FastString20 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastString21 operator+(FastString1 a, FastString20 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastString22 operator+(FastString2 a, FastString20 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastString23 operator+(FastString3 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastString24 operator+(FastString4 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastString25 operator+(FastString5 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastString26 operator+(FastString6 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastString27 operator+(FastString7 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastString28 operator+(FastString8 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastString29 operator+(FastString9 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastString30 operator+(FastString10 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastString31 operator+(FastString11 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastString32 operator+(FastString12 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastStringInf operator+(FastString13 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastStringInf operator+(FastString14 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastStringInf operator+(FastString15 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastStringInf operator+(FastString16 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastStringInf operator+(FastString17 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastStringInf operator+(FastString18 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastStringInf operator+(FastString19 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastStringInf operator+(FastString20 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastStringInf operator+(FastString21 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastStringInf operator+(FastString22 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastStringInf operator+(FastString23 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastStringInf operator+(FastString24 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastStringInf operator+(FastString25 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastStringInf operator+(FastString26 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastStringInf operator+(FastString27 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastStringInf operator+(FastString28 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastStringInf operator+(FastString29 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastStringInf operator+(FastString30 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastStringInf operator+(FastString31 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public static FastStringInf operator+(FastString32 a, FastString20 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 20; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 20;
    }

    public unsafe struct FastString21 : IFastString
    {
        internal fixed char letters[21];
        public static FastString21 operator+(FastString0 a, FastString21 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastString22 operator+(FastString1 a, FastString21 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastString23 operator+(FastString2 a, FastString21 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastString24 operator+(FastString3 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastString25 operator+(FastString4 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastString26 operator+(FastString5 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastString27 operator+(FastString6 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastString28 operator+(FastString7 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastString29 operator+(FastString8 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastString30 operator+(FastString9 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastString31 operator+(FastString10 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastString32 operator+(FastString11 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastStringInf operator+(FastString12 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastStringInf operator+(FastString13 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastStringInf operator+(FastString14 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastStringInf operator+(FastString15 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastStringInf operator+(FastString16 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastStringInf operator+(FastString17 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastStringInf operator+(FastString18 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastStringInf operator+(FastString19 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastStringInf operator+(FastString20 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastStringInf operator+(FastString21 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastStringInf operator+(FastString22 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastStringInf operator+(FastString23 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastStringInf operator+(FastString24 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastStringInf operator+(FastString25 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastStringInf operator+(FastString26 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastStringInf operator+(FastString27 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastStringInf operator+(FastString28 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastStringInf operator+(FastString29 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastStringInf operator+(FastString30 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastStringInf operator+(FastString31 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public static FastStringInf operator+(FastString32 a, FastString21 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 21; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 21;
    }

    public unsafe struct FastString22 : IFastString
    {
        internal fixed char letters[22];
        public static FastString22 operator+(FastString0 a, FastString22 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastString23 operator+(FastString1 a, FastString22 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastString24 operator+(FastString2 a, FastString22 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastString25 operator+(FastString3 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastString26 operator+(FastString4 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastString27 operator+(FastString5 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastString28 operator+(FastString6 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastString29 operator+(FastString7 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastString30 operator+(FastString8 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastString31 operator+(FastString9 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastString32 operator+(FastString10 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString11 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString12 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString13 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString14 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString15 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString16 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString17 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString18 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString19 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString20 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString21 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString22 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString23 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString24 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString25 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString26 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString27 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString28 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString29 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString30 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString31 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public static FastStringInf operator+(FastString32 a, FastString22 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 22; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 22;
    }

    public unsafe struct FastString23 : IFastString
    {
        internal fixed char letters[23];
        public static FastString23 operator+(FastString0 a, FastString23 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastString24 operator+(FastString1 a, FastString23 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastString25 operator+(FastString2 a, FastString23 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastString26 operator+(FastString3 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastString27 operator+(FastString4 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastString28 operator+(FastString5 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastString29 operator+(FastString6 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastString30 operator+(FastString7 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastString31 operator+(FastString8 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastString32 operator+(FastString9 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString10 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString11 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString12 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString13 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString14 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString15 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString16 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString17 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString18 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString19 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString20 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString21 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString22 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString23 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString24 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString25 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString26 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString27 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString28 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString29 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString30 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString31 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public static FastStringInf operator+(FastString32 a, FastString23 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 23; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 23;
    }

    public unsafe struct FastString24 : IFastString
    {
        internal fixed char letters[24];
        public static FastString24 operator+(FastString0 a, FastString24 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastString25 operator+(FastString1 a, FastString24 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastString26 operator+(FastString2 a, FastString24 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastString27 operator+(FastString3 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastString28 operator+(FastString4 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastString29 operator+(FastString5 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastString30 operator+(FastString6 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastString31 operator+(FastString7 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastString32 operator+(FastString8 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString9 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString10 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString11 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString12 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString13 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString14 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString15 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString16 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString17 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString18 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString19 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString20 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString21 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString22 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString23 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString24 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString25 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString26 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString27 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString28 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString29 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString30 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString31 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public static FastStringInf operator+(FastString32 a, FastString24 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 24; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 24;
    }

    public unsafe struct FastString25 : IFastString
    {
        internal fixed char letters[25];
        public static FastString25 operator+(FastString0 a, FastString25 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastString26 operator+(FastString1 a, FastString25 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastString27 operator+(FastString2 a, FastString25 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastString28 operator+(FastString3 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastString29 operator+(FastString4 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastString30 operator+(FastString5 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastString31 operator+(FastString6 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastString32 operator+(FastString7 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString8 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString9 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString10 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString11 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString12 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString13 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString14 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString15 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString16 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString17 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString18 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString19 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString20 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString21 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString22 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString23 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString24 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString25 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString26 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString27 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString28 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString29 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString30 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString31 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public static FastStringInf operator+(FastString32 a, FastString25 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 25; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 25;
    }

    public unsafe struct FastString26 : IFastString
    {
        internal fixed char letters[26];
        public static FastString26 operator+(FastString0 a, FastString26 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastString27 operator+(FastString1 a, FastString26 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastString28 operator+(FastString2 a, FastString26 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastString29 operator+(FastString3 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastString30 operator+(FastString4 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastString31 operator+(FastString5 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastString32 operator+(FastString6 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString7 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString8 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString9 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString10 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString11 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString12 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString13 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString14 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString15 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString16 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString17 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString18 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString19 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString20 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString21 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString22 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString23 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString24 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString25 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString26 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString27 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString28 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString29 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString30 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString31 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public static FastStringInf operator+(FastString32 a, FastString26 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 26; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 26;
    }

    public unsafe struct FastString27 : IFastString
    {
        internal fixed char letters[27];
        public static FastString27 operator+(FastString0 a, FastString27 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastString28 operator+(FastString1 a, FastString27 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastString29 operator+(FastString2 a, FastString27 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastString30 operator+(FastString3 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastString31 operator+(FastString4 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastString32 operator+(FastString5 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString6 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString7 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString8 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString9 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString10 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString11 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString12 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString13 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString14 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString15 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString16 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString17 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString18 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString19 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString20 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString21 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString22 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString23 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString24 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString25 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString26 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString27 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString28 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString29 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString30 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString31 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public static FastStringInf operator+(FastString32 a, FastString27 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 27; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 27;
    }

    public unsafe struct FastString28 : IFastString
    {
        internal fixed char letters[28];
        public static FastString28 operator+(FastString0 a, FastString28 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastString29 operator+(FastString1 a, FastString28 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastString30 operator+(FastString2 a, FastString28 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastString31 operator+(FastString3 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastString32 operator+(FastString4 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString5 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString6 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString7 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString8 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString9 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString10 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString11 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString12 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString13 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString14 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString15 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString16 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString17 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString18 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString19 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString20 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString21 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString22 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString23 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString24 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString25 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString26 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString27 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString28 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString29 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString30 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString31 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public static FastStringInf operator+(FastString32 a, FastString28 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 28; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 28;
    }

    public unsafe struct FastString29 : IFastString
    {
        internal fixed char letters[29];
        public static FastString29 operator+(FastString0 a, FastString29 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastString30 operator+(FastString1 a, FastString29 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastString31 operator+(FastString2 a, FastString29 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastString32 operator+(FastString3 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString4 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString5 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString6 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString7 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString8 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString9 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString10 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString11 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString12 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString13 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString14 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString15 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString16 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString17 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString18 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString19 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString20 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString21 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString22 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString23 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString24 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString25 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString26 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString27 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString28 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString29 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString30 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString31 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public static FastStringInf operator+(FastString32 a, FastString29 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 29; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 29;
    }

    public unsafe struct FastString30 : IFastString
    {
        internal fixed char letters[30];
        public static FastString30 operator+(FastString0 a, FastString30 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastString31 operator+(FastString1 a, FastString30 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastString32 operator+(FastString2 a, FastString30 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString3 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString4 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString5 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString6 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString7 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString8 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString9 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString10 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString11 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString12 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString13 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString14 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString15 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString16 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString17 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString18 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString19 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString20 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString21 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString22 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString23 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString24 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString25 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString26 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString27 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString28 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString29 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString30 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString31 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public static FastStringInf operator+(FastString32 a, FastString30 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 30; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 30;
    }

    public unsafe struct FastString31 : IFastString
    {
        internal fixed char letters[31];
        public static FastString31 operator+(FastString0 a, FastString31 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastString32 operator+(FastString1 a, FastString31 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString2 a, FastString31 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString3 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString4 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString5 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString6 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString7 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString8 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString9 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString10 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString11 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString12 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString13 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString14 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString15 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString16 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString17 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString18 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString19 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString20 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString21 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString22 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString23 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString24 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString25 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString26 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString27 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString28 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString29 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString30 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString31 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public static FastStringInf operator+(FastString32 a, FastString31 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 31; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 31;
    }

    public unsafe struct FastString32 : IFastString
    {
        internal fixed char letters[32];
        public static FastString32 operator+(FastString0 a, FastString32 b)
            => Factory.Construct(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString1 a, FastString32 b)
            => Factory.Construct(a[0], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString2 a, FastString32 b)
            => Factory.Construct(a[0], a[1], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString3 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString4 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString5 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString6 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString7 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString8 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString9 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString10 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString11 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString12 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString13 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString14 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString15 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString16 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString17 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString18 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString19 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString20 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString21 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString22 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString23 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString24 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString25 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString26 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString27 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString28 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString29 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString30 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString31 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public static FastStringInf operator+(FastString32 a, FastString32 b)
            => Factory.Construct(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15], a[16], a[17], a[18], a[19], a[20], a[21], a[22], a[23], a[24], a[25], a[26], a[27], a[28], a[29], a[30], a[31], b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17], b[18], b[19], b[20], b[21], b[22], b[23], b[24], b[25], b[26], b[27], b[28], b[29], b[30], b[31]);
        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < 32; i++)
                res += letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => 32;
    }

    public struct FastStringInf : IFastString
    {
        internal char[] letters;
        public static FastStringInf operator +(FastStringInf a, FastStringInf b)
        {
            var res = new FastStringInf();
            res.letters = new char[a.letters.Length + b.letters.Length];
            for (int i = 0; i < a.letters.Length; i++)
                res.letters[i] = a.letters[i];
            for (int i = 0; i < b.letters.Length; i++)
                res.letters[i + a.letters.Length] = b.letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => letters.Length;
        public override string ToString()
            => string.Join("", letters);
    }
    
}