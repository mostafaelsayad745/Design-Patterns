﻿using Adapter;

Console.Title = "Adapter";

ICityAdapter adapter = new cityAdapter();
var city = adapter.GetCity();

Console.WriteLine($"{city.FullName} , {city.Inhibtants}");
