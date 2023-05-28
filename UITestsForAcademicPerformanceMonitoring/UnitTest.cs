using Avalonia.Controls;
using Avalonia.VisualTree;

namespace UITestsForAcademicPerformanceMonitoring
{
    public class UITestsForAcademicPerformanceMonitoring
    {
        [Fact]
        public async void add_student_in_listbox()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            var expected = "Eugene Flat";
            await Task.Delay(100);
            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First(t => t.Name == "TextBoxInput");
            var addButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "AddButton");
            textBox.Text = "Eugene Flat";
            addButton.Command.Execute(addButton.CommandParameter);
            await Task.Delay(50);
            var textBlock = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "TextBlockO");
            var result = textBlock.Text;
            Assert.True(result.Equals(expected));
        }
        [Fact]
        public async void delete_student_from_listbox()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First(t => t.Name == "TextBoxInput");
            var listBox = mainWindow.GetVisualDescendants().OfType<ListBox>().First();
            var listBoxItems = listBox.GetVisualDescendants().OfType<ListBoxItem>();
            var deleteButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "DeleteButton");
            var addButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "AddButton");
            textBox.Text = "Eugene Flat";
            addButton.Command.Execute(addButton.CommandParameter);
            listBox.SelectedIndex = 0;
            deleteButton.Command.Execute(deleteButton.CommandParameter);
            deleteButton.Command.Execute(deleteButton.CommandParameter);
            deleteButton.Command.Execute(deleteButton.CommandParameter);
            await Task.Delay(50);
            Assert.True(listBoxItems.Count() == 0);
        }
        [Fact]
        public async void add_two_students_and_delete_first_from_listbox()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First(t => t.Name == "TextBoxInput");
            var listBox = mainWindow.GetVisualDescendants().OfType<ListBox>().First();
            var listBoxItems = listBox.GetVisualDescendants().OfType<ListBoxItem>();
            var deleteButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "DeleteButton");
            var addButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "AddButton");
            textBox.Text = "Eugene Flat";
            addButton.Command.Execute(addButton.CommandParameter);
            listBox.SelectedIndex = 0;
            textBox.Text = "Eugene Flat";
            addButton.Command.Execute(addButton.CommandParameter);
            textBox.Text = "Eugene Flat";
            deleteButton.Command.Execute(deleteButton.CommandParameter);
            await Task.Delay(50);
            Assert.True(listBoxItems.Count() == 1);
        }
        [Fact]
        public async void add_two_students_and_save_file()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First(t => t.Name == "TextBoxInput");
            var listBox = mainWindow.GetVisualDescendants().OfType<ListBox>().First();
            var listBoxItems = listBox.GetVisualDescendants().OfType<ListBoxItem>();
            var deleteButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "DeleteButton");
            var addButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "AddButton");
            var saveButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "SaveButton");
            textBox.Text = "Eugene Flat";
            addButton.Command.Execute(addButton.CommandParameter);
            listBox.SelectedIndex = 0;
            textBox.Text = "Eugene Flat";
            saveButton.Command.Execute(saveButton.CommandParameter);
            await Task.Delay(50);
            Assert.True(listBoxItems.Count() == 2);
        }
    }
}