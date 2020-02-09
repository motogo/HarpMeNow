using BasicClassLibrary;
using Enums;
using MidiOutApi.Api;
using System;
using System.Collections.Generic;
using System.Text;


namespace HarpMeNow
{

    public class FormInstances
    {
        static private volatile FormInstances instance = null;
        static object _lock_this = new object();
        public HarpSlotsForm harpSlotsForm;
        public HarpSequenceForm harpSequenceForm;
        public SongSequenceForm songSequenceForm;
        public HarpPlayForm harpPlayForm;
        public SoundAttributesForm soundAttributeForm;
        public InstrumentsForm instrumentsForm;
        public HarpEditForm harpEditForm;

        internal void RegisterFormsInfoNotify(object infoNotify)
        {
            throw new NotImplementedException();
        }

      

        public SlotEditForm slotEditForm;
        public SimpleApi sa = null;
        public HarpClass hc = null;
        public bool FirstRun = true;
        public NotifiesClass HarpNotifies = new NotifiesClass();
        public string DatabaseFile = "Harp.dat";

        static public FormInstances Create(System.Windows.Forms.Form frm)
        {
            lock (_lock_this)
            {
                if (instance == null)
                {
                    instance = new FormInstances();
                    instance.sa = new SimpleApi();
                    instance.hc = new HarpClass();
                    //CompanyForm cf = new CompanyForm();
                    //cf.MdiParent = frm;
                    //cf.WindowState = FormWindowState.Maximized;
                    //cf.Show();

                    instance.soundAttributeForm = new SoundAttributesForm();
                   
                    instance.soundAttributeForm.Visible = false;
                    instance.soundAttributeForm.MdiParent = frm;
                    

                    instance.harpSlotsForm = new HarpSlotsForm();
                    instance.harpSlotsForm.Visible = false;
                    instance.harpSlotsForm.MdiParent = frm;
                    

                    instance.harpPlayForm = new HarpPlayForm();
                    instance.harpPlayForm.Visible = false;
                    instance.harpPlayForm.MdiParent = frm;
                    
                    instance.harpPlayForm.Left = instance.harpSlotsForm.Width + 16;

                    

                    instance.songSequenceForm = new SongSequenceForm();
                    instance.songSequenceForm.Visible = false;
                   // instance.songSequenceForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                    instance.songSequenceForm.MdiParent = frm;
                    
                    instance.songSequenceForm.Top = instance.harpSlotsForm.Height + 16;

                    instance.harpSequenceForm = new HarpSequenceForm();
                    instance.harpSequenceForm.Visible = false;
                    instance.harpSequenceForm.MdiParent = frm;
                    instance.harpSequenceForm.Top = instance.harpSlotsForm.Height + 16;


                  

                    instance.HarpNotifies.Register4Error(instance.Notify_OnRaiseErrorHandler);
                    instance.HarpNotifies.Register4Info(instance.Notify_OnRaiseInfoHandler);                                
                    instance.FirstRun = false;
                };
            }
            return (instance);
        }

        public void LoadHarps()
        {
            SQLDataClass sq = new SQLDataClass(DatabaseFile);
            List<Harp> lst = sq.GetAll();
            hc.AddHarps(lst);
            hc.SelectHarp(lst[0]);
        }
        
        private void Notify_OnRaiseInfoHandler(object sender, MessageEventArgs k)
        {
           
            
        }
        private void Notify_OnRaiseErrorHandler(object sender, MessageEventArgs k)
        {
            
        }

        static public FormInstances Instance()
        {
            return instance;
        }       

        /// <summary>
        /// Fremde Notify Routinen werden der zentralen HarpNoties zugeordnet.
        /// </summary>
        /// <param name="notify"></param>
        /*
        public void RegisterFormsInfoNotify(RaiseNotifyHandler notify)
        {
            List<string> lst = HarpNotifies.Notify.GetInfoTargedList();
            if (lst.Contains(notify.Target.ToString())) return;
            HarpNotifies.Notify.OnRaiseInfoHandler -= notify;            
            HarpNotifies.Notify.OnRaiseInfoHandler += notify;
        }
        public void RegisterFormsErrorNotify(RaiseNotifyHandler notify)
        {
            List<string> lst = HarpNotifies.Notify.GetErrorTargedList();
            if (lst.Contains(notify.Target.ToString())) return;
            HarpNotifies.Notify.OnRaiseErrorHandler -= notify;
            HarpNotifies.Notify.OnRaiseErrorHandler += notify;

        }
        */
        public void SelectHarpByName(string name)
        {
            Harp harp = hc.Harps.Find(X => X.Name == name);
            hc.ActualHarpInstrument = HarpInstrumentFactory.HarpDatabaeObject2HarpInstrument(harp);            
            soundAttributeForm.SetHarp(harp);            
        }
        public void SelectRefHarpByName(string name)
        {
            Harp harp = hc.Harps.Find(X => X.Name == name);
          //  hc.ReferenceHarpInstrument = HarpInstrumentFactory.HarpDatabaeObject2HarpInstrument(harp);
          //  soundAttributeForm.SetRefHarp(harp);
        }
        public void SetVelocity(int vel)
        {
            hc.SetVelocity(vel*Statics.VelocityFactor);
            soundAttributeForm.SetVelocity(vel);
        }
        public void SetVolume(double vel)
        {
            hc.SetVolume(vel);
            soundAttributeForm.SetVolume(vel);
        }
        public void RunSelectedHarpSequence(string selectedText)
        {
            string[] cmdstr = selectedText.Replace("\"", "\"#\"").Split(new char[] { '"' }, StringSplitOptions.RemoveEmptyEntries);
            bool comment = false;
            var sb = new StringBuilder();
            foreach (string cstr in cmdstr)
            {
                if (cstr == Statics.CommentKey) comment = !comment;
                if (!comment && cstr != Statics.CommentKey) sb.Append(cstr);
            }
            harpPlayForm.flowLayoutPanel1.Visible = false;
            hc.ClearPlayHarp();
            harpPlayForm.flowLayoutPanel1.Visible = true;
            string cmd = hc.RemoveUselessCharacters(sb.ToString());
            hc.CreatePlayHarp(FormInstances.Instance().harpPlayForm.flowLayoutPanel1, songSequenceForm.rtbSong, cmd);

            hc.PlaySequence(hc.RemoveUselessCharacters(sb.ToString()));
        }
        public void RunCompleteHarpSequence(string[] lines)
        {

            FormInstances.Instance().harpPlayForm.RunCompleteHarpSequenceFromButtons();

            /*
            StringBuilder allnotes = new StringBuilder();

            foreach (string line in lines)
            {
                if (line.Trim().StartsWith("\"")) continue;
                if (line.Trim().StartsWith(Statics.CommentKey)) continue;
                allnotes.Append(line);
            }

            harpPlayForm.SetIsPlayingUI();
            harpPlayForm.flowLayoutPanel1.Visible = false;
            hc.ClearPlayHarp();
            harpPlayForm.flowLayoutPanel1.Visible = true;
            string cmd = hc.RemoveUselessCharacters(allnotes.ToString());
            hc.CreatePlayHarp(harpPlayForm.flowLayoutPanel1, songSequenceForm.rtbSong, cmd);

            hc.PlaySequence(hc.RemoveUselessCharacters(cmd));
            harpPlayForm.SetPlayUI();
            */
        }
        public string TranslateSongNotationToHarpNotation(string[] songlines, int rowoffset, eSongFormat songFormat, eTranslateType translateType)
        {
            string sb1 = TranslateSelectedSongNotationToHarpNotation(songlines, songlines, rowoffset, songFormat, translateType);
            return sb1;
/*
            string sb = string.Empty;
            hc.shiftedKey = hc.ActualHarpInstrument.Key;
            if (songFormat == eSongFormat.simple)
            {
                hc.Translate2SongNotesList(songlines, hc.shiftedKey, translateType);                 
                if (hc.ShiftNote != 0)
                {
                    List<int> fail = hc.ShiftSongNotes(hc.ShiftNote);                                        
                }
                sb = hc.TranslateSongNotesList2HarpText(false);
                hc.TranslateSongNotesList2Harp(harpPlayForm.flowLayoutPanel1, songSequenceForm.rtbSong);                
            }
            else
            {
                sb = hc.TranslateABC(songlines, rowoffset);
            }
            harpSequenceForm.SetSongText(sb.ToString());
            return sb.ToString();
            */
        }

        



        public string TranslateSelectedSongNotationToHarpNotation(string[] songlines, string[] selectedsonglines, int rowoffset, eSongFormat songFormat, eTranslateType translateType)
        {                        
            string sb = string.Empty;
            hc.shiftedKey = hc.ActualHarpInstrument.Key;
            if (songFormat == eSongFormat.simple)
            {
                hc.SongDefinition = hc.TranslateDefinition2SongNotesList(songlines, rowoffset, translateType);
                List<Notes> notessonglines = hc.TranslateNotes2SongNotesList(selectedsonglines,  hc.shiftedKey, translateType);
                hc.SongNotesList = new List<Notes>();

                hc.SongNotesList.AddRange(notessonglines);

                if (hc.ShiftNote != 0)
                {
                    List<int> fail = hc.ShiftSongNotes(hc.ShiftNote);
                }
                sb = hc.TranslateSongNotesList2HarpText(false);
                hc.TranslateSongNotesList2Harp(harpPlayForm.flowLayoutPanel1, songSequenceForm.rtbSong);
            }
            else
            {
                sb = hc.TranslateABC(songlines, rowoffset);
            }
            harpSequenceForm.SetSongText(sb.ToString());
            return sb.ToString();
        }
        public void NewSong()
        {
            var sb = new StringBuilder();            
            sb.Append($@"{Statics.SongInstrumentKey.ToLower()}={hc.ActualHarpInstrument.Name}{Environment.NewLine}");            
            sb.Append($@"{Statics.SongVolumeKey.ToLower()}={soundAttributeForm.GetVolume().ToString()}{Environment.NewLine}");
            sb.Append($@"{Statics.SongTempoKey.ToLower()}={soundAttributeForm.GetVelocity().ToString()}{Environment.NewLine}");
            songSequenceForm.SetNewSong(sb.ToString());
        }
    }
}
