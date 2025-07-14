src/Vaso.js
export default class Vaso {
 constructor() {
 this.tamanos = {
 pequeno: 3,
 mediano: 5,
 grande: 7,
 };
 }
getOunces(tamano) {
 const valor = this.tamanos[tamano.toLowerCase()];
 if (!valor) {

 throw new Error("Tamaño inválido");
 }
 return valor;
 }
}