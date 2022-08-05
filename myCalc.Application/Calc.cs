using myCalc.api.DTOs;
using myCalc.Domain;

namespace myCalc.Application
{
    public class Calc : ICalc
    {
        public Result _result;
        public Calc(Result result)
        {
            _result = result;
        }
        public OperationInfoDTO operate(OperationInfo info)
        {
            _result.result = info.operationSignal switch
            {
                '+' => info.x + info.y,
                '-' => info.x - info.y,
                '*' => info.x * info.y,
                '/' => info.x / info.y,
                _ => throw new InvalidDataException("Insert a valid operator"),
            };
            return new OperationInfoDTO()
            {
                result = "Operation done! Go to the results route."
            };
        }

        double ICalc.getResult()
        {
            return _result.result;
        }
    }
}
