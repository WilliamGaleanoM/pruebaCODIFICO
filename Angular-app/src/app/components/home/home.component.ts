import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { GithubService } from '../../services/github.service';
import { User } from '../../models/user.model';
import { filter, switchMap, debounceTime, catchError } from 'rxjs/operators';
import { EMPTY } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private githubService: GithubService) { }
  searchControl = new FormControl();  
  error: boolean = false;
  user!: User;

  ngOnInit(): void {
   
  }

  buscarUser(event: Event){
    this.githubService.getUser(this.searchControl.value)
    .pipe(
      catchError(err => {
        this.error = true;
        return EMPTY;
      })
    ).subscribe(user => {
      this.user = user;
      this.error = false;
    });   
  }


}
