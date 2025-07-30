using ChainOfResponsability;

var level3SupportHandler = new Level3SupportHandler();
var level2SupportHandler = new Level2SupportHandler();
var level1SupportHandler = new Level1SupportHandler();

level1SupportHandler.SetNext(level2SupportHandler);
level2SupportHandler.SetNext(level3SupportHandler);

var ticket1 = new Ticket{Severity = Severity.Low};
var ticket2 = new Ticket{Severity = Severity.Medium};
var ticket3 = new Ticket{Severity = Severity.Medium};

level1SupportHandler.HandleTicket(ticket1);
level1SupportHandler.HandleTicket(ticket2);
level1SupportHandler.HandleTicket(ticket3);