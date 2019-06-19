import {CardService} from './card-service';
export class Main{
    constructor(){}
    static Main(){
        var newDeck=<HTMLButtonElement>document.getElementById("newDeck");
        var drawCard=<HTMLButtonElement>document.getElementById("drawCard");
        var container=<HTMLDivElement>document.getElementById("container");
        var deckId:string;


        let service=new CardService();
        newDeck.addEventListener("click",()=>{
            service.createDeck()
            .then(res=>{
                drawCard.disabled=false;
                container.innerHTML='';
                deckId=res.deck_id;
                console.log(deckId);
            })
            .catch(console.log);
        });
        
        drawCard.onclick=()=>{
            service.drawDeck(deckId)
            .then(res=>{
                let image=<HTMLImageElement>document.createElement('img');
                image.src=res.cards[0].image;
                container.appendChild(image);
                console.log(res.cards[0].image);
            })
            .catch(console.log);
        };
    }
}
Main.Main();