﻿using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"\tShares: {productShares:N3} Product");
Console.WriteLine($"\t\tSubtotal: {subtotal:C}");
Console.WriteLine($"\t\t\tTax Percentage: {taxPercentage:P3}");
Console.WriteLine($"\t\t\t\tTotal Billed: {total:C}");