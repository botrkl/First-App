import { Component, OnInit, ContentChild } from '@angular/core';
import { BoardService } from '../services/boardService';
import { HttpClientModule } from '@angular/common/http';
import { ListComponent } from '../list/list.component';
import { CommonModule } from '@angular/common';
import { listOfCardModel } from '../models/listOfCardModel';

@Component({
  selector: 'app-board',
  standalone: true,
  imports: [HttpClientModule,ListComponent,CommonModule],
  templateUrl: './board.component.html',
  styleUrls: ['./board.component.css'],
  providers:[BoardService],
})
export class BoardComponent implements OnInit{
  title="My Task Board";
  board!: listOfCardModel[];
  constructor(private boardService: BoardService) {}
  ngOnInit(): void {
    this.boardService.getBoardData().subscribe((data) => {
      this.board = data;
    });
  }
}