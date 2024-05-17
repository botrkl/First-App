import { Component, Input } from '@angular/core';
import { ListModel } from '../models/list.model';
import { CardComponent } from '../card/card.component';
import { CommonModule } from '@angular/common';
import { ListService } from '../services/list.service';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { UpdateListModel } from '../models/updateModels/update-list.model';
import { AddCardComponent } from '../add-card/add-card.component';

@Component({
  selector: 'app-list',
  standalone: true,
  imports: [CardComponent,CommonModule,HttpClientModule,FormsModule,AddCardComponent],
  templateUrl: './list.component.html',
  styleUrl: './list.component.css',
  providers:[ListService]
})
export class ListComponent {
    @Input() list! : ListModel;
    isEditing = false;
    editedTitle = '';

    constructor(private listService: ListService) {}

    editList(list:ListModel) {
      this.isEditing = true;
      this.editedTitle = list.title;
    }

    saveList(id:string) {
      let updateListModel = new UpdateListModel();
      updateListModel.id=id;
      updateListModel.title=this.editedTitle;
      this.isEditing = false;

      this.listService.updateList(updateListModel).subscribe(response => {
        console.log(response);
        location.reload();
      }, error => {
        console.error(error);
      });
    }

  deleteList(id:string){
    this.listService.deleteList(id).subscribe(response => {
      console.log(response);
      location.reload();
    }, error => {
      console.error(error);
    });
  }
}
