using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel;

/// <summary>
/// Сохраняет текст в файл.
/// </summary>
public class SaveCommand : ICommand
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
        Contact contact = new Contact(_vm.Name, _vm.Email, _vm.Phone);
        _serializer.Save(contact);
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="SaveCommand"/>.
    /// </summary>
    /// <param name="mainVM">Экземпляр класса <see cref="MainVM"/>.</param>
    public SaveCommand(MainVM mainVM)
    {
        _vm = mainVM;
        _serializer = new ContactSerializer();
    }
}
