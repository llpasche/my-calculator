using myCalc.api.DTOs;
using myCalc.Domain;

public interface ICalc
{
    public OperationInfoDTO operate(OperationInfo info);

    public double getResult();
}