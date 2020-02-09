using BasicClassLibrary;
using MidiOutApi.Api;
using System;
using System.Collections.Generic;
using System.Text;

namespace HarpMeNow
{
    public class Song
    {
        // ABC Definitions                
        public string _songTitle = string.Empty;
        public string _songTonality = string.Empty;

        /// <summary>
        /// M: Metrum
        /// Im Feld „M:“ (Metrum) steht die Taktart, z. B.: 
        /// M:6/8 
        /// M:4/4 oder
        /// M:3/4 oder
        /// M:2/2 oder
        /// M:C(entspricht M:4/4) oder
        /// M:C| (entspricht M:2/2). 
        /// Eine M:-Zeile kann auch zwischen Melodiezeilen stehen, um einen Taktwechsel anzuzeigen.
        /// </summary>
        
        public int _tunes = 1;

        //Extended Defnitions
        public string _songInstrument = string.Empty;
        //public string _songMajor = string.Empty;
       // public double _volumne = 5;
       // public double _velocity = 40;
        
        public string SongTitle
        {
            get
            {
                return string.IsNullOrEmpty(_songTitle) ? string.Empty : $@"{Statics.SongTitleKey}{_songTitle}";
            }
        }
        public string SongIntrument
        {
            get
            {
                return string.IsNullOrEmpty(_songInstrument) ? string.Empty : $@"{Statics.SongInstrumentKey}{_songInstrument}";
            }
        }

        public string Tonality
        {
            get
            {
                return string.IsNullOrEmpty(_songTonality) ? string.Empty : $@"{Statics.SongTonalityKey}{_songTonality}";
            }
        }
              
        /*
        public string Volume
        {
            get
            {
                return _volumne >= 0 ? $@"{Statics.SongVolumeKey}{_volumne}" : string.Empty;
            }
        }
        */
      
    }
    public class Notes
    {
        public string _notebez; //Bezeichnung der Note z.B. c''
        public string _note;    //Notennummer des Slots z.b. 7 107, -107 Minus gibt an
        public string _value;   //Länge der Note z.B. 1/8  /8  3
        public int _shifted = 0;
        public eNoteType _notetype = eNoteType.none;
        public Notes(string notebez, string note, string value)
        {
            _notebez = notebez;
            _note = note;
            _value = value;
            _shifted = 0;

        }
        public override string ToString()
        {
            return $@"{_notebez}->{_note} ({_value})";
        }
    }
    public class HarpInstrumentClass
    {

        public string[] Notes = null;
        public string Name = string.Empty;
        public int RowOffsetToStandard = -1;
        public Dictionary<AirSlotAttributesClass, InstrumentsNotesClass> InstrumentNotesDefinition = new Dictionary<AirSlotAttributesClass, InstrumentsNotesClass>();
        public eKey Key;
        public HarpInstrumentClass(string name, Dictionary<AirSlotAttributesClass, InstrumentsNotesClass> instrumentNotesDefinition, eKey key)
        {
            Name = name;
            Key = key;
            InstrumentNotesDefinition = instrumentNotesDefinition;
        }

        public string SearchNoteByHarpSlot(int slot)
        {
            string note = string.Empty;
            KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> instrument = new KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass>();
            foreach (KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> ins in InstrumentNotesDefinition)
            {
                if (slot < -100)
                {
                    if ((ins.Key.BreathDirection == eBreathDirection.drawPushed) && (ins.Key.Slot == Math.Abs(slot + 100)))
                    {
                        instrument = ins;
                        return ins.Value.Note;
                    }
                }
                else if (slot < 0)
                {
                    if ((ins.Key.BreathDirection == eBreathDirection.draw) && (ins.Key.Slot == Math.Abs(slot)))
                    {
                        instrument = ins;
                        return ins.Value.Note;
                    }
                }
                else if (slot > 100)
                {
                    if ((ins.Key.BreathDirection == eBreathDirection.blowPushed) && (ins.Key.Slot == (slot - 100)))
                    {
                        instrument = ins;
                        return ins.Value.Note;
                    }
                }
                else
                {
                    if ((ins.Key.BreathDirection == eBreathDirection.blow) && (ins.Key.Slot == slot))
                    {
                        instrument = ins;
                        return ins.Value.Note;
                    }
                }
            }
            return note;
        }

        public int SearchHarpSloyByNote(string note)
        {
            //Note zuerst im Blasmodus suchen
            KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> instrument = new KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass>();
            int slotFound = int.MinValue;
            foreach (KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> ins in InstrumentNotesDefinition)
            {
                if (ins.Value.Note == note)
                {
                    instrument = ins;
                    if(ins.Key.BreathDirection == eBreathDirection.blow) slotFound = ins.Key.Slot;
                    else if(ins.Key.BreathDirection == eBreathDirection.draw) slotFound = ins.Key.Slot * -1;
                    else if(ins.Key.BreathDirection == eBreathDirection.blowPushed) slotFound = ins.Key.Slot + 100;
                    else if(ins.Key.BreathDirection == eBreathDirection.drawPushed) slotFound =(ins.Key.Slot + 100) * -1;
                }
            }

           
            return slotFound;
        }

        public int SearchHarpSloyByNoteDrawPriority(string note)
        {
            //Note zuerst im Blasmodus suchen
            KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> instrument = new KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass>();
            foreach (KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> ins in InstrumentNotesDefinition)
            {
                if ((ins.Key.BreathDirection == eBreathDirection.blow) && (ins.Value.Note == note))
                {
                    instrument = ins;
                    return ins.Key.Slot;
                }
            }

            foreach (KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> ins in InstrumentNotesDefinition)
            {
                if ((ins.Key.BreathDirection == eBreathDirection.draw) && (ins.Value.Note == note))
                {
                    instrument = ins;
                    return ins.Key.Slot * -1;
                }
            }

            foreach (KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> ins in InstrumentNotesDefinition)
            {
                if ((ins.Key.BreathDirection == eBreathDirection.blowPushed) && (ins.Value.Note == note))
                {
                    instrument = ins;
                    return ins.Key.Slot + 100;
                }
            }

            foreach (KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> ins in InstrumentNotesDefinition)
            {
                if ((ins.Key.BreathDirection == eBreathDirection.drawPushed) && (ins.Value.Note == note))
                {
                    instrument = ins;
                    return (ins.Key.Slot + 100) * -1;
                }
            }

            return int.MinValue;
        }

        public int SearchHarpSloyByNoteNextToPrevious(string note, int previousSlot)
        {
            //Note zuerst im Blasmodus suchen
            KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> instrument = new KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass>();
            int slotFound = int.MinValue;
            foreach (KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> ins in InstrumentNotesDefinition)
            {
                if (ins.Value.Note == note)
                {
                    
                    instrument = ins;

                    if (ins.Key.BreathDirection == eBreathDirection.blow) slotFound = ins.Key.Slot;
                    else if (ins.Key.BreathDirection == eBreathDirection.draw) slotFound = ins.Key.Slot * -1;
                    else if (ins.Key.BreathDirection == eBreathDirection.blowPushed) slotFound = ins.Key.Slot + 100;
                    else if (ins.Key.BreathDirection == eBreathDirection.drawPushed) slotFound = (ins.Key.Slot + 100) * -1;
                }
            }
            Console.WriteLine($@"{previousSlot}->{slotFound}");
            return slotFound;
        }

        /*
        public int GetHarpSlotnDiff(AirSlotAttributesClass HarpSlot, HarpInstrumentClass refHarpInstrument)
        {
            int notediff = 0;
            if (this.Name != refHarpInstrument.Name)
            {
                //Referenzinstument ist diffeernt, es muß die R0wDiff errechnet werden

                KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> instrument = new KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass>();
                KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> instrumentRef = new KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass>();

                foreach (KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> ins in InstrumentNotesDefinition)
                {
                    if ((ins.Key.BreathDirection == HarpSlot.BreathDirection) && (ins.Key.Slot == HarpSlot.Slot))
                    {
                        instrument = ins;
                        break;
                    }
                }

                foreach (KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> ins in refHarpInstrument.InstrumentNotesDefinition)
                {
                    if ((ins.Key.BreathDirection == HarpSlot.BreathDirection) && (ins.Key.Slot == HarpSlot.Slot))
                    {
                        instrumentRef = ins;
                        break;
                    }
                }

                if (instrumentRef.Value != null && instrument.Value != null)
                {
                    notediff = instrument.Value.NoteDiff - instrumentRef.Value.NoteDiff;
                }
            }
            return notediff;
        }
        */
        /*
        public byte Play(AirSlotAttributesClass HarpSlot, SimpleApi sa, HarpInstrumentClass refHarpInstrument)
        {
            int notediff = GetHarpSlotnDiff(HarpSlot, refHarpInstrument);
            KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> instrument = new KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass>();

            foreach (KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> ins in InstrumentNotesDefinition)
            {
                if ((ins.Key.BreathDirection == HarpSlot.BreathDirection) && (ins.Key.Slot == HarpSlot.Slot - notediff))
                {
                    instrument = ins;
                    break;
                }
            }
            byte playByte = 0;

            if (instrument.Value != null)
            {

                playByte = instrument.Value.GetNoteByte();
                //sa.SetTranspose(transpose);
                sa.NoteOn(playByte);
            }
            return playByte;
        }
        */
        public byte Play(AirSlotAttributesClass HarpSlot, SimpleApi sa)
        {
            //int notediff = GetHarpSlotnDiff(HarpSlot, refHarpInstrument);
            KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> instrument = new KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass>();

            foreach (KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> ins in InstrumentNotesDefinition)
            {
                if ((ins.Key.BreathDirection == HarpSlot.BreathDirection) && (ins.Key.Slot == HarpSlot.Slot))
                {
                    instrument = ins;
                    break;
                }
            }
            byte playByte = 0;
            
            if (instrument.Value != null)
            {

                playByte = instrument.Value.GetNoteByte();
                //sa.SetTranspose(transpose);
                sa.NoteOn(playByte);
            }
            return playByte;
        }

        public void PlayOff(byte playByte, SimpleApi sa)
        {
            sa.NoteOff(playByte);
        }

        /*
        public void PlayOff(AirSlotAttributesClass HarpSlot, SimpleApi sa, HarpInstrumentClass refHarpInstrument)
        {
            int notediff = GetHarpSlotnDiff(HarpSlot, refHarpInstrument);
            KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> instrument = new KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass>();
            foreach (KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> ins in InstrumentNotesDefinition)
            {
                if ((ins.Key.BreathDirection == HarpSlot.BreathDirection) && (ins.Key.Slot == HarpSlot.Slot - notediff))
                {
                    instrument = ins;
                    break;
                }
            }

            if (instrument.Value != null)
            {
                //sa.SetTranspose(transpose);
                byte playByte = instrument.Value.GetNoteByte();

                sa.NoteOff(playByte);
            }
        }
        */
        public void PlayOff(AirSlotAttributesClass HarpSlot, SimpleApi sa)
        {
            
            KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> instrument = new KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass>();
            foreach (KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> ins in InstrumentNotesDefinition)
            {
                if ((ins.Key.BreathDirection == HarpSlot.BreathDirection) && (ins.Key.Slot == HarpSlot.Slot))
                {
                    instrument = ins;
                    break;
                }
            }

            if (instrument.Value != null)
            {
                //sa.SetTranspose(transpose);
                byte playByte = instrument.Value.GetNoteByte();

                sa.NoteOff(playByte);
            }
        }
        
        /// <summary>
        /// Erzeugt aus dem orginalen Songtext (Notation) eine List<Notes></Notes>
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="rowOffset"></param>
        /// <param name="translateType"></param>
        /// <returns></returns>
       

        List<string> notes = new List<string>();
        public void InitNotes()
        {
            notes.Add(Statics.C_0);
            notes.Add(Statics.D_0);
            notes.Add(Statics.E_0);
            notes.Add(Statics.F_0);
            notes.Add(Statics.G_0);
            notes.Add(Statics.A_0);
            notes.Add(Statics.H_0);
            notes.Add(Statics.c_0);
            notes.Add(Statics.d_0);
            notes.Add(Statics.e_0);
            notes.Add(Statics.f_0);
            notes.Add(Statics.g_0);
            notes.Add(Statics.a_0);
            notes.Add(Statics.h_0);
            notes.Add(Statics.c_1);
            notes.Add(Statics.d_1);
            notes.Add(Statics.e_1);
            notes.Add(Statics.f_1);
            notes.Add(Statics.g_1);
            notes.Add(Statics.a_1);
            notes.Add(Statics.h_1);

        }       
        public bool IsNote(string note)
        {
            string nt = notes.Find(X => X == note);
            if (nt == null)
            {
                return false;
            }
            return true;
        }
        public bool IsCommand(string cmd)
        {
            string cmdStr = cmd.Trim().ToUpper();
            if (cmdStr.StartsWith("X:")
                || cmdStr.StartsWith("L:")
                || cmdStr.StartsWith("K:")
                || cmdStr.StartsWith("T:")
                || cmdStr.StartsWith("M:")
                || cmdStr.StartsWith("Q:")
                || cmdStr.StartsWith("Z:")
                || cmdStr.StartsWith("C:"))
            {
                return true;
            }
            return false;
        }
        public bool IsComment(string cmd)
        {
            string cmdStr = cmd.Trim().ToUpper();
            if (cmdStr.StartsWith("% ") || cmdStr.StartsWith("%%"))
            {
                return true;
            }
            return false;
        }

        /// <summary>        
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="rowOffset"></param>
        /// <example>
        /// X: 1 
        /// L: 1/4 
        /// K: 
        /// C C16|C8|C4|D2 D2|E0 E E E E|FF F/ F/ F/ F/| G3 G// G/4 G/8 G/8 G/16 G/16 G/16 G/16| 
        /// </example>
        /// <returns></returns>
        public string TranslateABC(string[] lines, int rowOffset)
        {
            InitNotes();
            StringBuilder noteList = new StringBuilder();
            foreach (string line in lines)
            {
                if (IsCommand(line)) continue;
                if (IsComment(line)) continue;

                //Aufteilung in Takte
                string[] takte = line.Replace("\r", "").Replace("\n", "").Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string note in takte)
                {
                    bool noteReady = false;
                    string nt = string.Empty;
                    for (int i = 0; i < note.Length; i++)
                    {
                        // FF F/ F/ F/ F/
                        char[] ntc = { note[i] };
                        if (ntc[0] == ' ')
                        {
                            noteReady = true;
                        }
                        else
                        {
                            string ni = new string(ntc);
                            nt += ni;
                        }

                        if (noteReady)
                        {
                            if (IsNote(nt))
                            {
                                noteList.Append(nt);
                            }
                            noteReady = false;
                            nt = string.Empty;
                        }
                    }
                }
            }
            return noteList.ToString();
        }

        public string TranslateBack(string[] cmd, int rowOffset)
        {
            var sb = new StringBuilder();
            foreach (string cmdStr in cmd)
            {
                if (cmdStr.Trim().StartsWith("\"")) continue;
                sb.Append(cmdStr);
            }
            string cmd2 = sb.ToString().Replace("\n", "").Replace("\r", "");


            string[] notes = cmd2.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            var notesList = new StringBuilder();
            foreach (string note in notes)
            {
                if (note.Trim().StartsWith("\"")) continue;

                if ((note.Trim().ToUpper().StartsWith(Statics.SongVolumeKey)) || (note.Trim().ToUpper().StartsWith(Statics.SongTempoKey)))
                {
                    string[] vstr = note.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    if (vstr.Length > 1)
                    {
                        notesList.Append($@"{vstr[0].Trim()}={vstr[1].Trim()} ");
                    }
                    continue;
                }

                if (note.Trim() == Statics.TaktKey)
                {
                    notesList.Append($@"{Statics.TaktKey} ");
                    continue;
                }
                if (note.Trim().ToUpper().StartsWith(Statics.PauseKey))
                {
                    string[] vstr = note.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    if (vstr.Length > 1)
                    {
                        notesList.Append($@"{vstr[0].Trim().ToUpper()}{vstr[1].Trim()} ");
                    }
                    else
                    {
                        notesList.Append($@"{vstr[0].Trim().ToUpper()} ");
                    }
                    continue;
                }
                string[] nt = note.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                string noteStr = nt[0].Trim();
                bool punkt = noteStr.EndsWith(Statics.DotUpKey);
                if (punkt) noteStr = noteStr.Remove(noteStr.Length - 1, 1);

                int harpSlot = StaticFunctionsClass.ToIntDef(noteStr, 0);
                string instrumentNoteStr = SearchNoteByHarpSlot(harpSlot);

                if (nt.Length > 1)
                {
                    //Es gibt note und delay
                    string nstr = punkt ? $@"{instrumentNoteStr}>" : $@"{instrumentNoteStr}";
                    string lenstr = nt[1].Trim();
                    notesList.Append($@"{nstr}{lenstr} ");
                }
                else
                {
                    //es gibt nur note
                    string nstr = punkt ? $@"{instrumentNoteStr}> " : $@"{instrumentNoteStr} ";
                    notesList.Append(nstr);
                }

            }
            return notesList.ToString();
        }
    }
}
