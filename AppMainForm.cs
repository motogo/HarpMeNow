using BasicClassLibrary;
using System;
using System.Reflection;
using System.Windows.Forms;


namespace HarpMeNow
{
    public partial class AppMainForm : Form
    {

        //NotifyClass NotifyHandler;

        public AppMainForm()
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
            
            this.Text = $@"{AppName}, V{AppVersion} Copyright by {s.Company} 2019";
            toolStripMenuItemWindows.Text  = LanguageClass.Instance().GetString("Windows");
            toolStripMenuItemLanguage.Text = LanguageClass.Instance().GetString("Language");
            toolStripMenuItemCloseApplication.Text = LanguageClass.Instance().GetString("CloseApplication");
        }
        string AppName = string.Empty;
        string AppVersion = string.Empty;
        AssemblyCompanyAttribute s;

        private void AppMainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
          
            this.Visible = true;
            this.LayoutMdi(System.Windows.Forms.MdiLayout.ArrangeIcons);

            Assembly asb = System.Reflection.Assembly.GetExecutingAssembly();
            AppName = asb.GetName().ToString().Split(',')[0];
            AppVersion = asb.GetName().Version.ToString();
            string nm = asb.GetName().Name;
            object[] cp = asb.GetCustomAttributes(true);
            s = (AssemblyCompanyAttribute)cp[6];

            LanguageClass.Instance().InitEmbedded(this.GetType().Assembly, "HarpMeNow", "LanguageResource", "_", SelectedClass.Instance().Culture, LanguageClass.English);
            LanguageClass.Instance().ChangeLanguage(SelectedClass.Instance().Culture);
            SetLanguageControls();
            FormInstances.Create(this);
            FormInstances.Instance().LoadHarps();

            
            FormInstances.Instance().soundAttributeForm.Show();
            FormInstances.Instance().soundAttributeForm.SendToBack();
            FormInstances.Instance().harpSlotsForm.Show();
            FormInstances.Instance().harpSlotsForm.SendToBack();
            FormInstances.Instance().songSequenceForm.Show();
            FormInstances.Instance().songSequenceForm.SendToBack();
            FormInstances.Instance().harpSequenceForm.Show();
            FormInstances.Instance().harpSequenceForm.SendToBack();
            FormInstances.Instance().harpPlayForm.Show();
            FormInstances.Instance().harpPlayForm.SendToBack();

            FormInstances.Instance().harpPlayForm.Top        = FormInstances.Instance().harpSlotsForm.Top;
            FormInstances.Instance().harpPlayForm.Left       = FormInstances.Instance().harpSlotsForm.Left + FormInstances.Instance().harpSlotsForm.Width + 16;
            FormInstances.Instance().harpPlayForm.Height     = FormInstances.Instance().harpSlotsForm.Height;
            FormInstances.Instance().songSequenceForm.Top    = FormInstances.Instance().harpSlotsForm.Top + FormInstances.Instance().harpSlotsForm.Height + 16;
            FormInstances.Instance().songSequenceForm.Left   = FormInstances.Instance().harpSlotsForm.Left;
            FormInstances.Instance().harpSequenceForm.Top    = FormInstances.Instance().harpSlotsForm.Top + FormInstances.Instance().harpSlotsForm.Height + 16;
            FormInstances.Instance().harpSequenceForm.Left   = FormInstances.Instance().songSequenceForm.Left + FormInstances.Instance().songSequenceForm.Width + 16;
            FormInstances.Instance().soundAttributeForm.Top  = FormInstances.Instance().harpSequenceForm.Top;
            FormInstances.Instance().soundAttributeForm.Left = FormInstances.Instance().harpSequenceForm.Left + FormInstances.Instance().harpSequenceForm.Width + 16;

            this.WindowState = FormWindowState.Maximized;
            var cf = FBXInfo.Instance(this);
            cf.MdiParent = this;
            cf.Show();
            SetPositions();
        }

        int harpPlayFormTop;
        int harpPlayFormLeft;
        int harpPlayFormHeight;
        int harpPlayFormWidth;

        int harpSequenceFormTop;
        int harpSequenceFormLeft;
        int harpSequenceFormHeight;
        int harpSequenceFormWidth;

        int harpSlotsFormTop;
        int harpSlotsFormLeft;
        int harpSlotsFormHeight;
        int harpSlotsFormWidth;

        int soundAttributesFormTop;
        int soundAttributesFormLeft;
        int soundAttributesFormHeight;
        int soundAttributesFormWidth;

        private void SetPositions()
        {
            harpPlayFormTop         = FormInstances.Instance().harpPlayForm.Top;
            harpPlayFormLeft        = FormInstances.Instance().harpPlayForm.Left;
            harpPlayFormHeight      = FormInstances.Instance().harpPlayForm.Height;
            harpPlayFormWidth       = FormInstances.Instance().harpPlayForm.Width;

            harpSequenceFormTop     = FormInstances.Instance().harpSequenceForm.Top;
            harpSequenceFormLeft    = FormInstances.Instance().harpSequenceForm.Left;
            harpSequenceFormHeight  = FormInstances.Instance().harpSequenceForm.Height;
            harpSequenceFormWidth   = FormInstances.Instance().harpSequenceForm.Width;

            harpSlotsFormTop        = FormInstances.Instance().harpSlotsForm.Top;
            harpSlotsFormLeft       = FormInstances.Instance().harpSlotsForm.Left;
            harpSlotsFormHeight     = FormInstances.Instance().harpSlotsForm.Height;
            harpSlotsFormWidth      = FormInstances.Instance().harpSlotsForm.Width;

            soundAttributesFormTop      = FormInstances.Instance().soundAttributeForm.Top;
            soundAttributesFormLeft     = FormInstances.Instance().soundAttributeForm.Left;
            soundAttributesFormHeight   = FormInstances.Instance().soundAttributeForm.Height;
            soundAttributesFormWidth    = FormInstances.Instance().soundAttributeForm.Width;
        }

        private void GetPositions()
        {
            GetPlayPositions();
            GetSequencePositions();
            GetAttributePositions();
            GetSlotsPositions();
        }
        private void GetPlayPositions()
        {
            FormInstances.Instance().harpPlayForm.Top       = harpPlayFormTop;
            FormInstances.Instance().harpPlayForm.Left      = harpPlayFormLeft;
            FormInstances.Instance().harpPlayForm.Height    = harpPlayFormHeight;
            FormInstances.Instance().harpPlayForm.Width     = harpPlayFormWidth;
        }
        private void GetSequencePositions()
        {

            FormInstances.Instance().harpSequenceForm.Top       = harpSequenceFormTop;
            FormInstances.Instance().harpSequenceForm.Left      = harpSequenceFormLeft;
            FormInstances.Instance().harpSequenceForm.Height    = harpSequenceFormHeight;
            FormInstances.Instance().harpSequenceForm.Width     = harpSequenceFormWidth;

        }

        private void GetSlotsPositions()
        {            
            FormInstances.Instance().harpSlotsForm.Top      = harpSlotsFormTop;
            FormInstances.Instance().harpSlotsForm.Left     = harpSlotsFormLeft;
            FormInstances.Instance().harpSlotsForm.Height   = harpSlotsFormHeight;
            FormInstances.Instance().harpSlotsForm.Width    = harpSlotsFormWidth;
        }

        private void GetAttributePositions()
        {
            FormInstances.Instance().soundAttributeForm.Top     = soundAttributesFormTop;
            FormInstances.Instance().soundAttributeForm.Left    = soundAttributesFormLeft;
            FormInstances.Instance().soundAttributeForm.Height  = soundAttributesFormHeight;
            FormInstances.Instance().soundAttributeForm.Width   = soundAttributesFormWidth;
        }

        private void menuFileAndWindow_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Console.WriteLine(e.ClickedItem);
        }

        private void ShowSongAttributes()
        {
            if (FormInstances.Instance().soundAttributeForm.Visible)
            {
                FormInstances.Instance().soundAttributeForm.BringToFront();
            }
            else
            {
                FormInstances.Instance().soundAttributeForm.Visible = true;
                GetAttributePositions();
            }
            FormInstances.Instance().soundAttributeForm.WindowState = FormWindowState.Normal;
        }
        private void ShowHarpSequence()
        {
            if (FormInstances.Instance().harpSequenceForm.Visible)
            {
                FormInstances.Instance().harpSequenceForm.BringToFront();
            }
            else
            {
                FormInstances.Instance().harpSequenceForm.Visible = true;
                GetSequencePositions();
            }
            FormInstances.Instance().harpSequenceForm.WindowState = FormWindowState.Normal;
        }

        private void ShowSongSequence()
        {
            if (FormInstances.Instance().songSequenceForm.Visible)
            {
                FormInstances.Instance().songSequenceForm.BringToFront();
            }
            else
            {
                FormInstances.Instance().songSequenceForm.Visible = true;
                GetSequencePositions();
            }
            FormInstances.Instance().songSequenceForm.WindowState = FormWindowState.Normal;
        }
        public void ShowHarpSlots()
        {
            if (FormInstances.Instance().harpSlotsForm.Visible)
            {
                FormInstances.Instance().harpSlotsForm.BringToFront();
            }
            else
            {
                FormInstances.Instance().harpSlotsForm.Visible = true;
                GetSlotsPositions();
            }
            FormInstances.Instance().harpSlotsForm.WindowState = FormWindowState.Normal;
        }
        private void ShowPlaySlots()
        {
            if (FormInstances.Instance().harpPlayForm.Visible)
            {
                FormInstances.Instance().harpPlayForm.BringToFront();
            }
            else
            {
                FormInstances.Instance().harpPlayForm.Visible = true;
                GetPlayPositions();
            }
            FormInstances.Instance().harpPlayForm.WindowState = FormWindowState.Normal;
        }

        private void cmsWindows_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsmiCascadeWindows)
            {
                tsmiCascadeWindows.Checked = !tsmiCascadeWindows.Checked;
                if (tsmiCascadeWindows.Checked)
                {
                    SetPositions();
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                }
                else
                {
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.ArrangeIcons);
                    GetPositions();
                }
            }
            else if(e.ClickedItem == tsmiCloseApplication)
            {
                FormInstances.Instance().hc.CancelPlay = true;
                FormInstances.Instance().harpPlayForm.Close();
                FormInstances.Instance().harpPlayForm.Dispose();
                FormInstances.Instance().harpSequenceForm.Close();
                FormInstances.Instance().harpSequenceForm.Dispose();
                FormInstances.Instance().harpSlotsForm.Close();
                FormInstances.Instance().harpSlotsForm.Dispose();
                FormInstances.Instance().songSequenceForm.Close();
                FormInstances.Instance().songSequenceForm.Dispose();
                FormInstances.Instance().soundAttributeForm.Close();
                FormInstances.Instance().soundAttributeForm.Dispose();
                if (FormInstances.Instance().instrumentsForm != null)
                {
                    FormInstances.Instance().instrumentsForm.Close();
                }
                if (FormInstances.Instance().harpEditForm != null)
                {
                    FormInstances.Instance().harpEditForm.Close();
                }
                Application.Exit();
            }
            else if(e.ClickedItem == tsmiSoundAttributes)
            {
                ShowSongAttributes();                    
            }
            else if (e.ClickedItem == tsmiPlayForm)
            {
                ShowPlaySlots();
            }
            else if (e.ClickedItem == tsmiHarpSlotsForm)
            {
                ShowHarpSlots();
            }
            else if (e.ClickedItem == tsmiSequenceForm)
            {
                ShowHarpSequence();
            }
            else if (e.ClickedItem == tsmiInstruments)
            {
                if (FormInstances.Instance().instrumentsForm == null)
                {
                    FormInstances.Instance().instrumentsForm = new InstrumentsForm();
                    FormInstances.Instance().instrumentsForm.MdiParent = this;
                    FormInstances.Instance().instrumentsForm.Show();
                }
            }
        }
        private void AppMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormInstances.Instance().hc.CancelPlay = true;
            FormInstances.Instance().harpPlayForm.Close();
            FormInstances.Instance().harpPlayForm.Dispose();
            FormInstances.Instance().harpSequenceForm.Close();
            FormInstances.Instance().harpSequenceForm.Dispose();
            FormInstances.Instance().harpSlotsForm.Close();
            FormInstances.Instance().harpSlotsForm.Dispose();
            FormInstances.Instance().songSequenceForm.Close();
            FormInstances.Instance().songSequenceForm.Dispose();
            FormInstances.Instance().soundAttributeForm.Close();
            FormInstances.Instance().soundAttributeForm.Dispose();

            Application.Exit();
        }

        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender == harpSequenceToolStripMenuItem)
            {
                ShowHarpSequence();
            }
            else if (sender == songSequenceToolStripMenuItem)
            {
                ShowSongSequence();
            }
            else if (sender == harpSlotsToolStripMenuItem)
            {
                ShowHarpSlots();
            }
            else if (sender == playSotsToolStripMenuItem)
            {
                ShowPlaySlots();
            }
            else if (sender == songAttributesToolStripMenuItem)
            {
                ShowSongAttributes();
            }
            else if (sender == toolStripMenuItemCloseApplication)
            {
                FormInstances.Instance().harpPlayForm.Close();
                FormInstances.Instance().harpPlayForm.Dispose();
                FormInstances.Instance().harpSequenceForm.Close();
                FormInstances.Instance().harpSequenceForm.Dispose();
                FormInstances.Instance().harpSlotsForm.Close();
                FormInstances.Instance().harpSlotsForm.Dispose();
                FormInstances.Instance().songSequenceForm.Close();
                FormInstances.Instance().songSequenceForm.Dispose();
                FormInstances.Instance().soundAttributeForm.Close();
                FormInstances.Instance().soundAttributeForm.Dispose();

                Application.Exit();
            }
            else if (sender == instrumentsToolStripMenuItem)
            {
                if (FormInstances.Instance().instrumentsForm == null)
                {
                    FormInstances.Instance().instrumentsForm = new InstrumentsForm();
                    FormInstances.Instance().instrumentsForm.MdiParent = this;
                    FormInstances.Instance().instrumentsForm.Show();
                }
            }
        }
        private void ChangeLanguage_click(object sender, EventArgs e)
        {
            if(sender == deutschToolStripMenuItem)
            {
              LanguageClass.Instance().ChangeLanguage("de");
            }
            else if (sender == englischToolStripMenuItem)
            {
                LanguageClass.Instance().ChangeLanguage("en");
            }

        }
    }
}
