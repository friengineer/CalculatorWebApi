# Calculator Web Api
A RESTful web API to perform arithmetic operations on supplied numbers.

## Requirements
- .NET 8
- Visual Studio ASP.NET and web development workload

## Usage

### Add
Add two integers together and return the result in a JSON response. Uses a HTTP GET request.

#### Path
`/Calculator/add?firstNumber=<x>&secondNumber=<y>` where `<x>` and `<y>` are integers.

#### Example ran on localhost
A request of `https://localhost:7126/Calculator/add?firstNumber=24&secondNumber=6` returns the following response.
```json
{
    "result" : 30
}
```

### Subtract
Subtract the second integer from the first integer and return the result in a JSON response. Uses a HTTP GET request.

#### Path
`/Calculator/subtract?firstNumber=<x>&secondNumber=<y>` where `<x>` and `<y>` are integers.

#### Example ran on localhost
A request of `https://localhost:7126/Calculator/subtract?firstNumber=24&secondNumber=6` returns the following response.
```json
{
    "result" : 18
}
```

