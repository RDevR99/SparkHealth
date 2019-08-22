import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { BehaviorSubject } from "rxjs";

@Injectable()
export class AuthService {
  private loggedIn: BehaviorSubject<boolean> = new BehaviorSubject<boolean>(
    false
  );

  constructor(private router: Router) {}

  get isLoggedIn() {
    return this.loggedIn.asObservable();
  }

  login() {
    this.loggedIn.next(true);
    this.router.navigate(["/dashboard"]);
  }

  logout() {
    this.loggedIn.next(false);
    this.router.navigate(["/login"]);
  }
}
