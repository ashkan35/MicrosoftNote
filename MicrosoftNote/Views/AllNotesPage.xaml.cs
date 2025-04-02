using MicrosoftNote.ViewModels;

namespace MicrosoftNote.Views;
public partial class AllNotesPage : ContentPage
{
    public AllNotesPage()
    {
        InitializeComponent();
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        if (BindingContext is NotesViewModel model)
        {
            notesCollection.SelectedItem = null;
        }
    }
}