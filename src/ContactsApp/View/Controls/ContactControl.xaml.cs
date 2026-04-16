using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace View.Controls;

/// <summary>
/// Логика взаимодействия для ContactControl.xaml.
/// </summary>
public partial class ContactControl : UserControl
{
    /// <summary>
    /// Проверяет, разрешен ли вводимый текст.
    /// </summary>
    /// <param name="text">Текст для проверки.</param>
    /// <returns>True, если текст разрешен, иначе False.</returns>
    private bool IsTextAllowed(string text)
    {
        return text.All(c => char.IsDigit(c) || "+()- ".Contains(c));
    }
    
    /// <summary>
    /// Обрабатывает событие предварительного ввода текста в текстовое поле телефона.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private void PhoneTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
    {
        e.Handled = !IsTextAllowed(e.Text);
    }

    /// <summary>
    /// Обрабатывает событие вставки текста в текстовое поле телефона.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private void PhoneTextBox_Pasting(object sender, DataObjectPastingEventArgs e)
    {
        if (e.DataObject.GetDataPresent(DataFormats.Text))
        {
            string text = (string)e.DataObject.GetData(DataFormats.Text);

            if (!IsTextAllowed(text))
            {
                e.CancelCommand();
            }
        }
        else
        {
            e.CancelCommand();
        }
    }

    public ContactControl()
    {
        InitializeComponent();
    }
}
