using Decorator;

IMailService cloudMailService = new StatisticsDecorator(
    new LoggingDecorator(
        new CloudMailService()
    )
);
cloudMailService.SendMail("Hola mundo!");

IMailService onPremiseMailService = new StatisticsDecorator(
    new LoggingDecorator(
        new OnPremiseMailService()
    )
);
onPremiseMailService.SendMail("Hola mundo on-premise!");