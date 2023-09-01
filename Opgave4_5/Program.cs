using Opgave4_5;
using static Opgave4_5.Card;


Cardgame game = new Cardgame(1);

Cardgame game2 = new Cardgame(0);

game.filterCardGame(FilterByKlør);



//FILTERS
static bool filterBy2(Card card)
{
    if (card.number == Number.TWO)
    {
        return true;
    }
    return false;
}

static bool FilterByKlør(Card card)
{
    if (card.suit == Suit.CLUBS)
        return true;
    else
        return false;

}