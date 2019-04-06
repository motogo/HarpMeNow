using BasicClassLibrary;
using MidiOutApi.Api;
using SeControlsLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

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
                
                case "C0" : 
                case "c0" :
                case "C" :
                case "c" :
                    return 48; 

                case "C#0" : 
                case "c#0" :
                case "C#" :
                case "c#" :
                case "Db0" : 
                case "db0" : 
                case "Db" : 
                case "db" :
                    return 49; 

                case "D0" : 
                case "d0" : 
                case "D" : 
                case "d" : 
                    return 50; 

                case "D#0" : 
                case "d#0" : 
                case "D#" : 
                case "d#" : 
                case "Eb0" : 
                case "eb0" : 
                case "Eb" : 
                case "eb" :
                    return 51; 

                case "E0" : 
                case "e0" : 
                case "E" : 
                case "e" : 
                    return 52; 
                
                case "F0" : 
                case "f0" : 
                case "F" : 
                case "f" : 
                    return 53; 

                case "F#0" : 
                case "f#0" : 
                case "F#" : 
                case "f#" :
                case "Gb0" : 
                case "gb0" : 
                case "Gb" : 
                case "gb" :
                    return 54; 

                case "G0" : 
                case "g0" : 
                case "G" : 
                case "g" : 
                    return 55; 

                case "G#0" : 
                case "g#0" : 
                case "G#" : 
                case "g#" :
                case "Ab0" : 
                case "ab0" : 
                case "Ab" : 
                case "ab" :
                    return 56; 

                case "A0" : 
                case "a0" : 
                case "A" : 
                case "a" : 
                    return 57;

                case "A#0" : 
                case "a#0" : 
                case "A#" : 
                case "a#" :                 
                case "B0" : 
                case "b0" :                 
                case "B" : 
                case "b" :
                    return 58; 

                case "H0" : 
                case "h0" : 
                case "H" : 
                case "h" : 
                    return 59;

                case "C1" : 
                case "c1" :
                case "C'" :
                case "c'" :
                    return 60; 

                case "C#1" : 
                case "c#1" :
                case "C#'" :
                case "c#'" :
                case "Db1" : 
                case "db1" : 
                case "Db'" : 
                case "db'" :
                    return 61; 

                case "D1" : 
                case "d1" : 
                case "D'" : 
                case "d'" : 
                    return 62; 

                case "D#1" : 
                case "d#1" : 
                case "D#'" : 
                case "d#'" : 
                case "Eb1" : 
                case "eb1" : 
                case "Eb'" : 
                case "eb'" :
                    return 63; 

                case "E1" : 
                case "e1" : 
                case "E'" : 
                case "e'" : 
                    return 64; 
                
                case "F1" : 
                case "f1" : 
                case "F'" : 
                case "f'" : 
                    return 65; 

                case "F#1" : 
                case "f#1" : 
                case "F#'" : 
                case "f#'" :
                case "Gb1" : 
                case "gb1" : 
                case "Gb'" : 
                case "gb'" :
                    return 66; 

                case "G1" : 
                case "g1" : 
                case "G'" : 
                case "g'" : 
                    return 67; 

                case "G#1" : 
                case "g#1" : 
                case "G#'" : 
                case "g#'" :
                case "Ab1" : 
                case "ab1" : 
                case "Ab'" : 
                case "ab'" :
                    return 68; 

                case "A1" : 
                case "a1" : 
                case "A'" : 
                case "a'" : 
                    return 69;

                case "A#1" : 
                case "a#1" : 
                case "A#'" : 
                case "a#'" :                 
                case "B1" : 
                case "b1" : 
                case "B'" : 
                case "b'" :                 
                    return 70; 

                case "H1" : 
                case "h1" : 
                case "H'" : 
                case "h'" : 
                    return 71;



                case "C2" : 
                case "c2" :
                case "C''" :
                case "c''" :
                    return 72; 

                case "C#2" : 
                case "c#2" :
                case "C#''" :
                case "c#''" :
                case "Db2" : 
                case "db2" : 
                case "Db''" : 
                case "db''" :
                    return 73; 

                case "D2" : 
                case "d2" : 
                case "D''" : 
                case "d''" : 
                    return 74; 

                case "D#2" : 
                case "d#2" : 
                case "D#''" : 
                case "d#''" : 
                case "Eb2" : 
                case "eb2" : 
                case "Eb''" : 
                case "eb''" :
                    return 75; 

                case "E2" : 
                case "e2" : 
                case "E''" : 
                case "e''" : 
                    return 76; 
                
                case "F2" : 
                case "f2" : 
                case "F''" : 
                case "f''" : 
                    return 77; 

                case "F#2" : 
                case "f#2" : 
                case "F#''" : 
                case "f#''" :
                case "Gb2" : 
                case "gb2" : 
                case "Gb''" : 
                case "gb''" :
                    return 78; 

                case "G2" : 
                case "g2" : 
                case "G''" : 
                case "g''" : 
                    return 79; 

                case "G#2" : 
                case "g#2" : 
                case "G#''" : 
                case "g#''" :
                case "Ab2" : 
                case "ab2" : 
                case "Ab''" : 
                case "ab''" :
                    return 80; 

                case "A2" : 
                case "a2" : 
                case "A''" : 
                case "a''" : 
                    return 81;

                case "A#2" : 
                case "a#2" : 
                case "A#''" : 
                case "a#''" :                 
                case "B2" : 
                case "b2" : 
                case "B''" : 
                case "b''" :                 
                    return 82; 

                case "H2" : 
                case "h2" : 
                case "H''" : 
                case "h''" : 
                    return 83;


                    case "C3" : 
                case "c3" :
                case "C'''" :
                case "c'''" :
                    return 84; 

                case "C#3" : 
                case "c#3" :
                case "C#'''" :
                case "c#'''" :
                case "Db3" : 
                case "db3" : 
                case "Db'''" : 
                case "db'''" :
                    return 85; 

                case "D3" : 
                case "d3" : 
                case "D'''" : 
                case "d'''" : 
                    return 86; 

                case "D#3" : 
                case "d#3" : 
                case "D#'''" : 
                case "d#'''" : 
                case "Eb3" : 
                case "eb3" : 
                case "Eb'''" : 
                case "eb'''" :
                    return 87; 

                case "E3" : 
                case "e3" : 
                case "E'''" : 
                case "e'''" : 
                    return 88; 
                
                case "F3" : 
                case "f3" : 
                case "F'''" : 
                case "f'''" : 
                    return 89; 

                case "F#3" : 
                case "f#3" : 
                case "F#'''" : 
                case "f#'''" :
                case "Gb3" : 
                case "gb3" : 
                case "Gb'''" : 
                case "gb'''" :
                    return 90; 

                case "G3" : 
                case "g3" : 
                case "G'''" : 
                case "g'''" : 
                    return 91; 

                case "G#3" : 
                case "g#3" : 
                case "G#'''" : 
                case "g#'''" :
                case "Ab3" : 
                case "ab3" : 
                case "Ab'''" : 
                case "ab'''" :
                    return 92; 

                case "A3" : 
                case "a3" : 
                case "A'''" : 
                case "a'''" : 
                    return 93;

                case "A#3" : 
                case "a#3" : 
                case "A#'''" : 
                case "a#'''" :                
                case "B3" : 
                case "b3" :                 
                case "B'''" : 
                case "b'''" :                 
                    return 94; 

                case "H3" : 
                case "h3" : 
                case "H'''" : 
                case "h'''" : 
                    return 95;

            };
            return 0;
        }

    }

    public class NoteButton : Button
    {
        public Color ColorPushed = Color.Green;
        public Color ColorReleased = Color.LightGray;
        public NoteButton()
        {
            
        }
    }


    public class AirSlotClass
    {
        public NoteButton slot;
        public Button slotUpper;
        public Button slotLeft;
        public NoteClass note;
        SimpleApi sa=null; 
        Color blowColor = Color.Green;
        Color drawColor = Color.Red;

        public KeyValuePair<HarpSlotClass,InstrumentsNotesClass> SlotDefinition
        {
            get
            {
                return (KeyValuePair<HarpSlotClass,InstrumentsNotesClass>) slot.Tag;
            }
        }
        public AirSlotClass(Control parent,KeyValuePair<HarpSlotClass,InstrumentsNotesClass> ins,SimpleApi simpleApi)
        {
            slotUpper = new Button(); // SeControlsLib.HotSpot();
            slotUpper.Left = (ins.Value.HarpSlot*50)+8;
            slotUpper.Top = 16;
            slotUpper.Width = 48;
            slotUpper.Height = 24;
            slotUpper.Parent = parent;
            slotUpper.BackColor = Color.Bisque;           
            slotUpper.TextAlign = ContentAlignment.MiddleCenter;
            slotUpper.Text = (ins.Value.HarpSlot).ToString();
            
            slot = new NoteButton(); // SeControlsLib.HotSpot();
            slot.Left = (ins.Value.HarpSlot*50)+8;

            if(ins.Value.HarpSlot==1)
            {
                 slotLeft = new Button();
                 slotLeft.Parent = parent;
                 slotLeft.BackColor = Color.Bisque;
                 
                 slotLeft.Left = 8;
                 slotLeft.Height = 24;
                 slotLeft.Width = 48;
            }


            if(ins.Key.BreathDirection == eBreathDirection.blow) 
            {
               if(ins.Value.HarpSlot==1)
               {                    
                    slotLeft.Text = "blow";
                    slotLeft.Top = 28+slotUpper.Height;
               }
               slot.Top = 16+slotUpper.Height;
               slot.MouseDown += Slot_MouseDownBlow;
               slot.ColorPushed = blowColor;
            }
            else if(ins.Key.BreathDirection == eBreathDirection.draw)
            {
               if(ins.Value.HarpSlot==1)
               {                
                    slotLeft.Text = "draw";
                    slotLeft.Top = 48+28+slotUpper.Height;
               }
               slot.Top = 48+16+slotUpper.Height;
               slot.MouseDown += Slot_MouseDownDraw;
               slot.ColorPushed = drawColor;
            }
            else if(ins.Key.BreathDirection == eBreathDirection.blowPushed)
            {
               if(ins.Value.HarpSlot==1)
               {                
                    slotLeft.Text = "blow-p";
                    slotLeft.Top = 2*48+28+slotUpper.Height;
               }
               slot.Top = 2*48+16+slotUpper.Height;
               slot.MouseDown += Slot_MouseDownBlow;
               slot.ColorPushed = blowColor;
            }
            else if(ins.Key.BreathDirection == eBreathDirection.drawPushed)
            {
               if(ins.Value.HarpSlot==1)
               {                
                    slotLeft.Text = "draw-p";
                    slotLeft.Top = 3*48+28+slotUpper.Height;
               }
               slot.Top = 3*48+16+slotUpper.Height;
               slot.MouseDown += Slot_MouseDownDraw;
               slot.ColorPushed = drawColor;
            }
            slot.Width = 48;
            slot.Height = 48;
            slot.Parent = parent;
            slot.BackColor = Color.LightGray;           
            slot.TextAlign = ContentAlignment.MiddleCenter;
            

            

            
            slot.Tag = ins;

            slot.Text = $@"{ins.Value.Note}";
            sa = simpleApi;           
          
            slot.MouseUp += Slot_MouseUp;
            
            
        }


        public AirSlotClass(Control parent,int i,HarpInstrumentClass harp,  string noteNameBlow, string noteNameDraw, SimpleApi simpleApi)
        {
            slotUpper = new Button(); // SeControlsLib.HotSpot();
            slotUpper.Left = (i*50)+8;
            slotUpper.Top = 16;
            slotUpper.Width = 48;
            slotUpper.Height = 24;
            slotUpper.Parent = parent;
            slotUpper.BackColor = Color.LightGray;           
            slotUpper.TextAlign = ContentAlignment.MiddleCenter;
            slotUpper.Text = (i+1).ToString();

            slot = new NoteButton(); // SeControlsLib.HotSpot();
            slot.Left = (i*50)+8;
            slot.Top = 16+slotUpper.Height;
            slot.Width = 48;
            slot.Height = 48;
            slot.Parent = parent;
            slot.BackColor = Color.LightGray;           
            slot.TextAlign = ContentAlignment.MiddleCenter;


            

            note = new NoteClass();
            note.NoteBlow = noteNameBlow;
            note.NoteDraw = noteNameDraw;
            note.NoteKeyBlow = NotesStaticClass.GetNote(noteNameBlow);
            note.NoteKeyDraw = NotesStaticClass.GetNote(noteNameDraw);
            
            slot.Tag = note;
            slot.Tag = harp.InstrumentNotesDefinition;

            slot.Text = $@"{note.NoteBlow}{Environment.NewLine}{note.NoteDraw}";
            sa = simpleApi;           
          
            slot.MouseUp += Slot_MouseUp;
            slot.MouseDown += Slot_MouseDownBlow;
            
        }

        private void Slot_MouseDownBlow(object sender, MouseEventArgs e)
        {
            var hs = (Button) sender;
            var nc = (KeyValuePair<HarpSlotClass,InstrumentsNotesClass>) hs.Tag;
            Application.DoEvents();            
            hs.BackColor = Color.Green;                             
            sa.NoteOn(nc.Value.GetNoteByte(),65,0);                        
            Application.DoEvents();
            Thread.Sleep(100);
        }
        private void Slot_MouseDownDraw(object sender, MouseEventArgs e)
        {
            var hs = (Button) sender;
            var nc = (KeyValuePair<HarpSlotClass,InstrumentsNotesClass>) hs.Tag;
            Application.DoEvents();
            
            hs.BackColor = Color.Red;                             
            sa.NoteOn(nc.Value.GetNoteByte(),65,0);
            
            Application.DoEvents();
            Thread.Sleep(100);
        }

        private void Slot_MouseUp(object sender, MouseEventArgs e)
        {
            var hs = (Button) sender;
            hs.BackColor = Color.LightGray;
            var nc = (KeyValuePair<HarpSlotClass,InstrumentsNotesClass>) hs.Tag;
            if(e.Button == MouseButtons.Left)
            {
                sa.NoteOff(nc.Value.GetNoteByte());
            }
            else
            {
                sa.NoteOff(nc.Value.GetNoteByte());
            }
        }

        private void Slot_Click(object sender, EventArgs e)
        {           
        }
    }



    public class HarpInstrumentClass
    {
        public string[] Notes = null;
        public string Name = string.Empty;
        public int RowOffsetToStandard = -1;
        public Dictionary<HarpSlotClass,InstrumentsNotesClass> InstrumentNotesDefinition=new Dictionary<HarpSlotClass, InstrumentsNotesClass>();
                                
        public HarpInstrumentClass(string name, Dictionary<HarpSlotClass,InstrumentsNotesClass> instrumentNotesDefinition)
        {
           
            Name = name;
            InstrumentNotesDefinition = instrumentNotesDefinition;
        }

        public string SearchNoteByHarpSlot(int slot)
        {
            string note = string.Empty;
            KeyValuePair<HarpSlotClass,InstrumentsNotesClass> instrument = new KeyValuePair<HarpSlotClass, InstrumentsNotesClass>();
            foreach(KeyValuePair<HarpSlotClass,InstrumentsNotesClass> ins in InstrumentNotesDefinition)
            {
                if(slot < -100)
                {
                    if((ins.Key.BreathDirection == eBreathDirection.drawPushed)&&(ins.Key.HarpSlot == Math.Abs(slot+100)))
                    {
                        instrument = ins;                                     
                        return ins.Value.Note;
                    }
                }
                else if (slot < 0)
                {
                    if((ins.Key.BreathDirection == eBreathDirection.draw)&&(ins.Key.HarpSlot == Math.Abs(slot)))
                    {
                        instrument = ins;                                     
                        return ins.Value.Note;
                    }
                }
                else if (slot > 100)
                {
                    if((ins.Key.BreathDirection == eBreathDirection.blowPushed)&&(ins.Key.HarpSlot == (slot-100)))
                    {
                        instrument = ins;                                     
                        return ins.Value.Note;
                    }
                }
                else
                {                
                    if((ins.Key.BreathDirection == eBreathDirection.blow)&&(ins.Key.HarpSlot == slot))
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
            KeyValuePair<HarpSlotClass,InstrumentsNotesClass> instrument = new KeyValuePair<HarpSlotClass, InstrumentsNotesClass>();
            foreach(KeyValuePair<HarpSlotClass,InstrumentsNotesClass> ins in InstrumentNotesDefinition)
            {
                if((ins.Key.BreathDirection == eBreathDirection.blow)&&(ins.Value.Note == note))
                {
                    instrument = ins;
                    return ins.Key.HarpSlot;                    
                }
            }

            foreach(KeyValuePair<HarpSlotClass,InstrumentsNotesClass> ins in InstrumentNotesDefinition)
            {
                if((ins.Key.BreathDirection == eBreathDirection.draw)&&(ins.Value.Note == note))
                {
                    instrument = ins;
                    return ins.Key.HarpSlot*-1;                    
                }
            }

            foreach(KeyValuePair<HarpSlotClass,InstrumentsNotesClass> ins in InstrumentNotesDefinition)
            {
                if((ins.Key.BreathDirection == eBreathDirection.blowPushed)&&(ins.Value.Note == note))
                {
                    instrument = ins;
                    return ins.Key.HarpSlot+100;                    
                }
            }

            foreach(KeyValuePair<HarpSlotClass,InstrumentsNotesClass> ins in InstrumentNotesDefinition)
            {
                if((ins.Key.BreathDirection == eBreathDirection.drawPushed)&&(ins.Value.Note == note))
                {
                    instrument = ins;
                    return (ins.Key.HarpSlot+100)*-1;                    
                }
            }

            return 0;
        }


        public int GetHarpSlotnDiff(HarpSlotClass HarpSlot, HarpInstrumentClass refHarpInstrument)
        {
            
            

            int notediff = 0;
            if(this.Name != refHarpInstrument.Name)
            {
                //Referenzinstument ist diffeernt, es muß die R0wDiff errechnet werden

                KeyValuePair<HarpSlotClass,InstrumentsNotesClass> instrument = new KeyValuePair<HarpSlotClass, InstrumentsNotesClass>();
                KeyValuePair<HarpSlotClass,InstrumentsNotesClass> instrumentRef = new KeyValuePair<HarpSlotClass, InstrumentsNotesClass>();

                foreach(KeyValuePair<HarpSlotClass,InstrumentsNotesClass> ins in InstrumentNotesDefinition)
                {
                    if((ins.Key.BreathDirection == HarpSlot.BreathDirection)&&(ins.Key.HarpSlot == HarpSlot.HarpSlot))
                    {
                        instrument = ins;
                        break;
                    }
                }

                foreach(KeyValuePair<HarpSlotClass,InstrumentsNotesClass> ins in refHarpInstrument.InstrumentNotesDefinition)
                {
                    if((ins.Key.BreathDirection == HarpSlot.BreathDirection)&&(ins.Key.HarpSlot == HarpSlot.HarpSlot))
                    {
                        instrumentRef = ins;
                        break;
                    }
                }

                if(instrumentRef.Value != null && instrument.Value != null)
                {
                    notediff = instrument.Value.NoteDiff - instrumentRef.Value.NoteDiff;                    
                }
            }
            return notediff;
        }

        public byte Play(HarpSlotClass HarpSlot, SimpleApi sa, HarpInstrumentClass refHarpInstrument)
        {
            int notediff = GetHarpSlotnDiff(HarpSlot,refHarpInstrument);
            KeyValuePair<HarpSlotClass,InstrumentsNotesClass> instrument = new KeyValuePair<HarpSlotClass, InstrumentsNotesClass>();
            
            foreach(KeyValuePair<HarpSlotClass,InstrumentsNotesClass> ins in InstrumentNotesDefinition)
            {
                if((ins.Key.BreathDirection == HarpSlot.BreathDirection)&&(ins.Key.HarpSlot == HarpSlot.HarpSlot-notediff))
                {
                    instrument = ins;
                    break;
                }
            }
            byte playByte = 0;
            if(instrument.Value != null)
            {         
                
                 playByte =  instrument.Value.GetNoteByte();
                 
                 sa.NoteOn(playByte);                
            }
            return playByte;
        }

        
        public void PlayOff(byte playByte, SimpleApi sa)
        {                       
            sa.NoteOff(playByte);                            
        }

        public void PlayOff(HarpSlotClass HarpSlot, SimpleApi sa, HarpInstrumentClass refHarpInstrument)
        {
            int notediff = GetHarpSlotnDiff(HarpSlot,refHarpInstrument);            
            KeyValuePair<HarpSlotClass,InstrumentsNotesClass> instrument = new KeyValuePair<HarpSlotClass, InstrumentsNotesClass>();
            foreach(KeyValuePair<HarpSlotClass,InstrumentsNotesClass> ins in InstrumentNotesDefinition)
            {
                if((ins.Key.BreathDirection == HarpSlot.BreathDirection)&&(ins.Key.HarpSlot == HarpSlot.HarpSlot-notediff))
                {                    
                    instrument = ins;
                    break;
                }
            }
                        
            if(instrument.Value != null)
            {                 
                 byte playByte = instrument.Value.GetNoteByte();
                 
                 sa.NoteOff(playByte);                
            }
        }

        public string Translate(string[] cmd, int rowOffset)
        {     
            InitNotes();            
            StringBuilder noteList = new StringBuilder();
            foreach(string notesStr in cmd)
            {
                string notes = notesStr.Replace("  "," ");            
                if(notes.Trim().StartsWith(HarpClass.CommentKey))
                {                
                    noteList.AppendLine(notes.Trim());                                                 
                    continue;
                }
            
                string nt = string.Empty;                          
                string[] nts = notes.Split(HarpClass.SongNotesDivider.ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                foreach(string ntc in nts)
                {                      
                    if( ntc.Trim().ToUpper().StartsWith(HarpClass.VelocityKey) || ntc.Trim().ToUpper().StartsWith(HarpClass.VolumeKey)) 
                    {
                        string[] att = ntc.Split(HarpClass.SongEqualKey.ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                        noteList.Append($@"{att[0].Trim()}{HarpClass.HarpAttributeDivider}{att[1].Trim()}{HarpClass.HarpNotesDivider}");                        
                        continue;
                    }

                    if(ntc.Trim() == HarpClass.TaktKey)
                    {
                        noteList.Append($@" {HarpClass.TaktKey} {HarpClass.HarpNotesDivider}");                        
                        continue;
                    }
                               
                    // c  c''  c''/8
                    string nready = string.Empty;
                    bool diff = false;
                    bool punkt = false;
                    int zahl = -1;
                    for(int ix = 0; ix < ntc.Length; ix++)
                    {
                        string nstr = ntc.Substring(ix,1);
                        if(nstr == HarpClass.Divider)
                        {
                            //operator nach note
                            diff  = true;
                        }
                        else if(nstr == HarpClass.Dot)
                        {
                            //operator nach note
                            punkt  = true;
                        }
                        else if(StaticFunctionsClass.ToIntDef(nstr,-1) > 0)
                        {
                                //Zahl nach note
                            zahl = StaticFunctionsClass.ToIntDef(nstr,-1);
                        }
                        else
                        {
                            //gehört zu note
                            nready+= nstr;
                        }
                    }
                
                    string inxStr = string.Empty;
                    if(nready.Trim().ToUpper() == HarpClass.PauseKey)
                    {
                        inxStr = HarpClass.PauseKey;
                    }
                
                    else
                    {
                      int inx = SearchHarpSloyByNote(nready);
                      inxStr = inx.ToString();
                    }
                    string newcmd = string.Empty;
                    if(zahl > -1)
                    {
                        if(punkt)
                        {
                            newcmd = (diff) ? $@"{inxStr}{HarpClass.Dot}{HarpClass.HarpAttributeDivider}{HarpClass.Divider}{zahl}{HarpClass.HarpNotesDivider}" : $@"{inxStr}{HarpClass.Dot}{HarpClass.HarpAttributeDivider}{zahl}{HarpClass.HarpNotesDivider}";
                        }
                        else
                        {
                            newcmd = (diff) ? $@"{inxStr}{HarpClass.HarpAttributeDivider}{HarpClass.Divider}{zahl}{HarpClass.HarpNotesDivider}" : $@"{inxStr}{HarpClass.HarpAttributeDivider}{zahl}{HarpClass.HarpNotesDivider}";
                        }
                    }
                    else
                    {
                        if(punkt)
                        {
                            newcmd = $@"{inxStr}{HarpClass.Dot}{HarpClass.HarpNotesDivider}";
                        }
                        else
                        {
                            newcmd = $@"{inxStr}{HarpClass.HarpNotesDivider}";
                        }
                    }
                    noteList.Append(newcmd);                                                      
                }
                noteList.AppendLine("");
            }
            return noteList.ToString();
        }
        
        List<string> notes = new List<string>();

        public void InitNotes()
        {
            notes.Add("C");
            notes.Add("D");
            notes.Add("E");
            notes.Add("F");
            notes.Add("G");
            notes.Add("A");
            notes.Add("H");
            notes.Add("c");
            notes.Add("d");
            notes.Add("e");
            notes.Add("f");
            notes.Add("g");
            notes.Add("a");
            notes.Add("h");
            notes.Add("c'");
            notes.Add("d'");
            notes.Add("e'");
            notes.Add("f'");
            notes.Add("g'");
            notes.Add("a'");
            notes.Add("h'");

        }

        public bool IsNote(string note)
        {
            string nt = notes.Find(X=>X == note);
            if(nt == null)
            {
                return false;
            }
            return true;
        }

        public bool IsCommand(string cmd)
        {
            string cmdStr = cmd.Trim().ToUpper();
            if(cmdStr.StartsWith("X:")
                ||cmdStr.StartsWith("L:")
                ||cmdStr.StartsWith("K:")
                ||cmdStr.StartsWith("T:")
                ||cmdStr.StartsWith("M:")
                ||cmdStr.StartsWith("Q:")
                ||cmdStr.StartsWith("Z:")
                ||cmdStr.StartsWith("C:"))
            {
                return true;
            }
            return false;
        }
        public bool IsComment(string cmd)
        {
            string cmdStr = cmd.Trim().ToUpper();
            if(cmdStr.StartsWith("% ")||cmdStr.StartsWith("%%"))
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
            foreach(string line in lines)
            {
                if(IsCommand(line)) continue;
                if(IsComment(line)) continue;
            
                //Aufteilung in Takte
                string[] takte = line.Replace("\r","").Replace("\n","").Split(new char[]{'|' },StringSplitOptions.RemoveEmptyEntries);
                
                foreach(string note in takte)
                {           
                    bool noteReady = false;
                    string nt = string.Empty;
                    for(int i = 0; i < note.Length; i++)
                    {
                        // FF F/ F/ F/ F/
                        char[] ntc = {note[i] };
                        if(ntc[0] == ' ')
                        {
                            noteReady = true;
                        }
                        else
                        {
                            string ni = new string(ntc);
                            nt+=ni;
                        }

                        if(noteReady)
                        {
                            if(IsNote(nt))
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
            StringBuilder sb = new StringBuilder();
            foreach(string cmdStr in cmd)
            {
                if(cmdStr.Trim().StartsWith("\"")) continue;
                sb.Append(cmdStr);
            }
            string cmd2 = sb.ToString().Replace("\n","").Replace("\r","");

            
            string[] notes = cmd2.Split(new char[]{',' },StringSplitOptions.RemoveEmptyEntries);
            
            StringBuilder notesList = new StringBuilder();
            foreach(string note in notes)
            {
                if(note.Trim().StartsWith("\"")) continue;

                if((note.Trim().ToUpper().StartsWith(HarpClass.VolumeKey))||(note.Trim().ToUpper().StartsWith(HarpClass.VelocityKey)))
                {
                    string[] vstr = note.Split(new char[]{';' },StringSplitOptions.RemoveEmptyEntries);
                    if(vstr.Length > 1)
                    {
                      notesList.Append($@"{vstr[0].Trim()}={vstr[1].Trim()} ");
                    }
                    continue;
                }

                if(note.Trim() == HarpClass.TaktKey)
                {
                    notesList.Append($@"{HarpClass.TaktKey} ");
                    continue;
                }
                if(note.Trim().ToUpper().StartsWith(HarpClass.PauseKey))
                {
                    string[] vstr = note.Split(new char[]{';' },StringSplitOptions.RemoveEmptyEntries);
                    if(vstr.Length > 1)
                    {
                      notesList.Append($@"{vstr[0].Trim().ToUpper()}{vstr[1].Trim()} ");
                    }
                    else
                    {
                        notesList.Append($@"{vstr[0].Trim().ToUpper()} ");
                    }
                    continue;
                }
                string[] nt = note.Split(new char[]{';' },StringSplitOptions.RemoveEmptyEntries);

                string noteStr = nt[0].Trim();
                bool punkt = noteStr.EndsWith(HarpClass.Dot);
                if(punkt) noteStr = noteStr.Remove(noteStr.Length-1,1);

                int harpSlot = StaticFunctionsClass.ToIntDef(noteStr,0);
                
                

                string instrumentNoteStr = SearchNoteByHarpSlot(harpSlot); 

                if(nt.Length > 1)
                {     
                    //Es gibt note und delay
                    string nstr = punkt ? $@"{instrumentNoteStr}>" :$@"{instrumentNoteStr}";
                    string lenstr = nt[1].Trim();
                    //bool diff = lenstr.StartsWith("/");
                    

                    notesList.Append($@"{nstr}{lenstr} ");
                }
                else
                {
                    //es gibt nur note
                    string nstr = punkt ? $@"{instrumentNoteStr}> " :$@"{instrumentNoteStr} ";
                    notesList.Append(nstr);
                }
                
            }
            return notesList.ToString();
        }
    }


    public class HarpSlotClass
    {
        public int HarpSlot=0;
        public int SlotPush=0;
        public eBreathDirection BreathDirection = eBreathDirection.blow; 
        public HarpSlotClass(int harpSlot, eBreathDirection breathDirection)
        {
            BreathDirection = breathDirection;
            HarpSlot = harpSlot;
        }
    }
    public class InstrumentsNotesClass
    {
        public string Note = string.Empty;
        public int NoteDiff = 0;
        public int HarpSlot = 0;
        public InstrumentsNotesClass(int harpSlot, string note, int noteDiff)
        {
            NoteDiff    = noteDiff;
            Note        = note;
            HarpSlot    = harpSlot;
        }
        public byte GetNoteByte()
        {
            return NotesStaticClass.GetNote(Note);
        }
    }


    public enum eHarpInstruments{SeydelDeLuxeSteelOrchestra, HohnerUnsereLieblinge,ChroamticStandard };



    public class HarpInstrumentFactory
    {

        public static List<eHarpInstruments> GetInstruments()
        {
            List<eHarpInstruments> hi = new List<eHarpInstruments>();
            hi.Add(eHarpInstruments.SeydelDeLuxeSteelOrchestra);
            hi.Add(eHarpInstruments.ChroamticStandard);
            hi.Add(eHarpInstruments.HohnerUnsereLieblinge);
            return hi;
        }


        public static HarpInstrumentClass Create(eHarpInstruments harpInstrument, string dur)
        {
            switch (harpInstrument)
            {
                case eHarpInstruments.ChroamticStandard: return ChroamticStandard(dur);
                case eHarpInstruments.SeydelDeLuxeSteelOrchestra: return SeydelDeLuxeSteelOrchestra(dur);
                case eHarpInstruments.HohnerUnsereLieblinge: return HohnerUnsereLieblinge(dur);
            }
            return null;
        }


        public static HarpInstrumentClass SeydelDeLuxeSteelOrchestra(string dur)
        {
            //1 Reihe mit 12 HarpSlotn jeweit für Blow and Draw
            Dictionary<HarpSlotClass,InstrumentsNotesClass> InstrumentNotesDefinition = new Dictionary<HarpSlotClass, InstrumentsNotesClass>();
            if(dur.ToUpper() == "C")
            {
                InstrumentNotesDefinition.Add(new HarpSlotClass(1,eBreathDirection.blow),new InstrumentsNotesClass(1,"g",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(2,eBreathDirection.blow),new InstrumentsNotesClass(2,"c'",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(3,eBreathDirection.blow),new InstrumentsNotesClass(3,"c'",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(4,eBreathDirection.blow),new InstrumentsNotesClass(4,"e'",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(5,eBreathDirection.blow),new InstrumentsNotesClass(5,"g'",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(6,eBreathDirection.blow),new InstrumentsNotesClass(6,"c''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(7,eBreathDirection.blow),new InstrumentsNotesClass(7,"c''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(8,eBreathDirection.blow),new InstrumentsNotesClass(8,"e''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(9,eBreathDirection.blow),new InstrumentsNotesClass(9,"g''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(10,eBreathDirection.blow),new InstrumentsNotesClass(10,"c'''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(11,eBreathDirection.blow),new InstrumentsNotesClass(11,"c'''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(12,eBreathDirection.blow),new InstrumentsNotesClass(12,"e'''",2));

                InstrumentNotesDefinition.Add(new HarpSlotClass(1,eBreathDirection.draw),new InstrumentsNotesClass(1,"a",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(2,eBreathDirection.draw),new InstrumentsNotesClass(2,"h",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(3,eBreathDirection.draw),new InstrumentsNotesClass(3,"d'",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(4,eBreathDirection.draw),new InstrumentsNotesClass(4,"f'",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(5,eBreathDirection.draw),new InstrumentsNotesClass(5,"a'",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(6,eBreathDirection.draw),new InstrumentsNotesClass(6,"h'",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(7,eBreathDirection.draw),new InstrumentsNotesClass(7,"d''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(8,eBreathDirection.draw),new InstrumentsNotesClass(8,"f''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(9,eBreathDirection.draw),new InstrumentsNotesClass(9,"a''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(10,eBreathDirection.draw),new InstrumentsNotesClass(10,"h''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(11,eBreathDirection.draw),new InstrumentsNotesClass(11,"d'''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(12,eBreathDirection.draw),new InstrumentsNotesClass(12,"f'''",2));

                InstrumentNotesDefinition.Add(new HarpSlotClass(1,eBreathDirection.blowPushed),new InstrumentsNotesClass(1,"g#",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(2,eBreathDirection.blowPushed),new InstrumentsNotesClass(2,"c#'",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(3,eBreathDirection.blowPushed),new InstrumentsNotesClass(3,"c#'",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(4,eBreathDirection.blowPushed),new InstrumentsNotesClass(4,"f'",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(5,eBreathDirection.blowPushed),new InstrumentsNotesClass(5,"g#'",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(6,eBreathDirection.blowPushed),new InstrumentsNotesClass(6,"c#''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(7,eBreathDirection.blowPushed),new InstrumentsNotesClass(7,"c#''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(8,eBreathDirection.blowPushed),new InstrumentsNotesClass(8,"f''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(9,eBreathDirection.blowPushed),new InstrumentsNotesClass(9,"g#''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(10,eBreathDirection.blowPushed),new InstrumentsNotesClass(10,"c#'''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(11,eBreathDirection.blowPushed),new InstrumentsNotesClass(11,"c#'''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(12,eBreathDirection.blowPushed),new InstrumentsNotesClass(12,"f'''",2));

                InstrumentNotesDefinition.Add(new HarpSlotClass(1,eBreathDirection.drawPushed),new InstrumentsNotesClass(1,"a#",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(2,eBreathDirection.drawPushed),new InstrumentsNotesClass(2,"c",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(3,eBreathDirection.drawPushed),new InstrumentsNotesClass(3,"d#'",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(4,eBreathDirection.drawPushed),new InstrumentsNotesClass(4,"f#'",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(5,eBreathDirection.drawPushed),new InstrumentsNotesClass(5,"a#'",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(6,eBreathDirection.drawPushed),new InstrumentsNotesClass(6,"c'",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(7,eBreathDirection.drawPushed),new InstrumentsNotesClass(7,"d#''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(8,eBreathDirection.drawPushed),new InstrumentsNotesClass(8,"f#''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(9,eBreathDirection.drawPushed),new InstrumentsNotesClass(9,"a#''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(10,eBreathDirection.drawPushed),new InstrumentsNotesClass(10,"c''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(11,eBreathDirection.drawPushed),new InstrumentsNotesClass(11,"d#'''",2));
                InstrumentNotesDefinition.Add(new HarpSlotClass(12,eBreathDirection.drawPushed),new InstrumentsNotesClass(12,"f#'''",2));

                return new HarpInstrumentClass("Seydel De Luxe Steel Orchestra C-DUR", InstrumentNotesDefinition);
            }
            return new HarpInstrumentClass($@"Seydel De Luxe Steel Orchestra {dur.ToUpper()}-DUR", InstrumentNotesDefinition);
        }

        public static HarpInstrumentClass ChroamticStandard(string dur)
        {
            Dictionary<HarpSlotClass,InstrumentsNotesClass> InstrumentNotesDefinition = new Dictionary<HarpSlotClass, InstrumentsNotesClass>();
            if(dur.ToUpper() == "C")
            {
                InstrumentNotesDefinition.Add(new HarpSlotClass(1,eBreathDirection.blow),new InstrumentsNotesClass(1,"c",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(2,eBreathDirection.blow),new InstrumentsNotesClass(2,"e",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(3,eBreathDirection.blow),new InstrumentsNotesClass(3,"g",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(4,eBreathDirection.blow),new InstrumentsNotesClass(4,"c'",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(5,eBreathDirection.blow),new InstrumentsNotesClass(5,"c'",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(6,eBreathDirection.blow),new InstrumentsNotesClass(6,"e'",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(7,eBreathDirection.blow),new InstrumentsNotesClass(7,"g'",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(8,eBreathDirection.blow),new InstrumentsNotesClass(8,"c''",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(9,eBreathDirection.blow),new InstrumentsNotesClass(9,"c''",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(10,eBreathDirection.blow),new InstrumentsNotesClass(10,"e''",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(11,eBreathDirection.blow),new InstrumentsNotesClass(11,"g''",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(12,eBreathDirection.blow),new InstrumentsNotesClass(12,"c'''",0));


                InstrumentNotesDefinition.Add(new HarpSlotClass(1,eBreathDirection.draw),new InstrumentsNotesClass(1,"d",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(2,eBreathDirection.draw),new InstrumentsNotesClass(2,"f",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(3,eBreathDirection.draw),new InstrumentsNotesClass(3,"a",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(4,eBreathDirection.draw),new InstrumentsNotesClass(4,"h",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(5,eBreathDirection.draw),new InstrumentsNotesClass(5,"d'",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(6,eBreathDirection.draw),new InstrumentsNotesClass(6,"f'",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(7,eBreathDirection.draw),new InstrumentsNotesClass(7,"a'",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(8,eBreathDirection.draw),new InstrumentsNotesClass(8,"h'",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(9,eBreathDirection.draw),new InstrumentsNotesClass(9,"d''",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(10,eBreathDirection.draw),new InstrumentsNotesClass(10,"f''",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(11,eBreathDirection.draw),new InstrumentsNotesClass(11,"a''",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(12,eBreathDirection.draw),new InstrumentsNotesClass(12,"h''",0));

                InstrumentNotesDefinition.Add(new HarpSlotClass(1,eBreathDirection.blowPushed),new InstrumentsNotesClass(1,"c#",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(2,eBreathDirection.blowPushed),new InstrumentsNotesClass(2,"f",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(3,eBreathDirection.blowPushed),new InstrumentsNotesClass(3,"g#",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(4,eBreathDirection.blowPushed),new InstrumentsNotesClass(4,"c#'",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(5,eBreathDirection.blowPushed),new InstrumentsNotesClass(5,"c#'",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(6,eBreathDirection.blowPushed),new InstrumentsNotesClass(6,"f'",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(7,eBreathDirection.blowPushed),new InstrumentsNotesClass(7,"g#'",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(8,eBreathDirection.blowPushed),new InstrumentsNotesClass(8,"c#''",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(9,eBreathDirection.blowPushed),new InstrumentsNotesClass(9,"c#''",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(10,eBreathDirection.blowPushed),new InstrumentsNotesClass(10,"f''",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(11,eBreathDirection.blowPushed),new InstrumentsNotesClass(11,"g#''",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(12,eBreathDirection.blowPushed),new InstrumentsNotesClass(12,"c#'''",0));
                

                InstrumentNotesDefinition.Add(new HarpSlotClass(1,eBreathDirection.drawPushed),new InstrumentsNotesClass(1,"d#",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(2,eBreathDirection.drawPushed),new InstrumentsNotesClass(2,"f#",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(3,eBreathDirection.drawPushed),new InstrumentsNotesClass(3,"a#",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(4,eBreathDirection.drawPushed),new InstrumentsNotesClass(4,"c",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(5,eBreathDirection.drawPushed),new InstrumentsNotesClass(5,"d#'",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(6,eBreathDirection.drawPushed),new InstrumentsNotesClass(6,"f#'",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(7,eBreathDirection.drawPushed),new InstrumentsNotesClass(7,"a#'",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(8,eBreathDirection.drawPushed),new InstrumentsNotesClass(8,"c'",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(9,eBreathDirection.drawPushed),new InstrumentsNotesClass(9,"d#''",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(10,eBreathDirection.drawPushed),new InstrumentsNotesClass(10,"f#''",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(11,eBreathDirection.drawPushed),new InstrumentsNotesClass(11,"a#''",0));
                InstrumentNotesDefinition.Add(new HarpSlotClass(12,eBreathDirection.drawPushed),new InstrumentsNotesClass(12,"c''",0));
                                
                return new HarpInstrumentClass("ChroamticStandard C-DUR",InstrumentNotesDefinition);
            }
            return new HarpInstrumentClass($@"ChroamticStandard {dur.ToUpper()}-DUR",InstrumentNotesDefinition);
        }

        public static HarpInstrumentClass HohnerUnsereLieblinge(string dur)
        {
            // 2 Reihen je 8 x 2er HarpSlotn füf 1 blow und 1 draw
            // 1.Reihe von e - g''
            // 2.Reihen von e' - g'''
            Dictionary<HarpSlotClass,InstrumentsNotesClass> InstrumentNotesDefinition = new Dictionary<HarpSlotClass, InstrumentsNotesClass>();
            if(dur.ToUpper() == "C")
            {
               
                InstrumentNotesDefinition.Add(new HarpSlotClass(1,eBreathDirection.blow),new InstrumentsNotesClass(1,"e",1));
                InstrumentNotesDefinition.Add(new HarpSlotClass(2,eBreathDirection.blow),new InstrumentsNotesClass(2,"g",1));
                InstrumentNotesDefinition.Add(new HarpSlotClass(3,eBreathDirection.blow),new InstrumentsNotesClass(3,"c'",1));                
                InstrumentNotesDefinition.Add(new HarpSlotClass(4,eBreathDirection.blow),new InstrumentsNotesClass(4,"e'",1));
                InstrumentNotesDefinition.Add(new HarpSlotClass(5,eBreathDirection.blow),new InstrumentsNotesClass(5,"g'",1));
                InstrumentNotesDefinition.Add(new HarpSlotClass(6,eBreathDirection.blow),new InstrumentsNotesClass(6,"c''",1));                
                InstrumentNotesDefinition.Add(new HarpSlotClass(7,eBreathDirection.blow),new InstrumentsNotesClass(7,"e''",1));
                InstrumentNotesDefinition.Add(new HarpSlotClass(8,eBreathDirection.blow),new InstrumentsNotesClass(8,"g''",1));
                


                InstrumentNotesDefinition.Add(new HarpSlotClass(1,eBreathDirection.draw),new InstrumentsNotesClass(1,"g",1));
                InstrumentNotesDefinition.Add(new HarpSlotClass(2,eBreathDirection.draw),new InstrumentsNotesClass(2,"a",1));
                InstrumentNotesDefinition.Add(new HarpSlotClass(3,eBreathDirection.draw),new InstrumentsNotesClass(3,"d'",1));
                InstrumentNotesDefinition.Add(new HarpSlotClass(4,eBreathDirection.draw),new InstrumentsNotesClass(4,"f'",1));
                InstrumentNotesDefinition.Add(new HarpSlotClass(5,eBreathDirection.draw),new InstrumentsNotesClass(5,"g'",1));
                InstrumentNotesDefinition.Add(new HarpSlotClass(6,eBreathDirection.draw),new InstrumentsNotesClass(6,"h'",1));
                InstrumentNotesDefinition.Add(new HarpSlotClass(7,eBreathDirection.draw),new InstrumentsNotesClass(7,"d''",1));
                InstrumentNotesDefinition.Add(new HarpSlotClass(8,eBreathDirection.draw),new InstrumentsNotesClass(8,"f''",1));
                                                
                 return new HarpInstrumentClass("Hohner Unsere Lieblinge C-DUR",InstrumentNotesDefinition);
            }
            return new HarpInstrumentClass($@"Hohner Unsere Lieblinge C-DUR {dur.ToUpper()}-DUR", InstrumentNotesDefinition);
        }
    }

    public enum eBreathDirection{blow=0, draw=1, blowPushed=2, drawPushed=3};

    public class AirSlotsClass
    {
       
        public List<AirSlotClass> Slots = new List<AirSlotClass>();
        SimpleApi sa = new SimpleApi();
        HarpInstrumentClass harp = null;
        GroupBox gb  =null;
        
        public IEnumerable<Control> GetAll(Control control,Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl,type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }


        public void DeleteSlots()
        {
            if(gb != null)
            {
                var all = GetAll(gb,typeof(NoteButton));                
                foreach(NoteButton nb in all)
                {
                    Console.WriteLine(nb.Name);
                    nb.Dispose();
                }
                all = GetAll(gb,typeof(Button));                
                foreach(Button nb in all)
                {
                    Console.WriteLine(nb.Name);
                    nb.Dispose();
                }
                gb.Dispose();
            }
        }

        public void Create(Control parent, SimpleApi saa, Instrument instrument,eHarpInstruments harpInstrument)
        {    
                       
            sa = new SimpleApi();
            sa = saa;
            sa.SetInstrument(instrument);
            harp = HarpInstrumentFactory.Create(harpInstrument,"C");
                                    
            if(harp.InstrumentNotesDefinition.Count <= 0)
            {
                return;
            }
            var inn = harp.InstrumentNotesDefinition.Keys.Select(m => m).Where(kvp => kvp.BreathDirection ==  eBreathDirection.blow).Select(k => k.HarpSlot).ToList();
            gb = new GroupBox();
            gb.Parent = parent;
            gb.Width = (inn.Count+1)*50+16;
            gb.Height = 500;
            gb.Left = 8;
            gb.Top  = 16;
            gb.Text = string.Empty; //harp.Name;
            gb.Dock = DockStyle.Left;
            gb.Visible = true;
            //Für alle im Instrument definierten HarpSlotn wird die UI angelegt
            foreach(KeyValuePair<HarpSlotClass,InstrumentsNotesClass> inf in  harp.InstrumentNotesDefinition)
            {
                
                AirSlotClass aslot = new AirSlotClass(gb,inf,sa);
                Slots.Add(aslot);
            }
           
        }

        public void SetInstrument(Instrument instrument)
        {                        
            sa.SetInstrument(instrument);           
        }

        public AirSlotClass GetNote(byte row)
        {
            if(row > Slots.Count) return null;
            var asc = Slots[row];
            return (asc != null) ? asc : null;
        }
        private bool isEmpty()
        {
            return (Slots.Count <= 0);
        }

        public bool IsEmpty => isEmpty();
    }

    public class HarpClass
    {
        public static string VelocityKey = "VEL";
        public static string VolumeKey = "VOL";
        public static string PauseKey = "P";
        public static string TaktKey = "|";
        public static string Divider = "/";
        public static string Dot = ">";
        public static string HarpAttributeDivider = ";";
        public static string HarpNotesDivider = ",";
        public static string SongAttributeDivider = "";
        public static string SongNotesDivider = " ";
        public static string SongEqualKey = "=";
        public static string CommentKey = "%";

        AirSlotsClass airSlots = new AirSlotsClass();
        SimpleApi sa;
        public HarpInstrumentClass HarpInstrument = null;
        public HarpInstrumentClass ReferenceHarpInstrument = null;
        public void CreateHarp(Control parent, SimpleApi saa,Instrument instrument,eHarpInstruments harpInstrument,eHarpInstruments refHarpInstrument)
        {
            sa = saa;
            airSlots.Create(parent, sa, instrument,harpInstrument);
            HarpInstrument = HarpInstrumentFactory.Create(harpInstrument,"C");
            ReferenceHarpInstrument = HarpInstrumentFactory.Create(refHarpInstrument,"C");
        }

        public byte Play(int harpSlotnr, eBreathDirection breathDirection, int ms)
        {     
            int notediff = this.GetHarpSlotnDiff(new HarpSlotClass(harpSlotnr,breathDirection));
            var asc = (NoteButton) this.GetControl(new HarpSlotClass(harpSlotnr-notediff,breathDirection));
            if(asc == null) return 0;
            asc.BackColor = asc.ColorPushed;
            Application.DoEvents();
            byte played = this.Play(new HarpSlotClass(harpSlotnr,breathDirection),sa);
            Thread.Sleep(ms);
            Application.DoEvents();
            this.HarpInstrument.PlayOff(played,sa);
            asc.BackColor = asc.ColorReleased;
            return played;
        }

        public void DeleteSlots()
        {
            airSlots.DeleteSlots();
        }

        public Control GetControl(HarpSlotClass HarpSlot)
        {          
            AirSlotClass asc = this.airSlots.Slots.Find(X=>(X.SlotDefinition.Key.HarpSlot == HarpSlot.HarpSlot)&&(X.SlotDefinition.Key.BreathDirection == HarpSlot.BreathDirection));
            return asc?.slot;
        }

        public void SetVolume(double volume)
        {
            sa.SetVolume(volume);
        }
        public string Translate(string[] cmd, int rowOffset)
        {
           // HarpInstrumentClass harp = HarpInstrumentFactory.SeydelDeLuxeSteelOrchestra("C");
            return this.HarpInstrument.Translate(cmd,rowOffset);
        }
        public string TranslateABC(string[] cmd, int rowOffset)
        {
           // HarpInstrumentClass harp = HarpInstrumentFactory.SeydelDeLuxeSteelOrchestra("C");
            return this.HarpInstrument.TranslateABC(cmd,rowOffset);
        }
        public string TranslateBack(string[] cmd,int rowOffset)
        {            
            return this.HarpInstrument.TranslateBack(cmd,rowOffset);
        }

        public string RemoveUselessCharacters(string cmd)
        {
            string str = cmd.Trim().Replace("\n","").Replace("\r","");
            return str;
        }

        public bool IsNotANote(string note)
        {
            string pnote = note.Trim().ToUpper();
            return(pnote.Contains(HarpClass.VelocityKey) 
                || pnote.Contains(HarpClass.VolumeKey) 
                );
        }
        
        public string GetPlainNotes(string cmdToPlay)
        {
            StringBuilder sb = new StringBuilder();
            
            
                                        
            string cmd = RemoveUselessCharacters(cmdToPlay);
            string[] notes =  cmd.Split(HarpClass.HarpNotesDivider.ToCharArray(),StringSplitOptions.RemoveEmptyEntries);          
            
            foreach(string note in notes)
            {     
                if(IsNotANote(note)) continue;
                string[] noteattributes = note.Split(HarpClass.HarpAttributeDivider.ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                string cstr = noteattributes[0].Trim();
                if(cstr.EndsWith(HarpClass.Dot)) 
                {
                    cstr = cstr.Remove(cstr.Length-1,1);
                }
                sb.Append($@"{cstr}{HarpClass.HarpNotesDivider} ");
            }
            
            return sb.ToString();
        }

        public void SetInstrument(Instrument instrument)
        {
            airSlots.SetInstrument(instrument);
        }

        public void SetHarpInstrument(eHarpInstruments harpInstrument, string dur)
        {
            HarpInstrument = HarpInstrumentFactory.Create(harpInstrument,dur);
        }

        public void SetRefHarpInstrument(eHarpInstruments harpInstrument, string dur)
        {
           ReferenceHarpInstrument = HarpInstrumentFactory.Create(harpInstrument,dur);
        }
         
        public int GetHarpSlotnDiff(HarpSlotClass HarpSlot)
        {
            return this.HarpInstrument.GetHarpSlotnDiff(HarpSlot,ReferenceHarpInstrument);
        }

        public byte Play(HarpSlotClass HarpSlot, SimpleApi sa)
        {
            return this.HarpInstrument.Play(HarpSlot,sa,ReferenceHarpInstrument);
        }

        public void PlayOff(HarpSlotClass HarpSlot, SimpleApi sa)
        {
            this.HarpInstrument.PlayOff(HarpSlot,sa,ReferenceHarpInstrument);
        }

    }
}
