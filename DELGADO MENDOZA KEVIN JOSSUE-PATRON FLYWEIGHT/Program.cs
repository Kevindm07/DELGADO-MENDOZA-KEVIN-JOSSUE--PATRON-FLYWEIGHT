// Cliente
class Program
{
    static void Main(string[] args)
    {
        CaracterFlyweightFactory flyweightFactory = new CaracterFlyweightFactory();

        // Creamos una secuencia de caracteres con formatos diferentes
        List<char> caracteres = new List<char> { 'A', 'B', 'C', 'A', 'B' };

        // Mostramos los caracteres en diferentes posiciones
        int posicion = 0;
        foreach (char caracter in caracteres)
        {
            ICaracterFlyweight flyweight = flyweightFactory.ObtenerCaracter(caracter);
            flyweight.Mostrar(posicion);
            posicion++;
        }
    }
}