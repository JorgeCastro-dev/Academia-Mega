import { Component } from '@angular/core';

@Component({
  selector: 'app-card',
  imports: [],
  templateUrl: './card.component.html',
  styleUrl: './card.component.css'
})
export class CardComponent {
  title = "Esto es una card";
  contenido = "Este es el contenido de la card"
  botonText = "Ver mas"
  img = "https:picsum.photos/640/640?r" + Math.random()
}
