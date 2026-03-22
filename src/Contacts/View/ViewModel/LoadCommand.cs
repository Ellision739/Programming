using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel;

/// <summary>
/// Загружает текст из файла.
/// </summary>
public class LoadCommand : ICommand
{
    /// <inheritdoc />
    private readonly MainVM _vm;

    /// <inheritdoc />
    private readonly ContactSerializer _serializer;

    /// <summary>
    /// Проверяет, может ли команда выполниться.
    /// </summary>
    /// <param name="parameter">Данные, передаваемые командой.</param>
    /// <returns>Всегда True.</returns>
    public bool CanExecute(object parameter)
    { return true; }

    /// <summary>
    /// Происходит при изменении состояния команды.
    /// </summary>
    public event EventHandler CanExecuteChanged;

    /// <summary>
    /// Подписывает событие на изменение свойства.
    /// </summary>
    public void RaiseCanExecuteChanged()
    {
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }

    /// <summary>
    /// Выполняет логику команды.
    /// </summary>
    /// <param name="parameter">Данные, передаваемые командой.</param>
    public void Execute(object parameter)
    {
        Contact contact = _serializer.Load();
        _vm.Name = contact.Name;
        _vm.Email = contact.Email;
        _vm.Phone = contact.Phone;
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="LoadCommand"/>.
    /// </summary>
    /// <param name="mainVM">Экземпляр класса <see cref="MainVM"/>.</param>
    public LoadCommand(MainVM mainVM)
    {
        _vm = mainVM;
        _serializer = new ContactSerializer();
    }
}
