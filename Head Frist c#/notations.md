# WPF Envorimental

## Getting Started
WPF (Windows Presentation Foundation) is a .NET framework tool for building graphical user interfaces (GUIs). It uses XAML for designing GUIs.

## XAML

- **`<StackPanel/>`**: Arranges elements vertically or horizontally.
- **`<Button/>`**: Creates a clickable button.
- **`<TextBlock/>`**: Similar to `<p></p>` in HTML, used for displaying text.
- **`<Grid/>`**: Similar to HTML tables. Use `<ColumnDefinition/>` and `<RowDefinition/>` to automatically adjust layout to window size.
- **TextWrapping**: To enable or disable text wrapping, expand the **Text section** in the properties panel and search for **TextWrapping**.

## Methods

### What's a Method?

Method is a piece of code that when one is called, it runs a block of code.

### Auto Method

When adding a method, a light bulb icon appears on the left side of the window. Clicking it shows a context menu with actions. If an action generates code, a preview is shown.

Example:

`private void SetUpGame()`<br>
`{`<br>
    `throw new NotImplementedException();`<br>
`}`<br>

## Event Handler

Event handler is a method that gets called when certain actions happen. Like click, double-click resize windown and so on. It's similar `to add.eventListener` Js property.

`private void Button_Click(object sender, RoutedEventArgs e)`
`{`
    ``// Handle button click event`
`}`