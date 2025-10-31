using System;
using System.Collections.Generic;

namespace DesktopApplications.Models.Classes;

public class Recipe
{
    public string Name;
    public string Time;
    public List<string> ingredients = new List<string>();
    public List<string> steps = new List<string>();
}