using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppObnova.BusinessLayer;

namespace WindowsFormsAppObnova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateGridView();
        }

        private void PopulateGridView() {
            var getSongs = new GetSongOperation();
            var data = getSongs.Execute().Data as IEnumerable<SongDto>;
            this.dgv_songs.DataSource = data;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            var createForm = new Form2();
            createForm.Show();
        }

        private int GetSelectedId() {
            var rowIndex = dgv_songs.SelectedCells[0].RowIndex;
            var row = dgv_songs.Rows[rowIndex];
            var dto = row.DataBoundItem as SongDto;
            return dto.Id;
        }

        private void dgv_songs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var deleteOperation = new DeleteSongOperation(GetSelectedId());

            try {
                deleteOperation.Execute();
                MessageBox.Show("Uspesno brisanje.");
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var createForm = new Form2(GetSelectedId());
            createForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txb_search.Text.Trim();
                var operation = new GetSongOperation(keyword);
                var data = operation.Execute().Data as IEnumerable<SongDto>;
                this.dgv_songs.DataSource = data;
            }
            catch (Exception exp) {
                MessageBox.Show(exp.Message);
            }
            
        }
    }
}
