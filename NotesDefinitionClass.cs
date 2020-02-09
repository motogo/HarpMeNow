namespace HarpMeNow
{
    public class NoteClass
    {
        public string NoteBlow = string.Empty;
        public byte NoteKeyBlow = 0;
        public string NoteDraw = string.Empty;
        public byte NoteKeyDraw = 0;
    }
    public static class NotesStaticClass
    {
        public static byte GetNote(string note)
        {
            switch (note)
            {

                case Statics.C0:
                case Statics.c0:
                case Statics.C_0:
                case Statics.c_0:
                    return 48;

                case Statics.CIS0:
                case Statics.cis0:
                case Statics.CIS_0:
                case Statics.cis_0:
                case Statics.DB0:
                case Statics.db0:
                case Statics.DB_0:
                case Statics.db_0:
                    return 49;

                case Statics.D0:
                case Statics.d0:
                case Statics.D_0:
                case Statics.d_0:
                    return 50;

                case Statics.DIS0:
                case Statics.dis0:
                case Statics.DIS_0:
                case Statics.dis_0:
                case Statics.EB0:
                case Statics.eb0:
                case Statics.EB_0:
                case Statics.eb_0:
                    return 51;

                case Statics.E0:
                case Statics.e0:
                case Statics.E_0:
                case Statics.e_0:
                    return 52;

                case Statics.F0:
                case Statics.f0:
                case Statics.F_0:
                case Statics.f_0:
                    return 53;

                case Statics.FIS0:
                case Statics.fis0:
                case Statics.FIS_0:
                case Statics.fis_0:
                case Statics.GB0:
                case Statics.gb0:
                case Statics.GB_0:
                case Statics.gb_0:
                    return 54;

                case Statics.G0:
                case Statics.g0:
                case Statics.G_0:
                case Statics.g_0:
                    return 55;

                case Statics.GIS0:
                case Statics.gis0:
                case Statics.GIS_0:
                case Statics.gis_0:
                case Statics.AB0:
                case Statics.ab0:
                case Statics.AB_0:
                case Statics.ab_0:
                    return 56;

                case Statics.A0:
                case Statics.a0:
                case Statics.A_0:
                case Statics.a_0:
                    return 57;

                case Statics.AIS0:
                case Statics.ais0:
                case Statics.AIS_0:
                case Statics.ais_0:
                case Statics.B0:
                case Statics.b0:
                case Statics.B_0:
                case Statics.b_0:
                    return 58;

                case Statics.H0:
                case Statics.h0:
                case Statics.H_0:
                case Statics.h_0:
                    return 59;

                case Statics.C1:
                case Statics.c1:
                case Statics.C_1:
                case Statics.c_1:
                    return 60;

                case Statics.CIS1:
                case Statics.cis1:
                case Statics.CIS_1:
                case Statics.cis_1:
                case Statics.DB1:
                case Statics.db1:
                case Statics.DB_1:
                case Statics.db_1:
                    return 61;

                case Statics.D1:
                case Statics.d1:
                case Statics.D_1:
                case Statics.d_1:
                    return 62;

                case Statics.DIS1:
                case Statics.dis1:
                case Statics.DIS_1:
                case Statics.dis_1:
                case Statics.EB1:
                case Statics.eb1:
                case Statics.EB_1:
                case Statics.eb_1:
                    return 63;

                case Statics.E1:
                case Statics.e1:
                case Statics.E_1:
                case Statics.e_1:
                    return 64;

                case Statics.F1:
                case Statics.f1:
                case Statics.F_1:
                case Statics.f_1:
                    return 65;

                case Statics.FIS1:
                case Statics.fis1:
                case Statics.FIS_1:
                case Statics.fis_1:
                case Statics.GB1:
                case Statics.gb1:
                case Statics.GB_1:
                case Statics.gb_1:
                    return 66;

                case Statics.G1:
                case Statics.g1:
                case Statics.G_1:
                case Statics.g_1:
                    return 67;

                case Statics.GIS1:
                case Statics.gis1:
                case Statics.GIS_1:
                case Statics.gis_1:
                case Statics.AB1:
                case Statics.ab1:
                case Statics.AB_1:
                case Statics.ab_1:
                    return 68;

                case Statics.A1:
                case Statics.a1:
                case Statics.A_1:
                case Statics.a_1:
                    return 69;

                case Statics.AIS1:
                case Statics.ais1:
                case Statics.AIS_1:
                case Statics.ais_1:
                case Statics.B1:
                case Statics.b1:
                case Statics.B_1:
                case Statics.b_1:
                    return 70;

                case Statics.H1:
                case Statics.h1:
                case Statics.H_1:
                case Statics.h_1:
                    return 71;

                case Statics.C2:
                case Statics.c2:
                case Statics.C_2:
                case Statics.c_2:
                    return 72;

                case Statics.CIS2:
                case Statics.cis2:
                case Statics.CIS_2:
                case Statics.cis_2:
                case Statics.DB2:
                case Statics.db2:
                case Statics.DB_2:
                case Statics.db_2:
                    return 73;

                case Statics.D2:
                case Statics.d2:
                case Statics.D_2:
                case Statics.d_2:
                    return 74;

                case Statics.DIS2:
                case Statics.dis2:
                case Statics.DIS_2:
                case Statics.dis_2:
                case Statics.EB2:
                case Statics.eb2:
                case Statics.EB_2:
                case Statics.eb_2:
                    return 75;

                case Statics.E2:
                case Statics.e2:
                case Statics.E_2:
                case Statics.e_2:
                    return 76;

                case Statics.F2:
                case Statics.f2:
                case Statics.F_2:
                case Statics.f_2:
                    return 77;

                case Statics.FIS2:
                case Statics.fis2:
                case Statics.FIS_2:
                case Statics.fis_2:
                case Statics.GB2:
                case Statics.gb2:
                case Statics.GB_2:
                case Statics.gb_2:
                    return 78;

                case Statics.G2:
                case Statics.g2:
                case Statics.G_2:
                case Statics.g_2:
                    return 79;

                case Statics.GIS2:
                case Statics.gis2:
                case Statics.GIS_2:
                case Statics.gis_2:
                case Statics.AB2:
                case Statics.ab2:
                case Statics.AB_2:
                case Statics.ab_2:
                    return 80;

                case Statics.A2:
                case Statics.a2:
                case Statics.A_2:
                case Statics.a_2:
                    return 81;

                case Statics.AIS2:
                case Statics.ais2:
                case Statics.AIS_2:
                case Statics.ais_2:
                case Statics.B2:
                case Statics.b2:
                case Statics.B_2:
                case Statics.b_2:
                    return 82;

                case Statics.H2:
                case Statics.h2:
                case Statics.H_2:
                case Statics.h_2:
                    return 83;


                case Statics.C3:
                case Statics.c3:
                case Statics.C_3:
                case Statics.c_3:
                    return 84;

                case Statics.CIS3:
                case Statics.cis3:
                case Statics.CIS_3:
                case Statics.cis_3:
                case Statics.DB3:
                case Statics.db3:
                case Statics.DB_3:
                case Statics.db_3:
                    return 85;

                case Statics.D3:
                case Statics.d3:
                case Statics.D_3:
                case Statics.d_3:
                    return 86;

                case Statics.DIS3:
                case Statics.dis3:
                case Statics.DIS_3:
                case Statics.dis_3:
                case Statics.EB3:
                case Statics.eb3:
                case Statics.EB_3:
                case Statics.eb_3:
                    return 87;

                case Statics.E3:
                case Statics.e3:
                case Statics.E_3:
                case Statics.e_3:
                    return 88;

                case Statics.F3:
                case Statics.f3:
                case Statics.F_3:
                case Statics.f_3:
                    return 89;

                case Statics.FIS3:
                case Statics.fis3:
                case Statics.FIS_3:
                case Statics.fis_3:
                case Statics.GB3:
                case Statics.gb3:
                case Statics.GB_3:
                case Statics.gb_3:
                    return 90;

                case Statics.G3:
                case Statics.g3:
                case Statics.G_3:
                case Statics.g_3:
                    return 91;

                case Statics.GIS3:
                case Statics.gis3:
                case Statics.GIS_3:
                case Statics.gis_3:
                case Statics.AB3:
                case Statics.ab3:
                case Statics.AB_3:
                case Statics.ab_3:
                    return 92;

                case Statics.A3:
                case Statics.a3:
                case Statics.A_3:
                case Statics.a_3:
                    return 93;

                case Statics.AIS3:
                case Statics.ais3:
                case Statics.AIS_3:
                case Statics.ais_3:
                case Statics.B3:
                case Statics.b3:
                case Statics.B_3:
                case Statics.b_3:
                    return 94;

                case Statics.H3:
                case Statics.h3:
                case Statics.H_3:
                case Statics.h_3:
                    return 95;

            };
            return 0;
        }
    }
}
