namespace Pizzeria.Persistence;

/// <summary>
/// Ошибки уровня инфраструктуры
/// </summary>
public class PersistenceException(string message) : Exception(message);

/// <summary>
/// Объект не найден 
/// </summary>
public class EntityNotFoundException<T>(object Identificator)
    : PersistenceException($"{typeof(T).GetType().FullName} '{Identificator}' not found!");










