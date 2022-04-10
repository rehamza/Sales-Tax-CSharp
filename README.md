# Sales-Tax-CSharp

# For Live code testing link on Repl.it
https://replit.com/@hamzar1/Sales-Tax-C#main.cs

you can test the program live on repl using to click above link

# Assumption to solve a program

First I read out the problem statement carefully and identified the object or noun from the statement that I used in the program as classese
for examle 
Tax is the main class
using Tax classe I derived 2 more classes 1 is Basic tax on all goods except books , foods and medical
ans 2nd is Imported Duty class tax including on those items that is imported only
I also derived some other classes that play very important role in the program item parser data parse from description "1 book at 12.49"
Product 
Cart derived from baskets of items
and Finally print the receipt of data

I also searched on google to follow-up the best approach and I have experience on multiple Programming language such Javascript,Typescript,Python,C# and finally
I decided to implement in C# because its a strong OOP base programming language






# Problem description

Basic sales tax is applicable at a rate of 10% on all goods, except books, food, and medical
products that are exempt. Import duty is an additional sales tax
applicable on all imported goods at a rate of 5%, with no exemptions. When I purchase items
I receive a receipt which lists the name of all the items and their price (including tax),
finishing with the total cost of the items,
and the total amounts of sales taxes paid. The rounding rules for sales tax are that for a tax
rate of n%, a shelf price of p contains (np/100 rounded up to the nearest 0.05) amount of
sales tax.


Write an application that prints out the receipt details for these shopping baskets
