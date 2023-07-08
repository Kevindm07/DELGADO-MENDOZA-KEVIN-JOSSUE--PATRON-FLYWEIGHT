// Flyweight concreto: Implementa la interfaz flyweight y almacena el estado intrínseco compartido
class CaracterFlyweight : ICaracterFlyweight
{
    private readonly char _caracter;
    
    public CaracterFlyweight(char caracter)
    {
        _caracter = caracter;
    }
    
    public void Mostrar(int posicion)
    {
        Console.WriteLine($"Caracter '{_caracter}' mostrado en la posición {posicion}");
    }
}