using BasicClassLibrary;
using System.Collections.Generic;
using System.Drawing;

namespace HarpMeNow
{
    public enum eSongFormat { simple, abc }
    public static class Statics
    {
        public static string SetVolume = "SetVolume";
        public static string SetVelocity = "SetVelocity";
        public static string SetTranspose = "SetTranspose";
        public static string SilderString = "=>";
        public static string DrawString = "-";
     
        // ABC Song Definitionen
        public static string ReferenceNumberKey = "X:";
        public static string SongTitleKey = "T:";
        public static string SongUnitLengthKey = "L:";
        public static string SongMetrumKey = "M:";
        public static string SongTonalityKey = "K:";
        public static string SongTempoKey = "Q:";
        // Extended ABC Song Definitionen
        public static string SongInstrumentKey = "I:";
        public static string SongVolumeKey = "V:";       

        //Notenkeys nach ABC Notation
        public static string PauseKey = "z";
        public static string HalfUpKey = "^";
        public static string HalfDownKey = "_";
        public static string BlockStartKey = "[";
        public static string BlockEndKey = "]";
        public static string RepeatKey = ":";
            
        public static string TaktKey = "|";
        public static string Divider = "/";
        public static string DotUpKey = ">";                    //g>a Der Ton links vom > wird um die Hälfte verlängert, der Ton rechts vom > entsprechend um die Hälfte verkürzt
        public static string DotDownKey = "<";                  //g<a Der Ton rechts vom < wird um die Hälfte verlängert, der Ton links vom < entsprechend um die Hälfte verkürzt
        public static string HarpAttributeDivider = ";";
        public static string HarpNotesDivider = ",";
        public static string HarpNotesImageSpace = "  ";
        public static string SongAttributeDivider = "";
        public static string SongNotesDivider = " ";
        public static string SongEqualKey = "=";
        public static string CommentKey = "%";
        //public static string SongKeyStr = "Songkey";
        public static string InstrumentStr = "Instrument";
        public static string RefInstrumentStr = "ReferenceInstrument";
        public static double NoteDelayFactor = 5.0;
        public static int SlotButtonWitdh = 48;
        public static int PlayButtonWitdh = 52;
        public static int PlayButtonHeight = 40;
        public static int TabButtonWitdh = 12;
        public static double VelocityFactor = 5.0;
        public static double RefTempo = 120;

        public const string c_0 = "c";
        public const string C_0 = "C";
        public const string c_1 = "c'";
        public const string C_1 = "C'";
        public const string c_2 = "c''";
        public const string C_2 = "C''";
        public const string c_3 = "c'''";
        public const string C_3 = "C'''";
        public const string c0 = "c0";
        public const string C0 = "C0";
        public const string c1 = "c1";
        public const string C1 = "C1";
        public const string c2 = "c2";
        public const string C2 = "C2";
        public const string c3 = "c3";
        public const string C3 = "C3";

        public const string d_0 = "d";
        public const string D_0 = "D";
        public const string d_1 = "d'";
        public const string D_1 = "D'";
        public const string d_2 = "d''";
        public const string D_2 = "D''";
        public const string d_3 = "d'''";
        public const string D_3 = "D'''";


        public const string d0 = "d0";
        public const string D0 = "D0";
        public const string d1 = "d1";
        public const string D1 = "D1";
        public const string d2 = "d2";
        public const string D2 = "D2";
        public const string d3 = "d3";
        public const string D3 = "D3";

        public const string e_0 = "e";
        public const string E_0 = "E";
        public const string e_1 = "e'";
        public const string E_1 = "E'";
        public const string e_2 = "e''";
        public const string E_2 = "E''";
        public const string e_3 = "e'''";
        public const string E_3 = "E'''";
        public const string e0 = "e0";
        public const string E0 = "E0";
        public const string e1 = "e1";
        public const string E1 = "E1";
        public const string e2 = "e2";
        public const string E2 = "E2";
        public const string e3 = "e3";
        public const string E3 = "E3";

        public const string f_0 = "f";
        public const string F_0 = "F";
        public const string f_1 = "f'";
        public const string F_1 = "F'";
        public const string f_2 = "f''";
        public const string F_2 = "F''";
        public const string f_3 = "f'''";
        public const string F_3 = "F'''";
        public const string f0 = "f0";
        public const string F0 = "F0";
        public const string f1 = "f1";
        public const string F1 = "F1";
        public const string f2 = "f2";
        public const string F2 = "F2";
        public const string f3 = "f3";
        public const string F3 = "F3";

        public const string gis_0 = "g#";
        public const string GIS_0 = "G#";
        public const string gis_1 = "g#'";
        public const string GIS_1 = "G#'";
        public const string gis_2 = "g#''";
        public const string GIS_2 = "G#''";
        public const string gis_3 = "g#'''";
        public const string GIS_3 = "G#'''";
        public const string gis0 = "g#0";
        public const string GIS0 = "G#0";
        public const string gis1 = "g#1";
        public const string GIS1 = "G#1";
        public const string gis2 = "g#2";
        public const string GIS2 = "G#2";
        public const string gis3 = "g#3";
        public const string GIS3 = "G#3";

        public const string fis_0 = "f#";
        public const string FIS_0 = "F#";
        public const string fis_1 = "f#'";
        public const string FIS_1 = "F#'";
        public const string fis_2 = "f#''";
        public const string FIS_2 = "F#''";
        public const string fis_3 = "f#'''";
        public const string FIS_3 = "F#'''";
        public const string fis0 = "f#0";
        public const string FIS0 = "F#0";
        public const string fis1 = "f#1";
        public const string FIS1 = "F#1";
        public const string fis2 = "f#2";
        public const string FIS2 = "F#2";
        public const string fis3 = "f#3";
        public const string FIS3 = "F#3";

        public const string ais_0 = "a#";
        public const string AIS_0 = "A#";
        public const string ais_1 = "a#'";
        public const string AIS_1 = "A#'";
        public const string ais_2 = "a#''";
        public const string AIS_2 = "A#''";
        public const string ais_3 = "a#'''";
        public const string AIS_3 = "A#'''";
        public const string ais0 = "a#0";
        public const string AIS0 = "A#0";
        public const string ais1 = "a#1";
        public const string AIS1 = "A#1";
        public const string ais2 = "a#2";
        public const string AIS2 = "A#2";
        public const string ais3 = "a#3";
        public const string AIS3 = "A#3";

        public const string cis_0 = "c#";
        public const string CIS_0 = "C#";
        public const string cis_1 = "c#'";
        public const string CIS_1 = "C#'";
        public const string cis_2 = "c#''";
        public const string CIS_2 = "C#''";
        public const string cis_3 = "c#'''";
        public const string CIS_3 = "C#'''";
        public const string cis0 = "c#0";
        public const string CIS0 = "C#0";
        public const string cis1 = "c#1";
        public const string CIS1 = "C#1";
        public const string cis2 = "c#2";
        public const string CIS2 = "C#2";
        public const string cis3 = "c#3";
        public const string CIS3 = "C#3";

        public const string dis_0 = "d#";
        public const string DIS_0 = "D#";
        public const string dis_1 = "d#'";
        public const string DIS_1 = "D#'";
        public const string dis_2 = "d#''";
        public const string DIS_2 = "D#''";
        public const string dis_3 = "d#'''";
        public const string DIS_3 = "D#'''";
        public const string dis0 = "d#0";
        public const string DIS0 = "D#0";
        public const string dis1 = "d#1";
        public const string DIS1 = "D#1";
        public const string dis2 = "d#2";
        public const string DIS2 = "D#2";
        public const string dis3 = "d#3";
        public const string DIS3 = "D#3";

        public const string g_0 = "g";
        public const string G_0 = "G";
        public const string g_1 = "g'";
        public const string G_1 = "G'";
        public const string g_2 = "g''";
        public const string G_2 = "G''";
        public const string g_3 = "g'''";
        public const string G_3 = "G'''";
        public const string g0 = "g0";
        public const string G0 = "G0";
        public const string g1 = "g1";
        public const string G1 = "G1";
        public const string g2 = "g2";
        public const string G2 = "G2";
        public const string g3 = "g3";
        public const string G3 = "G3";

        public const string a_0 = "a";
        public const string A_0 = "A";
        public const string a_1 = "a'";
        public const string A_1 = "A'";
        public const string a_2 = "a''";
        public const string A_2 = "A''";
        public const string a_3 = "a'''";
        public const string A_3 = "A'''";
        public const string a0 = "a0";
        public const string A0 = "A0";
        public const string a1 = "a1";
        public const string A1 = "A1";
        public const string a2 = "a2";
        public const string A2 = "A2";
        public const string a3 = "a3";
        public const string A3 = "A3";

        public const string ab_0 = "ab";
        public const string AB_0 = "Ab";
        public const string ab_1 = "ab'";
        public const string AB_1 = "Ab'";
        public const string ab_2 = "ab''";
        public const string AB_2 = "Ab''";
        public const string ab_3 = "ab'''";
        public const string AB_3 = "Ab'''";
        public const string ab0 = "ab0";
        public const string AB0 = "Ab0";
        public const string ab1 = "ab1";
        public const string AB1 = "Ab1";
        public const string ab2 = "ab2";
        public const string AB2 = "Ab2";
        public const string ab3 = "ab3";
        public const string AB3 = "Ab3";

        public const string db_0 = "db";
        public const string DB_0 = "Db";
        public const string db_1 = "db'";
        public const string DB_1 = "Db'";
        public const string db_2 = "db''";
        public const string DB_2 = "Db''";
        public const string db_3 = "db'''";
        public const string DB_3 = "Db'''";
        public const string db0 = "db0";
        public const string DB0 = "Db0";
        public const string db1 = "db1";
        public const string DB1 = "Db1";
        public const string db2 = "db2";
        public const string DB2 = "Db2";
        public const string db3 = "db3";
        public const string DB3 = "Db3";

        public const string eb_0 = "eb";
        public const string EB_0 = "Eb";
        public const string eb_1 = "eb'";
        public const string EB_1 = "Eb'";
        public const string eb_2 = "eb''";
        public const string EB_2 = "Eb''";
        public const string eb_3 = "eb'''";
        public const string EB_3 = "Eb'''";
        public const string eb0 = "eb0";
        public const string EB0 = "Eb0";
        public const string eb1 = "eb1";
        public const string EB1 = "Eb1";
        public const string eb2 = "eb2";
        public const string EB2 = "Eb2";
        public const string eb3 = "eb3";
        public const string EB3 = "Eb3";

        public const string gb_0 = "gb";
        public const string GB_0 = "Gb";
        public const string gb_1 = "gb'";
        public const string GB_1 = "Gb'";
        public const string gb_2 = "gb''";
        public const string GB_2 = "Gb''";
        public const string gb_3 = "gb'''";
        public const string GB_3 = "Gb'''";
        public const string gb0 = "gb0";
        public const string GB0 = "Gb0";
        public const string gb1 = "gb1";
        public const string GB1 = "Gb1";
        public const string gb2 = "gb2";
        public const string GB2 = "Gb2";
        public const string gb3 = "gb3";
        public const string GB3 = "Gb3";

        public const string h_0 = "h";
        public const string H_0 = "H";
        public const string h_1 = "h'";
        public const string H_1 = "H'";
        public const string h_2 = "h''";
        public const string H_2 = "H''";
        public const string h_3 = "h'''";
        public const string H_3 = "H'''";
        public const string h0 = "h0";
        public const string H0 = "H0";
        public const string h1 = "h1";
        public const string H1 = "H1";
        public const string h2 = "h2";
        public const string H2 = "H2";
        public const string h3 = "h3";
        public const string H3 = "H3";

        public const string b_0 = "b";
        public const string B_0 = "B";
        public const string b_1 = "b'";
        public const string B_1 = "B'";
        public const string b_2 = "b''";
        public const string B_2 = "B''";
        public const string b_3 = "b'''";
        public const string B_3 = "B'''";
        public const string b0 = "b0";
        public const string B0 = "B0";
        public const string b1 = "b1";
        public const string B1 = "B1";
        public const string b2 = "b2";
        public const string B2 = "B2";
        public const string b3 = "b3";
        public const string B3 = "B3";

        public static double GetNoteLength(string noteatt, double unitlength)
        {
            int inxsplit = noteatt.IndexOf(Divider);
            double notelength = 0;
            if (inxsplit < 0)
            {
                notelength = StaticFunctionsClass.ToDoubleDef(noteatt, 0);
            }
            else if (inxsplit == 0)
            {
                notelength = 1.0 / StaticFunctionsClass.ToIntDef(noteatt.Substring(1), 1);
            }
            else
            {
                string ddstr = noteatt.Substring(0, inxsplit);
                string ddstr2 = noteatt.Substring(inxsplit + 1);
                double d1 = StaticFunctionsClass.ToDoubleDef(ddstr, 1);
                double d2 = StaticFunctionsClass.ToDoubleDef(ddstr2, 1);
                notelength = d1 / d2;
            }
            return notelength* unitlength;
        }
        
    }
    public class NotesImages
    {
        static private volatile NotesImages instance = null;
        static object _lock_this = new object();
        public Dictionary<double,Image> images = new Dictionary<double,Image>();
        static public NotesImages Instance()
        {
            lock (_lock_this)
            {
                if (instance == null)
                {
                    instance = new NotesImages();
                }
            }
            return instance;
        }
        private NotesImages()
        {
            images.Add(1,           Properties.Resources.ganze_note_black_24x);
            images.Add(2,           Properties.Resources.ganze_note_2_black_24x);
            images.Add(3,           Properties.Resources.ganze_note_3_black_24x);
            images.Add(4,           Properties.Resources.ganze_note_4_black_24x);
            images.Add(5,           Properties.Resources.ganze_note_5_black_24x);
            images.Add(6,           Properties.Resources.ganze_note_6_black_24x);
            images.Add(7,           Properties.Resources.ganze_note_7_black_24x);
            images.Add(8,           Properties.Resources.ganze_note_8_black_24x);
            images.Add(1.0/2.0,     Properties.Resources.halbe_note_black_24px);
            images.Add(1.0/4.0,     Properties.Resources.viertel_note_black_24px);
            images.Add(1.0/8.0,     Properties.Resources.achtel_note_black_24px);
            images.Add(1.0/16.0,    Properties.Resources.sechzehntel_note_black_24px);
            images.Add(1.0/32.0,    Properties.Resources.zweiundreisigstel_note_black_24px);
            images.Add(3.0/2.0,     Properties.Resources.dreihalbe_note_black_24px);
            images.Add(3.0/4.0,     Properties.Resources.dreiviertel_note_black_24px);
            images.Add(3.0/8.0,     Properties.Resources.dreiachtel_note_black_px24);
            images.Add(3.0/16.0,    Properties.Resources.drei_sechzehntel_note_black_24px);
        }
    }
}
