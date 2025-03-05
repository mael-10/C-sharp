# WPF Envorimental

## Understand development

* **Designer** - lets edit the user interface.<br>
* **Toolbox** - Has many visual controls to drag onto Designer<br>
* **Properties** - Show properties to selected designer.<br>
* **Error List** - Debugger console<br>
* **Using F9** - highlight the line<br>

## Getting Started
WPF (Windows Presentation Foundation) is a .NET framework tool for building graphical user interfaces (GUIs). It uses XAML for designing GUIs.

---

## XAML

- **`<StackPanel/>`**: Arranges elements vertically or horizontally.<br>
- **`<Button/>`**: Creates a clickable button.<br>
- **`<TextBlock/>`**: Similar to `<p></p>` in HTML, used for displaying text.<br>
- **`<Grid/>`**: Similar to HTML tables. Use `<ColumnDefinition/>` and `<RowDefinition/>` to automatically adjust layout to window size.<br>
- **TextWrapping**: To enable or disable text wrapping, expand the **Text section** in the properties panel and search for **TextWrapping**.<br>
    - `spanColumn and spanRow` spans columns and rows at arrange you want to set up (section layout).<br>
    - `TextBlock` put a name to the properties (like a dom object)<br>
- **``<listBox>`** Choose a list of items<br>
- **`<comboBox>`** combina uma `<listBox>` ´e um `<TextBlock/>`<br>
- **`Radio Button`**: let you restrict the user’s choice
- **`Sliders`**: Used exclusively to choose a number

---

## TextBlock

To access TextBlock go to Toobox -> TextBlock and drag to the Designer.

### Properties TextBlock

**Text** -- Show text displayed on screen<br>
**Horizontal Aligment** -- Justify left, right and centerM<br>
**VerticalAlignment** aligns it to the top, middle, or bottom of its box.<br>
**Margin** -- Margins to all sides like excel<br>
**TextWrapping** -- Add or not line break<br>

HAVE FIVE PROPERTIES<br>

### Set up

**Horizontal Aligment and VerticalAlignment** -- Click on TextLabel --> Layout section --> Center (or square --> reset)<br>
**Font** -- Click on TextLabel -- Text --> Font size<br>
**Change Text** -- Click on TextLabel --> common --> TextBlock<br>
**TextWrapping** -- Click on TextLabel --> Click on Search Box -- Search Wrap<br>

---

## TextBox

Text boxs are like an HTML's input

### Properties TextBox

-**TextChanged="numberTextBox_TextChanged"** is an *event handler* which the event handler is called as long as user continue to type.<br>
- **PreviewTextInput** will to only accept input that’s made up of numbers.<br>

//When you put properties

## Title

It's the windown title. To change it, click on title --> properties windows --> Common --> Title.

## Grid

Move your mouse over the left side of the window in the designer. <br>
When a plus appears over the cursor, click the mouse to add a row.<br>

### Make the rows and columns equal size

Click on `<ColumnDefinition/>` and `<RowDefinition/>` and --> Layout --> click Filled black square --> Reset<br>
Afterwards all rows and colums will be auto at height.
`
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

Event handler is a method that gets called when certain actions happen. Like click, double-click resize windown and so on. It's similar `to add.eventListener` Js property.<br>

`private void Button_Click(object sender, RoutedEventArgs e)`<br>
`{`<br>
    `// Handle button click event`<br>
`}`<br>

## Set up Event Handler

1- Click on textBlock --> Click on Event Handler (lightining button) in properies --> select the handle event<br>
2- To add event handler to all textBlocks at same time, select all and use `ctrl + h` to quick replace.<br>