tests/Azucarero.test.js
import Azucarero from '/src/Azucarero.js';
describe('Azucarero', () => {
 test('Debe reducir el azúcar disponible', () => {
 const azucarero = new Azucarero(10);
 azucarero.usarAzucar(3);
 expect(azucarero.azucarDisponible).toBe(7);
 });
 test('Debe lanzar error si no hay suficiente azúcar', () => {
 const azucarero = new Azucarero(2);
 expect(() => azucarero.usarAzucar(5)).toThrow("No hay suficiente azúcar");
 });
});