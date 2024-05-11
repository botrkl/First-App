import { Component, ContentChild, Input } from '@angular/core';
import { listOfCardModel } from '../models/listOfCardModel';
import { CardComponent } from '../card/card.component';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-list',
  standalone: true,
  imports: [CardComponent,CommonModule],
  templateUrl: './list.component.html',
  styleUrl: './list.component.css'
})
export class ListComponent {
  @Input() listOfCard!:listOfCardModel;
  showMenu = false;

  toggleMenu() {
    this.showMenu = !this.showMenu;
  }

  editCard() {
  }

  deleteCard() {
  }
}
