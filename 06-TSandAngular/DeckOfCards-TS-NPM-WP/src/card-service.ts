import CreateDeckResponse from './create-deck-response';
import {DrawCardResponse} from './draw-card-response';

export class CardService{
    private static urlNewDeck:string="https://deckofcardsapi.com/api/deck/new/";
    
    private static getUrlDrawDeck(deckid:string,count:number):string{
        return `https://deckofcardsapi.com/api/deck/${deckid}/draw/?count=${count}`;
    }
     
    createDeck():Promise<CreateDeckResponse>{
        return fetch(CardService.urlNewDeck)
        .then(function(response){
            return response.json();
        });
    }
    drawDeck(deckid:string, count:number=1):Promise<DrawCardResponse>{
        return fetch(CardService.getUrlDrawDeck(deckid,count))
        .then(res=>res.json())
        .catch(res=>res);
    }

}