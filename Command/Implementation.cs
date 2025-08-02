namespace Command;

public class Employee(int id, string name)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
}

public class Manager(int id, string name) : Employee(id, name)
{
    public List<Employee> Employees { get; set; } = [];
}

/// <summary>
/// Receiver (interface)
/// As I understand, it seems like a service that will be used by the command
/// </summary>
public interface IEmployeeManagerRepository
{
    void Add(int managerId, Employee employee);
    void Remove(int managerId, Employee employee);
    bool HasEmployee(int managerId, int employeeId);
    void DataStore();
}

/// <summary>
/// Receiver (implementation)
/// </summary>

public class EmployeeManagerManagerRepository : IEmployeeManagerRepository
{
    private readonly List<Manager> _managers = 
    [
        new (1, "Dylan"),
        new (2, "Werner")
    ];

    public void Add(int managerId, Employee employee)
    {
        var manager = _managers.FirstOrDefault(m => m.Id == managerId);
        manager?.Employees.Add(employee);
    }

    public void Remove(int managerId, Employee employee)
    {
        var manager = _managers.FirstOrDefault(m => m.Id == managerId);
        manager?.Employees.Remove(employee);
    }

    public bool HasEmployee(int managerId, int employeeId)
    {
        var manager = _managers.FirstOrDefault(m => m.Id == managerId);
        return manager?.Employees.Any(e => e.Id == employeeId) ?? false;
    }
    
    public void DataStore()
    {
        foreach (var manager in _managers)
        {
            Console.WriteLine($"Manager: {manager.Name} (ID: {manager.Id})");

            if (manager.Employees.Count == 0)
            {
                Console.WriteLine("  No employees assigned.");
                continue;
            }

            var empleados = string.Join(", ", manager.Employees.Select(e => $"{e.Name} (ID: {e.Id})"));
            Console.WriteLine($"  Employees: {empleados}");
        }
    }
}

/// <summary>
/// Command
/// </summary>
public interface ICommand
{
    void Execute();
    bool CanExecute();
}

/// <summary>
/// Concrete Command
/// </summary>
public class AddEmployeeToManagerList(
    IEmployeeManagerRepository employeeManagerRepository,
    int managerId,
    Employee? employee)
    : ICommand
{
    public bool CanExecute()
    {
        if (employee is null)
        {
            return false;
        }

        return !employeeManagerRepository.HasEmployee(managerId, employee.Id);
    }
    
    public void Execute()
    {
        if (employee is null)
        {
            return;
        }

        employeeManagerRepository.Add(managerId, employee);
    }
}

/// <summary>
/// Invoker
/// </summary>
public abstract class CommandManager
{
    public static void Invoke(ICommand command)
    {
        if (command.CanExecute())
        {
            command.Execute();
        }
    }
}



