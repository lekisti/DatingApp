import { Component } from '@angular/core';

// decorator...
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html', // each component has template url.
  styleUrls: ['./app.component.css'] // and style url.
})
export class AppComponent {
  title = 'Dating';
}
