using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillageNewbiesOhjelmisto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mokkiDataset.lasku' table. You can move, or remove it, as needed.
            this.laskuTableAdapter.Fill(this.mokkiDataset.lasku);
            // Täällä otetaan tietokannsta tiedot dataGridView:hin

            // TODO: This line of code loads data into the 'mokkiDataset.palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter.Fill(this.mokkiDataset.palvelu);
            // TODO: This line of code loads data into the 'mokkiDataset.varaus' table. You can move, or remove it, as needed.
            this.varausTableAdapter.Fill(this.mokkiDataset.varaus);
            // TODO: This line of code loads data into the 'mokkiDataset.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.mokkiDataset.asiakas);

            // TODO: This line of code loads data into the 'hoviDataset.toimintaalue' table. You can move, or remove it, as needed.
            this.toimintaalueTableAdapter.Fill(this.hoviDataset.toimintaalue);
            // TODO: This line of code loads data into the 'hoviDataset.posti' table. You can move, or remove it, as needed.
            this.postiTableAdapter.Fill(this.hoviDataset.posti);

            // TODO: This line of code loads data into the 'hoviDataset.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.hoviDataset.mokki);

            //comboBPalvelut.DataSource = mokkiDataset.palvelu.Rows[0];
            //comboBPalvelut.Items.Insert(0, );
            comboBPalvelut.SelectedItem = 0;
            //comboBPalvelut.SelectedText = "Ei palvelua";

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Nimi", 50);
            listView1.Columns.Add("Kpl", 35);
            listView1.Columns.Add("Hinta", 35);
            listView1.Columns.Add("ALV", 35);
        }

        private void lisaaPalvelu(string nimi, string kpl, string hinta, string alv) {
            // Tämä lisää listView:iin uuden palvelun
            string[] row = { nimi, kpl, hinta, alv };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }

        private void BtnLisaa_Click(object sender, EventArgs e)
        {
            // Lisää painike laittaa uuden mökin tiedot tietokantaan
            // ja päivittää sen
            // Lisää painiketta painettaessa se katsoo ensin, onko
            // jo olemassa olevia tietoja tietokannassa, jotta niitä 
            // ei tarvitsi tehdä usempaan kertaan.

            int toimintaalueID = 0;
            //if (mokkiTableAdapter.GetMokkinimi(tbMokkinimi.Text) == null) {
                Validate();
                osastoBindingSource.EndEdit();
                mokkiTableAdapter.Update(this.hoviDataset);

                if (toimintaalueTableAdapter.
                    GetToimintaalueID(tbToimialue.Text) == null)
                {
                    toimintaalueTableAdapter.Insert(tbToimialue.Text);
                }
                toimintaalueID = (int)toimintaalueTableAdapter.
                        GetToimintaalueID(tbToimialue.Text);

                if (postiTableAdapter.GetPostinro(tbPostinumero.Text) == null)
                {
                    postiTableAdapter.Insert(tbPostinumero.Text,
                    tbPostitoimipaikka.Text);
                }


                mokkiTableAdapter.Insert(toimintaalueID,
                    tbPostinumero.Text, tbMokkinimi.Text,
                    tbKatuosoite.Text
                    , tbKuvaus.Text,
                    int.Parse(tbHenkilomaara.Text),
                    tbVarustelu.Text);
            mokkiTableAdapter.InsertHinta(int.Parse(tbHintaMokki.Text));

                tyhjennaTextBoksit();
            //}
            this.mokkiTableAdapter.Fill(this.hoviDataset.mokki);
        }

        private void BtnPoista_Click(object sender, EventArgs e)
        {
            // Poista nappi poistaa mökin tietokannsta ja päivittää
            // dataGridViewvin

            mokkiTableAdapter.DeleteRow(tbPostinumero.Text, 
                tbMokkinimi.Text, tbKatuosoite.Text, tbKuvaus.Text, 
                tbVarustelu.Text);
            tyhjennaTextBoksit();
            this.mokkiTableAdapter.Fill(this.hoviDataset.mokki);
        }

        private void tyhjennaTextBoksit() {
            // Tyhjentää textboxit

            tbToimialue.Text = "";
            tbPostitoimipaikka.Text = "";
            tbPostinumero.Text = "";
            tbMokkinimi.Text = "";
            tbKatuosoite.Text = "";
            tbKuvaus.Text = "";
            tbHenkilomaara.Text = "";
            tbVarustelu.Text = "";
            tbHintaMokki.Text = "";       }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kun painaa dataGridView:stä, varaukset muuttuu 
            // sitä mukaan mitä se on assosioitunut tietyn mökin kanssa.
            int mokkiID = int.Parse(dgvMokkiNakyma.CurrentRow.Cells[0].Value.ToString());

            if (e.RowIndex < hoviDataset.mokki.Count && e.RowIndex != -1) {
                DataGridViewRow dgvRow = dgvMokkiNakyma.Rows[e.RowIndex];
                tbToimialue.Text = toimintaalueTableAdapter.
                    GetToimintaNimi(int.Parse(dgvRow.Cells[1].Value.ToString()));
                tbPostitoimipaikka.Text = postiTableAdapter.
                    GetPostitoimipaikka(dgvRow.Cells[2].Value.ToString());
                tbHintaMokki.Text = mokkiTableAdapter.
                    GetHintaFromMokki(mokkiID).ToString();

                int toimintaAlueId = int.Parse(dgvMokkiNakyma.CurrentRow.Cells[1].Value.ToString());
                DataTable dt = palveluTableAdapter.GetDataByToimintaID(toimintaAlueId);
                if (dt.Rows.Count == 0)
                {
                    comboBPalvelut.DataSource = new DataTable();
                    comboBPalvelut.SelectedItem = 0;
                    comboBPalvelut.SelectedText = "Ei palvelua";
                }
                else
                {
                    comboBPalvelut.DataSource = dt;
                    //comboBPalvelut.ValueMember = "toimintaalue_id";
                    comboBPalvelut.DisplayMember = "nimi";
                }
                varausTableAdapter.FillBySearch(this.mokkiDataset.varaus,
                    int.Parse(dgvRow.Cells[0].Value.ToString()));

                tyhjennaVaraukset();
                lblMokinHinta.Text = "";
                lblMokinYot.Text = "";
                lblMokinYhtHinta.Text = "";
                mcKalenteri.SetSelectionRange(DateTime.Now, DateTime.Now);
            }
        }

        private void BtnMuokkaa_Click(object sender, EventArgs e)
        {
            // Pystyy muokkaamaan mökin tietoja query:llä

            if (toimintaalueTableAdapter.GetToimintaalueID(tbToimialue.Text) == null) {
                toimintaalueTableAdapter.Insert(tbToimialue.Text);
            }
            int mokkiID = int.Parse(dgvMokkiNakyma.CurrentRow.Cells[0].Value.ToString());
            int toimiAlueID = (int)toimintaalueTableAdapter.GetToimintaalueID(tbToimialue.Text);

            //tbEtunimi.Text = mokkiID.ToString();

            mokkiTableAdapter.UpdateQueryMokki(toimiAlueID,
                tbPostinumero.Text, tbMokkinimi.Text, tbKatuosoite.Text, 
                tbKuvaus.Text, int.Parse(tbHenkilomaara.Text), tbVarustelu.Text, 
                mokkiID);
            postiTableAdapter.UpdateToimipaikkaByPostinro(tbPostitoimipaikka.Text, 
                tbPostinumero.Text);
            mokkiTableAdapter.
                    UpdateQueryHinta(int.Parse(tbHintaMokki.Text), mokkiID);
            this.mokkiTableAdapter.Fill(this.hoviDataset.mokki);
        }

        private void TbHaku_TextChanged(object sender, EventArgs e)
        {
            // Haetaan query:llä tietyn nimisiä mökkejä.

            mokkiTableAdapter.FillBySearch(this.hoviDataset.mokki,
                "%" + tbHaku.Text + "%", "%" + tbHaku.Text + "%");
        }

        private void BtnLisaaAsiakas_Click(object sender, EventArgs e)
        {
            // Jos ei ole jo olemassa olevaa postinumeroa ja emailia
            // tehdään ne uudet.
            // Lisää uuden varauksen tietokantaan. mökin numeron se ottaa
            // valittuna olevasta mökistä dataGridViev:stä.
            // Aikajanan se ottaa MonthCalendar:sta.

            if (postiTableAdapter.GetPostinro(tbPostinroAsiakas.Text) == null)
            {
                postiTableAdapter.Insert(tbPostinroAsiakas.Text,
                tbPostitoimipaikkaAsiakas.Text);
            }
            if (asiakasTableAdapter.GetAsiakasIDByEmail(tbEmail.Text) == null)
            {
                asiakasTableAdapter.Insert(tbPostinroAsiakas.Text,
                tbEtunimi.Text, tbSukunimi.Text,
                tbLahiosoite.Text, tbEmail.Text, tbPuhelinnro.Text);
            }

            string mokkiID = dgvMokkiNakyma.CurrentRow.Cells[0].Value.ToString();


            DateTime dateNow = DateTime.Now;
            int asiakasID = (int)asiakasTableAdapter.GetAsiakasIDByEmail(tbEmail.Text);

            varausTableAdapter.Insert(asiakasID, int.Parse(mokkiID), dateNow, 
                dateNow.AddDays(7), mcKalenteri.SelectionStart.Date,
                mcKalenteri.SelectionEnd.Date);

            varausTableAdapter.FillBySearch(this.mokkiDataset.varaus,
                    int.Parse(mokkiID));

            tyhjennaVaraukset();
        }

        private void BtnPoistaAsiakas_Click(object sender, EventArgs e)
        {
            // Poistaa varauksen tietokannalta ja päivittää dataGridView:n

            string mokkiID = dgvMokkiNakyma.CurrentRow.Cells[0].Value.ToString();

            varausTableAdapter.DeleteQueryByAsiakasID(int.Parse(
                dgvAsiakkaat.CurrentRow.Cells[1].Value.ToString()));


            varausTableAdapter.FillBySearch(this.mokkiDataset.varaus,
                    int.Parse(mokkiID));

            tyhjennaVaraukset();
        }

        private void DgvAsiakkaat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kun painaa varauksesta, sen varaaman henkilön tiedot
            // näkyvät textbox:eissa.
            // Myös MonthCalendar:iin tulee näkyviin sen henkilön varaaman
            // aikajanan.
            if (e.RowIndex < mokkiDataset.varaus.Count && e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvAsiakkaat.Rows[e.RowIndex];

                DateTime alku = Convert.ToDateTime(varausTableAdapter.
                GetVarattuAlkuPvm(int.Parse(dgvRow.Cells[0].Value.ToString())));
                DateTime loppu = Convert.ToDateTime(varausTableAdapter.GetLoppuPvm(int.
                    Parse(dgvRow.Cells[0].Value.ToString())));

                mcKalenteri.SelectionRange = new SelectionRange(alku, loppu);

                tbEtunimi.Text = asiakasTableAdapter.GetEtunimi(int.Parse(dgvRow.Cells[0].Value.ToString()));
                tbSukunimi.Text = asiakasTableAdapter.GetSukunimi(int.Parse(dgvRow.Cells[0].Value.ToString()));
                tbPostinroAsiakas.Text = asiakasTableAdapter.GetPostinumero(int.Parse(dgvRow.Cells[0].Value.ToString()));
                tbPostitoimipaikkaAsiakas.Text = postiTableAdapter.
                    GetPostitoimipaikka(asiakasTableAdapter.GetPostinumero(int.Parse(dgvRow.Cells[0].Value.ToString())));
                tbLahiosoite.Text = asiakasTableAdapter.GetLahiosoite(int.Parse(dgvRow.Cells[0].Value.ToString()));
                tbEmail.Text = asiakasTableAdapter.GetEmail(int.Parse(dgvRow.Cells[0].Value.ToString()));
                tbPuhelinnro.Text = asiakasTableAdapter.GetPuhelinnro(int.Parse(dgvRow.Cells[0].Value.ToString()));

                int paivat = (int)((loppu - alku).TotalDays) + 1;
                lblMokinYot.Text = paivat.ToString();
                int mokkiID = int.Parse(dgvMokkiNakyma.CurrentRow.Cells[0].Value.ToString());
                int mokinHinta = int.Parse(mokkiTableAdapter.GetHintaFromMokki(mokkiID).ToString());
                lblMokinHinta.Text = mokinHinta.ToString();
                lblMokinYhtHinta.Text = (paivat * mokinHinta).ToString();

                laskuTableAdapter.FillByVarausID(this.mokkiDataset.lasku, 
                    int.Parse(dgvAsiakkaat.CurrentRow.Cells[1].Value.ToString()));
            }
            else {
                tyhjennaVaraukset();
                lblMokinHinta.Text = "";
                lblMokinYot.Text = "";
                lblMokinYhtHinta.Text = "";
            }
        }

        public void tyhjennaVaraukset() {
            // Tyhjentää asiakkaan textBox:it

            tbEtunimi.Text = "";
            tbSukunimi.Text = "";
            tbPostinroAsiakas.Text = "";
            tbPostitoimipaikkaAsiakas.Text = "";
            tbLahiosoite.Text = "";
            tbEmail.Text = "";
            tbPuhelinnro.Text = "";
        }

        private void BtnTyhjennaVaraukset_Click(object sender, EventArgs e)
        {
            tyhjennaVaraukset();
        }

        private void BtnTyhjennä_Click(object sender, EventArgs e)
        {
            tyhjennaTextBoksit();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //Graphics g = this.CreateGraphics();
            //bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            //Graphics mg = Graphics.FromImage(bmp);
            //mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private string tulostaRivit(ListView list) {
            string tulostus = "";
            //tulostus = list.Items[1].SubItems[1].Text;
            for (int i = 0; i < list.Columns.Count; i++)
            {
                tulostus += list.Columns[i].Text + "\t \t";
            }
            tulostus += "\n";
            for (int a = 0; a < list.Items.Count; a++)
            {
                for (int c = 0; c < list.Columns.Count; c++)
                {
                    tulostus += list.Items[a].SubItems[c].Text + "\t \t";
                }
                tulostus += "\n";
            }
            return tulostus;
        }

        private double tulostaMaksettava(ListView list) {
            double hinta = 0;

            for (int i = 0; i < list.Items.Count; i++)
            {
                hinta += int.Parse(list.Items[i].SubItems[1].Text) * 
                    int.Parse(list.Items[i].SubItems[2].Text) *
                    int.Parse(list.Items[i].SubItems[3].Text);
            }
            hinta += int.Parse(lblMokinYhtHinta.Text) * 1.24;
            return hinta;
        }
        
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //e.Graphics.DrawImage(bmp, 0, 0);
            e.Graphics.DrawString("Village Newbies Oy", new Font("Aerial", 12,
                FontStyle.Regular), Brushes.Black, new Point(50, 50));
            e.Graphics.DrawString(tbEtunimi.Text +" " + tbSukunimi.Text +"\n"
                + tbLahiosoite.Text +"\n" +tbPostinroAsiakas.Text +" "
                +tbPostitoimipaikkaAsiakas.Text + "\n" +tbEmail.Text +"\n"
                +"Puh: " +tbPuhelinnro.Text
                , new Font("Aerial", 12,
                FontStyle.Regular), Brushes.Black, new Point(50, 150));
            e.Graphics.DrawString("-----------------------------------------" +
                "----------------------------------------------------------" +
                "-----------------------------------", new Font("Aerial", 12,
                FontStyle.Regular), Brushes.Black, new Point(50, 250));
            e.Graphics.DrawString("Palvelut: \n\n" +tulostaRivit(listView1), new Font("Aerial", 12,
                FontStyle.Regular), Brushes.Black, new Point(50, 450));
            e.Graphics.DrawString("Mökki: \n" +tbMokkinimi.Text 
                + "\t\tÖitä: " +lblMokinYot.Text +"\t\tHinta/Yö: " +lblMokinHinta.Text
                +"\tHinta Yht: " +lblMokinYhtHinta.Text +"\n" 
                +tbKatuosoite.Text +"\n" +tbPostinumero.Text +" " 
                +tbPostitoimipaikka.Text +"\nVarustelu: " +tbVarustelu.Text
                , new Font("Aerial", 12,
                FontStyle.Regular), Brushes.Black, new Point(50, 300));
            e.Graphics.DrawString("Lasku \n\n\nPäivämäärä: \t\t" +DateTime.Now.ToShortDateString()
                +"\nLaskun numero:\nViitteenne\nAsiakasnumero\n" +
                "Toimituspäivä laskulle: \t" +DateTime.Now.AddDays(3).ToShortDateString()
                +"\nToimituspaketti: \t\t Postipaketti\nHuomautusaika: \t\t 7 vrk", new Font("Aerial", 12,
                FontStyle.Regular), Brushes.Black, new Point(500, 60));
            e.Graphics.DrawString("Maksettava: \t" +tulostaMaksettava(listView1) +"€", new Font("Aerial", 12,
                FontStyle.Regular), Brushes.Black, new Point(500, 800));
        }
        Bitmap bmp;

        private void BtnLisaaPalvelu_Click(object sender, EventArgs e)
        {
            if (toimintaalueTableAdapter.GetToimintaalueID(tbToimintaalue.Text) == null)
            {
                toimintaalueTableAdapter.Insert(tbToimintaalue.Text);
            }
            //int toimiID = (int)toimintaalueTableAdapter.GetToimintaalueID(tbToimintaalue.Text);

            palveluTableAdapter.Insert(int.Parse(tbPalveluID.Text),
                (int)toimintaalueTableAdapter.GetToimintaalueID(tbToimintaalue.Text), 
                tbNimi.Text, int.Parse(tbTyyppi.Text), tbKuvaus.Text, 
                double.Parse(tbHinta.Text), double.Parse(tbAlv.Text));

            palveluTableAdapter.Fill(this.mokkiDataset.palvelu);
        }

        private void BtnPoistaPalvelu_Click(object sender, EventArgs e)
        {
            try
            {
                int palveluID = int.Parse(dgvPalvelut.SelectedCells[0].Value.ToString());
                palveluTableAdapter.DeleteQueryByPalveluID(palveluID);
            }
            catch (Exception)
            {
                
            }
            
        }

        private void BtnLisaaPalv_Click(object sender, EventArgs e)
        {
            int toimintaAlueId = int.Parse(dgvMokkiNakyma.CurrentRow.Cells[1].Value.ToString());
            DataTable dt = palveluTableAdapter.GetDataByToimintaID(toimintaAlueId);
            if (dt.Rows.Count != 0){
                DataRowView rowView = comboBPalvelut.SelectedItem as DataRowView;
                string jota = rowView.Row["Nimi"] as string;
                //listBoxPalvelut.Items.Add(jota + numericUpDown1.Value.ToString());
                lisaaPalvelu(jota, numericUpDown1.Value.ToString(),
                    palveluTableAdapter.GetHintaFromPalvelu(jota, toimintaAlueId).ToString(),
                    palveluTableAdapter.GetAlvFromPalvelu(jota, toimintaAlueId).ToString());
            }

            //DataTable dt = palveluTableAdapter.GetDataByToimintaID(toimintaAlueId);
            //comboBPalvelut.DataSource = dt;
            //comboBPalvelut.ValueMember = "toimintaalue_id";
            //comboBPalvelut.DisplayMember = "nimi";
        }

        private void BtnLaskuMaksettu_Click(object sender, EventArgs e)
        {
            //int VarausID = int.Parse(dgvAsiakkaat.CurrentRow.Cells[1].Value.ToString());
            //laskuTableAdapter.InsertWithoutLaskuID(VarausID, (decimal)tulostaMaksettava(listView1), (decimal)24.0);
            //laskuTableAdapter.FillByVarausID(this.mokkiDataset.lasku,
            //        int.Parse(dgvAsiakkaat.CurrentRow.Cells[1].Value.ToString()));


        }
    }
}
