import { Component, Input } from '@angular/core';
import { CardModel } from '../models/card.model';
import { CommonModule } from '@angular/common';
import { CardService } from '../services/card.service';
import { HttpClientModule, HttpClientXsrfModule } from '@angular/common/http';
import { ListModel } from '../models/list.model';
import { ListService } from '../services/list.service';
import { UpdateCardModel } from '../models/updateModels/update-card.model';

@Component({
  selector: 'app-card',
  standalone: true,
  imports: [CommonModule,HttpClientXsrfModule],
  templateUrl: './card.component.html',
  styleUrl: './card.component.css',
  providers: [CardService,ListService]
})
export class CardComponent {
    @Input() card! : CardModel;
    list! : ListModel[];
    constructor(private cardService: CardService,private listService: ListService) {}
  
    ngOnInit(): void {
      this.listService.getAllList().subscribe((data) => {
        this.list = data;
      });
    }

    deleteCard(){
      this.cardService.deleteCard(this.card.id).subscribe(response => {
        console.log(response);
        location.reload();
      }, error => {
        console.error(error);
      });
    }
}
