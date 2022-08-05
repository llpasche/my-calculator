using Microsoft.AspNetCore.Mvc;
using myCalc.Domain;

namespace myCalc.api.Controllers;

[ApiController]
[Route("[controller]")]
public class Calculator : ControllerBase
{
    public readonly ICalc _calculator;
    public Calculator(ICalc calculator)
    {
        _calculator = calculator;
    }
    /// <summary>
    ///     This method does the operation based on the operation signal sent via body.
    /// </summary>
    /// <param name="x">first number</param>
    /// <param name="y">second number</param>
    /// <param name="operationSignal">operation signal</param>
    /// <returns>the sum of the two numbers</returns>
    [HttpPost("[action]")]
    public IActionResult Operate([FromBody] OperationInfo info)
    {
        return Ok(_calculator.operate(info));
    }
    
    /// <summary>
    ///     This method shows the operation result
    /// </summary>
    /// <returns>the result</returns>
    [HttpGet("[action]")]
    public IActionResult getResult()
    {
        return Ok(_calculator.getResult());
    }

}
