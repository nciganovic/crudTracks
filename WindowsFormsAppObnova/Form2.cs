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
    public partial class Form2 : Form
    {
        private int id;
        
        public Form2()
        {
            InitializeComponent();
            PopulateDropDown(GetMediaType(), cbx_mediaType);
            PopulateDropDown(GetAlbum(), cbx_album);
            PopulateDropDown(GetGenre(), cbx_genre);
            PopulatePlaylist();

            button1.Visible = true;
        }

        public Form2(int id)
        {
            InitializeComponent();
            PopulateDropDown(GetMediaType(), cbx_mediaType);
            PopulateDropDown(GetAlbum(), cbx_album);
            PopulateDropDown(GetGenre(), cbx_genre);
            PopulatePlaylist();

            this.id = id;
            EditSongDto currentSongDto = GetSongById().First() as EditSongDto;
            SetDefaultValues(currentSongDto);

            btn_updatesongf2.Visible = true;
        }

        private void SetDefaultValues(EditSongDto dto) {
            txb_songname.Text = dto.Name;
            txb_bytes.Text = dto.Bytes.ToString();
            txb_composer.Text = dto.Composer;
            txb_milisec.Text = dto.Miliseconds.ToString();
            txb_unitprice.Text = dto.Price.ToString();

            cbx_album.SelectedIndex = dto.AlbumId; //might be wrong
            cbx_genre.SelectedIndex = dto.GenreId; //might be wrong
            cbx_mediaType.SelectedIndex = dto.MediaId; //might be wrong
        }

        private void PopulateDropDown(IEnumerable<Dto> data, ComboBox c)
        {
            c.DisplayMember = "Name";
            c.ValueMember = "Id";
            c.DataSource = data;
        }

        private IEnumerable<Dto> GetSongById()
        {
            var operation = new GetSongByIdOperation(id);
            var data = OperationManager.Instance.Exec(operation);
            return data.Data as IEnumerable<EditSongDto>;
        }

        private IEnumerable<Dto> GetAlbum()
        {
            var operation = new GetAlbumOperation();
            var data = OperationManager.Instance.Exec(operation);
            return data.Data as IEnumerable<AlbumDto>;
        }

        private IEnumerable<Dto> GetMediaType() {
            var operation = new GetMediaTypeOperation();
            var data = OperationManager.Instance.Exec(operation);
            return data.Data as IEnumerable<MediaTypeDto>;
        }

        private IEnumerable<Dto> GetGenre()
        {
            var operation = new GetGenreOperation();
            var data = OperationManager.Instance.Exec(operation);
            return data.Data as IEnumerable<GenreDto>;
        }

        private IEnumerable<Dto> GetPlaylist()
        {
            var operation = new GetPlaylistOperation();
            var data = OperationManager.Instance.Exec(operation);
            return data.Data as IEnumerable<PlaylistDto>;
        }

        private void PopulatePlaylist() {
            var playlist = GetPlaylist();
            foreach (var p in playlist) {
                playlistCheckbox.Items.Add(p); 
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private CreateSongDto CollectFormData() {
            CreateSongDto dto = new CreateSongDto();

            try
            {
                dto.Name = txb_songname.Text.Trim();
                dto.AlbumId = (cbx_album.SelectedItem as AlbumDto).Id;
                dto.Composer = txb_composer.Text.Trim();
                dto.Bytes = Convert.ToInt32(txb_bytes.Text.Trim());
                dto.Miliseconds = Convert.ToInt32(txb_milisec.Text.Trim());
                dto.Price = Convert.ToDecimal(txb_unitprice.Text.Trim());
                dto.MediaId = (cbx_mediaType.SelectedItem as MediaTypeDto).Id;
                dto.GenreId = (cbx_genre.SelectedItem as GenreDto).Id;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            //Playlist
            var selectedPlaylists = playlistCheckbox.CheckedItems;
            foreach (var playlist in selectedPlaylists)
            {
                dto.PlaylistIDs.Add((playlist as PlaylistDto).Id);
            }

            return dto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateSongDto dto = CollectFormData();

            try
            {
                var operation = new CreateSongOperation(dto);
                operation.Execute();

                MessageBox.Show("Uspesan unos!");

                txb_songname.Text = "";
                txb_composer.Text = "";
                cbx_mediaType.SelectedItem = 1;
                cbx_genre.SelectedItem = 1;
                cbx_album.SelectedItem = 1;
                txb_unitprice.Text = "";
            }
            catch (Exception exp) {
                MessageBox.Show(exp.Message);
            }

        }

        private void btn_updatesongf2_Click(object sender, EventArgs e)
        {
            CreateSongDto dto = CollectFormData();

            dto.SongId = id;

            try
            {
                var operation = new CreateSongOperation(dto);
                operation.Execute();

                MessageBox.Show("Uspesan update!");

                this.Dispose();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
