using System;

namespace HarpMeNow
{
    [Serializable]
    public class HarpSequenceFormDesign
    {
        public string SlotTxt;
    };

    [Serializable]
    public class HarpPlayFormDesign
    {
        public int cbHarpInstrumentINX;
        public int cbRefHarpInstrumentINX;
        public int cbHarpSoundINX;
        public int PlainTextsize;
        public int Volume;
        public int Velocity;        
    };

    [Serializable]
    public class HarpSlotsFormDesign
    {

       


    };   

    [Serializable]
    public class SongSequenceFormDesign
    {
        public string txtRowOffset;        
        public string txtFullNoteMS;
        public bool PlayedNoteAppendToText;
        public string SongNotationFile;

    };

    [Serializable]
    public class SoundAttributesFormDesign
    {
        public int cbHarpInstrumentINX;
        public int cbRefHarpInstrumentINX;
        public int cbHarpSoundINX;
        
        public int Volume;
        public int Velocity;

    };

    [Serializable]
    public class MainFormDesign
    {
        public int cbHarpInstrumentINX;
        public int cbRefHarpInstrumentINX;
        public int cbHarpSoundINX;
        public int PlainTextsize;
        public int Volume;
        public int Velocity;

    };
}
