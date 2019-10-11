using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegelSpil
{
    public partial class Form1 : Form
    {
        Deck deck;
        public Form1()
        {
            InitializeComponent();
            lblDrawnCard.Text = "Start nyt spil";
            lblCardsLeft.Text = "Ingen kort";
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            lstvwPlayers.Items.Add(txtbxAddPlayer.Text);
            txtbxAddPlayer.Clear();
        }

        private void tsmStartNew_Click(object sender, EventArgs e)
        {
            if (deck != null)
                deck.OnCardDrawn -= Deck_OnCardDrawn;

            deck = new Deck();
            deck.OnCardDrawn += Deck_OnCardDrawn;
            btnDrawCard.Enabled = true;
            lblCardsLeft.Text = $"{deck.Count} kort tilbage";
        }

        private void Deck_OnCardDrawn(object sender, Deck.CardDrawnEventArgs args)
        {
            btnDrawCard.Enabled = args.CardsLeft > 0;

            lblCardsLeft.Text = $"{args.CardsLeft} kort tilbage";
            imgDrawCard.Image = (Image)Properties.Resources.ResourceManager.GetObject(args.DrawnCard.ImageName);
            string result = GetString("Stiig", args.DrawnCard);
            lblDrawnCard.Text = $"{result}";
            rtxtbxHistory.Text = result + "\n" + rtxtbxHistory.Text;
        }

        private void btnDrawCard_Click(object sender, EventArgs e)
        {
            deck.DrawCard();
        }

        public string GetString(string player, Card card)
        {
            if (card.Color != Card.CardColor.Joker)
                return $"{player} trak {card.GetColor} {card.GetValue}";
            else
                return $"{player} trak en Joker";
        }
    }
}