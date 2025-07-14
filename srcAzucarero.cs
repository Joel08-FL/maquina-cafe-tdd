src/Azucarero.js
export default class Azucarero {
 constructor(cantidadInicial = 20) {
 this.azucarDisponible = cantidadInicial;
 }
 usarAzucar(cucharadas) {
 if (this.azucarDisponible < cucharadas) {
 throw new Error("No hay suficiente azúcar");
 }
 this.azucarDisponible -= cucharadas;
 }
}