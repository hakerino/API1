using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;


namespace API1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonCerca.Click += ButtonCerca_Click;
        }

        //private void buttonCaricaLibro_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.Filter = "Text Files (*.txt)|*.txt";

        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        string[] righe = File.ReadAllLines(openFileDialog.FileName);

        //        listBoxCapitoli.Items.Clear();

        //        string capitoloCorrente = "";
        //        List<string> testoCapitolo = new List<string>();

        //        foreach (string riga in righe)
        //        {
        //            if (riga.StartsWith("Chapter", StringComparison.OrdinalIgnoreCase) || riga.StartsWith("CHAPTER"))
        //            {
        //                if (!string.IsNullOrEmpty(capitoloCorrente))
        //                {
        //                    listBoxCapitoli.Items.Add(new
        //                    {
        //                        Titolo = capitoloCorrente,
        //                        Contenuto = string.Join(Environment.NewLine, testoCapitolo)
        //                    });
        //                }

        //                capitoloCorrente = riga.Trim();
        //                testoCapitolo.Clear();
        //            }
        //            else
        //            {
        //                testoCapitolo.Add(riga);
        //            }
        //        }

        //        if (!string.IsNullOrEmpty(capitoloCorrente))
        //        {
        //            listBoxCapitoli.Items.Add(new
        //            {
        //                Titolo = capitoloCorrente,
        //                Contenuto = string.Join(Environment.NewLine, testoCapitolo)
        //            });
        //        }

        //        listBoxCapitoli.DisplayMember = "Titolo";
        //    }
        //}

        //private void listBoxCapitoli_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    var item = listBoxCapitoli.SelectedItem;
        //    if (item != null)
        //    {
        //        var prop = item.GetType().GetProperty("Contenuto");
        //        string contenuto = prop.GetValue(item)?.ToString();
        //        listBoxCapitoli.Text = contenuto;
        //    }
        //}

        private async void ButtonCerca_Click(object sender, EventArgs e)
        {
            string parola = textBoxParola.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(parola))
            {
                MessageBox.Show("Inserisci una parola da cercare.");
                return;
            }

            await CercaDefinizione(parola);
        }
        private async Task CercaSinonimiEContrari(string parola)
        {
            listBoxSinonimi.Items.Clear();
            listBoxContrari.Items.Clear();

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string urlSinonimi = $"https://api.datamuse.com/words?rel_syn={parola}";
                    string jsonSinonimi = await client.GetStringAsync(urlSinonimi);
                    JArray sinonimi = JArray.Parse(jsonSinonimi);

                    listBoxSinonimi.Items.Add("Sinonimi:");
                    foreach (var item in sinonimi)
                    {
                        listBoxSinonimi.Items.Add(item["word"].ToString());
                    }

                    string urlContrari = $"https://api.datamuse.com/words?rel_ant={parola}";
                    string jsonContrari = await client.GetStringAsync(urlContrari);
                    JArray contrari = JArray.Parse(jsonContrari);

                    listBoxContrari.Items.Add("Contrari:");
                    foreach (var item in contrari)
                    {
                        listBoxContrari.Items.Add(item["word"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore nel recupero di sinonimi e contrari.");
                }
            }
        }

        private async Task CercaDefinizione(string parola)
        {
            listBoxDefinizioni.Items.Clear();

            string url = $"https://api.dictionaryapi.dev/api/v2/entries/en/{parola}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(url);
                    JArray array = JArray.Parse(json);

                    foreach (var meaning in array[0]["meanings"])
                    {
                        string parteDelDiscorso = meaning["partOfSpeech"]?.ToString();
                        listBoxDefinizioni.Items.Add($"--- {parteDelDiscorso} ---");

                        foreach (var def in meaning["definitions"])
                        {
                            string definizione = def["definition"]?.ToString();
                            string esempio = def["example"]?.ToString();

                            listBoxDefinizioni.Items.Add($"Definizione: {definizione}");
                            if (!string.IsNullOrEmpty(esempio))
                            {
                                listBoxDefinizioni.Items.Add($"Esempio: {esempio}");
                            }
                            listBoxDefinizioni.Items.Add(""); 
                        }
                    }
                }
                catch (HttpRequestException ex)
                {
                    listBoxDefinizioni.Items.Add("Errore di connessione all'API.");
                }
                catch (Exception ex)
                {
                    listBoxDefinizioni.Items.Add("Parola non trovata o errore nella risposta.");
                }
            }
        }

        private async void buttonCaricaLibro_Click_1(object sender, EventArgs e)
        {
            
            string parola = textBoxParola.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(parola))
            {
                MessageBox.Show("Inserisci una parola da cercare.");
                return;
            }

            await CercaDefinizione(parola);
            await CercaSinonimiEContrari(parola);
        }
    }
}

