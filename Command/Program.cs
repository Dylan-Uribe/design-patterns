using Command;

var repository = new EmployeeManagerManagerRepository();

CommandManager.Invoke(
    new AddEmployeeToManagerList(
        repository,
        1,
        new Employee(111, "John")
    )
);
repository.DataStore();

CommandManager.Invoke(
    new AddEmployeeToManagerList(
        repository,
        1,
        new Employee(222 ,"Carol")
    )
);
repository.DataStore();

CommandManager.Invoke(
    new AddEmployeeToManagerList(
        repository,
        2,
        new Employee(333, "Alice Smith")
    )
);
repository.DataStore();

