import { Component, OnInit } from '@angular/core';
import {MatDialogRef} from '@angular/material';
import {MatFormFieldModule} from '@angular/material/form-field';
import {BookService} from 'src/app/api/book.service';
import { NgForm } from '@angular/forms';
import { Book } from 'src/app/models/book-model';

@Component({
  selector: 'app-add-book',
  templateUrl: './add-book.component.html',
  styleUrls: ['./add-book.component.css']
})
export class AddBookComponent implements OnInit {

  constructor(public dialogbox: MatDialogRef<AddBookComponent>,
              private service: BookService ) {}



  ngOnInit() {
  }


  resetForm() {

    this.service.formData = new Book();

    }

    saveBook() {
       this.service.addBook(this.service.formData).subscribe(res => {
         this.resetForm();
         alert(res);
       });
     }




    onClose() {
      this.dialogbox.close();
      this.service.filter('Register click');
    }



}
