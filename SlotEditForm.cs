using BasicClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HarpMeNow
{
    public partial class SlotEditForm : Form
    {
        private AirSlotAttributesClass slot;
        NotifiesClass remoteNotify;
        public SlotEditForm(NotifiesClass notify)
        {
            InitializeComponent();
            remoteNotify = notify;
        }
        SQLDataClass sq = new SQLDataClass(FormInstances.Instance().DatabaseFile);
        public void SetData(int slt)
        {
            List<AirSlotAttributesClass> slots = sq.GetSlotID(slt);
            if(slots.Count == 1)
            {
                slot = slots[0];
            
            }
        }

        public void DataToEdit()
        {
            txtNote.Text        = slot.NoteStr;
            
        }

        public void EditToData()
        {
            slot.NoteStr       = txtNote.Text;                       
        }

        private void hsSave_Click(object sender, EventArgs e)
        {
            EditToData();            
            sq.UpdateSlotDatas(slot);
            remoteNotify.AddToDataSaved(slot);
            Close();
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SlotEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormInstances.Instance().slotEditForm = null;
        }

        private void SlotEditForm_Load(object sender, EventArgs e)
        {
            cbKey.Items.Add(eKey.C_DUR);
            cbKey.Items.Add(eKey.D_DUR);
            cbKey.Items.Add(eKey.E_DUR);
            cbKey.Items.Add(eKey.G_DUR);
            DataToEdit();
        }
    }
}
