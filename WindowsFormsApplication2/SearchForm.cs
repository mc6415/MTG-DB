using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApplication2
{
    public partial class SearchForm : Form
    {
        static string cardjson = File.ReadAllText("../debug/json/AllCards-x.json");
        static dynamic cardList = JsonConvert.DeserializeObject(cardjson);
        static string setjson = File.ReadAllText("../debug/json/AllSets-x.json");
        static dynamic setList = JsonConvert.DeserializeObject(setjson);
        IEnumerable<dynamic> sets = setList;
        IEnumerable<dynamic> cards = cardList;

        public SearchForm()
        {
            InitializeComponent();            
        }

        public void searchCards(string name)
        {
            if (cards.Where(c => c.Name.ToLower().Contains(name.ToLower())).Count() > 1)
            {
                searchResults.Items.Clear();
                searchResults.Visible = true;
                multiResults(name);
            }
            else if (cards.Where(c => c.Name.ToLower().Contains(name.ToLower())).Count() == 0)
            {

            } else
            {
                setCardDetails(name);
            }
        }

        public string getSetName(string code)
        {
            var set = sets.Where(s => s.Name == code).FirstOrDefault();

            return set.Value["name"];
        }

        public void multiResults(string name)
        {
            var results = cards.Where(c => c.Name.ToLower().Contains(name.ToLower())).ToList();

            foreach(var card in results)
            {
                searchResults.Items.Add(card.Name);
            }
        }

        public IEnumerable<dynamic> getPrinting(JArray setCodes, string cardName)
        {
            foreach(string code in setCodes)
            {
                IEnumerable<dynamic> set = sets.Where(s => s.Name == code).FirstOrDefault().Value["cards"];
                var card = set.Where(c => c["name"] == cardName).FirstOrDefault();
                if (card.multiverseid != null)
                {
                    return card;
                }
            }

            return sets;
        }

        public dynamic getCard(string name)
        {            
            return cards.Where(c => c.Name.ToLower().Contains(name.ToLower())).FirstOrDefault();
        }

        public void setCardDetails(string name)
        {           
            var card = getCard(name);
            var defPrint = card.Value["printings"];
            var printing = getPrinting(card.Value["printings"], card.Name);
            string url = "http://gatherer.wizards.com/Handlers/Image.ashx?multiverseid="+printing.multiverseid+"&type=card";
            cardImage.Load(url);
            label1.Text = card.Name;
            textBox1.Text = card.Name;
            rulesText.Text = printing.text;
            printingList.Visible = true;
            foreach(var p in card.Value["printings"])
            {
                printingList.Items.Add(getSetName(p.Value));
            }
        }

        public void getSetArtwork(string setName, string cardName)
        {
            var setCode = sets.Where(s => s.Value["name"] == setName).FirstOrDefault().Name;

            IEnumerable<dynamic> set = sets.Where(s => s.Name == setCode).FirstOrDefault().Value["cards"];
            var card = set.Where(c => c["name"] == cardName).FirstOrDefault();

            if (card.multiverseid != null)
            {
                string url = "http://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=" + card.multiverseid + "&type=card";
                cardImage.Load(url);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchResults.Items.Clear();
            searchResults.Visible = false;
            printingList.Items.Clear();
            printingList.Visible = false;
            searchCards(textBox1.Text);
        }

        private void searchResults_SelectedIndexChanged(object sender, EventArgs e)
        {            
            setCardDetails(searchResults.SelectedItem.ToString());
            searchResults.Items.Clear();
            searchResults.Visible = false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                searchResults.Items.Clear();
                searchResults.Visible = false;
                printingList.Items.Clear();
                printingList.Visible = false;
                searchCards(textBox1.Text);
            }
        }

        private void printingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            getSetArtwork(printingList.SelectedItem.ToString(), textBox1.Text);
        }
    }
}
