using MidiOutApi.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HarpMeNow
{
    public class AirSlotsClass
    {
        public List<AirSlotClass> Slots = new List<AirSlotClass>();
        
        
        GroupBox gb = null;

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        public void DeleteSlots()
        {
            if (gb != null)
            {
                var all = GetAll(gb, typeof(NoteButton));
                foreach (NoteButton nb in all)
                {
                    Console.WriteLine(nb.Name);
                    nb.Dispose();
                }
                all = GetAll(gb, typeof(Button));
                foreach (Button nb in all)
                {
                    Console.WriteLine(nb.Name);
                    nb.Dispose();
                }
                gb.Dispose();
            }
        }

        public int Create(Control parent, Control songTextControl, SimpleApi saa, Instrument instrument, Harp harp)
        {            
            FormInstances.Instance().hc.ActualHarpInstrument = HarpInstrumentFactory.HarpDatabaeObject2HarpInstrument(harp);

            if (FormInstances.Instance().hc.ActualHarpInstrument.InstrumentNotesDefinition.Count <= 0)
            {
                return 0;
            }

            var inn = FormInstances.Instance().hc.ActualHarpInstrument.InstrumentNotesDefinition.Keys.Select(m => m).Where(kvp => kvp.BreathDirection == eBreathDirection.blow).Select(k => k.Slot).ToList();
            gb = new GroupBox();
            gb.Parent = parent;
            gb.Width = (inn.Count + 1) * (Statics.SlotButtonWitdh + 2) + 16;
            gb.Height = 500;
            gb.Left = 8;
            gb.Top = 16;
            gb.Text = string.Empty; //harp.Name;
            gb.Dock = DockStyle.Left;
            gb.Visible = true;
            //Für alle im Instrument definierten HarpSlotn wird die UI angelegt
            int witdh = 0;
            foreach (KeyValuePair<AirSlotAttributesClass, InstrumentsNotesClass> inf in FormInstances.Instance().hc.ActualHarpInstrument.InstrumentNotesDefinition)
            {
                if (inf.Key.BreathDirection == eBreathDirection.blow) witdh += 1;
                AirSlotClass aslot = new AirSlotClass(gb, songTextControl, inf, FormInstances.Instance().sa);
                
                Slots.Add(aslot);
            }

            return (witdh * (Statics.SlotButtonWitdh+2)) + 86;
        }

        public void SetNotesToText(Control songTextControl, bool write, int fullnotems)
        {
            foreach (AirSlotClass aslot in Slots)
            {
                aslot.SetNoteToText(songTextControl, write, fullnotems);
            }
        }

        public AirSlotClass GetNote(byte row)
        {
            if (row > Slots.Count) return null;
            var asc = Slots[row];
            return (asc != null) ? asc : null;
        }

        private bool isEmpty()
        {
            return (Slots.Count <= 0);
        }

        public bool IsEmpty => isEmpty();
    }
}
