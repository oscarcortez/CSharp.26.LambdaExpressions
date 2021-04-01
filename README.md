# CSharp.26.LambdaExpressions

lambda function: es una nomenclatura para crear metodos anonimos: func, action, predicate

puede tener un parameter x=>..., mas de uno: (x,y)=> o ninguno: ()

el operador => ejecuta la expresion

```csharp
Predicate<int> MayorDeEdad = edad => edad >= 18;
```
