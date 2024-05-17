import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { AddListModel } from '../models/addModels/add-list.model';
import { ListService } from '../services/list.service';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-add-list',
  standalone: true,
  imports: [CommonModule,HttpClientModule,FormsModule],
  templateUrl: './add-list.component.html',
  styleUrl: './add-list.component.css',
  providers:[ListService]
})
export class AddListComponent {
    listTitle: string = '';
    addListModel = new AddListModel();
    isModalVisible = false;
    
    constructor(private listService: ListService) {}

    addList(title:string) {
      this.addListModel.title = title;
      this.listService.addList(this.addListModel).subscribe(response => {
        console.log(response);
        location.reload();
      }, error => {
        console.error(error);
      });
    }
}
