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
//// ������: 
//// ����������� ������-��������� ������ ������ ���������
//// ��������� ������ ������������ ����������� ��� ������:
//// - 1 ����        (1000 ��)   
//// - ���������     (1 ��)
//// - ������        (3785,41 ��)
//// - ������ �����  (29,57 ��)
//// - ������ �����  (5 ��)
///
//// �� �������� ��-����-��-���

//// ����������� 2 �����������:
//// 1) /convert - ����������, ������� ��������� 3 ���������:
////      - �������� �������
////      - �������� ��� �����������
////      - ������� ������� ���������
//// 2) /supported-units - ����������, ������� ���������� ������ �������������� ����� ����������� �������

//// ������� �������� ����������, ������ �������� ������� ��������������.