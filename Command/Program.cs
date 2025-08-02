using Command;

var commandManager = new CommandManager();
var repository = new EmployeeManagerManagerRepository();

commandManager.Invoke(
    new AddEmployeeToManagerList(
        repository,
        1,
        new Employee(111, "John")
    )
);
repository.DataStore();

commandManager.Undo();
repository.DataStore();

commandManager.Invoke(
    new AddEmployeeToManagerList(
        repository,
        1,
        new Employee(222 ,"Carol")
    )
);
repository.DataStore();

commandManager.Invoke(
    new AddEmployeeToManagerList(
        repository,
        2,
        new Employee(333, "Alice Smith")
    )
);
repository.DataStore();

commandManager.UndoAll();
repository.DataStore();

