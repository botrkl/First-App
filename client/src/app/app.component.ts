import { Component,Input } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {CardComponent} from '../app/card/card.component'
import { CommonModule} from '@angular/common';
import { ListComponent } from './list/list.component';
import { BoardComponent } from './board/board.component';
import { AddListComponent } from './add-list/add-list.component';
import { AddCardComponent } from './add-card/add-card.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,BoardComponent,AddListComponent,ListComponent,CardComponent, CommonModule,AddCardComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  providers: [],
})
export class AppComponent {
}
