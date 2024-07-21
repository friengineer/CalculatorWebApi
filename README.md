# Calculator Web Api
A RESTful web API to perform arithmetic operations on supplied numbers.

## Requirements
- .NET 8
- Visual Studio ASP.NET and web development workload

## Usage
The API accepts HTTP POST requests that contain a JSON payload in the HTTP body with the below format where you can substitute the integers for your own values.
```json
{
    "firstNumber" : 24,
    "secondNumber" : 6
}
```

> [!NOTE]
> When running the solution in development mode on your own machine, ensure you run it using the HTTPS profile to allow requests to be sent using HTTPS to the endpoint

### Add
Add two integers together and return the result in a JSON response. Uses a HTTP POST request.

#### Path
`/Calculator/Add`

#### Example ran on localhost
Sending the example HTTP POST request in the [usage](#usage) section to `https://localhost:7126/Calculator/Add` returns the following response.
```json
{
    "result" : 30
}
```

### Subtract
Subtract the second integer from the first integer and return the result in a JSON response. Uses a HTTP POST request.

#### Path
`/Calculator/Subtract`

#### Example ran on localhost
Sending the example HTTP POST request in the [usage](#usage) section to `https://localhost:7126/Calculator/Subtract` returns the following response.
```json
{
    "result" : 18
}
```

### Multiply
Multiply two integers together and return the result in a JSON response. Uses a HTTP POST request.

#### Path
`/Calculator/Multiply`

#### Example ran on localhost
Sending the example HTTP POST request in the [usage](#usage) section to `https://localhost:7126/Calculator/Multiply` returns the following response.
```json
{
    "result" : 144
}
```

### Divide
Divide the first integer by the second integer and return the result in a JSON response. Uses a HTTP POST request.

#### Path
`/Calculator/Divide`

#### Example ran on localhost
Sending the example HTTP POST request in the [usage](#usage) section to `https://localhost:7126/Calculator/Divide` returns the following response.
```json
{
    "result" : 4
}
```
