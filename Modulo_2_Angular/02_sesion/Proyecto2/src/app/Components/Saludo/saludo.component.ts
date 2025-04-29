import { Component } from '@angular/core';
import { CardComponent } from "../card/card.component";

@Component({
    selector: 'app-saludo',
    imports: [CardComponent],
    templateUrl: './saludo.component.html',
    styleUrl: './saludo.component.css'
})

export class Saludo{
    name = "Jorge Castro"
}

