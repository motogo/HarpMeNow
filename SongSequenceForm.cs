using BasicClassLibrary;
using SharedStorages;
using System;
using System.IO;
using System.Windows.Forms;

namespace HarpMeNow
{
    public partial class SongSequenceForm : Form
    {
        string sharedFolder = $@"{Application.StartupPath}\Temp\";
        SongSequenceFormDesign mw = new SongSequenceFormDesign();
        SharedStorage ss = new SharedStorage();
        eSongFormat songFormat = eSongFormat.simple;       
        public SongSequenceForm()
        {
            InitializeComponent();                        
            LanguageClass.Instance().RegisterChangeNotifiy(languageChanged);
        }
               
        public void SetLanguageControls()
        {
            
            hsCloseApp.Text = LanguageClass.Instance().GetString("Close");
        }
        private void LoadFormDesign()
        {
            try
            {
                ss.SharedFolder = sharedFolder;
                ss.StorageName = this.Name;
                ss.DestroyWhenDisposed = false;
                var mw2 = (SongSequenceFormDesign)ss["FormData"];
                if (mw2 != null)
                {
                    mw = mw2;
                    if (mw != null)
                    {
                        txtFullNoteMS.Text                  = mw.txtFullNoteMS;
                        ofdSong.FileName                    = mw.SongNotationFile;
                        this.Text                           = $@"HarpSequence File:{ofdSong.FileName}";
                        cbPlayedNoteAppendToText.Checked    = mw.PlayedNoteAppendToText;
                        txtRowOffset.Text                   = mw.txtRowOffset;
                    }
                    else
                    {
                        txtFullNoteMS.Text = "1000";
                        txtRowOffset.Text = "0";
                        cbPlayedNoteAppendToText.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void SaveFormDesign()
        {
            if ((mw != null) && (ss != null))
            {
                mw.txtFullNoteMS            = txtFullNoteMS.Text;
                mw.SongNotationFile         = ofdSong.FileName;
                mw.PlayedNoteAppendToText   = cbPlayedNoteAppendToText.Checked;
                mw.txtRowOffset             = txtRowOffset.Text;
                               
                ss.SharedFolder = sharedFolder;
                ss.StorageName = this.Name;

                ss.AddOrUpdate("FormData", mw);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Song Sequence";
            cbTranslateType.Items.Add(new TranslateOrder(eTranslateType.BlowDrawPushOrder));
            cbTranslateType.Items.Add(new TranslateOrder(eTranslateType.BlowDrawPushOrderNearPrevious));
            cbTranslateType.Items.Add(new TranslateOrder(eTranslateType.NoOrder));
            cbTranslateType.Items.Add(new TranslateOrder(eTranslateType.NoOrderNearPrevieous));
            cbTranslateType.SelectedIndex = 0;
            
            LoadFormDesign();
            if (File.Exists(ofdSong.FileName))
            {
                rtbSong.LoadFile(ofdSong.FileName, RichTextBoxStreamType.PlainText);
                if (ofdSong.FileName.ToUpper().EndsWith(".ABC")) songFormat = eSongFormat.abc;
                FormInstances.Instance().harpSequenceForm.SetSongText(FormInstances.Instance().TranslateSongNotationToHarpNotation(rtbSong.Lines, StaticFunctionsClass.ToIntDef(txtRowOffset.Text,0),songFormat,((TranslateOrder)cbTranslateType.SelectedItem).TranslateType));
            }
        }

        private void languageChanged(object sender, LanguageChangedEventArgs k)
        {
            SetLanguageControls();
        }

        public void SetNewSong(string txt)
        {
            rtbSong.Clear();
            rtbSong.Text = txt;
            rtbSong.Focus();
            rtbSong.SelectionStart = rtbSong.Text.Length;
            ofdSong.FileName = $@"NewSong{DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")}.not";
            this.Text = ofdSong.FileName;
        }
        public void SaveSong()
        {
            sfdSong.FileName = ofdSong.FileName;
            if (sfdSong.ShowDialog() == DialogResult.OK)
            {
                rtbSong.SaveFile(sfdSong.FileName, RichTextBoxStreamType.PlainText);
                this.Text = $@"Song sequence file:{sfdSong.FileName}";
                ofdSong.FileName = sfdSong.FileName;
            }
        }
        private void LoadSong()
        {
            ofdSong.InitialDirectory = Application.StartupPath + "\\songs\\";
            if (ofdSong.ShowDialog() == DialogResult.OK)
            {
                rtbSong.LoadFile(ofdSong.FileName, RichTextBoxStreamType.PlainText);
                this.Text = $@"Song sequence File:{ofdSong.FileName}";
                if (ofdSong.FileName.ToUpper().EndsWith(".ABC")) songFormat = eSongFormat.abc;
                FormInstances.Instance().TranslateSongNotationToHarpNotation(rtbSong.Lines, StaticFunctionsClass.ToIntDef(txtRowOffset.Text, 0), songFormat, ((TranslateOrder)cbTranslateType.SelectedItem).TranslateType);
            }
        }        
        private void cmsSongNotation_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsmiLoadSong)
            {
                LoadSong();
            }
            else if (e.ClickedItem == tsmiSaveSong)
            {
                cmsSongNotation.Close();
                SaveSong();
            }
            else if (e.ClickedItem == tsmiTranslateNotationToHarpSequence)
            {
                FormInstances.Instance().TranslateSongNotationToHarpNotation(rtbSong.Lines, StaticFunctionsClass.ToIntDef(txtRowOffset.Text, 0),songFormat, ((TranslateOrder)cbTranslateType.SelectedItem).TranslateType);
            }
            else if (e.ClickedItem == tsmiTranslatoToHarpAndPlay)
            {
                FormInstances.Instance().TranslateSongNotationToHarpNotation(rtbSong.Lines, StaticFunctionsClass.ToIntDef(txtRowOffset.Text, 0),songFormat, ((TranslateOrder)cbTranslateType.SelectedItem).TranslateType);
                FormInstances.Instance().RunCompleteHarpSequence(FormInstances.Instance().harpSequenceForm.rtbSongHarp.Lines);
            }
            else if (e.ClickedItem == tsmiEditMode)
            {
                rtbSong.ContextMenuStrip = cmsInsertNotes;
            }
            else if (e.ClickedItem == tsmiNewSong)
            {                
                FormInstances.Instance().NewSong();
            }
        }

        private void hsCloseApp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SongSequenceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFormDesign();
            e.Cancel = true;
            this.Hide();
        }
       
        private void trkShift_Scroll(object sender, EventArgs e)
        {
            gbShift.Text = $@"Shift ({(double)trkShift.Value/2.0})";
        }

        private void trkShift_MouseUp(object sender, MouseEventArgs e)
        {
            FormInstances.Instance().hc.ShiftNote = trkShift.Value;
        }

        private void trkShift_KeyUp(object sender, KeyEventArgs e)
        {
            FormInstances.Instance().hc.ShiftNote = trkShift.Value;
        }
    }
}
