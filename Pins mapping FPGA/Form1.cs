using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pins_mapping_FPGA
{
   
    public partial class Form1 : Form
    {
        int[] mappimg_array = new int [256];

        public Form1()
        {   //индекс - отечественная плис, значение - зарубежная
            InitializeComponent();
            mappimg_array[0] = 0;
            mappimg_array[1] = 181;
            mappimg_array[2] = 183;
            mappimg_array[3] = 182;
            mappimg_array[4] = 0;
            mappimg_array[5] = 184;
            mappimg_array[6] = 186;
            mappimg_array[7] = 185;
            mappimg_array[8] = 188;
            mappimg_array[9] = 0;
            mappimg_array[10] = 191;
            mappimg_array[11] = 190;
            mappimg_array[12] = 193;
            mappimg_array[13] = 192;
            mappimg_array[14] = 194;
            mappimg_array[15] =0;
            mappimg_array[16] = 196;
            mappimg_array[17] = 195;
            mappimg_array[18] = 199;
            mappimg_array[19] = 198;
            mappimg_array[20] = 201;
            mappimg_array[21] = 200;
            mappimg_array[22] = 202;
            mappimg_array[23] = 203;
            mappimg_array[24] = 204;
            mappimg_array[25] = 0;
            mappimg_array[26] = 206;
            mappimg_array[27] = 207;
            mappimg_array[28] = 208;
            mappimg_array[29] = 209;
            mappimg_array[30] = 0;
            mappimg_array[31] = 0;
            mappimg_array[32] = 210;
            mappimg_array[33] = 211;
            mappimg_array[34] = 212;
            mappimg_array[35] = 0;
            mappimg_array[36] = 0;
            mappimg_array[37] = 213;
            mappimg_array[38] = 214;
            mappimg_array[39] = 215;
            mappimg_array[40] = 217;
            mappimg_array[41] = 218;
            mappimg_array[42] = 219;
            mappimg_array[43] = 220;
            mappimg_array[44] = 221;
            mappimg_array[45] = 111;
            mappimg_array[46] = 222;
            mappimg_array[47] =0;
            mappimg_array[48] = 223;
            mappimg_array[49] = 227;
            mappimg_array[50] = 226;
            mappimg_array[51] = 229;
            mappimg_array[52] = 228;
            mappimg_array[53] = 0;
            mappimg_array[54] = 230;
            mappimg_array[55] = 233;
            mappimg_array[56] = 231;
            mappimg_array[57] = 235;
            mappimg_array[58] = 234;
            mappimg_array[59] = 237;
            mappimg_array[60] = 236; 
            mappimg_array[61] = 239;
            mappimg_array[62] = 238;
            mappimg_array[63] = 240;
            mappimg_array[64] =0;
            mappimg_array[65] = 1;
            mappimg_array[66] = 2;
            mappimg_array[67] = 3;
            mappimg_array[68] = 4;
            mappimg_array[69] = 6;
            mappimg_array[70] =0;
            mappimg_array[71] = 7;
            mappimg_array[72] = 8;
            mappimg_array[73] = 9;
            mappimg_array[74] = 11;
            mappimg_array[75] =0;
            mappimg_array[76] =0;
            mappimg_array[77] = 13;
            mappimg_array[78] = 14;
            mappimg_array[79] =0;
            mappimg_array[80] = 17;
            mappimg_array[81] =0;
            mappimg_array[82] = 18;
            mappimg_array[83] = 19;
            mappimg_array[84] =0;
            mappimg_array[85] = 21;
            mappimg_array[86] = 23;
            mappimg_array[87] =0;
            mappimg_array[88] = 24;
            mappimg_array[89] = 25;
            mappimg_array[90] = 26;
            mappimg_array[91] = 28;
            mappimg_array[92] =0;
            mappimg_array[93] = 29;
            mappimg_array[94] = 30;
            mappimg_array[95] = 31;
            mappimg_array[96] =0;
            mappimg_array[97] =0;
            mappimg_array[98] = 33;
            mappimg_array[99] =0;
            mappimg_array[100] = 34;
            mappimg_array[101] = 35;
            mappimg_array[102] = 36;
            mappimg_array[103] =0;
            mappimg_array[104] = 38;
            mappimg_array[105] = 39;
            mappimg_array[106] =0;
            mappimg_array[107] = 41;
            mappimg_array[108] =0;
            mappimg_array[109] = 43;
            mappimg_array[110] = 44;
            mappimg_array[111] = 45;
            mappimg_array[112] = 46;
            mappimg_array[113] =0;
            mappimg_array[114] = 48;
            mappimg_array[115] = 49;
            mappimg_array[116] = 50;
            mappimg_array[117] = 51;
            mappimg_array[118] = 53;
            mappimg_array[119] =0;
            mappimg_array[120] = 54;
            mappimg_array[121] = 55;
            mappimg_array[122] = 56;
            mappimg_array[123] =0;
            mappimg_array[124] =0;
            mappimg_array[125] = 58;
            mappimg_array[126] = 59;
            mappimg_array[127] = 60;
            mappimg_array[128] =0;
            mappimg_array[129] = 0;
            mappimg_array[130] = 62;
            mappimg_array[131] = 61;
            mappimg_array[132] = 64;
            mappimg_array[133] = 63;
            mappimg_array[134] = 66;
            mappimg_array[135] = 65;
            mappimg_array[136] = 68;
            mappimg_array[137] = 67;
            mappimg_array[138] = 71;
            mappimg_array[139] = 70;
            mappimg_array[140] = 73;
            mappimg_array[141] = 72;
            mappimg_array[142] = 75;
            mappimg_array[143] = 74;
            mappimg_array[144] = 78;
            mappimg_array[145] =0;
            mappimg_array[146] =0;
            mappimg_array[147] = 79;
            mappimg_array[148] = 81;
            mappimg_array[149] = 80;
            mappimg_array[150] = 82;
            mappimg_array[151] =0;
            mappimg_array[152] = 83;
            mappimg_array[153] = 84;
            mappimg_array[154] = 86;
            mappimg_array[155] = 87;
            mappimg_array[156] = 88;
            mappimg_array[157] =0;
            mappimg_array[158] =0;
            mappimg_array[159] = 90;
            mappimg_array[160] = 91;
            mappimg_array[161] = 92;
            mappimg_array[162] =0;
            mappimg_array[163] =0;
            mappimg_array[164] =0;
            mappimg_array[165] =0;
            mappimg_array[166] = 94;
            mappimg_array[167] = 95;
            mappimg_array[168] = 97;
            mappimg_array[169] = 98;
            mappimg_array[170] = 99;
            mappimg_array[171] = 100;
            mappimg_array[172] = 101;
            mappimg_array[173] = 102;
            mappimg_array[174] = 103;
            mappimg_array[175] = 105;
            mappimg_array[176] =0;
            mappimg_array[177] = 107;
            mappimg_array[178] = 106;
            mappimg_array[179] = 109;
            mappimg_array[180] = 108;
            mappimg_array[181] = 111;
            mappimg_array[182] = 110;
            mappimg_array[183] = 113;
            mappimg_array[184] =0;
            mappimg_array[185] = 115;
            mappimg_array[186] = 114;
            mappimg_array[187] = 117;
            mappimg_array[188] = 116;
            mappimg_array[189] = 119;
            mappimg_array[190] = 118;
            mappimg_array[191] = 0;
            mappimg_array[192] = 120;
            mappimg_array[193] = 121;
            mappimg_array[194] = 122;
            mappimg_array[195] = 123;
            mappimg_array[196] = 124;
            mappimg_array[197] = 0;
            mappimg_array[198] = 0;
            mappimg_array[199] = 127;
            mappimg_array[200] = 128;
            mappimg_array[201] = 129;
            mappimg_array[202] = 131;
            mappimg_array[203] =0;
            mappimg_array[204] = 132;
            mappimg_array[205] = 133;
            mappimg_array[206] = 134;
            mappimg_array[207] = 136;
            mappimg_array[208] =0;
            mappimg_array[209] = 137;
            mappimg_array[210] = 198;
            mappimg_array[211] =0;
            mappimg_array[212] = 141;
            mappimg_array[213] =0;
            mappimg_array[214] = 142;
            mappimg_array[215] = 143;
            mappimg_array[216] = 144;
            mappimg_array[217] = 146;
            mappimg_array[218] =0;
            mappimg_array[219] = 147;
            mappimg_array[220] = 148;
            mappimg_array[221] = 149;
            mappimg_array[222] =0;
            mappimg_array[223] =0;
            mappimg_array[224] = 151;
            mappimg_array[225] =0;
            mappimg_array[226] = 152;
            mappimg_array[227] = 153;
            mappimg_array[228] =0;
            mappimg_array[229] = 154;
            mappimg_array[230] = 156;
            mappimg_array[231] = 157;
            mappimg_array[232] = 158;
            mappimg_array[233] =0;
            mappimg_array[234] =0;
            mappimg_array[235] = 161;
            mappimg_array[236] = 162;
            mappimg_array[237] =0;
            mappimg_array[238] =0;
            mappimg_array[239] = 164;
            mappimg_array[240] = 166;
            mappimg_array[241] = 167;
            mappimg_array[242] = 168;
            mappimg_array[243] =0;
            mappimg_array[244] = 169;
            mappimg_array[245] = 171;
            mappimg_array[246] = 172;
            mappimg_array[247] = 173;
            mappimg_array[248] = 0;
            mappimg_array[249] = 0;
            mappimg_array[250] = 174;
            mappimg_array[251] = 174;
            mappimg_array[252] = 177;
            mappimg_array[253] = 178;
            mappimg_array[254] = 179;
            mappimg_array[255] = 180;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int a;
                if (int.TryParse(textBox1.Text, out a))
                {
                    if(a<=255 && a >= 0)

                    {
                        if (mappimg_array[a] != 0)
                            textBox2.Text = mappimg_array[a].ToString();
                        else
                            textBox2.Text = "Отсутсвует";
                    }
                    else
                        textBox2.Text = "Отсутсвует";

                }
                else
                    textBox2.Text = "";
            }
            else
                textBox2.Text = "";
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                int a;
                if (int.TryParse(textBox4.Text, out a))
                {
                    if (a <= 255 && a >= 0)
                    {
                        if (mappimg_array[a] != 0)
                            textBox3.Text = mappimg_array[a].ToString();
                        else
                            textBox3.Text = "Отсутсвует";
                    }
                    else
                        textBox3.Text = "Отсутсвует";
                }
                else
                    textBox3.Text = "";
            }
            else
                textBox3.Text = "";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                int a;
                if (int.TryParse(textBox6.Text, out a))
                {
                    if (a <= 255 && a >= 0)
                    {
                        if (mappimg_array[a] != 0)
                            textBox5.Text = mappimg_array[a].ToString();
                        else
                            textBox5.Text = "Отсутсвует";
                    }
                    else
                        textBox5.Text = "Отсутсвует";
                }
                else
                    textBox5.Text = "";
            }
            else
                textBox5.Text = "";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
                int a;
                if (int.TryParse(textBox8.Text, out a))
                {
                    if (a <= 255 && a >= 0)
                    {
                        if (mappimg_array[a] != 0)
                            textBox7.Text = mappimg_array[a].ToString();
                        else
                            textBox7.Text = "Отсутсвует";
                    }
                    else
                        textBox7.Text = "Отсутсвует";
                }
                else
                    textBox7.Text = "";
            }
            else
                textBox7.Text = "";
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                int a;
                if (int.TryParse(textBox10.Text, out a))
                {
                    if (a <= 255 && a >= 0)
                    {
                        if (mappimg_array[a] != 0)
                            textBox9.Text = mappimg_array[a].ToString();
                        else
                            textBox9.Text = "Отсутсвует";
                    }
                    else
                        textBox9.Text = "Отсутсвует";
                }
                else
                    textBox9.Text = "";
            }
            else
                textBox9.Text = "";
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (textBox20.Text != "")
            {
                int a;
                if (int.TryParse(textBox20.Text, out a))
                {
                    int i = 0;
                    if(a==0)
                        textBox19.Text = "Отсутсвует";
                    else
                    { 
                        for (i = 0; i <= 255; i++)
                        {
                            if (mappimg_array[i] == a)
                            {
                                textBox19.Text = i.ToString();
                                i = 300;
                            }

                        }
                        if (i == 256)
                        {
                            textBox19.Text = "Отсутсвует";
                        }
                    }
                }
                else
                    textBox19.Text = "";
            }
            else
                textBox19.Text = "";
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (textBox18.Text != "")
            {
                int a;
                if (int.TryParse(textBox18.Text, out a))
                {
                    int i = 0;
                    if (a == 0)
                        textBox17.Text = "Отсутсвует";
                    else
                    {
                        for (i = 0; i <= 255; i++)
                        {
                            if (mappimg_array[i] == a)
                            {
                                textBox17.Text = i.ToString();
                                i = 300;
                            }

                        }
                        if (i == 256)
                        {
                            textBox17.Text = "Отсутсвует";
                        }
                    }
                }
                else
                    textBox17.Text = "";
            }
            else
                textBox17.Text = "";
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (textBox16.Text != "")
            {
                int a;
                if (int.TryParse(textBox16.Text, out a))
                {
                    int i = 0;
                    if (a == 0)
                        textBox15.Text = "Отсутсвует";
                    else
                    {
                        for (i = 0; i <= 255; i++)
                        {
                            if (mappimg_array[i] == a)
                            {
                                textBox15.Text = i.ToString();
                                i = 300;
                            }

                        }
                        if (i == 256)
                        {
                            textBox15.Text = "Отсутсвует";
                        }
                    }
                }
                else
                    textBox15.Text = "";
            }
            else
                textBox15.Text = "";
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text != "")
            {
                int a;
                if (int.TryParse(textBox14.Text, out a))
                {
                    int i = 0;
                    if (a == 0)
                        textBox13.Text = "Отсутсвует";
                    else
                    {
                        for (i = 0; i <= 255; i++)
                        {
                            if (mappimg_array[i] == a)
                            {
                                textBox13.Text = i.ToString();
                                i = 300;
                            }

                        }
                        if (i == 256)
                        {
                            textBox13.Text = "Отсутсвует";
                        }
                    }
                }
                else
                    textBox13.Text = "";
            }
            else
                textBox13.Text = "";
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text != "")
            {
                int a;
                if (int.TryParse(textBox12.Text, out a))
                {
                    int i = 0;
                    if (a == 0)
                        textBox11.Text = "Отсутсвует";
                    else
                    {
                        for (i = 0; i <= 255; i++)
                        {
                            if (mappimg_array[i] == a)
                            {
                                textBox11.Text = i.ToString();
                                i = 300;
                            }

                        }
                        if (i == 256)
                        {
                            textBox11.Text = "Отсутсвует";
                        }
                    }
                }
                else
                    textBox11.Text = "";
            }
            else
                textBox11.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            textBox10.Text = "";
            textBox20.Text = "";
            textBox18.Text = "";
            textBox16.Text = "";
            textBox14.Text = "";
            textBox12.Text = "";
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("мсв");
        }


    }
}
