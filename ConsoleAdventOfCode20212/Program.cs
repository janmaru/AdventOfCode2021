// See https://aka.ms/new-console-template for more information
using AdventOfCode2021.Models;
using ConsoleAdventOfCode20212.Models;

var demo = @"0,5";
string? input = FileHelper.Read(demo).ToList().FirstOrDefault();
var day = new Days7();
day.Parse(input);
var ma = day.CalculateProgressiveAlignment();
Helper.Print(ma);