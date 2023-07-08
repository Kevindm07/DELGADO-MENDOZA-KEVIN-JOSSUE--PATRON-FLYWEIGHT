// FlyweightFactory: Crea y administra los objetos flyweight
class CaracterFlyweightFactory
{
    private readonly Dictionary<char, ICaracterFlyweight> _flyweights = new Dictionary<char, ICaracterFlyweight>();
    
    public ICaracterFlyweight ObtenerCaracter(char clave)
    {
        if (_flyweights.ContainsKey(clave))
        {
            return _flyweights[clave];
        }
        else
        {
            ICaracterFlyweight flyweight = new CaracterFlyweight(clave);
            _flyweights.Add(clave, flyweight);
            return flyweight;
        }
    }
}