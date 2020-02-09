using BasicClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace HarpMeNow
{
    public partial class InstrumentsForm : Form
    {
        NotifiesClass localNotify = new NotifiesClass();
        public InstrumentsForm()
        {
            InitializeComponent();
            localNotify.Register4Info(Notify_OnRaiseInfoHandler);
        }

        private void Notify_OnRaiseInfoHandler(object sender, MessageEventArgs k)
        {
            if(k.Key.ToString() == NotifyInfoCodes.DataSaved)
            {
                LoadDatas(FormInstances.Instance().DatabaseFile);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void SaveInitialHarps(string fileName)
        {
            if (File.Exists(FormInstances.Instance().DatabaseFile)) File.Delete(FormInstances.Instance().DatabaseFile);
            HarpInstrumentClass hi = HarpInstrumentFactory.SeydelDeLuxeSteelOrchestra(eKey.C_DUR);
            
            Harp ins = new Harp();
            List<AirSlotAttributesClass> airSlots = new List<AirSlotAttributesClass>(); 
            airSlots.AddRange(hi.InstrumentNotesDefinition.Keys);            
            ins.AirSlots = airSlots;
            ins.Name = hi.Name;
            ins.Description = hi.Name;
            ins.Stamp = DateTime.Now;
            ins.Key = hi.Key;
            var sq = new SQLDataClass(fileName);
            sq.InsertDatas(ins);

            
            hi = HarpInstrumentFactory.HohnerUnsereLieblinge(eKey.C_DUR);
            ins = new Harp();
            airSlots = new List<AirSlotAttributesClass>();
            airSlots.AddRange(hi.InstrumentNotesDefinition.Keys);
            ins.AirSlots = airSlots;
            ins.Name = hi.Name;
            ins.Description = hi.Name;
            ins.Stamp = DateTime.Now;
            ins.Key = hi.Key;
            
            sq.InsertDatas(ins);

            hi = HarpInstrumentFactory.ChroamticStandard(eKey.C_DUR);            
            ins = new Harp();
            airSlots = new List<AirSlotAttributesClass>();
            airSlots.AddRange(hi.InstrumentNotesDefinition.Keys);
            ins.AirSlots = airSlots;
            ins.Name = hi.Name;
            ins.Description = hi.Name;
            ins.Stamp = DateTime.Now;
            ins.Key = hi.Key;
           
            sq.InsertDatas(ins);
        }

        SQLDataClass sq = null;

        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void LoadDatas(string fileName)
        {
            sq = new SQLDataClass(fileName);
            List<Harp> lst = sq.GetAll(); 
            
            dgvDATA.DataSource = lst;

            SetAirSlots(lst[0]);
            FormInstances.Instance().hc.AddHarps(lst);
            HarpInstrumentFactory.HarpDatabaeObject2HarpInstrument(lst[0]);

        }
        private void SetAirSlots(Harp lst)
        {
            if (lst != null)
            {
                var list = sq.GetSortAirSlots(lst.AirSlots);
                dgvSLOTS.DataSource = list;
            }
        }

        private void RefreshAirSlots(string harpName)
        {
            List<Harp> lst = sq.GetInstument(harpName);
            if(lst.Count > 0)
            SetAirSlots(lst[0]);
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDATA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridView grid = sender as DataGridView;
            if (grid.SelectedRows.Count > 0)
            {
                var row = grid.SelectedRows[0];
                string txt = row.Cells[2].Value.ToString();
                RefreshAirSlots(txt);
            }
        }
        public void EditHarp()
        {
            var he = new HarpEditForm(localNotify);
            he.MdiParent = this.MdiParent;
            he.SetData((Guid)dgvDATA.SelectedRows[0].Cells[0].Value);
            he.Show();
        }

        private void cmsHarp_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem == tsmiHarpEdit)
            {
                EditHarp();
            }
        }

        private void InstrumentsForm_Load(object sender, EventArgs e)
        {
            LoadDatas(FormInstances.Instance().DatabaseFile);
        }

        private void hsRefresh_Click(object sender, EventArgs e)
        {
            LoadDatas(FormInstances.Instance().DatabaseFile);
        }

        private void InstrumentsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormInstances.Instance().instrumentsForm = null;
        }

        private void hsSaveInit_Click(object sender, EventArgs e)
        {
            sfvSaveDB.FileName = FormInstances.Instance().DatabaseFile;
            if (sfvSaveDB.ShowDialog() == DialogResult.OK)
            {
                SaveInitialHarps(sfvSaveDB.FileName);
            }
        }

        private void hsLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = FormInstances.Instance().DatabaseFile;
















            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadDatas(openFileDialog1.FileName);
            }
        }

        private void dgvDATA_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDATA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditHarp();
        }
    }
}
