using BasicClassLibrary;
using Enums;
using MidiOutApi.Api;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HarpMeNow
{
    public  class TranslateOrder
    {
        public eTranslateType TranslateType;
        public TranslateOrder(eTranslateType translateType)
        {
            TranslateType = translateType;
        }
        public override string ToString()
        {
            return EnumHelper.GetDescription(TranslateType);

        }
    }

   
    public class InstrumentsNotesClass
    {
        public string Note { get; set; }
        public int NoteDiff { get; set; }
        public int HarpSlot { get; set; }

        public eBreathDirection BreathDirection { get; set; }

        public InstrumentsNotesClass()
        {

        }

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

    public class HarpInstrumentFactory
    {
       
        
        public static HarpInstrumentClass HarpDatabaeObject2HarpInstrument(Harp harpObject)
        {
            Dictionary<AirSlotAttributesClass, InstrumentsNotesClass> InstrumentNotesDefinition = new Dictionary<AirSlotAttributesClass, InstrumentsNotesClass>();
            int noteDiff = 2;
            foreach(AirSlotAttributesClass airslot in harpObject.AirSlots)
            {
                InstrumentNotesDefinition.Add(airslot, new InstrumentsNotesClass(airslot.Slot, airslot.NoteStr, noteDiff));
            }
            return new HarpInstrumentClass($@"{harpObject.Description}", InstrumentNotesDefinition,harpObject.Key);
        }

        

        public static HarpInstrumentClass SeydelDeLuxeSteelOrchestra(eKey dur)
        {
            //1 Reihe mit 12 HarpSlotn jeweit für Blow and Draw
            
            Dictionary<AirSlotAttributesClass,InstrumentsNotesClass> InstrumentNotesDefinition = new Dictionary<AirSlotAttributesClass, InstrumentsNotesClass>();
            if(dur == eKey.C_DUR)
            {
                string noteStrBlow          = string.Empty;
                string noteStrDraw          = string.Empty;
                string noteStrBlowPushed    = string.Empty;
                string noteStrDrawPushed    = string.Empty;
                for (int i = 1; i <= 12; i++)
                {                    
                    int noteInx = i;
                    switch(noteInx)
                    {
                        case 1:
                            noteStrBlow         = Statics.g_0;
                            noteStrDraw         = Statics.a_0;
                            noteStrBlowPushed   = Statics.gis_0;
                            noteStrDrawPushed   = Statics.ais_0;
                            break;
                        case 2:
                            noteStrBlow         = Statics.c_1;
                            noteStrDraw         = Statics.h_0;
                            noteStrBlowPushed   = Statics.cis_1;
                            noteStrDrawPushed   = Statics.c_0;
                            break;
                        case 3:
                            noteStrBlow         = Statics.c_1;
                            noteStrDraw         = Statics.d_1;
                            noteStrBlowPushed   = Statics.cis_1;
                            noteStrDrawPushed   = Statics.dis_1;
                            break;
                        case 4:
                            noteStrBlow         = Statics.e_1;
                            noteStrDraw         = Statics.f_1;
                            noteStrBlowPushed   = Statics.f_1;
                            noteStrDrawPushed   = Statics.fis_1;
                            break;
                        case 5:
                            noteStrBlow         = Statics.g_1;
                            noteStrDraw         = Statics.a_1;
                            noteStrBlowPushed   = Statics.gis_1;
                            noteStrDrawPushed   = Statics.ais_1;
                            break;
                        case 6:
                            noteStrBlow         = Statics.c_2;
                            noteStrDraw         = Statics.h_1;
                            noteStrBlowPushed   = Statics.cis_2;
                            noteStrDrawPushed   = Statics.c_2;
                            break;
                        case 7:
                            noteStrBlow         = Statics.c_2;
                            noteStrDraw         = Statics.d_2;
                            noteStrBlowPushed   = Statics.cis_2;
                            noteStrDrawPushed   = Statics.dis_2;
                            break;
                        case 8:
                            noteStrBlow         = Statics.e_2;
                            noteStrDraw         = Statics.f_2;
                            noteStrBlowPushed   = Statics.f_2;
                            noteStrDrawPushed   = Statics.fis_2;
                            break;
                        case 9:
                            noteStrBlow         = Statics.g_2;
                            noteStrDraw         = Statics.a_2;
                            noteStrBlowPushed   = Statics.gis_2;
                            noteStrDrawPushed   = Statics.ais_2;
                            break;
                        case 10:
                            noteStrBlow         = Statics.c_3;
                            noteStrDraw         = Statics.h_2;
                            noteStrBlowPushed   = Statics.cis_3;
                            noteStrDrawPushed   = Statics.c_3;
                            break;
                        case 11:
                            noteStrBlow         = Statics.c_3;
                            noteStrDraw         = Statics.d_3;                            
                            noteStrBlowPushed   = Statics.cis_3;
                            noteStrDrawPushed   = Statics.dis_3;
                            break;
                        case 12:
                            noteStrBlow         = Statics.e_3;
                            noteStrDraw         = Statics.f_3;
                            noteStrBlowPushed   = Statics.f_3;
                            noteStrDrawPushed   = Statics.fis_3;
                            break;
                    }
                    InstrumentNotesDefinition.Add(new AirSlotAttributesClass(noteInx, eBreathDirection.blow, noteStrBlow), new InstrumentsNotesClass(noteInx, noteStrBlow, 2));
                    InstrumentNotesDefinition.Add(new AirSlotAttributesClass(noteInx, eBreathDirection.draw, noteStrDraw), new InstrumentsNotesClass(noteInx, noteStrDraw, 2));
                    InstrumentNotesDefinition.Add(new AirSlotAttributesClass(noteInx, eBreathDirection.blowPushed, noteStrBlowPushed), new InstrumentsNotesClass(noteInx, noteStrBlowPushed, 2));
                    InstrumentNotesDefinition.Add(new AirSlotAttributesClass(noteInx, eBreathDirection.drawPushed, noteStrDrawPushed), new InstrumentsNotesClass(noteInx, noteStrDrawPushed, 2));
                }
                                                                                                                                                                                                              
                return new HarpInstrumentClass($@"Seydel De Luxe Steel Orchestra ({EnumHelper.GetDescription(dur)})", InstrumentNotesDefinition,dur);
            }
            return new HarpInstrumentClass($@"Seydel De Luxe Steel Orchestra ({EnumHelper.GetDescription(dur)})", InstrumentNotesDefinition,dur);
        }

       

        public static HarpInstrumentClass ChroamticStandard(eKey dur)
        {
            Dictionary<AirSlotAttributesClass,InstrumentsNotesClass> InstrumentNotesDefinition = new Dictionary<AirSlotAttributesClass, InstrumentsNotesClass>();
            if(dur == eKey.C_DUR)
            {
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(1,eBreathDirection.blow,Statics.c_0),new InstrumentsNotesClass(1,Statics.c_0,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(2,eBreathDirection.blow,Statics.e_0),new InstrumentsNotesClass(2,Statics.e_0,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(3,eBreathDirection.blow,Statics.g_0),new InstrumentsNotesClass(3,Statics.g_0,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(4,eBreathDirection.blow,Statics.c_1),new InstrumentsNotesClass(4,Statics.c_1,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(5,eBreathDirection.blow,Statics.c_1),new InstrumentsNotesClass(5,Statics.c_1,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(6,eBreathDirection.blow,Statics.e_1),new InstrumentsNotesClass(6,Statics.e_1,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(7,eBreathDirection.blow,Statics.g_1),new InstrumentsNotesClass(7,Statics.g_1,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(8,eBreathDirection.blow,Statics.c_2),new InstrumentsNotesClass(8,Statics.c_2,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(9,eBreathDirection.blow,Statics.c_2),new InstrumentsNotesClass(9,Statics.c_2,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(10,eBreathDirection.blow,Statics.e_2),new InstrumentsNotesClass(10,Statics.e_2,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(11,eBreathDirection.blow,Statics.g_2),new InstrumentsNotesClass(11,Statics.g_2,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(12,eBreathDirection.blow,Statics.c_3),new InstrumentsNotesClass(12,Statics.c_3,0));


                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(1,eBreathDirection.draw,Statics.d_0),new InstrumentsNotesClass(1,Statics.d_0,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(2,eBreathDirection.draw,Statics.f_0),new InstrumentsNotesClass(2,Statics.f_0,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(3,eBreathDirection.draw,Statics.a_0),new InstrumentsNotesClass(3,Statics.a_0,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(4,eBreathDirection.draw,Statics.h_0),new InstrumentsNotesClass(4,Statics.h_0,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(5,eBreathDirection.draw,Statics.d_1),new InstrumentsNotesClass(5,Statics.d_1,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(6,eBreathDirection.draw,Statics.f_1),new InstrumentsNotesClass(6,Statics.f_1,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(7,eBreathDirection.draw,Statics.a_1),new InstrumentsNotesClass(7,Statics.a_1,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(8,eBreathDirection.draw,Statics.h_1),new InstrumentsNotesClass(8,Statics.h_1,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(9,eBreathDirection.draw,Statics.d_2),new InstrumentsNotesClass(9,Statics.d_2,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(10,eBreathDirection.draw,Statics.f_2),new InstrumentsNotesClass(10,Statics.f_2,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(11,eBreathDirection.draw,Statics.a_2),new InstrumentsNotesClass(11,Statics.a_2,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(12,eBreathDirection.draw,Statics.h_2),new InstrumentsNotesClass(12,Statics.h_2,0));

                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(1,eBreathDirection.blowPushed, Statics.cis_0),new InstrumentsNotesClass(1,Statics.cis_0,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(2,eBreathDirection.blowPushed, Statics.f_0),new InstrumentsNotesClass(2,Statics.f_0,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(3,eBreathDirection.blowPushed, Statics.gis_1),new InstrumentsNotesClass(3,Statics.gis_1,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(4,eBreathDirection.blowPushed, Statics.cis_1),new InstrumentsNotesClass(4,Statics.cis_1,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(5,eBreathDirection.blowPushed, Statics.cis_1),new InstrumentsNotesClass(5,Statics.cis_1,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(6,eBreathDirection.blowPushed, Statics.f_1),new InstrumentsNotesClass(6,Statics.f_1,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(7,eBreathDirection.blowPushed, Statics.gis_1),new InstrumentsNotesClass(7,Statics.gis_1,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(8,eBreathDirection.blowPushed, Statics.cis_2),new InstrumentsNotesClass(8,Statics.cis_2,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(9,eBreathDirection.blowPushed, Statics.cis_2),new InstrumentsNotesClass(9,Statics.cis_2,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(10,eBreathDirection.blowPushed, Statics.f_2),new InstrumentsNotesClass(10,Statics.f_2,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(11,eBreathDirection.blowPushed, Statics.gis_2),new InstrumentsNotesClass(11,Statics.gis_2,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(12,eBreathDirection.blowPushed, Statics.cis_3),new InstrumentsNotesClass(12,Statics.cis_3,0));
                

                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(1,eBreathDirection.drawPushed,Statics.dis_0),new InstrumentsNotesClass(1,Statics.dis_0,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(2,eBreathDirection.drawPushed,Statics.fis_0),new InstrumentsNotesClass(2,Statics.fis_0,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(3,eBreathDirection.drawPushed,Statics.ais_0),new InstrumentsNotesClass(3,Statics.ais_0,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(4,eBreathDirection.drawPushed,Statics.c_0),new InstrumentsNotesClass(4,Statics.c_0,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(5,eBreathDirection.drawPushed,Statics.dis_1),new InstrumentsNotesClass(5,Statics.dis_1,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(6,eBreathDirection.drawPushed,Statics.fis_1),new InstrumentsNotesClass(6,Statics.fis_1,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(7,eBreathDirection.drawPushed,Statics.ais_1),new InstrumentsNotesClass(7,Statics.ais_1,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(8,eBreathDirection.drawPushed,Statics.c_2),new InstrumentsNotesClass(8,Statics.c_2,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(9,eBreathDirection.drawPushed,Statics.dis_2),new InstrumentsNotesClass(9,Statics.dis_2,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(10,eBreathDirection.drawPushed,Statics.fis_2),new InstrumentsNotesClass(10,Statics.fis_2,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(11,eBreathDirection.drawPushed,Statics.ais_2),new InstrumentsNotesClass(11,Statics.ais_2,0));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(12,eBreathDirection.drawPushed,Statics.c_2),new InstrumentsNotesClass(12,Statics.c_2,0));
                                
                return new HarpInstrumentClass($@"ChroamticStandard ({EnumHelper.GetDescription(dur)})", InstrumentNotesDefinition,dur);
            }
            return new HarpInstrumentClass($@"ChroamticStandard ({EnumHelper.GetDescription(dur)})",InstrumentNotesDefinition, dur);
        }

        public static HarpInstrumentClass HohnerUnsereLieblinge(eKey dur)
        {
            // 2 Reihen je 8 x 2er HarpSlotn füf 1 blow und 1 draw
            // 1.Reihe von e - g''
            // 2.Reihen von e' - g'''
            Dictionary<AirSlotAttributesClass,InstrumentsNotesClass> InstrumentNotesDefinition = new Dictionary<AirSlotAttributesClass, InstrumentsNotesClass>();
            
            if(dur == eKey.C_DUR)
            {
               
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(1,eBreathDirection.blow, Statics.e_0),new InstrumentsNotesClass(1,Statics.e_0,1));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(2,eBreathDirection.blow,Statics.g_0),new InstrumentsNotesClass(2,Statics.g_0,1));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(3,eBreathDirection.blow,Statics.c_1),new InstrumentsNotesClass(3,Statics.c_1,1));                
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(4,eBreathDirection.blow,Statics.e_1),new InstrumentsNotesClass(4,Statics.e_1,1));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(5,eBreathDirection.blow,Statics.g_1),new InstrumentsNotesClass(5,Statics.g_1,1));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(6,eBreathDirection.blow,Statics.c_2),new InstrumentsNotesClass(6,Statics.c_2,1));                
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(7,eBreathDirection.blow,Statics.e_2),new InstrumentsNotesClass(7,Statics.e_2,1));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(8,eBreathDirection.blow,Statics.g_2),new InstrumentsNotesClass(8,Statics.g_2,1));
                


                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(1,eBreathDirection.draw,Statics.g_0),new InstrumentsNotesClass(1,Statics.g_0,1));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(2,eBreathDirection.draw,Statics.a_0),new InstrumentsNotesClass(2,Statics.a_0,1));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(3,eBreathDirection.draw,Statics.d_1),new InstrumentsNotesClass(3,Statics.d_1,1));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(4,eBreathDirection.draw,Statics.f_1),new InstrumentsNotesClass(4,Statics.f_1,1));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(5,eBreathDirection.draw,Statics.g_1),new InstrumentsNotesClass(5,Statics.g_1,1));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(6,eBreathDirection.draw,Statics.h_1),new InstrumentsNotesClass(6,Statics.h_1,1));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(7,eBreathDirection.draw,Statics.d_2),new InstrumentsNotesClass(7,Statics.d_2,1));
                InstrumentNotesDefinition.Add(new AirSlotAttributesClass(8,eBreathDirection.draw,Statics.f_2),new InstrumentsNotesClass(8,Statics.f_2,1));
                                                
                 return new HarpInstrumentClass($@"Hohner Unsere Lieblinge ({EnumHelper.GetDescription(dur)})", InstrumentNotesDefinition,dur);
            }
            return new HarpInstrumentClass($@"Hohner Unsere Lieblinge ({EnumHelper.GetDescription(dur)})", InstrumentNotesDefinition,dur);
        }
    }

    public class RemoteDataClass
    {
        public bool Cancel;
        public bool Pause;
    }
    public class HarpDataClass
    {
        public int SelectionStart;
        public int SelectionLength;
        public Color SelectionBackColor;
        public Color SelectionColor;
    }

    public class HarpClass
    {
        //public NotifiesClass Notifies = new NotifiesClass();
        public List<Harp> Harps = new List<Harp>();
        AirSlotsClass airSlots = new AirSlotsClass();
        SimpleApi sa;
        public HarpInstrumentClass ActualHarpInstrument = null;
      //  public HarpInstrumentClass ReferenceHarpInstrument = null;
        Harp SelectedHarp = null;
        Instrument instrument;        
        PlayHarpClass playHarp;
        private double _velocity = 100;
        private double _volume = 10;
        public byte Transpose = 0;
        public int ShiftNote = 0;
        
        public bool CancelPlay = false;
        public bool PausePlay = false;
        double ReferenceSpeedNote = 1.0;

        public HarpClass()
        {            
            FormInstances.Instance().HarpNotifies.Register4Info(Notify_OnRaiseInfoHandler);
        }

        private void Notify_OnRaiseInfoHandler(object sender, MessageEventArgs k)
        {
            if(k.Key.ToString() == Statics.SetVolume)
            {
                double vol = StaticFunctionsClass.ToDoubleDef(k.Meldung, 5);
                SetVolume(vol);
            }
            else if (k.Key.ToString() == Statics.SetVelocity)
            {
                double vel = StaticFunctionsClass.ToDoubleDef(k.Meldung, 50);
                SetVelocity(vel* Statics.VelocityFactor);
            }
            else if (k.Key.ToString() == Statics.SetTranspose)
            {
                byte tr = (byte) StaticFunctionsClass.ToIntDef(k.Meldung, 0);
                SetTranspose(tr);
            }
        }

        public bool IsCreate = false;

        public void AddHarps(List<Harp> lst)
        {
            Harps.Clear();
            Harps.AddRange(lst);
        }
        public void SelectHarp(Harp harp)
        {
            SelectedHarp = harp;
        }
        public int CreateHarp(Control parent,Control songText, SimpleApi saa,Harp actualHarp,Harp refHarp)
        {            
            sa = saa;
            sa.SetTranspose(0);
           
            airSlots = new AirSlotsClass();
            airSlots.DeleteSlots();
            int x = airSlots.Create(parent,songText, sa, instrument,actualHarp);
            ActualHarpInstrument = HarpInstrumentFactory.HarpDatabaeObject2HarpInstrument(actualHarp); 
            //ReferenceHarpInstrument = HarpInstrumentFactory.HarpDatabaeObject2HarpInstrument(refHarp);

            IsCreate = true;
            return x;
        }        

        public void SetInstrument(Instrument instr)
        {
            instrument = instr;
        }
        
        public void SetCancel(bool cnc)
        {
            CancelPlay = cnc;
        }       

        public byte Play(int harpSlotnr, eBreathDirection breathDirection, int ms)
        {     
           // int notediff = this.GetHarpSlotnDiff(new AirSlotAttributesClass(harpSlotnr,breathDirection));
            if (harpSlotnr > 100)
            {
                harpSlotnr -= 100;
                if (breathDirection == eBreathDirection.draw)
                {
                    breathDirection = eBreathDirection.drawPushed;
                }
                else
                {
                    breathDirection = eBreathDirection.blowPushed;
                }
            }
            //var asc = (NoteButton) this.GetControl(new AirSlotAttributesClass(harpSlotnr-notediff,breathDirection));
            
            var asc = (NoteButton)this.GetControl(new AirSlotAttributesClass(harpSlotnr, breathDirection));
            if (asc == null) return 0;
            asc.BackColor = asc.ColorPushed;
            
            Application.DoEvents();
            
            byte played = this.Play(new AirSlotAttributesClass(harpSlotnr,breathDirection),sa);
            Thread.Sleep(ms);
            Application.DoEvents();
            this.ActualHarpInstrument.PlayOff(played,sa);
            asc.BackColor = asc.ColorReleased;
            return played;
        }

        public void PlayPause(int ms, PlayNoteButton asc)
        {            
            asc.BackColor = asc.ColorPushed;
            Application.DoEvents();           
            Thread.Sleep(ms);               
            asc.BackColor = asc.ColorReleased;
            Application.DoEvents();
        }

        private double GetPunktDelay(double delay)
        {
            return delay / 2.0;
        }

       

        public bool PlaySequence(string cmdToPlay)
        {
        //    double ReferenceSpeedNote = 1.0; // / 8.0;
            int nPlay = 0;
            CancelPlay = false;
            double unitLength = 1.0; //ToDo        
            SetVolume(_volume*10);
            SetTranspose(Transpose);
            string cmd = cmdToPlay;

            string[] notes = cmd.Split(Statics.HarpNotesDivider.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            int i_note = 0;
            foreach (string note in notes)
            {
                while (PausePlay && !CancelPlay)
                {
                    Thread.Sleep(100);
                    Application.DoEvents();
                }

                string[] noteattributes = note.Split(Statics.HarpAttributeDivider.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string HarpSlot = noteattributes[0].Trim();
                if (HarpSlot == Statics.TaktKey)
                {
                    nPlay += noteattributes[0].Length;
                    i_note++;
                    
                    continue;
                }
                if ((HarpSlot.ToUpper() == Statics.SongTempoKey) && (noteattributes.Length > 1))
                {
                    double tmp = StaticFunctionsClass.ToDoubleDef(noteattributes[1].Trim(), Statics.RefTempo);
                    FormInstances.Instance().HarpNotifies.Notify.RaiseInfo(tmp.ToString(), Statics.SetVelocity, this);
                    SetVelocity(tmp* Statics.VelocityFactor);                   
                    continue;
                }

                if ((HarpSlot.ToUpper() == Statics.SongVolumeKey) && (noteattributes.Length > 1))
                {
                    double Volume = StaticFunctionsClass.ToDoubleDef(noteattributes[1].Trim().Replace(".", ","), _volume);
                    FormInstances.Instance().HarpNotifies.Notify.RaiseInfo(Volume.ToString(), Statics.SetVolume, this);
                    SetVolume(Volume);                    
                    continue;
                }

                bool punkt = HarpSlot.Contains(Statics.DotUpKey);
                bool pause = HarpSlot.Contains(Statics.PauseKey);
                if (pause)
                {
                    double p_delay = 1;
                    double p_pdel = 0.0;
                    if (noteattributes.Length > 1)
                    {
                        string dstr = noteattributes[1].Trim();
                        bool diff = dstr.Contains(Statics.Divider);
                        string ddstr = dstr;
                        if (diff) ddstr = dstr.Substring(1);

                        p_delay = StaticFunctionsClass.ToIntDef(ddstr, 0);
                        if (diff) p_delay = 1.0 / p_delay;
                        if (punkt) p_pdel = GetPunktDelay(p_delay);
                    }

                    if (_velocity <= 0) SetVelocity(50* Statics.VelocityFactor);

                    int p_delayms = (int)((1000 * (p_delay + p_pdel)) * (100.0 / _velocity) * ReferenceSpeedNote);

                    if (CancelPlay) return false;
                    nPlay += punkt ? HarpSlot.Length + 1 : HarpSlot.Length + 2;
                    playHarp.Notes[i_note++].BackColor = Color.Aqua;
                    Thread.Sleep(p_delayms);
                    
                    continue;
                }

                if (punkt)
                {
                    HarpSlot = HarpSlot.Remove(HarpSlot.Length - 1, 1);
                }

                if (!IsNotANote(note))
                {
                    bool blow = StaticFunctionsClass.ToIntDef(HarpSlot, 0) > 0;                   
                    nPlay += HarpSlot.Length + 2;
                }

                int key = StaticFunctionsClass.ToIntDef(HarpSlot, 0);
                double note_delay = 1;
                double additional_delay = 0.0;
                if (noteattributes.Length > 1)
                {
                    //Console.WriteLine("");
                    string dstr = noteattributes[1].Trim();
                    note_delay = Statics.GetNoteLength(dstr,unitLength);                    
                    if (punkt) additional_delay = GetPunktDelay(note_delay);
                }

                note_delay *= Statics.NoteDelayFactor;
                if (_velocity <= 0) SetVelocity(50* Statics.VelocityFactor);
                int delayms = (int)((1000 * (note_delay + additional_delay)) * (100.0 / _velocity) * ReferenceSpeedNote);

                if (CancelPlay)
                {
                    return false;
                }

                //SetTranspose(Transpose);
                playHarp.Notes[i_note].FlatStyle = FlatStyle.Flat;
                if (key < 0)
                {
                    //Alle Keys < -100 oder > 100 sind mit den Push-Schieber zu spielen
                    if (key > -100)
                    {
                        playHarp.Notes[i_note].FlatAppearance.BorderSize = 2;
                        playHarp.Notes[i_note].FlatAppearance.BorderColor = Color.Blue;

                        Play(Math.Abs(key), eBreathDirection.draw, delayms);
                        playHarp.Notes[i_note++].BackColor = Color.LightSalmon;
                    }
                    else
                    {
                        playHarp.Notes[i_note].FlatAppearance.BorderSize = 2;
                        playHarp.Notes[i_note].FlatAppearance.BorderColor = Color.Blue;

                        Play(Math.Abs(key + 100), eBreathDirection.drawPushed, delayms);
                        playHarp.Notes[i_note++].BackColor = Color.LightSalmon;
                    }
                }
                else if (key > 0)
                {
                    if (key < 100)
                    {
                        playHarp.Notes[i_note].FlatAppearance.BorderSize = 2;
                        playHarp.Notes[i_note].FlatAppearance.BorderColor = Color.Blue;
                        Play(Math.Abs(key), eBreathDirection.blow, delayms);
                        playHarp.Notes[i_note++].BackColor = Color.LightGreen;

                    }
                    else
                    {
                        playHarp.Notes[i_note].FlatStyle = FlatStyle.Flat;
                        playHarp.Notes[i_note].FlatAppearance.BorderSize = 2;
                        playHarp.Notes[i_note].FlatAppearance.BorderColor = Color.Blue;
                        Play(Math.Abs(key - 100), eBreathDirection.blowPushed, delayms);
                        playHarp.Notes[i_note++].BackColor = Color.LightGreen;
                    }
                }
                else
                {
                    Thread.Sleep(delayms);
                }
                Application.DoEvents();
            }
            return true;
        }

        public bool PlaySequenceFromButtons(double volume, double velocity, byte transpose)
        {
            
            CancelPlay = false;

            SetVolume(volume);
            SetVelocity(velocity* Statics.VelocityFactor);
            SetTranspose(transpose);
            foreach (PlayNoteButton note in playHarp.Notes)
            {
                note.FlatAppearance.BorderSize = 0;
            }
            foreach (PlayNoteButton note in playHarp.Notes)
            {
                while (PausePlay && !CancelPlay)
                {
                    Thread.Sleep(100);
                    Application.DoEvents();
                }
                if (CancelPlay) break;

                var asa = (AirSlotAttributesClass) note.Tag;
               // if (_velocity <= 0) SetVelocity(50*Statics.VelocityFactor);
               // double note_delay = asa.Delay;
               // double additional_delay = 0.0;
               // int delayms1 = (int)((1000 * (note_delay + additional_delay)) * (100.0 / _velocity) * ReferenceSpeedNote);
                note.FlatAppearance.BorderColor = Color.Blue;
                note.FlatAppearance.BorderSize = 2;
                Application.DoEvents();
                int delayms1 = (int)(asa.Delay * Statics.NoteDelayFactor);
                if (asa.Notetype == eNoteType.note)
                {
                    Play(Math.Abs(asa.Slot), asa.BreathDirection, delayms1);
                }
                else if(asa.Notetype == eNoteType.pause)
                {
                    PlayPause(delayms1,note);
                }
                note.FlatAppearance.BorderSize = 1;

                Application.DoEvents();
            }
            return true;
        }

       

        public void DeleteSlots()
        {
            airSlots.DeleteSlots();
        }

        public Control GetControl(AirSlotAttributesClass HarpSlot)
        {                    
            AirSlotClass asc = this.airSlots.Slots.Find(X=>(X.SlotDefinition.Key.Slot == HarpSlot.Slot)&&(X.SlotDefinition.Key.BreathDirection == HarpSlot.BreathDirection));
            return asc?.slot;
        }

        public void SetVolume(double volume)
        {
            _volume = volume;
            sa?.SetVolume(volume);
        }

        public void SetTranspose(byte trps)
        {
            Transpose = trps;
            sa?.SetTranspose(Transpose);            
        }
        public void SetVelocity(double velocity)
        {
            _velocity = velocity;            
        }
        public void UpdateTranspose(byte trps)
        {
            Transpose = trps;
            sa?.SetTranspose(Transpose);
            
        }

        public eKey shiftedKey;
        //public eKey Key;
        public Notes TransposeUp(Notes note)
        {
            if (String.IsNullOrEmpty(note._notebez))
            {
                return note;
            }
            int octave = 0;
            string purenote = string.Empty;
            if (note._notebez.EndsWith("'''"))
            {
                octave = 3;
                purenote = note._notebez.Remove(note._notebez.Length - 3).ToLower();
            }
            else if (note._notebez.EndsWith("''"))
            {
                octave = 2;
                purenote = note._notebez.Remove(note._notebez.Length - 2).ToLower();
            }
            else if (note._notebez.EndsWith("'"))
            {
                octave = 1;
                purenote = note._notebez.Remove(note._notebez.Length - 1).ToLower();
            }
            else
            {
                octave = 0;
                purenote = note._notebez;
            }



            string newnote = purenote;
            switch (purenote)
            {
                case Statics.c_0:
                    newnote = Statics.cis_0;
                    break;
                case Statics.cis_0:
                    newnote = Statics.d_0;
                    break;
                case Statics.d_0:
                    newnote = Statics.dis_0;
                    break;
                case Statics.dis_0:
                    newnote = Statics.e_0;
                    break;
                case Statics.e_0:
                    newnote = Statics.f_0;
                    break;
                case Statics.f_0:
                    newnote = Statics.fis_0;
                    break;
                case Statics.fis_0:
                    newnote = Statics.g_0;
                    break;
                case Statics.g_0:
                    newnote = Statics.gis_0;
                    break;
                case Statics.gis_0:
                    newnote = Statics.a_0;
                    break;
                case Statics.a_0:
                    newnote = Statics.ais_0;
                    break;
                case Statics.ais_0:
                    newnote = Statics.h_0;
                    break;
                case Statics.h_0:
                    newnote = Statics.c_0;
                    octave++;
                    break;

            }

            for (int i = 0; i < octave; i++)
            {
                newnote += "'";
            }
            int inx = this.ActualHarpInstrument.SearchHarpSloyByNote(newnote);
            if (inx == int.MinValue)
            {
                return null;
            }
            string inxStr = inx.ToString();
            Notes ntnew = new Notes(newnote, inxStr, note._value);
            ntnew._notetype = eNoteType.note;
            ntnew._shifted = note._shifted + 1;
            return ntnew;
        }
        public eKey ShiftKeyUp(eKey key)
        {
            eKey newkey = key;
            switch (key)
            {
                case eKey.C_DUR:
                    newkey = eKey.Cis_DUR;
                    break;
                case eKey.Cis_DUR:
                    newkey = eKey.D_DUR;
                    break;
                case eKey.D_DUR:
                    newkey = eKey.Es_DUR;
                    break;
                case eKey.Es_DUR:
                    newkey = eKey.E_DUR;
                    break;
                case eKey.E_DUR:
                    newkey = eKey.F_DUR;
                    break;
                case eKey.F_DUR:
                    newkey = eKey.Fis_DUR;
                    break;
                case eKey.Fis_DUR:
                    newkey = eKey.G_DUR;
                    break;
                case eKey.G_DUR:
                    newkey = eKey.Gis_DUR;
                    break;
                case eKey.Gis_DUR:
                    newkey = eKey.A_DUR;
                    break;
                case eKey.A_DUR:
                    newkey = eKey.B_DUR;
                    break;
                case eKey.B_DUR:
                    newkey = eKey.H_DUR;
                    break;
                case eKey.H_DUR:
                    newkey = eKey.C_DUR;
                    break;

            }

            return newkey;
        }
        public eKey ShiftKeyDown(eKey key)
        {
            eKey newkey = key;
            switch (key)
            {
                case eKey.C_DUR:
                    newkey = eKey.H_DUR;
                    break;
                case eKey.H_DUR:
                    newkey = eKey.B_DUR;
                    break;
                case eKey.B_DUR:
                    newkey = eKey.A_DUR;
                    break;
                case eKey.A_DUR:
                    newkey = eKey.As_DUR;
                    break;
                case eKey.As_DUR:
                    newkey = eKey.G_DUR;
                    break;
                case eKey.G_DUR:
                    newkey = eKey.Ges_DUR;
                    break;
                case eKey.Ges_DUR:
                    newkey = eKey.F_DUR;
                    break;
                case eKey.F_DUR:
                    newkey = eKey.E_DUR;
                    break;
                case eKey.E_DUR:
                    newkey = eKey.Es_DUR;
                    break;
                case eKey.Es_DUR:
                    newkey = eKey.D_DUR;
                    break;
                case eKey.D_DUR:
                    newkey = eKey.Des_DUR;
                    break;
                case eKey.Des_DUR:
                    newkey = eKey.C_DUR;
                    break;
            }
            return newkey;
        }
        public Notes TransposeDown(Notes note)
        {
            if (String.IsNullOrEmpty(note._notebez))
            {
                return note;
            }
            int octave = 0;
            string purenote = string.Empty;
            if (note._notebez.EndsWith("'''"))
            {
                octave = 3;
                purenote = note._notebez.Remove(note._notebez.Length - 3).ToLower();
            }
            else if (note._notebez.EndsWith("''"))
            {
                octave = 2;
                purenote = note._notebez.Remove(note._notebez.Length - 2).ToLower();
            }
            else if (note._notebez.EndsWith("'"))
            {
                octave = 1;
                purenote = note._notebez.Remove(note._notebez.Length - 1).ToLower();
            }
            else
            {
                octave = 0;
                purenote = note._notebez.ToLower();
            }


            string newnote = purenote;
            switch (purenote)
            {
                case Statics.cis_0:
                    newnote = Statics.c_0;
                    break;
                case Statics.d_0:
                    newnote = Statics.cis_0;
                    break;
                case Statics.dis_0:
                    newnote = Statics.d_0;
                    break;
                case Statics.e_0:
                    newnote = Statics.dis_0;
                    break;
                case Statics.f_0:
                    newnote = Statics.e_0;
                    break;
                case Statics.fis_0:
                    newnote = Statics.f_0;
                    break;
                case Statics.g_0:
                    newnote = Statics.fis_0;
                    break;
                case Statics.gis_0:
                    newnote = Statics.g_0;
                    break;
                case Statics.a_0:
                    newnote = Statics.gis_0;
                    break;
                case Statics.ais_0:
                    newnote = Statics.a_0;
                    break;
                case Statics.h_0:
                    newnote = Statics.ais_0;
                    break;
                case Statics.c_0:
                    newnote = Statics.h_0;
                    octave--;
                    break;

            }

            if (octave < 0)
            {
                return null;
            }

            for (int i = 0; i < octave; i++)
            {
                newnote += "'";
            }
            int inx = this.ActualHarpInstrument.SearchHarpSloyByNote(newnote);
            if (inx == int.MinValue)
            {
                return null;
            }
            string inxStr = inx.ToString();
            Notes ntnew = new Notes(newnote, inxStr, note._value);
            ntnew._shifted = note._shifted - 1;
            ntnew._notetype = eNoteType.note;
            return ntnew;
        }


        public List<int> ShiftNotesUp(int n)
        {
            var fail = new List<int>();
            shiftedKey = ActualHarpInstrument.Key;
            for (int k = 0; k < n; k++)
            {
                shiftedKey = ShiftKeyUp(shiftedKey);
                for (int i = 0; i < SongNotesList.Count; i++)
                {
                    var note = SongNotesList[i];
                    if (note._notetype != eNoteType.note) continue;
                    var newnote = TransposeUp(note);
                    if (newnote == null)
                    {
                        fail.Add(i);
                        continue;
                    }
                    SongNotesList[i] = newnote;
                }
            }
            if (shiftedKey != ActualHarpInstrument.Key)
            {
                for (int i = 0; i < SongNotesList.Count; i++)
                {
                    var note = SongNotesList[i];
                    if (note._notetype != eNoteType.command) continue;
                    if (note._note.ToUpper().StartsWith(Statics.SongTonalityKey.ToUpper()))
                    {
                        Notes nti = new Notes("", $@"{Statics.SongTonalityKey}", $@"{this.shiftedKey.ToString()}");
                        nti._notetype = eNoteType.command;
                        nti._shifted += n;
                        SongNotesList[i] = nti;
                    }
                }
            }

            return fail;
        }

        public List<int> ShiftNotesDown(int n)
        {
            List<int> fail = new List<int>();
            shiftedKey = ActualHarpInstrument.Key; 
            for (int k = 0; k < n; k++)
            {
                shiftedKey = ShiftKeyDown(shiftedKey);
                for (int i = 0; i < SongNotesList.Count; i++)
                {
                    var note = SongNotesList[i];
                    if (note._notetype != eNoteType.note) continue;
                    var newnote = TransposeDown(note);
                    if (newnote == null)
                    {
                        fail.Add(i);
                        continue;
                    }
                    SongNotesList[i] = newnote;
                }
            }
            if (shiftedKey != ActualHarpInstrument.Key)
            {
                for (int i = 0; i < SongNotesList.Count; i++)
                {
                    var note = SongNotesList[i];
                    if (note._notetype != eNoteType.command) continue;
                    if (note._note.ToUpper().StartsWith(Statics.SongTonalityKey.ToUpper()))
                    {
                        Notes nti = new Notes("", $@"{Statics.SongTonalityKey}", $@"{this.shiftedKey.ToString()}");
                        nti._notetype = eNoteType.command;
                        nti._shifted -= n;
                        SongNotesList[i] = nti;
                    }
                }
            }
            return fail;
        }

        public List<int> ShiftSongNotes(int n)
        {
            if (n > 0)
            {
                //return this.ActualHarpInstrument.ShiftNotesUp(n);
                return this.ShiftNotesUp(n);
            }
            else if(n < 0)
            {
                return this.ShiftNotesDown(Math.Abs(n));
                //return this.ActualHarpInstrument.ShiftNotesDown(Math.Abs(n));
            }
            return new List<int>();
        }
        public void TranslateSongNotesList2Harp(Control parent, Control songparent)
        {
            FormInstances.Instance().harpPlayForm.flowLayoutPanel1.Visible = false;
            ClearPlayHarp();
            double unitLength = 1;
            double volume = 5;
            double tempo = 120;
            string metrum = "4/4";

            if (!string.IsNullOrEmpty(SongDefinition._songInstrument))
            {
                var i = FormInstances.Instance().soundAttributeForm.SelectInstrument(SongDefinition._songInstrument);
                if (i != null)
                {
                    ActualHarpInstrument = HarpInstrumentFactory.HarpDatabaeObject2HarpInstrument(i);
                }
            }
            
            foreach (Notes notes in SongNotesList)
            {
                if (notes._notetype == eNoteType.command)
                {
                    if(notes._note == Statics.SongUnitLengthKey)
                    {
                        unitLength = StaticFunctionsClass.ToDoubleDef(notes._value, 1);
                    }


                    else if (notes._note == Statics.SongTempoKey)
                    {
                        
                        tempo = StaticFunctionsClass.ToDoubleDef(notes._value, 120);
                        SetVelocity(tempo);
                    }
                    else if (notes._note == Statics.SongMetrumKey)
                    {
                        metrum = notes._value;
                    }
                    else if (notes._note == Statics.SongVolumeKey)
                    {
                        volume = StaticFunctionsClass.ToDoubleDef(notes._value, 1);
                        SetVolume(volume);
                    }
                    
                }
                else if (notes._notetype == eNoteType.note)
                {
                    
                    AirSlotAttributesClass slot = new AirSlotAttributesClass();
                    slot.BreathDirection = eBreathDirection.blow;
                    
                    if (notes._notebez.ToUpper() == "P")
                    {
                        slot.Slot = 0;
                    }
                    else
                    {
                        slot.Slot = StaticFunctionsClass.ToIntDef(notes._note, 0);
                    }

                    //Delay wird berechnet auf den Songdefinition und der notenlänge

                    double ul = unitLength; //Länge der Noten
                    double tp = tempo; //Länge der Noten
                    
                    slot.SetDelay(notes._value,ul * tp);
                    slot.UnitLength = unitLength;
                    //slot.SetDelay(notes._value);
                    var x = ActualHarpInstrument.InstrumentNotesDefinition;
                    foreach (var y in x.Keys)
                    {                       
                        if(notes._notebez == y.NoteStr)
                        {
                            
                            slot.NoteStr = y.NoteStr;
                            slot.Slot = y.Slot;
                            slot.Notetype = eNoteType.note;
                            slot.BreathDirection = y.BreathDirection;
                            break;
                        }
                    }

                    playHarp.CreateNote(parent, this, slot, notes._value);
                }
                else if (notes._notetype == eNoteType.pause)
                {
                    AirSlotAttributesClass slot = new AirSlotAttributesClass();
                    slot.BreathDirection = eBreathDirection.blow;
                    slot.Slot = 0;
                    slot.NoteStr = Statics.PauseKey;
                    slot.Notetype = eNoteType.pause;
                    double ul = unitLength; //Länge der Noten
                    double tp = tempo; //Länge der Noten

                    slot.SetDelay(notes._value,ul * tp);

                    //slot.SetDelay(notes._value);                   
                    playHarp.CreatePause(parent, this, slot, notes._value);
                }
                else if(notes._notetype == eNoteType.takt)
                {
                    AirSlotAttributesClass slot = new AirSlotAttributesClass();
                    slot.BreathDirection = eBreathDirection.blow;
                    slot.Slot = -999;
                    slot.Notetype = eNoteType.takt;
                    playHarp.CreateTakt(parent, this, slot, notes._value);
                }
            }
            FormInstances.Instance().harpPlayForm.SetKey(shiftedKey);
            FormInstances.Instance().harpPlayForm.flowLayoutPanel1.Visible = true;            
        }

        /*
        public string TranslateSongNotesList2HarpText(bool withComments)
        {
            
            return this.ActualHarpInstrument.TranslateSongNotesList2HarpText(withComments);
        }
        */
        public List<Notes> SongNotesList;
        public Song SongDefinition = new Song();

        public bool StartsWithSongDefinition(string notes)
        {
            return (
                (notes.Trim().ToUpper().StartsWith(Statics.SongInstrumentKey)) ||
                (notes.Trim().ToUpper().StartsWith(Statics.SongTitleKey)) ||
                (notes.Trim().ToUpper().StartsWith(Statics.ReferenceNumberKey))
                );                        
        }
        

        public List<Notes> TranslateNotes2SongNotesList(string[] cmd,  eKey shiftedKey, eTranslateType translateType)
        {
            this.ActualHarpInstrument.InitNotes();
            var songNotesList = new List<Notes>();                       
            
            foreach (string notesStr in cmd)
            {
                string notes = notesStr.Replace("  ", " ");
                if (StartsWithSongDefinition(notes)) continue;
                
                //Commands
                if (notes.Trim().ToUpper().StartsWith(Statics.SongVolumeKey))
                {
                    double v = getCommandDouble(Statics.SongVolumeKey, notes);
                    var nt0 = new Notes("", Statics.SongVolumeKey, v.ToString());
                    nt0._notetype = eNoteType.command;
                    songNotesList.Add(nt0);
                    continue;
                }
                else if (notes.Trim().ToUpper().StartsWith(Statics.SongTempoKey))
                {
                    double v = getCommandDouble(Statics.SongTempoKey, notes);
                    var nt0 = new Notes("", Statics.SongTempoKey, v.ToString());
                    nt0._notetype = eNoteType.command;
                    songNotesList.Add(nt0);
                    continue;
                }
                else if (notes.Trim().ToUpper().StartsWith(Statics.SongUnitLengthKey))
                {
                    double v = getCommandFractional(Statics.SongUnitLengthKey, notes);
                    var nt0 = new Notes("", Statics.SongUnitLengthKey, v.ToString());
                    nt0._notetype = eNoteType.command;
                    songNotesList.Add(nt0);
                    continue;
                }
                else if (notes.Trim().ToUpper().StartsWith(Statics.SongMetrumKey))
                {
                    string v = getCommandString(Statics.SongMetrumKey, notes);
                    var nt0 = new Notes("", Statics.SongMetrumKey, v);
                    nt0._notetype = eNoteType.command;
                    songNotesList.Add(nt0);
                    continue;
                }
                else if (notes.Trim().StartsWith(Statics.CommentKey))
                {
                    var nt0 = new Notes("", Statics.CommentKey, notes.Trim());
                    nt0._notetype = eNoteType.comment;
                    songNotesList.Add(nt0);
                    continue;
                }
                else if (notes.Trim().ToUpper().StartsWith(Statics.SongTonalityKey))
                {
                    string v = getCommandString(Statics.SongTonalityKey, notes);
                    var nt0 = new Notes("", Statics.SongTonalityKey, v);
                    nt0._notetype = eNoteType.command;
                    songNotesList.Add(nt0);
                    continue;
                }

                string[] nts = notes.Split(Statics.SongNotesDivider.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                int slotPreview = int.MinValue;
                for (int i = 0; i < nts.Length; i++)
                {
                    string ntc = nts[i];
                    if (ntc.Trim() == Statics.TaktKey)
                    {
                        var nt4 = new Notes("", $@"{Statics.TaktKey}", "");
                        nt4._notetype = eNoteType.takt;
                        songNotesList.Add(nt4);
                        continue;
                    }

                    // c c'' c''/8 c''2/8

                    int notedivider = -1;
                    for (int ix = 0; ix < ntc.Length; ix++)
                    {
                        int inx1 = StaticFunctionsClass.ToIntDef(ntc[ix].ToString(), -1);
                        if ((inx1 >= 0) || (ntc[ix].ToString() == "/"))
                        {
                            notedivider = ix;
                            break;
                        }
                    }

                    string notelen = "1";
                    string notebez = string.Empty;
                    if (notedivider > 0)
                    {
                        notelen = ntc.Substring(notedivider);
                        if (notelen.StartsWith("/")) notelen = "1" + notelen;
                        notebez = ntc.Substring(0, notedivider);
                    }
                    else
                    {
                        notelen = "1";
                        notebez = ntc.Trim();
                    }

                    bool divider = false;
                    bool punkt = notebez.EndsWith(">");
                    if (notebez.EndsWith(">"))
                    {
                        notebez = notebez.Remove(notebez.Length - 1);
                    }

                    string inxStr = string.Empty;
                    int inx = 0;
                    if (notebez.Trim().ToUpper() == Statics.PauseKey)
                    {
                        inxStr = Statics.PauseKey;
                    }
                    else
                    {
                        if (translateType == eTranslateType.NoOrderNearPrevieous)
                        {
                            inx = this.ActualHarpInstrument.SearchHarpSloyByNoteNextToPrevious(notebez, slotPreview);
                        }
                        else if (translateType == eTranslateType.NoOrder)
                        {
                            inx = this.ActualHarpInstrument.SearchHarpSloyByNote(notebez);
                        }
                        else if (translateType == eTranslateType.BlowDrawPushOrder)
                        {
                            inx = this.ActualHarpInstrument.SearchHarpSloyByNoteDrawPriority(notebez);
                        }
                        else if (translateType == eTranslateType.BlowDrawPushOrderNearPrevious)
                        {

                        }
                        inxStr = inx.ToString();
                    }

                    string newcmd = string.Empty;
                    string note = string.Empty;
                    string duration = string.Empty;
                    if (punkt)
                    {
                        note = $@"{inxStr}{Statics.DotUpKey}";
                        duration = divider ? $@"{Statics.Divider}{notelen}" : $@"{notelen}";

                        newcmd = (divider)
                            ? $@"{inxStr}{Statics.DotUpKey}{Statics.HarpAttributeDivider}{Statics.Divider}{notelen}{Statics.HarpNotesDivider}"
                            : $@"{inxStr}{Statics.DotUpKey}{Statics.HarpAttributeDivider}{notelen}{Statics.HarpNotesDivider}";

                    }
                    else
                    {
                        note = $@"{inxStr}";
                        duration = divider ? $@"{Statics.Divider}{notelen}" : $@"{notelen}";

                        newcmd = (divider)
                            ? $@"{inxStr}{Statics.HarpAttributeDivider}{Statics.Divider}{notelen}{Statics.HarpNotesDivider}"
                            : $@"{inxStr}{Statics.HarpAttributeDivider}{notelen}{Statics.HarpNotesDivider}";
                    }
                    var nt1 = new Notes(notebez, note, duration);
                    //Bei minValue ist die Note ausserhalb des HarpArrays
                    if (inx <= int.MinValue)
                    {
                        nt1._notetype = eNoteType.failnote;
                    }
                    else if (inxStr == Statics.PauseKey)
                    {
                        nt1._notetype = eNoteType.pause;
                    }
                    else
                    {
                        nt1._notetype = eNoteType.note;
                    }
                    songNotesList.Add(nt1);
                    slotPreview = inx;
                }                
            }
            return songNotesList;
        }

        public string getCommandString(string key, string notestr)
        {
            if (notestr.ToUpper().StartsWith(key))
            {
                return notestr.Substring(notestr.IndexOf(key) + key.Length);
            }
            return string.Empty;
        }
        public double getCommandDouble(string key, string notestr)
        {
            if (notestr.ToUpper().StartsWith(key))
            {
                string str = notestr.Substring(notestr.IndexOf(key) + key.Length);
                return StaticFunctionsClass.ToDoubleDef(str, 0);
            }
            return 0;
        }

        public double getCommandFractional(string key, string notestr)
        {
            if (notestr.ToUpper().StartsWith(key))
            {
                string str = notestr.Substring(notestr.IndexOf(key) + key.Length);
                if(str.Contains("/"))
                {
                    string[] zn = str.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                    int z = StaticFunctionsClass.ToIntDef(zn[0], 0);
                    int n = StaticFunctionsClass.ToIntDef(zn[1], 1);
                    return (double)z / (double)n;
                }
                return StaticFunctionsClass.ToDoubleDef(str, 0);
            }
            return 0;
        }

        public double getCommandInt(string key, string notestr)
        {
            if (notestr.ToUpper().StartsWith(key))
            {
                string str = notestr.Substring(notestr.IndexOf(key) + key.Length);
                return StaticFunctionsClass.ToIntDef(str, 0);
            }
            return 0;
        }


        public Song TranslateDefinition2SongNotesList(string[] cmd, int rowOffset, eTranslateType translateType)
        {
            this.ActualHarpInstrument.InitNotes();

            SongDefinition._songTitle = string.Empty;
            SongDefinition._songInstrument = string.Empty;
            SongDefinition._songTonality = string.Empty;

            foreach (string notesStr in cmd)
            {
                string notes = notesStr.Replace("  ", " ");
                if(notes.StartsWith(Statics.SongTitleKey))       SongDefinition._songTitle       = getCommandString(Statics.SongTitleKey, notes);
                if (notes.StartsWith(Statics.SongInstrumentKey)) SongDefinition._songInstrument  = getCommandString(Statics.SongInstrumentKey, notes);
                if (notes.StartsWith(Statics.SongTonalityKey))   SongDefinition._songTonality    = getCommandString(Statics.SongTonalityKey, notes);    
            }
            return SongDefinition;
        }


        public string TranslateSongNotesList2HarpText(bool withComments)
        {
            var txt = new StringBuilder();
            txt.Append(string.IsNullOrEmpty(SongDefinition.SongTitle) ?     string.Empty : $@"{ SongDefinition.SongTitle}{Environment.NewLine}");
            txt.Append(string.IsNullOrEmpty(SongDefinition.SongIntrument) ? string.Empty : $@"{ SongDefinition.SongIntrument}{Environment.NewLine}");

            foreach (var nt in SongNotesList)
            {
                if (nt._note == Environment.NewLine)
                {
                    txt.Append(Environment.NewLine);
                    continue;
                }
                else if (nt._note == Statics.TaktKey)
                {
                    txt.Append($@"{Statics.TaktKey}{Statics.HarpNotesDivider}");
                    continue;
                }
                else if (nt._note == Statics.CommentKey)
                {
                    if (withComments)
                    {
                        txt.Append($@"{nt._value}");
                    }
                    continue;
                }
                
                if ((nt._notetype == eNoteType.note) || (nt._notetype == eNoteType.failnote))
                {
                    txt.Append($@"{nt._note}{Statics.HarpAttributeDivider}{nt._value}{Statics.HarpNotesDivider}");
                }
                else if (nt._notetype == eNoteType.command)
                {
                    txt.Append($@"{nt._note}{Statics.HarpAttributeDivider}{nt._value}{Environment.NewLine}");
                }
            }
            return txt.ToString();
        }
        public string TranslateABC(string[] cmd, int rowOffset)
        {
            return this.ActualHarpInstrument.TranslateABC(cmd,rowOffset);
        }
        public string TranslateBack(string[] cmd,int rowOffset)
        {            
            return this.ActualHarpInstrument.TranslateBack(cmd,rowOffset);
        }

        public string RemoveUselessCharacters(string cmd)
        {
            string str = cmd.Trim().Replace("\n","").Replace("\r","");
            return str;
        }

        public bool IsNotANote(string note)
        {
            string pnote = note.Trim().ToUpper();
            return(pnote.Contains(Statics.SongTempoKey.ToUpper()) 
                || pnote.Contains(Statics.SongVolumeKey.ToUpper())
                || pnote.Contains(Statics.SongInstrumentKey.ToUpper())
                || pnote.Contains(Statics.SongTonalityKey.ToUpper())
                );
        }

        public void ClearPlayHarp()
        {
            if (playHarp != null)
            {
                playHarp.Clear();
            }
            playHarp = new PlayHarpClass();
            
        }

        

        public string CreatePlayHarp(Control parent, Control songparent, string cmdToPlay)
        {
            var sb = new StringBuilder();
            string cmd = RemoveUselessCharacters(cmdToPlay);
            string[] notes =  cmd.Split(Statics.HarpNotesDivider.ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
            int nnotes = 0;
            double unitlength = 1; //ToDo
            parent.Visible = false;
            playHarp = new PlayHarpClass();
           
            playHarp.SetIntrument(sa, instrument, SelectedHarp);
            foreach (string note in notes)
            {     
                if(IsNotANote(note)) continue;
                nnotes++;
                string[] noteattributes = note.Split(Statics.HarpAttributeDivider.ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                string cstr = noteattributes[0].Trim();
                if(note.Contains("-108"))
                {
                    Console.WriteLine();
                }
                string noteatt = string.Empty;
                AirSlotAttributesClass slot = new AirSlotAttributesClass();
                slot.BreathDirection = eBreathDirection.blow;
                
                if (noteattributes.Length == 2)
                {
                    noteatt = noteattributes[1];
                }
                if(cstr.EndsWith(Statics.DotUpKey)) 
                {
                    cstr = cstr.Remove(cstr.Length-1,1);
                }

                if((cstr.Length > 3)&&(cstr.StartsWith(Statics.DrawString)))
                {
                    //z.b. -108

                    //cstr = $@"{Statics.SilderString}{cstr.Substring(0, 1)}{cstr.Substring(3)}";
                    slot.BreathDirection = eBreathDirection.drawPushed;
                    cstr = $@"{cstr.Substring(0, 1)}{cstr.Substring(2)}";
                    
                }
                else if ((cstr.Length > 2) && (!cstr.StartsWith(Statics.DrawString)))
                {
                    //z.b. 108


                    //cstr = $@"{Statics.SilderString}{cstr.Substring(2)}";
                    slot.BreathDirection = eBreathDirection.blowPushed;
                   
                    int cnr = StaticFunctionsClass.ToIntDef(cstr, 0);
                    cstr = $@"{cstr.Substring(1)}";
                    slot.BreathDirection = eBreathDirection.blowPushed;                    
                }
                else if(cstr.StartsWith("-"))
                {
                    slot.BreathDirection = eBreathDirection.draw;
                }

                sb.Append($@"{cstr}{Statics.HarpNotesDivider}{Statics.HarpNotesImageSpace} ");
                if (cstr == "|") slot.Slot = -999;
                else if (cstr.ToUpper() == "P")
                {
                    slot.Slot = 0;
                }
                else
                {
                    slot.Slot = StaticFunctionsClass.ToIntDef(cstr, 0);
                }
                slot.SetDelay(noteatt);
                var x = ActualHarpInstrument.InstrumentNotesDefinition;
                foreach (var y in x.Keys)
                {
                    if ((y.Slot == Math.Abs(slot.Slot)) && (y.BreathDirection == slot.BreathDirection))
                    {
                        slot.NoteStr = y.NoteStr;
                    }
                }
                slot.UnitLength = unitlength;
                playHarp.CreateNote(parent,this, slot, noteatt);
            }
            parent.Visible = true;
            return sb.ToString();
        }

        

       
        /*
        public int GetHarpSlotnDiff(AirSlotAttributesClass HarpSlot)
        {
            return this.ActualHarpInstrument.GetHarpSlotnDiff(HarpSlot,ReferenceHarpInstrument);
        }
        */
        public byte Play(AirSlotAttributesClass HarpSlot, SimpleApi sa)
        {
            sa.SetTranspose(Transpose);
            //return this.ActualHarpInstrument.Play(HarpSlot,sa,ReferenceHarpInstrument);
            return this.ActualHarpInstrument.Play(HarpSlot, sa);
        }

        public void PlayOff(AirSlotAttributesClass HarpSlot, SimpleApi sa)
        {
            sa.SetTranspose(Transpose);
            //this.ActualHarpInstrument.PlayOff(HarpSlot,sa,ReferenceHarpInstrument);
            this.ActualHarpInstrument.PlayOff(HarpSlot, sa);
        }
    }
}
