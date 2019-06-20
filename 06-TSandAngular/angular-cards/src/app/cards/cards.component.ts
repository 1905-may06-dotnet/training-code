import { Component, OnInit, Input } from '@angular/core';
import { CardsApiService } from '../cards-api.service';

@Component({
  selector: 'app-cards',
  templateUrl: './cards.component.html',
  styleUrls: ['./cards.component.css']
})
export class CardsComponent implements OnInit {

  deckId: string;

  @Input()
  textFromInput: string;

  constructor(private cardService: CardsApiService) { }

  newDeck(
    drawCardButton: HTMLButtonElement,
    shuffleButton: HTMLButtonElement,
    cardContainer: HTMLDivElement)
  {
    this.cardService.createDeck().then(res => this.deckId = res.deck_id);
    drawCardButton.disabled = false;
    shuffleButton.disabled = false;
    cardContainer.innerHTML = '';
    // should catch and show good error message
  }

  drawCard(cardContainer: HTMLDivElement)
  {
    this.cardService.drawDeck(this.deckId, 1).then(res => {
      let img = document.createElement('img');
      img.src = res.cards[0].image;
      cardContainer.appendChild(img);
    });
    // should catch and show good error message
  }

  shuffle() {
    this.cardService.shuffleDeck(this.deckId).then();
  }

  ngOnInit() {
  }

}
