using BasicClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HarpMeNow
{
    public partial class HarpEditForm : Form
    {
        private Harp harp;
        NotifiesClass remoteNotify;
        public HarpEditForm(NotifiesClass notify)
        {
            InitializeComponent();
            remoteNotify = notify;
        }
        SQLDataClass sq = new SQLDataClass(FormInstances.Instance().DatabaseFile);
        public void SetData(Guid guid)
        {
            List<Harp> harps = sq.GetID(guid);
            if(harps.Count == 1)
            {
                harp = harps[0];
            
            }
        }

        public void DataToEdit()
        {
            txtName.Text        = harp.Name;
            txtDescription.Text = harp.Description;
            cbKey.SelectedIndex = cbKey.FindStringExact(harp.Key.ToString());
        }

        public void EditToData()
        {
            harp.Name           = txtName.Text;
            harp.Description    = txtDescription.Text;
            harp.Key            = (eKey)cbKey.SelectedItem;
            harp.Stamp          = DateTime.Now;
        }

        private void hsSave_Click(object sender, EventArgs e)
        {
            EditToData();            
            sq.UpdateDatas(harp);
            remoteNotify.AddToDataSaved(harp);
            Close();
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HarpEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormInstances.Instance().harpEditForm = null;
        }

        private void HarpEditForm_Load(object sender, EventArgs e)
        {
            cbKey.Items.Add(eKey.C_DUR);
            cbKey.Items.Add(eKey.D_DUR);
            cbKey.Items.Add(eKey.E_DUR);
            cbKey.Items.Add(eKey.G_DUR);
            DataToEdit();
        }
    }
}
