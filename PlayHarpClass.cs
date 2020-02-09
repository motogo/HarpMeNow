using MidiOutApi.Api;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HarpMeNow
{

    public class PlayHarpClass
        {
            public List<PlayNoteButton> Notes = new List<PlayNoteButton>();
            
            HarpInstrumentClass harpIntrument = null;
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
            public void SetIntrument(SimpleApi saa, Instrument instrument, Harp harp)
            {
                harpIntrument = HarpInstrumentFactory.HarpDatabaeObject2HarpInstrument(harp);

                if (harpIntrument.InstrumentNotesDefinition.Count <= 0)
                {
                    return;
                }

                var inn = harpIntrument.InstrumentNotesDefinition.Keys.Select(m => m).Where(kvp => kvp.BreathDirection == eBreathDirection.blow).Select(k => k.Slot).ToList();
            }
            

            public void CreateNote(Control parent,HarpClass hc, AirSlotAttributesClass slot, string noteatt)
            {
                Image img = GetNoteImage(noteatt,slot.UnitLength);
                PlayHarpNoteClass aslot = new PlayHarpNoteClass().CreateNote(parent, slot,img,hc);
                Notes.Add(aslot.slot);
            }
            public void CreatePause(Control parent, HarpClass hc, AirSlotAttributesClass slot, string noteatt)
            {
                Image img = GetNoteImage(noteatt,slot.UnitLength);
                PlayHarpNoteClass aslot = new PlayHarpNoteClass().CreatePause(parent, slot, img, hc);
                Notes.Add(aslot.slot);
            }
            public void CreateTakt(Control parent, HarpClass hc, AirSlotAttributesClass slot, string noteatt)
            {
                Image img = null;
                var hnc = new PlayHarpNoteClass();
                PlayHarpNoteClass aslot = hnc.CreateTakt(parent, slot, hc);
                Notes.Add(aslot.slot);
            }

            public Image GetNoteImage(string noteatt, double unitlength)
            {                
                double notelength = Statics.GetNoteLength(noteatt,unitlength);
                Image im = null;
                NotesImages.Instance().images.TryGetValue(notelength, out im);
                return im;                   
            }

            public void Clear()
            {
                for (int i = 0; i < Notes.Count; i++)
                {
                    Notes[i].Dispose();
                }
            }

            private bool isEmpty()
            {
                return (Notes.Count <= 0);
            }

            public bool IsEmpty => isEmpty();
        }
    }
