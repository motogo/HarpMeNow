using BasicClassLibrary;
using MidiOutApi.Api;
using SharedStorages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HarpMeNow
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            sa = new SimpleApi();
            sharedFolder = $@"{Application.StartupPath}\temp\";
        }

        SimpleApi sa = null;
        MainFormDesign mw = new MainFormDesign();        
        SharedStorage ss  = new SharedStorage();
        public string sharedFolder;
                
        private void LoadMainFormDesign()
        {                                   
            try
            {                
                ss.SharedFolder = sharedFolder;
                ss.StorageName = "HarpMeNowMainForm";                
                ss.DestroyWhenDisposed = false;
                var mw2 = (MainFormDesign)ss["FormData"];
                if (mw2 != null)
                {
                    mw = mw2;
                    
                    if (mw != null)
                    {
                        cbHarpInstrument.SelectedIndex              = mw.cbHarpInstrumentINX;
                        cbReferenzHarpInstruments.SelectedIndex     = mw.cbRefHarpInstrumentINX;
                        cbHarpSoundInstrument.SelectedIndex         = mw.cbHarpSoundINX;
                        trkPlainTextSize.Value                      = mw.PlainTextsize;
                        trkVelocity.Value                           = mw.Velocity;
                        trkVolume.Value                             = mw.Volume;
                    }
                    else
                    {
                        cbHarpInstrument.SelectedIndex          = -1;
                        cbReferenzHarpInstruments.SelectedIndex = -1;
                        cbHarpSoundInstrument.SelectedIndex     = -1;
                        trkPlainTextSize.Value                  = 12;
                        trkVelocity.Value                       = 50;
                        trkVolume.Value                         = 10;
                    }                   
                }
            }
            catch(Exception ex)
            {                 
               
            }
        }

        private void SaveMainFormDesign()
        {
            if ((mw != null) && (ss != null))
            {   
                if(!Directory.Exists(sharedFolder)) Directory.CreateDirectory(sharedFolder);
                mw.cbHarpInstrumentINX      = cbHarpInstrument.SelectedIndex;   
                mw.cbRefHarpInstrumentINX   = cbReferenzHarpInstruments.SelectedIndex;
                mw.cbHarpSoundINX           = cbHarpSoundInstrument.SelectedIndex;
                mw.Volume                   = trkVolume.Value;
                mw.Velocity                 = trkVelocity.Value;
                mw.PlainTextsize            = trkPlainTextSize.Value;

                ss.SharedFolder = sharedFolder;
                ss.StorageName = "HarpMeNowMainForm";
                ss.AddOrUpdate("FormData", mw);
            }
        }
        private void PlaySingleNote()
        {
            int kz = StaticFunctionsClass.ToIntDef(txtHarpSlotNr.Text,0);
            if(kz >= 0)
            {
               if(kz < 100)
               {
                 hc.Play(kz,eBreathDirection.blow,1000);
               }
               else
               {
                 hc.Play(kz-100,eBreathDirection.blowPushed,1000);
               }
            }
            else
            {
               if(kz > -100)
               {
                 hc.Play(Math.Abs(kz),eBreathDirection.draw,1000);
               }
               else
               {
                   hc.Play(Math.Abs(kz+100),eBreathDirection.drawPushed,1000);
               }
            }
        }
        
        HarpClass hc = null;        
        bool cancel = false;
        
        private void RunCompleteHarpSequence()
        {
            StringBuilder allnotes = new StringBuilder();
            foreach(string line in rtbSongHarp.Lines)
            {
                if(line.Trim().StartsWith("\"")) continue;
                if(line.Trim().StartsWith(HarpClass.CommentKey)) continue;
                allnotes.Append(line);
            }
            hsCancel.Visible = true;

            rtbPlainNotes.Clear();
            string cmd = hc.RemoveUselessCharacters(allnotes.ToString());
            rtbPlainNotes.Text = hc.GetPlainNotes(cmd);

            PlaySequence(hc.RemoveUselessCharacters(cmd));
            hsCancel.Visible = false;
        }

        private void RunSelectedHarpSequence()
        {      
            hsCancel.Visible = true;
            string[] cmdstr = rtbSongHarp.SelectedText.Replace("\"","\"#\"").Split(new char[]{'"'},StringSplitOptions.RemoveEmptyEntries);
            bool comment = false;
            StringBuilder sb = new StringBuilder();
            foreach(string cstr in cmdstr)
            {
                if(cstr== HarpClass.CommentKey) comment = !comment;
                if(!comment && cstr != HarpClass.CommentKey ) sb.Append(cstr);

            }

            rtbPlainNotes.Clear();
            string cmd = hc.RemoveUselessCharacters(sb.ToString());
            rtbPlainNotes.Text = hc.GetPlainNotes(cmd);


            PlaySequence(hc.RemoveUselessCharacters(sb.ToString()));
            hsCancel.Visible = false;
        }

        double tempo =  100;
        
        private double GetPunktDelay(double delay)
        {
            return delay/2.0;
        }
       
        private bool PlaySequence(string cmdToPlay)
        {      
            
            double ReferenceSpeedNote = 1.0/8.0;
            
            int nPlay = 0;
            cancel = false;
            tempo =  trkVelocity.Value;
            double volume = trkVolume.Value/10.0;
            hc.SetVolume(volume);   
            string cmd = cmdToPlay;
                                                        
            string[] notes =  cmd.Split(HarpClass.HarpNotesDivider.ToCharArray(),StringSplitOptions.RemoveEmptyEntries);                                                        
            
            foreach(string note in notes)
            {                                             
                string[] noteattributes = note.Split(HarpClass.HarpAttributeDivider.ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                string HarpSlot = noteattributes[0].Trim();
                if(HarpSlot == HarpClass.TaktKey)
                {
                    nPlay+=noteattributes[0].Length;
                    continue;
                }
                if((HarpSlot.ToUpper() == HarpClass.VelocityKey)&&(noteattributes.Length > 1))
                {
                    double tmp = StaticFunctionsClass.ToDoubleDef(noteattributes[1].Trim(),tempo);
                    tempo = tmp/2;
                    trkVelocity.Value = (int)tempo > trkVelocity.Maximum ? trkVelocity.Maximum : (int) tempo;
                    continue;
                }

                if((HarpSlot.ToUpper() == HarpClass.VolumeKey)&&(noteattributes.Length > 1))
                {
                    volume = StaticFunctionsClass.ToDoubleDef(noteattributes[1].Trim().Replace(".",","),volume);
                    hc.SetVolume(volume);
                    trkVolume.Value = (volume*10.0)>trkVolume.Maximum ? trkVolume.Maximum : (int) (volume*10.0);
                    continue;
                }

                bool punkt = HarpSlot.Contains(HarpClass.Dot);
                bool pause = HarpSlot.Contains(HarpClass.PauseKey);
                if(pause)
                {
                    double p_delay = 1;
                    double p_pdel = 0.0;
                    if(noteattributes.Length > 1)
                    {                        
                        string dstr = noteattributes[1].Trim();                  
                        bool diff = dstr.Contains(HarpClass.Divider);                                       
                        string ddstr = dstr;
                        if (diff) ddstr = dstr.Substring(1);
                                            
                        p_delay = StaticFunctionsClass.ToIntDef(ddstr,0);                                            
                        if(diff) p_delay= 1.0/p_delay;                        
                        if(punkt) p_pdel = GetPunktDelay(p_delay);
                    }
                                
                    if(tempo <= 0) tempo = 100.0;
                    int p_delayms = (int)((1000 * (p_delay+p_pdel))*(100.0/tempo) * ReferenceSpeedNote);

                    if(cancel) return false;
                    nPlay+=punkt  ? HarpSlot.Length+1 : HarpSlot.Length+2;                                               
                    Thread.Sleep(p_delayms);                                    
                    continue;
                }

                
                if(!hc.IsNotANote(note))
                {
                    bool blow =  StaticFunctionsClass.ToIntDef(HarpSlot,0) > 0;
                    if(!pause)
                    {
                        if(punkt)
                        {
                            SelectPlainText(nPlay,HarpSlot.Length-1,blow);
                        }
                        else
                        {
                            SelectPlainText(nPlay,HarpSlot.Length,blow);
                        }
                    }
                    nPlay+= punkt  ? HarpSlot.Length+1 : HarpSlot.Length+2; 
                }
                
                if(punkt)
                {
                    HarpSlot = HarpSlot.Remove(HarpSlot.Length-1,1);
                }

                int key = StaticFunctionsClass.ToIntDef(HarpSlot,0);
                double delay = 1;
                double pdel = 0.0;
                if(noteattributes.Length > 1)
                {
                    Console.WriteLine("");
                    string dstr = noteattributes[1].Trim();
                  
                    bool diff = dstr.Contains(HarpClass.Divider);                   
                    
                    string ddstr = dstr;
                    if (diff)
                    {
                        ddstr = dstr.Substring(1);
                    }
                    
                    delay = diff ? 1.0/StaticFunctionsClass.ToIntDef(ddstr,1) : StaticFunctionsClass.ToIntDef(ddstr,1);
                    
                    if(punkt)  pdel = GetPunktDelay(delay);                    
                }
                
                
                if(tempo <= 0) tempo = 100.0;
                int delayms = (int)((1000 * (delay+pdel))*(100.0/tempo) * ReferenceSpeedNote);

                if(cancel)
                {
                    return false;
                }               

                if(key < 0)
                {
                    if(key < 100)
                    {
                       hc.Play(Math.Abs(key),eBreathDirection.draw,delayms);                   
                    }
                    else
                    {
                        hc.Play(Math.Abs(key+100),eBreathDirection.drawPushed,delayms);                   
                    }
                }
                else if(key > 0)
                {
                    if(key > -100)
                    {
                        hc.Play(Math.Abs(key),eBreathDirection.blow,delayms);
                    }
                    else
                    {
                        hc.Play(Math.Abs(key-100),eBreathDirection.blowPushed,delayms);
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

        private void TransferToPlainHarpNotes(string[] cmdToPlay)
        {       
            StringBuilder sb = new StringBuilder();
            foreach(string cmdStr in cmdToPlay)
            {
                if(cmdStr.Trim().StartsWith("\"")) continue;
                if(cmdStr.Trim().StartsWith(HarpClass.CommentKey)) continue;
                sb.Append(cmdStr);
            }

            //string cmd = hc.RemoveUselessCharacters(sb.ToString());                        
            //string[] notes =  cmd.Split(HarpClass.HarpNotesDivider.ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
            cancel = false;
            tempo =  trkVelocity.Value;
            double volume = trkVolume.Value/10.0;
            hc.SetVolume(volume); 
            
            rtbPlainNotes.Clear();
            rtbPlainNotes.Text = hc.GetPlainNotes(hc.RemoveUselessCharacters(sb.ToString()));                                                  
        }

        
       
        private void Form1_Load(object sender, EventArgs e)
        {           
           Assembly asb = System.Reflection.Assembly.GetExecutingAssembly();
            
           string AppPath = Path.GetDirectoryName(asb.Location);
           string TempPath = Path.GetTempPath();
           string AppName = asb.GetName().ToString().Split(',')[0];
           string AppVersion = asb.GetName().Version.ToString();
           string nm = asb.GetName().Name;
           hsCancel.Visible = false;
           object[] cp = asb.GetCustomAttributes(true);
           var s = (AssemblyCompanyAttribute) cp[6];
           this.Text = $@"{AppName}, V{AppVersion} Copyright by {s.Company} 2018";
          
           foreach(InstrumentGroup ig in InstrumentGroupSet.Groups)
           {
                int i = cbHarpSoundInstrument.Items.Add(ig);                
           }

           foreach(eHarpInstruments ehi in HarpInstrumentFactory.GetInstruments())
           {
                cbHarpInstrument.Items.Add(ehi);
                cbReferenzHarpInstruments.Items.Add(ehi);
           }
           
           cbHarpInstrument.SelectedIndex = cbHarpInstrument.Items.Count > 0 ? 0 : -1;
           cbReferenzHarpInstruments.SelectedIndex = cbHarpInstrument.SelectedIndex;
           cbHarpSoundInstrument.SelectedIndex = cbHarpSoundInstrument.Items.Count > 0 ? 0 : -1;

           LoadMainFormDesign();

           InstrumentGroup ig2 = (InstrumentGroup) cbHarpSoundInstrument.SelectedItem;
           hc = new HarpClass();
           hc.CreateHarp(this.pnlSlots,sa,ig2.First,(eHarpInstruments)cbHarpInstrument.SelectedItem,(eHarpInstruments) cbReferenzHarpInstruments.SelectedItem);
        }

        private void cbIntrument_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(hc == null) return;
            InstrumentGroup ig2 = (InstrumentGroup) cbHarpSoundInstrument.SelectedItem;
            if(ig2 != null)
            {
                hc.SetInstrument(ig2.First);
            }
        }

        private void hsCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
        }

        private void hsRunMarked_Click(object sender, EventArgs e)
        {
            string cmd = hc.RemoveUselessCharacters(rtbSongHarp.SelectedText);           
            rtbPlainNotes.Clear();          
            rtbPlainNotes.Text = hc.GetPlainNotes(cmd);
            PlaySequence(cmd);
        }
       
        private void hsLoadSongHarp_Click(object sender, EventArgs e)
        {
            ofdHarpSong.InitialDirectory = Application.StartupPath+"\\songs\\";
            if(ofdHarpSong.ShowDialog() == DialogResult.OK)
            {
                rtbSongHarp.LoadFile(ofdSong.FileName,RichTextBoxStreamType.PlainText);
            }
        }
        
        private void cbReferenzHarpInstuments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(hc == null) return;            
            hc.SetRefHarpInstrument((eHarpInstruments) cbReferenzHarpInstruments.SelectedItem,"C");            
        }

        private void cbHarpInstrument_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(hc == null) return;                                     
           InstrumentGroup ig2 = (InstrumentGroup) cbHarpSoundInstrument.SelectedItem;
           if(hc != null)  hc.DeleteSlots();
           hc = new HarpClass();
           hc.CreateHarp(this.pnlSlots,sa,ig2.First,(eHarpInstruments)cbHarpInstrument.SelectedItem,(eHarpInstruments) cbReferenzHarpInstruments.SelectedItem);
        }

        public void SaveSong()
        {
            sfdSong.FileName = ofdSong.FileName;
            if(sfdSong.ShowDialog() == DialogResult.OK)
            {
                rtbSong.SaveFile(sfdSong.FileName,RichTextBoxStreamType.PlainText);
            }
        }
        
        enum eSongFormat{simple,abc}

        eSongFormat SongFormat = eSongFormat.simple;

        private void LoadSong()
        {
            ofdSong.InitialDirectory = Application.StartupPath+"\\songs\\";
            if(ofdSong.ShowDialog() == DialogResult.OK)
            {
                rtbSong.LoadFile(ofdSong.FileName,RichTextBoxStreamType.PlainText);
                if(ofdSong.FileName.ToUpper().EndsWith(".ABC")) SongFormat = eSongFormat.abc;
            }
        }

        public void SaveHarpSong()
        {
            SongFormat = eSongFormat.simple;
            sfdHarpSong.FileName = ofdSong.FileName;
            if(sfdHarpSong.ShowDialog() == DialogResult.OK)
            {
               rtbSongHarp.SaveFile(sfdHarpSong.FileName,RichTextBoxStreamType.PlainText);
            }
        }

        private void LoadHarpSong()
        {
            ofdHarpSong.InitialDirectory = Application.StartupPath+"\\songs\\";
            if(ofdHarpSong.ShowDialog() == DialogResult.OK)
            {
               rtbSongHarp.LoadFile(ofdHarpSong.FileName,RichTextBoxStreamType.PlainText);
            }
        }

        private void cmsSongNotiation_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem == tsmiLoadSong)
            {
                LoadSong();
            }
            else if(e.ClickedItem == tsmiSaveSong)
            {
                SaveSong();
            }
            else if(e.ClickedItem == tsmiTranslateNotationToHarpSequence)
            {
                int rowoffset = StaticFunctionsClass.ToIntDef(txtRowOffset.Text,0);
                if(SongFormat == eSongFormat.simple)
                {
                    rtbSongHarp.Text = hc.Translate(rtbSong.Lines,rowoffset);
                    StringBuilder sb = new StringBuilder();
                    foreach(string lines in rtbSongHarp.Lines)
                    {
                        if(lines.Trim().StartsWith(HarpClass.CommentKey)) continue;
                        sb.Append(lines);
                    }
                    rtbPlainNotes.Text = hc.GetPlainNotes(hc.RemoveUselessCharacters(sb.ToString()));
                }
                else
                {
                    rtbSongHarp.Text = hc.TranslateABC(rtbSong.Lines,rowoffset);
                }
            }
            else if(e.ClickedItem == tsmiEditMode)
            {
                rtbSong.ContextMenuStrip = cmsInsertNotes;
            }
        }

        private void cmsHarpSongNotation_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            cmsHarpSongNotation.Close();
            if(e.ClickedItem == tsmiLoadHarpSong)
            {
                LoadHarpSong();
            }
            else if(e.ClickedItem == tsmiSaveHarpSong)
            {
                
                SaveHarpSong();
            }
            else if(e.ClickedItem == tsmiPlayHarpSong)
            {
                CounterForm cf = new CounterForm();
                cf.ShowDialog();
                RunCompleteHarpSequence();
            }
            else if(e.ClickedItem == tsmiPlaySelectedHarpText)
            {
                RunSelectedHarpSequence();
            }
            else if(e.ClickedItem == tsmiTranslateHarpSequeceToSongNotation)
            {
                int rowoffset = StaticFunctionsClass.ToIntDef(txtRowOffset.Text,0);
                rtbSong.Text = hc.TranslateBack(rtbSongHarp.Lines,0);
            }
            else if(e.ClickedItem == tsmiTranslateToPlainHarpNotes)
            {
                TransferToPlainHarpNotes(rtbSongHarp.Lines);
            }
        }
      
        private void hotSpot1_Click_1(object sender, EventArgs e)
        {
            PlaySingleNote();
        }

        private void hsEdit_MarkedReached(object sender, SeControlsLib.MarkedEventArgs e)
        {
            rtbSong.ContextMenuStrip = (e.marked) ? cmsInsertNotes : cmsSongNotation;
        }

        private void cmsInsertNotes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {           
            if(e.ClickedItem == tsmiGanzNote)
            {
                rtbSong.Text = rtbSong.Text.Insert(rtbSong.SelectionStart, "1");
            }
            else if(e.ClickedItem ==  tsmiHalbeNote)
            {
              rtbSong.Text = rtbSong.Text.Insert(rtbSong.SelectionStart, "1/2");
            }
            else if(e.ClickedItem == tsmiViertelNote)
            {
                rtbSong.Text = rtbSong.Text.Insert(rtbSong.SelectionStart, "1/4");
            }
            else if(e.ClickedItem ==  tsmiSechzehntelNote)
            {
                rtbSong.Text = rtbSong.Text.Insert(rtbSong.SelectionStart, "1/16");
            }
            else if(e.ClickedItem == tsmiAchtelNote)
            {
                rtbSong.Text = rtbSong.Text.Insert(rtbSong.SelectionStart, "1/8");
            }
            else if(e.ClickedItem == tsmiDreiAchtelNote)
            {
                rtbSong.Text = rtbSong.Text.Insert(rtbSong.SelectionStart, "3/8");
            }
            else if(e.ClickedItem == tsmiDreiViertelNote)
            {
                rtbSong.Text = rtbSong.Text.Insert(rtbSong.SelectionStart, "3/4");
            }
            else if(e.ClickedItem == tsmiEndEditMode)
            {
                rtbSong.ContextMenuStrip = cmsSongNotation;
            }                             
        }

        private void trkVolume_Scroll(object sender, EventArgs e)
        {
             hc.SetVolume(trkVolume.Value/10.0);
        }

        private void trkVelocity_Scroll(object sender, EventArgs e)
        {
            tempo = trkVelocity.Value;
        }
        
        private void SelectPlainText(int n, int length, bool blow)
        {
            rtbPlainNotes.SelectionStart = Math.Abs(n);                
            rtbPlainNotes.SelectionLength = length;
            rtbPlainNotes.SelectionBackColor = blow ? Color.Green : Color.Red;
            rtbPlainNotes.SelectionColor = Color.Yellow;
          
            Application.DoEvents();
        }

        private void trkPlainTextSize_Scroll(object sender, EventArgs e)
        {
            Font fnt = new Font("Consolas",(float)trkPlainTextSize.Value);
            rtbPlainNotes.Font = fnt;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancel = true;
            SaveMainFormDesign();
        }

        private void hotSpot1_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void cmsPlainHarpSequence_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            rtbPlainNotes.SelectionBackColor = rtbPlainNotes.BackColor;
            //rtbPlainNotes.Clear();
        }
    }
}
