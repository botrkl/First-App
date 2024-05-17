import { Component, EventEmitter, Output } from '@angular/core';
import { CardActivityModel } from '../models/card-activity.model';
import { HistoryService } from '../services/history.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-sidebar',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './sidebar.component.html',
  styleUrl: './sidebar.component.css',
  providers:[HistoryService]
})
export class SidebarComponent {
  @Output() close = new EventEmitter();
  activities! :CardActivityModel[];

  constructor(private boardService: HistoryService) {}

    ngOnInit(): void {
      this.boardService.getHistoryData().subscribe((data) => {
        this.activities = data;
      });
    }
}
