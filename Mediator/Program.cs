using Mediator;

TeamChatRoom teamChatRoom = new();
var steven = new Lawyer("Steven");
var kenneth = new Lawyer("kenneth");
var john = new AccountManager("John");

teamChatRoom.Register(steven);
teamChatRoom.Register(kenneth);
teamChatRoom.Register(john);
steven.Send("Hello everyone!");
teamChatRoom.Send("kenneth", "Hello Steven!");