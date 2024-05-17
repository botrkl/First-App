import { CommonModule } from '@angular/common';
import { Component, Input } from '@angular/core';
import { AddCardModel } from '../models/addModels/add-card.model';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { CardService } from '../services/card.service';

@Component({
  selector: 'app-add-card',
  standalone: true,
  imports: [CommonModule,HttpClientModule,FormsModule],
  templateUrl: './add-card.component.html',
  styleUrl: './add-card.component.css',
  providers:[CardService]
})
export class AddCardComponent {
  addCardModel = new AddCardModel();
  showModal = false;

  constructor(private cardService: CardService) {}

  onSubmit() {
      this.cardService.addCard(this.addCardModel).subscribe(response => {
        console.log(response);
        location.reload();
      }, error => {
        console.error(error);
      });
  }

  openModal() {
    this.showModal = true;
  }

  closeModal() {
    this.showModal = false;
  }
}
