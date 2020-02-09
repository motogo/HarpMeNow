using BasicClassLibrary;
using MidiOutApi.Api;
using SharedStorages;
using System;
using System.Windows.Forms;


namespace HarpMeNow
{
    public partial class SoundAttributesForm : Form
    {
        public bool FirstRun = true;        
        SoundAttributesFormDesign mw = new SoundAttributesFormDesign();
        string sharedFolder = $@"{Application.StartupPath}\Temp\";

        SharedStorage ss = new SharedStorage();
        public SoundAttributesForm()
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

        private void LoadFormDesign()
        {
            try
            {
                ss.SharedFolder = sharedFolder;
                ss.StorageName = this.Name;
                ss.DestroyWhenDisposed = false;
                var mw2 = (SoundAttributesFormDesign)ss["FormData"];
                if (mw2 != null)
                {
                    mw = mw2;

                    if (mw != null)
                    {
                        trkVelocity.Value                       = mw.Velocity;
                        trkVolume.Value                         = mw.Volume;
                        cbHarpInstrument.SelectedIndex          = mw.cbHarpInstrumentINX;
                        cbHarpSoundInstrument.SelectedIndex     = mw.cbHarpSoundINX;
                        cbReferenzHarpInstruments.SelectedIndex = mw.cbRefHarpInstrumentINX;
                    }
                    else
                    {
                        trkVelocity.Value = 50;
                        trkVolume.Value = 5;
                        cbHarpInstrument.SelectedIndex = 0;
                        cbHarpSoundInstrument.SelectedIndex = 0;
                        cbReferenzHarpInstruments.SelectedIndex = 0;
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
                mw.Velocity                 = trkVelocity.Value;
                mw.Volume                   = trkVolume.Value;
                mw.cbHarpInstrumentINX      = cbHarpInstrument.SelectedIndex;
                mw.cbHarpSoundINX           = cbHarpSoundInstrument.SelectedIndex;
                mw.cbRefHarpInstrumentINX   = cbReferenzHarpInstruments.SelectedIndex;
                
                ss.SharedFolder = sharedFolder;
                ss.StorageName = this.Name;

                ss.AddOrUpdate("FormData", mw);
            }
        }

     

        private void hsCloseApp_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void cbReferenzHarpInstruments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormInstances.Instance().hc == null) return;
            Harp harp = (Harp)cbReferenzHarpInstruments.SelectedItem;

          //  FormInstances.Instance().hc.ReferenceHarpInstrument = HarpInstrumentFactory.HarpDatabaeObject2HarpInstrument(harp);
        }
        private void SoundAttributesForm_Load(object sender, EventArgs e)
        {
            this.Text = "Sound Attributes";
            foreach (InstrumentGroup ig in InstrumentGroupSet.Groups)
            {
                int i = cbHarpSoundInstrument.Items.Add(ig);
            }
            /*
            foreach (eHarpInstruments ehi in HarpInstrumentFactory.GetInstruments())
            {
                cbHarpInstrument.Items.Add(ehi);
                cbReferenzHarpInstruments.Items.Add(ehi);
            }
            */

            foreach(Harp harpIntument in FormInstances.Instance().hc.Harps)
            {
                cbHarpInstrument.Items.Add(harpIntument);
                cbReferenzHarpInstruments.Items.Add(harpIntument);
            }
            SetUIVolume();
            SetUIVelocity();
            FormInstances.Instance().HarpNotifies.Register4Info(infoNotify);

            cbHarpInstrument.SelectedIndex          = cbHarpInstrument.Items.Count > 0 ? 0 : -1;
            cbReferenzHarpInstruments.SelectedIndex = cbHarpInstrument.SelectedIndex;
            cbHarpSoundInstrument.SelectedIndex     = cbHarpSoundInstrument.Items.Count > 0 ? 0 : -1;

            InstrumentGroup ig2 = (InstrumentGroup)cbHarpSoundInstrument.SelectedItem;
            //FormInstances.Instance().hc.SetTranspose(FormInstances.Instance().Transpose);
            FormInstances.Instance().hc.SetInstrument(ig2.First);
            int x = FormInstances.Instance().hc.CreateHarp(FormInstances.Instance().harpSlotsForm.pnlSlots, FormInstances.Instance().songSequenceForm.rtbSong, FormInstances.Instance().sa, (Harp)cbHarpInstrument.SelectedItem, (Harp)cbReferenzHarpInstruments.SelectedItem);
            FormInstances.Instance().harpSlotsForm.Width = x;
            FirstRun = false;
        }

        private void infoNotify(object sender, MessageEventArgs k)
        {
            if (k.Key.ToString() == "SetVelocity")
            {
                SetUIVelocity();
            }
        }

        public void SetHarp(Harp harp)
        {
            cbHarpInstrument.Text = harp.Name;
        }
        public void SetRefHarp(Harp harp)
        {
          cbReferenzHarpInstruments.Text = harp.Name;
        }
       
        private void cbHarpInstrument_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormInstances.Instance().hc == null) return;

            if (cbHarpSoundInstrument.SelectedItem == null)
            {
                if (cbHarpSoundInstrument.Items.Count > 0) cbHarpSoundInstrument.SelectedIndex = 0;
            }

            if (cbReferenzHarpInstruments.SelectedItem == null)
            {
                if (cbReferenzHarpInstruments.Items.Count > 0) cbReferenzHarpInstruments.SelectedIndex = 0;
            }

            if (FormInstances.Instance().hc != null) FormInstances.Instance().hc.DeleteSlots();

            //FormInstances.Instance().hc.SetTranspose(FormInstances.Instance().Transpose);
            if (!FirstRun)
            {
                int x = FormInstances.Instance().hc.CreateHarp(FormInstances.Instance().harpSlotsForm.pnlSlots, FormInstances.Instance().songSequenceForm.rtbSong, FormInstances.Instance().sa, (Harp)cbHarpInstrument.SelectedItem, (Harp)cbReferenzHarpInstruments.SelectedItem);
                FormInstances.Instance().harpSlotsForm.Width = x;

            }

        }

        public double GetVolume()
        {
            return trkVolume.Value/10.0;
        }

        public double GetVelocity()
        {
            return trkVelocity.Value;
        }

        public byte GetTranspose()
        {
            return (byte) StaticFunctionsClass.ToIntDef(txtTranspose.Text, 0);
        }

        bool doEvents = true;
      
        public void SetVolume(double v)
        {
            trkVolume.Value = (int) (v*10); 
            SetUIVolume();
        }
        private void SetUIVolume()
        {            
            gbVolume.Text = $@"Volume ({trkVolume.Value / 10.0})";
        }
      
        public void SetVelocity(int v)
        {
            trkVelocity.Value = v;
            SetUIVelocity();
        }
        private void SetUIVelocity()
        {            
            gbVelocity.Text = $@"Velocity ({trkVelocity.Value})";
        }
        private void txtTranspose_TextChanged(object sender, EventArgs e)
        {
            byte transpose = 0;
            if (doEvents)
            {
                transpose = (byte)StaticFunctionsClass.ToIntDef(txtTranspose.Text, 0);
                FormInstances.Instance().hc.SetTranspose(transpose);
            }
            doEvents = false;
            //txtTranspose.Text = transpose.ToString();
            doEvents = true;
        }

        private void cbHarpSoundInstrument_SelectedIndexChanged(object sender, EventArgs e)
        {
            InstrumentGroup ig2 = (InstrumentGroup)cbHarpSoundInstrument.SelectedItem;
            FormInstances.Instance().sa.SetInstrument(ig2.First);
        }

        private void trkVelocity_KeyUp(object sender, KeyEventArgs e)
        {
            FormInstances.Instance().HarpNotifies.Notify.RaiseInfo(trkVelocity.Value.ToString(), Statics.SetVelocity, this);
        }

        private void trkVelocity_MouseUp(object sender, MouseEventArgs e)
        {
            FormInstances.Instance().HarpNotifies.Notify.RaiseInfo(trkVelocity.Value.ToString(), Statics.SetVelocity, this);
        }

        private void trkVolume_MouseUp(object sender, MouseEventArgs e)
        {
            SetUIVolume();            
            FormInstances.Instance().HarpNotifies.Notify.RaiseInfo((trkVolume.Value/10.0).ToString(), Statics.SetVolume, this);
        }

        private void trkVolume_KeyUp(object sender, KeyEventArgs e)
        {
            SetUIVolume();            
            FormInstances.Instance().HarpNotifies.Notify.RaiseInfo((trkVolume.Value/10.0).ToString(), Statics.SetVolume, this);
        }

        private void SoundAttributesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFormDesign();
            e.Cancel = true;
            this.Hide();
        }

        public Harp SelectInstrument(string instrStr)
        {
            cbHarpInstrument.Text = instrStr;
            var i = (Harp)cbHarpInstrument.SelectedItem;
            return i;
        }
    }
}
