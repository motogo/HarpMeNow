using BasicClassLibrary;
using SharedStorages;
using System;
using System.Windows.Forms;


namespace HarpMeNow
{
    public partial class HarpSlotsForm : Form
    {
        enum eSongFormat { simple, abc }
        string sharedFolder;
        
        MainFormDesign mw               = new MainFormDesign();
        SharedStorage ss                = new SharedStorage();        
        RemoteDataClass remoteDataClass = new RemoteDataClass();
        
        public HarpSlotsForm()
        {
            InitializeComponent();
            
            sharedFolder = $@"{Application.StartupPath}\temp\";
            
            
           FormInstances.Instance().HarpNotifies.Register4Info(NotifyInfoHandler);
           LanguageClass.Instance().RegisterChangeNotifiy(languageChanged);
        }

        private void NotifyInfoHandler(object sender, MessageEventArgs k)
        {
            if (k.Data.GetType() == typeof(RemoteDataClass))
            {
                var hdc = (RemoteDataClass)k.Data;
                FormInstances.Instance().hc.SetCancel(hdc.Cancel);
            }
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
            /*
            try
            {                
                ss.SharedFolder = sharedFolder;
                ss.StorageName = this.Name;
                ss.DestroyWhenDisposed = false;
                var mw2 = (HarpSlotsFormDesign)ss["FormData"];
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
            catch(Exception ex)
            {                 
               
            }
            */
        }
        private void SaveFormDesign()
        {
            /*
            if ((mw != null) && (ss != null))
            {   
                if(!Directory.Exists(sharedFolder)) Directory.CreateDirectory(sharedFolder);

                ss.SharedFolder = sharedFolder;
                ss.StorageName = this.Name;
                ss.AddOrUpdate("FormData", mw);
            }
            */
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           this.Text = "Harp Slots";
           LoadFormDesign();           
           FirstRun = false;
        }
        
        public bool FirstRun = true;
       
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            remoteDataClass.Cancel = true;
            SaveFormDesign();            
            e.Cancel = true;
            this.Hide();
        }
       
        private void hsCloseApp_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
