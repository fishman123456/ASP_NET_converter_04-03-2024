using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/ping", () => "pong");

app.MapPost("/convert",([FromForm] string baseUnit, [FromForm] double value, [FromForm] string destUnit) =>
{
    int[] basis = new int[4];

    return $"received params baseUnit = {baseUnit}; value = {value}; destUnit = {destUnit};";

}).DisableAntiforgery();

app.Run();
//// ЗАДАЧА: 
//// Реализовать онлайн-конвертер единиц объема жидкостей
//// Конвертер должен поддерживать конвертацию для единиц:
//// - 1 литр        (1000 мл)   
//// - миллилитр     (1 мл)
//// - галлон        (3785,41 мл)
//// - жидкая унция  (29,57 мл)
//// - чайная ложка  (5 мл)
///
//// ПО ПРИНЦИПУ ИЗ-ВСЕХ-ВО-ВСЕ

//// Реализовать 2 обработчика:
//// 1) /convert - обработчик, который принимает 3 параметра:
////      - исходная единица
////      - значения для конвертации
////      - целевая единица измерения
//// 2) /supported-units - обработчик, который возвращает список поддерживаемых вашим конвертером величин

//// Способы передачи параметров, методы запросов выбрать самостоятельно.