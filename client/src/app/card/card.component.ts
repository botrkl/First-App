import { Component, Input } from '@angular/core';
import { cardModel } from '../models/cardModel';

@Component({
  selector: 'app-card',
  standalone: true,
  imports: [],
  templateUrl: './card.component.html',
  styleUrl: './card.component.css',
})
export class CardComponent {
  @Input() card!:cardModel;
}
