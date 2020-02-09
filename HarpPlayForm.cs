using BasicClassLibrary;
using Enums;
using SharedStorages;
using System;
using System.Text;
using System.Windows.Forms;

namespace HarpMeNow
{
    public partial class HarpPlayForm : Form
    {
        enum eSongFormat { simple, abc }
        string sharedFolder;

        HarpPlayFormDesign mw = new HarpPlayFormDesign();
        SharedStorage ss = new SharedStorage();

        

        public HarpPlayForm()
        {
            InitializeComponent();
            
            LanguageClass.Instance().RegisterChangeNotifiy(languageNotify_OnRaiseHandler);            
        }

        private void languageNotify_OnRaiseHandler(object sender, LanguageChangedEventArgs k)
        {
            SetLanguageControls();
        }

        

        public void SetLanguageControls()
        {
            
            hsCloseApp.Text = LanguageClass.Instance().GetString("Close");
        }

        private void LoadMainFormDesign()
        {
            try
            {
                ss.SharedFolder = sharedFolder;
                ss.StorageName = this.Name;
                ss.DestroyWhenDisposed = false;
                var mw2 = (HarpPlayFormDesign)ss["FormData"];
                if (mw2 != null)
                {
                    mw = mw2;

                    if (mw != null)
                    {
                      
                       
                        
                    }
                    else
                    {
                       
                      
                        
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void HarpPlayForm_Load(object sender, EventArgs e)
        {
            this.Text = "Harp Play";
            SetPlayUI();
        }

        public void SetPlayUI()
        {
            FormInstances.Instance().hc.CancelPlay = true;
            hsPausePlaying.Marked = false;
            hsPausePlaying.Visible = false;
            hsCancel.Visible = false;
            hsPlay.Visible = true;
        }

        private void hsCancel_Click(object sender, EventArgs e)
        {
            FormInstances.Instance().hc.CancelPlay = true;
            hsPausePlaying.Marked = false;
            hsPausePlaying.Visible = false;
            hsCancel.Visible = false;
            hsPlay.Visible = true;
        }

        private void hsPausePlaying_Click(object sender, EventArgs e)
        {
            FormInstances.Instance().hc.PausePlay = !FormInstances.Instance().hc.PausePlay;
        }

        private void hsCloseApp_Click(object sender, EventArgs e)
        {
            FormInstances.Instance().hc.CancelPlay = true;
            this.Visible = false;
        }

        private void RunCompleteHarpSequence()
        {
            var allnotes = new StringBuilder();            
            foreach (string line in FormInstances.Instance().harpSequenceForm.rtbSongHarp.Lines)
            {
                if (line.Trim().StartsWith("\"")) continue;
                if (line.Trim().StartsWith(Statics.CommentKey)) continue;
                allnotes.Append(line);
            }

            FormInstances.Instance().harpPlayForm.flowLayoutPanel1.Visible = false;
            FormInstances.Instance().hc.ClearPlayHarp();
            FormInstances.Instance().harpPlayForm.flowLayoutPanel1.Visible = true;
            string cmd = FormInstances.Instance().hc.RemoveUselessCharacters(allnotes.ToString());
            FormInstances.Instance().hc.CreatePlayHarp(this.flowLayoutPanel1, FormInstances.Instance().songSequenceForm.rtbSong, cmd);
            FormInstances.Instance().hc.PlaySequence(FormInstances.Instance().hc.RemoveUselessCharacters(cmd));
        }

        public void RunCompleteHarpSequenceFromButtons()
        {            
            this.flowLayoutPanel1.Visible = true;
            
            FormInstances.Instance().hc.PlaySequenceFromButtons(
            FormInstances.Instance().soundAttributeForm.GetVolume(), 
            FormInstances.Instance().soundAttributeForm.GetVelocity(), 
            FormInstances.Instance().soundAttributeForm.GetTranspose());
        }
        private void RunSelectedHarpSequence()
        {
            string[] cmdstr = FormInstances.Instance().harpSequenceForm.rtbSongHarp.SelectedText.Replace("\"", "\"#\"").Split(new char[] { '"' }, StringSplitOptions.RemoveEmptyEntries);
            bool comment = false;
            var sb = new StringBuilder();
            foreach (string cstr in cmdstr)
            {
                if (cstr == Statics.CommentKey) comment = !comment;
                if (!comment && cstr != Statics.CommentKey) sb.Append(cstr);
            }
            FormInstances.Instance().harpPlayForm.flowLayoutPanel1.Visible = false;
            FormInstances.Instance().hc.ClearPlayHarp();
            FormInstances.Instance().harpPlayForm.flowLayoutPanel1.Visible = true;
            string cmd = FormInstances.Instance().hc.RemoveUselessCharacters(sb.ToString());
            FormInstances.Instance().hc.CreatePlayHarp(FormInstances.Instance().harpPlayForm.flowLayoutPanel1, FormInstances.Instance().songSequenceForm.rtbSong, cmd);
            FormInstances.Instance().hc.PlaySequence(FormInstances.Instance().hc.RemoveUselessCharacters(sb.ToString()));
        }

        private void hsPlay_Click(object sender, EventArgs e)
        {
            SetIsPlayingUI();
            RunCompleteHarpSequenceFromButtons();
            hsPlay.Visible = true;
            hsCancel.Visible = false;
            hsPausePlaying.Visible = false;
        }

        public void SetIsPlayingUI()
        {
            FormInstances.Instance().hc.PausePlay = false;
            FormInstances.Instance().hc.CancelPlay = false;
            hsPausePlaying.Marked = false;
            hsPausePlaying.Visible = true;
            hsCancel.Visible = true;
            hsPlay.Visible = false;
        }

        public void SetKey(eKey key)
        {
            lblKey.Text =  EnumHelper.GetDescription(key);
        }

        private void LoadFormDesign()
        {
            /*
            try
            {
                ss.SharedFolder = sharedFolder;
                ss.StorageName = this.Name;
                ss.DestroyWhenDisposed = false;
                var mw2 = (HarpPlayFormDesign)ss["FormData"];
                if (mw2 != null)
                {
                    mw = mw2;

                    if (mw != null)
                    {

                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {

            }
            */
        }
        private void SaveFormDesign()
        {
            /*
            if ((mw != null) && (ss != null))
            {
                mw.PlainTextsize = 10;
                ss.SharedFolder = sharedFolder;
                ss.StorageName = this.Name;

                ss.AddOrUpdate("FormData", mw);
            }
            */
        }

        private void HarpPlayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFormDesign();
            e.Cancel = true;
            this.Hide();
        }
    }
}
