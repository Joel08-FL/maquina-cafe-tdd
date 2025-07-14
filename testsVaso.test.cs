tests/Vaso.test.js
import Vaso from '/src/Vaso.js';
describe('Vaso', () => {
 test('Debe entregar un vaso pequeño con 3 oz', () => {
 const vaso = new Vaso();
 expect(vaso.getOunces("pequeño")).toBe(3);
 });
 test('Debe lanzar error si tamaño no es válido', () => {
 const vaso = new Vaso();
 expect(() => vaso.getOunces("gigante")).toThrow("Tamaño inválido");
 });
});
