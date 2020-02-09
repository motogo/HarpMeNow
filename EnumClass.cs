using Enums;

namespace HarpMeNow
{
    /*
    public enum eHarpInstruments 
    {
        [EnumDescription("SeydelDeLuxeSteelOrchestra Model (C),")]
        SeydelDeLuxeSteelOrchestra_CDUR,
        [EnumDescription("Hohner unsere Lieblinge (C),")]
        HohnerUnsereLieblinge, 
        ChroamticStandard 
    };
    */
    public enum eBreathDirection { blow = 0, draw = 1, blowPushed = 2, drawPushed = 3 };
    public enum eTranslateType {NoOrder, BlowDrawPushOrder, NoOrderNearPrevieous, BlowDrawPushOrderNearPrevious }
    public enum eNoteType {none=0,note=1,takt = 2, pause = 3, command = 4, comment = 5, failnote = 6};
    public enum eKey 
    {
        [EnumDescription("Ces")]
        Ces_DUR=0,
        [EnumDescription("Ges")]
        Ges_DUR=1,
        [EnumDescription("Des")]
        Des_DUR=2,
        [EnumDescription("As")]
        As_DUR=3,
        [EnumDescription("Es")]
        Es_DUR=4,
        [EnumDescription("B")]
        B_DUR=5,        
        [EnumDescription("C")]
        C_DUR=6,
        [EnumDescription("Cis")]
        Cis_DUR = 7,
        [EnumDescription("D")]
        D_DUR = 8,
        [EnumDescription("Gis")]
        Gis_DUR = 9,
        [EnumDescription("E")]
        E_DUR = 10,
        [EnumDescription("F")]
        F_DUR = 11,
        [EnumDescription("G")]
        G_DUR=12,        
        [EnumDescription("A")]
        A_DUR=13,        
        [EnumDescription("H")]
        H_DUR=14,
        [EnumDescription("Fis")]
        Fis_DUR=15,
        
    };
    class EnumClass
    {
    }
}
