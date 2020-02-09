using System;
using System.Drawing;
using System.Windows.Forms;

namespace HarpMeNow
{
    public class PlayNoteButton : SeControlsLib.HotSpot // Button
    {
        public Color ColorPushed = Color.Green;
        public Color ColorReleased = Color.LightGray;
        public PlayNoteButton()
        {

        }
        

        public string Info
        {
            get
            {
                if (Tag != null)
                {
                    if (Tag.GetType() == typeof(AirSlotAttributesClass))
                    {
                        var t = (AirSlotAttributesClass)Tag;
                        return $@"{base.ToString()}->Delay:{t.Delay}->RefDelay:{t.RefDelay}";
                    }
                }
                return $@"Slot:{Text}";
            }
        }

    }

    public class PlayHarpNoteAttributesClass
    {
        public int Slot = 0;
        public int SlotPush = 0;
        public eBreathDirection BreathDirection = eBreathDirection.blow;
        public PlayHarpNoteAttributesClass(int slot, eBreathDirection breathDirection)
        {
            BreathDirection = breathDirection;
            Slot = slot;
        }
    }

    public static class PlayHarpNoteFactory
    {
        
    }

    public class PlayHarpNoteClass
    {
        public PlayNoteButton slot;
        public Button slotUpper;
        public Button slotLeft;
        public RichTextBox SongText;
        public NoteClass note;                           
        HarpClass harpClass = null;
        public PlayHarpNoteClass()
        {
        }
        public PlayHarpNoteClass CreateNote(Control parent, AirSlotAttributesClass txt, Image img, HarpClass hc)
        {            
            harpClass               = hc;
            slot                    = new PlayNoteButton();
            slot.Enabled            = true;
            slot.Parent             = parent;
            slot.BackColor          = Color.Bisque;
            slot.Font               = new Font("Consolas",10,FontStyle.Bold);
            slot.TextAlign          = ContentAlignment.BottomLeft;
            slot.ToolTipActive      = true;
            slot.ToolTipText        = $@"Note:{txt.NoteStr} ({txt.DelayStr}){Environment.NewLine}Slot:{txt.Slot}{Environment.NewLine}Delay:{txt.Delay}{Environment.NewLine}RefDelay:{txt.RefDelay}";                                  
            slot.Width              = Statics.PlayButtonWitdh;
            slot.Height             = Statics.PlayButtonHeight;
            slot.Text               = txt.Slot.ToString();
            slot.Image              = img;
            slot.ImageHover         = img;
            
            if (txt.BreathDirection == eBreathDirection.blow)
            {
                slot.BackColor = Color.LightGreen;
            }
            else if(txt.BreathDirection == eBreathDirection.draw)
            {
                slot.BackColor = Color.LightSalmon;
            }
            else if (txt.BreathDirection == eBreathDirection.blowPushed)
            {
                slot.BackColor = Color.LightGreen;
                slot.ForeColor = Color.Yellow;
            }
            else if (txt.BreathDirection == eBreathDirection.drawPushed)
            {
                slot.BackColor = Color.LightSalmon;
                slot.ForeColor = Color.Yellow;                
            }
            slot.BackColorHover     = slot.BackColor;
            slot.BorderColorHover   = Color.Blue;
            slot.HoverStyle         = SeControlsLib.frameStyle.thickRectangle;
            slot.FlatStyle          = FlatStyle.Flat;
            slot.Tag                = txt;
            slot.MouseDown          += Slot_MouseDown;
            slot.MouseUp            += Slot_MouseUp;
            return this;
        }
        public PlayHarpNoteClass CreatePause(Control parent, AirSlotAttributesClass txt, Image img, HarpClass hc)
        {
            harpClass               = hc;
            slot                    = new PlayNoteButton();
            slot.Enabled            = true;
            slot.Parent             = parent;
            slot.BackColor          = Color.Bisque;
            slot.Font               = new Font("Consolas", 10, FontStyle.Bold);
            slot.TextAlign          = ContentAlignment.BottomLeft;
            slot.ToolTipActive      = true;
            slot.ToolTipText        = $@"Note:{txt.NoteStr} ({txt.DelayStr}){Environment.NewLine}Slot:{txt.Slot}";
            slot.Width              = Statics.PlayButtonWitdh;
            slot.Height             = Statics.PlayButtonHeight;            
            slot.Text               = txt.Slot.ToString();
            slot.Image              = img;
            slot.ImageHover         = img;
            slot.BackColor          = Color.LightGray;
            slot.Text               = "P";
            slot.BackColorHover     = slot.BackColor;
            slot.BorderColorHover   = Color.Blue;
            slot.HoverStyle         = SeControlsLib.frameStyle.thickRectangle;
            slot.FlatStyle          = FlatStyle.Flat;
            slot.Tag                = txt;
            
            return this;
        }

        public PlayHarpNoteClass CreateTakt(Control parent, AirSlotAttributesClass txt, HarpClass hc)
        {
            harpClass               = hc;
            slot                    = new PlayNoteButton();
            slot.Enabled            = true;
            slot.Parent             = parent;
            slot.BackColor          = Color.Bisque;
            slot.Font               = new Font("Consolas", 10, FontStyle.Bold);
            slot.TextAlign          = ContentAlignment.BottomLeft;
            slot.ToolTipActive      = false;
            slot.ToolTipText        = string.Empty;
            slot.Image              = null;
            slot.ImageHover         = null;
            slot.ImageAlign         = ContentAlignment.MiddleRight;
            slot.Width              = Statics.TabButtonWitdh;
            slot.Height             = Statics.PlayButtonHeight;
            slot.Text               = string.Empty;
            slot.BackColor          = Color.Gray;
            slot.BackColorHover     = slot.BackColor;
            slot.BorderColorHover   = Color.Blue;
            slot.HoverStyle         = SeControlsLib.frameStyle.thickRectangle;
            slot.FlatStyle          = FlatStyle.Flat;
            slot.Tag                = txt;
            
            return this;
        }

        private void Slot_MouseDown(object sender, MouseEventArgs e)
        {
            AirSlotAttributesClass note = (AirSlotAttributesClass) this.slot.Tag;
            harpClass.Play(Math.Abs(note.Slot),note.BreathDirection, 1000);
        }

        private void Slot_MouseUp(object sender, MouseEventArgs e)
        {                      
        }
      
    }
}
