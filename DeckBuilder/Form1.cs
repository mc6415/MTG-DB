﻿using System;
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

namespace DeckBuilder
{
    public partial class Form1 : Form
    {
        static string json = File.ReadAllText("./json/AllCards.json");
        static dynamic cardList = JsonConvert.DeserializeObject(json);
        IEnumerable<dynamic> cards = cardList;

        public Form1()
        {
            InitializeComponent();
            addCards();
            loadDeck("mardu");
        }

        public void addCards()
        {
            foreach(var card in cards)
            {
                listBox1.Items.Add(card.Name);
            }
        }

        public void loadDeck(string deckName)
        {
            listBox2.Items.Clear();
            string deck = File.ReadAllText("./decks/" + deckName + ".json");
            dynamic deckList = JsonConvert.DeserializeObject(deck);
            foreach(var card in deckList)
            {
                listBox2.Items.Add(card);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            listBox1.Items.Clear();
            cards.Where(c => c.Name.ToLower().Contains(textBox1.Text.ToLower())).ToList().ForEach(x => listBox1.Items.Add(x.Name));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try {
                File.Create("./decks/" + deckName.Text + ".json").Close();
                JArray test = new JArray();
                foreach(var item in listBox2.Items)
                {
                    test.Add(item);
                }
                File.WriteAllText("./decks/" + deckName.Text.ToLower() + ".json", test.ToString());
            } catch {
                Directory.CreateDirectory("./decks");
                File.Create("./decks/" + deckName.Text.ToLower() + ".json").Close();
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            openDeck.InitialDirectory = Directory.GetCurrentDirectory();          
            if(openDeck.ShowDialog() == DialogResult.OK)
            {
                loadDeck(openDeck.SafeFileName.Split('.')[0]);
            }            
        }
    }
}
