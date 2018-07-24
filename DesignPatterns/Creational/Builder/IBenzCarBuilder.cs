namespace DesignPatterns.Creational.Builder
{
    public interface IBenzCarBuilder
    {
        BenzCar GetCar();
        IBenzCarBuilder WithBodywork(string bodywork);
        IBenzCarBuilder WithChassis(string chassis);
        IBenzCarBuilder WithElectricalEquipment(string electricalEquipment);
        IBenzCarBuilder WithMotor(string motor);
    }
}