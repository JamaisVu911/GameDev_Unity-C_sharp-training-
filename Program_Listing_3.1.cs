using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Listing_3._1
{
    class UsingIfDemo
    {
        static void Main(string[] args)
        {
            // Переменная для определения типа пиктограммы:

            MessageBoxIcon icon;

            // Переменные для определения текста сообщения, заголовка окна и имени пользователя;

            string msg, title, name;

            // Считывание имени пользователя:

            name = Interaction.InputBox(
                // Текст над полем ввода:
                "Как вас зовут? ",
                // Название окна:
                "Знакомисмя");
            // Првоверка введенного пользователем текста:

            if (name == "")
            {
                // Если текст не введен
                // Пиктограмма ошибки:
                icon = MessageBoxIcon.Error;
                // Текст сообщения:
                msg = "Очень жаль, что мы не познакомились!";
                // Заголовок окна:
                title = "Знакомство не состоялось";
            }

            else
            {
                // Если текст введен
                // Информационная пиктограмма:
                icon = MessageBoxIcon.Information;

                // Текст сообщения:
                msg = "Очень приятно, " + name + "!";
                // Заголовок окна:
                title = "Знакомство состоялось";
            }

            // Отображение сообщения (аргументы - текст сообщения, заголовок, кнопки и пиктограмма):
            MessageBox.Show(msg, title, MessageBoxButtons.OK, icon);
        }
    }
}
