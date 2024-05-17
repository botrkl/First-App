import { Component, OnInit } from '@angular/core';
import { ListComponent } from '../list/list.component';
import { BoardModel } from '../models/board.model';
import { CommonModule } from '@angular/common';
import { CardComponent } from '../card/card.component';
import { BoardService } from '../services/board.service';
import { HttpClientModule } from '@angular/common/http';
import { SidebarComponent } from '../sidebar/sidebar.component';
import { AddListComponent } from '../add-list/add-list.component';


@Component({
  selector: 'app-board',
  standalone: true,
  imports: [HttpClientModule,SidebarComponent,AddListComponent,ListComponent,CardComponent,CommonModule],
  templateUrl: './board.component.html',
  styleUrl: './board.component.css',
  providers:[BoardService]
})
export class BoardComponent implements OnInit{
    board = new BoardModel();
    showSidebar = false;

    constructor(private boardService: BoardService) {}
    ngOnInit(): void {
      this.boardService.getBoardData().subscribe((data) => {
        this.board.list = data;
      });
    }
}
