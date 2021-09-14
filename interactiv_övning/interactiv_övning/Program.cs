using System;

Console.WriteLine("Du har vandrat i skogen i två timmar nu och letar efter en väg tillbaka till skogsbrynet där du gick in. Du hittar en stig och följer den tills den delar på sig. Väljer du att gå till Höger eller fortsätter du framåt? skriv ditt svar.");

string höger = Console.ReadLine();
string framåt = Console.ReadLine();

höger = höger.ToLower();
framåt = framåt.ToLower();

if (höger == "höger") {
    Console.WriteLine("Du går åt höger och följer denna stig tills du kommer till ytligare en delning av stigen. Väljer du att gå åt vänster eller höger? skriv ditt svar.");
}
if (framåt == "framåt") {
    Console.WriteLine("Du fortsätter framåt och kommer till ett gammalt hus. Du kan knacka på och se om någon är hemma eller gå förbi huset. Skriv ditt svar.");
}

string vänster = Console.ReadLine();
string höger2 = Console.ReadLine();

vänster = vänster.ToLower();
höger = höger.ToLower();

if (vänster == "vänster") {
    Console.WriteLine("Du går åt vänster och kommer tillbaka till där du började. Väljer du att gå åt höger eller frmåt? Skriv ditt svar");
}

