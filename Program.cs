using ConsoleApp.Modules;

var number = InputModule.ReadInt("Введите число: ");
var array = InputModule.ReadArray("Введите массив");

if (ValidationModule.IsValid(number, array))
{
    ProcessingModule.ProcessData(number, array);
}