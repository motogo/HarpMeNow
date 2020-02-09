using BasicClassLibrary;
using MidiOutApi.Api;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace HarpMeNow
{

    public class NoteButton : Button
    {
        public Color ColorPushed = Color.Green;
        public Color ColorReleased = Color.LightGray;
        public NoteButton()
        {

        }
    }

    public class AirSlotAttributesClass
    {
        public double RefDelay { get; set; }
        public int Slot { get; set; }
        public double Delay { get; set; }
        public double UnitLength { get; set; }
        public string DelayStr { get; set; }
        public string NoteStr { get; set; }
        public eNoteType Notetype { get; set; }

        public eBreathDirection BreathDirection { get; set; }

        public AirSlotAttributesClass()
        {
             RefDelay = 1;
             Slot = 0;
             Delay = 1;
             DelayStr = "1";
             NoteStr = "";
             UnitLength = 1.0;
             Notetype = eNoteType.note;
             BreathDirection = eBreathDirection.blow;
        }
        public AirSlotAttributesClass(int slot, eBreathDirection breathDirection)
        {
            BreathDirection = breathDirection;
            Slot = slot;
           
        }

        public AirSlotAttributesClass(int slot, eBreathDirection breathDirection, string noteStr)
        {
            BreathDirection = breathDirection;
            Slot = slot;
            NoteStr = noteStr;
        }

        public void SetDelay(string delay)
        {
            DelayStr = delay.StartsWith("/") ? $@"1{delay}" : delay;
                       
            if(DelayStr.Contains("/"))
            {
                string[] zt = DelayStr.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                int z = StaticFunctionsClass.ToIntDef(zt[0], 0);
                int t = StaticFunctionsClass.ToIntDef(zt[1], 1);
                Delay = RefDelay * (((double)z) / ((double)t));
            }
            else if (!string.IsNullOrEmpty(DelayStr))
            {
                double dl = StaticFunctionsClass.ToDoubleDef(DelayStr,1);
                Delay = RefDelay * dl;
            }
            else
            {
                Delay = 1;
            }
            Delay *= Statics.NoteDelayFactor;
        }
        public void SetDelay(string noteDelay, double delayDefinition)
        {
            
            DelayStr = noteDelay.StartsWith("/") ? $@"1{noteDelay}" : noteDelay;
            RefDelay = 120.0 * (120.0 / delayDefinition); 
            if (DelayStr.Contains("/"))
            {
                string[] zt = DelayStr.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                int z = StaticFunctionsClass.ToIntDef(zt[0], 0);
                int t = StaticFunctionsClass.ToIntDef(zt[1], 1);
                Delay = RefDelay * (((double)z) / ((double)t));
            }
            else if (!string.IsNullOrEmpty(DelayStr))
            {
                int z = StaticFunctionsClass.ToIntDef(DelayStr, 1);
                Delay = RefDelay * z;
            }
            else
            {
                Delay = RefDelay;
            }
        }
    }

    public class AirSlotClass
    {
        public NoteButton slot;
        public Button slotUpper;
        public Button slotLeft;
        public RichTextBox SongText;
        public NoteClass note;
        SimpleApi sa = null;
        Color blowColor = Color.Green;
        Color drawColor = Color.Red;
        public bool writeNoteToText = false;
        int fullnotetime = 500;
        Stopwatch timePlayed = new Stopwatch();
        public KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> SlotDefinition
        {
            get
            {
                return (KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass>)slot.Tag;
            }
        }
        public AirSlotClass(Control parent, Control SongTextControl, KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> ins, SimpleApi simpleApi)
        {
            SongText = (RichTextBox)SongTextControl;
            slotUpper = new Button();
            slotUpper.Left = (ins.Value.HarpSlot * (Statics.SlotButtonWitdh+2)) + 8;
            slotUpper.Top = 16;
            slotUpper.Width = 48;
            slotUpper.Height = 24;
            slotUpper.Parent = parent;
            slotUpper.BackColor = Color.Bisque;
            slotUpper.TextAlign = ContentAlignment.MiddleCenter;
            slotUpper.Text = (ins.Value.HarpSlot).ToString();

            slot = new NoteButton();

            slot.Left = (ins.Value.HarpSlot * (Statics.SlotButtonWitdh+2)) + 8;

            if (ins.Value.HarpSlot == 1)
            {
                slotLeft = new Button();
                slotLeft.Enabled = false;
                slotLeft.Parent = parent;
                slotLeft.BackColor = Color.Bisque;

                slotLeft.Left = 2;
                slotLeft.Height = 24;
                slotLeft.Width = 54;
            }


            if (ins.Key.BreathDirection == eBreathDirection.blow)
            {
                if (ins.Value.HarpSlot == 1)
                {
                    slotLeft.Text = "blow";
                    slotLeft.Top = 28 + slotUpper.Height;
                }
                slot.Top = 16 + slotUpper.Height;
                slot.MouseDown += Slot_MouseDownBlow;
                slot.ColorPushed = blowColor;
            }
            else if (ins.Key.BreathDirection == eBreathDirection.draw)
            {
                if (ins.Value.HarpSlot == 1)
                {
                    slotLeft.Text = "draw";
                    slotLeft.Top = 48 + 28 + slotUpper.Height;
                }
                slot.Top = 48 + 16 + slotUpper.Height;
                slot.MouseDown += Slot_MouseDownDraw;
                slot.ColorPushed = drawColor;
            }
            else if (ins.Key.BreathDirection == eBreathDirection.blowPushed)
            {
                if (ins.Value.HarpSlot == 1)
                {
                    slotLeft.Text = "blow-p";
                    slotLeft.Top = 2 * 48 + 28 + slotUpper.Height;
                }
                slot.Top = 2 * 48 + 16 + slotUpper.Height;
                slot.MouseDown += Slot_MouseDownBlow;
                slot.ColorPushed = blowColor;
            }
            else if (ins.Key.BreathDirection == eBreathDirection.drawPushed)
            {
                if (ins.Value.HarpSlot == 1)
                {
                    slotLeft.Text = "draw-p";
                    slotLeft.Top = 3 * 48 + 28 + slotUpper.Height;
                }
                slot.Top = 3 * 48 + 16 + slotUpper.Height;
                slot.MouseDown += Slot_MouseDownDraw;
                slot.ColorPushed = drawColor;
            }
            slot.Width = Statics.SlotButtonWitdh; //48
            slot.Height = 48;
            slot.Parent = parent;
            slot.BackColor = Color.LightGray;
            slot.TextAlign = ContentAlignment.MiddleCenter;

            slot.Tag = ins;

            slot.Text = $@"{ins.Value.Note}";
            sa = simpleApi;

            slot.MouseUp += Slot_MouseUp;

        }
        /*
        public AirSlotClass(Control parent, Control SongTextControl, int i, HarpInstrumentClass harp, string noteNameBlow, string noteNameDraw, SimpleApi simpleApi)
        {
            SongText = (RichTextBox)SongTextControl;
            slotUpper = new Button(); // SeControlsLib.HotSpot();
            slotUpper.Left = (i * 50) + 8;
            slotUpper.Top = 16;
            slotUpper.Width = 48;
            slotUpper.Height = 24;
            slotUpper.Parent = parent;
            slotUpper.BackColor = Color.LightGray;
            slotUpper.TextAlign = ContentAlignment.MiddleCenter;
            slotUpper.Text = (i + 1).ToString();

            slot = new NoteButton(); // SeControlsLib.HotSpot();
            slot.Left = (i * (Statics.SlotButtonWitdh+2)) + 8;
            slot.Top = 16 + slotUpper.Height;
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
        */
        public void SetNoteToText(Control SongTextControl, bool write, int fullnotems)
        {
            SongText = (RichTextBox)SongTextControl;
            writeNoteToText = write;
            fullnotetime = fullnotems;
        }
        private void Slot_MouseDownBlow(object sender, MouseEventArgs e)
        {
            var hs = (Button)sender;
            var nc = (KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass>)hs.Tag;
            Application.DoEvents();
            hs.BackColor = Color.Green;

            sa.NoteOn(nc.Value.GetNoteByte(), 65, 0);
            if (writeNoteToText)
            {
                timePlayed.Restart();
                SongText.AppendText($@"{nc.Value.Note}");
            }
            Application.DoEvents();
            Thread.Sleep(100);
        }
        private void Slot_MouseDownDraw(object sender, MouseEventArgs e)
        {
            var hs = (Button)sender;
            var nc = (KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass>)hs.Tag;
            Application.DoEvents();

            hs.BackColor = Color.Red;

            sa.NoteOn(nc.Value.GetNoteByte(), 65, 0);
            if (writeNoteToText)
            {
                timePlayed.Restart();
                SongText.AppendText($@"{nc.Value.Note}");
            }
            Application.DoEvents();
            Thread.Sleep(100);
        }
        private void Slot_MouseUp(object sender, MouseEventArgs e)
        {
            var hs = (Button)sender;
            hs.BackColor = Color.LightGray;
            var nc = (KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass>)hs.Tag;

            if (e.Button == MouseButtons.Left)
            {
                sa.NoteOff(nc.Value.GetNoteByte());
            }
            else
            {
                sa.NoteOff(nc.Value.GetNoteByte());
            }
            if (writeNoteToText)
            {
                timePlayed.Stop();
                if (timePlayed.ElapsedMilliseconds > (4 * fullnotetime))
                {
                    SongText.AppendText($@"4 ");
                }
                else if (timePlayed.ElapsedMilliseconds > (3 * fullnotetime))
                {
                    SongText.AppendText($@"3 ");
                }
                else if (timePlayed.ElapsedMilliseconds > (2 * fullnotetime))
                {
                    SongText.AppendText($@"2 ");
                }
                else if (timePlayed.ElapsedMilliseconds > (fullnotetime))
                {
                    SongText.AppendText($@" ");
                }
                else if (timePlayed.ElapsedMilliseconds > (fullnotetime / 2))
                {
                    SongText.AppendText($@"1/2 ");
                }
                else if (timePlayed.ElapsedMilliseconds > (fullnotetime / 4))
                {
                    SongText.AppendText($@"1/4 ");
                }
                else if (timePlayed.ElapsedMilliseconds > (fullnotetime / 8))
                {
                    SongText.AppendText($@"1/8 ");
                }
                else if (timePlayed.ElapsedMilliseconds > (fullnotetime / 16))
                {
                    SongText.AppendText($@"1/16 ");
                }
                else
                {
                    SongText.AppendText($@" ");
                }

            }
        }

    }
}
