using BasicClassLibrary;
using SharedStorages;
using System;
using System.Text;
using System.Windows.Forms;


namespace HarpMeNow
{


    public partial class HarpSequenceForm : Form
    {
        string sharedFolder = $@"{Application.StartupPath}\Temp\";
        HarpSequenceFormDesign mw = new HarpSequenceFormDesign();
        SharedStorage ss = new SharedStorage();        
        RemoteDataClass remoteDataClass = new RemoteDataClass();

        public HarpSequenceForm()
        {
           InitializeComponent();                        
           LanguageClass.Instance().RegisterChangeNotifiy(languageChanged);          
        }

        private void languageChanged(object sender, LanguageChangedEventArgs k)
        {
            SetLanguageControls();
        }

     
        public void SetLanguageControls()
        {
           
            hsCloseApp.Text = LanguageClass.Instance().GetString("Close");
        }

        private void PlaySingleNote(string HarpCode)
        {
            int kz = StaticFunctionsClass.ToIntDef(HarpCode, 0);
            //FormInstances.Instance().hc.SetTranspose(FormInstances.Instance().Transpose);
            if (kz >= 0)
            {
                if (kz < 100)
                {
                    FormInstances.Instance().hc.Play(kz, eBreathDirection.blow, 1000);
                }
                else
                {
                    FormInstances.Instance().hc.Play(kz - 100, eBreathDirection.blowPushed, 1000);
                }
            }
            else
            {
                if (kz > -100)
                {
                    FormInstances.Instance().hc.Play(Math.Abs(kz), eBreathDirection.draw, 1000);
                }
                else
                {
                    FormInstances.Instance().hc.Play(Math.Abs(kz + 100), eBreathDirection.drawPushed, 1000);
                }
            }
        }
        
        
        private void TransferToPlainHarpNotes(string[] cmdToPlay)
        {
            var sb = new StringBuilder();
            foreach (string cmdStr in cmdToPlay)
            {
                if (cmdStr.Trim().StartsWith("\"")) continue;
                if (cmdStr.Trim().StartsWith(Statics.CommentKey)) continue;
                sb.Append(cmdStr);
            }

            remoteDataClass.Cancel = false;
                                    
            FormInstances.Instance().harpPlayForm.flowLayoutPanel1.Visible = false;
            FormInstances.Instance().hc.ClearPlayHarp();
            FormInstances.Instance().harpPlayForm.flowLayoutPanel1.Visible = true;
            FormInstances.Instance().hc.CreatePlayHarp(FormInstances.Instance().harpPlayForm.flowLayoutPanel1, FormInstances.Instance().songSequenceForm.rtbSong, FormInstances.Instance().hc.RemoveUselessCharacters(sb.ToString()));
        }
        
        private void LoadFormDesign()
        {
            try
            {
                ss.SharedFolder = sharedFolder;
                ss.StorageName  = this.Name;
                ss.DestroyWhenDisposed = false;
                var mw2 = (HarpSequenceFormDesign)ss["FormData"];
                if (mw2 != null)
                {
                    mw = mw2;

                    if (mw != null)
                    {
                        txtHarpSlotNr.Text = mw.SlotTxt;
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
        private void SaveFormDesign()
        {
            if ((mw != null) && (ss != null))
            {
                mw.SlotTxt                  = txtHarpSlotNr.Text;
                ss.SharedFolder             = sharedFolder;
                ss.StorageName              = this.Name;

                ss.AddOrUpdate("FormData", mw);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text           = "Harp Sequence";
            LoadFormDesign(); 
        }

        public void SaveHarpSong()
        {
            if (sfdHarpSong.ShowDialog() == DialogResult.OK)
            {
                rtbSongHarp.SaveFile(sfdHarpSong.FileName, RichTextBoxStreamType.PlainText);
               
            }
        }
        private void LoadHarpSong()
        {
            ofdHarpSong.InitialDirectory = Application.StartupPath + "\\songs\\";
            if (ofdHarpSong.ShowDialog() == DialogResult.OK)
            {
                rtbSongHarp.LoadFile(ofdHarpSong.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        public void SetSongText(string text)
        {
            rtbSongHarp.Clear();
            rtbSongHarp.Text = text;
        }
        
        private void cmsHarpSongNotation_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            cmsHarpSongNotation.Close();
            if (e.ClickedItem == tsmiLoadHarpSong)
            {
                LoadHarpSong();
            }
            else if (e.ClickedItem == tsmiSaveHarpSong)
            {
                SaveHarpSong();
            }
            else if (e.ClickedItem == tsmiPlayHarpSong)
            {
                FormInstances.Instance().RunCompleteHarpSequence(rtbSongHarp.Lines);
            }
            else if (e.ClickedItem == tsmiPlayHarpSongDelayed)
            {
                new CounterForm().ShowDialog();                
                FormInstances.Instance().RunCompleteHarpSequence(rtbSongHarp.Lines);
            }
            else if (e.ClickedItem == tsmiPlaySelectedHarpText)
            {
                FormInstances.Instance().RunSelectedHarpSequence(rtbSongHarp.SelectedText);
            }                        
        }

        private void hsPlaySingleNote_Click(object sender, EventArgs e)
        {
            PlaySingleNote(txtHarpSlotNr.Text);
        }
                        
        private void hsCloseApp_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }       

        private void HarpSequenceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFormDesign();
            e.Cancel = true;
            this.Hide();
        }

       

        private void hsPlaySingleNote_Click_1(object sender, EventArgs e)
        {           
            PlaySingleNote(txtHarpSlotNr.Text);
        }

    }
}
