import { Component, OnInit } from '@angular/core';
import { Http } from "@angular/http";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  public output: string;
  public first: string;
  public second: string;
  public third: string;
  constructor(private readonly httpService : Http) { }

  validateTriangle() {

    if (!this.validateData()) {
      return;
    }

    this.httpService.get("/api/values?first=" + this.first + "&second=" + this.second + "&third=" + this.third).subscribe(data => {
      this.output = "Result = " + data.text() as string;
    });
  }

  private validateData(): boolean {

    if (isNaN(parseInt(this.first, 10))) {
      this.output = "invalid data";
      return false;
    }

    if (isNaN(parseInt(this.second, 10))) {
      this.output = "invalid data";
      return false;
    }

    if (isNaN(parseInt(this.third, 10))) {
      this.output = "invalid data";
      return false;
    }
    return true;
  }

}
