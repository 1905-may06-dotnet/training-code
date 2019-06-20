import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import CreateDeckResponse from './models/create-deck-response';
import { DrawCardResponse } from './models/draw-card-response';

@Injectable({
  providedIn: 'root'
})
export class CardsApiService {
  constructor(private http: HttpClient) { }

  private urlNewDeck = 'https://deckofcardsapi.com/api/deck/new/';

  private getUrlDrawDeck(deckid: string, count: number): string {
    return `https://deckofcardsapi.com/api/deck/${deckid}/draw/?count=${count}`;
  }

  private getUrlShuffle(deckid: string): string {
    return `https://cors.now.sh/https://deckofcardsapi.com/api/deck/${deckid}/shuffle`;
  }

  createDeck() {
    return this.http.get<CreateDeckResponse>(this.urlNewDeck)
      .toPromise();
  }

  drawDeck(deckid: string, count: number = 1) {
    return this.http.get<DrawCardResponse>(this.getUrlDrawDeck(deckid, count))
      .toPromise();
  }

  shuffleDeck(deckid: string) {
    // if promise resolves to success, it will be shuffled
    return this.http.get(this.getUrlShuffle(deckid)).toPromise();
  }
}
