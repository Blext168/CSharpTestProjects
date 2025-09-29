namespace CreationalPatterns.Builder;

public class AddressBuilder
{
    private Address _address = new Address();

    public AddressBuilder WithName(string pName)
    {
        _address.Fullname = pName;
        return this;
    }
    
    public AddressBuilder WithStreet(string pStreet)
    {
        _address.Street = pStreet;
        return this;
    }
    
    public AddressBuilder WithZipCode(string pZipCode)
    {
        _address.ZipCode = pZipCode;
        return this;
    }
    
    public AddressBuilder WithCity(string pCity)
    {
        _address.City = pCity;
        return this;
    }
    
    public AddressBuilder WithState(string pState)
    {
        _address.State = pState;
        return this;
    }

    public Address Build()
    {
        return _address;
    }
}